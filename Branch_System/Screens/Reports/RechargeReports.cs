using Microsoft.Reporting.WinForms;
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
using CTS.Database.DataObjects;

namespace CTS.Screens.Reports
{
    public partial class RechargeReports : Form
    {
        public RechargeReports()
        {
            InitializeComponent();
        }

        private void RechargeReports_Load(object sender, EventArgs e)
        {
            // string sql = "";
            // sql += "SELECT * FROM TABLE WHERE NAME='JOHN SMITH'";
            // OdbcDataAdapter adptr = new OdbcDataAdapter(sql, _connection);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            ds.Tables.Add(dt);
            dt.Columns.Add("Name");
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Customer_ID");


            var s = Database.Recharge.getRegarches("01-01-2019", "31-12-2020");

            if(s.status)
            {
                foreach(Database.DataObjects.Recharge r in s.Object)
                {
                    DataRow dr = dt.Rows.Add();
                    dr.SetField("Name", r.Name);
                    dr.SetField("Customer_ID", r.Customer_ID);

                    dr.SetField("ID", r.ID);
                }

                this.RechargeReport.Clear();
                //this.RechargeReport.LocalReport.ReportEmbeddedResource = "ReportViewerForm.Report1.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("Dataset", dt);
                this.RechargeReport.LocalReport.DataSources.Add(reportDataSource);

            }
           // var reportViewer = new ReportViewer();


          //  this.RechargeReport.
            this.RechargeReport.RefreshReport();
        }

        private void RechargeReport_LBL_Load(object sender, EventArgs e)
        {

        }
    }
}
