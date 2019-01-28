using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch_System.Database;
using Branch_System.Screens;
using Branch_System.Screens.AuthRecharge;


using System.Windows.Forms;

namespace Branch_System.Screens
{
    public partial class BranchAdmin : Form
    {
        public AuthRecharge.AuthRecharge authRecharge;
        public BranchAdmin()
        {
            InitializeComponent();
        }

        private void CheckStatus()
        {
            if (Database.Recharge.active != "True")
            {
                MessageBox.Show("عذراً, الشحن و الإصدار غير متاح");
                Status_LBL.Text = "غير متاح";
                Status_LBL.ForeColor = Color.Red;
            }
            else
            {
                Status_LBL.Text = "متاح";
                Status_LBL.ForeColor = Color.Green;
            }
        }
        private void BranchAdmin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Status IssueStatus = Database.Recharge.checkYear();

            CheckStatus();

            Name_LBL.Text = Database.Login.name;
            Branch_LBL.Text = Database.Login.branch;
            Amount_LBL.Text = Database.Recharge.amount.ToString();
            Year_LBL.Text = Database.Recharge.year;

            SheetManager.CreateFile();
        }

        private void Logout_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recharge_BTN_Click(object sender, EventArgs e)
        {
            if (authRecharge == null)
            {
                authRecharge = new AuthRecharge.AuthRecharge();
                authRecharge.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    authRecharge = null; Recharge_BTN.Enabled = true; };
                authRecharge.Show();
                Recharge_BTN.Enabled = false;
            }
        }
    }
}
