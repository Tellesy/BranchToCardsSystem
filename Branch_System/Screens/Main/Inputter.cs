using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTS.Database;

namespace CTS.Screens
{
    public partial class Inputter : Form
    {
        private Issue issueApp;
        private Recharge recargeApp;
        private ReIssue reIssueApp;
        private PIN pin;

        public Inputter()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Status IssueStatus = Database.Recharge.checkYear();

            CheckStatus();

            Name_LBL.Text   = Database.Login.name;
            Branch_LBL.Text = Database.Login.branch;
            Amount_LBL.Text = Database.Recharge.amount.ToString();
            Year_LBL.Text   = Database.Recharge.year;
            SheetManager.CreateFile();
        }

        private void CheckStatus()
        {
            if (Database.Recharge.active != "True")
            {
                MessageBox.Show("عذراً, الشحن و الإصدار غير متاح");
                Status_LBL.Text = "غير متاح";
                Status_LBL.ForeColor = Color.Red;
                Issue_BTN.Enabled = false;
                Recharge_BTN.Enabled = false;
                PIN_BTN.Enabled = false;
                Reissue_BTN.Enabled = false;
            }
            else
            {
                Status_LBL.Text = "متاح";
                Status_LBL.ForeColor = Color.Green;
                Issue_BTN.Enabled = true;
                Recharge_BTN.Enabled = true;
                PIN_BTN.Enabled = true;
                Reissue_BTN.Enabled = true;
            }
        }

        private void Logout_BTN_Click(object sender, EventArgs e)
        {
            if (issueApp != null)
                issueApp.Close();
            if (recargeApp != null)
                recargeApp.Close();
            if (reIssueApp != null)
                reIssueApp.Close();
            if (pin != null)
                pin.Close();


            this.Close();
        }

        private void Issue_BTN_Click(object sender, EventArgs e)
        {
            if(issueApp == null)
            {
                issueApp = new Issue();
                issueApp.Closed += (s, args) => { issueApp.UnlockRecord(); issueApp = null; Issue_BTN.Enabled = true;};
                issueApp.Show();
                Issue_BTN.Enabled = false;
            }
            else
            {
                
            }
            
        }

        private void Recharge_BTN_Click(object sender, EventArgs e)
        {
            if (recargeApp == null)
            {
                recargeApp = new Recharge(); 
                recargeApp.Closed += (s, args) => { recargeApp = null; Recharge_BTN.Enabled = true; };
                recargeApp.Show();
                Recharge_BTN.Enabled = false;
            }
            else
            {

            }
        }

        private void Reissue_BTN_Click(object sender, EventArgs e)
        {
            if (reIssueApp == null)
            {
                reIssueApp = new ReIssue();
                reIssueApp.Closed += (s, args) => { reIssueApp.UnlockRecord(); reIssueApp = null; Reissue_BTN.Enabled = true; };
                reIssueApp.Show();
                Reissue_BTN.Enabled = false;
            }
            else
            {

            }
        }

        private void PIN_BTN_Click(object sender, EventArgs e)
        {
            if (pin == null)
            {
                pin = new PIN();
                pin.Closed += (s, args) => {  pin = null; PIN_BTN.Enabled = true; };
                pin.Show();
                PIN_BTN.Enabled = false;
            }
            else
            {

            }
        }
    }
}
