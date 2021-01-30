namespace MPBS.Screens.PTS.Perso
{
    partial class UploadEMBPINtoDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadEMBPINtoDB));
            this.Upload_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowsePIN_TXT = new System.Windows.Forms.TextBox();
            this.BrowseEMB_TXT = new System.Windows.Forms.TextBox();
            this.BrowsePIN_BTN = new System.Windows.Forms.Button();
            this.BrowseEmb_BTN = new System.Windows.Forms.Button();
            this.Exit_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Upload_BTN
            // 
            this.Upload_BTN.AutoSize = true;
            this.Upload_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Upload_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Upload_BTN.BackgroundImage")));
            this.Upload_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Upload_BTN.Depth = 0;
            this.Upload_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Upload_BTN.Location = new System.Drawing.Point(296, 245);
            this.Upload_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Upload_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Upload_BTN.Name = "Upload_BTN";
            this.Upload_BTN.Primary = false;
            this.Upload_BTN.Size = new System.Drawing.Size(65, 36);
            this.Upload_BTN.TabIndex = 67;
            this.Upload_BTN.Text = "Upload";
            this.Upload_BTN.UseVisualStyleBackColor = true;
            this.Upload_BTN.Click += new System.EventHandler(this.Upload_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "PIN File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Embossing File";
            // 
            // BrowsePIN_TXT
            // 
            this.BrowsePIN_TXT.Location = new System.Drawing.Point(93, 177);
            this.BrowsePIN_TXT.Name = "BrowsePIN_TXT";
            this.BrowsePIN_TXT.Size = new System.Drawing.Size(268, 20);
            this.BrowsePIN_TXT.TabIndex = 64;
            // 
            // BrowseEMB_TXT
            // 
            this.BrowseEMB_TXT.Location = new System.Drawing.Point(93, 100);
            this.BrowseEMB_TXT.Name = "BrowseEMB_TXT";
            this.BrowseEMB_TXT.Size = new System.Drawing.Size(268, 20);
            this.BrowseEMB_TXT.TabIndex = 63;
            // 
            // BrowsePIN_BTN
            // 
            this.BrowsePIN_BTN.Location = new System.Drawing.Point(12, 174);
            this.BrowsePIN_BTN.Name = "BrowsePIN_BTN";
            this.BrowsePIN_BTN.Size = new System.Drawing.Size(75, 23);
            this.BrowsePIN_BTN.TabIndex = 62;
            this.BrowsePIN_BTN.Text = "Browse";
            this.BrowsePIN_BTN.UseVisualStyleBackColor = true;
            this.BrowsePIN_BTN.Click += new System.EventHandler(this.BrowsePIN_BTN_Click);
            // 
            // BrowseEmb_BTN
            // 
            this.BrowseEmb_BTN.Location = new System.Drawing.Point(12, 100);
            this.BrowseEmb_BTN.Name = "BrowseEmb_BTN";
            this.BrowseEmb_BTN.Size = new System.Drawing.Size(75, 23);
            this.BrowseEmb_BTN.TabIndex = 61;
            this.BrowseEmb_BTN.Text = "Browse";
            this.BrowseEmb_BTN.UseVisualStyleBackColor = true;
            this.BrowseEmb_BTN.Click += new System.EventHandler(this.BrowseEmb_BTN_Click);
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.AutoSize = true;
            this.Exit_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_BTN.BackgroundImage")));
            this.Exit_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_BTN.Depth = 0;
            this.Exit_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_BTN.Location = new System.Drawing.Point(8, 308);
            this.Exit_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Exit_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Primary = false;
            this.Exit_BTN.Size = new System.Drawing.Size(47, 36);
            this.Exit_BTN.TabIndex = 60;
            this.Exit_BTN.Text = "Back";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 213);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(349, 23);
            this.progressBar.TabIndex = 68;
            // 
            // UploadEMBPINtoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Upload_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowsePIN_TXT);
            this.Controls.Add(this.BrowseEMB_TXT);
            this.Controls.Add(this.BrowsePIN_BTN);
            this.Controls.Add(this.BrowseEmb_BTN);
            this.Controls.Add(this.Exit_BTN);
            this.Name = "UploadEMBPINtoDB";
            this.Text = "UploadEMBPINtoDB";
            this.Load += new System.EventHandler(this.UploadEMBPINtoDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Upload_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BrowsePIN_TXT;
        private System.Windows.Forms.TextBox BrowseEMB_TXT;
        private System.Windows.Forms.Button BrowsePIN_BTN;
        private System.Windows.Forms.Button BrowseEmb_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Exit_BTN;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}