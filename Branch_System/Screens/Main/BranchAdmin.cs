using System;
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


using MPBS.Screens.PTS.BranchAuthIssue;
using MPBS.Screens.PTS.Load;

using MPBS.Screens.PTS.Customer;
using MPBS.Screens.PTS.Account;
using Microsoft.VisualBasic;
using MPBS.Screens.PTS.Reports;
using MPBS.SpreadSheet.Structure;
using MPBS.SpreadSheet;
using MPBS.Database.Objects;
using MPBS.Screens.Charges;
using MPBS.Screens.Main.SubMenu;

namespace MPBS.Screens
{
    public partial class BranchAdmin : MaterialSkin.Controls.MaterialForm
    {

        public ChangePassword changePassword;
        private GenerateChargesFiles generateChargesFiles;
        
        private EditCustomer editCustomer;
        private EditAccount editAccount;
        private ReportsGenerator reportGenerator;

        private BranchAuthorizeSubMenu branchAuthorizeSubMenu;

        private BranchEditSubMenu branchEditSubMenu;

        private BranchDeleteSubMenu branchDeleteSubMenu;

        private Enquiry enquiry;


        public BranchAdmin()
        {
            InitializeComponent();
        }

        private void CheckStatus()
        {
            if (Database.YearController.active != "True")
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

            Status IssueStatus = Database.YearController.checkYear();

            CheckStatus();

            Name_LBL.Text = Database.Login.name;
            Branch_LBL.Text = Database.Login.branch;
            Amount_LBL.Text = Database.YearController.amount.ToString();
            Year_LBL.Text = Database.YearController.year;

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
            int errorCount = 0;
            int SuccesfulCount = 0;
            List<string> logs = new List<string>();
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
                    
                    MessageBox.Show(cblRecords.message, "Error in Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    l.Year = Database.YearController.year;
                    l.BranchCode = cbl.BranchCode;

                    //Check if customer exist
                    var cStatus = PTSCustomerController.getCustomer(l.CustomerID);
                    if(!cStatus.status || cStatus.Object == null)
                    {
                        string error = string.Format("Customer ID {0} data does not excist in the system", l.CustomerID);
                        MessageBox.Show(error,"Error in Customer ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        //Add to logs
                        logs.Add(error);
                        errorCount++;
                        continue;
                    }

                    //Check if Account Exist
                    var aStatus = PTSAccountController.getAccount(l.CustomerID, programCode);
                    if (!aStatus.status || aStatus.Object == null)
                    {
                        string error = string.Format("Account {0} data does not excist in the system", l.CustomerID);
                        MessageBox.Show(error, "Error in Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Add to logs
                        logs.Add(error);
                        errorCount++;
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
                            string error = string.Format("There is an issue related to getting the customer yearly balance for Customer {0}", l.CustomerID);
                            MessageBox.Show(error, "Error in Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //Add to logs
                            logs.Add(error);
                            errorCount++;
                            continue;
                        }

                        int total = sBalance.Object.Sum(i => i.Amount);


                        if ((total + l.Amount) > YearlyLimit)
                        {
                            string error = string.Format("The total Load Request for this customer {0} exceeds the yearly limit for this program ", l.CustomerID);
                            MessageBox.Show(error, "Error in Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //Add to logs
                            logs.Add(error);
                            errorCount++;
                            continue;
                        }





                        var pstatus = PTSLoadController.addLoadRecordFromCBLReport(l);
                        if(pstatus.status)
                        {
                            SuccesfulCount++;
                        }
                        else
                        {

                            string error = string.Format("Error in Adding Load record for Customer ID {0}", l.CustomerID);
                            MessageBox.Show(error, "Error in Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //Add to logs
                            logs.Add(error);
                            errorCount++;

                        }
                    }
                 

                    //Check if there is a load with same date
                    
                }

                logs.Add(string.Format("Number of Errors: {0}   Number of Succesfully Added Records {1}",errorCount,SuccesfulCount));
                //Create log file
                string location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CBL Load Files\" + branch.Object.Code;
                string folder = DateTime.Now.ToString("dd-MM-yyyy");
                string filename = "CBL File Logs " + DateTime.Now.ToString("dd-MM-yyyy-hhmmss")+".txt";
                System.IO.Directory.CreateDirectory(location + @"\" + folder);

                System.IO.File.WriteAllLines((location+@"\"+folder+@"\"+filename),logs);



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

        private void BranchAuthorzieSubMenu_Click(object sender, EventArgs e)
        {
            if (branchAuthorizeSubMenu == null)
            {
                branchAuthorizeSubMenu = new BranchAuthorizeSubMenu();
                branchAuthorizeSubMenu.Closed += (s, args) => {
                    //authRecharge.UnlockRecord();
                    BranchAuthorzieSubMenu.Enabled = true;
                    branchAuthorizeSubMenu = null; //PBF_Auth_BTN.Enabled = true;
                };
                branchAuthorizeSubMenu.Show();
                BranchAuthorzieSubMenu.Enabled = false;
            }
        }

        private void EditRecordsSubMenu_BTN_Click(object sender, EventArgs e)
        {

            if (branchEditSubMenu == null)
            {
                branchEditSubMenu = new BranchEditSubMenu();
                branchEditSubMenu.Closed += (s, args) => {
                    //authRecharge.UnlockRecord();
                    EditRecordsSubMenu_BTN.Enabled = true;
                    branchEditSubMenu = null; //PBF_Auth_BTN.Enabled = true;
                };
                branchEditSubMenu.Show();
                EditRecordsSubMenu_BTN.Enabled = false;
            }
        }

        private void DeleteSubMenu_BTN_Click(object sender, EventArgs e)
        {
            if (branchDeleteSubMenu == null)
            {
                branchDeleteSubMenu = new BranchDeleteSubMenu();
                branchDeleteSubMenu.Closed += (s, args) => {
                    //authRecharge.UnlockRecord();
                    DeleteSubMenu_BTN.Enabled = true;
                    branchEditSubMenu = null; //PBF_Auth_BTN.Enabled = true;
                };
                branchDeleteSubMenu.Show();
                DeleteSubMenu_BTN.Enabled = false;
            }
        }

        private void Enquiry_BTN_Click(object sender, EventArgs e)
        {
            if (enquiry == null)
            {
                enquiry = new Enquiry();
                enquiry.Closed += (s, args) => {
                    //authRecharge.UnlockRecord();
                    Enquiry_BTN.Enabled = true;
                    enquiry = null; //PBF_Auth_BTN.Enabled = true;
                };
                enquiry.Show();
                Enquiry_BTN.Enabled = false;
            }
        }
    }
}
