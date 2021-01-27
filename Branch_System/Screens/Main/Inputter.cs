using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MPBS.Database;

using MPBS.Screens.PTS.Account;
using MPBS.Screens.PTS.Customer;
using MPBS.Screens.PTS.Reports;
using MPBS.Screens.User;

namespace MPBS.Screens
{
    public partial class Inputter : MaterialSkin.Controls.MaterialForm
    {
        public ChangePassword changePassword;
        private PTS.Issue.Issue PTS_issue;
        private PTS.Load.Load PTS_load;
        private EditCustomer editCustomer;
        private EditAccount editAccount;
        private ReportsGenerator reportGenerator;

        public Inputter()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
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
               
            }
            else
            {
                Status_LBL.Text = "متاح";
                Status_LBL.ForeColor = Color.Green;
                //Issue_BTN.Enabled = true;
                //Recharge_BTN.Enabled = true;
                //PIN_BTN.Enabled = true;
                //Reissue_BTN.Enabled = true;
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
                    Password_BTN.Enabled = true;
                    changePassword = null; //PBF_Auth_BTN.Enabled = true;
                };
                changePassword.Show();
                Password_BTN.Enabled = false;
            }
        }

       

        private void CardENQ_BTN_Click(object sender, EventArgs e)
        {

        }

        private void ShareFolder_BTN_Click(object sender, EventArgs e)
        {
            MPBS.ConnectToSharedFolder.ShowShareFolder();
        }


        private void Issue_PTS_BTN_Click(object sender, EventArgs e)
        {
            if(PTS_issue==null)
            {
                PTS_issue = new PTS.Issue.Issue();
                PTS_issue.Closed += (s, args) => {
                    PTS_issue = null; Issue_PTS_BTN.Enabled = true;
                };

                PTS_issue.Show();
                Issue_PTS_BTN.Enabled = false;
                //PTS_issue.FormClosed
            }
        }

        private void PTSLoadWallet_BTN_Click(object sender, EventArgs e)
        {
            if (PTS_load == null)
            {
                PTS_load = new PTS.Load.Load();
                PTS_load.Closed += (s, args) => {
                    PTS_load = null; PTSLoadWallet_BTN.Enabled = true;
                };

                PTS_load.Show();
                PTSLoadWallet_BTN.Enabled = false;
                //PTS_issue.FormClosed
            }
        }

        private void EditCustomerInformation_BTN_Click(object sender, EventArgs e)
        {
            try
            {
  

                string customerID = Interaction.InputBox("Please Enter Customer ID?", "Search for Customer", "1000000");

                if(customerID.Count() < 7)
                {
                    MessageBox.Show("رقم الزبون غير صحيح");
                    return;
                }
            

                var status = PTSCustomerController.getCustomer(customerID);
                if(!status.status)
                {
                    MessageBox.Show("لا يوجد زبون بهذا الرقم");
                    return;
                }
                else
                {
                    if(string.IsNullOrWhiteSpace(status.Object.CustomerID))
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
    }
}
