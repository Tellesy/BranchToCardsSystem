using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Database;
using MPBS.PersoOps;

namespace MPBS.Screens.PTS.Perso
{
    public partial class UploadEMBPINtoDB : MaterialSkin.Controls.MaterialForm
    {
        private string pinFileLocation;
        private string embFileLocation;
        public UploadEMBPINtoDB()
        {
            InitializeComponent();
        }

        private void UploadEMBPINtoDB_Load(object sender, EventArgs e)
        {

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private OpenFileDialog OpenFileDialog()
        {
            OpenFileDialog deviceDialog = new OpenFileDialog();
            deviceDialog.InitialDirectory = @"C:\";
            deviceDialog.RestoreDirectory = true;
            //deviceDialog.DefaultExt = "";
            //deviceDialog.Filter = "xlsx files (*.xlsx)|*.xlsx";
            deviceDialog.AddExtension = true;
            // DialogResult dr = deviceDialog.ShowDialog();

            return deviceDialog;
        }
        private void BrowseEmb_BTN_Click(object sender, EventArgs e)
        {
            var deviceDialog = OpenFileDialog();
            DialogResult dr = deviceDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                BrowseEMB_TXT.Text = deviceDialog.FileName;
                embFileLocation = deviceDialog.FileName;
                //PINFileRecordsReorder.ExtractRecordsFromFiles(deviceDialog.FileName);

            }
        }

        private void BrowsePIN_BTN_Click(object sender, EventArgs e)
        {
            var deviceDialog = OpenFileDialog();
            DialogResult dr = deviceDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                BrowsePIN_TXT.Text = deviceDialog.FileName;
                pinFileLocation = deviceDialog.FileName;

            }
        }

        private void Upload_BTN_Click(object sender, EventArgs e)
        {
           var embRecords =  DeviceAndPINReader.extractEMBFile(embFileLocation);

            int progress = 0;
            int count = 100 / embRecords.Count;
            foreach (EmbPINRecord emb in embRecords)
            {
               var status = PTSDeviceController.printDevice(emb.DeviceNumber);
                if(!status.status)
                {
                    MessageBox.Show(string.Format(@"Error in Updating device Number {0}", emb.DeviceNumber), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                progressBar.Increment(count);
            }
        }
    }
}
