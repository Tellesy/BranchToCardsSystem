using MPBS.Database;
using MPBS.Database.Objects;
using MPBS.FilesCreator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.PTS.Generate_File
{
    
    public partial class GenLoadFile : MaterialSkin.Controls.MaterialForm
    {
        public GenLoadFile()
        {
            InitializeComponent();
        }

        private void GenLoadFile_Load(object sender, EventArgs e)
        {

        }

        private void GenAllLoadFiles_BTN_Click(object sender, EventArgs e)
        {
            Status<List<PTSLoad>> recordsStatus = PTSLoadController.getFullyAuthorizedLoadRequests();

            List<PTSLoad> records = new List<PTSLoad>();
            List<PTSTransactionRecord> transactions = new List<PTSTransactionRecord>();


            if (recordsStatus.status)
            {

                //Convert Load to Transaction record
                foreach (PTSLoad record in recordsStatus.Object)
                {

                    PTSTransactionRecord t = new PTSTransactionRecord();
                    t.
                }

                PTSTransactionUploadFileCreator.GenerateAppRecordFile(records);

                var status = LoadFileCreator.GenerateAppRecordFile(records);

                if (status.status)
                {
                    foreach (var record in records)
                    {
                        var sObject = PTSAppRecordController.genAppRecord(record.RecordID);
                        if (!sObject.status)
                        {
                            MessageBox.Show("The Record has been generated in file but failed to update (generated Var in DB)", "Error in Reocrd " + record.RecordID);
                        }
                    }

                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show(status.message);
                }

            }
            else
            {
                MessageBox.Show(recordsStatus.message);
                return;
            }

        }
    }
}
