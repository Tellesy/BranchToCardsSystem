namespace CTS.Screens
{
    partial class Issue
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
            this.label11 = new System.Windows.Forms.Label();
            this.Product_CBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTSMain = new CTS.CTSMain();
            this.label10 = new System.Windows.Forms.Label();
            this.Application_CBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CardNo_TXT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneNo_TXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BirthDate_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountUSD_TXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NID_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerName_TXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.Amount_TXT = new System.Windows.Forms.TextBox();
            this.cTSDataSet = new CTS.CTSDataSet();
            this.cTSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTSDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.branch_system1DataSet = new CTS.Branch_system1DataSet();
            this.branchsystem1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new CTS.CTSMainTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch_system1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "نوع المنتج";
            // 
            // Product_CBox
            // 
            this.Product_CBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Code", true));
            this.Product_CBox.FormattingEnabled = true;
            this.Product_CBox.Location = new System.Drawing.Point(166, 28);
            this.Product_CBox.Name = "Product_CBox";
            this.Product_CBox.Size = new System.Drawing.Size(209, 21);
            this.Product_CBox.TabIndex = 1;
            this.Product_CBox.SelectedIndexChanged += new System.EventHandler(this.Product_CBox_SelectedIndexChanged);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.cTSMain;
            // 
            // cTSMain
            // 
            this.cTSMain.DataSetName = "CTSMain";
            this.cTSMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "نوع المعاملة";
            // 
            // Application_CBox
            // 
            this.Application_CBox.Enabled = false;
            this.Application_CBox.FormattingEnabled = true;
            this.Application_CBox.Items.AddRange(new object[] {
            "إصدار جديد + شحن"});
            this.Application_CBox.Location = new System.Drawing.Point(166, 79);
            this.Application_CBox.Name = "Application_CBox";
            this.Application_CBox.Size = new System.Drawing.Size(209, 21);
            this.Application_CBox.TabIndex = 2;
            this.Application_CBox.SelectedIndexChanged += new System.EventHandler(this.Application_CBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "رقم البطاقة الجديد";
            // 
            // CardNo_TXT
            // 
            this.CardNo_TXT.Location = new System.Drawing.Point(142, 132);
            this.CardNo_TXT.MaxLength = 16;
            this.CardNo_TXT.Name = "CardNo_TXT";
            this.CardNo_TXT.ReadOnly = true;
            this.CardNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.CardNo_TXT.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(300, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "رقم جواز السفر";
            // 
            // Passport
            // 
            this.Passport.Enabled = false;
            this.Passport.Location = new System.Drawing.Point(142, 332);
            this.Passport.MaxLength = 8;
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(233, 20);
            this.Passport.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "رقم الهاتف (091XXXXXXX)";
            // 
            // PhoneNo_TXT
            // 
            this.PhoneNo_TXT.Enabled = false;
            this.PhoneNo_TXT.Location = new System.Drawing.Point(142, 435);
            this.PhoneNo_TXT.MaxLength = 10;
            this.PhoneNo_TXT.Name = "PhoneNo_TXT";
            this.PhoneNo_TXT.Size = new System.Drawing.Size(233, 20);
            this.PhoneNo_TXT.TabIndex = 10;
            this.PhoneNo_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNo_TXT_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "تاريخ الميلاد (DDMMYYYY)";
            // 
            // BirthDate_TXT
            // 
            this.BirthDate_TXT.Enabled = false;
            this.BirthDate_TXT.Location = new System.Drawing.Point(142, 387);
            this.BirthDate_TXT.MaxLength = 8;
            this.BirthDate_TXT.Name = "BirthDate_TXT";
            this.BirthDate_TXT.Size = new System.Drawing.Size(233, 20);
            this.BirthDate_TXT.TabIndex = 9;
            this.BirthDate_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BirthDate_TXT_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "رقم الحساب (USD)";
            // 
            // AccountUSD_TXT
            // 
            this.AccountUSD_TXT.Enabled = false;
            this.AccountUSD_TXT.Location = new System.Drawing.Point(142, 182);
            this.AccountUSD_TXT.MaxLength = 15;
            this.AccountUSD_TXT.Name = "AccountUSD_TXT";
            this.AccountUSD_TXT.Size = new System.Drawing.Size(233, 20);
            this.AccountUSD_TXT.TabIndex = 4;
            this.AccountUSD_TXT.TextChanged += new System.EventHandler(this.AccountUSD_TXT_TextChanged);
            this.AccountUSD_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountUSD_TXT_KeyPress);
            this.AccountUSD_TXT.Leave += new System.EventHandler(this.AccountUSD_TXT_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "الرقم الوطني";
            // 
            // NID_TXT
            // 
            this.NID_TXT.Enabled = false;
            this.NID_TXT.Location = new System.Drawing.Point(142, 284);
            this.NID_TXT.MaxLength = 12;
            this.NID_TXT.Name = "NID_TXT";
            this.NID_TXT.Size = new System.Drawing.Size(233, 20);
            this.NID_TXT.TabIndex = 6;
            this.NID_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NID_TXT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "اسم الزبون";
            // 
            // CustomerName_TXT
            // 
            this.CustomerName_TXT.Enabled = false;
            this.CustomerName_TXT.Location = new System.Drawing.Point(142, 232);
            this.CustomerName_TXT.MaxLength = 25;
            this.CustomerName_TXT.Name = "CustomerName_TXT";
            this.CustomerName_TXT.Size = new System.Drawing.Size(233, 20);
            this.CustomerName_TXT.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "قيمة الشحن بالدولار";
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(12, 595);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(363, 33);
            this.Back_BTN.TabIndex = 13;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Enabled = false;
            this.Submit_BTN.Location = new System.Drawing.Point(12, 557);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(363, 32);
            this.Submit_BTN.TabIndex = 12;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // Amount_TXT
            // 
            this.Amount_TXT.Enabled = false;
            this.Amount_TXT.Location = new System.Drawing.Point(234, 520);
            this.Amount_TXT.MaxLength = 5;
            this.Amount_TXT.Name = "Amount_TXT";
            this.Amount_TXT.Size = new System.Drawing.Size(141, 20);
            this.Amount_TXT.TabIndex = 11;
            // 
            // cTSDataSet
            // 
            this.cTSDataSet.DataSetName = "CTSDataSet";
            this.cTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTSDataSetBindingSource
            // 
            this.cTSDataSetBindingSource.DataSource = this.cTSDataSet;
            this.cTSDataSetBindingSource.Position = 0;
            // 
            // cTSDataSetBindingSource1
            // 
            this.cTSDataSetBindingSource1.DataSource = this.cTSDataSet;
            this.cTSDataSetBindingSource1.Position = 0;
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
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 640);
            this.ControlBox = false;
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Amount_TXT);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PhoneNo_TXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BirthDate_TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccountUSD_TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NID_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerName_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardNo_TXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Application_CBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Product_CBox);
            this.Name = "Issue";
            this.Text = "الإصدار";
            this.Load += new System.EventHandler(this.Issue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch_system1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Product_CBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Application_CBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardNo_TXT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PhoneNo_TXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BirthDate_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AccountUSD_TXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NID_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerName_TXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Button Submit_BTN;
        private System.Windows.Forms.TextBox Amount_TXT;
        private System.Windows.Forms.BindingSource branchsystem1DataSetBindingSource;
        private Branch_system1DataSet branch_system1DataSet;
        private CTSDataSet cTSDataSet;
        private System.Windows.Forms.BindingSource cTSDataSetBindingSource;
        private System.Windows.Forms.BindingSource cTSDataSetBindingSource1;
        private CTSMain cTSMain;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private CTSMainTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}