namespace MPBS.Screens.Account_Details
{
    partial class Search
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
            this.Card_Number_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_TXT = new System.Windows.Forms.TextBox();
            this.Customer_ID_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Account_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Card_Number_TXT
            // 
            this.Card_Number_TXT.Location = new System.Drawing.Point(196, 29);
            this.Card_Number_TXT.Name = "Card_Number_TXT";
            this.Card_Number_TXT.Size = new System.Drawing.Size(294, 20);
            this.Card_Number_TXT.TabIndex = 0;
            this.Card_Number_TXT.TextChanged += new System.EventHandler(this.Card_Number_TXT_TextChanged);
            this.Card_Number_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Card_Number_TXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم البطاقة";
            // 
            // Search_BTN
            // 
            this.Search_BTN.Location = new System.Drawing.Point(115, 27);
            this.Search_BTN.Name = "Search_BTN";
            this.Search_BTN.Size = new System.Drawing.Size(75, 23);
            this.Search_BTN.TabIndex = 2;
            this.Search_BTN.Text = "بحث";
            this.Search_BTN.UseVisualStyleBackColor = true;
            this.Search_BTN.Click += new System.EventHandler(this.Search_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "إسم الزبون";
            // 
            // Name_TXT
            // 
            this.Name_TXT.Enabled = false;
            this.Name_TXT.Location = new System.Drawing.Point(196, 133);
            this.Name_TXT.Name = "Name_TXT";
            this.Name_TXT.Size = new System.Drawing.Size(294, 20);
            this.Name_TXT.TabIndex = 4;
            // 
            // Customer_ID_TXT
            // 
            this.Customer_ID_TXT.Enabled = false;
            this.Customer_ID_TXT.Location = new System.Drawing.Point(9, 133);
            this.Customer_ID_TXT.Name = "Customer_ID_TXT";
            this.Customer_ID_TXT.Size = new System.Drawing.Size(117, 20);
            this.Customer_ID_TXT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "رقم الزبون";
            // 
            // Account_TXT
            // 
            this.Account_TXT.Location = new System.Drawing.Point(196, 174);
            this.Account_TXT.Name = "Account_TXT";
            this.Account_TXT.Size = new System.Drawing.Size(294, 20);
            this.Account_TXT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "رقم الحساب";
            // 
            // Product
            // 
            this.Product.Enabled = false;
            this.Product.Location = new System.Drawing.Point(9, 174);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(117, 20);
            this.Product.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "نوع المنتج";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(45, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(507, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "في حالة لاحظت ان اي من هذه البيانات غير صحيح, رجاءً لا تتردد في التواصل مع إدارة " +
    "البطاقات لتصحيح اي خطأ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 284);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Account_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Customer_ID_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Card_Number_TXT);
            this.Name = "Search";
            this.ShowIcon = false;
            this.Text = "بحث عن بيانات بطاقة";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Card_Number_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_TXT;
        private System.Windows.Forms.TextBox Customer_ID_TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Account_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}