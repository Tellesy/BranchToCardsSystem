namespace MPBS.Screens.PTS.Reports
{
    partial class ReportsGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Program_CBox = new System.Windows.Forms.ComboBox();
            this.Program_LBL = new System.Windows.Forms.Label();
            this.CardIssuingReport_RBTN = new MaterialSkin.Controls.MaterialRadioButton();
            this.Generate_BTN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // FromDate_DTP
            // 
            this.FromDate_DTP.Location = new System.Drawing.Point(23, 105);
            this.FromDate_DTP.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.FromDate_DTP.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.FromDate_DTP.Name = "FromDate_DTP";
            this.FromDate_DTP.Size = new System.Drawing.Size(200, 20);
            this.FromDate_DTP.TabIndex = 0;
            // 
            // ToDate_DTP
            // 
            this.ToDate_DTP.Location = new System.Drawing.Point(385, 105);
            this.ToDate_DTP.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.ToDate_DTP.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.ToDate_DTP.Name = "ToDate_DTP";
            this.ToDate_DTP.Size = new System.Drawing.Size(200, 20);
            this.ToDate_DTP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // Program_CBox
            // 
            this.Program_CBox.FormattingEnabled = true;
            this.Program_CBox.Location = new System.Drawing.Point(23, 226);
            this.Program_CBox.Name = "Program_CBox";
            this.Program_CBox.Size = new System.Drawing.Size(121, 21);
            this.Program_CBox.TabIndex = 5;
            // 
            // Program_LBL
            // 
            this.Program_LBL.AutoSize = true;
            this.Program_LBL.Location = new System.Drawing.Point(20, 210);
            this.Program_LBL.Name = "Program_LBL";
            this.Program_LBL.Size = new System.Drawing.Size(46, 13);
            this.Program_LBL.TabIndex = 6;
            this.Program_LBL.Text = "Program";
            // 
            // CardIssuingReport_RBTN
            // 
            this.CardIssuingReport_RBTN.AutoSize = true;
            this.CardIssuingReport_RBTN.Depth = 0;
            this.CardIssuingReport_RBTN.Font = new System.Drawing.Font("Roboto", 10F);
            this.CardIssuingReport_RBTN.Location = new System.Drawing.Point(23, 154);
            this.CardIssuingReport_RBTN.Margin = new System.Windows.Forms.Padding(0);
            this.CardIssuingReport_RBTN.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CardIssuingReport_RBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardIssuingReport_RBTN.Name = "CardIssuingReport_RBTN";
            this.CardIssuingReport_RBTN.Ripple = true;
            this.CardIssuingReport_RBTN.Size = new System.Drawing.Size(150, 30);
            this.CardIssuingReport_RBTN.TabIndex = 9;
            this.CardIssuingReport_RBTN.TabStop = true;
            this.CardIssuingReport_RBTN.Text = "Card Issuing Report";
            this.CardIssuingReport_RBTN.UseVisualStyleBackColor = true;
            this.CardIssuingReport_RBTN.CheckedChanged += new System.EventHandler(this.CardIssuingReport_RBTN_CheckedChanged);
            // 
            // Generate_BTN
            // 
            this.Generate_BTN.Depth = 0;
            this.Generate_BTN.Enabled = false;
            this.Generate_BTN.Location = new System.Drawing.Point(477, 295);
            this.Generate_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Generate_BTN.Name = "Generate_BTN";
            this.Generate_BTN.Primary = true;
            this.Generate_BTN.Size = new System.Drawing.Size(108, 57);
            this.Generate_BTN.TabIndex = 10;
            this.Generate_BTN.Text = "Generate";
            this.Generate_BTN.UseVisualStyleBackColor = true;
            this.Generate_BTN.Click += new System.EventHandler(this.Generate_BTN_Click);
            // 
            // ReportsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 388);
            this.Controls.Add(this.Generate_BTN);
            this.Controls.Add(this.CardIssuingReport_RBTN);
            this.Controls.Add(this.Program_LBL);
            this.Controls.Add(this.Program_CBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDate_DTP);
            this.Controls.Add(this.FromDate_DTP);
            this.Name = "ReportsMenu";
            this.Text = "ReportsMenu";
            this.Load += new System.EventHandler(this.ReportsMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FromDate_DTP;
        private System.Windows.Forms.DateTimePicker ToDate_DTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Program_CBox;
        private System.Windows.Forms.Label Program_LBL;
        private MaterialSkin.Controls.MaterialRadioButton CardIssuingReport_RBTN;
        private MaterialSkin.Controls.MaterialRaisedButton Generate_BTN;
    }
}