using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Branch_System.Database;


namespace Branch_System.Screens
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
                    this.Hide();
                    Inputter app = new Inputter();
                    app.Closed += (s, args) => this.Show();
                    app.Show();
                   
                }
                else if(Database.Login.role == "2")
                {
                    this.Hide();
                    BranchAdmin branchApp = new BranchAdmin();
                    branchApp.Closed += (s, args) => this.Show();
                    branchApp.Show();
                }
                else if(Database.Login.role == "0")
                {
                    this.Hide();
                    Admin adminApp = new Admin();
                    adminApp.Closed += (s, args) => this.Show();
                    adminApp.Show();
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
