namespace MPBS.Screens
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Version_LBL = new System.Windows.Forms.Label();
            this.Username_TXT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Password_TXT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DomainLogin_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.DataBaseType_CBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label1.Location = new System.Drawing.Point(12, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Login_BTN
            // 
            this.Login_BTN.AutoSize = true;
            this.Login_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login_BTN.Depth = 0;
            this.Login_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_BTN.Location = new System.Drawing.Point(287, 385);
            this.Login_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_BTN.Name = "Login_BTN";
            this.Login_BTN.Primary = false;
            this.Login_BTN.Size = new System.Drawing.Size(52, 36);
            this.Login_BTN.TabIndex = 11;
            this.Login_BTN.Text = "Login";
            this.Login_BTN.UseVisualStyleBackColor = false;
            this.Login_BTN.Click += new System.EventHandler(this.Login_BTN_Click);
            // 
            // Version_LBL
            // 
            this.Version_LBL.AutoSize = true;
            this.Version_LBL.BackColor = System.Drawing.Color.Transparent;
            this.Version_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Version_LBL.Location = new System.Drawing.Point(77, 449);
            this.Version_LBL.Name = "Version_LBL";
            this.Version_LBL.Size = new System.Drawing.Size(129, 17);
            this.Version_LBL.TabIndex = 1;
            this.Version_LBL.Text = "Muiee\'s Software ©";
            // 
            // Username_TXT
            // 
            this.Username_TXT.Depth = 0;
            this.Username_TXT.Hint = "";
            this.Username_TXT.Location = new System.Drawing.Point(127, 294);
            this.Username_TXT.MouseState = MaterialSkin.MouseState.HOVER;
            this.Username_TXT.Name = "Username_TXT";
            this.Username_TXT.PasswordChar = '\0';
            this.Username_TXT.SelectedText = "";
            this.Username_TXT.SelectionLength = 0;
            this.Username_TXT.SelectionStart = 0;
            this.Username_TXT.Size = new System.Drawing.Size(218, 23);
            this.Username_TXT.TabIndex = 9;
            this.Username_TXT.UseSystemPasswordChar = false;
            // 
            // Password_TXT
            // 
            this.Password_TXT.Depth = 0;
            this.Password_TXT.Hint = "";
            this.Password_TXT.Location = new System.Drawing.Point(127, 344);
            this.Password_TXT.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password_TXT.Name = "Password_TXT";
            this.Password_TXT.PasswordChar = '*';
            this.Password_TXT.SelectedText = "";
            this.Password_TXT.SelectionLength = 0;
            this.Password_TXT.SelectionStart = 0;
            this.Password_TXT.Size = new System.Drawing.Size(218, 23);
            this.Password_TXT.TabIndex = 10;
            this.Password_TXT.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // DomainLogin_BTN
            // 
            this.DomainLogin_BTN.AutoSize = true;
            this.DomainLogin_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DomainLogin_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DomainLogin_BTN.Depth = 0;
            this.DomainLogin_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DomainLogin_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DomainLogin_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DomainLogin_BTN.Location = new System.Drawing.Point(13, 385);
            this.DomainLogin_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DomainLogin_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.DomainLogin_BTN.Name = "DomainLogin_BTN";
            this.DomainLogin_BTN.Primary = false;
            this.DomainLogin_BTN.Size = new System.Drawing.Size(108, 36);
            this.DomainLogin_BTN.TabIndex = 12;
            this.DomainLogin_BTN.Text = "Domain Login";
            this.DomainLogin_BTN.UseVisualStyleBackColor = false;
            this.DomainLogin_BTN.Click += new System.EventHandler(this.DomainLogin_BTN_Click);
            // 
            // DataBaseType_CBox
            // 
            this.DataBaseType_CBox.FormattingEnabled = true;
            this.DataBaseType_CBox.Items.AddRange(new object[] {
            "Production",
            "UAT",
            "Dev (Not For Branch Users)"});
            this.DataBaseType_CBox.Location = new System.Drawing.Point(12, 93);
            this.DataBaseType_CBox.Name = "DataBaseType_CBox";
            this.DataBaseType_CBox.Size = new System.Drawing.Size(109, 21);
            this.DataBaseType_CBox.TabIndex = 13;
            this.DataBaseType_CBox.SelectedIndexChanged += new System.EventHandler(this.DataBaseType_CBox_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 481);
            this.Controls.Add(this.DataBaseType_CBox);
            this.Controls.Add(this.DomainLogin_BTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password_TXT);
            this.Controls.Add(this.Username_TXT);
            this.Controls.Add(this.Version_LBL);
            this.Controls.Add(this.Login_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Multi-Purpose Banking Solution  (MPBS)";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialFlatButton Login_BTN;
        private System.Windows.Forms.Label Version_LBL;
        private MaterialSkin.Controls.MaterialSingleLineTextField Username_TXT;
        private MaterialSkin.Controls.MaterialSingleLineTextField Password_TXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton DomainLogin_BTN;
        private System.Windows.Forms.ComboBox DataBaseType_CBox;
    }
}