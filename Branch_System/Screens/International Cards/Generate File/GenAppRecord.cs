﻿using System;
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

namespace MPBS.Screens.International_Cards.Generate_File
{
    public partial class GenAppRecord : Form
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

            if(recordsStatus.status)
            {

                //Get all Customer  info and Account  info
                //First get Customer info
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
                            MessageBox.Show(accountStatus.message + "هنالك مشكلة في بيانات حساب احد الزبائن ");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(customerStatus.message + "هنالك مشكلة في بيانات احد الزبائن ");
                        return;
                    }
                }

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
