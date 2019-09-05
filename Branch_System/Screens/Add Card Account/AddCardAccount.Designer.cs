namespace CTS.Screens.Card_Enquire
{
    partial class CardENQ
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
            this.label6 = new System.Windows.Forms.Label();
            this.CardAccountNo_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerID_TXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountUSDNo_TXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Product_CBox = new System.Windows.Forms.ComboBox();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "رقم اول بطاقة صدرت للزبون تحت هذا المنتج";
            // 
            // CardAccountNo_TXT
            // 
            this.CardAccountNo_TXT.Enabled = false;
            this.CardAccountNo_TXT.Location = new System.Drawing.Point(142, 111);
            this.CardAccountNo_TXT.MaxLength = 16;
            this.CardAccountNo_TXT.Name = "CardAccountNo_TXT";
            this.CardAccountNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.CardAccountNo_TXT.TabIndex = 36;
            this.CardAccountNo_TXT.TextChanged += new System.EventHandler(this.CardAccountNo_TXT_TextChanged);
            this.CardAccountNo_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardAccountNo_TXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "رقم الزبون";
            // 
            // CustomerID_TXT
            // 
            this.CustomerID_TXT.Enabled = false;
            this.CustomerID_TXT.Location = new System.Drawing.Point(142, 161);
            this.CustomerID_TXT.MaxLength = 15;
            this.CustomerID_TXT.Name = "CustomerID_TXT";
            this.CustomerID_TXT.Size = new System.Drawing.Size(233, 20);
            this.CustomerID_TXT.TabIndex = 39;
            this.CustomerID_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerID_TXT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "رقم الحساب (USD)";
            // 
            // AccountUSDNo_TXT
            // 
            this.AccountUSDNo_TXT.Enabled = false;
            this.AccountUSDNo_TXT.Location = new System.Drawing.Point(142, 217);
            this.AccountUSDNo_TXT.MaxLength = 15;
            this.AccountUSDNo_TXT.Name = "AccountUSDNo_TXT";
            this.AccountUSDNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.AccountUSDNo_TXT.TabIndex = 41;
            this.AccountUSDNo_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountUSDNo_TXT_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "نوع المنتج";
            // 
            // Product_CBox
            // 
            this.Product_CBox.FormattingEnabled = true;
            this.Product_CBox.Items.AddRange(new object[] {
            "ارباب الاسر 10",
            "أغراض شخصية 30"});
            this.Product_CBox.Location = new System.Drawing.Point(166, 39);
            this.Product_CBox.Name = "Product_CBox";
            this.Product_CBox.Size = new System.Drawing.Size(209, 21);
            this.Product_CBox.TabIndex = 43;
            this.Product_CBox.SelectedIndexChanged += new System.EventHandler(this.Product_CBox_SelectedIndexChanged);
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(12, 308);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(363, 33);
            this.Back_BTN.TabIndex = 46;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Enabled = false;
            this.Submit_BTN.Location = new System.Drawing.Point(12, 270);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(363, 32);
            this.Submit_BTN.TabIndex = 45;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // CardENQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 348);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Product_CBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccountUSDNo_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerID_TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CardAccountNo_TXT);
            this.Name = "CardENQ";
            this.Text = "CardENQ";
            this.Load += new System.EventHandler(this.CardENQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CardAccountNo_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerID_TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountUSDNo_TXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Product_CBox;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Button Submit_BTN;
    }
}