namespace MPBS.Screens
{
    partial class BranchAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchAdmin));
            this.Recharge_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Reports_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Logout_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Card_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.ShareFolder_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.AccountDetails_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.PTSIssueAuth_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.PTSLoadAuth_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Welcome_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.Name_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Amount_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.Year = new MaterialSkin.Controls.MaterialLabel();
            this.Year_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.Status_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Password_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Branch_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Recharge_BTN
            // 
            this.Recharge_BTN.AutoSize = true;
            this.Recharge_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Recharge_BTN.Depth = 0;
            this.Recharge_BTN.Enabled = false;
            this.Recharge_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Recharge_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Recharge_BTN.Image")));
            this.Recharge_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Recharge_BTN.Location = new System.Drawing.Point(13, 311);
            this.Recharge_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Recharge_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Recharge_BTN.Name = "Recharge_BTN";
            this.Recharge_BTN.Primary = false;
            this.Recharge_BTN.Size = new System.Drawing.Size(229, 36);
            this.Recharge_BTN.TabIndex = 25;
            this.Recharge_BTN.Text = "Authorize Load Request (SMT)";
            this.Recharge_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Recharge_BTN.UseVisualStyleBackColor = true;
            this.Recharge_BTN.Click += new System.EventHandler(this.Recharge_BTN_Click);
            // 
            // Reports_BTN
            // 
            this.Reports_BTN.AutoSize = true;
            this.Reports_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Reports_BTN.Depth = 0;
            this.Reports_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Reports_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Reports_BTN.Image")));
            this.Reports_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reports_BTN.Location = new System.Drawing.Point(13, 485);
            this.Reports_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Reports_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Reports_BTN.Name = "Reports_BTN";
            this.Reports_BTN.Primary = false;
            this.Reports_BTN.Size = new System.Drawing.Size(102, 36);
            this.Reports_BTN.TabIndex = 26;
            this.Reports_BTN.Text = "Load Report";
            this.Reports_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Reports_BTN.UseVisualStyleBackColor = true;
            this.Reports_BTN.Click += new System.EventHandler(this.Reports_BTN_Click);
            // 
            // Logout_BTN
            // 
            this.Logout_BTN.AutoSize = true;
            this.Logout_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logout_BTN.Depth = 0;
            this.Logout_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Logout_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Logout_BTN.Image")));
            this.Logout_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_BTN.Location = new System.Drawing.Point(14, 563);
            this.Logout_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Logout_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Logout_BTN.Name = "Logout_BTN";
            this.Logout_BTN.Primary = false;
            this.Logout_BTN.Size = new System.Drawing.Size(65, 36);
            this.Logout_BTN.TabIndex = 27;
            this.Logout_BTN.Text = "Logout";
            this.Logout_BTN.UseVisualStyleBackColor = true;
            this.Logout_BTN.Click += new System.EventHandler(this.Logout_BTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(178, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Muiee\'s Software ©";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Depth = 0;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 343);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = false;
            this.button1.Size = new System.Drawing.Size(187, 36);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add Card Account (SMT)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Card_BTN
            // 
            this.Card_BTN.AutoSize = true;
            this.Card_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Card_BTN.Depth = 0;
            this.Card_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Card_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Card_BTN.Image")));
            this.Card_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Card_BTN.Location = new System.Drawing.Point(13, 280);
            this.Card_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Card_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Card_BTN.Name = "Card_BTN";
            this.Card_BTN.Primary = false;
            this.Card_BTN.Size = new System.Drawing.Size(239, 36);
            this.Card_BTN.TabIndex = 35;
            this.Card_BTN.Text = "Authorize Issue Request - (SMT) ";
            this.Card_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Card_BTN.UseVisualStyleBackColor = true;
            this.Card_BTN.Click += new System.EventHandler(this.Card_BTN_Click);
            // 
            // ShareFolder_BTN
            // 
            this.ShareFolder_BTN.AutoSize = true;
            this.ShareFolder_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShareFolder_BTN.Depth = 0;
            this.ShareFolder_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ShareFolder_BTN.Location = new System.Drawing.Point(13, 515);
            this.ShareFolder_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShareFolder_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShareFolder_BTN.Name = "ShareFolder_BTN";
            this.ShareFolder_BTN.Primary = false;
            this.ShareFolder_BTN.Size = new System.Drawing.Size(118, 36);
            this.ShareFolder_BTN.TabIndex = 37;
            this.ShareFolder_BTN.Text = "Shared Folder";
            this.ShareFolder_BTN.UseVisualStyleBackColor = true;
            this.ShareFolder_BTN.Click += new System.EventHandler(this.ShareFolder_BTN_Click);
            // 
            // AccountDetails_BTN
            // 
            this.AccountDetails_BTN.AutoSize = true;
            this.AccountDetails_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccountDetails_BTN.Depth = 0;
            this.AccountDetails_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.AccountDetails_BTN.Image = ((System.Drawing.Image)(resources.GetObject("AccountDetails_BTN.Image")));
            this.AccountDetails_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountDetails_BTN.Location = new System.Drawing.Point(13, 373);
            this.AccountDetails_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AccountDetails_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.AccountDetails_BTN.Name = "AccountDetails_BTN";
            this.AccountDetails_BTN.Primary = false;
            this.AccountDetails_BTN.Size = new System.Drawing.Size(184, 36);
            this.AccountDetails_BTN.TabIndex = 38;
            this.AccountDetails_BTN.Text = "Card Info Enquiry (SMT)";
            this.AccountDetails_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AccountDetails_BTN.UseVisualStyleBackColor = true;
            this.AccountDetails_BTN.Click += new System.EventHandler(this.AccountDetails_BTN_Click);
            // 
            // PTSIssueAuth_BTN
            // 
            this.PTSIssueAuth_BTN.AutoSize = true;
            this.PTSIssueAuth_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PTSIssueAuth_BTN.Depth = 0;
            this.PTSIssueAuth_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.PTSIssueAuth_BTN.Image = ((System.Drawing.Image)(resources.GetObject("PTSIssueAuth_BTN.Image")));
            this.PTSIssueAuth_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PTSIssueAuth_BTN.Location = new System.Drawing.Point(14, 410);
            this.PTSIssueAuth_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PTSIssueAuth_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.PTSIssueAuth_BTN.Name = "PTSIssueAuth_BTN";
            this.PTSIssueAuth_BTN.Primary = false;
            this.PTSIssueAuth_BTN.Size = new System.Drawing.Size(228, 36);
            this.PTSIssueAuth_BTN.TabIndex = 39;
            this.PTSIssueAuth_BTN.Text = "Authorize Issue Request (PTS)";
            this.PTSIssueAuth_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PTSIssueAuth_BTN.UseVisualStyleBackColor = true;
            this.PTSIssueAuth_BTN.Click += new System.EventHandler(this.PTSIssueAuthBTN_Click);
            // 
            // PTSLoadAuth_BTN
            // 
            this.PTSLoadAuth_BTN.AutoSize = true;
            this.PTSLoadAuth_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PTSLoadAuth_BTN.Depth = 0;
            this.PTSLoadAuth_BTN.Enabled = false;
            this.PTSLoadAuth_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.PTSLoadAuth_BTN.Image = ((System.Drawing.Image)(resources.GetObject("PTSLoadAuth_BTN.Image")));
            this.PTSLoadAuth_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PTSLoadAuth_BTN.Location = new System.Drawing.Point(13, 437);
            this.PTSLoadAuth_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PTSLoadAuth_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.PTSLoadAuth_BTN.Name = "PTSLoadAuth_BTN";
            this.PTSLoadAuth_BTN.Primary = false;
            this.PTSLoadAuth_BTN.Size = new System.Drawing.Size(226, 36);
            this.PTSLoadAuth_BTN.TabIndex = 40;
            this.PTSLoadAuth_BTN.Text = "Authorize Load Request (PTS)";
            this.PTSLoadAuth_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PTSLoadAuth_BTN.UseVisualStyleBackColor = true;
            // 
            // Welcome_LBL
            // 
            this.Welcome_LBL.AutoSize = true;
            this.Welcome_LBL.Depth = 0;
            this.Welcome_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Welcome_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Welcome_LBL.Location = new System.Drawing.Point(12, 81);
            this.Welcome_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Welcome_LBL.Name = "Welcome_LBL";
            this.Welcome_LBL.Size = new System.Drawing.Size(76, 19);
            this.Welcome_LBL.TabIndex = 51;
            this.Welcome_LBL.Text = "Welcome:";
            // 
            // Name_LBL
            // 
            this.Name_LBL.AutoSize = true;
            this.Name_LBL.Depth = 0;
            this.Name_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Name_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name_LBL.Location = new System.Drawing.Point(97, 81);
            this.Name_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Name_LBL.Name = "Name_LBL";
            this.Name_LBL.Size = new System.Drawing.Size(18, 19);
            this.Name_LBL.TabIndex = 50;
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
            this.panel1.Location = new System.Drawing.Point(11, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 132);
            this.panel1.TabIndex = 49;
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
            // Password_BTN
            // 
            this.Password_BTN.AutoSize = true;
            this.Password_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Password_BTN.Depth = 0;
            this.Password_BTN.Location = new System.Drawing.Point(373, 73);
            this.Password_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Password_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password_BTN.Name = "Password_BTN";
            this.Password_BTN.Primary = false;
            this.Password_BTN.Size = new System.Drawing.Size(144, 36);
            this.Password_BTN.TabIndex = 52;
            this.Password_BTN.Text = "Change Password";
            this.Password_BTN.UseVisualStyleBackColor = true;
            this.Password_BTN.Click += new System.EventHandler(this.Password_BTN_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 107);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 53;
            this.materialLabel3.Text = "Branch:";
            // 
            // Branch_LBL
            // 
            this.Branch_LBL.AutoSize = true;
            this.Branch_LBL.Depth = 0;
            this.Branch_LBL.Font = new System.Drawing.Font("Roboto", 11F);
            this.Branch_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Branch_LBL.Location = new System.Drawing.Point(97, 107);
            this.Branch_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Branch_LBL.Name = "Branch_LBL";
            this.Branch_LBL.Size = new System.Drawing.Size(18, 19);
            this.Branch_LBL.TabIndex = 54;
            this.Branch_LBL.Text = "X";
            // 
            // BranchAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 640);
            this.ControlBox = false;
            this.Controls.Add(this.Branch_LBL);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.Password_BTN);
            this.Controls.Add(this.Welcome_LBL);
            this.Controls.Add(this.Name_LBL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PTSLoadAuth_BTN);
            this.Controls.Add(this.PTSIssueAuth_BTN);
            this.Controls.Add(this.AccountDetails_BTN);
            this.Controls.Add(this.ShareFolder_BTN);
            this.Controls.Add(this.Card_BTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logout_BTN);
            this.Controls.Add(this.Recharge_BTN);
            this.Controls.Add(this.Reports_BTN);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BranchAdmin";
            this.ShowIcon = false;
            this.Text = "Branch Authorizer";
            this.Load += new System.EventHandler(this.BranchAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFlatButton PTSIssueAuth_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Recharge_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Reports_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Logout_BTN;
        private MaterialSkin.Controls.MaterialFlatButton button1;
        private MaterialSkin.Controls.MaterialFlatButton Card_BTN;
        private MaterialSkin.Controls.MaterialFlatButton ShareFolder_BTN;
        private MaterialSkin.Controls.MaterialFlatButton AccountDetails_BTN;
        private MaterialSkin.Controls.MaterialFlatButton PTSLoadAuth_BTN;
        private MaterialSkin.Controls.MaterialLabel Welcome_LBL;
        private MaterialSkin.Controls.MaterialLabel Name_LBL;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel Amount_LBL;
        private MaterialSkin.Controls.MaterialLabel Year;
        private MaterialSkin.Controls.MaterialLabel Year_LBL;
        private MaterialSkin.Controls.MaterialLabel Status_LBL;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton Password_BTN;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel Branch_LBL;
    }
}