using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.AuthRecharge
{
    public partial class Authorize : Form
    {

        public Database.Objects.Recharge record;
        private int TotalAmountThisYear;
        //private bool isEnquire = false;
        public Authorize()
        {
            InitializeComponent();
        }

        private void Authorize_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            if (Database.Login.role == "0")
            {
                Accept_BTN.Enabled = false;
                Deny_BTN.Enabled = false;
                Accept_BTN.Hide();
                Deny_BTN.Hide();
            }

            if(record == null)
            {
                this.Close();
            }
            else
            {
                CustomerID_LBL.Text = record.Customer_ID;

                Database.Objects.Status<Database.Objects.Customer> status = Database.Issue.getCustomer(record.Customer_ID);

                if(status.status)
                {
                    CustomerName_LBL.Text = status.Object.Name;
                }

                Database.Objects.Status<int> amountStatus = Database.Recharge.checkRechargeAmountThisYear(record.NID, record.Product);

                if (amountStatus.status)
                {
                    TotalAmountThisYear = amountStatus.Object;
                    Total_Amount_LBL.Text = amountStatus.Object.ToString();
                }


                NID_LBL.Text = record.NID;
                Branch_LBL.Text = record.Branch.ToString() ;
                Product_LBL.Text = record.Product;
                Inputter_LBL.Text = record.Inputter.ToString();
                Amount_LBL.Text = record.Amount.ToString();
                CardAccount_LBL.Text = record.CardAccount;
                RecordDate_LBL.Text = record.Time;
                if(record.Type == 0)
                {
                    Type_LBL.Text = "إصدار";
                }
                if(record.Type == 1)
                {
                    Type_LBL.Text = "شحن \\ إعادة شحن";
                }
            }
        }

        private void Accept_BTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من تخويل هذه العملية؟", "تخويل العملية", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Cancel the request if the total amount this year is bigger than the allowed amount of this year
                if(TotalAmountThisYear + record.Amount > Database.Recharge.amount)
                {
                    MessageBox.Show("إجمالي العملية يتجاوز سقف الشحن لهذا العام");
                    return;
                }

                int recharge = 0; 
                Database.Status status = Database.Recharge.authRecharge(record.ID);
        
                if (status.status)
                {
                    //Get Total Amount to be added to PBF
                    Database.Objects.Status<int> amountStatus = Database.Recharge.checkRechargeAmount(record.NID, record.Product);
                    if(amountStatus.status)
                    {
                        recharge = amountStatus.Object;

                    }
                    else
                    {
                        MessageBox.Show(amountStatus.message);
                    }

                    //Database.Status s =  Database.PBF.addPBF(record.CardAccount, recharge, record.NID, record.Product);
                    Database.Status s = Database.PBF.addPBF(record.CardAccount, record.Amount, record.NID, record.Product);

                    if (!s.status)
                    {
                        MessageBox.Show(s.message);
                    }
                    MessageBox.Show("تم تخويل العملية بنجاح");
                    record = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(status.message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            record = null;
            this.Close();
        }

        private void Deny_BTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من إلغاء هذه العملية؟", "إلغاء العملية", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               Database.Status status =  Database.Recharge.deleteRecharge(record.ID);

                if(status.status)
                {
                    MessageBox.Show("تم إلغاء العملية بنجاح");
                    record = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(status.message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
