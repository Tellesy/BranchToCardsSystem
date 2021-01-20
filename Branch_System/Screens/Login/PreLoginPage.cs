using System;
using System.Runtime.InteropServices;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using MPBS.Database;
using System.Reflection;
using MPBS.Screens.Main;
using MPBS.Screens.PTS.Perso;

namespace MPBS.Screens
{
    public partial class PreLoginPage : MaterialSkin.Controls.MaterialForm
    {
       // public Login login;
        public PreLoginPage()
        {
            InitializeComponent();
        }

        private void PreLoginPage_Load(object sender, EventArgs e)
        {
            Assembly thisAssem = typeof(Login).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

            DataBaseType_CBox.SelectedIndex = 0;

            //MPBS.ConnectToSharedFolder.CreateShortcut();


            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Version_LBL.Text = Version_LBL.Text + " V" + thisAssemName.Version;
        }

        private void DataBaseType_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.DBConnection.ConnectionType connectionType = DBConnection.ConnectionType.Prod;

            switch (DataBaseType_CBox.SelectedIndex)
            {
                case 1:
                    connectionType = DBConnection.ConnectionType.UAT;
                    break;

                case 2:
                    connectionType = DBConnection.ConnectionType.Dev;
                    break;
                case 0:
                default:
                    connectionType = DBConnection.ConnectionType.Prod;
                    break;


            }
            Database.DBConnection.SwitchConnectionType(connectionType);
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_BTN_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            login.Closed += (s, args) => { //authRecharge.UnlockRecord();
                login = null; this.Show();
            };
            this.Hide();
        }
    }
}
