using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.Database;
using CTS.Database.Objects;
using System.Windows.Forms;

namespace CTS.Screens.FilesAuth
{
    public partial class AuthorizePO : Form
    {

        public PObject record;
        
        public AuthorizePO()
        {
            InitializeComponent();
        }

        private void AuthorizePO_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = record.ID.ToString();
            CustomerID_LBL.Text = record.Customer_ID;
            CustomerName_LBL.Text = record.Name;
            Account_LBL.Text = record.Account;
            Card_Number_LBL.Text = record.Card_Number;
            Branch_LBL.Text = record.Branch_Code;
            Begin_Date_LBL.Text = record.Begin_Date;
            Exp_Date_LBL.Text = record.End_Date;
            Inputter_LBL.Text = record.Inputter.ToString();
            Phone_LBL.Text = record.Phone;
            Process_Indicator_LBL.Text = record.Process_Indicator.ToString();
            Update_Code_LBL.Text = record.Update_Code.ToString();
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
                Database.Status status = Database.PO.deletePO(record.ID);
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

                Database.Status status = Database.PO.authPO(record.ID);

                if (status.status)
                {
                    //Get Total Amount to be added to PBF
                  

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
