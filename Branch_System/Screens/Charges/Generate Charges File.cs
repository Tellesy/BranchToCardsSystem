using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.Charges
{
    public partial class GenerateChargesFiles : MaterialSkin.Controls.MaterialForm
    {
        public GenerateChargesFiles()
        {
            InitializeComponent();
        }

        private void Generate_Charges_File_Load(object sender, EventArgs e)
        {

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateCardIssuingChargesFile_BTN_Click(object sender, EventArgs e)
        {

        }

        private List<Charge> GetCharges()
        {
            List<Charge> charges = new List<Charge>();


            return charges;
        }
    }
}
