﻿using MPBS.Database;
using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.PTS.Load
{
    public partial class Load : MaterialSkin.Controls.MaterialForm
    {

        private List<PTSProgram> programs;
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //ConfirmAmount_TXT.te
            GetPrograms();
        }


        private void TXTB_ONLY_NUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GetPrograms()
        {
            Status<List<PTSProgram>> programStatus = PTSProgramController.getActivePrograms();

            if (programStatus.status)
            {
                programs = programStatus.Object;
                // foreach(var p in programStatus.Object)
                Program_CBox.DataSource = programStatus.Object;
                Program_CBox.DisplayMember = "NameEN";
                Program_CBox.ValueMember = "Code";
                this.Program_CBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sumbit_BTN_Click(object sender, EventArgs e)
        {
           var sCustomer = PTSCustomerController.getCustomer(CustomerID_TXT.Text);
            if(!sCustomer.status)
            {
                MessageBox.Show("Customer Info Does not exist in Database");
                return;
            }

            string selectedProgramCode = String.Concat(Program_CBox.SelectedValue.ToString().Where(c => !Char.IsWhiteSpace(c)));

            var selectedProgramObject = programs.First(p => p.Code == selectedProgramCode);
            int amount = int.Parse(Amount_TXT.Text);
            int confirmAmount = int.Parse(ConfirmAmount_TXT.Text);

            if(amount!=confirmAmount)
            {
                MessageBox.Show("Amount and Confrim Amount values are not equal");
                return;
            }

            if(amount > selectedProgramObject.YearlyLimit)
            {
                MessageBox.Show("Load Amount is more than the yearly limit");
                return;
            }

            //Check if there is unauth recharge amount for the customer under the same program

            var sLoad = PTSLoadController.getBranchUnAuthLoad(CustomerID_TXT.Text, selectedProgramCode);
            //if(!sLoad.status)
            //{
            //    MessageBox.Show("There is an issue related to Unauthorized load records for this customer");
            //    return;
            //}
            
            if(sLoad.Object.Count > 0)
            {
                MessageBox.Show("There is unauthorized load records for this customer");
                return;
            }

            //Get Wallet Number 
           var sAccount = PTSAccountController.getAccount(CustomerID_TXT.Text, selectedProgramCode);
            if(!sAccount.status)
            {
                MessageBox.Show("There is an issue related to getting Account Info for this Customer");
                return;
            }
            //if(string.IsNullOrWhiteSpace(sAccount.Object.WalletNumber))
            //{
            //    MessageBox.Show("Please ");
            //    return;
            //}

            var sBranch = PTSBranchController.getBranch(int.Parse(Database.Login.branch));
            if (!sBranch.status)
            {
                MessageBox.Show("There is an issue related to getting Branch Code");
                return;
            }

            //Check if the total Load requests doesn't exceed the yearyl limit
            var sBalance = PTSLoadController.getTotalLoadRequestByYear(CustomerID_TXT.Text, selectedProgramCode, Database.YearController.year);

            if(!sBalance.status)
            {
                MessageBox.Show("There is an issue related to getting the customer yearly balance");
                return;
            }

            int total = sBalance.Object.Sum(i => i.Amount);

            if((total + amount) > selectedProgramObject.YearlyLimit)
            {
                MessageBox.Show("Sorry, The total Load Request for this customer exceeds the yearly limit for this program");
                return;
            }


            if(string.IsNullOrWhiteSpace(ExchangeRate_TXT.Text))
            {
                MessageBox.Show("Sorry, The Exchange Rate is not Currect");
                return;
            }

            if(!IsNumeric(ExchangeRate_TXT.Text))
            {
                MessageBox.Show("Sorry, The Exchange Rate is not Currect");
                return;
            }

            decimal ExchangeRate = decimal.Parse(ExchangeRate_TXT.Text);

            if(ExchangeRate > decimal.Parse("4.590") || ExchangeRate < decimal.Parse("1.1"))
            {
                MessageBox.Show("Sorry, The Exchange Rate is not Currect");
                return;
            }
            //if ())
            PTSLoad load = new PTSLoad();
            load.Year = Database.YearController.year;
            load.CustomerID = CustomerID_TXT.Text;
            load.ProgramCode = selectedProgramCode;
            load.BranchCode = sBranch.Object.Code;
            load.Inputter = Database.Login.id;
            load.ExchangeRate = ExchangeRate;
            load.FromCBLFlag = true;
            load.InputTime = DateTime.Now;
            //load.WalletNumber = sAccount.Object.WalletNumber;
            load.Amount = amount;

            //Display Customer info for validation
            DialogResult dialogResult = MessageBox.Show("Customer ID" + CustomerID_TXT.Text + @"\n" + "Name" + sCustomer.Object.EmbossedName + @"\n" + "Account Number:" + sAccount.Object.AccountNumberCurrency + @"\n" + "Amount:" + Amount_TXT.Text + @"\n", "Confirm Load for Customer Wallet", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Add Load Record
               // Status status = PTSLoadController.addLoadRecord(load);
                Status status = PTSLoadController.addLoadRecordFromCBLReport(load);


                if (!status.status)
                {
                    MessageBox.Show("Error in adding Load Record" + status.message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                MessageBox.Show("Done!");
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private bool IsNumeric(string s)
        {
            Regex r = new Regex(@"^[0-9]");

            return r.IsMatch(s);
        }
        private void ConfirmAmount_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaterialLabel12_Click(object sender, EventArgs e)
        {

        }

        private void CustomerID_TXT_TextChanged(object sender, EventArgs e)
        {
            if(CustomerID_TXT.Text.Count() >= 7)
            {
                string selectedProgramCode = String.Concat(Program_CBox.SelectedValue.ToString().Where(c => !Char.IsWhiteSpace(c)));
                var sBalance = PTSLoadController.getTotalLoadRequestByYear(CustomerID_TXT.Text, selectedProgramCode, Database.YearController.year);

                if (!sBalance.status)
                {
                    MessageBox.Show("There is an issue related to getting the customer yearly balance","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                var amount = sBalance.Object.Sum(i => i.Amount);

                var selectedProgramObject = programs.First(p => p.Code == selectedProgramCode);

                if (amount >= selectedProgramObject.YearlyLimit)
                {
                    MessageBox.Show("customer yearly balance reaches the limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Total_LBL.Text = sBalance.Object.Sum(i => i.Amount).ToString();

           

            }
        }
    }


}
