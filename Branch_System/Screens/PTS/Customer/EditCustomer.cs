using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Database;
using MPBS.Database.Objects;

namespace MPBS.Screens.PTS.Customer
{
    public partial class EditCustomer : Form
    {
        public string customer_id;

        List<Country> CountriesWithPhoneCode;
        List<Country> CountriesWithISOCode;


        public EditCustomer()
        {
            InitializeComponent();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {

            CountriesWithPhoneCode = CountryInfo.getCountriesWithPhoneCode();

            CountriesWithISOCode = CountryInfo.getCountriesWithISOCode();

            CountryPhoneCode_CBox.DataSource = CountriesWithPhoneCode;
            CountryPhoneCode_CBox.ValueMember = "code";
            CountryPhoneCode_CBox.DisplayMember = "name";
            CountryPhoneCode_CBox.SelectedValue = "+218";

            Nationality_CBOX.DataSource = CountriesWithISOCode;
            Nationality_CBOX.DisplayMember = "name";
            Nationality_CBOX.ValueMember = "isoCode";
            Nationality_CBOX.SelectedValue = "434";


            Status<PTSCustomer> customerStatus = PTSCustomerController.getCustomer(customer_id);
            if (!customerStatus.status)
            {
                MessageBox.Show(customerStatus.message, "Error");
                return;
            }

            var customer = customerStatus.Object;

            CustomerID_TXT.Text = customer.CustomerID;
            FirstName_TXT.Text = customer.FirstName;
            FatherName_TXT.Text = customer.FatherName;
            LastName_TXT.Text = customer.LastName;
            EmbossedName_TXT.Text = customer.EmbossedName;
            if (customer.Gender == "M")
            {
                Gender_CBOX.SelectedIndex = 0;
            }
            else
            {
                Gender_CBOX.SelectedIndex = 1;
            }
            Birthdate.Value = DateTime.Parse(customer.Birthdate);
            Nationality_CBOX.SelectedValue = customer.Nationality;
            NID_TXT.Text = customer.NationalID.Substring(0,12);
            Passport.Text = customer.PassportNumber;
            PassportExpDate.Value = DateTime.Parse(customer.PassportExp);
            Address_TXT.Text = customer.Address;
            CountryPhoneCode_CBox.Text = customer.PhoneISD;
            PhoneNo_TXT.Text = customer.Phone;


            Email_TXT.Text = customer.Email;
            if(string.IsNullOrWhiteSpace(customer.Email))
            {
                Email_CHBox.Checked = false;
            }
            else
            {
                Email_CHBox.Checked = true;
            }


        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                if (UpdateCustomer())
                {
                    MessageBox.Show("تم التعديل بنجاح");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("عذراً, لم يتم تحديث المستخدم");
                    return;
                };

            }
            

        }

        public bool UpdateCustomer()
        {
            bool status = false;

            PTSCustomer customer = new PTSCustomer();
            customer.CustomerID = CustomerID_TXT.Text;
            customer.FirstName = FirstName_TXT.Text;
            customer.FatherName = FatherName_TXT.Text;
            customer.LastName = LastName_TXT.Text;
            customer.Gender = Gender_CBOX.Text;
            customer.Birthdate = Birthdate.Text;
            customer.NationalID = NID_TXT.Text;
            if (string.IsNullOrWhiteSpace(Nationality_CBOX.SelectedValue.ToString()))
            {
                Nationality_CBOX.SelectedValue = "434";
            }
            customer.Nationality = Nationality_CBOX.SelectedValue.ToString();
            customer.EmbossedName = EmbossedName_TXT.Text;
            customer.PassportNumber = Passport.Text;
            customer.PassportExp = PassportExpDate.Text;
            customer.Address = Address_TXT.Text;
            customer.PhoneISD = String.Concat(CountryPhoneCode_CBox.SelectedValue.ToString().Where(c => !char.IsWhiteSpace(c)));
            customer.Phone = PhoneNo_TXT.Text;
            if (Email_CHBox.Checked)
            {
                customer.Email = Email_TXT.Text;
            }
            else
            {
                customer.Email = null;
            }


            Status cstatus = PTSCustomerController.updateCustomer(customer, customer_id);

            status = cstatus.status;

            return status;
        }

        public bool validateFields()
        {
            bool status = false;

            if (String.IsNullOrWhiteSpace(CustomerID_TXT.Text))
            {
                MessageBox.Show("الرجاء ادخال رقم الزبون");
                return status;
            }


            if (String.IsNullOrWhiteSpace(FirstName_TXT.Text))
            {
                MessageBox.Show("الرجاء ادخال الاسم الاول للزبون");
                return status;
            }
            if (String.IsNullOrWhiteSpace(FatherName_TXT.Text))
            {
                MessageBox.Show("الرجاء ادخال اسم الاب");
                return status;
            }
            if (String.IsNullOrWhiteSpace(LastName_TXT.Text))
            {
                MessageBox.Show("الرجاء إدخال اللقب");
                return status;
            }
            if (String.IsNullOrWhiteSpace(EmbossedName_TXT.Text))
            {
                MessageBox.Show("الرجاء ادخال الإسم على البطاقة");
                return status;
            }
            if (String.IsNullOrWhiteSpace(Gender_CBOX.Text))
            {
                MessageBox.Show("الرجاء إختيار الجنس");
                return status;
            }
            if (String.IsNullOrWhiteSpace(Birthdate.Text))
            {
                MessageBox.Show("الرجاء إدخال تاريخ الميلاد");
                return status;
            }
            if (String.IsNullOrWhiteSpace(Nationality_CBOX.Text))
            {
                MessageBox.Show("الرجاء إختيار الجنسية");
                return status;
            }

            if (String.IsNullOrWhiteSpace(NID_TXT.Text) || NID_TXT.Text.Length != 12)
            {
                MessageBox.Show("الرجاء إدخال الرقم الوطني");
                return status;
            }
            if (String.IsNullOrWhiteSpace(Passport.Text))
            {
                MessageBox.Show("الرجاء إدخال رقم جواز السفر");
                return status;
            }
            if (String.IsNullOrWhiteSpace(PassportExpDate.Text))
            {
                MessageBox.Show("الرجاء إدخال تاريخ إنتهاء صلاحية جواز السفر");
                return status;
            }

            if (String.IsNullOrWhiteSpace(Address_TXT.Text))
            {
                MessageBox.Show("الرجاء إدخال العنوان");
                return status;
            }
            if (String.IsNullOrWhiteSpace(CountryPhoneCode_CBox.Text))
            {
                MessageBox.Show("الرجاء إدخال مفتاح الدولة");
                return status;
            }
            if (String.IsNullOrWhiteSpace(PhoneNo_TXT.Text))
            {
                MessageBox.Show("الرجاء إدخال رقم الهاتف");
                return status;
            }

            if (String.IsNullOrWhiteSpace(Email_TXT.Text) && Email_CHBox.Checked)
            {
                MessageBox.Show("الرجاء إدخال عنوان البريد الإلكتروني");
                return status;
            }
            if (!IsValidEmail(Email_TXT.Text) && Email_CHBox.Checked)
            {
                MessageBox.Show("الرجاء التأكد من عنوان البريد الإلكتروني");
                return status;
            }
           
            status = true;
            return status;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Email_CHBox_CheckedChanged(object sender, EventArgs e)
        {
            if(Email_CHBox.Checked)
            {
                Email_TXT.Enabled = true;
            }
            else
            {
                Email_TXT.Enabled = false;
            }
        }
    }
}
