namespace CTS.Screens.PTS.Issue
{
    partial class PTS_Issue
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
            this.productsTableAdapter = new CTS.CTSMainTableAdapters.ProductsTableAdapter();
            this.branch_system1DataSet = new CTS.Branch_system1DataSet();
            this.cTSDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cTSDataSet = new CTS.CTSDataSet();
            this.cTSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneNo_TXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NID_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_TXT = new System.Windows.Forms.TextBox();
            this.branchsystem1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTSMain = new CTS.CTSMain();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Account_TXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Product_CBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerID_TXT = new System.Windows.Forms.TextBox();
            this.Birthdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CountryPhoneCode_CBox = new System.Windows.Forms.ComboBox();
            this.Nationality_CBOX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.branch_system1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // branch_system1DataSet
            // 
            this.branch_system1DataSet.DataSetName = "Branch_system1DataSet";
            this.branch_system1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTSDataSetBindingSource1
            // 
            this.cTSDataSetBindingSource1.DataSource = this.cTSDataSet;
            this.cTSDataSetBindingSource1.Position = 0;
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
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(20, 598);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(363, 33);
            this.Back_BTN.TabIndex = 55;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Enabled = false;
            this.Submit_BTN.Location = new System.Drawing.Point(20, 560);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(363, 32);
            this.Submit_BTN.TabIndex = 54;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "Passport Number";
            // 
            // Passport
            // 
            this.Passport.Enabled = false;
            this.Passport.Location = new System.Drawing.Point(20, 320);
            this.Passport.MaxLength = 8;
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(126, 20);
            this.Passport.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Phone Number";
            // 
            // PhoneNo_TXT
            // 
            this.PhoneNo_TXT.Enabled = false;
            this.PhoneNo_TXT.Location = new System.Drawing.Point(155, 372);
            this.PhoneNo_TXT.MaxLength = 10;
            this.PhoneNo_TXT.Name = "PhoneNo_TXT";
            this.PhoneNo_TXT.Size = new System.Drawing.Size(141, 20);
            this.PhoneNo_TXT.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "National ID";
            // 
            // NID_TXT
            // 
            this.NID_TXT.Enabled = false;
            this.NID_TXT.Location = new System.Drawing.Point(155, 267);
            this.NID_TXT.MaxLength = 12;
            this.NID_TXT.Name = "NID_TXT";
            this.NID_TXT.Size = new System.Drawing.Size(141, 20);
            this.NID_TXT.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Name";
            // 
            // Name_TXT
            // 
            this.Name_TXT.Enabled = false;
            this.Name_TXT.Location = new System.Drawing.Point(20, 183);
            this.Name_TXT.MaxLength = 25;
            this.Name_TXT.Name = "Name_TXT";
            this.Name_TXT.Size = new System.Drawing.Size(233, 20);
            this.Name_TXT.TabIndex = 48;
            // 
            // branchsystem1DataSetBindingSource
            // 
            this.branchsystem1DataSetBindingSource.DataSource = this.branch_system1DataSet;
            this.branchsystem1DataSetBindingSource.Position = 0;
            // 
            // cTSMain
            // 
            this.cTSMain.DataSetName = "CTSMain";
            this.cTSMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.cTSMain;
            // 
            // Account_TXT
            // 
            this.Account_TXT.Enabled = false;
            this.Account_TXT.Location = new System.Drawing.Point(20, 135);
            this.Account_TXT.MaxLength = 15;
            this.Account_TXT.Name = "Account_TXT";
            this.Account_TXT.Size = new System.Drawing.Size(233, 20);
            this.Account_TXT.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Program";
            // 
            // Product_CBox
            // 
            this.Product_CBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Code", true));
            this.Product_CBox.FormattingEnabled = true;
            this.Product_CBox.Location = new System.Drawing.Point(20, 47);
            this.Product_CBox.Name = "Product_CBox";
            this.Product_CBox.Size = new System.Drawing.Size(209, 21);
            this.Product_CBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Program Account Number";
            // 
            // CustomerID_TXT
            // 
            this.CustomerID_TXT.Enabled = false;
            this.CustomerID_TXT.Location = new System.Drawing.Point(20, 87);
            this.CustomerID_TXT.MaxLength = 15;
            this.CustomerID_TXT.Name = "CustomerID_TXT";
            this.CustomerID_TXT.Size = new System.Drawing.Size(93, 20);
            this.CustomerID_TXT.TabIndex = 65;
            // 
            // Birthdate
            // 
            this.Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthdate.Location = new System.Drawing.Point(20, 222);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(93, 20);
            this.Birthdate.TabIndex = 67;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Exp Date";
            // 
            // CountryPhoneCode_CBox
            // 
            this.CountryPhoneCode_CBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Code", true));
            this.CountryPhoneCode_CBox.FormattingEnabled = true;
            this.CountryPhoneCode_CBox.Location = new System.Drawing.Point(20, 372);
            this.CountryPhoneCode_CBox.Name = "CountryPhoneCode_CBox";
            this.CountryPhoneCode_CBox.Size = new System.Drawing.Size(126, 21);
            this.CountryPhoneCode_CBox.TabIndex = 70;
            // 
            // Nationality_CBOX
            // 
            this.Nationality_CBOX.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Code", true));
            this.Nationality_CBOX.FormattingEnabled = true;
            this.Nationality_CBOX.Location = new System.Drawing.Point(20, 266);
            this.Nationality_CBOX.Name = "Nationality_CBOX";
            this.Nationality_CBOX.Size = new System.Drawing.Size(126, 21);
            this.Nationality_CBOX.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nationality";
            // 
            // PTS_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 779);
            this.Controls.Add(this.Nationality_CBOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CountryPhoneCode_CBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerID_TXT);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PhoneNo_TXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NID_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name_TXT);
            this.Controls.Add(this.Account_TXT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Product_CBox);
            this.Name = "PTS_Issue";
            this.Text = "PTS_Issue";
            this.Load += new System.EventHandler(this.PTS_Issue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branch_system1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTSMainTableAdapters.ProductsTableAdapter productsTableAdapter;
        private Branch_system1DataSet branch_system1DataSet;
        private System.Windows.Forms.BindingSource cTSDataSetBindingSource1;
        private CTSDataSet cTSDataSet;
        private System.Windows.Forms.BindingSource cTSDataSetBindingSource;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Button Submit_BTN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PhoneNo_TXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NID_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_TXT;
        private System.Windows.Forms.BindingSource branchsystem1DataSetBindingSource;
        private CTSMain cTSMain;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.TextBox Account_TXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Product_CBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerID_TXT;
        private System.Windows.Forms.DateTimePicker Birthdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CountryPhoneCode_CBox;
        private System.Windows.Forms.ComboBox Nationality_CBOX;
        private System.Windows.Forms.Label label3;
    }
}