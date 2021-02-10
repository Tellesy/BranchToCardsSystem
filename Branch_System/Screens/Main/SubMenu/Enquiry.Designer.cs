namespace MPBS.Screens.Main.SubMenu
{
    partial class Enquiry
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
            this.IssueStatus_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoadStatus_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Back_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // IssueStatus_BTN
            // 
            this.IssueStatus_BTN.AutoSize = true;
            this.IssueStatus_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IssueStatus_BTN.Depth = 0;
            this.IssueStatus_BTN.Location = new System.Drawing.Point(13, 95);
            this.IssueStatus_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.IssueStatus_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.IssueStatus_BTN.Name = "IssueStatus_BTN";
            this.IssueStatus_BTN.Primary = false;
            this.IssueStatus_BTN.Size = new System.Drawing.Size(104, 36);
            this.IssueStatus_BTN.TabIndex = 0;
            this.IssueStatus_BTN.Text = "Issue Status";
            this.IssueStatus_BTN.UseVisualStyleBackColor = true;
            // 
            // LoadStatus_BTN
            // 
            this.LoadStatus_BTN.AutoSize = true;
            this.LoadStatus_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadStatus_BTN.Depth = 0;
            this.LoadStatus_BTN.Location = new System.Drawing.Point(13, 153);
            this.LoadStatus_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadStatus_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadStatus_BTN.Name = "LoadStatus_BTN";
            this.LoadStatus_BTN.Primary = false;
            this.LoadStatus_BTN.Size = new System.Drawing.Size(102, 36);
            this.LoadStatus_BTN.TabIndex = 1;
            this.LoadStatus_BTN.Text = "Load Status";
            this.LoadStatus_BTN.UseVisualStyleBackColor = true;
            this.LoadStatus_BTN.Click += new System.EventHandler(this.LoadStatus_BTN_Click);
            // 
            // Back_BTN
            // 
            this.Back_BTN.AutoSize = true;
            this.Back_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back_BTN.Depth = 0;
            this.Back_BTN.Location = new System.Drawing.Point(13, 399);
            this.Back_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Back_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Primary = false;
            this.Back_BTN.Size = new System.Drawing.Size(47, 36);
            this.Back_BTN.TabIndex = 2;
            this.Back_BTN.Text = "Back";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 450);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.LoadStatus_BTN);
            this.Controls.Add(this.IssueStatus_BTN);
            this.Name = "Enquiry";
            this.Text = "Enquiry";
            this.Load += new System.EventHandler(this.Enquiry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton IssueStatus_BTN;
        private MaterialSkin.Controls.MaterialFlatButton LoadStatus_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Back_BTN;
    }
}