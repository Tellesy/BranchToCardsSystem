﻿using MPBS.Database;
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

namespace MPBS.Screens.PTS.Delete.SubScreen
{

    public partial class IssueBranchDeleteScreen : Form
    {

        public PTSAppRecord record;

        public IssueBranchDeleteScreen()
        {
            InitializeComponent();
        }

        private void IssueBranchAuthScreen_Load(object sender, EventArgs e)
        {
            
            this.Text = record.RecordID.ToString() + " " + record.Inputter;
            CustomerID_TXT.Text = record.CustomerID;
            
            //get customer name from here
            var customerObject = PTSCustomerController.getCustomer(record.CustomerID);
            FirstName_TXT.Text = customerObject.Object.FirstName;
            FatherName_TXT.Text = customerObject.Object.FatherName;
            LastName_TXT.Text = customerObject.Object.LastName;
            EmbossedName_TXT.Text = customerObject.Object.EmbossedName;
            Gender_CBOX.Text = customerObject.Object.Gender;
            Birthdate.Value = DateTime.Parse(customerObject.Object.Birthdate);
            Nationality_CBOX.SelectedValue = customerObject.Object.Nationality;
            NID_TXT.Text = customerObject.Object.NationalID;
            Passport.Text = customerObject.Object.PassportNumber;
            PassportExpDate.Value = DateTime.Parse(customerObject.Object.PassportExp);
            Address_TXT.Text = customerObject.Object.Address;
            CountryPhoneCode_CBox.Text = customerObject.Object.PhoneISD;
            PhoneNo_TXT.Text = customerObject.Object.Phone;
            Email_TXT.Text = customerObject.Object.Email;
            var programsObject = PTSProgramController.getPrograms();

            string programCode = String.Concat(record.ProgramCode.Where(c => !Char.IsWhiteSpace(c)));

            if (programsObject.status)
            {
                
                programCode = programsObject.Object.First(i => i.Code == String.Concat(record.ProgramCode.Where(c => !Char.IsWhiteSpace(c)))).NameEN;
            }
            Program_CBox.Text = programCode;
            var accountObject = PTSAccountController.getAccount(record.CustomerID, record.ProgramCode);


            MainAccount_TXT.Text = accountObject.Object.AccountNumberLYD;
            ProgramAccount_TXT.Text = accountObject.Object.AccountNumberCurrency;

            AppType_TXT.Text = record.ApplicationType.ToString();
            AppSubType_TXT.Text = record.ApplicationSubType.ToString();
            Inputter_TXT.Text = record.Inputter.ToString();

        }



        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_BTN_Click(object sender, EventArgs e)
        {
               DialogResult dialogResult = MessageBox.Show("هل انت متأكد من حذف هذه العملية؟", "حذف العملية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                //Delete Charge
                Database.Status chargeDStatus = Database.ChargeController.deleteCharges(record.RecordID);
                if(!chargeDStatus.status)
                {
                    MessageBox.Show(chargeDStatus.message, "Error in Deleting Charge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //Delete App Record
                Database.Status appRecordDStatus = Database.PTSAppRecordController.deleteAppRecord(record.RecordID);

                if (!appRecordDStatus.status)
                {
                    MessageBox.Show(appRecordDStatus.message, "Error in Deleting AppRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Database.Status accountDStatus = Database.PTSAccountController.deleteAccount(record.CustomerID,record.ProgramCode);

                if (!accountDStatus.status)
                {
                    MessageBox.Show(accountDStatus.message, "Error in Deleting Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("تم حذف العملية بنجاح");
                record = null;
                this.Close();
      
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
