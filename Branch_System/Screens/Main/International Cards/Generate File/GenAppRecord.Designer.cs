namespace CTS.Screens.Main.International_Cards.Generate_File
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
            this.GenAppRecord_BTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenAppRecord_BTN
            // 
            this.GenAppRecord_BTN.Font = new System.Drawing.Font("Modern No. 20", 10.25F);
            this.GenAppRecord_BTN.Location = new System.Drawing.Point(12, 23);
            this.GenAppRecord_BTN.Name = "GenAppRecord_BTN";
            this.GenAppRecord_BTN.Size = new System.Drawing.Size(145, 63);
            this.GenAppRecord_BTN.TabIndex = 46;
            this.GenAppRecord_BTN.Text = "Generate App Record File";
            this.GenAppRecord_BTN.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.25F);
            this.button1.Location = new System.Drawing.Point(163, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 63);
            this.button1.TabIndex = 47;
            this.button1.Text = "Generate App Record File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_BTN.BackgroundImage")));
            this.Exit_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_BTN.Location = new System.Drawing.Point(228, 319);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(80, 59);
            this.Exit_BTN.TabIndex = 48;
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // GenAppRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(319, 390);
            this.ControlBox = false;
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GenAppRecord_BTN);
            this.Name = "GenAppRecord";
            this.Text = "GenAppRecord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenAppRecord_BTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit_BTN;
    }
}