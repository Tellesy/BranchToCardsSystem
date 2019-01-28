using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch_System;
using Branch_System.Database;
using Branch_System.Database.Objects;

namespace Branch_System.Screens
{
    public partial class Recharge : Form
    {
        private string Product;
        public Recharge()
        {
            InitializeComponent();
        }

        private void Validate_BTN_Click(object sender, EventArgs e)
        {
            int AmountThisYear = 0;
            int AmountTotal = 0;
            int RechargeAmount = 0;
            //Check for Empty boxes
            //if one empty return true
            if (CheckEmpty())
            {
                return;
            }

            //Check for Card Account
            Status s = Database.Recharge.checkCardAccount(CardNo_TXT.Text);

            if (!s.status)
            {
                MessageBox.Show(s.message);
                return;
            }

            Status<int> status = Database.Recharge.checkRechargeAmountThisYear(NID_TXT.Text, Product);

            if (!status.status)
            {
                MessageBox.Show(status.message);
                return;
            }
            AmountThisYear = status.Object;
            Total_This_Year_TXT.Text = AmountThisYear.ToString();

            status = Database.Recharge.checkRechargeAmount(NID_TXT.Text, Product);

            if (!status.status)
            {
                MessageBox.Show(status.message);
                return;
            }
            AmountTotal = status.Object;
            Total_Amount_TXT.Text = AmountTotal.ToString();

            if(Product == "30")
            {
                if(AmountThisYear <= Database.Recharge.amount)
                {
                    Submit_BTN.Enabled = true;

                }
                else
                {
                    MessageBox.Show("إجمالي قيمة الشحن تتجاوز السقف المسموح به لهذا العام");
                    return;
                }
            }
            else
            {
                Submit_BTN.Enabled = true;
            }
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            int AmountThisYear = 0;
            int AmountTotal = 0;
            int RechargeAmount = 0;

            //Check for Empty boxes
            //if one empty return true
            if (CheckEmpty())
            {
                return;
            }

            //Check for Card Account
            Status s = Database.Recharge.checkCardAccount(CardNo_TXT.Text);

            if (!s.status)
            {
                MessageBox.Show(s.message);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                " شحن للبطاقة \n"
                + CardNo_TXT.Text
                + "\n"
                + " بقيمة "
                + "\n"
                + Amount_TXT.Text,
                "هل أنت متأكد",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                Amount_TXT.Text = "0";
                return;
            }
            //Is first time to charge or not
            Status<int> status = Database.Recharge.checkRechargeAmountThisYear(NID_TXT.Text, Product);

            if(!status.status)
            {
                MessageBox.Show(status.message);
                return;
            }
            AmountThisYear = status.Object;
            Total_This_Year_TXT.Text = AmountThisYear.ToString();

            status = Database.Recharge.checkRechargeAmount(NID_TXT.Text, Product);

            if (!status.status)
            {
                MessageBox.Show(status.message);
                return;
            }
            AmountTotal = status.Object;
            Total_Amount_TXT.Text = AmountTotal.ToString();

            if(int.Parse(Amount_TXT.Text) > 0)
            {
                if(Product == "30")
                {
                    RechargeAmount = int.Parse(Amount_TXT.Text) + AmountThisYear;

                    if (RechargeAmount <= Database.Recharge.amount)
                    {
                        //Add recharge to the records
                        Database.Recharge.recharge(Customer_ID.Text, NID_TXT.Text, int.Parse(Amount_TXT.Text), Product, CardNo_TXT.Text);

                        //To add it BPF file
                        RechargeAmount = int.Parse(this.Amount_TXT.Text) + AmountTotal;

                        if(AmountTotal > 0)
                        {
                            AddToFile("R");
                        }
                        else
                        {
                            AddToFile("RFirst");
                        }

                        //Database.Status PBFStatus = Database.PBF.addPBF(CardNo_TXT.Text, RechargeAmount);
                        //if (!PBFStatus.status)
                        //{
                        //    MessageBox.Show("Error in Adding to PBF table\n" + PBFStatus.message);
                        //}

                    }
                    else
                    {
                        MessageBox.Show("إجمالي قيمة الشحن تتجاوز السقف المسموح به لهذا العام");
                        return;
                    }
                }
                else
                {
                    //Add recharge to the records
                    Database.Recharge.recharge(Customer_ID.Text, NID_TXT.Text, int.Parse(Amount_TXT.Text), Product, CardNo_TXT.Text);

                    //To add it BPF file
                    RechargeAmount = int.Parse(this.Amount_TXT.Text) + AmountTotal;


                    if (AmountTotal > 0)
                    {
                        AddToFile("R");
                    }
                    else
                    {
                        AddToFile("RFirst");
                    }

                    //Database.Status PBFStatus = Database.PBF.addPBF(CardNo_TXT.Text, RechargeAmount);
                    //if (!PBFStatus.status)
                    //{
                    //    MessageBox.Show("Error in Adding to PBF table\n" + PBFStatus.message);
                    //}
                }

                Submit_BTN.Enabled = false;
                EmptyBoxes();

            }
            else
            {
                MessageBox.Show("قيمة الشحن يجب ان تكون اكبر من صفر");
            }
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Product_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Product_CBox.SelectedIndex)
            {
                case 0:
                    Product = "10";
                    EnableBoxes();
                    break;
                case 1:
                    Product = "30";
                    EnableBoxes();
                    break;
                case -1:
                default:
                    CardNo_TXT.Enabled = false;
                    NID_TXT.Enabled = false;
                    Amount_TXT.Enabled = false;
                    //Submit_BTN.Enabled = false;
                    Validate_BTN.Enabled = false;
                    Customer_ID.Enabled = false;
                    break;
            }
            EmptyBoxes();
            
        }

