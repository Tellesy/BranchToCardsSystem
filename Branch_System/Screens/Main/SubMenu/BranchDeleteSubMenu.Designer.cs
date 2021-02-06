namespace MPBS.Screens.Main.SubMenu
{
    partial class BranchDeleteSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchDeleteSubMenu));
            this.Back_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.PTSLoadAuth_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.PTSIssueDelete_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // Back_BTN
            // 
            this.Back_BTN.AutoSize = true;
            this.Back_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back_BTN.Depth = 0;
            this.Back_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Back_BTN.Image")));
            this.Back_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back_BTN.Location = new System.Drawing.Point(13, 194);
            this.Back_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Back_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Primary = false;
            this.Back_BTN.Size = new System.Drawing.Size(47, 36);
            this.Back_BTN.TabIndex = 46;
            this.Back_BTN.Text = "Back";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // PTSLoadAuth_BTN
            // 
            this.PTSLoadAuth_BTN.AutoSize = true;
            this.PTSLoadAuth_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PTSLoadAuth_BTN.Depth = 0;
            this.PTSLoadAuth_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTSLoadAuth_BTN.Image = ((System.Drawing.Image)(resources.GetObject("PTSLoadAuth_BTN.Image")));
            this.PTSLoadAuth_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PTSLoadAuth_BTN.Location = new System.Drawing.Point(13, 124);
            this.PTSLoadAuth_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PTSLoadAuth_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.PTSLoadAuth_BTN.Name = "PTSLoadAuth_BTN";
            this.PTSLoadAuth_BTN.Primary = false;
            this.PTSLoadAuth_BTN.Size = new System.Drawing.Size(199, 36);
            this.PTSLoadAuth_BTN.TabIndex = 45;
            this.PTSLoadAuth_BTN.Text = "Delete Load Request (PTS)";
            this.PTSLoadAuth_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PTSLoadAuth_BTN.UseVisualStyleBackColor = true;
            // 
            // PTSIssueDelete_BTN
            // 
            this.PTSIssueDelete_BTN.AutoSize = true;
            this.PTSIssueDelete_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PTSIssueDelete_BTN.Depth = 0;
            this.PTSIssueDelete_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTSIssueDelete_BTN.Image = ((System.Drawing.Image)(resources.GetObject("PTSIssueDelete_BTN.Image")));
            this.PTSIssueDelete_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PTSIssueDelete_BTN.Location = new System.Drawing.Point(13, 76);
            this.PTSIssueDelete_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PTSIssueDelete_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.PTSIssueDelete_BTN.Name = "PTSIssueDelete_BTN";
            this.PTSIssueDelete_BTN.Primary = false;
            this.PTSIssueDelete_BTN.Size = new System.Drawing.Size(195, 36);
            this.PTSIssueDelete_BTN.TabIndex = 44;
            this.PTSIssueDelete_BTN.Text = "Delete Issue Record (PTS)";
            this.PTSIssueDelete_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PTSIssueDelete_BTN.UseVisualStyleBackColor = true;
            this.PTSIssueDelete_BTN.Click += new System.EventHandler(this.PTSIssueDelete_BTN_Click);
            // 
            // BranchDeleteSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 240);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.PTSLoadAuth_BTN);
            this.Controls.Add(this.PTSIssueDelete_BTN);
            this.Name = "BranchDeleteSubMenu";
            this.Text = "BranchDeleteSubMenu";
            this.Load += new System.EventHandler(this.BranchDeleteSubMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Back_BTN;
        private MaterialSkin.Controls.MaterialFlatButton PTSLoadAuth_BTN;
        private MaterialSkin.Controls.MaterialFlatButton PTSIssueDelete_BTN;
    }
}