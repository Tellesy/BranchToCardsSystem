namespace MPBS.Screens.User
{
    partial class Add_User
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
            this.Username_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EMPID_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Name_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Password_TXT = new System.Windows.Forms.TextBox();
            this.BranchNumber_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Product_CBox = new System.Windows.Forms.ComboBox();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Username";
            // 
            // Username_TXT
            // 
            this.Username_TXT.Enabled = false;
            this.Username_TXT.Location = new System.Drawing.Point(12, 174);
            this.Username_TXT.MaxLength = 15;
            this.Username_TXT.Name = "Username_TXT";
            this.Username_TXT.Size = new System.Drawing.Size(233, 20);
            this.Username_TXT.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Name";
            // 
            // EMPID_TXT
            // 
            this.EMPID_TXT.Enabled = false;
            this.EMPID_TXT.Location = new System.Drawing.Point(12, 90);
            this.EMPID_TXT.MaxLength = 7;
            this.EMPID_TXT.Name = "EMPID_TXT";
            this.EMPID_TXT.Size = new System.Drawing.Size(89, 20);
            this.EMPID_TXT.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Employee ID";
            // 
            // Name_TXT
            // 
            this.Name_TXT.Enabled = false;
            this.Name_TXT.Location = new System.Drawing.Point(12, 259);
            this.Name_TXT.MaxLength = 16;
            this.Name_TXT.Name = "Name_TXT";
            this.Name_TXT.Size = new System.Drawing.Size(233, 20);
            this.Name_TXT.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Password";
            // 
            // Password_TXT
            // 
            this.Password_TXT.Enabled = false;
            this.Password_TXT.Location = new System.Drawing.Point(12, 218);
            this.Password_TXT.MaxLength = 15;
            this.Password_TXT.Name = "Password_TXT";
            this.Password_TXT.Size = new System.Drawing.Size(233, 20);
            this.Password_TXT.TabIndex = 49;
            // 
            // BranchNumber_TXT
            // 
            this.BranchNumber_TXT.Enabled = false;
            this.BranchNumber_TXT.Location = new System.Drawing.Point(12, 129);
            this.BranchNumber_TXT.MaxLength = 7;
            this.BranchNumber_TXT.Name = "BranchNumber_TXT";
            this.BranchNumber_TXT.Size = new System.Drawing.Size(89, 20);
            this.BranchNumber_TXT.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Branch Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "الصلاحيات";
            // 
            // Product_CBox
            // 
            this.Product_CBox.FormattingEnabled = true;
            this.Product_CBox.Items.AddRange(new object[] {
            "مدخل",
            "مخول",
            "مراجع"});
            this.Product_CBox.Location = new System.Drawing.Point(148, 36);
            this.Product_CBox.Name = "Product_CBox";
            this.Product_CBox.Size = new System.Drawing.Size(99, 21);
            this.Product_CBox.TabIndex = 53;
            this.Product_CBox.SelectedIndexChanged += new System.EventHandler(this.Product_CBox_SelectedIndexChanged);
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(12, 338);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(235, 33);
            this.Back_BTN.TabIndex = 56;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Enabled = false;
            this.Submit_BTN.Location = new System.Drawing.Point(12, 300);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(235, 32);
            this.Submit_BTN.TabIndex = 55;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 385);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Product_CBox);
            this.Controls.Add(this.BranchNumber_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password_TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EMPID_TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Name_TXT);
            this.Name = "Add_User";
            this.Text = "Add_User";
            this.Load += new System.EventHandler(this.Add_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EMPID_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Name_TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password_TXT;
        private System.Windows.Forms.TextBox BranchNumber_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Product_CBox;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Button Submit_BTN;
    }
}