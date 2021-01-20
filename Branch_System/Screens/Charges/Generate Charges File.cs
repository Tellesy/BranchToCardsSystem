using MPBS.Database;
using MPBS.Database.Objects;
using MPBS.SpreadSheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.Charges
{
    public partial class GenerateChargesFiles : MaterialSkin.Controls.MaterialForm
    {
        private string ChargeCreditAccount = "PL52120";
        public GenerateChargesFiles()
        {
            InitializeComponent();
        }

        private void Generate_Charges_File_Load(object sender, EventArgs e)
        {

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateCardIssuingChargesFile_BTN_Click(object sender, EventArgs e)
        {
            var charges = GetCharges();
            List<Charge> generatedCharges = new List<Charge>();
            if(charges.Count() == 0)
            {
                MessageBox.Show("لا يوجد عمولات جديدة");
                return;
            }


            var date = DateTime.Now;


            List<List<string>> dataTable = new List<List<string>>();
            List<string> headers = new List<string>();
            headers.Add("Account Number");
            headers.Add("Value Date");

            dataTable.Add(headers);
            List<string> cols = new List<string>();
            foreach(var c in charges)
            {
                var astatus = PTSAccountController.getAccount(c.CustomerID.ToString(), c.ProgramCode);
                if(astatus.status && astatus.Object != null)
                {
                    cols.Add(astatus.Object.AccountNumberLYD);
                   
                    string dString = string.Format(date.Day + @"/" + date.Month + @"/"+ date.Year);
                    cols.Add(dString);
                    generatedCharges.Add(c);
                }
            }
            dataTable.Add(cols);


            string fileName = "CardsChargesFile-"+ date.Day.ToString().PadLeft(2,'0') + date.Month.ToString().PadLeft(2, '0') + date.Year.ToString() + date.Hour.ToString().PadLeft(2, '0') + date.Minute.ToString().PadLeft(2, '0') + date.Millisecond.ToString().PadLeft(2, '0');

            SettlementsFiles.GenerateTemplateSpreadsheet(fileName, dataTable,true);
            

        }

        private List<Charge> GetCharges()
        {
            List<Charge> charges = new List<Charge>();

            //var sBranch = PTSBranchController.getBranch(int.Parse(Database.Login.branch));
            //if (!sBranch.status)
            //{
            //    MessageBox.Show("There is an issue related to getting Branch Code");
            //    return null;
            //}
            var cstatus = MPBS.Database.ChargeController.getUngenCharges(Database.Login.branch);
           
            if(cstatus.status)
            {
                charges = cstatus.Object;
            }

            return charges;
        }

        private void GenerateLoadFile_BTN_Click(object sender, EventArgs e)
        {
            var charges = GetCharges();

            List<Charge> genCharges = new List<Charge>();
            List<PTSLoad> genLoads = new List<PTSLoad>();
            List<PTSLoad> loads = new List<PTSLoad>();
            var sBranch = PTSBranchController.getBranch(int.Parse(Database.Login.branch));
            if (!sBranch.status)
            {
                MessageBox.Show("There is an issue related to getting Branch Code");
                return;
            }

            var lstatus = PTSLoadController.getCBSLoadRecords(sBranch.Object.Code);
            if(lstatus.status)
            {
                loads = lstatus.Object;
            }
            else
            {
                MessageBox.Show(lstatus.message);
                return;
            }

            var date = DateTime.Now;


            List<List<string>> dataTable = new List<List<string>>();

            //Set Headers
            List<string> headers = new List<string>();
            headers.Add("Record ID");
            headers.Add("LYD Account Number");
            headers.Add("Currency Account Number");
            headers.Add("Amount");
            headers.Add("Currency");
            headers.Add("Exchange Rate");
            headers.Add("Value Date");
            headers.Add("Program Code");
            headers.Add("Waive Flag");

            //Add headers to dataTable
            dataTable.Add(headers);
          
            //Add coloums 
            foreach (var l in loads)
            {
                List<string> cols = new List<string>();
                var astatus = PTSAccountController.getAccount(l.CustomerID.ToString(), l.ProgramCode);
                if (astatus.status && astatus.Object != null)
                {
               
                    //Add record ID
                    cols.Add(l.ID.ToString());
                    //Account number (Debit)
                    cols.Add(astatus.Object.AccountNumberLYD);
                    //Account number (Credit)
                    cols.Add(astatus.Object.AccountNumberCurrency);
                    //Load Amount
                    cols.Add(l.Amount.ToString());
                    //Currency
                    cols.Add("USD");
                    //Exchange rate from Credit to Debit
                    cols.Add(l.ExchangeRate.ToString());
                    //Value Date
                    string dString = string.Format(date.Day + @"/" + date.Month + @"/" + date.Year);
                    cols.Add(dString);
                    //Add Program Code
                    cols.Add(l.ProgramCode);

                    //Waive charge in case the charge was already collected 
                    //If it is already in genCharges list then waive 

                    //Get the untaken charges 
                    var resutls = charges.FindAll(i => i.CustomerID == int.Parse(l.CustomerID));
                    if(resutls.Count > 0)
                    {
                       var c = resutls.Find(x => x.ProgramCode == l.ProgramCode);
                        if (c != null)
                        {
                            if(genCharges.Contains(c))
                            {
                                cols.Add("Waive");
                            }
                            else
                            {
                                //Keep Empty and add it genCharges to mark and generated charge
                                genCharges.Add(c);
                            }
                           
                        }
                        else
                        {
                            cols.Add("Waive");
                        }
                    }
                    else
                    {
                        cols.Add("Waive");
                    }


                    genLoads.Add(l);
                }

                dataTable.Add(cols);

            }
           


            string fileName = "CBSLoadFile-" + date.Day.ToString().PadLeft(2, '0') + date.Month.ToString().PadLeft(2, '0') + date.Year.ToString() + date.Hour.ToString().PadLeft(2, '0') + date.Minute.ToString().PadLeft(2, '0') + date.Millisecond.ToString().PadLeft(2, '0');

            SettlementsFiles.GenerateTemplateSpreadsheet(fileName, dataTable,true);

            //Now make the taken charges as generated and load gen Loads in DB
            
            foreach(var l in genLoads)
            {
               var genLoadStatus = PTSLoadController.genCBSLoadRecords(l.ID);
                if(!genLoadStatus.status)
                {
                    MessageBox.Show("Error in Load record " + l.ID);
                }
            }

            foreach (var c in genCharges)
            {
                var genChargeStatus = ChargeController.genCharge(c.ID);
                if (!genChargeStatus.status)
                {
                    MessageBox.Show("Error in Charge record " + c.ID);
                }
            }

        }

        private void LoadAndIssueFile_BTN_Click(object sender, EventArgs e)
        {
            var charges = GetCharges();

            List<Charge> genCharges = new List<Charge>();
            List<PTSLoad> genLoads = new List<PTSLoad>();
            List<PTSLoad> loads = new List<PTSLoad>();
            var sBranch = PTSBranchController.getBranch(int.Parse(Database.Login.branch));
            if (!sBranch.status)
            {
                MessageBox.Show("There is an issue related to getting Branch Code");
                return;
            }

            var lstatus = PTSLoadController.getCBSLoadRecords(sBranch.Object.Code);
            if (lstatus.status)
            {
                loads = lstatus.Object;
            }
            else
            {
                MessageBox.Show(lstatus.message);
                return;
            }

            var date = DateTime.Now;


            List<List<string>> dataTable = new List<List<string>>();

            //Set Headers
            //List<string> headers = new List<string>();
            //headers.Add("Record ID");
            //headers.Add("LYD Account Number");
            //headers.Add("Currency Account Number");
            //headers.Add("Amount");
            //headers.Add("Currency");
            //headers.Add("Exchange Rate");
            //headers.Add("Value Date");
            //headers.Add("Program Code");
            //headers.Add("Issue Charge");
            //headers.Add("FT Type");


            ////Add headers to dataTable
            //dataTable.Add(headers);

            //Add coloums 
            foreach (var l in loads)
            {
                List<string> cols = new List<string>();
                var astatus = PTSAccountController.getAccount(l.CustomerID.ToString(), l.ProgramCode);
                if (astatus.status && astatus.Object != null)
                {

                    //Add record ID
                    cols.Add(l.ID.ToString());
                    //Account number (Debit)
                    cols.Add(astatus.Object.AccountNumberLYD);
                    //Account number (Credit)
                    cols.Add(astatus.Object.AccountNumberCurrency);
                    //Load Amount
                    cols.Add(l.Amount.ToString());
                    //Currency
                    cols.Add("USD");
                    //Exchange rate from Credit to Debit
                    cols.Add(l.ExchangeRate.ToString());
                    //Value Date
                    string dString = string.Format(date.Year.ToString() + date.Month.ToString().PadLeft(2,'0') + date.Day.ToString().PadLeft(2, '0'));
                    cols.Add(dString);
                    //Add Program Code
                    cols.Add(l.ProgramCode);

                    //Don't waive load charge 
                    cols.Add("");
                    //Type
                    cols.Add("ACMC");
                    //Desc
                    cols.Add("");
                    //FT Type
                    cols.Add("Load");
                  


                    genLoads.Add(l);
                }

                dataTable.Add(cols);

            }

            foreach (var c in charges)
            {
                List<string> cols = new List<string>();
                //ID
                cols.Add(c.ID.ToString());
                var astatus = PTSAccountController.getAccount(c.CustomerID.ToString(), c.ProgramCode);
                if (astatus.status && astatus.Object != null)
                {
                    
                    //LYD Account
                    cols.Add(astatus.Object.AccountNumberLYD);

                }
                //Credit account
                cols.Add(ChargeCreditAccount);
                //Amount
                cols.Add("150");
                //Currency
                cols.Add("LYD");
                //Exchange rate
                cols.Add("0");
                //Value Date
                string dString = string.Format(date.Year.ToString() + date.Month.ToString().PadLeft(2, '0') + date.Day.ToString().PadLeft(2, '0'));
                cols.Add(dString);
                //Program Code
                cols.Add(c.ProgramCode);
                //headers.Add("Waive Flag");
                cols.Add("CARDMAIN");
                //Type
                cols.Add("ACCI");
                //Desc
                cols.Add("Travel Card Issuing Charge");
                //FT Type
                cols.Add("Issue");

           

                genCharges.Add(c);
                dataTable.Add(cols);

            }

            string fileName = "CBSLoadAndIssueFile-" + date.Day.ToString().PadLeft(2, '0') + date.Month.ToString().PadLeft(2, '0') + date.Year.ToString() + date.Hour.ToString().PadLeft(2, '0') + date.Minute.ToString().PadLeft(2, '0') + date.Millisecond.ToString().PadLeft(2, '0');

            SettlementsFiles.GenerateTemplateSpreadsheet(fileName, dataTable,true);

            //Now make the taken charges as generated and load gen Loads in DB

            foreach (var l in genLoads)
            {
                var genLoadStatus = PTSLoadController.genCBSLoadRecords(l.ID);
                if (!genLoadStatus.status)
                {
                    MessageBox.Show("Error in Load record " + l.ID);
                }
            }

            foreach (var c in genCharges)
            {
                var genChargeStatus = ChargeController.genCharge(c.ID);
                if (!genChargeStatus.status)
                {
                    MessageBox.Show("Error in Charge record " + c.ID);
                }
            }

        }
    }
}
