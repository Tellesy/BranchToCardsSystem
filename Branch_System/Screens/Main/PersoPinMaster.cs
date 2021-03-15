using MPBS.Screens.PTS.Perso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.Main
{
    public partial class PersoPinMaster : MaterialSkin.Controls.MaterialForm
    {

        GenerateEMBPIN generateEMBPIN;
        UploadEMBPINtoDB uploadEMBPINtoDB;
        public PersoPinMaster()
        {
            InitializeComponent();
        }

        private void PersoPinMaster_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Name_LBL.Text = Database.Login.name;
            //Branch_LBL.Text = Database.Login.branch;
           // Amount_LBL.Text = Database.Recharge.amount.ToString();
            //Year_LBL.Text = Database.Recharge.year;
        }

        private void GenerateEMBPIN_BTN_Click(object sender, EventArgs e)
        {
            if (generateEMBPIN == null)
            {
                generateEMBPIN = new GenerateEMBPIN();


                generateEMBPIN.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    generateEMBPIN = null; SortEMBPINFiles_BTN.Enabled = true;
                };
                generateEMBPIN.Show();
                SortEMBPINFiles_BTN.Enabled = false;
            }
        }

        private void Logout_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UploadEMPAndPinFilesTODB_BTN_Click(object sender, EventArgs e)
        {
            if (uploadEMBPINtoDB == null)
            {
                uploadEMBPINtoDB = new UploadEMBPINtoDB();


                uploadEMBPINtoDB.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    uploadEMBPINtoDB = null; UploadEMPAndPinFilesTODB_BTN.Enabled = true;
                };
                uploadEMBPINtoDB.Show();
                UploadEMPAndPinFilesTODB_BTN.Enabled = false;
            }

        }
    }
}
