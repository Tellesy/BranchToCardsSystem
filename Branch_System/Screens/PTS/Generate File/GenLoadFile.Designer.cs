namespace MPBS.Screens.PTS.Generate_File
{
    partial class GenLoadFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenLoadFile));
            this.Exit_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.GenLoadFilesBasedOnCode_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.GenAllLoadFiles_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
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
            this.Exit_BTN.Location = new System.Drawing.Point(13, 210);
            this.Exit_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Exit_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Primary = false;
            this.Exit_BTN.Size = new System.Drawing.Size(47, 36);
            this.Exit_BTN.TabIndex = 51;
            this.Exit_BTN.Text = "Back";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            // 
            // GenLoadFilesBasedOnCode_BTN
            // 
            this.GenLoadFilesBasedOnCode_BTN.AutoSize = true;
            this.GenLoadFilesBasedOnCode_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenLoadFilesBasedOnCode_BTN.Depth = 0;
            this.GenLoadFilesBasedOnCode_BTN.Font = new System.Drawing.Font("Modern No. 20", 10.25F);
            this.GenLoadFilesBasedOnCode_BTN.Location = new System.Drawing.Point(14, 139);
            this.GenLoadFilesBasedOnCode_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenLoadFilesBasedOnCode_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenLoadFilesBasedOnCode_BTN.Name = "GenLoadFilesBasedOnCode_BTN";
            this.GenLoadFilesBasedOnCode_BTN.Primary = false;
            this.GenLoadFilesBasedOnCode_BTN.Size = new System.Drawing.Size(390, 36);
            this.GenLoadFilesBasedOnCode_BTN.TabIndex = 50;
            this.GenLoadFilesBasedOnCode_BTN.Text = "Generate Load Record Files Based on Program Code";
            this.GenLoadFilesBasedOnCode_BTN.UseVisualStyleBackColor = true;
            // 
            // GenAllLoadFiles_BTN
            // 
            this.GenAllLoadFiles_BTN.AutoSize = true;
            this.GenAllLoadFiles_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenAllLoadFiles_BTN.Depth = 0;
            this.GenAllLoadFiles_BTN.Font = new System.Drawing.Font("Modern No. 20", 10.25F);
            this.GenAllLoadFiles_BTN.Location = new System.Drawing.Point(13, 74);
            this.GenAllLoadFiles_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenAllLoadFiles_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenAllLoadFiles_BTN.Name = "GenAllLoadFiles_BTN";
            this.GenAllLoadFiles_BTN.Primary = false;
            this.GenAllLoadFiles_BTN.Size = new System.Drawing.Size(217, 36);
            this.GenAllLoadFiles_BTN.TabIndex = 49;
            this.GenAllLoadFiles_BTN.Text = "Generate All Load Requests";
            this.GenAllLoadFiles_BTN.UseVisualStyleBackColor = true;
            this.GenAllLoadFiles_BTN.Click += new System.EventHandler(this.GenAllLoadFiles_BTN_Click);
            // 
            // GenLoadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(415, 260);
            this.ControlBox = false;
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.GenLoadFilesBasedOnCode_BTN);
            this.Controls.Add(this.GenAllLoadFiles_BTN);
            this.Name = "GenLoadFile";
            this.Text = "Generate Load Files (PTS)";
            this.Load += new System.EventHandler(this.GenLoadFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Exit_BTN;
        private MaterialSkin.Controls.MaterialFlatButton GenLoadFilesBasedOnCode_BTN;
        private MaterialSkin.Controls.MaterialFlatButton GenAllLoadFiles_BTN;
    }
}