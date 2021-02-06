using System;
using System.Runtime.InteropServices;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using MPBS.Database;
using System.Reflection;
using MPBS.Screens.Main;
using MPBS.Screens.PTS.Perso;

namespace MPBS.Screens
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            
            
            MPBS.ConnectToSharedFolder.CreateShortcut();


            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            SheetManager.CreateFile();

            //await MPBSystem.CheckIfSystemActiveAsync();

            Assembly thisAssem = typeof(Login).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();

            Version ver = thisAssemName.Version;
            Status status = new Status();

            //We can skip this part 
            //from here 

            status = MPBSystem.GetActiveStatus();
            if (!status.status)
            {
                MessageBox.Show(status.message);
                this.Close();
            }
            //Run gpupdate in CMD to update to leatest verion
            //string strCmdText;
            //strCmdText = "/C gpupdate";
            ////System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = strCmdText;
            //process.StartInfo = startInfo;
            //process.Start();

            status = MPBSystem.CheckVersion(thisAssemName.Version.ToString());
            if (!status.status)
            {
                MessageBox.Show(status.message);
                this.Close();
            }
            //To here 
            Version_LBL.Text = Version_LBL.Text + " V" + thisAssemName.Version;

            
        }

        private void Login_BTN_Click(object sender, EventArgs e)
        {
          

            string username = Username_TXT.Text;
            string password = Password_TXT.Text;


           


            Status status =  Database.Login.login(username, password);

            if(status.status)
            {
                checkAndLogin();
            }
            else
            {
                MessageBox.Show(status.message);
            }


        }

        private void preLoginProcedure()
        {
            Username_TXT.Text = "";
            Password_TXT.Text = "";
            this.Hide();
        }
        private void checkAndLogin()
        {
            preLoginProcedure();

            switch (Database.Login.role)
            {
                case "0":
                    HQAdmin hqAdmin = new HQAdmin();
                    hqAdmin.Closed += (s, args) => this.Show();
                    hqAdmin.Show();
                    break;
                case "1":
                    Inputter app = new Inputter();
                    app.Closed += (s, args) => this.Show();
                    app.Show();
                    break;
                case "2":
                    BranchAdmin branchApp = new BranchAdmin();
                    branchApp.Closed += (s, args) => this.Show();
                    branchApp.Show();
                    break;
                case "3":
                    //Auditor auditorApp = new Auditor();
                    //auditorApp.Closed += (s, args) => this.Show();
                    //auditorApp.Show();
                    break;

                //Card Issuance is No.4
                case "4":
                    HQIssueMenu hQIssueMenu = new HQIssueMenu();
                    hQIssueMenu.Closed += (s, args) => this.Show();
                    hQIssueMenu.Show();
                    break;

                //Load Accounting is No.5
                case "5":
                    HQAccounting hqAccountingMenu = new HQAccounting();
                    hqAccountingMenu.Closed += (s, args) => this.Show();
                    hqAccountingMenu.Show();
                    break;

                case "6":
                    GenerateEMBPIN generateEMBPIN = new GenerateEMBPIN();
                    generateEMBPIN.Closed += (s, args) => this.Show();
                    generateEMBPIN.Show();
                    break;

                case "9":
                    HQLoadMenu hQLoad = new HQLoadMenu();
                    hQLoad.Closed += (s, args) => this.Show();
                    hQLoad.Show();
                    break;

                default:
                    MessageBox.Show("لا تملك الصلاحيات للدخول الى هذا النظام");
                    this.Show();
                    break;
            }
        }
        private void DomainLogin_BTN_Click(object sender, EventArgs e)
        {
            string username = Username_TXT.Text;
            string password = Password_TXT.Text;


            var result = Database.Login.ADlogin(username, password);

            if(!result.status)
            {
                MessageBox.Show(result.status.ToString());
                MessageBox.Show(result.message);
                return;
            }
            else
            {
                checkAndLogin();
            }
            Console.WriteLine(result.status);
        

        }

    

        
    }
}
