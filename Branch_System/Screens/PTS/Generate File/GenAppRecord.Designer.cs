namespace MPBS.Screens.PTS.Generate_File
{
    partial class GenAppRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenAppRecord));
            this.GenAllAppFiles_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.GenAppFilesBasedOnCode_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Exit_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // GenAllAppFiles_BTN
            // 
            this.GenAllAppFiles_BTN.AutoSize = true;
            this.GenAllAppFiles_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenAllAppFiles_BTN.Depth = 0;
            this.GenAllAppFiles_BTN.Font = new System.Drawing.Font("Modern No. 20", 10.25F);
            this.GenAllAppFiles_BTN.Location = new System.Drawing.Point(12, 79);
            this.GenAllAppFiles_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenAllAppFiles_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenAllAppFiles_BTN.Name = "GenAllAppFiles_BTN";
            this.GenAllAppFiles_BTN.Primary = false;
            this.GenAllAppFiles_BTN.Size = new System.Drawing.Size(202, 36);
            this.GenAllAppFiles_BTN.TabIndex = 46;
            this.GenAllAppFiles_BTN.Text = "Generate All App Records";
            this.GenAllAppFiles_BTN.UseVisualStyleBackColor = true;
            this.GenAllAppFiles_BTN.Click += new System.EventHandler(this.GenAllAppFiles_BTN_Click);
            // 
            // GenAppFilesBasedOnCode_BTN
            // 
            this.GenAppFilesBasedOnCode_BTN.AutoSize = true;
            this.GenAppFilesBasedOnCode_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenAppFilesBasedOnCode_BTN.Depth = 0;
            this.GenAppFilesBasedOnCode_BTN.Font = new System.Drawing.Font("Modern No. 20", 10.25F);
            this.GenAppFilesBasedOnCode_BTN.Location = new System.Drawing.Point(13, 144);
            this.GenAppFilesBasedOnCode_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenAppFilesBasedOnCode_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenAppFilesBasedOnCode_BTN.Name = "GenAppFilesBasedOnCode_BTN";
            this.GenAppFilesBasedOnCode_BTN.Primary = false;
            this.GenAppFilesBasedOnCode_BTN.Size = new System.Drawing.Size(381, 36);
            this.GenAppFilesBasedOnCode_BTN.TabIndex = 47;
            this.GenAppFilesBasedOnCode_BTN.Text = "Generate App Record Files Based on Program Code";
            this.GenAppFilesBasedOnCode_BTN.UseVisualStyleBackColor = true;
            this.GenAppFilesBasedOnCode_BTN.Click += new System.EventHandler(this.GenAppFilesBasedOnCode_BTN_Click);
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
            this.Exit_BTN.Location = new System.Drawing.Point(12, 339);
            this.Exit_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Exit_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Primary = false;
            this.Exit_BTN.Size = new System.Drawing.Size(47, 36);
            this.Exit_BTN.TabIndex = 48;
            this.Exit_BTN.Text = "Back";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // GenAppRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(416, 390);
            this.ControlBox = false;
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.GenAppFilesBasedOnCode_BTN);
            this.Controls.Add(this.GenAllAppFiles_BTN);
            this.Name = "GenAppRecord";
            this.Text = "Generate App Record Upload Files";
            this.Load += new System.EventHandler(this.GenAppRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton GenAllAppFiles_BTN;
        private MaterialSkin.Controls.MaterialFlatButton GenAppFilesBasedOnCode_BTN;
        private MaterialSkin.Controls.MaterialFlatButton Exit_BTN;
    }
}