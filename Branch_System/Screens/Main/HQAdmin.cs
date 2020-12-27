using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Database;
using MPBS.Database.Objects;
using MPBS.Screens;
using MPBS.Screens.AuthRecharge;
using MPBS.FilesCreator;
using MPBS.Screens.User;
using System.Net;
using System.IO;
using MPBS.Screens.Account_Details;
using System;
using System.Collections.Generic;
using MPBS.Screens.PTS.BranchAuthIssue;
using MPBS.Screens.PTS.Generate_File;
using MPBS.Screens.PTS.AuthIssue;
using MPBS.Screens.UploadFile;
using MPBS.Screens.PTS.Load;
using MPBS.Screens.PTS.Perso;

namespace MPBS.Screens.Main
{
    public partial class HQAdmin : MaterialSkin.Controls.MaterialForm
    {

        private ChangePassword changePassword;
        private Search search;
        private BranchAuthIssue branchAuthIssue;
        private HQAuthIssue hQAuthIssue;
        private GenerateT24Files generateT24Files;
        private HQAuthLoad hQAuthLoad;
        private GenLoadFile genLoadFile;
        GenerateEMBPIN generateEMBPIN;
        private GenAppRecord genAppRecord;
        public HQAdmin()
        {
            InitializeComponent();
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

        private void UpdateUser_BTN_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_BTN_Click(object sender, EventArgs e)
        {
            MPBS.Screens.User.Add_User adduser = new MPBS.Screens.User.Add_User();
            adduser.Show();
        }

        private void AddCardAccount_BTN_Click(object sender, EventArgs e)
        {
            MPBS.Screens.Card_Enquire.CardENQ cardAccount = new Card_Enquire.CardENQ();
            cardAccount.Show();
        }

        private void HQAdmin_Load(object sender, EventArgs e)
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
            if(branchAuthIssue == null)
            {
                branchAuthIssue = new BranchAuthIssue();
                

                branchAuthIssue.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    branchAuthIssue = null; unAuthAppRecord_BTN.Enabled = true;
                };
                branchAuthIssue.Show();
                unAuthAppRecord_BTN.Enabled = false;
            }
           
        }

        private void Logout_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AuthLoadRequests_BTN_Click(object sender, EventArgs e)
        {
            if (hQAuthLoad == null)
            {
                hQAuthLoad = new HQAuthLoad();


                hQAuthLoad.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    hQAuthLoad = null; AuthLoadRequests_BTN.Enabled = true;
                };
                hQAuthLoad.Show();
                AuthLoadRequests_BTN.Enabled = false;
            }
        }

        private void GenLoadFiles_BTN_Click(object sender, EventArgs e)
        {
            if (genLoadFile == null)
            {
                genLoadFile = new GenLoadFile();


                genLoadFile.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    genLoadFile = null; GenLoadFiles_BTN.Enabled = true;
                };
                genLoadFile.Show();
                GenLoadFiles_BTN.Enabled = false;
            }
        }

        private void UnauthBrasnchLoad_BTN_Click(object sender, EventArgs e)
        {

        }

        private void GenerateEMBPIN_BTN_Click(object sender, EventArgs e)
        {

            if (generateEMBPIN == null)
            {
                generateEMBPIN = new GenerateEMBPIN();


                generateEMBPIN.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    generateEMBPIN = null; GenerateEMBPIN_BTN.Enabled = true;
                };
                generateEMBPIN.Show();
                GenerateEMBPIN_BTN.Enabled = false;
            }
        }
    }
}
