namespace CTS.Screens
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Amount_LBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Year_LBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Status_LBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UnuthReport_BTN = new System.Windows.Forms.Button();
            this.Name_LBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CAF_Auth_BTN = new System.Windows.Forms.Button();
            this.PBF_Auth_BTN = new System.Windows.Forms.Button();
            this.PO_Auth_BTN = new System.Windows.Forms.Button();
            this.PO_Gen_BTN = new System.Windows.Forms.Button();
            this.PBF_Gen_BTN = new System.Windows.Forms.Button();
            this.CAF_Gen_BTN = new System.Windows.Forms.Button();
            this.Logout_BTN = new System.Windows.Forms.Button();
            this.Reports_BTN = new System.Windows.Forms.Button();
            this.Password_LBL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Amount_LBL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Year_LBL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Status_LBL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 127);
            this.panel1.TabIndex = 27;
            // 
            // Amount_LBL
            // 
            this.Amount_LBL.AutoSize = true;
            this.Amount_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Amount_LBL.Location = new System.Drawing.Point(10, 85);
            this.Amount_LBL.Name = "Amount_LBL";
            this.Amount_LBL.Size = new System.Drawing.Size(20, 20);
            this.Amount_LBL.TabIndex = 8;
            this.Amount_LBL.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(272, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "سقف الشحن";
            // 
            // Year_LBL
            // 
            this.Year_LBL.AutoSize = true;
            this.Year_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Year_LBL.Location = new System.Drawing.Point(10, 48);
            this.Year_LBL.Name = "Year_LBL";
            this.Year_LBL.Size = new System.Drawing.Size(20, 20);
            this.Year_LBL.TabIndex = 6;
            this.Year_LBL.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(311, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "السنة";
            // 
            // Status_LBL
            // 
            this.Status_LBL.AutoSize = true;
            this.Status_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Status_LBL.Location = new System.Drawing.Point(10, 11);
            this.Status_LBL.Name = "Status_LBL";
            this.Status_LBL.Size = new System.Drawing.Size(20, 20);
            this.Status_LBL.TabIndex = 4;
            this.Status_LBL.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(213, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "حالة الشحن و الإصدار";
            // 
            // UnuthReport_BTN
            // 
            this.UnuthReport_BTN.Font = new System.Drawing.Font("Modern No. 20", 12.25F);
            this.UnuthReport_BTN.Location = new System.Drawing.Point(12, 217);
            this.UnuthReport_BTN.Name = "UnuthReport_BTN";
            this.UnuthReport_BTN.Size = new System.Drawing.Size(172, 119);
            this.UnuthReport_BTN.TabIndex = 1;
            this.UnuthReport_BTN.Text = "Unauthorized Recharge Report";
            this.UnuthReport_BTN.UseVisualStyleBackColor = true;
            this.UnuthReport_BTN.Click += new System.EventHandler(this.UnuthReport_BTN_Click);
            // 
            // Name_LBL
            // 
            this.Name_LBL.AutoSize = true;
            this.Name_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Name_LBL.Location = new System.Drawing.Point(14, 11);
            this.Name_LBL.Name = "Name_LBL";
            this.Name_LBL.Size = new System.Drawing.Size(20, 20);
            this.Name_LBL.TabIndex = 26;
            this.Name_LBL.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(313, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "مرحباً ";
            // 
            // CAF_Auth_BTN
            // 
            this.CAF_Auth_BTN.Font = new System.Drawing.Font("Modern No. 20", 12.25F);
            this.CAF_Auth_BTN.Location = new System.Drawing.Point(190, 343);
            this.CAF_Auth_BTN.Name = "CAF_Auth_BTN";
            this.CAF_Auth_BTN.Size = new System.Drawing.Size(172, 119);
            this.CAF_Auth_BTN.TabIndex = 4;
            this.CAF_Auth_BTN.Text = "Authorize CAF Reocrds";
            this.CAF_Auth_BTN.UseVisualStyleBackColor = true;
            this.CAF_Auth_BTN.Click += new System.EventHandler(this.CAF_Auth_BTN_Click);
            // 
            // PBF_Auth_BTN
            // 
            this.PBF_Auth_BTN.Font = new System.Drawing.Font("Modern No. 20", 12.25F);
            this.PBF_Auth_BTN.Location = new System.Drawing.Point(12, 343);
            this.PBF_Auth_BTN.Name = "PBF_Auth_BTN";
            this.PBF_Auth_BTN.Size = new System.Drawing.Size(172, 119);
            this.PBF_Auth_BTN.TabIndex = 3;
            this.PBF_Auth_BTN.Text = "Authorize PBF Reocrds";
            this.PBF_Auth_BTN.UseVisualStyleBackColor = true;
            this.PBF_Auth_BTN.Click += new System.EventHandler(this.PBF_Auth_BTN_Click);
            // 
            // PO_Auth_BTN
            // 
            this.PO_Auth_BTN.Font = new System.Drawing.Font("Modern No. 20", 12.25F);
            this.PO_Auth_BTN.Location = new System.Drawing.Point(190, 217);
            this.PO_Auth_BTN.Name = "PO_Auth_BTN";
            this.PO_Auth_BTN.Size = new System.Drawing.Size(172, 119);
            this.PO_Auth_BTN.TabIndex = 2;
            this.PO_Auth_BTN.Text = "Authorize PO Reocrds";
            this.PO_Auth_BTN.UseVisualStyleBackColor = true;
            this.PO_Auth_BTN.Click += new System.EventHandler(this.PO_Auth_BTN_Click);
            // 
            // PO_Gen_BTN
            // 
            this.PO_Gen_BTN.Font = new System.Drawing.Font("Modern No. 20", 10.25F);
            this.PO_Gen_BTN.Location = new System.Drawing.Point(546, 343);
            this.PO_Gen_BTN.Name = "PO_Gen_BTN";
            this.PO_Gen_BTN.Size = new System.Drawing.Size(172, 119);
            this.PO_Gen_BTN.TabIndex = 7;
            this.PO_Gen_BTN.Text = "Generate PO File";
            this.PO_Gen_BTN.UseVisualStyleBackColor = true;
            this.PO_Gen_BTN.Click += new System.EventHandler(this.PO_Gen_BTN_Click);
            // 
            // PBF_Gen_BTN
            // 
            this.PBF_Gen_BTN.Font = new System.Drawing.Font("Modern No. 20", 10.25F);
            this.PBF_Gen_BTN.Location = new System.Drawing.Point(368, 218);
            this.PBF_Gen_BTN.Name = "PBF_Gen_BTN";
            this.PBF_Gen_BTN.Size = new System.Drawing.Size(172, 119);
            this.PBF_Gen_BTN.TabIndex = 5;
            this.PBF_Gen_BTN.Text = "Generate PBF File";
            this.PBF_Gen_BTN.UseVisualStyleBackColor = true;
            this.PBF_Gen_BTN.Click += new System.EventHandler(this.PBF_Gen_BTN_Click);
            // 
            // CAF_Gen_BTN
            // 
            this.CAF_Gen_BTN.Font = new System.Drawing.Font("Modern No. 20", 10.25F);
            this.CAF_Gen_BTN.Location = new System.Drawing.Point(368, 343);
            this.CAF_Gen_BTN.Name = "CAF_Gen_BTN";
            this.CAF_Gen_BTN.Size = new System.Drawing.Size(172, 119);
            this.CAF_Gen_BTN.TabIndex = 6;
            this.CAF_Gen_BTN.Text = "Generate CAF File";
            this.CAF_Gen_BTN.UseVisualStyleBackColor = true;
            this.CAF_Gen_BTN.Click += new System.EventHandler(this.CAF_Gen_BTN_Click);
            // 
            // Logout_BTN
            // 
            this.Logout_BTN.Font = new System.Drawing.Font("Modern No. 20", 16.25F);
            this.Logout_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Logout_BTN.Image")));
            this.Logout_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_BTN.Location = new System.Drawing.Point(12, 531);
            this.Logout_BTN.Name = "Logout_BTN";
            this.Logout_BTN.Size = new System.Drawing.Size(350, 70);
            this.Logout_BTN.TabIndex = 9;
            this.Logout_BTN.Text = "تسجيل الخروج";
            this.Logout_BTN.UseVisualStyleBackColor = true;
            this.Logout_BTN.Click += new System.EventHandler(this.Logout_BTN_Click);
            // 
            // Reports_BTN
            // 
            this.Reports_BTN.Enabled = false;
            this.Reports_BTN.Font = new System.Drawing.Font("Modern No. 20", 16.25F);
            this.Reports_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Reports_BTN.Image")));
            this.Reports_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reports_BTN.Location = new System.Drawing.Point(546, 218);
            this.Reports_BTN.Name = "Reports_BTN";
            this.Reports_BTN.Size = new System.Drawing.Size(172, 119);
            this.Reports_BTN.TabIndex = 8;
            this.Reports_BTN.Text = "Reports";
            this.Reports_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Reports_BTN.UseVisualStyleBackColor = true;
            // 
            // Password_LBL
            // 
            this.Password_LBL.AutoSize = true;
            this.Password_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.Password_LBL.ForeColor = System.Drawing.Color.Blue;
            this.Password_LBL.Location = new System.Drawing.Point(614, 11);
            this.Password_LBL.Name = "Password_LBL";
            this.Password_LBL.Size = new System.Drawing.Size(104, 20);
            this.Password_LBL.TabIndex = 32;
            this.Password_LBL.Text = "تغير كلمة المرور";
            this.Password_LBL.Click += new System.EventHandler(this.Password_LBL_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 613);
            this.ControlBox = false;
            this.Controls.Add(this.Password_LBL);
            this.Controls.Add(this.Reports_BTN);
            this.Controls.Add(this.Logout_BTN);
            this.Controls.Add(this.CAF_Gen_BTN);
            this.Controls.Add(this.PBF_Gen_BTN);
            this.Controls.Add(this.PO_Gen_BTN);
            this.Controls.Add(this.PO_Auth_BTN);
            this.Controls.Add(this.PBF_Auth_BTN);
            this.Controls.Add(this.CAF_Auth_BTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UnuthReport_BTN);
            this.Controls.Add(this.Name_LBL);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Amount_LBL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Year_LBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Status_LBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UnuthReport_BTN;
        private System.Windows.Forms.Label Name_LBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CAF_Auth_BTN;
        private System.Windows.Forms.Button PBF_Auth_BTN;
        private System.Windows.Forms.Button PO_Auth_BTN;
        private System.Windows.Forms.Button PO_Gen_BTN;
        private System.Windows.Forms.Button PBF_Gen_BTN;
        private System.Windows.Forms.Button CAF_Gen_BTN;
        private System.Windows.Forms.Button Logout_BTN;
        private System.Windows.Forms.Button Reports_BTN;
        private System.Windows.Forms.Label Password_LBL;
    }
}