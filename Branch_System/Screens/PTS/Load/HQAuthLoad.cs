using MPBS.Database.Objects;
using MPBS.Screens.PTS.AuthIssue.SubScreen;
using MPBS.Screens.PTS.Load.SubScreen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using static MPBS.Screens.AuthRecharge.AuthRecharge;

namespace MPBS.Screens.PTS.Load
{
    public partial class HQAuthLoad : MaterialSkin.Controls.MaterialForm
    {
        
        public List<Database.Objects.PTSLoad> records;

        public HQAuthLoad()
        {
            InitializeComponent();
        }

        private void Sync_BTN_Click(object sender, EventArgs e)
        {
            GetUnAuthRecords();
        }

        private void HQAuthIssue_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
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
            List<ViewList> viewLists = new List<ViewList>();
            Status<List<Database.Objects.PTSLoad>> statusObject = Database.PTSLoadController.getHQUnAuthLoad();

            if (statusObject.status)
            {
                if (statusObject.Object.Count > 0)
                {
                    records = statusObject.Object;
                    for (int i = 0; i < records.Count; i++)
                    {
                        ViewList viewList = new ViewList();
                        viewList.id = records[i].ID;
                        viewList.Customer_ID = records[i].CustomerID;
                        viewList.ProgramCode = records[i].ProgramCode;
                        viewList.Amount = records[i].Amount.ToString();
                        viewList.Year = records[i].Year.ToString();
                        viewList.Branch = records[i].BranchCode;
                        viewList.Inputter = records[i].Inputter;
                        viewList.InputTime = records[i].InputTime;

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
                Record_DGView.Columns[2].HeaderText = "المنتج";
                Record_DGView.Columns[3].HeaderText = "نوع الطلب";
                Record_DGView.Columns[4].HeaderText = "النوع الثانوي";
                Record_DGView.Columns[5].HeaderText = "الفرع";
                Record_DGView.Columns[6].HeaderText = "المدخل";
                Record_DGView.Columns[7].HeaderText = "وقت الإدخال";



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
            public string ProgramCode { get; set; }
            public string Inputter { get; set; }
            public string Amount { get; set; }
            public string Year { get; set; }
            public string Branch { get; set; }
            public DateTime InputTime { get; set; }

        }


        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Record_DGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                DataGridViewRow r = Record_DGView.SelectedRows[0];
                LoadHQAuthScreen authorize = new LoadHQAuthScreen();
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
