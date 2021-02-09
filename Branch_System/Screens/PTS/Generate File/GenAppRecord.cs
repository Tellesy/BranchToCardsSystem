using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPBS.Database.Objects;
using System.Windows.Forms;
using MPBS.FilesCreator;
using MPBS.Database;

namespace MPBS.Screens.PTS.Generate_File
{
    public partial class GenAppRecord : MaterialSkin.Controls.MaterialForm
    {
        public GenAppRecord()
        {
            InitializeComponent();
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenAllAppFiles_BTN_Click(object sender, EventArgs e)
        {
            //First all Auth but unGen AppRecords;
            Status<List<PTSAppRecord>> recordsStatus = PTSAppRecordController.getFullyAuthorizedAppRecords();

            List<PTSAppRecord> records = new List<PTSAppRecord>();

            List<string> logs = new List<string>();

            if(recordsStatus.status)
            {

                //Get all Customer  info and Account  info
                //First get Customer info
                var ModRecords = new List<PTSAppRecord>();
                foreach (PTSAppRecord record in recordsStatus.Object)
                {
                    var customerStatus = PTSCustomerController.getCustomer(record.CustomerID);
                    if(customerStatus.status)
                    {
                        record.Customer = customerStatus.Object;
                        //Get Account Info
                      var accountStatus =  PTSAccountController.getAccount(record.CustomerID, record.ProgramCode);
                        if(accountStatus.status)
                        {
                            record.Account = accountStatus.Object;

                            records.Add(record);
                            
                        }
                        else
                        {
                            string error = string.Format("Account Data does not exist for Customer ID {0} and Program {1}", record.CustomerID, record.ProgramCode);
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            logs.Add(error);
                            //return;
                        }
                    }
                    else
                    {
                        string error = string.Format("Customer Data does not exist for Customer ID {0} and Program {1}", record.CustomerID, record.ProgramCode);
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logs.Add(error);
                        //return;
                    }
                }

                try
                {
                    
                    foreach (var r in records)
                    {
                        ModRecords.Add(r);
                        if (r.ApplicationSubType == 'E')
                        {

                            var devuceStatus = PTSDeviceController.getExistingDevice(r.CustomerID);
                            if (devuceStatus.status)
                            {
                                r.ExistingDeviceNumber = devuceStatus.Object.DeviceNumber;
                            }
                            else
                            {
                                string error = string.Format("Device Data does not exist for Customer ID {0} and Program {1}", r.CustomerID, r.ProgramCode);
                                MessageBox.Show(error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                //r.ApplicationSubType = 'N';
                                logs.Add(error);
                                ModRecords.Remove(r);
                            }
                        }

                    }

                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }

                records = ModRecords;

                string location = MPBSConfig.Logs + @"\Application Logs\";
                string filename = "AppRecGenLogs-" + DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss");
                System.IO.Directory.CreateDirectory(location);

                System.IO.File.WriteAllLines((location  + filename), logs);




                var status = AppRecrodFileCreator.GenerateAppRecordFile(records);

                if(status.status)
                {
                    foreach(var record in records)
                    {
                       var sObject = PTSAppRecordController.genAppRecord(record.RecordID);
                        if(!sObject.status)
                        {
                            MessageBox.Show("The Record has been generated in file but failed to update (generated Var in DB)","Error in Reocrd " + record.RecordID);
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

        private void GenAppFilesBasedOnCode_BTN_Click(object sender, EventArgs e)
        {

        }

        private void GenAppRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
