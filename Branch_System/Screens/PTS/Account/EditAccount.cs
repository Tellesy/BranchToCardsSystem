using MPBS.Database;
using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.PTS.Account
{
    public partial class EditAccount : Form
    {
        private List<PTSProgram> programs;
        public EditAccount()
        {
            InitializeComponent();
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            GetPrograms();
        }

        private void GetPrograms()
        {
            Status<List<PTSProgram>> programStatus = PTSProgramController.getPrograms();

            if (programStatus.status)
            {
                programs = programStatus.Object;
                // foreach(var p in programStatus.Object)
                Program_CBox.DataSource = programStatus.Object;
                Program_CBox.DisplayMember = "NameEN";
                Program_CBox.ValueMember = "Code";
                this.Program_CBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void Program_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerID_TXT.Enabled = true;
            MainAccount_TXT.Enabled = false;
            ProgramAccount_TXT.Enabled = false;

            CustomerID_TXT.Text = "";
            MainAccount_TXT.Text = "";
            ProgramAccount_TXT.Text = "";
            Submit_BTN.Enabled = false;

            return;
        }

        private void CustomerID_TXT_TextChanged(object sender, EventArgs e)
        {
            if (CustomerID_TXT.Text.Count() == 7)
            {

                getAccount(Program_CBox.SelectedValue.ToString(), CustomerID_TXT.Text);
            }
        }
        private void getAccount(string programCode, string customerID)
        {
            var accountStatus = PTSAccountController.getAccount(customerID, programCode);
            if(!accountStatus.status || accountStatus.Object == null)
            {
                MessageBox.Show("لايوجد حساب لهذا الزبون تحت هذا المنتج, الرجاء التأكد");
                MainAccount_TXT.Enabled = false;
                ProgramAccount_TXT.Enabled = false;

                MainAccount_TXT.Text = "";
                ProgramAccount_TXT.Text = "";
                Submit_BTN.Enabled = false;

                return;
            }

            var account = accountStatus.Object;

            MainAccount_TXT.Enabled = true;
            ProgramAccount_TXT.Enabled = true;

            MainAccount_TXT.Text = account.AccountNumberLYD;
            ProgramAccount_TXT.Text = account.AccountNumberCurrency;
            Submit_BTN.Enabled = true;



        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {

            //validate Account
            string customerID = CustomerID_TXT.Text;
            string lydAccount = MainAccount_TXT.Text;
            string programAccount = ProgramAccount_TXT.Text;

            if(string.IsNullOrWhiteSpace(lydAccount) || lydAccount.Count() != 15 || lydAccount.Substring(0,7) != customerID)
            {
                MessageBox.Show("رقم الحساب الرئيسي غير صحيح");
                return;
            }

            if (string.IsNullOrWhiteSpace(programAccount) || programAccount.Count() != 15 || programAccount.Substring(0, 7) != customerID)
            {
                MessageBox.Show("رقم حساب المنتج  غير صحيح");
                return;
            }

            if(customerID.Count() != 7)
            {
                MessageBox.Show("رقم الزبون غير صحيح");
                return;
            }

            var status =  PTSAccountController.updateAccount(customerID, Program_CBox.SelectedValue.ToString(), lydAccount, programAccount);

            if(status.status)
            {
                MessageBox.Show("تم التعديل بنجاح");
                this.Close();
            }
            else
            {
                MessageBox.Show(status.message);
            }
        }
    }

  
}
