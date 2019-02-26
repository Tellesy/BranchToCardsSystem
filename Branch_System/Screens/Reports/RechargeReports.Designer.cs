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
            this.RechargeReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.RechargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RechargeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RechargeReport
            // 
            this.RechargeReport.LocalReport.ReportEmbeddedResource = "CTS.Screens.Reports.Report1.rdlc";
            this.RechargeReport.Location = new System.Drawing.Point(3, 123);
            this.RechargeReport.Name = "RechargeReport";
            this.RechargeReport.Size = new System.Drawing.Size(794, 415);
            this.RechargeReport.TabIndex = 0;
            this.RechargeReport.Load += new System.EventHandler(this.RechargeReport_LBL_Load);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(387, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
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
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.RechargeReport);
            this.Name = "RechargeReports";
            this.Text = "RechargeReports";
            this.Load += new System.EventHandler(this.RechargeReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RechargeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RechargeReport;
        private System.Windows.Forms.BindingSource RechargeBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}