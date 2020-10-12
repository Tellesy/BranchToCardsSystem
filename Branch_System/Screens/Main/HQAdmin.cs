using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTS.Database;
using CTS.Database.Objects;
using CTS.Screens;
using CTS.Screens.AuthRecharge;
using CTS.FilesCreator;
using CTS.Screens.User;
using System.Net;
using System.IO;
using CTS.Screens.Account_Details;
using System;
using System.Collections.Generic;
using CTS.Screens.Main.International_Cards.AuthIssue;

namespace CTS.Screens.Main
{
    public partial class HQAdmin : Form
    {

        private ChangePassword changePassword;
        private Search search;
        private AuthIssue authIssue;
        public HQAdmin()
        {
            InitializeComponent();
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

        private void UpdateUser_BTN_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_BTN_Click(object sender, EventArgs e)
        {
            CTS.Screens.User.Add_User adduser = new CTS.Screens.User.Add_User();
            adduser.Show();
        }

        private void AddCardAccount_BTN_Click(object sender, EventArgs e)
        {
            CTS.Screens.Card_Enquire.CardENQ cardAccount = new Card_Enquire.CardENQ();
            cardAccount.Show();
        }

        private void HQAdmin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //FileCreator
            FileExporter.POFile = new List<string>();
            System.IO.Directory.CreateDirectory(FileExporter.location);
            string RECEPT = String.Format(FileExporter.location + "RECEPT");
            string REFRESH = String.Format(FileExporter.location + "REFRESH");

            System.IO.Directory.CreateDirectory(RECEPT);
            System.IO.Directory.CreateDirectory(REFRESH);

            Status IssueStatus = Database.Recharge.checkYear();

            CheckStatus();

            Name_LBL.Text = Database.Login.name;
            //Branch_LBL.Text = Database.Login.branch;
            Amount_LBL.Text = Database.Recharge.amount.ToString();
            Year_LBL.Text = Database.Recharge.year;

            SheetManager.CreateFile();
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

        private void AuthAppRecord_BTN_Click(object sender, EventArgs e)
        {
            if(authIssue == null)
            {
                authIssue = new AuthIssue();
                

                authIssue.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    authIssue = null; AuthAppRecord_BTN.Enabled = true;
                };
                authIssue.Show();
                AuthAppRecord_BTN.Enabled = false;
            }
           
        }

        private void Logout_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
