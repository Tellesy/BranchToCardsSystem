namespace MPBS.Screens.Main
{
    partial class PersoPinMaster
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
            this.SortEMBPINFiles_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Logout_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.generateEMBandPINFiles_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.UploadEMPAndPinFilesTODB_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // Password_BTN
            // 
            this.Password_BTN.AutoSize = true;
            this.Password_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Password_BTN.Depth = 0;
            this.Password_BTN.Location = new System.Drawing.Point(193, 116);
            this.Password_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Password_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password_BTN.Name = "Password_BTN";
            this.Password_BTN.Primary = false;
            this.Password_BTN.Size = new System.Drawing.Size(144, 36);
            this.Password_BTN.TabIndex = 56;
            this.Password_BTN.Text = "Change Password";
            this.Password_BTN.UseVisualStyleBackColor = true;
            // 
            // Welcome_LBL
            // 
            this.Welcome_LBL.AutoSize = true;
            this.Welcome_LBL.Depth = 0;
            this.Welcome_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Welcome_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Welcome_LBL.Location = new System.Drawing.Point(18, 84);
            this.Welcome_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Welcome_LBL.Name = "Welcome_LBL";
            this.Welcome_LBL.Size = new System.Drawing.Size(76, 19);
            this.Welcome_LBL.TabIndex = 55;
            this.Welcome_LBL.Text = "Welcome:";
            // 
            // Name_LBL
            // 
            this.Name_LBL.AutoSize = true;
            this.Name_LBL.Depth = 0;
            this.Name_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Name_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name_LBL.Location = new System.Drawing.Point(129, 84);
            this.Name_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Name_LBL.Name = "Name_LBL";
            this.Name_LBL.Size = new System.Drawing.Size(18, 19);
            this.Name_LBL.TabIndex = 54;
            this.Name_LBL.Text = "X";
            // 
            // SortEMBPINFiles_BTN
            // 
            this.SortEMBPINFiles_BTN.AutoSize = true;
            this.SortEMBPINFiles_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SortEMBPINFiles_BTN.Depth = 0;
            this.SortEMBPINFiles_BTN.Location = new System.Drawing.Point(13, 263);
            this.SortEMBPINFiles_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SortEMBPINFiles_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.SortEMBPINFiles_BTN.Name = "SortEMBPINFiles_BTN";
            this.SortEMBPINFiles_BTN.Primary = false;
            this.SortEMBPINFiles_BTN.Size = new System.Drawing.Size(324, 36);
            this.SortEMBPINFiles_BTN.TabIndex = 60;
            this.SortEMBPINFiles_BTN.Text = "Upload and Generate PTS Emb and PIN Files";
            this.SortEMBPINFiles_BTN.UseVisualStyleBackColor = true;
            this.SortEMBPINFiles_BTN.Click += new System.EventHandler(this.GenerateEMBPIN_BTN_Click);
            // 
            // Logout_BTN
            // 
            this.Logout_BTN.AutoSize = true;
            this.Logout_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logout_BTN.Depth = 0;
            this.Logout_BTN.Location = new System.Drawing.Point(13, 473);
            this.Logout_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Logout_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Logout_BTN.Name = "Logout_BTN";
            this.Logout_BTN.Primary = false;
            this.Logout_BTN.Size = new System.Drawing.Size(65, 36);
            this.Logout_BTN.TabIndex = 61;
            this.Logout_BTN.Text = "Logout";
            this.Logout_BTN.UseVisualStyleBackColor = true;
            this.Logout_BTN.Click += new System.EventHandler(this.Logout_BTN_Click);
            // 
            // generateEMBandPINFiles_BTN
            // 
            this.generateEMBandPINFiles_BTN.AutoSize = true;
            this.generateEMBandPINFiles_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generateEMBandPINFiles_BTN.Depth = 0;
            this.generateEMBandPINFiles_BTN.Location = new System.Drawing.Point(13, 359);
            this.generateEMBandPINFiles_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generateEMBandPINFiles_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.generateEMBandPINFiles_BTN.Name = "generateEMBandPINFiles_BTN";
            this.generateEMBandPINFiles_BTN.Primary = false;
            this.generateEMBandPINFiles_BTN.Size = new System.Drawing.Size(208, 36);
            this.generateEMBandPINFiles_BTN.TabIndex = 63;
            this.generateEMBandPINFiles_BTN.Text = "Generate EMP and PIN Files";
            this.generateEMBandPINFiles_BTN.UseVisualStyleBackColor = true;
            // 
            // UploadEMPAndPinFilesTODB_BTN
            // 
            this.UploadEMPAndPinFilesTODB_BTN.AutoSize = true;
            this.UploadEMPAndPinFilesTODB_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UploadEMPAndPinFilesTODB_BTN.Depth = 0;
            this.UploadEMPAndPinFilesTODB_BTN.Location = new System.Drawing.Point(13, 311);
            this.UploadEMPAndPinFilesTODB_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UploadEMPAndPinFilesTODB_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.UploadEMPAndPinFilesTODB_BTN.Name = "UploadEMPAndPinFilesTODB_BTN";
            this.UploadEMPAndPinFilesTODB_BTN.Primary = false;
            this.UploadEMPAndPinFilesTODB_BTN.Size = new System.Drawing.Size(226, 36);
            this.UploadEMPAndPinFilesTODB_BTN.TabIndex = 64;
            this.UploadEMPAndPinFilesTODB_BTN.Text = "Upload EMP and PIN File To DB";
            this.UploadEMPAndPinFilesTODB_BTN.UseVisualStyleBackColor = true;
            this.UploadEMPAndPinFilesTODB_BTN.Click += new System.EventHandler(this.UploadEMPAndPinFilesTODB_BTN_Click);
            // 
            // PersoPinMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 526);
            this.Controls.Add(this.UploadEMPAndPinFilesTODB_BTN);
            this.Controls.Add(this.generateEMBandPINFiles_BTN);
            this.Controls.Add(this.Logout_BTN);
            this.Controls.Add(this.SortEMBPINFiles_BTN);
            this.Controls.Add(this.Password_BTN);
            this.Controls.Add(this.Welcome_LBL);
            this.Controls.Add(this.Name_LBL);
            this.Name = "PersoPinMaster";
            this.Text = "Perso Office";
            this.Load += new System.EventHandler(this.PersoPinMaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton Password_BTN;
        private MaterialSkin.Controls.MaterialLabel Welcome_LBL;
        private MaterialSkin.Controls.MaterialLabel Name_LBL;
        private MaterialSkin.Controls.MaterialFlatButton SortEMBPINFiles_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Logout_BTN;
        private MaterialSkin.Controls.MaterialFlatButton generateEMBandPINFiles_BTN;
        private MaterialSkin.Controls.MaterialFlatButton UploadEMPAndPinFilesTODB_BTN;
    }
}