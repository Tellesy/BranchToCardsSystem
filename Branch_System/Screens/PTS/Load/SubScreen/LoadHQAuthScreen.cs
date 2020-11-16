using MPBS.Database;
using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.PTS.Load.SubScreen
{
    public partial class LoadHQAuthScreen : Form
    {
        public PTSLoad record;
        private PTSAccount accountObject;
        public LoadHQAuthScreen()
        {
            InitializeComponent();
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueHQAuthScreen_Load(object sender, EventArgs e)
        {
            Year_LBL.Text = Database.Recharge.year;
            this.Text = record.ID.ToString() + " " + record.Inputter;


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


            string programCode = String.Concat(record.ProgramCode.Where(c => !Char.IsWhiteSpace(c)));
            if (programsObject.status)
            {
                programCode = programsObject.Object.First(i => i.Code == programCode).NameEN;
            }


            Program_CBox.Text = programCode;
            var accountStatusObject = PTSAccountController.getAccount(record.CustomerID, record.ProgramCode);
            accountObject = accountStatusObject.Object;

            MainAccount_TXT.Text = accountStatusObject.Object.AccountNumberLYD;
            ProgramAccount_TXT.Text = accountStatusObject.Object.AccountNumberCurrency;

            Amount_TXT.Text = record.Amount.ToString();
            var sTotal = PTSLoadController.getTotalLoadAuthorizedRecordsForClient(record.CustomerID, record.ProgramCode, Database.Recharge.year);
            if (sTotal.status)
            {
                TotalAmount_TXT.Text = sTotal.Object.Sum(t => t.Amount).ToString();
            }

            //AppType_TXT.Text = record.ApplicationType.ToString();
            //AppSubType_TXT.Text = record.ApplicationSubType.ToString();
            Inputter_TXT.Text = record.Inputter.ToString();
        }

        private void Authorize_BTN_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(accountObject.WalletNumber))
            {
                MessageBox.Show("Error! This card doesn't have wallet number in Database");
                return;
            }

             DialogResult dialogResult = MessageBox.Show("هل انت متأكد من تخويل هذه العملية؟", "تخويل العملية", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Database.Status status = Database.PTSLoadController.authHQLoadRequest(record.ID);

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

