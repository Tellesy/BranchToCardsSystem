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

using MPBS.Screens.User;


using System.Windows.Forms;

using MPBS.Screens.Account_Details;
using MPBS.Screens.PTS.BranchAuthIssue;
using MPBS.Screens.PTS.Load;
using MPBS.Screens.Charges;
using MPBS.Screens.PTS.Customer;
using MPBS.Screens.PTS.Account;
using Microsoft.VisualBasic;
using MPBS.Screens.PTS.Reports;
using MPBS.SpreadSheet.Structure;
using MPBS.SpreadSheet;
using MPBS.Database.Objects;

namespace MPBS.Screens
{
    public partial class BranchAdmin : MaterialSkin.Controls.MaterialForm
    {

        public ChangePassword changePassword;

        private Search search;
        private BranchAuthLoad branchAuthLoad;
        private GenerateChargesFiles generateChargesFiles;
        //PTSScreens
        private BranchAuthIssue authIssue;
        private EditCustomer editCustomer;
        private EditAccount editAccount;
        private ReportsGenerator reportGenerator;

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

        private void EditCustomerInformation_BTN_Click(object sender, EventArgs e)
        {
            try
            {


                string customerID = Interaction.InputBox("Please Enter Customer ID?", "Search for Customer", "1000000");

                if (customerID.Count() < 7)
                {
                    MessageBox.Show("رقم الزبون غير صحيح");
                    return;
                }


                var status = PTSCustomerController.getCustomer(customerID);
                if (!status.status)
                {
                    MessageBox.Show("لا يوجد زبون بهذا الرقم");
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(status.Object.CustomerID))
                    {
                        MessageBox.Show("لا يوجد زبون بهذا الرقم");
                        return;
                    }
                    if (editCustomer == null)
                    {
                        editCustomer = new EditCustomer();
                        editCustomer.customer_id = customerID;

                        editCustomer.Closed += (s, args) => { //authRecharge.UnlockRecord();
                            editCustomer = null; EditCustomerInformation_BTN.Enabled = true;
                        };
                        editCustomer.Show();
                        EditCustomerInformation_BTN.Enabled = false;
                    }


                }



            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void EditAccountInformation_BTN_Click(object sender, EventArgs e)
        {
            if (editAccount == null)
            {
                editAccount = new EditAccount();


                editAccount.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    editAccount = null; EditAccountInformation_BTN.Enabled = true;
                };
                editAccount.Show();
                EditAccountInformation_BTN.Enabled = false;
            }
        }

        private void Reports_BTN_Click(object sender, EventArgs e)
        {
            if (reportGenerator == null)
            {
                reportGenerator = new ReportsGenerator();
                reportGenerator.isBranch = true;
                reportGenerator.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    reportGenerator = null; Reports_BTN.Enabled = true;
                };
                reportGenerator.Show();
                Reports_BTN.Enabled = false;
            }
        }

        private void UploadCBLLoadReport_BTN_Click(object sender, EventArgs e)
        {
            int YearlyLimit = 10000;
            string programCode = "TF019";
            var branch = PTSBranchController.getBranch(int.Parse(Database.Login.branch));
            if(!branch.status || branch.Object == null)
            {
                MessageBox.Show("Error", branch.message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userPTSBranchCode = branch.Object.Code;

            var deviceDialog = OpenFileDialog();
            DialogResult dr = deviceDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {



                var cblRecords = CBLReports.CBLLoadReportReader(deviceDialog.FileName);

                if(!cblRecords.status)
                {
                    MessageBox.Show("Error! " + cblRecords.message );
                    return;
                }


                List<PTSLoad> loads = new List<PTSLoad>();
                foreach (var cbl in cblRecords.Object.FindAll(i=>i.BranchCode== userPTSBranchCode))
                {
                    PTSLoad l = new PTSLoad();
                    l.InputTime = DateTime.Parse(cbl.Date);
                    l.ProgramCode = programCode;
                    l.Inputter = Database.Login.id;
                    l.InputTime = DateTime.Parse(cbl.Date);
                    l.CustomerID = cbl.CustomerID;
                    l.Amount = int.Parse(cbl.AmountUSD);
                    l.ExchangeRate = decimal.Parse(cbl.ExchangeRate);
                    l.FromCBLFlag = true;
                    l.Year = Database.Recharge.year;
                    l.BranchCode = cbl.BranchCode;

                    //Check if customer exist
                    var cStatus = PTSCustomerController.getCustomer(l.CustomerID);
                    if(!cStatus.status || cStatus.Object == null)
                    {
                        MessageBox.Show(string.Format("زبون رقم {0} غير موجود في النظام, ارجو الإضافة بشكل يدوي", l.CustomerID));
                        continue;
                    }

                    var status = PTSLoadController.getCBSLoadRecordByCustomerIDAndDate(l.CustomerID, cbl.Date, l.Amount);
                    if(status.status || status.Object.Count > 0)
                    {

                        MessageBox.Show(string.Format("عملية الشحن للزبون {0} موجودة مسبقاً", l.CustomerID));
                    }
                    else
                    {

                        //Check total
                        var sBalance = PTSLoadController.getTotalLoadAuthorizedRecordsForClient(l.CustomerID, l.ProgramCode, l.Year);

                        if (!sBalance.status)
                        {

                            MessageBox.Show(string.Format("There is an issue related to getting the customer yearly balance for Customer {0}",l.CustomerID));
                            continue;
                        }

                        int total = sBalance.Object.Sum(i => i.Amount);


                        if ((total + l.Amount) > YearlyLimit)
                        {
                            MessageBox.Show("Sorry, The total Load Request for this customer exceeds the yearly limit for this program");
                            continue;
                        }





                        var pstatus = PTSLoadController.addLoadRecordFromCBLReport(l);
                        if(pstatus.status)
                        {
                           
                        }
                        else
                        {
                            MessageBox.Show("Error with Customer ID "+l.CustomerID,"Error");

                        }
                    }
                 

                    //Check if there is a load with same date
                    
                }


                MessageBox.Show("Done!");

            }
      
        }
        public static string getBranchCode(string name)
        {
            if(name.Contains("المصرف الإسلامي - الرئيسي"))
            {
                return "1002";
            }
            if (name.Contains("المصرف الاسلامي - فرع تاجوراء"))
            {
                return "1004";
            }
            if (name.Contains("المصرف الاسلامي - فرع مصراتة"))
            {
                return "1005";
            }
            if (name.Contains("المصرف الإسلامي - فرع السواني"))
            {
                return "1006";
            }
            if (name.Contains("المصرف الإسلامي - فرع هون"))
            {
                return "1007";
            }
            if (name.Contains("لمصرف الاسلامي - فرع السياحية"))
            {
                return "1008";
            }
            else
            {
                return null;
            }

           



        }
        private OpenFileDialog OpenFileDialog()
        {
            OpenFileDialog deviceDialog = new OpenFileDialog();
            deviceDialog.InitialDirectory = @"C:\";
            deviceDialog.RestoreDirectory = true;
            deviceDialog.DefaultExt = "xlsx";
            deviceDialog.Filter = "xlsx files (*.xlsx)|*.xlsx";
            deviceDialog.AddExtension = true;
            // DialogResult dr = deviceDialog.ShowDialog();

            return deviceDialog;
        }
    }
}
