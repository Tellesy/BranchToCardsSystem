using MPBS.Screens.PTS.BranchAuthIssue;
using MPBS.Screens.PTS.Load;
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
    public partial class BranchAuthorizeSubMenu : MaterialSkin.Controls.MaterialForm
    {
        private BranchAuthLoad branchAuthLoad;
        private BranchAuthIssue authIssue;
        public BranchAuthorizeSubMenu()
        {
            InitializeComponent();
        }

        private void BranchAuthorizeSubMenu_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
        }

        private void PTSIssueAuth_BTN_Click(object sender, EventArgs e)
        {
            if (authIssue == null)
            {
                authIssue = new BranchAuthIssue();
                authIssue.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    authIssue = null; PTSIssueAuth_BTN.Enabled = true;
                };
                authIssue.Show();
                PTSIssueAuth_BTN.Enabled = false;
            }
        }

        private void PTSLoadAuth_BTN_Click(object sender, EventArgs e)
        {
            if (branchAuthLoad == null)
            {
                branchAuthLoad = new BranchAuthLoad();
                branchAuthLoad.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    branchAuthLoad = null; PTSLoadAuth_BTN.Enabled = true;
                };
                branchAuthLoad.Show();
                PTSLoadAuth_BTN.Enabled = false;
            }
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
