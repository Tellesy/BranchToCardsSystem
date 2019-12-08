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
using CTS.Database;
using System.Reflection;
using CTS.Screens.Main;

namespace CTS.Screens
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            //Testing Area
            CTS.ConnectToSharedFolder.CreateShortcut();
            //End of Testing 

            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            SheetManager.CreateFile();

         await CTSystem.CheckIfSystemActiveAsync();

            Assembly thisAssem = typeof(Login).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();

            Version ver = thisAssemName.Version;
            Status status = new Status();

            //We can skip this part 
            //from here 

            status = CTSystem.GetActiveStatus();
            if (!status.status)
            {
                MessageBox.Show(status.message);
                this.Close();
            }
            status = CTSystem.CheckVersion(thisAssemName.Version.ToString());
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
                if(Database.Login.role == "1")
                {
                    Username_TXT.Text = "";
                    Password_TXT.Text = "";
                    this.Hide();
                    Inputter app = new Inputter();
                    app.Closed += (s, args) => this.Show();
                    app.Show();
                   
                }
                else if(Database.Login.role == "2")
                {
                    Username_TXT.Text = "";
                    Password_TXT.Text = "";
                    this.Hide();
                    BranchAdmin branchApp = new BranchAdmin();
                    branchApp.Closed += (s, args) => this.Show();
                    branchApp.Show();
                }
                else if(Database.Login.role == "0")
                {
                    Username_TXT.Text = "";
                    Password_TXT.Text = "";
                    this.Hide();
                    Admin adminApp = new Admin();
                    adminApp.Closed += (s, args) => this.Show();
                    adminApp.Show();
                }
                else if(Database.Login.role == "3")
                {
                    Username_TXT.Text = "";
                    Password_TXT.Text = "";
                    this.Hide();
                    Auditor auditorApp = new Auditor();
                    auditorApp.Closed += (s, args) => this.Show();
                    auditorApp.Show();
                }
                else
                {
                    MessageBox.Show("لا تملك الصلاحيات للدخول الى هذا النظام");
                }
            }
            else
            {
                MessageBox.Show(status.message);
            }


        }

      
    }
}
