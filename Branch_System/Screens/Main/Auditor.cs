using CTS.Database;
using CTS.Screens.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS.Screens.Main
{
    public partial class Auditor : Form
    {
        public ChangePassword changePassword;
        public Auditor()
        {
            InitializeComponent();
        }

        private void Reports_BTN_Click(object sender, EventArgs e)
        {
            CTS.Screens.Reports.RechargeReports rechargeReport = new Reports.RechargeReports();
            rechargeReport.Show();
        }

        private void Password_LBL_Click(object sender, EventArgs e)
        {
            if (changePassword == null)
            {
                changePassword = new ChangePassword();
                changePassword.Closed += (s, args) => {
                    //authRecharge.UnlockRecord();
                    Password_LBL.Enabled = true;
                    changePassword = null; //PBF_Auth_BTN.Enabled = true;
                };
                changePassword.Show();
                Password_LBL.Enabled = false;
            }
        }

        private void Auditor_Load(object sender, EventArgs e)
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

        private void CheckStatus()
        {
            throw new NotImplementedException();
        }
    }
}
