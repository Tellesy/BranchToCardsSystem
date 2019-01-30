using Branch_System.Database.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch_System.Screens.FilesAuth;

namespace Branch_System.Screens
{
    public partial class PBFUnauth : Form
    {
        public List<Database.Objects.PBFObject> records;
        public PBFUnauth()
        {
            InitializeComponent();
        }

        private void PBFUnauth_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            GetUnAuthRecords();
        }

        public void GetUnAuthRecords()
        {
            //Get un Auth recharge records
            records = null;
            List<Database.Objects.PBFObject> viewLists = new List<Database.Objects.PBFObject>();
            Status<List<Database.Objects.PBFObject>> statusObject = Database.PBF.getUnauthPBF();

            if (statusObject.status)
            {
                records = statusObject.Object;
                Record_DGView.DataSource = statusObject.Object;
                //Record_DGView.Columns[0].HeaderText = "id";

                if (statusObject.Object == null)
                {
                    Record_DGView.Rows.Clear();
                    Record_DGView.DataSource = null;
                    Record_DGView.Rows.Clear();
                    while (Record_DGView.Rows.Count > 0)
                    {
                        Record_DGView.Rows.RemoveAt(0);
                    }
                    Record_DGView.Update();
                    Record_DGView.Refresh();
                }
            }
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            records = null;
            this.Close();
        }

        private void Sync_BTN_Click(object sender, EventArgs e)
        {
            GetUnAuthRecords();
        }

        private void Record_DGView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = Record_DGView.SelectedRows[0];
            AuthorizePBF authorize = new AuthorizePBF();
            if (records != null)
            {
                var q = records.Where(x => x.ID == Convert.ToInt32(r.Cells[0].Value)).ToArray();

                if (q.Count() > 0)
                {
                    this.Hide();
                    authorize.record = q[0];
                    authorize.Closed += (s, args) => { this.GetUnAuthRecords(); this.Show(); };
                    authorize.Show();
                }
            }
        }
    }
}
