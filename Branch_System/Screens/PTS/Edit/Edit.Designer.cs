namespace MPBS.Screens.PTS.Edit
{
    partial class Edit
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
            this.EditCustomerInformation_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // EditCustomerInformation_BTN
            // 
            this.EditCustomerInformation_BTN.AutoSize = true;
            this.EditCustomerInformation_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditCustomerInformation_BTN.Depth = 0;
            this.EditCustomerInformation_BTN.Location = new System.Drawing.Point(23, 102);
            this.EditCustomerInformation_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditCustomerInformation_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditCustomerInformation_BTN.Name = "EditCustomerInformation_BTN";
            this.EditCustomerInformation_BTN.Primary = false;
            this.EditCustomerInformation_BTN.Size = new System.Drawing.Size(212, 36);
            this.EditCustomerInformation_BTN.TabIndex = 0;
            this.EditCustomerInformation_BTN.Text = "Edit Customer Information";
            this.EditCustomerInformation_BTN.UseVisualStyleBackColor = true;
            this.EditCustomerInformation_BTN.Click += new System.EventHandler(this.EditCustomerInformation_BTN_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 450);
            this.Controls.Add(this.EditCustomerInformation_BTN);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton EditCustomerInformation_BTN;
    }
}