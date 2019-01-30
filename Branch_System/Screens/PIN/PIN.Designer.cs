namespace Branch_System.Screens
{
    partial class PIN
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
            this.label2 = new System.Windows.Forms.Label();
            this.AccountUSD_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerName_TXT = new System.Windows.Forms.TextBox();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CardNo_TXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "رقم الحساب (USD)";
            // 
            // AccountUSD_TXT
            // 
            this.AccountUSD_TXT.Location = new System.Drawing.Point(142, 81);
            this.AccountUSD_TXT.MaxLength = 15;
            this.AccountUSD_TXT.Name = "AccountUSD_TXT";
            this.AccountUSD_TXT.Size = new System.Drawing.Size(233, 20);
            this.AccountUSD_TXT.TabIndex = 2;
            this.AccountUSD_TXT.TextChanged += new System.EventHandler(this.AccountUSD_TXT_TextChanged);
            this.AccountUSD_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountUSD_TXT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "اسم الزبون";
            // 
            // CustomerName_TXT
            // 
            this.CustomerName_TXT.Location = new System.Drawing.Point(142, 131);
            this.CustomerName_TXT.MaxLength = 25;
            this.CustomerName_TXT.Name = "CustomerName_TXT";
            this.CustomerName_TXT.Size = new System.Drawing.Size(233, 20);
            this.CustomerName_TXT.TabIndex = 3;
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(12, 208);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(363, 33);
            this.Back_BTN.TabIndex = 5;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Location = new System.Drawing.Point(12, 170);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(363, 32);
            this.Submit_BTN.TabIndex = 4;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "رقم البطاقة";
            // 
            // CardNo_TXT
            // 
            this.CardNo_TXT.Location = new System.Drawing.Point(142, 31);
            this.CardNo_TXT.MaxLength = 16;
            this.CardNo_TXT.Name = "CardNo_TXT";
            this.CardNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.CardNo_TXT.TabIndex = 1;
            this.CardNo_TXT.TextChanged += new System.EventHandler(this.CardNo_TXT_TextChanged);
            this.CardNo_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNo_TXT_KeyPress);
            // 
            // PIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 249);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccountUSD_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerName_TXT);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CardNo_TXT);
            this.Name = "PIN";
            this.Text = "إعادة إصدار الرقم السري";
            this.Load += new System.EventHandler(this.PIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountUSD_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerName_TXT;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Button Submit_BTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CardNo_TXT;
    }
}