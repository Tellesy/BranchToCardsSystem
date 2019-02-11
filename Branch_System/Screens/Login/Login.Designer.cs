namespace CTS.Screens
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_BTN = new System.Windows.Forms.Button();
            this.Username_TXT = new System.Windows.Forms.TextBox();
            this.Password_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Version_LBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_BTN
            // 
            this.Login_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Login_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_BTN.Location = new System.Drawing.Point(440, 406);
            this.Login_BTN.Name = "Login_BTN";
            this.Login_BTN.Size = new System.Drawing.Size(110, 42);
            this.Login_BTN.TabIndex = 0;
            this.Login_BTN.Text = "دخول";
            this.Login_BTN.UseVisualStyleBackColor = true;
            this.Login_BTN.Click += new System.EventHandler(this.Login_BTN_Click);
            // 
            // Username_TXT
            // 
            this.Username_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_TXT.Location = new System.Drawing.Point(364, 317);
            this.Username_TXT.Name = "Username_TXT";
            this.Username_TXT.Size = new System.Drawing.Size(257, 29);
            this.Username_TXT.TabIndex = 1;
            // 
            // Password_TXT
            // 
            this.Password_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TXT.Location = new System.Drawing.Point(364, 361);
            this.Password_TXT.Name = "Password_TXT";
            this.Password_TXT.PasswordChar = '*';
            this.Password_TXT.Size = new System.Drawing.Size(257, 29);
            this.Password_TXT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label1.Location = new System.Drawing.Point(272, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label2.Location = new System.Drawing.Point(272, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(929, 288);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Version_LBL);
            this.panel1.Location = new System.Drawing.Point(-7, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 162);
            this.panel1.TabIndex = 7;
            // 
            // Version_LBL
            // 
            this.Version_LBL.AutoSize = true;
            this.Version_LBL.BackColor = System.Drawing.Color.Transparent;
            this.Version_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Version_LBL.Location = new System.Drawing.Point(389, 133);
            this.Version_LBL.Name = "Version_LBL";
            this.Version_LBL.Size = new System.Drawing.Size(149, 17);
            this.Version_LBL.TabIndex = 1;
            this.Version_LBL.Text = "Mu Tellesy Software ©";
            // 
            // Login
            // 
            this.AcceptButton = this.Login_BTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_TXT);
            this.Controls.Add(this.Username_TXT);
            this.Controls.Add(this.Login_BTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Cards Tracking System (CTS)";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_BTN;
        private System.Windows.Forms.TextBox Username_TXT;
        private System.Windows.Forms.TextBox Password_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Version_LBL;
    }
}