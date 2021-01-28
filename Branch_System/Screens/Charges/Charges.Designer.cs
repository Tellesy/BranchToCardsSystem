namespace MPBS.Screens.Charges
{
    partial class GenerateChargesFiles
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
            this.Back_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoadAndIssueFile_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // Back_BTN
            // 
            this.Back_BTN.AutoSize = true;
            this.Back_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back_BTN.Depth = 0;
            this.Back_BTN.Location = new System.Drawing.Point(13, 130);
            this.Back_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Back_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Primary = false;
            this.Back_BTN.Size = new System.Drawing.Size(47, 36);
            this.Back_BTN.TabIndex = 7;
            this.Back_BTN.Text = "Back";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // LoadAndIssueFile_BTN
            // 
            this.LoadAndIssueFile_BTN.AutoSize = true;
            this.LoadAndIssueFile_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadAndIssueFile_BTN.Depth = 0;
            this.LoadAndIssueFile_BTN.Location = new System.Drawing.Point(13, 82);
            this.LoadAndIssueFile_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadAndIssueFile_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadAndIssueFile_BTN.Name = "LoadAndIssueFile_BTN";
            this.LoadAndIssueFile_BTN.Primary = false;
            this.LoadAndIssueFile_BTN.Size = new System.Drawing.Size(340, 36);
            this.LoadAndIssueFile_BTN.TabIndex = 10;
            this.LoadAndIssueFile_BTN.Text = "Generate Load and Card Issuing Charges File";
            this.LoadAndIssueFile_BTN.UseVisualStyleBackColor = true;
            this.LoadAndIssueFile_BTN.Click += new System.EventHandler(this.LoadAndIssueFile_BTN_Click);
            // 
            // GenerateChargesFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 182);
            this.Controls.Add(this.LoadAndIssueFile_BTN);
            this.Controls.Add(this.Back_BTN);
            this.Name = "GenerateChargesFiles";
            this.Text = "Generate CBS Load and Charges File";
            this.Load += new System.EventHandler(this.Generate_Charges_File_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Back_BTN;
        private MaterialSkin.Controls.MaterialFlatButton LoadAndIssueFile_BTN;
    }
}