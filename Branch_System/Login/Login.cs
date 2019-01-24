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

namespace Branch_System.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_BTN_Click(object sender, EventArgs e)
        {
            string username = Username_TXT.Text;
            string password = Password_TXT.Text;

         Status status =  Database.Login.login(username, password);

            if(status.status)
            {
                if(Database.Login.role == "0" || Database.Login.role == "1")
                {
                   // MessageBox.Show("Welcome " + Database.Login.username + " ");
                    this.Hide();
                    Application app = new Application();
                    app.Closed += (s, args) => this.Show();
                    app.Show();
                   
                }
                else
                    MessageBox.Show("لا تملك الصلاحيات للدخول الى هذا النظام");
            }
            else
            {
                MessageBox.Show(status.message);
            }
        }
    }
}
