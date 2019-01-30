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

namespace Branch_System.Screens.FilesAuth
{
    public partial class AuthorizePBF : Form
    {
        public PBFObject record;
        public AuthorizePBF()
        {
            InitializeComponent();
        }

        private void AuthorizePBF_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = record.ID.ToString();
            Card_Account_LBL.Text = record.Card_Account;
            Inputter_LBL.Text = record.Inputter.ToString();
            Balance_LBL.Text = record.Balance.ToString();
            Time_LBL.Text = record.Time;

            Status<int> status = Database.Recharge.checkRechargeAmount(record.NID,record.Product);
            if(status.status)
            {
                Total_Amount_LBL.Text = status.Object.ToString();
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
                Database.Status status = Database.PBF.deletePBF(record.ID);
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

                Database.Status status = Database.PBF.authPBF(record.ID);

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

