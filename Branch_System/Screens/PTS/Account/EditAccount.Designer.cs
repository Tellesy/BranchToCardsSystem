namespace MPBS.Screens.PTS.Account
{
    partial class EditAccount
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
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ProgramAccount_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerID_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MainAccount_TXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Program_CBox = new System.Windows.Forms.ComboBox();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(197, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 13);
            this.label18.TabIndex = 96;
            this.label18.Text = "رقم الحساب الخاص بالمنتج ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(167, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 13);
            this.label17.TabIndex = 95;
            this.label17.Text = "رقم الحساب الأساسي (دينار ليبي)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 94;
            this.label16.Text = "رقم الزبون";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(190, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 93;
            this.label15.Text = "المنتج";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "Program Account Number";
            // 
            // ProgramAccount_TXT
            // 
            this.ProgramAccount_TXT.Enabled = false;
            this.ProgramAccount_TXT.Location = new System.Drawing.Point(15, 171);
            this.ProgramAccount_TXT.MaxLength = 15;
            this.ProgramAccount_TXT.Name = "ProgramAccount_TXT";
            this.ProgramAccount_TXT.Size = new System.Drawing.Size(233, 20);
            this.ProgramAccount_TXT.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Main LYD Account Number";
            // 
            // CustomerID_TXT
            // 
            this.CustomerID_TXT.Enabled = false;
            this.CustomerID_TXT.Location = new System.Drawing.Point(15, 65);
            this.CustomerID_TXT.MaxLength = 7;
            this.CustomerID_TXT.Name = "CustomerID_TXT";
            this.CustomerID_TXT.Size = new System.Drawing.Size(93, 20);
            this.CustomerID_TXT.TabIndex = 86;
            this.CustomerID_TXT.TextChanged += new System.EventHandler(this.CustomerID_TXT_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Customer ID";
            // 
            // MainAccount_TXT
            // 
            this.MainAccount_TXT.Enabled = false;
            this.MainAccount_TXT.Location = new System.Drawing.Point(15, 113);
            this.MainAccount_TXT.MaxLength = 15;
            this.MainAccount_TXT.Name = "MainAccount_TXT";
            this.MainAccount_TXT.Size = new System.Drawing.Size(233, 20);
            this.MainAccount_TXT.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "Program";
            // 
            // Program_CBox
            // 
            this.Program_CBox.FormattingEnabled = true;
            this.Program_CBox.Location = new System.Drawing.Point(15, 25);
            this.Program_CBox.Name = "Program_CBox";
            this.Program_CBox.Size = new System.Drawing.Size(209, 21);
            this.Program_CBox.TabIndex = 85;
            this.Program_CBox.SelectedIndexChanged += new System.EventHandler(this.Program_CBox_SelectedIndexChanged);
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(12, 254);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(363, 33);
            this.Back_BTN.TabIndex = 98;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Enabled = false;
            this.Submit_BTN.Location = new System.Drawing.Point(12, 216);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(363, 32);
            this.Submit_BTN.TabIndex = 97;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 303);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ProgramAccount_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerID_TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MainAccount_TXT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Program_CBox);
            this.Name = "EditAccount";
            this.Text = "EditAccount";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ProgramAccount_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerID_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MainAccount_TXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Program_CBox;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Button Submit_BTN;
    }
}