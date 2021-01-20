namespace MPBS.Screens
{
    partial class PreLoginPage
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
            this.DataBaseType_CBox = new System.Windows.Forms.ComboBox();
            this.Login_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.Version_LBL = new System.Windows.Forms.Label();
            this.Exit_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataBaseType_CBox
            // 
            this.DataBaseType_CBox.FormattingEnabled = true;
            this.DataBaseType_CBox.Items.AddRange(new object[] {
            "Production",
            "UAT",
            "Dev (Not For Branch Users)"});
            this.DataBaseType_CBox.Location = new System.Drawing.Point(32, 114);
            this.DataBaseType_CBox.Name = "DataBaseType_CBox";
            this.DataBaseType_CBox.Size = new System.Drawing.Size(182, 21);
            this.DataBaseType_CBox.TabIndex = 14;
            this.DataBaseType_CBox.SelectedIndexChanged += new System.EventHandler(this.DataBaseType_CBox_SelectedIndexChanged);
            // 
            // Login_BTN
            // 
            this.Login_BTN.AutoSize = true;
            this.Login_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login_BTN.Depth = 0;
            this.Login_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_BTN.Location = new System.Drawing.Point(242, 105);
            this.Login_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_BTN.Name = "Login_BTN";
            this.Login_BTN.Primary = false;
            this.Login_BTN.Size = new System.Drawing.Size(55, 36);
            this.Login_BTN.TabIndex = 15;
            this.Login_BTN.Text = "Start";
            this.Login_BTN.UseVisualStyleBackColor = false;
            this.Login_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // Version_LBL
            // 
            this.Version_LBL.AutoSize = true;
            this.Version_LBL.BackColor = System.Drawing.Color.Transparent;
            this.Version_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Version_LBL.Location = new System.Drawing.Point(67, 215);
            this.Version_LBL.Name = "Version_LBL";
            this.Version_LBL.Size = new System.Drawing.Size(129, 17);
            this.Version_LBL.TabIndex = 16;
            this.Version_LBL.Text = "Muiee\'s Software ©";
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.AutoSize = true;
            this.Exit_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Exit_BTN.Depth = 0;
            this.Exit_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Exit_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Exit_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_BTN.Location = new System.Drawing.Point(32, 173);
            this.Exit_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Exit_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Primary = false;
            this.Exit_BTN.Size = new System.Drawing.Size(41, 36);
            this.Exit_BTN.TabIndex = 17;
            this.Exit_BTN.Text = "Exit";
            this.Exit_BTN.UseVisualStyleBackColor = false;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(29, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Database";
            // 
            // PreLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 241);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Version_LBL);
            this.Controls.Add(this.Login_BTN);
            this.Controls.Add(this.DataBaseType_CBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreLoginPage";
            this.Text = "Welcome To MPBS by Mu Tellesy";
            this.Load += new System.EventHandler(this.PreLoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DataBaseType_CBox;
        private MaterialSkin.Controls.MaterialFlatButton Login_BTN;
        private System.Windows.Forms.Label Version_LBL;
        private MaterialSkin.Controls.MaterialFlatButton Exit_BTN;
        private System.Windows.Forms.Label label1;
    }
}