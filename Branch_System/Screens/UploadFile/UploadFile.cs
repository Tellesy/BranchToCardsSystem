using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.SpreadSheet;
using MPBS.SpreadSheet.Structure;



namespace MPBS.Screens.UploadFile
{
    public partial class UploadFile : MaterialSkin.Controls.MaterialForm
    {
        public UploadFile()
        {
            InitializeComponent();
        }

        private void UploadFile_Load(object sender, EventArgs e)
        {

        }

        private void ApplicationApproveReport_BTN_Click(object sender, EventArgs e)
        {

            OpenFileDialog deviceDialog = new OpenFileDialog();
            deviceDialog.InitialDirectory = @"C:\";
            deviceDialog.RestoreDirectory = true;
            deviceDialog.DefaultExt = "xlsx";
            deviceDialog.Filter = "xlsx files (*.xlsx)|*.xlsx";
            deviceDialog.AddExtension = true;

            DialogResult dr = deviceDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                dr.ToString();
                Console.WriteLine(deviceDialog.FileName);
                

                  
               var status = FileReader.SMT_TransactionsFileReader(deviceDialog.FileName);
                foreach(var ts in status.Object)
                {
                    MessageBox.Show(ts.CardNumber);
                }

                
            }



        }
    }
}
