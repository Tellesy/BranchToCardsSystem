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
            // Generate_Charges_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.GenerateCardIssuingChargesFile_BTN);
            this.Controls.Add(this.Back_BTN);
            this.Name = "Generate_Charges_File";
            this.Text = "Generate_Charges_File";
            this.Load += new System.EventHandler(this.Generate_Charges_File_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Back_BTN;
        private MaterialSkin.Controls.MaterialFlatButton GenerateCardIssuingChargesFile_BTN;
    }
}