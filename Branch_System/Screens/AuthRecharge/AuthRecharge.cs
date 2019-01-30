using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTS.Database;
using CTS.Database.Objects;
using CTS.Screens.AuthRecharge;

namespace CTS.Screens.AuthRecharge
{
    public partial class AuthRecharge : Form
    {
        private bool isBranchAdmin = true;
        public List<Database.Objects.Recharge> records ;
        //public bool isEnquire = false;

        public AuthRecharge()
        {
            InitializeComponent();
        }

        private void AuthRecharge_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            if(Database.Login.role == "0")
            {
                isBranchAdmin = false;
            }
            else
            {
                isBranchAdmin = true;
            }
            GetUnAuthRecords();

        }



        public void GetUnAuthRecords()
        {
            //Get un Auth recharge records
            records = null;
            List<ViewList> viewLists = new List<ViewList>();
            Status<List<Database.Objects.Recharge>> statusObject = Database.Recharge.getUnAuthRecharge(isBranchAdmin);

            if (statusObject.status)
            {
                if(statusObject.Object.Count > 0)
                {
                    records = statusObject.Object;
                    for (int i = 0; i < records.Count; i++)
                    {
                        ViewList viewList = new ViewList();
                        viewList.id = records[i].ID;
                        viewList.Customer_ID = records[i].Customer_ID;
                        viewList.Nantional_ID = records[i].NID;
                        viewList.Amount = records[i].Amount;
                        viewList.Product = records[i].Product;
                        viewList.Branch = records[i].Branch;
                        viewLists.Add(viewList);
                    }

                }
                else
                {
                     viewLists = null;
                }
                
                Record_DGView.DataSource = viewLists;

                Record_DGView.Columns[0].HeaderText = "id";
                Record_DGView.Columns[1].HeaderText = "رقم الزبون";
                Record_DGView.Columns[2].HeaderText = "الرقم الوطني";
                Record_DGView.Columns[3].HeaderText = "القيمة";
                Record_DGView.Columns[4].HeaderText = "المنتج";
                Record_DGView.Columns[5].HeaderText = "الفرع";

                if (records == null)
                {
                    Record_DGView.Rows.Clear();
                    Record_DGView.DataSource = null;
                    Record_DGView.Rows.Clear();
                    while (Record_DGView.Rows.Count > 0)
                    {
                        
                        Record_DGView.Rows.RemoveAt(0);
                        //Record_DGView.Rows.Add();
                    }
                    Record_DGView.Update();
                    Record_DGView.Refresh();
                }
            }
        }

        public class ViewList
        {
            public int id { get; set; }
            public string Customer_ID { get; set; }
            public string Nantional_ID { get; set; }
            public int Amount { get; set; }
            public string Product { get; set; }
            public int Branch { get; set; }
        }

        private void Record_DGView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


        private void Sync_BTN_Click(object sender, EventArgs e)
        {
            GetUnAuthRecords();
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Record_DGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = Record_DGView.SelectedRows[0];
            Authorize authorize = new Authorize();
            if(records != null)
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
