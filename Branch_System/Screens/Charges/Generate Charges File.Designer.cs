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
            this.GenerateCardIssuingChargesFile_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.GenerateLoadFile_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoadAndIssueFile_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // Back_BTN
            // 
            this.Back_BTN.AutoSize = true;
            this.Back_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back_BTN.Depth = 0;
            this.Back_BTN.Location = new System.Drawing.Point(13, 327);
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
            // GenerateCardIssuingChargesFile_BTN
            // 
            this.GenerateCardIssuingChargesFile_BTN.AutoSize = true;
            this.GenerateCardIssuingChargesFile_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerateCardIssuingChargesFile_BTN.Depth = 0;
            this.GenerateCardIssuingChargesFile_BTN.Location = new System.Drawing.Point(13, 108);
            this.GenerateCardIssuingChargesFile_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenerateCardIssuingChargesFile_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenerateCardIssuingChargesFile_BTN.Name = "GenerateCardIssuingChargesFile_BTN";
            this.GenerateCardIssuingChargesFile_BTN.Primary = false;
            this.GenerateCardIssuingChargesFile_BTN.Size = new System.Drawing.Size(271, 36);
            this.GenerateCardIssuingChargesFile_BTN.TabIndex = 8;
            this.GenerateCardIssuingChargesFile_BTN.Text = "Generate Card Issuing Charges File";
            this.GenerateCardIssuingChargesFile_BTN.UseVisualStyleBackColor = true;
            this.GenerateCardIssuingChargesFile_BTN.Click += new System.EventHandler(this.GenerateCardIssuingChargesFile_BTN_Click);
            // 
            // GenerateLoadFile_BTN
            // 
            this.GenerateLoadFile_BTN.AutoSize = true;
            this.GenerateLoadFile_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerateLoadFile_BTN.Depth = 0;
            this.GenerateLoadFile_BTN.Location = new System.Drawing.Point(13, 166);
            this.GenerateLoadFile_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenerateLoadFile_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenerateLoadFile_BTN.Name = "GenerateLoadFile_BTN";
            this.GenerateLoadFile_BTN.Primary = false;
            this.GenerateLoadFile_BTN.Size = new System.Drawing.Size(149, 36);
            this.GenerateLoadFile_BTN.TabIndex = 9;
            this.GenerateLoadFile_BTN.Text = "Generate Load File";
            this.GenerateLoadFile_BTN.UseVisualStyleBackColor = true;
            this.GenerateLoadFile_BTN.Click += new System.EventHandler(this.GenerateLoadFile_BTN_Click);
            // 
            // LoadAndIssueFile_BTN
            // 
            this.LoadAndIssueFile_BTN.AutoSize = true;
            this.LoadAndIssueFile_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadAndIssueFile_BTN.Depth = 0;
            this.LoadAndIssueFile_BTN.Location = new System.Drawing.Point(13, 239);
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
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.LoadAndIssueFile_BTN);
            this.Controls.Add(this.GenerateLoadFile_BTN);
            this.Controls.Add(this.GenerateCardIssuingChargesFile_BTN);
            this.Controls.Add(this.Back_BTN);
            this.Name = "GenerateChargesFiles";
            this.Text = "Generate_Charges_File";
            this.Load += new System.EventHandler(this.Generate_Charges_File_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Back_BTN;
        private MaterialSkin.Controls.MaterialFlatButton GenerateCardIssuingChargesFile_BTN;
        private MaterialSkin.Controls.MaterialFlatButton GenerateLoadFile_BTN;
        private MaterialSkin.Controls.MaterialFlatButton LoadAndIssueFile_BTN;
    }
}