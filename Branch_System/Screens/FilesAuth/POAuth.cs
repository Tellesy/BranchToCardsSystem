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
                //if (statusObject.Object.Count > 0)
                //{
                //    records = statusObject.Object;
                //    for (int i = 0; i < records.Count; i++)
                //    {
                //        PObject viewList = new PObject();
                //        viewList.ID = records[i].ID;
                //        viewList.Card_Number = records[i].Card_Number;
                //        viewList.Name = records[i].Name;
                //        viewList.Account = records[i].Account;
                //        viewList.Process_Indicator = records[i].Process_Indicator;

                //        viewLists.Add(viewList);
                //    }

                //}
                //else
                //{
                //    viewLists = null;
                //}

                //Record_DGView.DataSource = viewLists;
                Record_DGView.DataSource = statusObject.Object;
                //Record_DGView.Columns[0].HeaderText = "id";
                //Record_DGView.Columns[1].HeaderText = "رقم الزبون";
                //Record_DGView.Columns[2].HeaderText = "الرقم الوطني";
                //Record_DGView.Columns[3].HeaderText = "القيمة";
                //Record_DGView.Columns[4].HeaderText = "المنتج";

                if (statusObject.Object == null)
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
    }
}
