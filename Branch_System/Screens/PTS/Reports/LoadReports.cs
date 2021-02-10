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

using MPBS.Screens.PTS.Reports.SubScreens;

namespace MPBS.Screens.PTS.Reports
{
    public partial class LoadReports : MaterialSkin.Controls.MaterialForm
    {
        private bool isBranchAdmin = true;
        public List<Database.Objects.PTSLoad> records;
        private List<ViewList> viewLists;
        private List<ViewList> viewListsByTime;
        private DateTime FromDate;
        private DateTime ToDate;

        //ddpkao-oapfas pkk


        //public bool isEnquire = false;

        public LoadReports()
        {
            InitializeComponent();
        }

        private void AuthIssue_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            ToDate = DateTime.Now;
            FromDate = ToDate.AddDays(-90);

            if (Database.Login.role == "2")
            {
                isBranchAdmin = true;
            }
            else
            {
                isBranchAdmin = false;
            }
            GetAllRecords();
        }

        //public void getUnAuthRecordsWithOutRerender()
        //{
        //    //Get un Auth recharge records
        //    records = null;
        //    viewLists = new List<ViewList>();
        //    Status<List<Database.Objects.PTSLoad>> statusObject = Database.PTSLoadController.getBranchUnAuthLoad(isBranchAdmin);

        //    if (statusObject.status)
        //    {
        //        if (statusObject.Object.Count > 0)
        //        {
        //            records = statusObject.Object;
        //            for (int i = 0; i < records.Count; i++)
        //            {
        //                ViewList viewList = new ViewList();
        //                viewList.id = records[i].ID;
        //                viewList.Customer_ID = records[i].CustomerID;
        //                viewList.ProgramCode = records[i].ProgramCode;
        //                viewList.Amount = records[i].Amount.ToString();
        //                viewList.Year = records[i].Year.ToString();
        //                viewList.Branch = records[i].BranchCode;
        //                viewList.Inputter = records[i].Inputter;
        //                viewList.InputTime = records[i].InputTime;

        //                viewLists.Add(viewList);
        //            }

        //        }
        //        else
        //        {
        //            viewLists = null;
        //        }

                    
        //  }
        //}
        public void GetAllRecords()
        {
            //Get un Auth recharge records
            records = null;
            viewLists = new List<ViewList>();
            Status<List<Database.Objects.PTSLoad>> statusObject = Database.PTSLoadController.getAllLoadPerBranchAndDate(isBranchAdmin, FromDate.ToString("yyyy-MM-dd"), ToDate.ToString("yyyy-MM-dd"));

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
                        viewList.Year = records[i].Year.ToString();

                        viewList.Inputter = records[i].Inputter;
                        viewList.Amount = records[i].Amount.ToString();
                        viewList.BranchAuth = records[i].BranchAuthorizer == null ? false : true;
                        viewList.HQAuth = records[i].HQAuthorizer == null ? false : true;
                        viewList.InputTime = records[i].InputTime;



                        viewLists.Add(viewList);
                    }

                }
                else
                {
                    viewLists = null;
                }

                Record_DGView.DataSource = null;
                Record_DGView.Update();
                Record_DGView.Refresh();
                Record_DGView.DataSource = viewLists;
                Record_DGView.Update();
                Record_DGView.Refresh();

                Record_DGView.Columns[0].HeaderText = "id";
                Record_DGView.Columns[1].HeaderText = "Customer ID";
                Record_DGView.Columns[2].HeaderText = "Product";
                Record_DGView.Columns[3].HeaderText = "Year";
                Record_DGView.Columns[4].HeaderText = "Inputter";
                Record_DGView.Columns[5].HeaderText = "Amount";
                Record_DGView.Columns[6].HeaderText = "Branch Auth";
                Record_DGView.Columns[7].HeaderText = "HQ Auth";



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
            public string Year { get; set; }
            public string Amount { get; set; }
         
            public bool BranchAuth { get; set; }
            public bool HQAuth { get; set; }
            public DateTime InputTime { get; set; }



        }

        private void Sync_BTN_Click(object sender, EventArgs e)
        {
            GetAllRecords();

        }


        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Record_DGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(isBranchAdmin)
            {
                DataGridViewRow r = Record_DGView.SelectedRows[0];
                LoadRecordStatus loadRecord = new LoadRecordStatus();
                if (records != null)
                {
                    var q = records.Where(x => x.ID == Convert.ToInt32(r.Cells[0].Value)).ToArray();

                    if (q.Count() > 0)
                    {
                        this.Hide();
                        this.Update();
                        loadRecord.record = q[0];
                        loadRecord.Closed += (s, args) => { this.GetAllRecords();
                            returnToSameStateAfterAuthScreenCloses(); this.Show(); };
                        loadRecord.Show();
                    }
                }
            }
          


        }

        public void returnToSameStateAfterAuthScreenCloses()
        {
            if(SearchByTime_CHBox.Checked)
            {
                viewListsByTime = viewLists.FindAll(i => i.InputTime.Date >= From_DTP.Value.Date && i.InputTime.Date <= To_DTP.Value.Date);

                Record_DGView.DataSource = viewListsByTime;
            }

            if (CustomerID_TXT.Text.Count() > 0)
            {
                List<ViewList> scopedList = viewLists;

                if (SearchByTime_CHBox.Checked)
                {
                    scopedList = viewListsByTime;
                }

             
                    Record_DGView.DataSource = scopedList.FindAll(i => i.Customer_ID.Contains(CustomerID_TXT.Text));
                

            }
            
        }
        private void CustomerID_TXT_TextChanged(object sender, EventArgs e)
        {
            List<ViewList> scopedList = viewLists;

            if (SearchByTime_CHBox.Checked)
            {
                scopedList = viewListsByTime;
            }

            if(CustomerID_TXT.Text.Count() <= 7)
            {
                Record_DGView.DataSource = scopedList.FindAll(i => i.Customer_ID.Contains(CustomerID_TXT.Text));
            }
            else
            {
                if (SearchByTime_CHBox.Checked)
                {
                    Record_DGView.DataSource = viewListsByTime;
                }
                else
                {

                    GetAllRecords();
                }

            }
        }

        private void SearchByTime_CHBox_CheckedChanged(object sender, EventArgs e)
        {
            if(SearchByTime_CHBox.Checked)
            {
                SearchByTime_GBox.Enabled = true;
                viewListsByTime = viewLists;

            }
            else
            {
                SearchByTime_GBox.Enabled = false;
                GetAllRecords();
            }
        }

        private void Search_BTN_Click(object sender, EventArgs e)
        {
            FromDate = From_DTP.Value.Date;
            ToDate= To_DTP.Value.Date;

            GetAllRecords();
            viewListsByTime = viewLists;
            Record_DGView.DataSource = viewListsByTime;
        }
    }
}
