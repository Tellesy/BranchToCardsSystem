﻿namespace Branch_System.Screens
{
    partial class CAFUnauth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAFUnauth));
            this.branch_system1DataSet = new Branch_System.Branch_system1DataSet();
            this.branchsystem1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Record_DGView = new System.Windows.Forms.DataGridView();
            this.branchsystem1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.Sync_BTN = new System.Windows.Forms.Button();
            this.Auth_All_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.branch_system1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Record_DGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource1)).BeginInit();
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
            this.Record_DGView.Location = new System.Drawing.Point(6, 85);
            this.Record_DGView.MultiSelect = false;
            this.Record_DGView.Name = "Record_DGView";
            this.Record_DGView.ReadOnly = true;
            this.Record_DGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Record_DGView.Size = new System.Drawing.Size(734, 495);
            this.Record_DGView.TabIndex = 8;
            this.Record_DGView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Record_DGView_CellMouseDoubleClick);
            // 
            // branchsystem1DataSetBindingSource1
            // 
            this.branchsystem1DataSetBindingSource1.DataSource = this.branch_system1DataSet;
            this.branchsystem1DataSetBindingSource1.Position = 0;
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_BTN.BackgroundImage")));
            this.Exit_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_BTN.Location = new System.Drawing.Point(660, 585);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(80, 59);
            this.Exit_BTN.TabIndex = 10;
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // Sync_BTN
            // 
            this.Sync_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sync_BTN.BackgroundImage")));
            this.Sync_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sync_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sync_BTN.Location = new System.Drawing.Point(12, 12);
            this.Sync_BTN.Name = "Sync_BTN";
            this.Sync_BTN.Size = new System.Drawing.Size(66, 57);
            this.Sync_BTN.TabIndex = 9;
            this.Sync_BTN.UseVisualStyleBackColor = true;
            this.Sync_BTN.Click += new System.EventHandler(this.Sync_BTN_Click);
            // 
            // Auth_All_BTN
            // 
            this.Auth_All_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Auth_All_BTN.Location = new System.Drawing.Point(6, 586);
            this.Auth_All_BTN.Name = "Auth_All_BTN";
            this.Auth_All_BTN.Size = new System.Drawing.Size(157, 59);
            this.Auth_All_BTN.TabIndex = 11;
            this.Auth_All_BTN.Text = "تخويل الجميع";
            this.Auth_All_BTN.UseVisualStyleBackColor = true;
            this.Auth_All_BTN.Click += new System.EventHandler(this.Auth_All_BTN_Click);
            // 
            // CAFUnauth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 649);
            this.ControlBox = false;
            this.Controls.Add(this.Auth_All_BTN);
            this.Controls.Add(this.Record_DGView);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Sync_BTN);
            this.Name = "CAFUnauth";
            this.Text = "CAFUnauth";
            this.Load += new System.EventHandler(this.CAFUnauth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branch_system1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Record_DGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Branch_system1DataSet branch_system1DataSet;
        private System.Windows.Forms.BindingSource branchsystem1DataSetBindingSource;
        private System.Windows.Forms.DataGridView Record_DGView;
        private System.Windows.Forms.BindingSource branchsystem1DataSetBindingSource1;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.Button Sync_BTN;
        private System.Windows.Forms.Button Auth_All_BTN;
    }
}