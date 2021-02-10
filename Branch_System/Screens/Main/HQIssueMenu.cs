using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Database;
using MPBS.Database.Objects;
using MPBS.Screens;

using MPBS.FilesCreator;
using MPBS.Screens.User;
using System.Net;
using System.IO;

using System;
using System.Collections.Generic;
using MPBS.Screens.PTS.BranchAuthIssue;
using MPBS.Screens.PTS.Generate_File;
using MPBS.Screens.PTS.AuthIssue;
using MPBS.Screens.UploadFile;
using MPBS.Screens.PTS.Load;
using Microsoft.VisualBasic;
using MPBS.Screens.PTS.Account;
using MPBS.Screens.PTS.Customer;
using MPBS.Screens.PTS.Reports;
using MPBS.Screens.Main.SubMenu;

namespace MPBS.Screens.Main
{
    public partial class HQIssueMenu : MaterialSkin.Controls.MaterialForm
    {
        private ChangePassword changePassword;
        private BranchAuthIssue branchAuthIssue;
        private HQAuthIssue hQAuthIssue;
        private GenAppRecord genAppRecord;
        private EditCustomer editCustomer;
        private EditAccount editAccount;
        private GenerateT24Files generateT24Files;
        private ReportsGenerator reportGenerator;

        private Enquiry enquiry;

        public HQIssueMenu()
        {
            InitializeComponent();
        }

        private void HQIssueMenu_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

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

            //Generate PTS Files
            MPBSConfig.CreateFolders();

            Status IssueStatus = Database.YearController.checkYear();

            CheckStatus();

            Name_LBL.Text = Database.Login.name;
            //Branch_LBL.Text = Database.Login.branch;
            Amount_LBL.Text = Database.YearController.amount.ToString();
            Year_LBL.Text = Database.YearController.year;

            SheetManager.CreateFile();
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

        private void unAuthAppRecord_BTN_Click(object sender, EventArgs e)
        {

            if (branchAuthIssue == null)
            {
                branchAuthIssue = new BranchAuthIssue();


                branchAuthIssue.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    branchAuthIssue = null; unAuthAppRecord_BTN.Enabled = true;
                };
                branchAuthIssue.Show();
                unAuthAppRecord_BTN.Enabled = false;
            }
        }

        private void HQAuthAppRecord_BTN_Click(object sender, EventArgs e)
        {
            if (hQAuthIssue == null)
            {
                hQAuthIssue = new HQAuthIssue();


                hQAuthIssue.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    hQAuthIssue = null; HQAuthAppRecord_BTN.Enabled = true;
                };
                hQAuthIssue.Show();
                HQAuthAppRecord_BTN.Enabled = false;
            }
        }

        private void GenFiles_BTN_Click(object sender, EventArgs e)
        {

            if (genAppRecord == null)
            {
                genAppRecord = new GenAppRecord();


                genAppRecord.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    genAppRecord = null; GenFiles_BTN.Enabled = true;
                };
                genAppRecord.Show();
                GenFiles_BTN.Enabled = false;
            }
        }

        private void Logout_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void GenerateT24_BTN_Click(object sender, EventArgs e)
        {
            if (generateT24Files == null)
            {
                generateT24Files = new GenerateT24Files();


                generateT24Files.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    generateT24Files = null; GenerateT24_BTN.Enabled = true;
                };
                generateT24Files.Show();
                GenerateT24_BTN.Enabled = false;
            }
        }

        private void Reports_BTN_Click(object sender, EventArgs e)
        {
            if (reportGenerator == null)
            {
                reportGenerator = new ReportsGenerator();
                reportGenerator.isBranch = false;
                reportGenerator.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    reportGenerator = null; Reports_BTN.Enabled = true;
                };
                reportGenerator.Show();
                Reports_BTN.Enabled = false;
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
