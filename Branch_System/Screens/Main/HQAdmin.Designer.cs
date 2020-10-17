namespace CTS.Screens.Main
{
    partial class HQAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Name_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.Welcome_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.Password_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Status_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.Year_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.Year = new MaterialSkin.Controls.MaterialLabel();
            this.Amount_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.UpdateUser_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.AddUser_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.unAuthAppRecord_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.HQAuthAppRecord_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.GenFiles_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Logout_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.UnauthBrasnchLoad_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.AuthLoadRequests_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.Amount_LBL);
            this.panel1.Controls.Add(this.Year);
            this.panel1.Controls.Add(this.Year_LBL);
            this.panel1.Controls.Add(this.Status_LBL);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(12, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 132);
            this.panel1.TabIndex = 37;
            // 
            // Name_LBL
            // 
            this.Name_LBL.AutoSize = true;
            this.Name_LBL.Depth = 0;
            this.Name_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Name_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name_LBL.Location = new System.Drawing.Point(199, 83);
            this.Name_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Name_LBL.Name = "Name_LBL";
            this.Name_LBL.Size = new System.Drawing.Size(18, 19);
            this.Name_LBL.TabIndex = 47;
            this.Name_LBL.Text = "X";
            // 
            // Welcome_LBL
            // 
            this.Welcome_LBL.AutoSize = true;
            this.Welcome_LBL.Depth = 0;
            this.Welcome_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Welcome_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Welcome_LBL.Location = new System.Drawing.Point(88, 83);
            this.Welcome_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Welcome_LBL.Name = "Welcome_LBL";
            this.Welcome_LBL.Size = new System.Drawing.Size(76, 19);
            this.Welcome_LBL.TabIndex = 48;
            this.Welcome_LBL.Text = "Welcome:";
            // 
            // Password_BTN
            // 
            this.Password_BTN.AutoSize = true;
            this.Password_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Password_BTN.Depth = 0;
            this.Password_BTN.Location = new System.Drawing.Point(367, 75);
            this.Password_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Password_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password_BTN.Name = "Password_BTN";
            this.Password_BTN.Primary = false;
            this.Password_BTN.Size = new System.Drawing.Size(144, 36);
            this.Password_BTN.TabIndex = 49;
            this.Password_BTN.Text = "Change Password";
            this.Password_BTN.UseVisualStyleBackColor = true;
            this.Password_BTN.Click += new System.EventHandler(this.Password_BTN_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 50;
            this.materialLabel1.Text = "Status:";
            // 
            // Status_LBL
            // 
            this.Status_LBL.AutoSize = true;
            this.Status_LBL.Depth = 0;
            this.Status_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Status_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status_LBL.Location = new System.Drawing.Point(243, 22);
            this.Status_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Status_LBL.Name = "Status_LBL";
            this.Status_LBL.Size = new System.Drawing.Size(18, 18);
            this.Status_LBL.TabIndex = 50;
            this.Status_LBL.Text = "X";
            // 
            // Year_LBL
            // 
            this.Year_LBL.AutoSize = true;
            this.Year_LBL.Depth = 0;
            this.Year_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Year_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Year_LBL.Location = new System.Drawing.Point(243, 54);
            this.Year_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Year_LBL.Name = "Year_LBL";
            this.Year_LBL.Size = new System.Drawing.Size(18, 19);
            this.Year_LBL.TabIndex = 51;
            this.Year_LBL.Text = "X";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Depth = 0;
            this.Year.Font = new System.Drawing.Font("Roboto", 11F);
            this.Year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Year.Location = new System.Drawing.Point(10, 54);
            this.Year.MouseState = MaterialSkin.MouseState.HOVER;
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(43, 19);
            this.Year.TabIndex = 52;
            this.Year.Text = "Year:";
            // 
            // Amount_LBL
            // 
            this.Amount_LBL.AutoSize = true;
            this.Amount_LBL.Depth = 0;
            this.Amount_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Amount_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Amount_LBL.Location = new System.Drawing.Point(242, 90);
            this.Amount_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Amount_LBL.Name = "Amount_LBL";
            this.Amount_LBL.Size = new System.Drawing.Size(18, 19);
            this.Amount_LBL.TabIndex = 53;
            this.Amount_LBL.Text = "X";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 90);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(135, 19);
            this.materialLabel2.TabIndex = 54;
            this.materialLabel2.Text = "Max Load Amount:";
            // 
            // UpdateUser_BTN
            // 
            this.UpdateUser_BTN.AutoSize = true;
            this.UpdateUser_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateUser_BTN.Depth = 0;
            this.UpdateUser_BTN.Location = new System.Drawing.Point(367, 193);
            this.UpdateUser_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateUser_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateUser_BTN.Name = "UpdateUser_BTN";
            this.UpdateUser_BTN.Primary = false;
            this.UpdateUser_BTN.Size = new System.Drawing.Size(104, 36);
            this.UpdateUser_BTN.TabIndex = 50;
            this.UpdateUser_BTN.Text = "Update  User";
            this.UpdateUser_BTN.UseVisualStyleBackColor = true;
            this.UpdateUser_BTN.Click += new System.EventHandler(this.UpdateUser_BTN_Click);
            // 
            // AddUser_BTN
            // 
            this.AddUser_BTN.AutoSize = true;
            this.AddUser_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddUser_BTN.Depth = 0;
            this.AddUser_BTN.Location = new System.Drawing.Point(367, 153);
            this.AddUser_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddUser_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddUser_BTN.Name = "AddUser_BTN";
            this.AddUser_BTN.Primary = false;
            this.AddUser_BTN.Size = new System.Drawing.Size(109, 36);
            this.AddUser_BTN.TabIndex = 52;
            this.AddUser_BTN.Text = "Add New User";
            this.AddUser_BTN.UseVisualStyleBackColor = true;
            this.AddUser_BTN.Click += new System.EventHandler(this.AddUser_BTN_Click);
            // 
            // unAuthAppRecord_BTN
            // 
            this.unAuthAppRecord_BTN.AutoSize = true;
            this.unAuthAppRecord_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unAuthAppRecord_BTN.Depth = 0;
            this.unAuthAppRecord_BTN.Location = new System.Drawing.Point(12, 293);
            this.unAuthAppRecord_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.unAuthAppRecord_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.unAuthAppRecord_BTN.Name = "unAuthAppRecord_BTN";
            this.unAuthAppRecord_BTN.Primary = false;
            this.unAuthAppRecord_BTN.Size = new System.Drawing.Size(200, 36);
            this.unAuthAppRecord_BTN.TabIndex = 53;
            this.unAuthAppRecord_BTN.Text = "Unauthorized App Record";
            this.unAuthAppRecord_BTN.UseVisualStyleBackColor = true;
            this.unAuthAppRecord_BTN.Click += new System.EventHandler(this.unAuthAppRecord_BTN_Click);
            // 
            // HQAuthAppRecord_BTN
            // 
            this.HQAuthAppRecord_BTN.AutoSize = true;
            this.HQAuthAppRecord_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HQAuthAppRecord_BTN.Depth = 0;
            this.HQAuthAppRecord_BTN.Location = new System.Drawing.Point(13, 341);
            this.HQAuthAppRecord_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.HQAuthAppRecord_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.HQAuthAppRecord_BTN.Name = "HQAuthAppRecord_BTN";
            this.HQAuthAppRecord_BTN.Primary = false;
            this.HQAuthAppRecord_BTN.Size = new System.Drawing.Size(172, 36);
            this.HQAuthAppRecord_BTN.TabIndex = 54;
            this.HQAuthAppRecord_BTN.Text = "Authorize App Record";
            this.HQAuthAppRecord_BTN.UseVisualStyleBackColor = true;
            this.HQAuthAppRecord_BTN.Click += new System.EventHandler(this.HQAuthAppRecord_BTN_Click);
            // 
            // GenFiles_BTN
            // 
            this.GenFiles_BTN.AutoSize = true;
            this.GenFiles_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenFiles_BTN.Depth = 0;
            this.GenFiles_BTN.Location = new System.Drawing.Point(12, 507);
            this.GenFiles_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenFiles_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenFiles_BTN.Name = "GenFiles_BTN";
            this.GenFiles_BTN.Primary = false;
            this.GenFiles_BTN.Size = new System.Drawing.Size(119, 36);
            this.GenFiles_BTN.TabIndex = 55;
            this.GenFiles_BTN.Text = "Generate Files";
            this.GenFiles_BTN.UseVisualStyleBackColor = true;
            this.GenFiles_BTN.Click += new System.EventHandler(this.GenFiles_BTN_Click);
            // 
            // Logout_BTN
            // 
            this.Logout_BTN.AutoSize = true;
            this.Logout_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logout_BTN.Depth = 0;
            this.Logout_BTN.Location = new System.Drawing.Point(11, 555);
            this.Logout_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Logout_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Logout_BTN.Name = "Logout_BTN";
            this.Logout_BTN.Primary = false;
            this.Logout_BTN.Size = new System.Drawing.Size(65, 36);
            this.Logout_BTN.TabIndex = 56;
            this.Logout_BTN.Text = "Logout";
            this.Logout_BTN.UseVisualStyleBackColor = true;
            this.Logout_BTN.Click += new System.EventHandler(this.Logout_BTN_Click);
            // 
            // UnauthBrasnchLoad_BTN
            // 
            this.UnauthBrasnchLoad_BTN.AutoSize = true;
            this.UnauthBrasnchLoad_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnauthBrasnchLoad_BTN.Depth = 0;
            this.UnauthBrasnchLoad_BTN.Enabled = false;
            this.UnauthBrasnchLoad_BTN.Location = new System.Drawing.Point(13, 389);
            this.UnauthBrasnchLoad_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UnauthBrasnchLoad_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.UnauthBrasnchLoad_BTN.Name = "UnauthBrasnchLoad_BTN";
            this.UnauthBrasnchLoad_BTN.Primary = false;
            this.UnauthBrasnchLoad_BTN.Size = new System.Drawing.Size(210, 36);
            this.UnauthBrasnchLoad_BTN.TabIndex = 57;
            this.UnauthBrasnchLoad_BTN.Text = "Unauthorized Branch Load";
            this.UnauthBrasnchLoad_BTN.UseVisualStyleBackColor = true;
            // 
            // AuthLoadRequests_BTN
            // 
            this.AuthLoadRequests_BTN.AutoSize = true;
            this.AuthLoadRequests_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AuthLoadRequests_BTN.Depth = 0;
            this.AuthLoadRequests_BTN.Enabled = false;
            this.AuthLoadRequests_BTN.Location = new System.Drawing.Point(13, 437);
            this.AuthLoadRequests_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AuthLoadRequests_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.AuthLoadRequests_BTN.Name = "AuthLoadRequests_BTN";
            this.AuthLoadRequests_BTN.Primary = false;
            this.AuthLoadRequests_BTN.Size = new System.Drawing.Size(204, 36);
            this.AuthLoadRequests_BTN.TabIndex = 58;
            this.AuthLoadRequests_BTN.Text = "Authorized Load Requests";
            this.AuthLoadRequests_BTN.UseVisualStyleBackColor = true;
            // 
            // HQAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(517, 664);
            this.ControlBox = false;
            this.Controls.Add(this.AuthLoadRequests_BTN);
            this.Controls.Add(this.UnauthBrasnchLoad_BTN);
            this.Controls.Add(this.Logout_BTN);
            this.Controls.Add(this.GenFiles_BTN);
            this.Controls.Add(this.HQAuthAppRecord_BTN);
            this.Controls.Add(this.unAuthAppRecord_BTN);
            this.Controls.Add(this.AddUser_BTN);
            this.Controls.Add(this.UpdateUser_BTN);
            this.Controls.Add(this.Password_BTN);
            this.Controls.Add(this.Welcome_LBL);
            this.Controls.Add(this.Name_LBL);
            this.Controls.Add(this.panel1);
            this.Name = "HQAdmin";
            this.Text = "HQ Admin Page";
            this.Load += new System.EventHandler(this.HQAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel Name_LBL;
        private MaterialSkin.Controls.MaterialLabel Welcome_LBL;
        private MaterialSkin.Controls.MaterialFlatButton Password_BTN;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel Amount_LBL;
        private MaterialSkin.Controls.MaterialLabel Year;
        private MaterialSkin.Controls.MaterialLabel Year_LBL;
        private MaterialSkin.Controls.MaterialLabel Status_LBL;
        private MaterialSkin.Controls.MaterialFlatButton UpdateUser_BTN;
        private MaterialSkin.Controls.MaterialFlatButton AddUser_BTN;
        private MaterialSkin.Controls.MaterialFlatButton unAuthAppRecord_BTN;
        private MaterialSkin.Controls.MaterialFlatButton HQAuthAppRecord_BTN;
        private MaterialSkin.Controls.MaterialFlatButton GenFiles_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Logout_BTN;
        private MaterialSkin.Controls.MaterialFlatButton UnauthBrasnchLoad_BTN;
        private MaterialSkin.Controls.MaterialFlatButton AuthLoadRequests_BTN;
    }
}