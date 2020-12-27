using MPBS.FilesCreator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.PTS.Perso
{
    public partial class GenerateEMBPIN : MaterialSkin.Controls.MaterialForm
    {
        private string pinFileLocation;
        private string embFileLocation;
        public GenerateEMBPIN()
        {
            InitializeComponent();
        }

        private void GenerateEMBPIN_Load(object sender, EventArgs e)
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

        private void Process_BTN_Click(object sender, EventArgs e)
        {
           var pin = PINFileRecordsReorder.extractPINString(pinFileLocation);

            string pinHeader = PINFileRecordsReorder.header;
            string pinFooter = PINFileRecordsReorder.footer;

            var emb = PINFileRecordsReorder.extractEMBString(embFileLocation);



            var sortedPIN = PINFileRecordsReorder.sortPINFile(emb, pin);


           var status = PINFileRecordsReorder.generatePINFile(sortedPIN,pinHeader,pinFooter);
            MessageBox.Show(status.status.ToString());
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
                //var SMTTransactions = this.ReadSMTTransactionSpreadSheet(deviceDialog.FileName);

                //var transactionsWithAccountNumber = new List<TransactionSettlements>();

                //if (SMTTransactions != null)
                //{

                //    transactionsWithAccountNumber = GetAccountNumberForTransaction(SMTTransactions);

                //    GenerateSettlementsSpreadSheets(transactionsWithAccountNumber);
                //}

            }
        }
    }
}
