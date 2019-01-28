using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch_System.Screens.AuthRecharge
{
    public partial class Authorize : Form
    {

        public Database.Objects.Recharge record;

        public Authorize()
        {
            InitializeComponent();
        }

        private void Authorize_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            if(record == null)
            {
                this.Close();
            }
            else
            {
                CustomerID_LBL.Text = record.Customer_ID;

                Database.Objects.Status<Database.Objects.Customer> status = Database.Issue.getCustomer(record.Customer_ID);

                if(status.status)
                {
                    CustomerName_LBL.Text = status.Object.Name;
                }

                NID_LBL.Text = record.NID;
                Branch_LBL.Text = record.Branch.ToString() ;
                Product_LBL.Text = record.Product;
                Inputter_LBL.Text = record.Inputter.ToString();
                Amount_LBL.Text = record.Amount.ToString();
            }
        }

        private void Accept_BTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من تخويل هذه العملية؟", "تخويل العملية", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            record = null;
            this.Close();
        }

        private void Deny_BTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من إلغاء هذه العملية؟", "إلغاء العملية", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
