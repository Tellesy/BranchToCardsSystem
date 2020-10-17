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

namespace CTS.Screens.International_Cards.AuthIssue.SubScreen
{
    public partial class IssueHQAuthScreen : Form
    {
        public PTSAppRecord record;

        public IssueHQAuthScreen()
        {
            InitializeComponent();
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueHQAuthScreen_Load(object sender, EventArgs e)
        {
            this.Text = record.RecordID.ToString() + " " + record.Inputter;
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
            var programsObject = PTSProgramController.getPrograms();

            string programCode = record.ProgramCode;
            if (programsObject.status)
            {
                programCode = programsObject.Object.First(i => i.Code == record.ProgramCode).NameEN;
            }
            Program_CBox.Text = programCode;
            var accountObject = PTSAccountController.getAccount(record.CustomerID, record.ProgramCode);


            MainAccount_TXT.Text = accountObject.Object.AccountNumberLYD;
            ProgramAccount_TXT.Text = accountObject.Object.AccountNumberCurrency;

            AppType_TXT.Text = record.ApplicationType.ToString();
            AppSubType_TXT.Text = record.ApplicationSubType.ToString();
            Inputter_TXT.Text = record.Inputter.ToString();
        }

        private void Authorize_BTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من تخويل هذه العملية؟", "تخويل العملية", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Database.Status status = Database.PTSAppRecordController.authHQAppRecord(record.RecordID);

                if (status.status)
                {
                    //Get Total Amount to be added to PBF


                    MessageBox.Show("تم تخويل العملية بنجاح");
                    record = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(status.message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
    }

