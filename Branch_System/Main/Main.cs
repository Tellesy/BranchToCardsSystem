using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch_System.Database;

namespace Branch_System.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
          Status IssueStatus = Database.Recharge.CheckYear();

            CheckStatus();

            Name_LBL.Text = Database.Login.name;
            Amount_LBL.Text = Database.Recharge.amount.ToString();
            Year_LBL.Text = Database.Recharge.year;




        }

        private void CheckStatus()
        {
            if (Database.Recharge.active != "True")
            {
                MessageBox.Show("عذراً, الشحن و الإصدار غير متاح");
                Status_LBL.Text = "غير متاح";
                Status_LBL.ForeColor = Color.Red;
                Start_BTN.Enabled = false;
            }
            else
            {
                Status_LBL.Text = "متاح";
                Status_LBL.ForeColor = Color.Green;
                Start_BTN.Enabled = true;

            }
        }

        private void Start_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Branch_System.Application app = new Branch_System.Application();
            app.Closed += (s, args) => this.Show();
            app.Show();
        }
    }
}
