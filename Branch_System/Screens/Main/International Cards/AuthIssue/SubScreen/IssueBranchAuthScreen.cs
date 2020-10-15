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

namespace CTS.Screens.Main.International_Cards.BranchAuthIssue.SubScreen
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
            CustomerID_TXT.Text = record.CustomerID;
            
            //get customer name from here
            var customerObject = PTSCustomerController.getCustomer(record.CustomerID);
            FirstName_TXT.Text = customerObject.Object.FirstName;
            FatherName_TXT.Text = customerObject.Object.FatherName;
            LastName_TXT.Text = customerObject.Object.LastName;
            EmbossedName_TXT.Text = customerObject.Object.EmbossedName;
            Gender_CBOX.Text = customerObject.Object.Gender;
            Birthdate.Value = DateTime.Parse(customerObject.Object.Birthdate);
            Nationality_CBOX.SelectedValue = customerObject.Object.Nationality;
            NID_TXT.Text = customerObject.Object.NationalID;
            Passport.Text = customerObject.Object.PassportNumber;
            PassportExpDate.Value = DateTime.Parse(customerObject.Object.PassportExp);
            Address_TXT.Text = customerObject.Object.Address;
            CountryPhoneCode_CBox.Text = customerObject.Object.PhoneISD;
            PhoneNo_TXT.Text = customerObject.Object.Phone;
            Email_TXT.Text = customerObject.Object.Email;
            var accountObject = PTSAccountController.getAccount(record.CustomerID, record.ProgramCode);


            MainAccount_TXT.Text = accountObject.Object.AccountNumberLYD;
            ProgramAccount_TXT.Text = accountObject.Object.AccountNumberCurrency;

            AppType_TXT.Text = record.ApplicationType.ToString();
            AppSubType_TXT.Text = record.ApplicationSubType.ToString();
            Inputter_TXT.Text = record.Inputter.ToString();

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
