namespace MPBS.Screens.PTS.Delete
{ 
    partial class BranchDeleteLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchDeleteLoad));
            this.branch_system1DataSet = new MPBS.Branch_system1DataSet();
            this.branchsystem1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Record_DGView = new System.Windows.Forms.DataGridView();
            this.branchsystem1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Exit_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Sync_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerID_TXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.To_DTP = new System.Windows.Forms.DateTimePicker();
            this.SearchByTime_CHBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.SearchByTime_GBox = new System.Windows.Forms.GroupBox();
            this.From_DTP = new System.Windows.Forms.DateTimePicker();
            this.Search_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.branch_system1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Record_DGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource1)).BeginInit();
            this.SearchByTime_GBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // branch_system1DataSet
            // 
            this.branch_system1DataSet.DataSetName = "Branch_system1DataSet";
            this.branch_system1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchsystem1DataSetBindingSource
            // 
            this.branchsystem1DataSetBindingSource.DataSource = this.branch_system1DataSet;
            this.branchsystem1DataSetBindingSource.Position = 0;
            // 
            // Record_DGView
            // 
            this.Record_DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Record_DGView.Location = new System.Drawing.Point(12, 190);
            this.Record_DGView.MultiSelect = false;
            this.Record_DGView.Name = "Record_DGView";
            this.Record_DGView.ReadOnly = true;
            this.Record_DGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Record_DGView.Size = new System.Drawing.Size(729, 335);
            this.Record_DGView.TabIndex = 5;
            this.Record_DGView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Record_DGView_CellMouseDoubleClick);
            // 
            // branchsystem1DataSetBindingSource1
            // 
            this.branchsystem1DataSetBindingSource1.DataSource = this.branch_system1DataSet;
            this.branchsystem1DataSetBindingSource1.Position = 0;
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.AutoSize = true;
            this.Exit_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_BTN.BackgroundImage")));
            this.Exit_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_BTN.Depth = 0;
            this.Exit_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_BTN.Location = new System.Drawing.Point(13, 534);
            this.Exit_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Exit_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Primary = false;
            this.Exit_BTN.Size = new System.Drawing.Size(41, 36);
            this.Exit_BTN.TabIndex = 7;
            this.Exit_BTN.Text = "Exit";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // Sync_BTN
            // 
            this.Sync_BTN.AutoSize = true;
            this.Sync_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sync_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sync_BTN.BackgroundImage")));
            this.Sync_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sync_BTN.Depth = 0;
            this.Sync_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sync_BTN.Location = new System.Drawing.Point(12, 73);
            this.Sync_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Sync_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Sync_BTN.Name = "Sync_BTN";
            this.Sync_BTN.Primary = false;
            this.Sync_BTN.Size = new System.Drawing.Size(70, 36);
            this.Sync_BTN.TabIndex = 6;
            this.Sync_BTN.Text = "Refresh";
            this.Sync_BTN.UseVisualStyleBackColor = true;
            this.Sync_BTN.Click += new System.EventHandler(this.Sync_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer ID";
            // 
            // CustomerID_TXT
            // 
            this.CustomerID_TXT.Location = new System.Drawing.Point(105, 160);
            this.CustomerID_TXT.MaxLength = 7;
            this.CustomerID_TXT.Name = "CustomerID_TXT";
            this.CustomerID_TXT.Size = new System.Drawing.Size(100, 20);
            this.CustomerID_TXT.TabIndex = 9;
            this.CustomerID_TXT.TextChanged += new System.EventHandler(this.CustomerID_TXT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "To";
            // 
            // To_DTP
            // 
            this.To_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To_DTP.Location = new System.Drawing.Point(4, 79);
            this.To_DTP.MaxDate = new System.DateTime(2031, 12, 31, 0, 0, 0, 0);
            this.To_DTP.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.To_DTP.Name = "To_DTP";
            this.To_DTP.Size = new System.Drawing.Size(107, 20);
            this.To_DTP.TabIndex = 12;
            // 
            // SearchByTime_CHBox
            // 
            this.SearchByTime_CHBox.AutoSize = true;
            this.SearchByTime_CHBox.Depth = 0;
            this.SearchByTime_CHBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.SearchByTime_CHBox.Location = new System.Drawing.Point(362, 76);
            this.SearchByTime_CHBox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchByTime_CHBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SearchByTime_CHBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchByTime_CHBox.Name = "SearchByTime_CHBox";
            this.SearchByTime_CHBox.Ripple = true;
            this.SearchByTime_CHBox.Size = new System.Drawing.Size(160, 30);
            this.SearchByTime_CHBox.TabIndex = 15;
            this.SearchByTime_CHBox.Text = "Search by Input Time";
            this.SearchByTime_CHBox.UseVisualStyleBackColor = true;
            this.SearchByTime_CHBox.CheckedChanged += new System.EventHandler(this.SearchByTime_CHBox_CheckedChanged);
            // 
            // SearchByTime_GBox
            // 
            this.SearchByTime_GBox.Controls.Add(this.From_DTP);
            this.SearchByTime_GBox.Controls.Add(this.Search_BTN);
            this.SearchByTime_GBox.Controls.Add(this.label2);
            this.SearchByTime_GBox.Controls.Add(this.label3);
            this.SearchByTime_GBox.Controls.Add(this.To_DTP);
            this.SearchByTime_GBox.Enabled = false;
            this.SearchByTime_GBox.Location = new System.Drawing.Point(525, 73);
            this.SearchByTime_GBox.Name = "SearchByTime_GBox";
            this.SearchByTime_GBox.Size = new System.Drawing.Size(216, 111);
            this.SearchByTime_GBox.TabIndex = 16;
            this.SearchByTime_GBox.TabStop = false;
            this.SearchByTime_GBox.Text = "Search By Time";
            // 
            // From_DTP
            // 
            this.From_DTP.CustomFormat = "";
            this.From_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From_DTP.Location = new System.Drawing.Point(4, 36);
            this.From_DTP.MaxDate = new System.DateTime(2031, 12, 31, 0, 0, 0, 0);
            this.From_DTP.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.From_DTP.Name = "From_DTP";
            this.From_DTP.Size = new System.Drawing.Size(107, 20);
            this.From_DTP.TabIndex = 18;
            // 
            // Search_BTN
            // 
            this.Search_BTN.AutoSize = true;
            this.Search_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Search_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_BTN.BackgroundImage")));
            this.Search_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search_BTN.Depth = 0;
            this.Search_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_BTN.Location = new System.Drawing.Point(140, 66);
            this.Search_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Search_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Search_BTN.Name = "Search_BTN";
            this.Search_BTN.Primary = false;
            this.Search_BTN.Size = new System.Drawing.Size(64, 36);
            this.Search_BTN.TabIndex = 17;
            this.Search_BTN.Text = "Search";
            this.Search_BTN.UseVisualStyleBackColor = true;
            this.Search_BTN.Click += new System.EventHandler(this.Search_BTN_Click);
            // 
            // BranchDeleteLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(749, 571);
            this.ControlBox = false;
            this.Controls.Add(this.SearchByTime_GBox);
            this.Controls.Add(this.CustomerID_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchByTime_CHBox);
            this.Controls.Add(this.Record_DGView);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Sync_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BranchDeleteLoad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Delete Load Requests";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AuthIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branch_system1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Record_DGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource1)).EndInit();
            this.SearchByTime_GBox.ResumeLayout(false);
            this.SearchByTime_GBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Branch_system1DataSet branch_system1DataSet;
        private System.Windows.Forms.BindingSource branchsystem1DataSetBindingSource;
        private System.Windows.Forms.DataGridView Record_DGView;
        private System.Windows.Forms.BindingSource branchsystem1DataSetBindingSource1;
        private MaterialSkin.Controls.MaterialFlatButton Exit_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Sync_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerID_TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker To_DTP;
        private MaterialSkin.Controls.MaterialCheckBox SearchByTime_CHBox;
        private System.Windows.Forms.GroupBox SearchByTime_GBox;
        private MaterialSkin.Controls.MaterialFlatButton Search_BTN;
        private System.Windows.Forms.DateTimePicker From_DTP;
    }
}