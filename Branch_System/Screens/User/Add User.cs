using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.User
{
    public partial class Add_User : Form
    {
        private int userType;

        public Add_User()
        {
            InitializeComponent();
        }

        private void Product_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmptyBoxes();


            Submit_BTN.Enabled = false;
            EMPID_TXT.Enabled = false;
            BranchNumber_TXT.Enabled = false;
            Username_TXT.Enabled = false;
            Password_TXT.Enabled = false;
            Name_TXT.Enabled = false;
            Submit_BTN.Enabled = false;

            switch (Product_CBox.SelectedIndex)
            {
                case 0:
                    userType = 1;
                    EnableFields();
                    break;
                case 1:
                    userType = 2;
                    EnableFields();
                    break;

                case 2:
                    userType = 3;
                    EnableFields();
                    break;
                default:


                    Submit_BTN.Enabled = false;
                    EMPID_TXT.Enabled = false;
                    BranchNumber_TXT.Enabled = false;
                    Username_TXT.Enabled = false;
                    Password_TXT.Enabled = false;
                    Name_TXT.Enabled = false;
                    Submit_BTN.Enabled = false;
                    EmptyBoxes();
                    break;
            }
        }

        private void EmptyBoxes()
        {
            EMPID_TXT.Text = "";
            BranchNumber_TXT.Text = "";
            Username_TXT.Text = "";
            Password_TXT.Text = "";
            Name_TXT.Text = "";

        }
        private void EnableFields()
        {
            Submit_BTN.Enabled = true;
            EMPID_TXT.Enabled = true;
            BranchNumber_TXT.Enabled = true;
            Username_TXT.Enabled = true;
            Password_TXT.Enabled = true;
            Name_TXT.Enabled = true;
            Submit_BTN.Enabled = true;
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if(EMPID_TXT.Text == "" || BranchNumber_TXT.Text == "" || Username_TXT.Text == "" || Password_TXT.Text == "" || Name_TXT.Text == "")
            {
                MessageBox.Show("الرجاء تعبئة كل الحقول");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("هل أنت متأكد؟", "هل أنت متأكد؟", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                EmptyBoxes();
                return;
            }

            Database.Status status = Database.User.addUser(userType, Int16.Parse(EMPID_TXT.Text), Int16.Parse(BranchNumber_TXT.Text), Username_TXT.Text, Password_TXT.Text, Name_TXT.Text);
            if (status.status)
            {
                MessageBox.Show("تم الإضافة بنجاح");
                EmptyBoxes();
            }
            else
            {
                MessageBox.Show(status.message);
                return;
            }

        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            Product_CBox.Enabled = true;
        }
    }
}
