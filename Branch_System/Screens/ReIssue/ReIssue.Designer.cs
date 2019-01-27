namespace Branch_System.Screens.ReIssue
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
            this.AccountUSD_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CardNo_TXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Product_CBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(8, 227);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(363, 33);
            this.Back_BTN.TabIndex = 39;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Enabled = false;
            this.Submit_BTN.Location = new System.Drawing.Point(8, 189);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(363, 32);
            this.Submit_BTN.TabIndex = 38;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "رقم الحساب (USD)";
            // 
            // AccountUSD_TXT
            // 
            this.AccountUSD_TXT.Enabled = false;
            this.AccountUSD_TXT.Location = new System.Drawing.Point(138, 143);
            this.AccountUSD_TXT.MaxLength = 15;
            this.AccountUSD_TXT.Name = "AccountUSD_TXT";
            this.AccountUSD_TXT.Size = new System.Drawing.Size(233, 20);
            this.AccountUSD_TXT.TabIndex = 37;
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
            this.CardNo_TXT.TabIndex = 36;
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
            // Product_CBox
            // 
            this.Product_CBox.FormattingEnabled = true;
            this.Product_CBox.Items.AddRange(new object[] {
            "ارباب الاسر 10",
            "أغراض شخصية 30"});
            this.Product_CBox.Location = new System.Drawing.Point(162, 34);
            this.Product_CBox.Name = "Product_CBox";
            this.Product_CBox.Size = new System.Drawing.Size(209, 21);
            this.Product_CBox.TabIndex = 35;
            // 
            // ReIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 715);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccountUSD_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardNo_TXT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Product_CBox);
            this.Name = "ReIssue";
            this.Text = "ReIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Button Submit_BTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AccountUSD_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardNo_TXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Product_CBox;
    }
}