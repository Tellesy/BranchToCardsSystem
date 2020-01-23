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
    public partial class PIN_Screen : Form
    {

        private string Customer_ID;
        private string Product;
        public PIN_Screen()
        {
            InitializeComponent();
        }

        private void PIN_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                " إعادةالرقم السري للبطاقة  \n"
                +CardNo_TXT.Text,
                "هل أنت متأكد",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                EmptyBoxes();
                return;
            }

            AddToFile("PIN");

            Customer customerInfo = new Customer();
            customerInfo.Birthdate = "30061993";
            //Add email field
            customerInfo.Email = "Email";
            customerInfo.Id = int.Parse(Customer_ID);
            customerInfo.Name = CustomerName_TXT.Text;
            customerInfo.Passport = "000000";
            customerInfo.Phone = "910000000";

            Database.Status POStatus = Database.PO.addPO(CardNo_TXT.Text, customerInfo, AccountUSD_TXT.Text, 1, 'C');
            if (!POStatus.status)
            {
                MessageBox.Show("Error in Adding to PO table\n" + POStatus.message);
            }
            EmptyBoxes();
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
            //Passport
            Cards.Add("00000");
            Cards.Add("9000000");

            //Cards.Add(PO_Begin_Date);
            Cards.Add(SheetManager.PO_Begin_Date);
            //Cards.Add(PO_EXP_Date);
            Cards.Add(SheetManager.PO_EXP_Date);
            Cards.Add("30061993");
            Cards.Add("Email");

            SheetManager.AddToExcelSheet(Cards, Product, sheet);
        }

        private bool ValidateData()
        {


            if (CardNo_TXT.Text.Length != 16)
            {
                MessageBox.Show("الرجاء ادخال رقم البطاقة");
                return false;
            }

            if (AccountUSD_TXT.Text.Length != 15)
            {
                MessageBox.Show("الرجاء ادخال رقم الحساب بشكل صحيح");
                return false;
            }

            if (CustomerName_TXT.Text.Length == 0)
            {
                MessageBox.Show("الرجاء ادخال قم الزبون");
                return false;
            }

            return true;
        }

        private void EmptyBoxes()
        {
            CardNo_TXT.Text = "";
            CustomerName_TXT.Text = "";
            AccountUSD_TXT.Text = "";
        }

        private void CardNo_TXT_TextChanged(object sender, EventArgs e)
        {
            if (CardNo_TXT.Text.Length >= 16)
            {
                bool valid = CardsValidation.LuhnCheck(CardNo_TXT.Text);
                if (!valid)
                {
                    MessageBox.Show("رقم البطاقة غير صحيح, الرجاء التأكد");
                    CardNo_TXT.Text = CardNo_TXT.Text.Substring(0, 10);
                    return;
                }
                else
                {
                    Product = CardNo_TXT.Text.Substring(6,2);
                    System.Console.Out.Write(Product);
                }
            }
        }

        private void CardNo_TXT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AccountUSD_TXT_TextChanged(object sender, EventArgs e)
        {
            if (AccountUSD_TXT.Text.Length >= 7)
            {
                this.Customer_ID = AccountUSD_TXT.Text.Substring(0, 7);
                Status<Customer> customer = Database.Issue.getCustomer(Customer_ID);

                if (customer.status)
                {
                    CustomerName_TXT.Text = customer.Object.Name;
                }
            }
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
