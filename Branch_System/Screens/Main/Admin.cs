using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


namespace MPBS.Screens
{
    public partial class Admin : Form
    {


        private ChangePassword changePassword;


        public Admin()
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

        private void Admin_Load(object sender, EventArgs e)
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

   


        private void PO_Gen_BTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد؟", " Generate PO file", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CreatePOFile();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void CAF_Gen_BTN_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد؟", " Generate CAF file", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CreateCAFile();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void PBF_Gen_BTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد؟", " Generate PBF file", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CreatePBFile();

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void CreateCAFile()
        {
            List<int> Processed_IDs = new List<int>();
            //First Get all Auth CAF files
            Status<List<CAFObject>> statusObject = Database.CAF.getAuthCAF();

            if(statusObject.status)
            {
                //Add each record to FileCreator List
                foreach(CAFObject record in statusObject.Object)
                {
                    //Get Limits for record product
                    Status<Product> status = Database.CAF.getLimit(record.Product);
                    if(status.status)
                    {
                        Product p = status.Object;
                        //start adding to FileCreator
                        FileExporter.Card_Account_Number_s = record.Card_Account;
                        FileExporter.Card_Number_s = record.Card_Number;
                        FileExporter.AggregateDailyLimit_s = (p.Cash_Limit + p.POS_Limit).ToString(); //"5000";
                        FileExporter.CashDailyLimit_s = p.Cash_Limit.ToString();
                        FileExporter.POSDailyLimit_s = p.POS_Limit.ToString();
                        FileExporter.CashTransCount_s = p.Cash_Transactions_Limit.ToString();
                        FileExporter.POSTransCount_s = p.POS_Transactions_Limit.ToString();
                        FileExporter.CAFExpDate_s = record.EXP_Date;
                        if (!record.HONOR)
                        {
                            FileExporter.HONOR = "9";
                        }
                        else
                            FileExporter.HONOR = "1";
                        FileExporter.AddToCAFile();

                        Processed_IDs.Add(record.ID);
                    }
                    else
                    {
                        MessageBox.Show(record.Card_Number + "\n" + status.message);
                    }
                }

                //Export CAF
                FileExporter.CAFileExporter();
                FileExporter.CAFile = new List<string>();
                FileExporter.isFirstCAF = true;
                //Update DB to reflect processed CAFs
                foreach (int id in Processed_IDs)
                {
                    Status s = Database.CAF.processCAF(id);
                    if(!s.status)
                    { MessageBox.Show(s.message); }
                }
                
                
            }
            else
            {
                MessageBox.Show(statusObject.message);
            }
        }

        private void CreatePBFile()
        {
            List<int> Processed_IDs = new List<int>();
            //First Get all Auth CAF files
            Status<List<PBFObject>> statusObject = Database.PBF.getAuthPBF();

            if (statusObject.status)
            {
                //Add each record to FileCreator List
                foreach (PBFObject record in statusObject.Object)
                {
                        //start adding to FileCreator
                    FileExporter.Card_Account_Number_s = record.Card_Account;
                    FileExporter.Amount_s = record.Balance;

                    FileExporter.AddToBPFile();

                    Processed_IDs.Add(record.ID);
                }

                //Export PBF
                FileExporter.BPFileExporter();
                FileExporter.BPFile = new List<string>();
                FileExporter.isFirstBP = true;

                //Update DB to reflect processed PBFs
                foreach (int id in Processed_IDs)
                {
                    Status s = Database.PBF.processPBF(id);
                    if (!s.status)
                    { MessageBox.Show(s.message); }
                }


            }
            else
            {
                MessageBox.Show(statusObject.message);
            }
        }

        private void CreatePOFile()
        {
            List<int> Processed_IDs = new List<int>();
            //First Get all Auth CAF files
            Status<List<PObject>> statusObject = Database.PO.getAuthPO();

            if (statusObject.status)
            {
                //Add each record to FileCreator List
                foreach (PObject record in statusObject.Object)
                {
                    //start adding to FileCreator
                    FileExporter.Bank_Account_Number_1_s = record.Account;
                    FileExporter.Card_Begin_Date_s = record.Begin_Date;
                    FileExporter.Branch_Code_s = record.Branch_Code;
                    FileExporter.Card_Number_s = record.Card_Number;
                    //FileExporter.ID_Code_s = record.Customer_ID;
                    FileExporter.Email_s = record.Email;
                    FileExporter.Card_End_Date_s = record.End_Date;
                    FileExporter.Card_Holder_Name_s = record.Name;
                    FileExporter.Passport_ID_s = record.Passport;
                    FileExporter.Phone_Number_s = record.Phone;
                    FileExporter.CARD_PROCESS_INDICATOR_s = record.Process_Indicator.ToString();
                    FileExporter.Update_code_s = record.Update_Code.ToString() ;


                    FileExporter.AddToPOFile();

                    Processed_IDs.Add(record.ID);
                }

                //Export PBF
                FileExporter.POFileExporter();
                FileExporter.POFile = new List<string>();

                //Update DB to reflect processed PBFs
                foreach (int id in Processed_IDs)
                {
                    Status s = Database.PO.processPO(id);
                    if (!s.status)
                    { MessageBox.Show(s.message); }
                }


            }
            else
            {
                MessageBox.Show(statusObject.message);
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



        private void AddUser_BTN_Click(object sender, EventArgs e)
        {
            MPBS.Screens.User.Add_User adduser = new MPBS.Screens.User.Add_User();
            adduser.Show();
        }


      
  

        private void ShareFolder_BTN_Click(object sender, EventArgs e)
        {
            MPBS.ConnectToSharedFolder.ShowShareFolder();
        }



        private void UpdateUser_BTN_Click(object sender, EventArgs e)
        {

        }
    }
}
