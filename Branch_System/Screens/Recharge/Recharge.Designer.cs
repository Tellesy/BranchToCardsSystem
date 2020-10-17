namespace MPBS.Screens
{
    partial class Recharge
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
            this.label9 = new System.Windows.Forms.Label();
            this.Amount_TXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NID_TXT = new System.Windows.Forms.TextBox();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.Total_This_Year_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Total_Amount_TXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CardNo_TXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Product_CBox = new System.Windows.Forms.ComboBox();
            this.Customer_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Validate_BTN = new System.Windows.Forms.Button();
            this.Customer_Name_TXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "قيمة الشحن بالدولار";
            // 
            // Amount_TXT
            // 
            this.Amount_TXT.Enabled = false;
            this.Amount_TXT.Location = new System.Drawing.Point(231, 253);
            this.Amount_TXT.MaxLength = 5;
            this.Amount_TXT.Name = "Amount_TXT";
            this.Amount_TXT.Size = new System.Drawing.Size(141, 20);
            this.Amount_TXT.TabIndex = 5;
            this.Amount_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_TXT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "الرقم الوطني";
            // 
            // NID_TXT
            // 
            this.NID_TXT.Enabled = false;
            this.NID_TXT.Location = new System.Drawing.Point(136, 186);
            this.NID_TXT.MaxLength = 12;
            this.NID_TXT.Name = "NID_TXT";
            this.NID_TXT.Size = new System.Drawing.Size(233, 20);
            this.NID_TXT.TabIndex = 3;
            this.NID_TXT.TextChanged += new System.EventHandler(this.NID_TXT_TextChanged);
            this.NID_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NID_TXT_KeyPress);
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(12, 407);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(363, 33);
            this.Back_BTN.TabIndex = 51;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Enabled = false;
            this.Submit_BTN.Location = new System.Drawing.Point(12, 369);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(363, 32);
            this.Submit_BTN.TabIndex = 6;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // Total_This_Year_TXT
            // 
            this.Total_This_Year_TXT.Enabled = false;
            this.Total_This_Year_TXT.Location = new System.Drawing.Point(231, 301);
            this.Total_This_Year_TXT.MaxLength = 5;
            this.Total_This_Year_TXT.Name = "Total_This_Year_TXT";
            this.Total_This_Year_TXT.Size = new System.Drawing.Size(141, 20);
            this.Total_This_Year_TXT.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "إجمالي قيمة الشحن لهذا العام";
            // 
            // Total_Amount_TXT
            // 
            this.Total_Amount_TXT.Enabled = false;
            this.Total_Amount_TXT.Location = new System.Drawing.Point(46, 301);
            this.Total_Amount_TXT.MaxLength = 5;
            this.Total_Amount_TXT.Name = "Total_Amount_TXT";
            this.Total_Amount_TXT.Size = new System.Drawing.Size(141, 20);
            this.Total_Amount_TXT.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "إجمالي قيمة الشحن منذ انشاء الحساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "رقم حساب البطاقة (رقم اول بطاقة صدرت للزبون لهذا المنتج)";
            // 
            // CardNo_TXT
            // 
            this.CardNo_TXT.Enabled = false;
            this.CardNo_TXT.Location = new System.Drawing.Point(136, 135);
            this.CardNo_TXT.MaxLength = 16;
            this.CardNo_TXT.Name = "CardNo_TXT";
            this.CardNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.CardNo_TXT.TabIndex = 2;
            this.CardNo_TXT.TextChanged += new System.EventHandler(this.CardNo_TXT_TextChanged);
            this.CardNo_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNo_TXT_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "نوع المنتج";
            // 
            // Product_CBox
            // 
            this.Product_CBox.FormattingEnabled = true;
            this.Product_CBox.Items.AddRange(new object[] {
            "ارباب الاسر 10",
            "أغراض شخصية 30"});
            this.Product_CBox.Location = new System.Drawing.Point(160, 35);
            this.Product_CBox.Name = "Product_CBox";
            this.Product_CBox.Size = new System.Drawing.Size(209, 21);
            this.Product_CBox.TabIndex = 1;
            this.Product_CBox.SelectedIndexChanged += new System.EventHandler(this.Product_CBox_SelectedIndexChanged);
            // 
            // Customer_ID
            // 
            this.Customer_ID.Enabled = false;
            this.Customer_ID.Location = new System.Drawing.Point(280, 87);
            this.Customer_ID.MaxLength = 7;
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Size = new System.Drawing.Size(89, 20);
            this.Customer_ID.TabIndex = 4;
            this.Customer_ID.TextChanged += new System.EventHandler(this.Customer_ID_TextChanged);
            this.Customer_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Customer_ID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "رقم الزبون";
            // 
            // Validate_BTN
            // 
            this.Validate_BTN.Enabled = false;
            this.Validate_BTN.Location = new System.Drawing.Point(12, 331);
            this.Validate_BTN.Name = "Validate_BTN";
            this.Validate_BTN.Size = new System.Drawing.Size(363, 32);
            this.Validate_BTN.TabIndex = 63;
            this.Validate_BTN.Text = "تحقق";
            this.Validate_BTN.UseVisualStyleBackColor = true;
            this.Validate_BTN.Click += new System.EventHandler(this.Validate_BTN_Click);
            // 
            // Customer_Name_TXT
            // 
            this.Customer_Name_TXT.Enabled = false;
            this.Customer_Name_TXT.Location = new System.Drawing.Point(136, 212);
            this.Customer_Name_TXT.MaxLength = 30;
            this.Customer_Name_TXT.Name = "Customer_Name_TXT";
            this.Customer_Name_TXT.Size = new System.Drawing.Size(233, 20);
            this.Customer_Name_TXT.TabIndex = 64;
            // 
            // Recharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 469);
            this.ControlBox = false;
            this.Controls.Add(this.Customer_Name_TXT);
            this.Controls.Add(this.Validate_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Customer_ID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Product_CBox);
            this.Controls.Add(this.CardNo_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Total_Amount_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total_This_Year_TXT);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Amount_TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NID_TXT);
            this.Name = "Recharge";
            this.Text = "الشحن";
            this.Load += new System.EventHandler(this.Recharge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Amount_TXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NID_TXT;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Button Submit_BTN;
        private System.Windows.Forms.TextBox Total_This_Year_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Total_Amount_TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CardNo_TXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Product_CBox;
        private System.Windows.Forms.TextBox Customer_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Validate_BTN;
        private System.Windows.Forms.TextBox Customer_Name_TXT;
    }
}