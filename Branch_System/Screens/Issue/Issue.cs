using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch_System.Screens.Issue
{
    public partial class Issue : Form
    {
        private string Product;
        private string CardNumber;

        public Issue()
        {
            InitializeComponent();
        }

        //Change it when you add new Product
        private void Product_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            //NIDUpdate_BTN.Enabled = true;
            int a = Application_CBox.SelectedIndex;
            Database.Status status = Database.Issue.getNewCardNumber(Product);
            if(status.status)
            {
                CardNumber = status.message;
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
    }
}
