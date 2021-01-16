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

namespace MPBS.Screens.PTS.Reports
{
    public partial class ReportsGenerator : MaterialSkin.Controls.MaterialForm
    {
        private List<PTSProgram> programs;
        public bool isBranch =true;
        public ReportsGenerator()
        {
            InitializeComponent();
        }

        private void ReportsMenu_Load(object sender, EventArgs e)
        {
            GetPrograms();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            FromDate_DTP.CustomFormat = "yyyy-MM-dd";
            FromDate_DTP.Format = DateTimePickerFormat.Custom;
            ToDate_DTP.CustomFormat = "yyyy-MM-dd";
            ToDate_DTP.Format = DateTimePickerFormat.Custom;

            //Get Products

        }

        private void Generate_BTN_Click(object sender, EventArgs e)
        {

            if(CardIssuingReport_RBTN.Checked)
            {
                getCardIssuingReport();
            }

          
        }

        private void getCardIssuingReport()
        {
            string fromDate = FromDate_DTP.Value.ToString("yyyy-MM-dd");
            string toDate = ToDate_DTP.Value.ToString("yyyy-MM-dd");

            var rStatus = ReportsController.getPTSCardsIssueReport(fromDate, toDate, isBranch, Program_CBox.SelectedValue.ToString());
            if (rStatus.status)
            {
                string fileName = "Card Issuing Report" + DateTime.Now.ToString("yyyyMMddhhmmss");
                SpreadSheet.SettlementsFiles.GenerateTemplateSpreadsheet(fileName, rStatus.Object, false);
            }
            else
            {
                MessageBox.Show(rStatus.message);
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

        private void CardIssuingReport_RBTN_CheckedChanged(object sender, EventArgs e)
        {
            Generate_BTN.Enabled = true ;
        }
    }
}
