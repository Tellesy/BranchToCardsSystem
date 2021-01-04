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
                    var date = DateTime.Now;
                    string dString = string.Format(date.Day + @"/" + date.Month + @"/"+ date.Year);
                    cols.Add(dString);
                    generatedCharges.Add(c);
                }
            }
            dataTable.Add(cols);




            SettlementsFiles.GenerateTemplateSpreadsheet("ChargesNow", dataTable);
            

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
    }
}
