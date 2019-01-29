namespace Branch_System.Screens
{
    partial class POAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POAuth));
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.Sync_BTN = new System.Windows.Forms.Button();
            this.Record_DGView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Record_DGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_BTN.BackgroundImage")));
            this.Exit_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_BTN.Location = new System.Drawing.Point(820, 498);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(80, 59);
            this.Exit_BTN.TabIndex = 7;
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // Sync_BTN
            // 
            this.Sync_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sync_BTN.BackgroundImage")));
            this.Sync_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sync_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sync_BTN.Location = new System.Drawing.Point(17, 15);
            this.Sync_BTN.Name = "Sync_BTN";
            this.Sync_BTN.Size = new System.Drawing.Size(66, 57);
            this.Sync_BTN.TabIndex = 6;
            this.Sync_BTN.UseVisualStyleBackColor = true;
            this.Sync_BTN.Click += new System.EventHandler(this.Sync_BTN_Click);
            // 
            // Record_DGView
            // 
            this.Record_DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Record_DGView.Location = new System.Drawing.Point(17, 88);
            this.Record_DGView.MultiSelect = false;
            this.Record_DGView.Name = "Record_DGView";
            this.Record_DGView.ReadOnly = true;
            this.Record_DGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Record_DGView.Size = new System.Drawing.Size(928, 400);
            this.Record_DGView.TabIndex = 5;
            this.Record_DGView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Record_DGView_CellMouseDoubleClick);
            // 
            // POAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 569);
            this.ControlBox = false;
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Sync_BTN);
            this.Controls.Add(this.Record_DGView);
            this.Name = "POAuth";
            this.Text = "POAuth";
            this.Load += new System.EventHandler(this.POAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Record_DGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.Button Sync_BTN;
        private System.Windows.Forms.DataGridView Record_DGView;
    }
}