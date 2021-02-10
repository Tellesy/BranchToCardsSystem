using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Screens.PTS.Reports;

namespace MPBS.Screens.Main.SubMenu
{
    public partial class Enquiry : MaterialSkin.Controls.MaterialForm
    {

        private LoadReports loadReports;
        public Enquiry()
        {
            InitializeComponent();
        }

        private void Enquiry_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void LoadStatus_BTN_Click(object sender, EventArgs e)
        {
            if (loadReports == null)
            {
                loadReports = new LoadReports();
                loadReports.Closed += (s, args) => {
                    //authRecharge.UnlockRecord();
                    LoadStatus_BTN.Enabled = true;
                    loadReports = null; //PBF_Auth_BTN.Enabled = true;
                };
                loadReports.Show();
                LoadStatus_BTN.Enabled = false;
            }
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
