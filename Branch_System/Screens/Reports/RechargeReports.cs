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
        public List<Database.Objects.Branch> brances;

        private int CustomerID;
        private string Product;
        private string reportViewerLink;
        public RechargeReports()
        {
            InitializeComponent();
        }

        private void 
            
            RechargeReports_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //string year = Database.Recharge.year.ToString();
            //this.LoadReport("01/01/"+year,"12/31/"+year);
            brances = new List<Database.Objects.Branch>();
            Database.Objects.Status<List<Database.Objects.Branch>> statusObject = Database.Branch.getBranches();
            if(statusObject.status)
            {
                brances = statusObject.Object;
                Branches_CBL.Items.Clear();
                foreach(Database.Objects.Branch branch in brances)
                {
                    Branches_CBL.Items.Add(branch.Name);
                }
            }

        }

        private void Search_BTN_Click(object sender, EventArgs e)
        {
            string from = FromDatePicker.Value.ToShortDateString();
            string to = ToDatePicker.Value.ToShortDateString();
            this.LoadReport(from, to);

            List<> selected = new List<ListItem>();
            foreach (ListItem item in CBLGold.Items)
                if (item.Selected) selected.Add(item);


        }

        private void LoadReport(string from, string to)
        {
            CustomerID = 0;
            if(CustomerID_CBX.Checked)
            {
                if(CustomerID_TXT.Text.Length != 7 )
                {
                    MessageBox.Show("الرجاء إدخال رقم الزبون بشكل صحيح");
                    return;
                }
                try
                {
                    CustomerID = int.Parse(CustomerID_TXT.Text);
                }
                catch
                {
                    MessageBox.Show("الرجاء إدخال رقم الزبون بشكل صحيح");
                    return;
                }
            }
            this.RechargeReport.LocalReport.ReportEmbeddedResource = "CTS.Screens.Reports." + reportViewerLink;
            var x = this.RechargeReport.LocalReport.ReportEmbeddedResource;
            this.RechargeReport.LocalReport.Refresh();
             this.RechargeReport.LocalReport.DataSources.Clear();
            this.RechargeReport.LocalReport.Refresh();

            //this.RechargeReport.LocalReport.DataSources.cl

            //this.RechargeReport.LocalReport.res

            //this.RechargeReport.Clear();
            // this.RechargeReport.Refresh();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            ds.Tables.Add(dt);
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Customer_ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Time");
            dt.Columns.Add("Branch");
            dt.Columns.Add("Amount", typeof(int));
            dt.Columns.Add("Inputter", typeof(int));
            dt.Columns.Add("Authorizer", typeof(int));
            dt.Columns.Add("CardAccount");             

            var s = Database.Recharge.getRegarches(from, to,Product,CustomerID);

            if (s.status)
            {
                foreach (Database.DataObjects.Recharge r in s.Object)
                {
                    DataRow dr = dt.Rows.Add();
                    dr.SetField("ID", r.ID);
                    dr.SetField("Customer_ID", r.Customer_ID);
                    dr.SetField("Name", r.Name);
                    dr.SetField("Branch", Database.Branch.getBranch(r.Branch));
                    dr.SetField("Time", r.Time);
                    dr.SetField("Amount", r.Amount);
                    dr.SetField("Inputter", r.Inputter);
                    dr.SetField("Authorizer", r.Authorizer);
                    if(r.CardAccount != null && r.CardAccount.Count() == 16)
                    dr.SetField("CardAccount", r.CardAccount.Substring(0,4)+ "___" + r.CardAccount.Substring(11,4));

                }

                this.RechargeReport.Clear();
              //  ReportParameter[] parameters = new ReportParameter[1];
               // parameters[0] = new ReportParameter("Date", "");
                //this.RechargeReport.LocalReport.SetParameters(parameters);
                ReportDataSource reportDataSource = new ReportDataSource("RechargeDT", dt);
                this.RechargeReport.LocalReport.DataSources.Add(reportDataSource);
            }
            else
            {
                ReportDataSource reportDataSource = new ReportDataSource("RechargeDT", dt);
                this.RechargeReport.LocalReport.DataSources.Add(reportDataSource);
                MessageBox.Show("لا يوجد عمليات في الفترة المحددة");
            }

            this.RechargeReport.RefreshReport();
        }

        private void CustomerID_CBX_CheckedChanged(object sender, EventArgs e)
        {
            if(CustomerID_CBX.Checked)
            {
                CustomerID_TXT.Enabled = true;
                
            }
            else
            {
                CustomerID_TXT.Enabled = false;
            }
        }

        private void CustomerID_TXT_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(CustomerID_TXT.Text, "  ^ [0-9]"))
            {
                CustomerID_TXT.Text = "";
            }
        }

        private void CustomerID_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Family_RB_CheckedChanged(object sender, EventArgs e)
        {
            if(Family_RB.Checked)
            {
                Product = "10";
                reportViewerLink = "MyFamilyRechargReport.rdlc";
                Search_BTN.Enabled = true;

            }
        }

        private void Alrafiq_RB_CheckedChanged(object sender, EventArgs e)
        {
            if(Alrafiq_RB.Checked)
            {
                Product = "30";
                reportViewerLink = "AlrafiqRechargReport.rdlc";
                Search_BTN.Enabled = true;
            }
        }
    }
}
