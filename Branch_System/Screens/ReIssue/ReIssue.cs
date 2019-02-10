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

namespace CTS.Screens
{
    public partial class ReIssue : Form
    {
        private string CardNumber;
        private string Product;
        private string Customer_ID;
        private bool UpdateInfoFlag = false;

        public ReIssue()
        {
            InitializeComponent();
        }

        private void Product_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmptyBoxes();

            if (CardNumber != null)
                if (CardNumber.Length != 0)
                {
                    Database.Issue.unlockSequences(CardNumber);
                }
            Submit_BTN.Enabled = false;
            CardAccount_TXT.Enabled = false;
            CustomerName_TXT.Enabled = false;
            NID_TXT.Enabled = false;
            AccountUSD_TXT.Enabled = false;
            BirthDate_TXT.Enabled = false;
            PhoneNo_TXT.Enabled = false;
            Passport.Enabled = false;

            switch (Product_CBox.SelectedIndex)
            {
                case 0:
                    Product = "10";
                    if (!GetNumber())
                    {
                        return;
                    }
                    break;
                case 1:
                    Product = "30";  
                    if(!GetNumber())
                    {
                        return;
                    }
                    break;
                default:
                    if (CardNumber != null)
                        if (CardNumber.Length != 0)
                        {
                            Database.Issue.unlockSequences(CardNumber);
                        }
                    Submit_BTN.Enabled = false;
                    CardAccount_TXT.Enabled = false;
                    CustomerName_TXT.Enabled = false;
                    NID_TXT.Enabled = false;
                    AccountUSD_TXT.Enabled = false;
                    BirthDate_TXT.Enabled = false;
                    PhoneNo_TXT.Enabled = false;
                    Passport.Enabled = false;
                    EmptyBoxes();
                    break;
            }

           
        }

        private void EmptyBoxes()
        {
            CardNo_TXT.Text = "";
            CardAccount_TXT.Text = "";
            CustomerName_TXT.Text = "";
            NID_TXT.Text = "";
            AccountUSD_TXT.Text = "";
            BirthDate_TXT.Text = "";
            PhoneNo_TXT.Text = "";
            Passport.Text = "";
        }

        private bool GetNumber()
        {
            Database.Status status = new Database.Status();


            status = Database.Issue.getNewCardNumber(Product);

            if (status.status)
            {
                CardNumber = status.message;
                Database.Issue.lockSequences(CardNumber);
                CardNo_TXT.Text = CardNumber;
            }
            else
            {
                MessageBox.Show(status.message);
                return false;
            }
            Submit_BTN.Enabled = true;
            CardAccount_TXT.Enabled = true;
            CustomerName_TXT.Enabled = true;
            NID_TXT.Enabled = true;
            AccountUSD_TXT.Enabled = true;
            BirthDate_TXT.Enabled = true;
            PhoneNo_TXT.Enabled = true;
            Passport.Enabled = true;
            return status.status;
        }

        public void UnlockRecord()
        {
           Database.Issue.unlockSequences(CardNumber);
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            Database.Issue.unlockSequences(CardNumber);
            this.Close();
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            IssueCard();
        }

        private bool ValidateData()
        {

            if (CardAccount_TXT.Text.Length != 16)
            {
                MessageBox.Show("الرجاء إدخال رقم حساب البطاقة");
                return false;
            }

            if (AccountUSD_TXT.Text.Length != 15)
            {
                MessageBox.Show("الرجاء ادخال رقم الحساب بشكل صحيح");
                return false;
            }

            if (NID_TXT.Text.Length != 12)
            {
                MessageBox.Show("رجاءً تأكد من ادخال الرقم الوطني");
                return false;
            }

            if (CardNo_TXT.Text == "" || CustomerName_TXT.Text == "" ||
               AccountUSD_TXT.Text == "" || NID_TXT.Text == ""
               || BirthDate_TXT.Text == "" || PhoneNo_TXT.Text == "")
            {
                MessageBox.Show("الرجاء التأكد من تعبئة كل البيانات");
                return false;
            }

            return true;
        }

        private void IssueCard()
        {
            if (!ValidateData())
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                " إعادة إصدار بطاقة للحساب  \n"
                + CardAccount_TXT.Text,
                "هل أنت متأكد",
                MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        CardAccount_TXT.Text = "0";
                        return;
                    }

            Status status = Database.Recharge.checkCardAccount(CardAccount_TXT.Text);

            if(!status.status)
            {
                MessageBox.Show(status.message);
                return;
            }
            status = Database.Issue.updateSequences(CardNumber);
            if (!status.status)
            {
                MessageBox.Show(status.message);
                return;
            }
            status = Database.Issue.createCard(CardNumber, CardAccount_TXT.Text);
            if (!status.status)
            {
                MessageBox.Show(status.message);
                return;
            }

