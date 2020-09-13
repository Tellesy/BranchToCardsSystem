using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CTS.Database;
using CTS.Database.Objects;

namespace CTS.Screens.PTS.Issue
{
    public partial class PTS_Issue : Form
    {

        private bool customerExistInDB = false;
        private bool customerHasAnAccountUnderTheSameProgram = false;

        public PTS_Issue()
        {
            InitializeComponent();
        }

        List<Country> CountriesWithPhoneCode;
        List<Country> CountriesWithISOCode;


        private void PTS_Issue_Load(object sender, EventArgs e)
        {
            GetPrograms();
            // TODO: This line of code loads data into the 'cTS_PTS_Programs.PTS_Program' table. You can move, or remove it, as needed.
            //this.pTS_ProgramTableAdapter.Fill(this.cTS_PTS_Programs.PTS_Program);
            //Test

            CountriesWithPhoneCode =  CountryInfo.getCountriesWithPhoneCode();
            CountriesWithISOCode = CountryInfo.getCountriesWithISOCode();

            for(int i =0;i< CountriesWithPhoneCode.Count; i++)
            {
                CountryPhoneCode_CBox.Items.Insert(i, CountriesWithPhoneCode[i].name + " " + CountriesWithPhoneCode[i].code);
            }

            for (int i = 0; i < CountriesWithISOCode.Count; i++)
            {
                Nationality_CBOX.Items.Insert(i, CountriesWithISOCode[i].name + " " + CountriesWithISOCode[i].isoCode);
            }


        }

        private void CustomerID_TXT_TextChanged(object sender, EventArgs e)
        {
            string customerID = CustomerID_TXT.Text;
            if(customerID.Length == 7)
            {
               Status<PTSCustomer> status = PTSCustomerController.getCustomer(customerID);

                if(status.status)
                {
                    //Tell the system that this customer exist and no need to update the record
                    customerExistInDB = true;

                    PTSCustomer customer = status.Object;
                    FirstName_TXT.Text = customer.FirstName;
                    FatherName_TXT.Text = customer.FatherName;
                    LastName_TXT.Text = customer.LastName;
                    EmbossedName_TXT.Text = customer.EmbossedName;
                    if(customer.Gender == "M")
                    {
                        Gender_CBOX.SelectedIndex = 0;
                    }
                    else
                    {
                        Gender_CBOX.SelectedIndex = 1;
                    }

                    Birthdate.Value = DateTime.Parse(customer.Birthdate);
                    Nationality_CBOX.Text = customer.Nationality;
                    NID_TXT.Text = customer.NationalID;
                    Passport.Text = customer.PassportNumber;
                    PassportExpDate.Value = DateTime.Parse(customer.PassportExp);
                    Address_TXT.Text = customer.Address;
                    CountryPhoneCode_CBox.Text = customer.PhoneISD;
                    PhoneNo_TXT.Text = customer.Phone;
                    Email_TXT.Text = customer.Email;

                    CheckAccount(customerID, Program_CBox.SelectedValue.ToString());
                    DisableFields();
                }
                else
                {
                    EnableAndClearFields();
                    customerExistInDB = false;
                }
      
     
            }
        }

        //Check if the customer already got an account
        private void CheckAccount(string customer_id,string program_code)
        {
            Status<PTSAccount> account = PTSAccountController.getAccount(customer_id, program_code);

            if(account.status)
            {
                //The customer got an account you shouldn't add it
                MessageBox.Show("عذراً, هذا الزبون لديه بطاقة صادرة مسبقاً لنفس المنتج");
                customerHasAnAccountUnderTheSameProgram = true;
            }
        }
        private void GetPrograms()
        {
           Status<List<PTSProgram>> programStatus = PTSProgramController.getPrograms();

            if(programStatus.status)
            {
                // foreach(var p in programStatus.Object)
                Program_CBox.DataSource = programStatus.Object;
                Program_CBox.DisplayMember = "NameEN";
                Program_CBox.ValueMember = "Code";
                this.Program_CBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void DisableFields()
        {
            FirstName_TXT.Enabled = false;
            FatherName_TXT.Enabled = false;
            LastName_TXT.Enabled = false;
            EmbossedName_TXT.Enabled = false;
            Gender_CBOX.Enabled = false;


            Birthdate.Enabled = false;
            Nationality_CBOX.Enabled = false;
            NID_TXT.Enabled = false;
            Passport.Enabled = false;
            PassportExpDate.Enabled = false;
            Address_TXT.Enabled = false;
            CountryPhoneCode_CBox.Enabled = false;
            PhoneNo_TXT.Enabled = false;
            Email_TXT.Enabled = false;
        }

        private void EnableAndClearFields()
        {
            FirstName_TXT.Enabled = true;
            FatherName_TXT.Enabled = true;
            LastName_TXT.Enabled = true;
            EmbossedName_TXT.Enabled = true;
            Gender_CBOX.Enabled = true;
            Birthdate.Enabled = true;
            Nationality_CBOX.Enabled = true;
            NID_TXT.Enabled = true;
            Passport.Enabled = true;
            PassportExpDate.Enabled = true;
            Address_TXT.Enabled = true;
            CountryPhoneCode_CBox.Enabled = true;
            PhoneNo_TXT.Enabled = true;
            Email_TXT.Enabled = true;

            FirstName_TXT.Clear();
            FatherName_TXT.Clear();
            LastName_TXT.Clear();
            EmbossedName_TXT.Clear();
            NID_TXT.Clear();
            Passport.Clear();
            Address_TXT.Clear();
            PhoneNo_TXT.Clear();
            Email_TXT.Clear();
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if (customerExistInDB)
            {
                //add onlt to PTS Account and PTS Application Record Table
            }
            else
            {
                //add customer
                if (AddCustomer())
                {
                    MessageBox.Show("Yaay");
                }
                else
                {
                    MessageBox.Show("Naay");

                }
            }
        }

        public bool AddCustomer()
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
            customer.Nationality = Nationality_CBOX.Text;
            customer.EmbossedName = EmbossedName_TXT.Text;
            customer.PassportNumber = Passport.Text;
            customer.PassportExp = PassportExpDate.Text;
            customer.Address = Address_TXT.Text;
            customer.PhoneISD = CountryPhoneCode_CBox.Text;
            customer.Phone = PhoneNo_TXT.Text;
            customer.Email = Email_TXT.Text;

            Status cstatus = PTSCustomerController.addCustomer(customer);

            status = cstatus.status;
            return status;
        }
    }
}
