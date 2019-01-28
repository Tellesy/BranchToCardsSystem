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
using Branch_System.Screens.AuthRecharge;

namespace Branch_System.Screens.AuthRecharge
{
    public partial class AuthRecharge : Form
    {
        private bool isBranchAdmin = true;
        public List<Database.Objects.Recharge> records ;

        public AuthRecharge()
        {
            InitializeComponent();
        }

        private void AuthRecharge_Load(object sender, EventArgs e)
        {
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
            Status<List<Database.Objects.Recharge>> statusObject = Database.Recharge.getUnAuthRecharge(isBranchAdmin);

            if (statusObject.status)
            {
                List<ViewList> viewLists = new List<ViewList>();
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

                    //viewList.Name = "Nigga";
                    // viewList.Customer_ID = statusObject.Object[i].Customer_ID;

                    viewLists.Add(viewList);
                }
                Record_DGView.DataSource = viewLists;
                Record_DGView.Columns[0].HeaderText = "id";
                Record_DGView.Columns[1].HeaderText = "رقم الزبون";
                Record_DGView.Columns[2].HeaderText = "الرقم الوطني";
                Record_DGView.Columns[3].HeaderText = "القيمة";
                Record_DGView.Columns[4].HeaderText = "المنتج";
                Record_DGView.Columns[5].HeaderText = "الفرع";
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
            var q = records.Where(x => x.ID == Convert.ToInt32(r.Cells[0].Value)).ToArray();

            if(q.Count() > 0)
            {
                authorize.record = q[0];

                authorize.Show();
            }

        }
    }


}
