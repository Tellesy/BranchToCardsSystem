using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Database.Objects;


namespace MPBS.Screens.PTS.Reports.SubScreens
{
    public partial class LoadRecordStatus : MaterialSkin.Controls.MaterialForm
    {
        public PTSLoad record;
        public LoadRecordStatus()
        {
            InitializeComponent();
        }

        private void LoadRecordStatus_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = record.ID.ToString();
            RecordID_TXT.Text = record.ID.ToString();
            CustomerID_TXT.Text = record.CustomerID;
            Amout_TXT.Text = record.Amount.ToString();
            InputDate_TXT.Text = record.InputTime.ToString();
            Inputter_TXT.Text = record.Inputter;
            BranchAuth_CBox.Checked = record.BranchAuthorizer == null ? false : true;
            BranchAuthDate_TXT.Text = !BranchAuth_CBox.Checked ? "" : record.BranchAuthorizeTime.ToString();
            BranchAuth_TXT.Text = record.BranchAuthorizer == null ? "" : record.BranchAuthorizer;
            HQAuth_CBox.Checked = record.HQAuthorizer == null ? false : true;
            HQAuthDate_TXT.Text = !HQAuth_CBox.Checked ? "" : record.HQAuthorizeTime.ToString();
            HQAuth_TXT.Text = record.HQAuthorizer == null ? "" : record.HQAuthorizer;

            MCLoaded_CBox.Checked = record.Generated;
            MCLoadedDate_TXT.Text = !CBSGenFlag_CBox.Checked ? "" : record.GenTime.ToString();

            CBSGenFlag_CBox.Checked = record.CBSFileGen;
            CBSGenFlagDate_TXT.Text = !CBSGenFlag_CBox.Checked ? "" : record.CBSFileGenTime.ToString();








        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
