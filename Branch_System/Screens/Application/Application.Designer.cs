namespace CTS
{
    partial class Application
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
            this.CardNo_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OldCardNo_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerName_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NID_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountUSD_TXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BirthDate_TXT = new System.Windows.Forms.TextBox();
            this.PhoneNo_TXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ApplicationType_CBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Amount_TXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductType_CBox = new System.Windows.Forms.ComboBox();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PIN_card = new System.Windows.Forms.TextBox();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Old_Amount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.TextBox();
            this.NIDUpdate_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CardNo_TXT
            // 
            this.CardNo_TXT.Location = new System.Drawing.Point(299, 50);
            this.CardNo_TXT.MaxLength = 16;
            this.CardNo_TXT.Name = "CardNo_TXT";
            this.CardNo_TXT.ReadOnly = true;
            this.CardNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.CardNo_TXT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم البطاقة الجديد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "رقم أول بطاقة تم إصدارها";
            // 
            // OldCardNo_TXT
            // 
            this.OldCardNo_TXT.Enabled = false;
            this.OldCardNo_TXT.Location = new System.Drawing.Point(299, 101);
            this.OldCardNo_TXT.MaxLength = 16;
            this.OldCardNo_TXT.Name = "OldCardNo_TXT";
            this.OldCardNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.OldCardNo_TXT.TabIndex = 2;
            this.OldCardNo_TXT.TextChanged += new System.EventHandler(this.OldCardNo_TXT_TextChanged);
            this.OldCardNo_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldCardNo_TXT_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(284, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "موجود في ورقة المعاملة";
            // 
            // CustomerName_TXT
            // 
            this.CustomerName_TXT.Enabled = false;
            this.CustomerName_TXT.Location = new System.Drawing.Point(299, 211);
            this.CustomerName_TXT.MaxLength = 25;
            this.CustomerName_TXT.Name = "CustomerName_TXT";
            this.CustomerName_TXT.Size = new System.Drawing.Size(233, 20);
            this.CustomerName_TXT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "اسم الزبون";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "الرقم الوطني";
            // 
            // NID_TXT
            // 
            this.NID_TXT.Enabled = false;
            this.NID_TXT.Location = new System.Drawing.Point(299, 261);
            this.NID_TXT.MaxLength = 12;
            this.NID_TXT.Name = "NID_TXT";
            this.NID_TXT.Size = new System.Drawing.Size(233, 20);
            this.NID_TXT.TabIndex = 7;
            this.NID_TXT.TextChanged += new System.EventHandler(this.NID_TXT_TextChanged);
            this.NID_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NID_TXT_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "رقم الحساب (USD)";
            // 
            // AccountUSD_TXT
            // 
            this.AccountUSD_TXT.Enabled = false;
            this.AccountUSD_TXT.Location = new System.Drawing.Point(299, 154);
            this.AccountUSD_TXT.MaxLength = 15;
            this.AccountUSD_TXT.Name = "AccountUSD_TXT";
            this.AccountUSD_TXT.Size = new System.Drawing.Size(233, 20);
            this.AccountUSD_TXT.TabIndex = 9;
            this.AccountUSD_TXT.TextChanged += new System.EventHandler(this.AccountUSD_TXT_TextChanged);
            this.AccountUSD_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountUSD_TXT_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "تاريخ الميلاد (DDMMYYYY)";
            // 
            // BirthDate_TXT
            // 
            this.BirthDate_TXT.Enabled = false;
            this.BirthDate_TXT.Location = new System.Drawing.Point(299, 359);
            this.BirthDate_TXT.MaxLength = 8;
            this.BirthDate_TXT.Name = "BirthDate_TXT";
            this.BirthDate_TXT.Size = new System.Drawing.Size(233, 20);
            this.BirthDate_TXT.TabIndex = 11;
            this.BirthDate_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BirthDate_TXT_KeyPress);
            // 
            // PhoneNo_TXT
            // 
            this.PhoneNo_TXT.Enabled = false;
            this.PhoneNo_TXT.Location = new System.Drawing.Point(299, 407);
            this.PhoneNo_TXT.MaxLength = 10;
            this.PhoneNo_TXT.Name = "PhoneNo_TXT";
            this.PhoneNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.PhoneNo_TXT.TabIndex = 13;
            this.PhoneNo_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNo_TXT_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "رقم الهاتف (091XXXXXXX)";
            // 
            // ApplicationType_CBox
            // 
            this.ApplicationType_CBox.Enabled = false;
            this.ApplicationType_CBox.FormattingEnabled = true;
            this.ApplicationType_CBox.Items.AddRange(new object[] {
            "إصدار جديد + شحن",
            "إصدار جديد فقط (صفر رصيد)",
            "شحن اول مرة",
            "إعادة شحن",
            "إعادة إصدار بطاقة",
            "إعادة اصدار رقم سري"});
            this.ApplicationType_CBox.Location = new System.Drawing.Point(565, 100);
            this.ApplicationType_CBox.Name = "ApplicationType_CBox";
            this.ApplicationType_CBox.Size = new System.Drawing.Size(121, 21);
            this.ApplicationType_CBox.TabIndex = 15;
            this.ApplicationType_CBox.SelectedIndexChanged += new System.EventHandler(this.ApplicationType_CBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "قيمة الشحن بالدولار";
            // 
            // Amount_TXT
            // 
            this.Amount_TXT.Enabled = false;
            this.Amount_TXT.Location = new System.Drawing.Point(121, 50);
            this.Amount_TXT.MaxLength = 5;
            this.Amount_TXT.Name = "Amount_TXT";
            this.Amount_TXT.Size = new System.Drawing.Size(141, 20);
            this.Amount_TXT.TabIndex = 16;
            this.Amount_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_TXT_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "نوع المعاملة";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(632, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "نوع المنتج";
            // 
            // ProductType_CBox
            // 
            this.ProductType_CBox.FormattingEnabled = true;
            this.ProductType_CBox.Items.AddRange(new object[] {
            "ارباب الاسر 10",
            "أغراض شخصية 30"});
            this.ProductType_CBox.Location = new System.Drawing.Point(565, 49);
            this.ProductType_CBox.Name = "ProductType_CBox";
            this.ProductType_CBox.Size = new System.Drawing.Size(121, 21);
            this.ProductType_CBox.TabIndex = 19;
            this.ProductType_CBox.SelectedIndexChanged += new System.EventHandler(this.ProductType_CBox_SelectedIndexChanged);
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Enabled = false;
            this.Submit_BTN.Location = new System.Drawing.Point(12, 381);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(252, 23);
            this.Submit_BTN.TabIndex = 21;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "رقم البطاقة في حالة اعادة اصدار الرقم السري";
            // 
            // PIN_card
            // 
            this.PIN_card.Enabled = false;
            this.PIN_card.Location = new System.Drawing.Point(29, 170);
            this.PIN_card.MaxLength = 16;
            this.PIN_card.Name = "PIN_card";
            this.PIN_card.Size = new System.Drawing.Size(233, 20);
            this.PIN_card.TabIndex = 22;
            this.PIN_card.TextChanged += new System.EventHandler(this.PIN_card_TextChanged);
            this.PIN_card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PIN_card_KeyPress);
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(12, 410);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(252, 23);
            this.Back_BTN.TabIndex = 24;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(137, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "اجمالي قيم الشحن السابقة";
            // 
            // Old_Amount
            // 
            this.Old_Amount.Enabled = false;
            this.Old_Amount.Location = new System.Drawing.Point(121, 101);
            this.Old_Amount.MaxLength = 5;
            this.Old_Amount.Name = "Old_Amount";
            this.Old_Amount.Size = new System.Drawing.Size(141, 20);
            this.Old_Amount.TabIndex = 25;
            this.Old_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Old_Amount_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(457, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "رقم جواز السفر";
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(299, 304);
            this.Passport.MaxLength = 8;
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(233, 20);
            this.Passport.TabIndex = 27;
            // 
            // NIDUpdate_BTN
            // 
            this.NIDUpdate_BTN.Enabled = false;
            this.NIDUpdate_BTN.Location = new System.Drawing.Point(204, 252);
            this.NIDUpdate_BTN.Name = "NIDUpdate_BTN";
            this.NIDUpdate_BTN.Size = new System.Drawing.Size(89, 36);
            this.NIDUpdate_BTN.TabIndex = 29;
            this.NIDUpdate_BTN.Text = "إضافة\\تعديل الرقم الوطني";
            this.NIDUpdate_BTN.UseVisualStyleBackColor = true;
            this.NIDUpdate_BTN.Click += new System.EventHandler(this.NIDUpdate_BTN_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 445);
            this.Controls.Add(this.NIDUpdate_BTN);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Old_Amount);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PIN_card);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProductType_CBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Amount_TXT);
            this.Controls.Add(this.ApplicationType_CBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PhoneNo_TXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BirthDate_TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccountUSD_TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NID_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerName_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OldCardNo_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardNo_TXT);
            this.Name = "Application";
            this.Text = "الإصدار و الشحن";
            this.Load += new System.EventHandler(this.Application_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardNo_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OldCardNo_TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerName_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NID_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AccountUSD_TXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BirthDate_TXT;
        private System.Windows.Forms.TextBox PhoneNo_TXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ApplicationType_CBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Amount_TXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ProductType_CBox;
        private System.Windows.Forms.Button Submit_BTN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PIN_card;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Old_Amount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Button NIDUpdate_BTN;
    }
}

