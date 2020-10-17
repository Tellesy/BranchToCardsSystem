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

namespace MPBS.Screens.Account_Details
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_BTN_Click(object sender, EventArgs e)
        {
            string Card_Number = Card_Number_TXT.Text;
            Status<CardAccount> status = MPBS.Database.Issue.getCardAccount(Card_Number);
            if(status.status)
            {
                Account_TXT.Text = status.Object.Account;
                Customer_ID_TXT.Text = status.Object.Customer_ID;
                Product.Text = status.Object.Product;

                Status<Customer> Customer = MPBS.Database.Issue.getCustomer(status.Object.Customer_ID);
                if(Customer.status)
                {
                    Name_TXT.Text = Customer.Object.Name;
                }
            }
            else
            {
               Status<string> Card_Account = MPBS.Database.Issue.getCardAccountFromCard_Number(Card_Number);
                if(Card_Account.status)
                {
                     status = MPBS.Database.Issue.getCardAccount(Card_Account.Object);
                    if(status.status)
                    {
                        Account_TXT.Text = status.Object.Account;
                        Customer_ID_TXT.Text = status.Object.Customer_ID;
                        Product.Text = status.Object.Product;

                        Status<Customer> Customer = MPBS.Database.Issue.getCustomer(status.Object.Customer_ID);
                        if (Customer.status)
                        {
                            Name_TXT.Text = Customer.Object.Name;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لا وجود لهذه البطاقة في قاعدة البيانات, الرجاء التواصل مع مدير النظام");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("لا وجود لهذه البطاقة في قاعدة البيانات, الرجاء التواصل مع مدير النظام");
                    return;
                }
            }
            
        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Card_Number_TXT_TextChanged(object sender, EventArgs e)
        {
            if (Card_Number_TXT.Text.Length >= 16)
            {
                bool valid = CardsValidation.LuhnCheck(Card_Number_TXT.Text);
                if (!valid)
                {
                    MessageBox.Show("رقم البطاقة غير صحيح, الرجاء التأكد");
                    Card_Number_TXT.Text = Card_Number_TXT.Text.Substring(0, 10);
                }
            }
        }

        private void Card_Number_TXT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
