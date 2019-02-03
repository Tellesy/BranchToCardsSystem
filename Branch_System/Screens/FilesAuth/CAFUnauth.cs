using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTS.Database.Objects;
using CTS.Screens.FilesAuth;
namespace CTS.Screens
{
    public partial class CAFUnauth : Form
    {
        public List<CAFObject> records;

        public CAFUnauth()
        {
            InitializeComponent();
        }

        public void GetUnAuthRecords()
        {
            //Get un Auth recharge records
            records = null;
            List<CAFObject> viewLists = new List<CAFObject>();
            Status<List<CAFObject>> statusObject = Database.CAF.getUnauthCAF();

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


        private void CAFUnauth_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            GetUnAuthRecords();
        }
        private void Auth_All_BTN_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من تخويل جميع العمليات؟", "تخويل كل العمليات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(records != null)
                {
                    for (int i = 0; i < records.Count(); i++)
                    {
                        Database.Status status = Database.CAF.authCAF(records[i].ID);
                        if (!status.status)
                        {
                            MessageBox.Show(status.message + "\nRecord ID: \n" + records[i].ID.ToString());
                        }
                    }
                    GetUnAuthRecords();
                }
                else
                {
                    return;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void Sync_BTN_Click(object sender, EventArgs e)
        {
            GetUnAuthRecords();
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.records = null;
            this.Close();
        }

        private void Record_DGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = Record_DGView.SelectedRows[0];
            AuthorizeCAF authorize = new AuthorizeCAF ();
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
