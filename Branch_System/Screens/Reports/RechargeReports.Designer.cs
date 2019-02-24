namespace CTS.Screens.Reports
{
    partial class RechargeReports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RechargeReport_LBL = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RechargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RechargeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RechargeReport_LBL
            // 
            reportDataSource1.Name = "Recharge_DT";
            reportDataSource1.Value = this.RechargeBindingSource;
            this.RechargeReport_LBL.LocalReport.DataSources.Add(reportDataSource1);
            this.RechargeReport_LBL.LocalReport.ReportEmbeddedResource = "CTS.Reports.RechargeReport.rdlc";
            this.RechargeReport_LBL.Location = new System.Drawing.Point(3, 129);
            this.RechargeReport_LBL.Name = "RechargeReport_LBL";
            this.RechargeReport_LBL.Size = new System.Drawing.Size(794, 409);
            this.RechargeReport_LBL.TabIndex = 0;
            this.RechargeReport_LBL.Load += new System.EventHandler(this.RechargeReport_LBL_Load);
            // 
            // RechargeBindingSource
            // 
            this.RechargeBindingSource.DataSource = typeof(CTS.Database.DataObjects.Recharge);
            // 
            // RechargeReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.RechargeReport_LBL);
            this.Name = "RechargeReports";
            this.Text = "RechargeReports";
            this.Load += new System.EventHandler(this.RechargeReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RechargeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RechargeReport_LBL;
        private System.Windows.Forms.BindingSource RechargeBindingSource;
    }
}