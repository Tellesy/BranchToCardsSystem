﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPBS.Database;
using MPBS.Screens;
using MPBS.Screens.AuthRecharge;
using MPBS.Screens.User;


using System.Windows.Forms;
using MPBS.Screens.FilesAuth;
using MPBS.Screens.Account_Details;
using MPBS.Screens.PTS.BranchAuthIssue;
using MPBS.Screens.PTS.Load;
using MPBS.Screens.Charges;

namespace MPBS.Screens
{
    public partial class BranchAdmin : MaterialSkin.Controls.MaterialForm
    {
        public AuthRecharge.AuthRecharge authRecharge;
        public ChangePassword changePassword;
        private POBranchUnauth POApp;
        private Search search;
        private BranchAuthLoad branchAuthLoad;
        private GenerateChargesFiles generateChargesFiles;
        //PTSScreens
        private BranchAuthIssue authIssue;

        public BranchAdmin()
        {
            InitializeComponent();
        }

        private void CheckStatus()
        {
            if (Database.Recharge.active != "True")
            {
                MessageBox.Show("عذراً, الشحن و الإصدار غير متاح");
                Status_LBL.Text = "Not Available";
                Status_LBL.ForeColor = Color.Red;
            }
            else
            {
                Status_LBL.Text = "Available";
                Status_LBL.ForeColor = Color.Green;
            }
        }
        private void BranchAdmin_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

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
                    Password_BTN.Enabled = true;
                    changePassword = null; //PBF_Auth_BTN.Enabled = true;
                };
                changePassword.Show();
                Password_BTN.Enabled = false;
            }
        }

        private void Reports_BTN_Click(object sender, EventArgs e)
        {
            MPBS.Screens.Reports.RechargeReports rechargeReport = new Reports.RechargeReports();
            rechargeReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MPBS.Screens.Card_Enquire.CardENQ cardAccount = new Card_Enquire.CardENQ();
            cardAccount.Show();
        }

   

        private void ShareFolder_BTN_Click(object sender, EventArgs e)
        {
            MPBS.ConnectToSharedFolder.ShowShareFolder();
        }

    

        private void PTSIssueAuthBTN_Click(object sender, EventArgs e)
        {

            if (authIssue == null)
            {
                authIssue = new BranchAuthIssue();
                authIssue.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    authIssue = null; PTSIssueAuth_BTN.Enabled = true;
                };
                authIssue.Show();
                PTSIssueAuth_BTN.Enabled = false;
            }
        }

        private void Password_BTN_Click(object sender, EventArgs e)
        {
            if (changePassword == null)
            {
                changePassword = new ChangePassword();
                changePassword.Closed += (s, args) => {
                    //authRecharge.UnlockRecord();
                    Password_BTN.Enabled = true;
                    changePassword = null; //PBF_Auth_BTN.Enabled = true;
                };
                changePassword.Show();
                Password_BTN.Enabled = false;
            }
        }

        private void PTSLoadAuth_BTN_Click(object sender, EventArgs e)
        {
            if (branchAuthLoad == null)
            {
                branchAuthLoad = new BranchAuthLoad();
                branchAuthLoad.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    branchAuthLoad = null; PTSLoadAuth_BTN.Enabled = true;
                };
                branchAuthLoad.Show();
                PTSLoadAuth_BTN.Enabled = false;
            }
        }

        private void ChargesAndLoadFiles_BTN_Click(object sender, EventArgs e)
        {
            if (generateChargesFiles == null)
            {
                generateChargesFiles = new GenerateChargesFiles();
                generateChargesFiles.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    generateChargesFiles = null; ChargesAndLoadFiles_BTN.Enabled = true;
                };
                generateChargesFiles.Show();
                ChargesAndLoadFiles_BTN.Enabled = false;
            }
        }
    }
}
