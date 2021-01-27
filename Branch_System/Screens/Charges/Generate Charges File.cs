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

       

        private List<Charge> GetCharges()
        {
            List<Charge> charges = new List<Charge>();

            //var sBranch = PTSBranchController.getBranch(int.Parse(Database.Login.branch));
            //if (!sBranch.status)
            //{
            //    MessageBox.Show("There is an issue related to getting Branch Code");
            //    return null;
            //}

            //Get The the branch
            var bStatus = MPBS.Database.PTSBranchController.getBranch(int.Parse(Database.Login.branch));
            if(!bStatus.status)
            {
                MessageBox.Show("Error Getting Branch Code");
                return null;
            }

            var cstatus = MPBS.Database.ChargeController.getUngenCharges(bStatus.Object.Code);
           
            if(cstatus.status)
            {
                charges = cstatus.Object;
            }

            return charges;
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
                    //Add Profit Margin 
                    l.ExchangeRate = (decimal)(decimal.ToDouble(l.ExchangeRate) + (decimal.ToDouble(l.ExchangeRate) * 0.0025));
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
                else
                {

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
                cols.Add("70");
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
                cols.Add("Travel Card");
                //FT Type
                cols.Add("Issue");

           

                genCharges.Add(c);
                dataTable.Add(cols);

            }

            //string fileName = "CBSLoadAndIssueFile-" + date.Day.ToString().PadLeft(2, '0') + date.Month.ToString().PadLeft(2, '0') + date.Year.ToString() + date.Hour.ToString().PadLeft(2, '0') + date.Minute.ToString().PadLeft(2, '0') + date.Millisecond.ToString().PadLeft(2, '0');

            string location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CBL Load Files\" + sBranch.Object.Code;
            string folder = DateTime.Now.ToString("dd-MM-yyyy");
            string fileName = "CBL Load File " + DateTime.Now.ToString("dd-MM-yyyy-hhmmss");
            System.IO.Directory.CreateDirectory(location + @"\" + folder);

           // System.IO.File.WriteAllLines((location + @"\" + folder + @"\" + filename), logs);
            SettlementsFiles.GenerateTemplateSpreadsheet(fileName, dataTable,true,(location+folder));

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
