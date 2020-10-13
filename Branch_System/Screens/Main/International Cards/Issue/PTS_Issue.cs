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

        private List<PTSProgram> programs;

        public PTS_Issue()
        {
            InitializeComponent();
        }

        List<Country> CountriesWithPhoneCode;
        List<Country> CountriesWithISOCode;


        private void PTS_Issue_Load(object sender, EventArgs e)
        {
            DisableAllFields();
            GetPrograms();

            // TODO: This line of code loads data into the 'cTS_PTS_Programs.PTS_Program' table. You can move, or remove it, as needed.
            //this.pTS_ProgramTableAdapter.Fill(this.cTS_PTS_Programs.PTS_Program);
            //Test

            CountriesWithPhoneCode =  CountryInfo.getCountriesWithPhoneCode();
          
            CountriesWithISOCode = CountryInfo.getCountriesWithISOCode();

            CountryPhoneCode_CBox.DataSource = CountriesWithPhoneCode;
            CountryPhoneCode_CBox.ValueMember = "code";
            CountryPhoneCode_CBox.DisplayMember = "name";

            Nationality_CBOX.DataSource = CountriesWithISOCode;
            Nationality_CBOX.DisplayMember = "name";
            Nationality_CBOX.ValueMember = "isoCode";
           
            //for (int i =0;i< CountriesWithPhoneCode.Count; i++)
            //{
               
            //    CountryPhoneCode_CBox.Items.Insert(i, CountriesWithPhoneCode[i].name + " " + CountriesWithPhoneCode[i].code);
            //}

            //for (int i = 0; i < CountriesWithISOCode.Count; i++)
            //{
            //    Nationality_CBOX.Items.Insert(i, CountriesWithISOCode[i].name + " " + CountriesWithISOCode[i].isoCode);
            //}


        }

        private void CustomerID_TXT_TextChanged(object sender, EventArgs e)
        {
            string customerID = CustomerID_TXT.Text;
            if(customerID.Length == 7)
            {
                Submit_BTN.Enabled = true;
                MainAccount_TXT.Text = CustomerID_TXT.Text;
                ProgramAccount_TXT.Text = CustomerID_TXT.Text;

                Status<PTSCustomer> status = PTSCustomerController.getCustomer(customerID);

                if(status.status)
                {
                  var astatus = CheckAccount(customerID, Program_CBox.SelectedValue.ToString());
                    if(astatus)
                    {
                        EnableAllAndClearFields();
                        DisableAllFields();
                        customerExistInDB = false;
                        return;
                    }
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
                    EnableAllAndClearFields();
                    MainAccount_TXT.Text = CustomerID_TXT.Text;
                    ProgramAccount_TXT.Text = CustomerID_TXT.Text;
                    customerExistInDB = false;
                }
      
     
            }
        }

        //Check if the customer already got an account
        private bool CheckAccount(string customer_id,string program_code)
        {
            bool status = false;
            Status<PTSAccount> account = PTSAccountController.getAccount(customer_id, program_code);

            if(account.status)
            {
                status = true;
                //The customer got an account you shouldn't add it
                MessageBox.Show("عذراً, هذا الزبون لديه بطاقة صادرة مسبقاً لنفس المنتج");
                Submit_BTN.Enabled = false;
                customerHasAnAccountUnderTheSameProgram = true;
            }

            return status;
        }
        private void GetPrograms()
        {
           Status<List<PTSProgram>> programStatus = PTSProgramController.getPrograms();

            if(programStatus.status)
            {
                programs = programStatus.Object;
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

        private void DisableAllFields()
        {
            FirstName_TXT.Enabled = false;
            FatherName_TXT.Enabled = false;
            LastName_TXT.Enabled = false;
            EmbossedName_TXT.Enabled = false;
            Gender_CBOX.Enabled = false;
            MainAccount_TXT.Enabled = false;
            ProgramAccount_TXT.Enabled = false;
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

        private void EnableAllAndClearFields()
        {
            MainAccount_TXT.Enabled = true;
            ProgramAccount_TXT.Enabled = true;
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

            MainAccount_TXT.Clear();
            ProgramAccount_TXT.Clear();
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
            if(validateFields())
            {
                if(!customerExistInDB)
                {
                    if (AddCustomer())
                    {
                        EnableAndClearFields();
                        customerExistInDB = false;
                    }
                    else
                    {
                        MessageBox.Show("عذراً, لم يتم اضافة المستخدم");
                        EnableAllAndClearFields();
                        customerExistInDB = false;
                        return;
                    };
                }
             
               if(CheckAccount(CustomerID_TXT.Text,Program_CBox.SelectedValue.ToString()))
                {
                    MessageBox.Show("عذراً, هذا الزبون لديه بطاقة صادرة مسبقاً لنفس المنتج");
                    EnableAllAndClearFields();
                    DisableAllFields();
                    return;

                }
                  
                    //Add to record table here

                    PTSAppRecord appRecord = new PTSAppRecord();
                    appRecord.CustomerID = CustomerID_TXT.Text;
                    appRecord.ApplicationType = 'P';
                    appRecord.ApplicationSubType = 'N';
                    appRecord.ProgramCode = Program_CBox.SelectedValue.ToString();

                    var devicePlanStatus = PTSDevicePlanController.getDevicePlan(appRecord.ProgramCode);
                    if(devicePlanStatus.status)
                    {
                        appRecord.DevicePlanCode1 = devicePlanStatus.Object[0].PlanCode;
                    }
                    else
                    {
                        appRecord.DevicePlanCode1 = "";
                    }
                    appRecord.BranchCode = Database.Login.branch.PadLeft(6, '0');
                    appRecord.Inputter = Database.Login.id;

                  var appRecordStatus =  PTSAppRecordController.addAppRecord(appRecord);
                    if(appRecordStatus.status)
                    {
                        if (AddAccount())
                        {
                              MessageBox.Show("تم الإضافة بنجاح");
                              EnableAllAndClearFields();
                              DisableAllFields();
                              customerExistInDB = false;
                    }
                        else
                        {
                   //     MessageBox.Show("عذراً, هذا الزبون لديه بطاقة صادرة مسبقاً لنفس المنتج");
                        EnableAllAndClearFields();
                        DisableAllFields();
                        return;
                        }

                    }
                    else
                    {
                        MessageBox.Show(appRecordStatus.message);
                        return;
                       
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
            customer.Nationality = Nationality_CBOX.SelectedValue.ToString();
            customer.EmbossedName = EmbossedName_TXT.Text;
            customer.PassportNumber = Passport.Text;
            customer.PassportExp = PassportExpDate.Text;
            customer.Address = Address_TXT.Text;
            customer.PhoneISD = CountryPhoneCode_CBox.SelectedValue.ToString();
            customer.Phone = PhoneNo_TXT.Text;
            customer.Email = Email_TXT.Text;

            Status cstatus = PTSCustomerController.addCustomer(customer);

            status = cstatus.status;
            
            return status;
        }
        public bool AddAccount()
        {
            bool status = false;

            PTSAccount account = new PTSAccount();
            account.ProgramCode = Program_CBox.SelectedValue.ToString();
            account.AccountNumberLYD = MainAccount_TXT.Text;
            account.AccountNumberCurrency = ProgramAccount_TXT.Text;
            account.Customer_ID = CustomerID_TXT.Text;
            account.CurrencyCode = "840";
   
          

            Status astatus = PTSAccountController.addAccount(account);

            status = astatus.status;
            return status;
        }

        public bool validateFields()
        {
            bool status = false;

            if(String.IsNullOrWhiteSpace(Program_CBox.Text))
            {
                MessageBox.Show("الرجاء اختيار المنتج");
                return status;
            }
            if (String.IsNullOrWhiteSpace(CustomerID_TXT.Text))
            {
                MessageBox.Show("الرجاء ادخال رقم الزبون");
                return status;
            }

            if (String.IsNullOrWhiteSpace(MainAccount_TXT.Text))
            {
                MessageBox.Show("الرجاء ادخال رقم الحساب الاساسي للزبون");
                return status;
            }
            if (String.IsNullOrWhiteSpace(ProgramAccount_TXT.Text))
            {
                MessageBox.Show("الرجاء ادخال رقم الحساب الخاص بالمنتج");
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

            if (String.IsNullOrWhiteSpace(NID_TXT.Text))
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

            if (String.IsNullOrWhiteSpace(Email_TXT.Text))
            {
                MessageBox.Show("الرجاء إدخال عنوان البريد الإلكتروني");
                return status;
            }

            status = true;
            return status;
        }

        private void TXTB_ONLY_NUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXTB_ONLY_CHAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            //&& !char.IsUpper(e.KeyChar)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            
            }
        
        }

        private void TEXTB_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
             textBox.Text = textBox.Text.ToUpper();
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            //Make sure the Text is valid by checking the Max Lenghth
            if(textBox.Text.Length <textBox.MaxLength)
            {
                textBox.Text = "";
                MessageBox.Show("الرجاء التأكد من صحة البيانات",textBox.Name);
                return;
            }

            //Check if Account number is valid
            if(textBox.Name == MainAccount_TXT.Name || textBox.Name == ProgramAccount_TXT.Name)
            {
                if(textBox.Text.Substring(0,7) != CustomerID_TXT.Text)
                {
                    textBox.Text = "";
                    MessageBox.Show("الرجاء التأكد من رقم الحساب", textBox.Name);
                    return;
                }
            }

            
           
        }
    }
}
