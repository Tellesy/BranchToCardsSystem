using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.Database;
using CTS.Screens;
using CTS.Screens.AuthRecharge;
using CTS.Screens.User;


using System.Windows.Forms;
using CTS.Screens.FilesAuth;
using CTS.Screens.Account_Details;

namespace CTS.Screens
{
    public partial class BranchAdmin : Form
    {
        public AuthRecharge.AuthRecharge authRecharge;
        public ChangePassword changePassword;
        private POBranchUnauth POApp;
        private Search search;

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

        private void Logout_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Reports_BTN_Click(object sender, EventArgs e)
        {
            CTS.Screens.Reports.RechargeReports rechargeReport = new Reports.RechargeReports();
            rechargeReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CTS.Screens.Card_Enquire.CardENQ cardAccount = new Card_Enquire.CardENQ();
            cardAccount.Show();
        }

        private void Card_BTN_Click(object sender, EventArgs e)
        {
            if (POApp == null)
            {
                POApp = new POBranchUnauth();
                POApp.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    POApp = null; Card_BTN.Enabled = true;
                };
                POApp.Show();
               Card_BTN.Enabled = false;
            }
        }

        private void ShareFolder_BTN_Click(object sender, EventArgs e)
        {
            CTS.ConnectToSharedFolder.ShowShareFolder();
        }

        private void AccountDetails_BTN_Click(object sender, EventArgs e)
        {
            if (search == null)
            {
                search = new Search();
                search.Closed += (s, args) => {
                    search = null; AccountDetails_BTN.Enabled = true;
                };
                search.Show();
                AccountDetails_BTN.Enabled = false;
            }
            
        }
    }
}
