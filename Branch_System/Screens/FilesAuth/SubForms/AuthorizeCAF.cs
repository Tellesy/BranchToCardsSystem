using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTS.Database.Objects;

namespace CTS.Screens.FilesAuth
{
    public partial class AuthorizeCAF : Form
    {
        public CAFObject record;
        public AuthorizeCAF()
        {
            InitializeComponent();
        }

        private void AuthorizeCAF_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = record.ID.ToString();
            Card_Number.Text = record.Card_Number;
            Card_Account_LBL.Text = record.Card_Account;
            Inputter_LBL.Text = record.Inputter.ToString();
            EXP_DATE_LBL.Text = record.EXP_Date;
            Product_LBL.Text = record.Product;
            Time_LBL.Text = record.Time;
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
                Database.Status status = Database.CAF.deleteCAF(record.ID);
                if (status.status)
                {
                    MessageBox.Show("تم إلغاء العملية بنجاح");
                    record = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(status.message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Accept_BTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من تخويل هذه العملية؟", "تخويل العملية", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Database.Status status = Database.CAF.authCAF(record.ID);

                if (status.status)
                {
                    MessageBox.Show("تم تخويل العملية بنجاح");
                    record = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(status.message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