            AddToFile("ReI");

            Database.Status CAFStatus = Database.CAF.addCAF(CardNumber, CardAccount_TXT.Text, SheetManager.Account_EXP_Date, Product);
            if (!CAFStatus.status)
            {
                MessageBox.Show("Error in Adding to CAF table\n" + CAFStatus.message);
            }

            Customer customerInfo = new Customer();
            customerInfo.Birthdate = BirthDate_TXT.Text;
            //Add email field
            customerInfo.Email = "Email";
            customerInfo.Id = int.Parse(Customer_ID);
            customerInfo.Name = CustomerName_TXT.Text;
            customerInfo.Passport = Passport.Text;
            customerInfo.Phone = PhoneNo_TXT.Text;
            //customerInfo.

            Database.Status POStatus = Database.PO.addPO(CardNumber, customerInfo, AccountUSD_TXT.Text, 1, 'D');
            if (!POStatus.status)
            {
                MessageBox.Show("Error in Adding to PO table\n" + POStatus.message);
            }

            if (UpdateInfoFlag)
            {
                Customer customer = new Customer();
                customer.Id = int.Parse(Customer_ID);
                customer.Name = CustomerName_TXT.Text;
                customer.NID = Int64.Parse(NID_TXT.Text);
                customer.Birthdate = BirthDate_TXT.Text;
                customer.Phone = PhoneNo_TXT.Text;
                Database.Issue.addCustomer(customer);
                UpdateInfoFlag = false;
            }

            EmptyBoxes();
            MessageBox.Show("تم إضافة البطاقة الجديدة بنجاح");

            status = Database.Issue.getNewCardNumber(Product);
            if (!status.status)
            {
                MessageBox.Show(status.message);
                Product_CBox.SelectedIndex = -1;
                CardNumber = "";
                CustomerName_TXT.Enabled = false;
                NID_TXT.Enabled = false;
                AccountUSD_TXT.Enabled = false;
                BirthDate_TXT.Enabled = false;
                PhoneNo_TXT.Enabled = false;
                Passport.Enabled = false;
                Submit_BTN.Enabled = false;
                return;
            }
            // Now Edit this
            CardNumber = status.message;
            CardNo_TXT.Text = CardNumber;

        }

        private void AddToFile(string sheet)
        {
            List<string> Cards = new List<string>();

            Cards.Add(CardNo_TXT.Text);
            Cards.Add(CardNo_TXT.Text);
            Cards.Add(CustomerName_TXT.Text);
            Cards.Add(AccountUSD_TXT.Text);
            //Cards.Add(Account_EXP_Date);
            Cards.Add(SheetManager.Account_EXP_Date);

            //Old Amount
            Cards.Add("0");

            //Amount
            Cards.Add("0");
            Cards.Add(Passport.Text);
            Cards.Add(PhoneNo_TXT.Text);

            //Cards.Add(PO_Begin_Date);
            Cards.Add(SheetManager.PO_Begin_Date);
            //Cards.Add(PO_EXP_Date);
            Cards.Add(SheetManager.PO_EXP_Date);
            Cards.Add(BirthDate_TXT.Text);
            Cards.Add("Email");

            SheetManager.AddToExcelSheet(Cards, Product, sheet);
        }

        private void AccountUSD_TXT_TextChanged(object sender, EventArgs e)
        {
            if (AccountUSD_TXT.Text.Length >= 7)
            {
                this.Customer_ID = AccountUSD_TXT.Text.Substring(0, 7);
                Status<Customer> customer = Database.Issue.getCustomer(Customer_ID);

                if (customer.status)
                {
                    UpdateInfoFlag = false;
                    if(customer.Object.Name.Count() > 25)
                    {
                        CustomerName_TXT.Text =  customer.Object.Name.Substring(0,24);
                    }
                    else
                    {
                        CustomerName_TXT.Text = customer.Object.Name;
                    }
                    NID_TXT.Text = customer.Object.NID.ToString();
                    BirthDate_TXT.Text = customer.Object.Birthdate;
                    PhoneNo_TXT.Text = customer.Object.Phone;
                }
                else
                {
                    UpdateInfoFlag = true;
                }
            }

        }

        private void CardAccount_TXT_TextChanged(object sender, EventArgs e)
        {
            if (CardAccount_TXT.Text.Length >= 16)
            {
                bool valid = CardsValidation.LuhnCheck(CardAccount_TXT.Text);
                if (!valid)
                {
                    MessageBox.Show("رقم البطاقة غير صحيح, الرجاء التأكد");
                    CardAccount_TXT.Text = CardAccount_TXT.Text.Substring(0, 10);
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

        private void Passport_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ReIssue_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CardAccount_TXT_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

