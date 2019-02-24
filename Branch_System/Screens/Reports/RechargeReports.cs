using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this.RechargeReport_LBL.RefreshReport();
        }

        private void RechargeReport_LBL_Load(object sender, EventArgs e)
        {

        }
    }
}
