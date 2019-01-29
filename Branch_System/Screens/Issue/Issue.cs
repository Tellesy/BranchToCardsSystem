using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch_System.Database.Objects;

namespace Branch_System.Screens
{
    public partial class Issue : Form
    {
        private string Product;
        private string CardNumber;
        private string Customer_ID;

        private bool UpdateInfoFlag = false;

        public Issue()
        {
            InitializeComponent();
        }

        //Change it when you add new Product
        private void Product_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CardNumber != null)
                if (CardNumber.Length != 0)
                {
                    Database.Issue.unlockSequences(CardNumber);
                }

            switch (Product_CBox.SelectedIndex)
            {
                case 0:
                    Product = "10";
                    break;
                case 1:
                    Product = "30";
                    break;
            }
            Application_CBox.SelectedIndex = -1;
            EmptyBoxes();
            Application_CBox.Enabled = true;
        }

        private void EmptyBoxes()
        {
            CardNo_TXT.Text = "";
            CustomerName_TXT.Text = "";
            NID_TXT.Text = "";
            AccountUSD_TXT.Text = "";
            BirthDate_TXT.Text = "";
            PhoneNo_TXT.Text = "";
            Amount_TXT.Text = "";
            Passport.Text = "";
        }

        private void Application_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //First disable everything
            CustomerName_TXT.Enabled = false;
            NID_TXT.Enabled = false;
            AccountUSD_TXT.Enabled = false;
            BirthDate_TXT.Enabled = false;
            PhoneNo_TXT.Enabled = false;
            Amount_TXT.Enabled = false;
            Passport.Enabled = false;
            Submit_BTN.Enabled = true;

            if(CardNumber != null)
            if(CardNumber.Length != 0)
            {
                Database.Issue.unlockSequences(CardNumber);
            }
            //NIDUpdate_BTN.Enabled = true;
            int a = Application_CBox.SelectedIndex;
            Database.Status status = Database.Issue.getNewCardNumber(Product);
            if(status.status)
            {
                CardNumber = status.message;
                Database.Issue.lockSequences(CardNumber);
                CardNo_TXT.Text = CardNumber;
                CustomerName_TXT.Enabled = true;
                NID_TXT.Enabled = true;
                AccountUSD_TXT.Enabled = true;
                BirthDate_TXT.Enabled = true;
                PhoneNo_TXT.Enabled = true;
                Passport.Enabled = true;
                switch (a)
                {
                    case 0:
                            Amount_TXT.Enabled = true;
                        break;
                    case 1:
                            Amount_TXT.Enabled = false;
                        break;
                }
            }
           
            else
            {
                MessageBox.Show(status.message);
            }
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            
            switch (Application_CBox.SelectedIndex)
            {
                case 0:
                    IssueAndRecharege();
                    break;

                case 1:
                    IssueCard();
                    break;
            }


        }

        private void AccountUSD_TXT_TextChanged(object sender, EventArgs e)
        {
            if(AccountUSD_TXT.Text.Length >= 7)
            {
              this.Customer_ID = AccountUSD_TXT.Text.Substring(0, 7);
              Status<Customer> customer = Database.Issue.getCustomer(Customer_ID);
                
                if(customer.status)
                {
                    UpdateInfoFlag = false;
                    CustomerName_TXT.Text = customer.Object.Name;
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

        private void AccountUSD_TXT_Leave(object sender, EventArgs e)
        {
            
            //if (AccountUSD_TXT.Text.Length >= 7)
            //{
            //    Status<Customer> customer = Database.Issue.getCustomer(AccountUSD_TXT.Text.Substring(0, 7));

            //    if (!customer.status)
            //    {
            //        MessageBox.Show(customer.message);
            //    }

            //}
        }

        private void IssueAndRecharege()
        {
            if (!ValidateData())
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show( 
                " إصدار بطاقة وشحن للزبون \n"
                + CustomerName_TXT.Text 
                + "\n"
                + " بقيمة " 
                + "\n"
                + Amount_TXT.Text,
                "هل أنت متأكد",
                MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.No)
            {
                Amount_TXT.Text = "0";
                return;
            }

            if (Amount_TXT.Text == "" || Amount_TXT.Text == null)
            {
                MessageBox.Show("أدخل قيمة الشحن");
                return;
            }

              if (Amount_TXT.Text.Length > 0)
                if (int.Parse(Amount_TXT.Text) > Database.Recharge.amount)
                {
                    MessageBox.Show("قيمة شحن البطاقة تتجاوز الحد المسموح به لهذا العام");
                    return;
                }

                else if (int.Parse(Amount_TXT.Text) <= 0)
                {
                    MessageBox.Show("قيمة الشحن يجب ان تكون اكثر من 0");
                    Amount_TXT.Text = "";
                    return;
                }
                else
                {
                    if (!Database.Issue.hasCardAccount(this.Customer_ID, Product).status)
                    {

                       Database.Status status = Database.Issue.updateSequences(CardNumber);
                        if (!status.status)
                        {
                            MessageBox.Show(status.message);
                            return;
                        }
                        
                        status = Database.Issue.createCardAccount(CardNumber, AccountUSD_TXT.Text, Customer_ID, NID_TXT.Text, Product);
                        if (!status.status)
                        {
                            MessageBox.Show(status.message);
                            return;
                        }

                        status = Database.Issue.createCard(CardNumber, "");
                        if (!status.status)
                        {
                            MessageBox.Show(status.message);
                            return;
                        }

                        status = Database.Recharge.recharge(Customer_ID, NID_TXT.Text, int.Parse(Amount_TXT.Text), Product, CardNumber);
                        if (!status.status)
                        {
                            MessageBox.Show(status.message);
                            return;
                        }
                        AddToFile("IR");

                        Database.Status CAFStatus = Database.CAF.addCAF(CardNumber, CardNumber, SheetManager.Account_EXP_Date, Product);
                        if(!CAFStatus.status)
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

                        Database.Status POStatus = Database.PO.addPO(CardNumber,customerInfo,AccountUSD_TXT.Text,1,'D');
                        if (!POStatus.status)
                        {
                            MessageBox.Show("Error in Adding to PO table\n" + POStatus.message);
                        }

                        //Database.Status PBFStatus = Database.PBF.addPBF(CardNumber, int.Parse(Amount_TXT.Text));
                        //if (!PBFStatus.status)
                        //{
                        //    MessageBox.Show("Error in Adding to PBF table\n" + PBFStatus.message);
                        //}
                        //Update Customer Info if Flag = ture
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
                            Application_CBox.SelectedIndex = -1;
                            CustomerName_TXT.Enabled = false;
                            NID_TXT.Enabled = false;
                            AccountUSD_TXT.Enabled = false;
                            BirthDate_TXT.Enabled = false;
                            PhoneNo_TXT.Enabled = false;
                            Amount_TXT.Enabled = false;
                            Passport.Enabled = false;
                            Submit_BTN.Enabled = false;
                            return;
                        }
                        CardNumber = status.message;
                        CardNo_TXT.Text = CardNumber;
                    }
                    else MessageBox.Show("هذا الزبون لديه بطاقة, الرجاء التأكد او الذهاب الى خيار اعادة الاصدار");
                }
        }

        private void IssueCard()
        {
            if (!ValidateData())
            {
                return;
            }

        DialogResult dialogResult = MessageBox.Show(
                " إصدار بطاقة  \n"
                + CustomerName_TXT.Text
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

            if (!Database.Issue.hasCardAccount(this.Customer_ID, Product).status)
            {

                Database.Status status = Database.Issue.updateSequences(CardNumber);
                if (!status.status)
                {
                    MessageBox.Show(status.message);
                    return;
                }

                status = Database.Issue.createCardAccount(CardNumber, AccountUSD_TXT.Text, Customer_ID, NID_TXT.Text, Product);
                if (!status.status)
                {
                    MessageBox.Show(status.message);
                    return;
                }

                status = Database.Issue.createCard(CardNumber, "");
                if (!status.status)
                {
                    MessageBox.Show(status.message);
                    return;
                }

                AddToFile("I");

                Database.Status CAFStatus = Database.CAF.addCAF(CardNumber, CardNumber, SheetManager.Account_EXP_Date, Product);
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

                Database.Status POStatus = Database.PO.addPO(CardNumber, customerInfo, AccountUSD_TXT.Text, 1, 'D');
                if (!POStatus.status)
                {
                    MessageBox.Show("Error in Adding to PO table\n" + POStatus.message);
                }
                //Update Customer Info if Flag = ture
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
                    Application_CBox.SelectedIndex = -1;
                    CardNumber = "";
                    CustomerName_TXT.Enabled = false;
                    NID_TXT.Enabled = false;
                    AccountUSD_TXT.Enabled = false;
                    BirthDate_TXT.Enabled = false;
                    PhoneNo_TXT.Enabled = false;
                    Amount_TXT.Enabled = false;
                    Passport.Enabled = false;
                    Submit_BTN.Enabled = false;
                    return;
                }
                // Now Edit this
                CardNumber = status.message;
                CardNo_TXT.Text = CardNumber;
            }
            else MessageBox.Show("هذا الزبون لديه بطاقة, الرجاء التأكد او الذهاب الى خيار اعادة الاصدار");
                
        }

        private bool ValidateData()
        {

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

            if (CardNo_TXT.Text == "" ||  CustomerName_TXT.Text == "" ||
               AccountUSD_TXT.Text == "" || NID_TXT.Text == ""
               || BirthDate_TXT.Text == "" || PhoneNo_TXT.Text == "")
            {
                MessageBox.Show("الرجاء التأكد من تعبئة كل البيانات");
                return false;
            }

            return true;
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

            Cards.Add(Amount_TXT.Text);
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

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            Database.Issue.unlockSequences(CardNumber);
            this.Close();
        }

        public void UnlockRecord()
        {
            Database.Issue.unlockSequences(CardNumber);
        }

        private void Issue_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
