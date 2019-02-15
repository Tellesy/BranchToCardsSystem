using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS.Screens.User
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = NewPassword_TXT.Text;
            string confirmPassword = ConfirmPassword_TXT.Text;
            string password = Password_TXT.Text;

            if(newPassword == confirmPassword)
            {

            }
            else
            {
                MessageBox.Show("كلمة المرور الجديدة غير متطابقة, الرجاء التأكد");
            }
        }
    }
}
