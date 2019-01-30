namespace Branch_System.Screens
{
    partial class ReIssue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CardAccount_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CardNo_TXT = new System.Windows.Forms.TextBox();
            this.Product_CBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneNo_TXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BirthDate_TXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountUSD_TXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NID_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerName_TXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(8, 536);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(363, 33);
            this.Back_BTN.TabIndex = 39;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Enabled = false;
            this.Submit_BTN.Location = new System.Drawing.Point(8, 498);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(363, 32);
            this.Submit_BTN.TabIndex = 38;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "رقم حساب البطاقة (رقم اول بطاقة صدرت للزبون لهذا المنتج)";
            // 
            // CardAccount_TXT
            // 
            this.CardAccount_TXT.Enabled = false;
            this.CardAccount_TXT.Location = new System.Drawing.Point(138, 143);
            this.CardAccount_TXT.MaxLength = 16;
            this.CardAccount_TXT.Name = "CardAccount_TXT";
            this.CardAccount_TXT.Size = new System.Drawing.Size(233, 20);
            this.CardAccount_TXT.TabIndex = 3;
            this.CardAccount_TXT.TextChanged += new System.EventHandler(this.CardAccount_TXT_TextChanged);
            this.CardAccount_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardAccount_TXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "رقم البطاقة الجديد";
            // 
            // CardNo_TXT
            // 
            this.CardNo_TXT.Location = new System.Drawing.Point(138, 93);
            this.CardNo_TXT.MaxLength = 16;
            this.CardNo_TXT.Name = "CardNo_TXT";
            this.CardNo_TXT.ReadOnly = true;
            this.CardNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.CardNo_TXT.TabIndex = 2;
            // 
            // Product_CBox
            // 
            this.Product_CBox.FormattingEnabled = true;
            this.Product_CBox.Items.AddRange(new object[] {
            "ارباب الاسر 10",
            "أغراض شخصية 30"});
            this.Product_CBox.Location = new System.Drawing.Point(162, 34);
            this.Product_CBox.Name = "Product_CBox";
            this.Product_CBox.Size = new System.Drawing.Size(209, 21);
            this.Product_CBox.TabIndex = 1;
            this.Product_CBox.SelectedIndexChanged += new System.EventHandler(this.Product_CBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "نوع المنتج";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(296, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "رقم جواز السفر";
            // 
            // Passport
            // 
            this.Passport.Enabled = false;
            this.Passport.Location = new System.Drawing.Point(138, 343);
            this.Passport.MaxLength = 8;
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(233, 20);
            this.Passport.TabIndex = 7;
            this.Passport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Passport_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "رقم الهاتف (091XXXXXXX)";
            // 
            // PhoneNo_TXT
            // 
            this.PhoneNo_TXT.Enabled = false;
            this.PhoneNo_TXT.Location = new System.Drawing.Point(138, 446);
            this.PhoneNo_TXT.MaxLength = 10;
            this.PhoneNo_TXT.Name = "PhoneNo_TXT";
            this.PhoneNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.PhoneNo_TXT.TabIndex = 9;
            this.PhoneNo_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNo_TXT_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "تاريخ الميلاد (DDMMYYYY)";
            // 
            // BirthDate_TXT
            // 
            this.BirthDate_TXT.Enabled = false;
            this.BirthDate_TXT.Location = new System.Drawing.Point(138, 398);
            this.BirthDate_TXT.MaxLength = 8;
            this.BirthDate_TXT.Name = "BirthDate_TXT";
            this.BirthDate_TXT.Size = new System.Drawing.Size(233, 20);
            this.BirthDate_TXT.TabIndex = 8;
            this.BirthDate_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BirthDate_TXT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "رقم الحساب (USD)";
            // 
            // AccountUSD_TXT
            // 
            this.AccountUSD_TXT.Enabled = false;
            this.AccountUSD_TXT.Location = new System.Drawing.Point(138, 193);
            this.AccountUSD_TXT.MaxLength = 15;
            this.AccountUSD_TXT.Name = "AccountUSD_TXT";
            this.AccountUSD_TXT.Size = new System.Drawing.Size(233, 20);
            this.AccountUSD_TXT.TabIndex = 4;
            this.AccountUSD_TXT.TextChanged += new System.EventHandler(this.AccountUSD_TXT_TextChanged);
            this.AccountUSD_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountUSD_TXT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "الرقم الوطني";
            // 
            // NID_TXT
            // 
            this.NID_TXT.Enabled = false;
            this.NID_TXT.Location = new System.Drawing.Point(138, 295);
            this.NID_TXT.MaxLength = 12;
            this.NID_TXT.Name = "NID_TXT";
            this.NID_TXT.Size = new System.Drawing.Size(233, 20);
            this.NID_TXT.TabIndex = 6;
            this.NID_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NID_TXT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "اسم الزبون";
            // 
            // CustomerName_TXT
            // 
            this.CustomerName_TXT.Enabled = false;
            this.CustomerName_TXT.Location = new System.Drawing.Point(138, 243);
            this.CustomerName_TXT.MaxLength = 25;
            this.CustomerName_TXT.Name = "CustomerName_TXT";
            this.CustomerName_TXT.Size = new System.Drawing.Size(233, 20);
            this.CustomerName_TXT.TabIndex = 5;
            // 
            // ReIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 578);
            this.ControlBox = false;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PhoneNo_TXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BirthDate_TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccountUSD_TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NID_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerName_TXT);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CardAccount_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardNo_TXT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Product_CBox);
            this.Name = "ReIssue";
            this.Text = "إعادة إصدار بطاقة";
            this.Load += new System.EventHandler(this.ReIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Button Submit_BTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CardAccount_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardNo_TXT;
        private System.Windows.Forms.ComboBox Product_CBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PhoneNo_TXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BirthDate_TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountUSD_TXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NID_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerName_TXT;
    }
}