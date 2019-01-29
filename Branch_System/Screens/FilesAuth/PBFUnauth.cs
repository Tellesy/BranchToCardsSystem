using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch_System.Screens
{
    public partial class PBFUnauth : Form
    {
        public PBFUnauth()
        {
            InitializeComponent();
        }

        private void PBFUnauth_Load(object sender, EventArgs e)
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
                }
            }
        }

    }
}
