using CTS.Database.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTS.Screens.FilesAuth;

namespace CTS.Screens
{
    public partial class PBFUnauth : Form
    {
        public List<Database.Objects.PBFObject> records;
        private string Selected_Branch;

        public PBFUnauth()
        {
            InitializeComponent();
        }

        private void PBFUnauth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cTSDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.cTSDataSet.Branches);

            Branch_CBox.SelectedValue = "0";
            Selected_Branch = "0";

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
                if (Selected_Branch != "0")
                {
                    List<Database.Objects.PBFObject> filterdPBF = new List<PBFObject>();


                    foreach (Database.Objects.PBFObject pObject in statusObject.Object)
                    {
                        var x = Convert.ToInt32(pObject.Card_Account.Substring(8, 2));
                        if(x == Convert.ToInt32(Selected_Branch))
                        {
                            Console.WriteLine("FU");
                        }
                        if (Convert.ToInt32(pObject.Card_Account.Substring(8,2)) == Convert.ToInt32(Selected_Branch))
                        {
                            filterdPBF.Add(pObject);
                        }
                    }
                    records = filterdPBF;
                    Record_DGView.DataSource = filterdPBF;
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
        }
    }
}
