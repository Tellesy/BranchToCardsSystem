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
            this.RechargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RechargeReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Search_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerID_CBX = new System.Windows.Forms.CheckBox();
            this.CustomerID_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Family_RB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Alrafiq_RB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.RechargeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RechargeBindingSource
            // 
            this.RechargeBindingSource.DataSource = typeof(CTS.Database.DataObjects.Recharge);
            // 
            // RechargeReport
            // 
            reportDataSource1.Name = "RechargeDT";
            reportDataSource1.Value = this.RechargeBindingSource;
            this.RechargeReport.LocalReport.DataSources.Add(reportDataSource1);
            this.RechargeReport.LocalReport.ReportEmbeddedResource = "CTS.Screens.Reports.AlrafiqRechargReport.rdlc";
            this.RechargeReport.Location = new System.Drawing.Point(3, 126);
            this.RechargeReport.Name = "RechargeReport";
            this.RechargeReport.Size = new System.Drawing.Size(898, 415);
            this.RechargeReport.TabIndex = 0;
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Location = new System.Drawing.Point(586, 35);
            this.FromDatePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.FromDatePicker.TabIndex = 1;
            this.FromDatePicker.Value = new System.DateTime(2018, 1, 1, 15, 7, 0, 0);
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Location = new System.Drawing.Point(586, 86);
            this.ToDatePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ToDatePicker.TabIndex = 2;
            // 
            // Search_BTN
            // 
            this.Search_BTN.Enabled = false;
            this.Search_BTN.Location = new System.Drawing.Point(130, 81);
            this.Search_BTN.Name = "Search_BTN";
            this.Search_BTN.Size = new System.Drawing.Size(95, 35);
            this.Search_BTN.TabIndex = 3;
            this.Search_BTN.Text = "بحث";
            this.Search_BTN.UseVisualStyleBackColor = true;
            this.Search_BTN.Click += new System.EventHandler(this.Search_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(792, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "من ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(792, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "إلى";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(824, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "ادخل الفترة";
            // 
            // CustomerID_CBX
            // 
            this.CustomerID_CBX.AutoSize = true;
            this.CustomerID_CBX.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CustomerID_CBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID_CBX.Location = new System.Drawing.Point(369, 24);
            this.CustomerID_CBX.Name = "CustomerID_CBX";
            this.CustomerID_CBX.Size = new System.Drawing.Size(157, 22);
            this.CustomerID_CBX.TabIndex = 7;
            this.CustomerID_CBX.Text = "إبحث بإستخدام رقم الزبون";
            this.CustomerID_CBX.UseVisualStyleBackColor = true;
            this.CustomerID_CBX.CheckedChanged += new System.EventHandler(this.CustomerID_CBX_CheckedChanged);
            // 
            // CustomerID_TXT
            // 
            this.CustomerID_TXT.Enabled = false;
            this.CustomerID_TXT.Location = new System.Drawing.Point(369, 89);
            this.CustomerID_TXT.MaxLength = 7;
            this.CustomerID_TXT.Name = "CustomerID_TXT";
            this.CustomerID_TXT.Size = new System.Drawing.Size(157, 20);
            this.CustomerID_TXT.TabIndex = 8;
            this.CustomerID_TXT.TextChanged += new System.EventHandler(this.CustomerID_TXT_TextChanged);
            this.CustomerID_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerID_TXT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "رقم الزبون";
            // 
            // Family_RB
            // 
            this.Family_RB.AutoSize = true;
            this.Family_RB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Family_RB.Location = new System.Drawing.Point(20, 19);
            this.Family_RB.Name = "Family_RB";
            this.Family_RB.Size = new System.Drawing.Size(75, 17);
            this.Family_RB.TabIndex = 10;
            this.Family_RB.TabStop = true;
            this.Family_RB.Text = "ارباب الأسر";
            this.Family_RB.UseVisualStyleBackColor = true;
            this.Family_RB.CheckedChanged += new System.EventHandler(this.Family_RB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Alrafiq_RB);
            this.groupBox1.Controls.Add(this.Family_RB);
            this.groupBox1.Location = new System.Drawing.Point(130, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 68);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع المنتج";
            // 
            // Alrafiq_RB
            // 
            this.Alrafiq_RB.AutoSize = true;
            this.Alrafiq_RB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Alrafiq_RB.Location = new System.Drawing.Point(2, 42);
            this.Alrafiq_RB.Name = "Alrafiq_RB";
            this.Alrafiq_RB.Size = new System.Drawing.Size(93, 17);
            this.Alrafiq_RB.TabIndex = 11;
            this.Alrafiq_RB.TabStop = true;
            this.Alrafiq_RB.Text = "أغراض شخصية";
            this.Alrafiq_RB.UseVisualStyleBackColor = true;
            this.Alrafiq_RB.CheckedChanged += new System.EventHandler(this.Alrafiq_RB_CheckedChanged);
            // 
            // RechargeReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerID_TXT);
            this.Controls.Add(this.CustomerID_CBX);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckBox CustomerID_CBX;
        private System.Windows.Forms.TextBox CustomerID_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Family_RB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Alrafiq_RB;
    }
}