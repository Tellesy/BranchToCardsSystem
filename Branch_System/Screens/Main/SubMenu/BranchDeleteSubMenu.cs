using MPBS.Screens.PTS.Delete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.Main.SubMenu
{
    public partial class BranchDeleteSubMenu : MaterialSkin.Controls.MaterialForm
    {
        private BranchDeleteIssue branchDeleteIssue;
        //private BranchDeleteLoad branchDeleteIssue;

        public BranchDeleteSubMenu()
        {
            InitializeComponent();
        }

        private void BranchDeleteSubMenu_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
        }

        private void PTSIssueDelete_BTN_Click(object sender, EventArgs e)
        {
            if (branchDeleteIssue == null)
            {
                branchDeleteIssue = new BranchDeleteIssue();
                branchDeleteIssue.Closed += (s, args) => {
                    //authRecharge.UnlockRecord();
                    PTSIssueDelete_BTN.Enabled = true;
                    branchDeleteIssue = null; //PBF_Auth_BTN.Enabled = true;
                };
                branchDeleteIssue.Show();
                PTSIssueDelete_BTN.Enabled = false;
            }
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
