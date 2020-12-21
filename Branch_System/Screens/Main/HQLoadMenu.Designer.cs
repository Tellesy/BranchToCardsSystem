namespace MPBS.Screens.Main
{
    partial class HQLoadMenu
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
            this.Password_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Welcome_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.Name_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Amount_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.Year = new MaterialSkin.Controls.MaterialLabel();
            this.Year_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.Status_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AuthLoadRequests_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.UnauthBrasnchLoad_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.GenLoadFiles_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.GenerateT24_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Logout_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Password_BTN
            // 
            this.Password_BTN.AutoSize = true;
            this.Password_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Password_BTN.Depth = 0;
            this.Password_BTN.Location = new System.Drawing.Point(365, 68);
            this.Password_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Password_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password_BTN.Name = "Password_BTN";
            this.Password_BTN.Primary = false;
            this.Password_BTN.Size = new System.Drawing.Size(144, 36);
            this.Password_BTN.TabIndex = 60;
            this.Password_BTN.Text = "Change Password";
            this.Password_BTN.UseVisualStyleBackColor = true;
            this.Password_BTN.Click += new System.EventHandler(this.Password_BTN_Click);
            // 
            // Welcome_LBL
            // 
            this.Welcome_LBL.AutoSize = true;
            this.Welcome_LBL.Depth = 0;
            this.Welcome_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Welcome_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Welcome_LBL.Location = new System.Drawing.Point(19, 76);
            this.Welcome_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Welcome_LBL.Name = "Welcome_LBL";
            this.Welcome_LBL.Size = new System.Drawing.Size(76, 19);
            this.Welcome_LBL.TabIndex = 59;
            this.Welcome_LBL.Text = "Welcome:";
            // 
            // Name_LBL
            // 
            this.Name_LBL.AutoSize = true;
            this.Name_LBL.Depth = 0;
            this.Name_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Name_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name_LBL.Location = new System.Drawing.Point(169, 76);
            this.Name_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Name_LBL.Name = "Name_LBL";
            this.Name_LBL.Size = new System.Drawing.Size(18, 19);
            this.Name_LBL.TabIndex = 58;
            this.Name_LBL.Text = "X";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.Amount_LBL);
            this.panel1.Controls.Add(this.Year);
            this.panel1.Controls.Add(this.Year_LBL);
            this.panel1.Controls.Add(this.Status_LBL);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(9, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 132);
            this.panel1.TabIndex = 57;
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
            // Status_LBL
            // 
            this.Status_LBL.AutoSize = true;
            this.Status_LBL.Depth = 0;
            this.Status_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Status_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status_LBL.Location = new System.Drawing.Point(243, 22);
            this.Status_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Status_LBL.Name = "Status_LBL";
            this.Status_LBL.Size = new System.Drawing.Size(18, 19);
            this.Status_LBL.TabIndex = 50;
            this.Status_LBL.Text = "X";
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
            // AuthLoadRequests_BTN
            // 
            this.AuthLoadRequests_BTN.AutoSize = true;
            this.AuthLoadRequests_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AuthLoadRequests_BTN.Depth = 0;
            this.AuthLoadRequests_BTN.Location = new System.Drawing.Point(9, 328);
            this.AuthLoadRequests_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AuthLoadRequests_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.AuthLoadRequests_BTN.Name = "AuthLoadRequests_BTN";
            this.AuthLoadRequests_BTN.Primary = false;
            this.AuthLoadRequests_BTN.Size = new System.Drawing.Size(204, 36);
            this.AuthLoadRequests_BTN.TabIndex = 62;
            this.AuthLoadRequests_BTN.Text = "Authorized Load Requests";
            this.AuthLoadRequests_BTN.UseVisualStyleBackColor = true;
            this.AuthLoadRequests_BTN.Click += new System.EventHandler(this.AuthLoadRequests_BTN_Click);
            // 
            // UnauthBrasnchLoad_BTN
            // 
            this.UnauthBrasnchLoad_BTN.AutoSize = true;
            this.UnauthBrasnchLoad_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnauthBrasnchLoad_BTN.Depth = 0;
            this.UnauthBrasnchLoad_BTN.Enabled = false;
            this.UnauthBrasnchLoad_BTN.Location = new System.Drawing.Point(9, 280);
            this.UnauthBrasnchLoad_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UnauthBrasnchLoad_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.UnauthBrasnchLoad_BTN.Name = "UnauthBrasnchLoad_BTN";
            this.UnauthBrasnchLoad_BTN.Primary = false;
            this.UnauthBrasnchLoad_BTN.Size = new System.Drawing.Size(210, 36);
            this.UnauthBrasnchLoad_BTN.TabIndex = 61;
            this.UnauthBrasnchLoad_BTN.Text = "Unauthorized Branch Load";
            this.UnauthBrasnchLoad_BTN.UseVisualStyleBackColor = true;
            this.UnauthBrasnchLoad_BTN.Click += new System.EventHandler(this.UnauthBrasnchLoad_BTN_Click);
            // 
            // GenLoadFiles_BTN
            // 
            this.GenLoadFiles_BTN.AutoSize = true;
            this.GenLoadFiles_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenLoadFiles_BTN.Depth = 0;
            this.GenLoadFiles_BTN.Location = new System.Drawing.Point(9, 424);
            this.GenLoadFiles_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenLoadFiles_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenLoadFiles_BTN.Name = "GenLoadFiles_BTN";
            this.GenLoadFiles_BTN.Primary = false;
            this.GenLoadFiles_BTN.Size = new System.Drawing.Size(196, 36);
            this.GenLoadFiles_BTN.TabIndex = 65;
            this.GenLoadFiles_BTN.Text = "Generate Load Files (PTS)";
            this.GenLoadFiles_BTN.UseVisualStyleBackColor = true;
            this.GenLoadFiles_BTN.Click += new System.EventHandler(this.GenLoadFiles_BTN_Click);
            // 
            // GenerateT24_BTN
            // 
            this.GenerateT24_BTN.AutoSize = true;
            this.GenerateT24_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerateT24_BTN.Depth = 0;
            this.GenerateT24_BTN.Location = new System.Drawing.Point(9, 376);
            this.GenerateT24_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenerateT24_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenerateT24_BTN.Name = "GenerateT24_BTN";
            this.GenerateT24_BTN.Primary = false;
            this.GenerateT24_BTN.Size = new System.Drawing.Size(234, 36);
            this.GenerateT24_BTN.TabIndex = 64;
            this.GenerateT24_BTN.Text = "Upload and Generate T24 Files";
            this.GenerateT24_BTN.UseVisualStyleBackColor = true;
            this.GenerateT24_BTN.Click += new System.EventHandler(this.GenerateT24_BTN_Click);
            // 
            // Logout_BTN
            // 
            this.Logout_BTN.AutoSize = true;
            this.Logout_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logout_BTN.Depth = 0;
            this.Logout_BTN.Location = new System.Drawing.Point(9, 581);
            this.Logout_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Logout_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Logout_BTN.Name = "Logout_BTN";
            this.Logout_BTN.Primary = false;
            this.Logout_BTN.Size = new System.Drawing.Size(65, 36);
            this.Logout_BTN.TabIndex = 63;
            this.Logout_BTN.Text = "Logout";
            this.Logout_BTN.UseVisualStyleBackColor = true;
            this.Logout_BTN.Click += new System.EventHandler(this.Logout_BTN_Click);
            // 
            // HQLoadMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(547, 632);
            this.Controls.Add(this.GenLoadFiles_BTN);
            this.Controls.Add(this.GenerateT24_BTN);
            this.Controls.Add(this.Logout_BTN);
            this.Controls.Add(this.AuthLoadRequests_BTN);
            this.Controls.Add(this.UnauthBrasnchLoad_BTN);
            this.Controls.Add(this.Password_BTN);
            this.Controls.Add(this.Welcome_LBL);
            this.Controls.Add(this.Name_LBL);
            this.Controls.Add(this.panel1);
            this.Name = "HQLoadMenu";
            this.Text = "HQLoadMenu";
            this.Load += new System.EventHandler(this.HQLoadMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Password_BTN;
        private MaterialSkin.Controls.MaterialLabel Welcome_LBL;
        private MaterialSkin.Controls.MaterialLabel Name_LBL;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel Amount_LBL;
        private MaterialSkin.Controls.MaterialLabel Year;
        private MaterialSkin.Controls.MaterialLabel Year_LBL;
        private MaterialSkin.Controls.MaterialLabel Status_LBL;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton AuthLoadRequests_BTN;
        private MaterialSkin.Controls.MaterialFlatButton UnauthBrasnchLoad_BTN;
        private MaterialSkin.Controls.MaterialFlatButton GenLoadFiles_BTN;
        private MaterialSkin.Controls.MaterialFlatButton GenerateT24_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Logout_BTN;
    }
}