using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Screens.PTS.Customer;

namespace MPBS.Screens.PTS.Edit
{
    public partial class Edit : MaterialSkin.Controls.MaterialForm
    {

        EditCustomer editCustomer;
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            
        }

        private void EditCustomerInformation_BTN_Click(object sender, EventArgs e)
        {
            if (editCustomer == null)
            {
                editCustomer = new EditCustomer();


                editCustomer.Closed += (s, args) => { //authRecharge.UnlockRecord();
                    editCustomer = null; EditCustomerInformation_BTN.Enabled = true;
                };
                editCustomer.Show();
                EditCustomerInformation_BTN.Enabled = false;
            }
        }
    }
}
