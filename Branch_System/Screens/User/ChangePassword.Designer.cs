namespace CTS.Screens.User
{
    partial class ChangePassword
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
            this.Password_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPassword_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmPassword_TXT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label2.Location = new System.Drawing.Point(290, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "كلمة المرور الحالية";
            // 
            // Password_TXT
            // 
            this.Password_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TXT.Location = new System.Drawing.Point(12, 12);
            this.Password_TXT.Name = "Password_TXT";
            this.Password_TXT.PasswordChar = '*';
            this.Password_TXT.Size = new System.Drawing.Size(257, 29);
            this.Password_TXT.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label1.Location = new System.Drawing.Point(287, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "كلمة المرور الجديدة";
            // 
            // NewPassword_TXT
            // 
            this.NewPassword_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword_TXT.Location = new System.Drawing.Point(12, 63);
            this.NewPassword_TXT.Name = "NewPassword_TXT";
            this.NewPassword_TXT.PasswordChar = '*';
            this.NewPassword_TXT.Size = new System.Drawing.Size(257, 29);
            this.NewPassword_TXT.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label3.Location = new System.Drawing.Point(300, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "تأكيد كلمة المرور";
            // 
            // ConfirmPassword_TXT
            // 
            this.ConfirmPassword_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword_TXT.Location = new System.Drawing.Point(12, 113);
            this.ConfirmPassword_TXT.Name = "ConfirmPassword_TXT";
            this.ConfirmPassword_TXT.PasswordChar = '*';
            this.ConfirmPassword_TXT.Size = new System.Drawing.Size(257, 29);
            this.ConfirmPassword_TXT.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(77, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "تعديل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfirmPassword_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPassword_TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_TXT);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPassword_TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConfirmPassword_TXT;
        private System.Windows.Forms.Button button1;
    }
}