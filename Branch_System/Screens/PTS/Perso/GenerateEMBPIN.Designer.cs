namespace MPBS.Screens.PTS.Perso
{
    partial class GenerateEMBPIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateEMBPIN));
            this.Exit_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.BrowseEmb_BTN = new System.Windows.Forms.Button();
            this.BrowsePIN_BTN = new System.Windows.Forms.Button();
            this.BrowseEMB_TXT = new System.Windows.Forms.TextBox();
            this.BrowsePIN_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Process_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
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
            this.Exit_BTN.Location = new System.Drawing.Point(13, 399);
            this.Exit_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Exit_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Primary = false;
            this.Exit_BTN.Size = new System.Drawing.Size(47, 36);
            this.Exit_BTN.TabIndex = 52;
            this.Exit_BTN.Text = "Back";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // BrowseEmb_BTN
            // 
            this.BrowseEmb_BTN.Location = new System.Drawing.Point(13, 124);
            this.BrowseEmb_BTN.Name = "BrowseEmb_BTN";
            this.BrowseEmb_BTN.Size = new System.Drawing.Size(75, 23);
            this.BrowseEmb_BTN.TabIndex = 53;
            this.BrowseEmb_BTN.Text = "Browse";
            this.BrowseEmb_BTN.UseVisualStyleBackColor = true;
            this.BrowseEmb_BTN.Click += new System.EventHandler(this.BrowseEmb_BTN_Click);
            // 
            // BrowsePIN_BTN
            // 
            this.BrowsePIN_BTN.Location = new System.Drawing.Point(13, 198);
            this.BrowsePIN_BTN.Name = "BrowsePIN_BTN";
            this.BrowsePIN_BTN.Size = new System.Drawing.Size(75, 23);
            this.BrowsePIN_BTN.TabIndex = 54;
            this.BrowsePIN_BTN.Text = "Browse";
            this.BrowsePIN_BTN.UseVisualStyleBackColor = true;
            this.BrowsePIN_BTN.Click += new System.EventHandler(this.BrowsePIN_BTN_Click);
            // 
            // BrowseEMB_TXT
            // 
            this.BrowseEMB_TXT.Location = new System.Drawing.Point(94, 124);
            this.BrowseEMB_TXT.Name = "BrowseEMB_TXT";
            this.BrowseEMB_TXT.Size = new System.Drawing.Size(268, 20);
            this.BrowseEMB_TXT.TabIndex = 55;
            // 
            // BrowsePIN_TXT
            // 
            this.BrowsePIN_TXT.Location = new System.Drawing.Point(94, 201);
            this.BrowsePIN_TXT.Name = "BrowsePIN_TXT";
            this.BrowsePIN_TXT.Size = new System.Drawing.Size(268, 20);
            this.BrowsePIN_TXT.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Embossing File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "PIN File";
            // 
            // Process_BTN
            // 
            this.Process_BTN.AutoSize = true;
            this.Process_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Process_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Process_BTN.BackgroundImage")));
            this.Process_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Process_BTN.Depth = 0;
            this.Process_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Process_BTN.Location = new System.Drawing.Point(287, 230);
            this.Process_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Process_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Process_BTN.Name = "Process_BTN";
            this.Process_BTN.Primary = false;
            this.Process_BTN.Size = new System.Drawing.Size(72, 36);
            this.Process_BTN.TabIndex = 59;
            this.Process_BTN.Text = "Process";
            this.Process_BTN.UseVisualStyleBackColor = true;
            this.Process_BTN.Click += new System.EventHandler(this.Process_BTN_Click);
            // 
            // GenerateEMBPIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.Process_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowsePIN_TXT);
            this.Controls.Add(this.BrowseEMB_TXT);
            this.Controls.Add(this.BrowsePIN_BTN);
            this.Controls.Add(this.BrowseEmb_BTN);
            this.Controls.Add(this.Exit_BTN);
            this.Name = "GenerateEMBPIN";
            this.Text = "Sort PIN File";
            this.Load += new System.EventHandler(this.GenerateEMBPIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Exit_BTN;
        private System.Windows.Forms.Button BrowseEmb_BTN;
        private System.Windows.Forms.Button BrowsePIN_BTN;
        private System.Windows.Forms.TextBox BrowseEMB_TXT;
        private System.Windows.Forms.TextBox BrowsePIN_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialFlatButton Process_BTN;
    }
}