using CTS.Database;
using CTS.Database.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS.Screens.Main.International_Cards.AuthIssue.SubScreen
{

    public partial class IssueBranchAuthScreen : Form
    {

        public PTSAppRecord record;

        public IssueBranchAuthScreen()
        {
            InitializeComponent();
        }

        private void IssueBranchAuthScreen_Load(object sender, EventArgs e)
        {
            this.Text = record.RecordID.ToString();
            CustomerID_LBL.Text = record.CustomerID;

            //get customer name from here
            var customerObject = PTSCustomerController.getCustomer(record.CustomerID);

            CustomerName_LBL.Text = customerObject.Object.EmbossedName;

            var accountObject = PTSAccountController.getAccount(record.CustomerID, record.ProgramCode);
            AccountLocal_LBL.Text = accountObject.Object.AccountNumberLYD;
            AccountProgram_LBL.Text = accountObject.Object.AccountNumberCurrency;
            Branch_LBL.Text = record.BranchCode;
            ApplicationType_LBL.Text = record.ApplicationType.ToString();
            ApplicationSubType_LBL.Text = record.ApplicationSubType.ToString();
            Inputter_LBL.Text = record.Inputter.ToString();

        }
        private void Accept_BTN_Click(object sender, EventArgs e)
        {
        //    DialogResult dialogResult = MessageBox.Show("هل انت متأكد من تخويل هذه العملية؟", "تخويل العملية", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {

        //        Database.Status status = Database.PO.authBranchPO(record.ID);

        //        if (status.status)
        //        {
        //            //Get Total Amount to be added to PBF


        //            MessageBox.Show("تم تخويل العملية بنجاح");
        //            record = null;
        //            this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show(status.message);
        //        }
        //    }
        //    else if (dialogResult == DialogResult.No)
        //    {
        //        //do something else
        //    }
        }

        private void Deny_BTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من إلغاء هذه العملية؟", "إلغاء العملية", MessageBoxButtons.YesNo);
           // if (dialogResult == DialogResult.Yes)
            //{
            //    Database.Status status = Database.PO.deletePO(record.CustomerID);
            //    if (status.status)
            //    {
            //        MessageBox.Show("تم إلغاء العملية بنجاح");
            //        record = null;
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show(status.message);
            //    }
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    //do something else
            //}
        }
    }
}
