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
            this.RechargeReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Search_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RechargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RechargeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RechargeReport
            // 
            reportDataSource1.Name = "RechargeDS";
            reportDataSource1.Value = this.RechargeBindingSource;
            this.RechargeReport.LocalReport.DataSources.Add(reportDataSource1);
            this.RechargeReport.LocalReport.ReportEmbeddedResource = "CTS.Screens.Reports.RechargeReport.rdlc";
            this.RechargeReport.Location = new System.Drawing.Point(3, 123);
            this.RechargeReport.Name = "RechargeReport";
            this.RechargeReport.Size = new System.Drawing.Size(794, 415);
            this.RechargeReport.TabIndex = 0;
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Location = new System.Drawing.Point(496, 81);
            this.FromDatePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.FromDatePicker.TabIndex = 1;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Location = new System.Drawing.Point(188, 80);
            this.ToDatePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ToDatePicker.TabIndex = 2;
            // 
            // Search_BTN
            // 
            this.Search_BTN.Location = new System.Drawing.Point(54, 81);
            this.Search_BTN.Name = "Search_BTN";
            this.Search_BTN.Size = new System.Drawing.Size(75, 23);
            this.Search_BTN.TabIndex = 3;
            this.Search_BTN.Text = "بحث";
            this.Search_BTN.UseVisualStyleBackColor = true;
            this.Search_BTN.Click += new System.EventHandler(this.Search_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(702, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "من ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(392, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "إلى";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(723, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "ادخل الفترة";
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_BTN);
            this.Controls.Add(this.ToDatePicker);
            this.Controls.Add(this.FromDatePicker);
            this.Controls.Add(this.RechargeReport);
            this.Name = "RechargeReports";
            this.Text = "RechargeReports";
            this.Load += new System.EventHandler(this.RechargeReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RechargeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RechargeReport;
        private System.Windows.Forms.BindingSource RechargeBindingSource;
        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.Button Search_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}