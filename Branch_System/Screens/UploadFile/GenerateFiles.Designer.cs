namespace MPBS.Screens.UploadFile
{
    partial class GenerateT24Files
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
            this.UploadSMTTransactionReport_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Back_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.UploadPTSApplicationApproveReport_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // UploadSMTTransactionReport_BTN
            // 
            this.UploadSMTTransactionReport_BTN.AutoSize = true;
            this.UploadSMTTransactionReport_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UploadSMTTransactionReport_BTN.Depth = 0;
            this.UploadSMTTransactionReport_BTN.Location = new System.Drawing.Point(13, 74);
            this.UploadSMTTransactionReport_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UploadSMTTransactionReport_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.UploadSMTTransactionReport_BTN.Name = "UploadSMTTransactionReport_BTN";
            this.UploadSMTTransactionReport_BTN.Primary = false;
            this.UploadSMTTransactionReport_BTN.Size = new System.Drawing.Size(257, 36);
            this.UploadSMTTransactionReport_BTN.TabIndex = 0;
            this.UploadSMTTransactionReport_BTN.Text = "Upload SMT Transactions Report";
            this.UploadSMTTransactionReport_BTN.UseVisualStyleBackColor = true;
            this.UploadSMTTransactionReport_BTN.Click += new System.EventHandler(this.UploadSMTTransactionReport_BTN_Click);
            // 
            // Back_BTN
            // 
            this.Back_BTN.AutoSize = true;
            this.Back_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back_BTN.Depth = 0;
            this.Back_BTN.Location = new System.Drawing.Point(13, 231);
            this.Back_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Back_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Primary = false;
            this.Back_BTN.Size = new System.Drawing.Size(47, 36);
            this.Back_BTN.TabIndex = 1;
            this.Back_BTN.Text = "Back";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // UploadPTSApplicationApproveReport_BTN
            // 
            this.UploadPTSApplicationApproveReport_BTN.AutoSize = true;
            this.UploadPTSApplicationApproveReport_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UploadPTSApplicationApproveReport_BTN.Depth = 0;
            this.UploadPTSApplicationApproveReport_BTN.Location = new System.Drawing.Point(13, 122);
            this.UploadPTSApplicationApproveReport_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UploadPTSApplicationApproveReport_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.UploadPTSApplicationApproveReport_BTN.Name = "UploadPTSApplicationApproveReport_BTN";
            this.UploadPTSApplicationApproveReport_BTN.Primary = false;
            this.UploadPTSApplicationApproveReport_BTN.Size = new System.Drawing.Size(300, 36);
            this.UploadPTSApplicationApproveReport_BTN.TabIndex = 2;
            this.UploadPTSApplicationApproveReport_BTN.Text = "Upload PTS Applicaton Approve Report";
            this.UploadPTSApplicationApproveReport_BTN.UseVisualStyleBackColor = true;
            this.UploadPTSApplicationApproveReport_BTN.Click += new System.EventHandler(this.UploadPTSApplicationApproveReport_BTN_Click);
            // 
            // GenerateT24Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(352, 282);
            this.ControlBox = false;
            this.Controls.Add(this.UploadPTSApplicationApproveReport_BTN);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.UploadSMTTransactionReport_BTN);
            this.Name = "GenerateT24Files";
            this.ShowIcon = false;
            this.Text = "Generate T24 Files";
            this.Load += new System.EventHandler(this.UploadFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton UploadSMTTransactionReport_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Back_BTN;
        private MaterialSkin.Controls.MaterialFlatButton UploadPTSApplicationApproveReport_BTN;
    }
}