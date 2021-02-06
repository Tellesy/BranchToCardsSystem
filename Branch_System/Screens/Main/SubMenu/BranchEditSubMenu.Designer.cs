namespace MPBS.Screens.Main.SubMenu
{
    partial class BranchEditSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchEditSubMenu));
            this.Back_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.EditAccountInformation_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.EditCustomerInformation_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // Back_BTN
            // 
            this.Back_BTN.AutoSize = true;
            this.Back_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back_BTN.Depth = 0;
            this.Back_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Back_BTN.Image")));
            this.Back_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back_BTN.Location = new System.Drawing.Point(13, 196);
            this.Back_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Back_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Primary = false;
            this.Back_BTN.Size = new System.Drawing.Size(47, 36);
            this.Back_BTN.TabIndex = 46;
            this.Back_BTN.Text = "Back";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // EditAccountInformation_BTN
            // 
            this.EditAccountInformation_BTN.AutoSize = true;
            this.EditAccountInformation_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditAccountInformation_BTN.Depth = 0;
            this.EditAccountInformation_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAccountInformation_BTN.Location = new System.Drawing.Point(13, 119);
            this.EditAccountInformation_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditAccountInformation_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditAccountInformation_BTN.Name = "EditAccountInformation_BTN";
            this.EditAccountInformation_BTN.Primary = false;
            this.EditAccountInformation_BTN.Size = new System.Drawing.Size(203, 36);
            this.EditAccountInformation_BTN.TabIndex = 68;
            this.EditAccountInformation_BTN.Text = "Edit Account Information";
            this.EditAccountInformation_BTN.UseVisualStyleBackColor = true;
            this.EditAccountInformation_BTN.Click += new System.EventHandler(this.EditAccountInformation_BTN_Click);
            // 
            // EditCustomerInformation_BTN
            // 
            this.EditCustomerInformation_BTN.AutoSize = true;
            this.EditCustomerInformation_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditCustomerInformation_BTN.Depth = 0;
            this.EditCustomerInformation_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCustomerInformation_BTN.Location = new System.Drawing.Point(13, 71);
            this.EditCustomerInformation_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditCustomerInformation_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditCustomerInformation_BTN.Name = "EditCustomerInformation_BTN";
            this.EditCustomerInformation_BTN.Primary = false;
            this.EditCustomerInformation_BTN.Size = new System.Drawing.Size(212, 36);
            this.EditCustomerInformation_BTN.TabIndex = 67;
            this.EditCustomerInformation_BTN.Text = "Edit Customer Information";
            this.EditCustomerInformation_BTN.UseVisualStyleBackColor = true;
            this.EditCustomerInformation_BTN.Click += new System.EventHandler(this.EditCustomerInformation_BTN_Click);
            // 
            // BranchEditSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 238);
            this.Controls.Add(this.EditAccountInformation_BTN);
            this.Controls.Add(this.EditCustomerInformation_BTN);
            this.Controls.Add(this.Back_BTN);
            this.Name = "BranchEditSubMenu";
            this.Text = "BranchEditSubMenu";
            this.Load += new System.EventHandler(this.BranchEditSubMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Back_BTN;
        private MaterialSkin.Controls.MaterialFlatButton EditAccountInformation_BTN;
        private MaterialSkin.Controls.MaterialFlatButton EditCustomerInformation_BTN;
    }
}