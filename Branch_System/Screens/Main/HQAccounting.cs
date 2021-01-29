using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Database;
using MPBS.Database.Objects;
using MPBS.Screens;
using MPBS.FilesCreator;
using MPBS.Screens.User;
using System.Net;
using System.IO;

using System;
using System.Collections.Generic;
using MPBS.Screens.PTS.BranchAuthIssue;
using MPBS.Screens.PTS.Generate_File;
using MPBS.Screens.PTS.AuthIssue;
using MPBS.Screens.UploadFile;
using MPBS.Screens.PTS.Load;
using MPBS.Screens.SettlementsSecreens;

namespace MPBS.Screens.Main
{
    public partial class HQAccounting : MaterialSkin.Controls.MaterialForm
    {
        private ChangePassword changePassword;

        private BranchAuthIssue branchAuthIssue;
        private BranchAuthLoad branchAuthLoad;

        private HQAuthIssue hQAuthIssue;
        private GenerateT24Files generateT24Files;
        private HQAuthLoad hQAuthLoad;
        private GenLoadFile genLoadFile;
        private SettlementsManager settlementsManager;

        public HQAccounting()
        {
            InitializeComponent();
        }

        private void HQAccounting_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            this.CenterToScreen();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void UnauthBrasnchLoad_BTN_Click(object sender, EventArgs e)
        {
            if (branchAuthLoad == null)
            {
                branchAuthLoad = new BranchAuthLoad();


                branchAuthLoad.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    branchAuthLoad = null; UnauthBrasnchLoad_BTN.Enabled = true;
                };
                branchAuthLoad.Show();
                UnauthBrasnchLoad_BTN.Enabled = false;
            }
        }

        private void AuthLoadRequests_BTN_Click(object sender, EventArgs e)
        {
            if (hQAuthLoad == null)
            {
                hQAuthLoad = new HQAuthLoad();


                hQAuthLoad.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    hQAuthLoad = null; AuthLoadRequests_BTN.Enabled = true;
                };
                hQAuthLoad.Show();
                AuthLoadRequests_BTN.Enabled = false;
            }
        }

        private void GenLoadFiles_BTN_Click(object sender, EventArgs e)
        {
            if (genLoadFile == null)
            {
                genLoadFile = new GenLoadFile();


                genLoadFile.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    genLoadFile = null; GenLoadFiles_BTN.Enabled = true;
                };
                genLoadFile.Show();
                GenLoadFiles_BTN.Enabled = false;
            }
        }

        private void GenerateT24_BTN_Click(object sender, EventArgs e)
        {

            if (generateT24Files == null)
            {
                generateT24Files = new GenerateT24Files();


                generateT24Files.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    generateT24Files = null; GenerateT24_BTN.Enabled = true;
                };
                generateT24Files.Show();
                GenerateT24_BTN.Enabled = false;
            }
        }

        private void Settlements_BTN_Click(object sender, EventArgs e)
        {
            //settlementsManager
            //Run Tests
            //MPBS.Screens.SettlementsSecreens.SettlementsManager x = new SettlementsSecreens.SettlementsManager();
            //x.Show();

            if (settlementsManager == null)
            {
                settlementsManager = new SettlementsManager();


                settlementsManager.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    settlementsManager = null; Settlements_BTN.Enabled = true;
                };
                settlementsManager.Show();
                Settlements_BTN.Enabled = false;
            }
        }
    }
}
