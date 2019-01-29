using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch_System.Database;
using Branch_System.Screens;
using Branch_System.Screens.AuthRecharge;

namespace Branch_System.Screens
{
    public partial class Admin : Form
    {
        private AuthRecharge.AuthRecharge unauthRecords;
        private POUnauth POApp;
        public Admin()
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

        private void Admin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
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

        private void UnuthReport_BTN_Click(object sender, EventArgs e)
        {
            if (unauthRecords == null)
            {
                unauthRecords = new AuthRecharge.AuthRecharge();
                unauthRecords.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    unauthRecords = null; UnuthReport_BTN.Enabled = true;
                };
                unauthRecords.Show();
                UnuthReport_BTN.Enabled = false;
            }
        }

        private void Logout_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PO_Auth_BTN_Click(object sender, EventArgs e)
        {
            if (POApp == null)
            {
                POApp = new POUnauth();
                POApp.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    POApp = null; PO_Auth_BTN.Enabled = true;
                };
                POApp.Show();
                PO_Auth_BTN.Enabled = false;
            }
        }
    }
}
