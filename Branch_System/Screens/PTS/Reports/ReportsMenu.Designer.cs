namespace MPBS.Screens.PTS.Reports
{
    partial class ReportsMenu
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
            this.FromDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.ToDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // FromDate_DTP
            // 
            this.FromDate_DTP.Location = new System.Drawing.Point(40, 126);
            this.FromDate_DTP.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.FromDate_DTP.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.FromDate_DTP.Name = "FromDate_DTP";
            this.FromDate_DTP.Size = new System.Drawing.Size(200, 20);
            this.FromDate_DTP.TabIndex = 0;
            // 
            // ToDate_DTP
            // 
            this.ToDate_DTP.Location = new System.Drawing.Point(310, 126);
            this.ToDate_DTP.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.ToDate_DTP.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.ToDate_DTP.Name = "ToDate_DTP";
            this.ToDate_DTP.Size = new System.Drawing.Size(200, 20);
            this.ToDate_DTP.TabIndex = 1;
            // 
            // ReportsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 388);
            this.Controls.Add(this.ToDate_DTP);
            this.Controls.Add(this.FromDate_DTP);
            this.Name = "ReportsMenu";
            this.Text = "ReportsMenu";
            this.Load += new System.EventHandler(this.ReportsMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FromDate_DTP;
        private System.Windows.Forms.DateTimePicker ToDate_DTP;
    }
}