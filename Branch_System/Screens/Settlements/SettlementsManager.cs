using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Settlements;
using MPBS.Settlements.PTS.ReportTemplates;

namespace MPBS.Screens.SettlementsSecreens
{
    public partial class SettlementsManager : MaterialSkin.Controls.MaterialForm
    {
        private string transactionReportFileLocation;
        public SettlementsManager()
        {
            InitializeComponent();
        }

        private void SettlementsManager_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void BrowseReport_BTN_Click(object sender, EventArgs e)
        {
            var deviceDialog = OpenFileDialog();
            DialogResult dr = deviceDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                BrowseReport_BTN.Text = deviceDialog.FileName;
                transactionReportFileLocation = deviceDialog.FileName;
                //PINFileRecordsReorder.ExtractRecordsFromFiles(deviceDialog.FileName);

            }
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

        private void Process_BTN_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(transactionReportFileLocation))
            {
                var obj = MPBS.Settlements.SettlementsManager.PTS_TransactionsReportReader(transactionReportFileLocation);
                if(obj.status)
                {

                }
            }
        }
    }
}