        private void EmptyBoxes()
        {
            CardNo_TXT.Text = "";
            NID_TXT.Text = "";
            Customer_ID.Text = "";
            Amount_TXT.Text = "";
        }

        private void EnableBoxes()
        {
            CardNo_TXT.Enabled = true;
            NID_TXT.Enabled = true;
            Amount_TXT.Enabled = true;
            Customer_ID.Enabled = true;
            Validate_BTN.Enabled = true;
            //Submit_BTN.Enabled = true;

        }

        private bool CheckEmpty()
        {
            bool flag = false;
            String messages = "رجاءً قم بتعبئة الخانات التالية" + "\n";

            if (CardNo_TXT.Text.Length < 16)
            {
                messages += "رقم حساب البطاقة" + "\n";
                flag = true;
            }
            if (NID_TXT.Text.Length < 12)
            {
                messages += " الرقم الوطني" + "\n";
                flag = true;
            }
            if (Customer_ID.Text.Length < 7)
            {
                messages += "رقم الزبون" + "\n";
                flag = true;
            }
            if (Amount_TXT.Text.Length == 0)
            {
                messages += "قيمة الشحن" + "\n";
                flag = true;
            }

            if(flag)
            {
                MessageBox.Show(messages);
            }

            return flag;

        }

        private void AddToFile(string sheet)
        {
            List<string> Cards = new List<string>();

            Cards.Add(CardNo_TXT.Text);
            Cards.Add(CardNo_TXT.Text);
            //Customer Name
            Cards.Add("");
            //Customer ID instead of Customer Account
            Cards.Add(Customer_ID.Text);
            //Cards.Add(Account_EXP_Date);
            Cards.Add(SheetManager.Account_EXP_Date);

            //Old Amount
            Cards.Add(Total_Amount_TXT.Text);

            Cards.Add(Amount_TXT.Text);
            //Passport
            Cards.Add("");
            //Phone
            Cards.Add("");

            //Cards.Add(PO_Begin_Date);
            Cards.Add(SheetManager.PO_Begin_Date);
            //Cards.Add(PO_EXP_Date);
            Cards.Add(SheetManager.PO_EXP_Date);
            //BirthDate
            Cards.Add("30061999");
            Cards.Add("Email");

            SheetManager.AddToExcelSheet(Cards, Product, sheet);
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

        private void Customer_ID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Recharge_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }

   
}
