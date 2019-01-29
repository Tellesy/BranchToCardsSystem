using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch_System.Database;
using Branch_System.Database.Objects;
using Branch_System.Screens.FilesAuth;

namespace Branch_System.Screens
{
    public partial class POAuth : Form
    {

        public List<Database.Objects.PObject> records;
        public POAuth()
        {
            InitializeComponent();
        }

        private void POAuth_Load(object sender, EventArgs e)
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
            List<Database.Objects.PObject> viewLists = new List<Database.Objects.PObject>();
            Status<List<Database.Objects.PObject>> statusObject = Database.PO.getUnauthPO();

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
                }
            }
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sync_BTN_Click(object sender, EventArgs e)
        {
            GetUnAuthRecords();
        }

        private void Record_DGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = Record_DGView.SelectedRows[0];
            AuthorizePO authorize = new AuthorizePO();
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
