namespace MPBS.Screens.UploadFile
{
    partial class UploadFile
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
            this.ApplicationApproveReport_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // ApplicationApproveReport_BTN
            // 
            this.ApplicationApproveReport_BTN.AutoSize = true;
            this.ApplicationApproveReport_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ApplicationApproveReport_BTN.Depth = 0;
            this.ApplicationApproveReport_BTN.Location = new System.Drawing.Point(13, 83);
            this.ApplicationApproveReport_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ApplicationApproveReport_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.ApplicationApproveReport_BTN.Name = "ApplicationApproveReport_BTN";
            this.ApplicationApproveReport_BTN.Primary = false;
            this.ApplicationApproveReport_BTN.Size = new System.Drawing.Size(275, 36);
            this.ApplicationApproveReport_BTN.TabIndex = 0;
            this.ApplicationApproveReport_BTN.Text = "Upload Application Approve Report";
            this.ApplicationApproveReport_BTN.UseVisualStyleBackColor = true;
            this.ApplicationApproveReport_BTN.Click += new System.EventHandler(this.ApplicationApproveReport_BTN_Click);
            // 
            // UploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(472, 282);
            this.ControlBox = false;
            this.Controls.Add(this.ApplicationApproveReport_BTN);
            this.Name = "UploadFile";
            this.ShowIcon = false;
            this.Text = "UploadFile";
            this.Load += new System.EventHandler(this.UploadFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton ApplicationApproveReport_BTN;
    }
}