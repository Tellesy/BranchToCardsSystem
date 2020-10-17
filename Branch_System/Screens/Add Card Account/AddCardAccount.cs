using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.Card_Enquire
{
    public partial class CardENQ : Form
    {
        private string CardNumber;
        private string Product;
        private string Customer_ID;
        private bool UpdateInfoFlag = false;

        public CardENQ()
        {
            InitializeComponent();
        }

        private void CustomerID_TXT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CardAccountNo_TXT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AccountUSDNo_TXT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Product_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmptyBoxes();


            Submit_BTN.Enabled = false;
            CardAccountNo_TXT.Enabled = false;
            CustomerID_TXT.Enabled = false;
            AccountUSDNo_TXT.Enabled = false;
            Submit_BTN.Enabled = false;

            switch (Product_CBox.SelectedIndex)
            {
                case 0:
                    Product = "10";
                    EnableFields();
                    break;
                case 1:
                    Product = "30";
                    EnableFields();
                    break;
                default:

                    Submit_BTN.Enabled = false;
                    CardAccountNo_TXT.Enabled = false;
                    CustomerID_TXT.Enabled = false;
                    AccountUSDNo_TXT.Enabled = false;
                    Submit_BTN.Enabled = false;
                    EmptyBoxes();
                    break;
            }
        }

        private void EnableFields()
        {
            Submit_BTN.Enabled = true;
            CardAccountNo_TXT.Enabled = true;
            CustomerID_TXT.Enabled = true;
            AccountUSDNo_TXT.Enabled = true;
            Submit_BTN.Enabled = true;
        }

        private void EmptyBoxes()
        {
            CardAccountNo_TXT.Text = "";
            CustomerID_TXT.Text = "";
            AccountUSDNo_TXT.Text = "";

        }

        private void CardENQ_Load(object sender, EventArgs e)
        {


            CardAccountNo_TXT.Enabled = false;
            CustomerID_TXT.Enabled = false;
            AccountUSDNo_TXT.Enabled = false;
            Submit_BTN.Enabled = false;
        }

        private void CardAccountNo_TXT_TextChanged(object sender, EventArgs e)
        {
            if (CardAccountNo_TXT.Text.Length >= 16)
            {
                bool valid = CardsValidation.LuhnCheck(CardAccountNo_TXT.Text);
                if (!valid)
                {
                    MessageBox.Show("رقم البطاقة غير صحيح, الرجاء التأكد");
                    CardAccountNo_TXT.Text = CardAccountNo_TXT.Text.Substring(0, 10);
                }
            }
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if(CardAccountNo_TXT.Text == "" || CardAccountNo_TXT.TextLength < 16)
            {
                MessageBox.Show("الرجاء التأكد من رقم البطاقة");
                return;
            }

            if (CustomerID_TXT.Text == "" || CustomerID_TXT.TextLength < 7)
            {
                MessageBox.Show("الرجاء التأكد من رقم الزبون");
                return;
            }
            if(AccountUSDNo_TXT.Text == "" || AccountUSDNo_TXT.TextLength < 15)
            {
                MessageBox.Show("الرجاء التأكد من رقم الحساب");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("هل أنت متأكد؟", "هل أنت متأكد؟", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                         EmptyBoxes();
                        return;
                    }
          Database.Status status =  Database.Issue.hasCardAccount(CustomerID_TXT.Text, Product);
            if(!status.status)
            {
               status = Database.Issue.createCardAccount(CardAccountNo_TXT.Text,AccountUSDNo_TXT.Text, CustomerID_TXT.Text, "", Product);

                if(status.status)
                {
                    MessageBox.Show("تم الإضافة بنجاح");
                   
                }
                else
                {
                    MessageBox.Show(status.message);
                    return;
                }
            }
           else
            {
                MessageBox.Show(status.message);
                return;
            }
        }

        private void CustomerID_TXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}