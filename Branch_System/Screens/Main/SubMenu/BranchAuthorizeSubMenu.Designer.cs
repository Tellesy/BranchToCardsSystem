namespace MPBS.Screens.Main.SubMenu
{
    partial class BranchAuthorizeSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchAuthorizeSubMenu));
            this.PTSLoadAuth_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.PTSIssueAuth_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Back_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // PTSLoadAuth_BTN
            // 
            this.PTSLoadAuth_BTN.AutoSize = true;
            this.PTSLoadAuth_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PTSLoadAuth_BTN.Depth = 0;
            this.PTSLoadAuth_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTSLoadAuth_BTN.Image = ((System.Drawing.Image)(resources.GetObject("PTSLoadAuth_BTN.Image")));
            this.PTSLoadAuth_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PTSLoadAuth_BTN.Location = new System.Drawing.Point(13, 132);
            this.PTSLoadAuth_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PTSLoadAuth_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.PTSLoadAuth_BTN.Name = "PTSLoadAuth_BTN";
            this.PTSLoadAuth_BTN.Primary = false;
            this.PTSLoadAuth_BTN.Size = new System.Drawing.Size(226, 36);
            this.PTSLoadAuth_BTN.TabIndex = 42;
            this.PTSLoadAuth_BTN.Text = "Authorize Load Request (PTS)";
            this.PTSLoadAuth_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PTSLoadAuth_BTN.UseVisualStyleBackColor = true;
            this.PTSLoadAuth_BTN.Click += new System.EventHandler(this.PTSLoadAuth_BTN_Click);
            // 
            // PTSIssueAuth_BTN
            // 
            this.PTSIssueAuth_BTN.AutoSize = true;
            this.PTSIssueAuth_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PTSIssueAuth_BTN.Depth = 0;
            this.PTSIssueAuth_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTSIssueAuth_BTN.Image = ((System.Drawing.Image)(resources.GetObject("PTSIssueAuth_BTN.Image")));
            this.PTSIssueAuth_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PTSIssueAuth_BTN.Location = new System.Drawing.Point(13, 84);
            this.PTSIssueAuth_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PTSIssueAuth_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.PTSIssueAuth_BTN.Name = "PTSIssueAuth_BTN";
            this.PTSIssueAuth_BTN.Primary = false;
            this.PTSIssueAuth_BTN.Size = new System.Drawing.Size(228, 36);
            this.PTSIssueAuth_BTN.TabIndex = 41;
            this.PTSIssueAuth_BTN.Text = "Authorize Issue Request (PTS)";
            this.PTSIssueAuth_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PTSIssueAuth_BTN.UseVisualStyleBackColor = true;
            this.PTSIssueAuth_BTN.Click += new System.EventHandler(this.PTSIssueAuth_BTN_Click);
            // 
            // Back_BTN
            // 
            this.Back_BTN.AutoSize = true;
            this.Back_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back_BTN.Depth = 0;
            this.Back_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Back_BTN.Image")));
            this.Back_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back_BTN.Location = new System.Drawing.Point(13, 226);
            this.Back_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Back_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Primary = false;
            this.Back_BTN.Size = new System.Drawing.Size(47, 36);
            this.Back_BTN.TabIndex = 43;
            this.Back_BTN.Text = "Back";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // BranchAuthorizeSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 270);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.PTSLoadAuth_BTN);
            this.Controls.Add(this.PTSIssueAuth_BTN);
            this.Name = "BranchAuthorizeSubMenu";
            this.Text = "BranchAuthorizeSubMenu";
            this.Load += new System.EventHandler(this.BranchAuthorizeSubMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton PTSLoadAuth_BTN;
        private MaterialSkin.Controls.MaterialFlatButton PTSIssueAuth_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Back_BTN;
    }
}