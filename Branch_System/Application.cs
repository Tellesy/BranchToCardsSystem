using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Branch_System
{
    public partial class Application : Form
    {

        private static string newCardNumber;
        private static string customer_ID;
        private static string PO_Begin_Date;
        private static string PO_EXP_Date;
        private static string Account_EXP_Date;
        private static readonly int year = 2018;
        private static readonly int AlrafiqLimit = 10000;
        


        public string ProductCode;
        public Application()
        {
            InitializeComponent();
        }


        private void ProductType_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int p = ProductType_CBox.SelectedIndex;
            
            switch(p)
            {
                case 0:
                    ProductCode = "10";
                    break;
                case 1:
                    ProductCode = "30";
                    break;
            }
            ApplicationType_CBox.SelectedIndex = -1;

            EmptyBoxes();
            ApplicationType_CBox.Enabled = true;

          
        }

        private void ApplicationType_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //First disable everything
            OldCardNo_TXT.Enabled = false;
            CustomerName_TXT.Enabled = false;
            NID_TXT.Enabled = false;
            AccountUSD_TXT.Enabled = false;
            BirthDate_TXT.Enabled = false;
            PhoneNo_TXT.Enabled = false;
            Amount_TXT.Enabled = false;
            PIN_card.Enabled = false;
            Passport.Enabled = false;
            Old_Amount.Enabled = false;
            Submit_BTN.Enabled = true;
            //NIDUpdate_BTN.Enabled = true;
            

            int a = ApplicationType_CBox.SelectedIndex;

            switch(a)
            {
                case 0:
                    newCardNumber = BranchSystem.getNewCardNumber(ProductCode);
                    CardNo_TXT.Text = newCardNumber;
                    //OldCardNo_TXT.Enabled = true;
                    CustomerName_TXT.Enabled = true;
                    NID_TXT.Enabled = true;
                    AccountUSD_TXT.Enabled = true;
                    BirthDate_TXT.Enabled = true;
                    PhoneNo_TXT.Enabled = true;
                    Passport.Enabled = true;
                    Amount_TXT.Enabled = true;
                    break;
               case 1:
                    newCardNumber = BranchSystem.getNewCardNumber(ProductCode);
                    CardNo_TXT.Text = newCardNumber;
                    CustomerName_TXT.Enabled = true;
                    NID_TXT.Enabled = true;
                    AccountUSD_TXT.Enabled = true;
                    BirthDate_TXT.Enabled = true;
                    PhoneNo_TXT.Enabled = true;
                    break;
               case 2:
                    CardNo_TXT.Text = "";
                    OldCardNo_TXT.Enabled = true;
                    AccountUSD_TXT.Enabled = true;
                    Amount_TXT.Enabled = true;
                    NID_TXT.Enabled = true;
                    break;
                case 3:
                    CardNo_TXT.Text = "";
                    OldCardNo_TXT.Enabled = true;
                    AccountUSD_TXT.Enabled = true;
                    Amount_TXT.Enabled = true;
                    Old_Amount.Enabled = true;
                    NID_TXT.Enabled = true;
                    break;
                case 4:
                    newCardNumber = BranchSystem.getNewCardNumber(ProductCode);
                    CardNo_TXT.Text = newCardNumber;
                    OldCardNo_TXT.Enabled = true;
                    CustomerName_TXT.Enabled = true;
                    NID_TXT.Enabled = true;
                    AccountUSD_TXT.Enabled = true;
                    BirthDate_TXT.Enabled = true;
                    Passport.Enabled = true;
                    PhoneNo_TXT.Enabled = true;
                    break;

                case 5:
                    CardNo_TXT.Text = "";
                    PIN_card.Enabled = true;
                    CustomerName_TXT.Enabled = true;
                    AccountUSD_TXT.Enabled = true;
                    break;

            }


        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            int a = ApplicationType_CBox.SelectedIndex;
            switch (a)
            {
                case 0:

                       IssueAndRecharege();
                  
                    break;

                case 1:
                         IssueCard();
                    break;

                case 2:
                    RechargeFirstTime();
                    break;
                case 3:
                    Recharge();
                    break;
                case 4:
                    ReIssueCard();
                    break;
                case 5:
                    PIN();
                    break;


            }
            
        }

        private void AddToFile(string sheet)
        {
            List<string> Cards = new List<string>();

            Cards.Add(CardNo_TXT.Text);
            Cards.Add(OldCardNo_TXT.Text);
            Cards.Add(CustomerName_TXT.Text);
            Cards.Add(AccountUSD_TXT.Text);
            Cards.Add(Account_EXP_Date);
            //Old Amount
            Cards.Add(Old_Amount.Text);

            Cards.Add(Amount_TXT.Text);
            Cards.Add(Passport.Text);
            Cards.Add(PhoneNo_TXT.Text);
           
            Cards.Add(PO_Begin_Date);
            Cards.Add(PO_EXP_Date);
            Cards.Add(BirthDate_TXT.Text);
            Cards.Add("Email");

            ExcelFileManager.AddToExcelSheet(Cards,ProductCode,sheet);
        }
        private void Application_Load(object sender, EventArgs e)
        {
            setDate();
            //Create direcotry
            string path = @"c:\BranchToCards";


            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");

                    //Crate Excel Export file for each product
                    ExcelFileManager.CreateExcelSheet("10");
                    ExcelFileManager.CreateExcelSheet("30");


                    return;
                }
                else
                {

                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                    //Crate Excel Export file for each product
                    ExcelFileManager.CreateExcelSheet("10");
                    ExcelFileManager.CreateExcelSheet("30");

                }

            }
            catch (Exception e1)
            {
                Console.WriteLine("The process failed: {0}", e1.ToString());
                MessageBox.Show("خطأ في النظام, الرجاء التواصل مع المطور" + "\nThe process failed:" + e1.ToString());
            }
            finally { }

          
        }

        private void setDate()
        {
            int m = DateTime.Today.Month + 1;
            int y = DateTime.Today.Year;

            if (m > 12)
            {
                m = m - 12;
                y = y + 3;
            }
            else
            {
                y = y + 2;
            }

           
            
            
            string year = y.ToString().Substring(2);

         
            string month = m.ToString();
            if (m < 10)
            {
                month = "0" + month;
            }

            PO_EXP_Date = month + year;
            Account_EXP_Date = year + month;
            PO_Begin_Date = "1118";
        
            
        }
        
        private void OldCardNo_TXT_TextChanged(object sender, EventArgs e)
        {
            if(OldCardNo_TXT.Text.Length >= 16)
            {
                bool valid = CardsValidation.LuhnCheck(OldCardNo_TXT.Text);
                if (!valid)
                {
                    MessageBox.Show("رقم البطاقة غير صحيح, الرجاء التأكد");
                    OldCardNo_TXT.Text = "";
                }
            }
        }

        private void EmptyBoxes()
        {
            CardNo_TXT.Text = "";
            OldCardNo_TXT.Text = "";
            CustomerName_TXT.Text = "";
            NID_TXT.Text = "";
            AccountUSD_TXT.Text = "";
            BirthDate_TXT.Text = "";
            PhoneNo_TXT.Text = "";
            Old_Amount.Text = "";
            Amount_TXT.Text = "";
            PIN_card.Text = "";
            Passport.Text = "";
            
        }

        private void AccountUSD_TXT_TextChanged(object sender, EventArgs e)
        {


            if(AccountUSD_TXT.Text.Length >= 7)
            {
                //search for the customer
                customer_ID = AccountUSD_TXT.Text.Substring(0, 7);
                
                List<string> info =  BranchSystem.getCustomerInfo(AccountUSD_TXT.Text.Substring(0, 7));
                if(info.Count>0)
                {
                    CustomerName_TXT.Text = info[0];
                    BirthDate_TXT.Text = info[1];
                    PhoneNo_TXT.Text = info[2];
                    NID_TXT.Text = info[3];
                }
                else
                {
                    MessageBox.Show("بيانات هذا الزبون غير موجودة في قاعدة البيانات, الرجاء التأكد");
                }
            }
        }

        private void PIN_card_TextChanged(object sender, EventArgs e)
        {

            if (PIN_card.Text.Length >= 16)
            {
                bool valid = CardsValidation.LuhnCheck(PIN_card.Text);
                if (!valid)
                {
                    MessageBox.Show("رقم البطاقة غير صحيح, الرجاء التأكد");
                    PIN_card.Text = "";
                }
            }
        }

        private void AccountUSD_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void OldCardNo_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Amount_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
                {
                e.Handled = true;
                }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Old_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PIN_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void NID_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BirthDate_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PhoneNo_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void IssueCard()
        {

            if (AccountUSD_TXT.Text.Length != 15)
            {
                MessageBox.Show("الرجاء ادخال رقم الحساب بشكل صحيح");
                return;
            }

            if (!BranchSystem.isCustomerID(customer_ID))
            {
                MessageBox.Show("بيانات هذا الزبون غير موجودة في قاعدة البيانات, الرجاء التأكد");
                return;
            }

            if (NID_TXT.Text.Length != 12)
            {
                MessageBox.Show("رجاءً تأكد من ادخال الرقم الوطني");
                return;
            }

       

            if (CardNo_TXT.Text == "" || CustomerName_TXT.Text == "" || 
               AccountUSD_TXT.Text == "" || NID_TXT.Text == ""
               || BirthDate_TXT.Text == "" || PhoneNo_TXT.Text == "")
            {
                MessageBox.Show("الرجاء التأكد من تعبئة كل البيانات");
                return;
            }
            else
            {
               if(NID_TXT.Text != "" || NID_TXT.Text.Length == 12 )
                {
                    if (!BranchSystem.checkCardAccount(customer_ID, ProductCode))
                    {
                        AddToFile("I");
                        BranchSystem.UpdateSequences(newCardNumber, ProductCode);
                        BranchSystem.createCardAccount(newCardNumber, AccountUSD_TXT.Text, customer_ID, NID_TXT.Text, ProductCode);
                        BranchSystem.createCard(newCardNumber, "");
                        EmptyBoxes();
                        newCardNumber = BranchSystem.getNewCardNumber(ProductCode);
                        CardNo_TXT.Text = newCardNumber;
                    }
                    else MessageBox.Show("هذا الزبون لديه بطاقة, الرجاء التأكد او الذهاب الى خيار اعادة الاصدار");
                }
               else
                {
                    MessageBox.Show("الرجاء التأكد من ادخال الرقم الوطني بشكل صحيح لتسجيله في قاعدة البيانات");
                }
              
            }

        }

        private void IssueAndRecharege()
        {


            if (AccountUSD_TXT.Text.Length != 15)
            {
                MessageBox.Show("الرجاء ادخال رقم الحساب بشكل صحيح");
                return;
            }

            if (!BranchSystem.isCustomerID(customer_ID))
            {
                MessageBox.Show("بيانات هذا الزبون غير موجودة في قاعدة البيانات, الرجاء التأكد");
                return;
            }

            if (NID_TXT.Text.Length != 12)
            {
                MessageBox.Show("رجاءً تأكد من ادخال الرقم الوطني");
                return;
            }
            if (CardNo_TXT.Text == "" || Amount_TXT.Text == "" || CustomerName_TXT.Text == "" ||
               AccountUSD_TXT.Text == "" || NID_TXT.Text == ""
               || BirthDate_TXT.Text == "" || PhoneNo_TXT.Text == "")
            {
                MessageBox.Show("الرجاء التأكد من تعبئة كل البيانات");
                return;
            }

            if(Amount_TXT.Text.Length > 0)
            if (int.Parse(Amount_TXT.Text) > AlrafiqLimit)
            {
                MessageBox.Show("قيمة شحن البطاقة تتجاوز الحد المسموح به لهذا العام");
                return;
            }

            else if (int.Parse(Amount_TXT.Text) <= 0)
            {
                MessageBox.Show("قيمة الشحن يجب ان تكون اكثر من 0");
            }
            else
            {
                if (!BranchSystem.checkCardAccount(customer_ID, ProductCode))
                {
                    AddToFile("IR");
                    BranchSystem.UpdateSequences(newCardNumber, ProductCode);
                    BranchSystem.createCardAccount(newCardNumber, AccountUSD_TXT.Text, customer_ID, NID_TXT.Text, ProductCode);
                    BranchSystem.createCard(newCardNumber, "");
                    BranchSystem.recharge(customer_ID, NID_TXT.Text, int.Parse(Amount_TXT.Text), ProductCode, 2018);
                    EmptyBoxes();
                    newCardNumber = BranchSystem.getNewCardNumber(ProductCode);
                    CardNo_TXT.Text = newCardNumber;
                }
                 else MessageBox.Show("هذا الزبون لديه بطاقة, الرجاء التأكد او الذهاب الى خيار اعادة الاصدار");
            }
        }

        private void ReIssueCard()
        {

            if (AccountUSD_TXT.Text.Length != 15)
            {
                MessageBox.Show("الرجاء ادخال رقم الحساب بشكل صحيح");
                return;
            }
            if (CardNo_TXT.Text == "" || CustomerName_TXT.Text == "" ||
               AccountUSD_TXT.Text == "" || NID_TXT.Text == ""
               || BirthDate_TXT.Text == "" || PhoneNo_TXT.Text == "")
            {
                MessageBox.Show("الرجاء التأكد من تعبئة كل البيانات");
            }
            else
            {
                if (NID_TXT.Text != "" || NID_TXT.Text.Length == 12)
                {
                    AddToFile("ReI");
                    BranchSystem.UpdateSequences(newCardNumber, ProductCode);
                    BranchSystem.createCard(newCardNumber, OldCardNo_TXT.Text);
                    EmptyBoxes();
                    newCardNumber = BranchSystem.getNewCardNumber(ProductCode);
                    CardNo_TXT.Text = newCardNumber;
                }
                else
                {
                    MessageBox.Show("الرجاء التأكد من ادخال الرقم الوطني بشكل صحيح لتسجيله في قاعدة البيانات");
                }
            }

        }

        private void RechargeFirstTime()
        {
            if(OldCardNo_TXT.Text.Length != 16)
            {
                MessageBox.Show("الرجاء ادخال رقم اول بطاقة بشكل صحيح");
                return;
            }
            if(AccountUSD_TXT.Text.Length != 15)
            {
                MessageBox.Show("الرجاء ادخال رقم الحساب بشكل صحيح");
                return;
            }
            if (NID_TXT.Text.Length != 12)
            {
                MessageBox.Show("رجاءً تأكد من ادخال الرقم الوطني");
                return;
            }

            int total =  BranchSystem.totalRecharge(NID_TXT.Text, year);
            
            if(total <= 0)
            {
                if (int.Parse(Amount_TXT.Text) <= AlrafiqLimit)
                {
                     AddToFile("RFirst");
                    BranchSystem.recharge(customer_ID, NID_TXT.Text, int.Parse(Amount_TXT.Text), ProductCode, year);
                }
                else
                {
                    MessageBox.Show("قيمة الشحن تتجاوز سقف الشحن المسموح به لهذا العام");
                }
            }
           
            else
            {
                MessageBox.Show("هذا الزبون قام بشحن بطاقته سابقاً في هذا العام, الرجاء التأكد او استخدام خيار إعادة الشحن");
            }
        }
        
        private void Recharge()
        {
            if (OldCardNo_TXT.Text.Length != 16)
            {
                MessageBox.Show("الرجاء ادخال رقم اول بطاقة بشكل صحيح");
                return;
            }
            if (AccountUSD_TXT.Text.Length != 15)
            {
                MessageBox.Show("الرجاء ادخال رقم الحساب بشكل صحيح");
                return;
            }
            if (NID_TXT.Text.Length != 12)
            {
                MessageBox.Show("رجاءً تأكد من ادخال الرقم الوطني");
                return;
            }
            int amount = BranchSystem.totalRecharge(NID_TXT.Text, year);
            Old_Amount.Text = amount.ToString();
            if(amount > 0)
            {
                int totalRecharge = int.Parse(Amount_TXT.Text) + amount;
                if (totalRecharge <= AlrafiqLimit)
                {
                    AddToFile("R");
                    BranchSystem.recharge(customer_ID, NID_TXT.Text, int.Parse(Amount_TXT.Text), ProductCode, year);
                }
                else
                {
                    MessageBox.Show(" إجمالي قيمة الشحن تتجاوز سقف الشحن المسموح به لهذا العام");
                }

               
            }
            else
            {
                MessageBox.Show("لا يوجد عملية شحن سابقة لهذا الزبون, الرجاء التأكد او استخدام خيار الشحن لاول مرة");
            }
           
        }

        private void PIN()
        {
            if (PIN_card.Text.Length != 16)
            {
                MessageBox.Show("الرجاء ادخال رقم البطاقة بشكل صحيح");
                return;
            }
           
            AddToFile("PIN");
        }

        private void NIDUpdate_BTN_Click(object sender, EventArgs e)
        {
            if (NID_TXT.Text.Length != 12)
            {
                MessageBox.Show("رجاءً تأكد من ادخال الرقم الوطني");
                return;
            }
            if (AccountUSD_TXT.Text.Length != 15)
            {
                MessageBox.Show("الرجاء ادخال رقم الحساب بشكل صحيح");
                return;
            }

            BranchSystem.updateCustomerNID(customer_ID, NID_TXT.Text);

        }

        private void NID_TXT_TextChanged(object sender, EventArgs e)
        {
            if(NID_TXT.Text.Length == 12)
            {
                NIDUpdate_BTN.Enabled = true;
            }
        }
    }
    }


   

