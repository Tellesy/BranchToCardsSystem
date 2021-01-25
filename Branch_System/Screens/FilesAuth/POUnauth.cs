using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Database;
using MPBS.Database.Objects;
using MPBS.Screens.FilesAuth;

namespace MPBS.Screens
{
    public partial class POUnauth : Form
    {

        public List<Database.Objects.PObject> records;
        private string Selected_Branch;

        public POUnauth()
        {
            InitializeComponent();
        }

        private void POAuth_Load(object sender, EventArgs e)
        {
            Branch_CBox.SelectedValue = "0";
            Selected_Branch = "0";
            // TODO: This line of code loads data into the 'cTSDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.cTSDataSet.Branches);
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
                if(Selected_Branch != "0")
                {
                    List<Database.Objects.PObject> filterdPO = new List<PObject>();


                    foreach (Database.Objects.PObject pObject in statusObject.Object)
                    {
                        if (Convert.ToInt32(pObject.Branch_Code) == Convert.ToInt32(Selected_Branch))
                        {
                            filterdPO.Add(pObject);
                        }
                    }
                    records = filterdPO;
                    Record_DGView.DataSource = filterdPO;
                    //

                }
                else
                {
                    records = statusObject.Object;
                    Record_DGView.DataSource = statusObject.Object;
                }
               
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

        private void Branch_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Selected_Branch = Branch_CBox.SelectedValue.ToString();
                GetUnAuthRecords();
            }
            catch
            {

            }
        
            //  MessageBox.Show(Branch_CBox.SelectedValue.ToString());
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
