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

namespace MPBS.Screens.PTS.Load
{
    public partial class Load : MaterialSkin.Controls.MaterialForm
    {

        private List<PTSProgram> programs;
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //ConfirmAmount_TXT.te
            GetPrograms();
        }


        private void TXTB_ONLY_NUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sumbit_BTN_Click(object sender, EventArgs e)
        {

            var selectedProgram = Program_CBox.SelectedValue;

            var prg = programs.First(p => p.Code == selectedProgram);
            int amount = int.Parse(Amount_TXT.Text);
            int confirmAmount = int.Parse(ConfirmAmount_TXT.Text);

            if(amount!=confirmAmount)
            {
                MessageBox.Show("Amount and Confrim Amount values are not equal");
                return;
            }

            //if(amount > )
        }
    }


}
