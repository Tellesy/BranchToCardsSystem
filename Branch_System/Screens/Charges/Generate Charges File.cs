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

            SettlementsFiles.GenerateTemplateSpreadsheet(fileName, dataTable);
            

        }

        private List<Charge> GetCharges()
        {
            List<Charge> charges = new List<Charge>();

            var sBranch = PTSBranchController.getBranch(int.Parse(Database.Login.branch));
            if (!sBranch.status)
            {
                MessageBox.Show("There is an issue related to getting Branch Code");
                return null;
            }
            var cstatus = MPBS.Database.ChargeController.getUngenCharges(sBranch.Object.Code);
           
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
            List<string> headers = new List<string>();
            headers.Add("ID");
            headers.Add("LYD Account Number");
            headers.Add("Currency Account Number");
            headers.Add("Amount");
            headers.Add("Currency");
            headers.Add("Exchange Rate");
            headers.Add("Value Date");
            headers.Add("Program Code");

            headers.Add("Waive Flag");




            dataTable.Add(headers);
          
            foreach (var l in loads)
            {
                List<string> cols = new List<string>();
                var astatus = PTSAccountController.getAccount(l.CustomerID.ToString(), l.ProgramCode);
                if (astatus.status && astatus.Object != null)
                {
               
                    cols.Add(l.ID.ToString());

                    cols.Add(astatus.Object.AccountNumberLYD);
                    cols.Add(astatus.Object.AccountNumberCurrency);
                    cols.Add(l.Amount.ToString());
                    cols.Add("USD");
                    cols.Add(l.ExchangeRate.ToString());
                    string dString = string.Format(date.Day + @"/" + date.Month + @"/" + date.Year);
                    cols.Add(dString);
                    cols.Add(l.ProgramCode);
                    //Decide to waive the charge or not
                    //If it is already in genCharges list then waive 
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
                                genCharges.Add(c);
                            }
                           // //Dobule check if you did not already taken the charge 
                           //var cResults = genCharges.FindAll(i => i.CustomerID == c.CustomerID);
                           // if(cResults.Count>0)
                           // {
                           //     var cResult = cResults.First(x => x.ProgramCode == c.ProgramCode);
                           //     if (cResult != null)
                           //     {
                           //         cols.Add("Waive");
                           //     }
                           //     else
                           //     {
                           //         genCharges.Add(c);
                           //     }
                           // }
                           // else
                           // {
                           //     genCharges.Add(c);
                           // }
                           
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

            SettlementsFiles.GenerateTemplateSpreadsheet(fileName, dataTable);
        }
    }
}
