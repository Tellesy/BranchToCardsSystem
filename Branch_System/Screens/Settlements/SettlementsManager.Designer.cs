namespace MPBS.Screens.SettlementsSecreens
{
    partial class SettlementsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettlementsManager));
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseTransactionReport_TXT = new System.Windows.Forms.TextBox();
            this.BrowseReport_BTN = new System.Windows.Forms.Button();
            this.Process_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Transaction Report";
            // 
            // BrowseTransactionReport_TXT
            // 
            this.BrowseTransactionReport_TXT.Location = new System.Drawing.Point(94, 101);
            this.BrowseTransactionReport_TXT.Name = "BrowseTransactionReport_TXT";
            this.BrowseTransactionReport_TXT.Size = new System.Drawing.Size(268, 20);
            this.BrowseTransactionReport_TXT.TabIndex = 59;
            // 
            // BrowseReport_BTN
            // 
            this.BrowseReport_BTN.Location = new System.Drawing.Point(13, 101);
            this.BrowseReport_BTN.Name = "BrowseReport_BTN";
            this.BrowseReport_BTN.Size = new System.Drawing.Size(75, 23);
            this.BrowseReport_BTN.TabIndex = 58;
            this.BrowseReport_BTN.Text = "Browse";
            this.BrowseReport_BTN.UseVisualStyleBackColor = true;
            this.BrowseReport_BTN.Click += new System.EventHandler(this.BrowseReport_BTN_Click);
            // 
            // Process_BTN
            // 
            this.Process_BTN.AutoSize = true;
            this.Process_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Process_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Process_BTN.BackgroundImage")));
            this.Process_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Process_BTN.Depth = 0;
            this.Process_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Process_BTN.Location = new System.Drawing.Point(290, 233);
            this.Process_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Process_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Process_BTN.Name = "Process_BTN";
            this.Process_BTN.Primary = false;
            this.Process_BTN.Size = new System.Drawing.Size(72, 36);
            this.Process_BTN.TabIndex = 61;
            this.Process_BTN.Text = "Process";
            this.Process_BTN.UseVisualStyleBackColor = true;
            this.Process_BTN.Click += new System.EventHandler(this.Process_BTN_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 152);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(349, 23);
            this.progressBar.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Progress";
            // 
            // SettlementsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Process_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseTransactionReport_TXT);
            this.Controls.Add(this.BrowseReport_BTN);
            this.Name = "SettlementsManager";
            this.Text = "SettlementsManager";
            this.Load += new System.EventHandler(this.SettlementsManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BrowseTransactionReport_TXT;
        private System.Windows.Forms.Button BrowseReport_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Process_BTN;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
    }
}