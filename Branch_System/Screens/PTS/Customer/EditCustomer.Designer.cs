namespace MPBS.Screens.PTS.Customer
{
    partial class EditCustomer
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
            this.Email_CHBox = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Email_TXT = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Address_TXT = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Gender_CBOX = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTSMain = new MPBS.CTSMain();
            this.label22 = new System.Windows.Forms.Label();
            this.pTS_ProgramTableAdapter = new MPBS.CTS_PTS_ProgramsTableAdapters.PTS_ProgramTableAdapter();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EmbossedName_TXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LastName_TXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FatherName_TXT = new System.Windows.Forms.TextBox();
            this.Nationality_CBOX = new System.Windows.Forms.ComboBox();
            this.productsTableAdapter = new MPBS.CTSMainTableAdapters.ProductsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.branch_system1DataSet = new MPBS.Branch_system1DataSet();
            this.cTSDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cTSDataSet = new MPBS.CTSDataSet();
            this.cTSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CountryPhoneCode_CBox = new System.Windows.Forms.ComboBox();
            this.branchsystem1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.PassportExpDate = new System.Windows.Forms.DateTimePicker();
            this.Birthdate = new System.Windows.Forms.DateTimePicker();
            this.CustomerID_TXT = new System.Windows.Forms.TextBox();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneNo_TXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NID_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cTS_PTS_Programs = new MPBS.CTS_PTS_Programs();
            this.FirstName_TXT = new System.Windows.Forms.TextBox();
            this.pTSProgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch_system1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTS_PTS_Programs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTSProgramBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Email_CHBox
            // 
            this.Email_CHBox.AutoSize = true;
            this.Email_CHBox.Location = new System.Drawing.Point(413, 292);
            this.Email_CHBox.Name = "Email_CHBox";
            this.Email_CHBox.Size = new System.Drawing.Size(90, 17);
            this.Email_CHBox.TabIndex = 156;
            this.Email_CHBox.Text = "تفعيل الرسائل";
            this.Email_CHBox.UseVisualStyleBackColor = true;
            this.Email_CHBox.CheckedChanged += new System.EventHandler(this.Email_CHBox_CheckedChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(127, 158);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 13);
            this.label31.TabIndex = 155;
            this.label31.Text = "الإسم على البطاقة";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(650, 102);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(103, 13);
            this.label30.TabIndex = 154;
            this.label30.Text = "تاريخ انتهاء الصلاحية";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(502, 102);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 13);
            this.label29.TabIndex = 153;
            this.label29.Text = "رقم جواز السفر";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(410, 273);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 13);
            this.label26.TabIndex = 152;
            this.label26.Text = "Email";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(671, 273);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 13);
            this.label25.TabIndex = 151;
            this.label25.Text = "البريد الإلكتروني";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Email_TXT
            // 
            this.Email_TXT.Enabled = false;
            this.Email_TXT.Location = new System.Drawing.Point(532, 288);
            this.Email_TXT.MaxLength = 50;
            this.Email_TXT.Name = "Email_TXT";
            this.Email_TXT.Size = new System.Drawing.Size(221, 20);
            this.Email_TXT.TabIndex = 122;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(714, 160);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 13);
            this.label28.TabIndex = 150;
            this.label28.Text = "العنوان";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(408, 160);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 13);
            this.label27.TabIndex = 149;
            this.label27.Text = "Address";
            // 
            // Address_TXT
            // 
            this.Address_TXT.Location = new System.Drawing.Point(413, 176);
            this.Address_TXT.MaxLength = 25;
            this.Address_TXT.Name = "Address_TXT";
            this.Address_TXT.Size = new System.Drawing.Size(340, 20);
            this.Address_TXT.TabIndex = 119;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(76, 260);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 13);
            this.label24.TabIndex = 148;
            this.label24.Text = "تاريخ الميلاد";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(84, 210);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 147;
            this.label23.Text = "الجنس";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Gender_CBOX
            // 
            this.Gender_CBOX.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Code", true));
            this.Gender_CBOX.FormattingEnabled = true;
            this.Gender_CBOX.ItemHeight = 13;
            this.Gender_CBOX.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Gender_CBOX.Location = new System.Drawing.Point(23, 226);
            this.Gender_CBOX.Name = "Gender_CBOX";
            this.Gender_CBOX.Size = new System.Drawing.Size(75, 21);
            this.Gender_CBOX.TabIndex = 113;
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
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 210);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 13);
            this.label22.TabIndex = 146;
            this.label22.Text = "Gender";
            // 
            // pTS_ProgramTableAdapter
            // 
            this.pTS_ProgramTableAdapter.ClearBeforeFill = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(560, 217);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 13);
            this.label21.TabIndex = 145;
            this.label21.Text = "رقم الهاتف (نقال)";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(688, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 144;
            this.label20.Text = "الرقم الوطني";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(530, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 143;
            this.label19.Text = "الجنسية";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 137;
            this.label12.Text = "Embossed Name";
            // 
            // EmbossedName_TXT
            // 
            this.EmbossedName_TXT.Location = new System.Drawing.Point(23, 174);
            this.EmbossedName_TXT.MaxLength = 25;
            this.EmbossedName_TXT.Name = "EmbossedName_TXT";
            this.EmbossedName_TXT.Size = new System.Drawing.Size(203, 20);
            this.EmbossedName_TXT.TabIndex = 112;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 136;
            this.label10.Text = "Last Name";
            // 
            // LastName_TXT
            // 
            this.LastName_TXT.Location = new System.Drawing.Point(241, 118);
            this.LastName_TXT.MaxLength = 25;
            this.LastName_TXT.Name = "LastName_TXT";
            this.LastName_TXT.Size = new System.Drawing.Size(106, 20);
            this.LastName_TXT.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 135;
            this.label9.Text = "Father Name";
            // 
            // FatherName_TXT
            // 
            this.FatherName_TXT.Location = new System.Drawing.Point(127, 118);
            this.FatherName_TXT.MaxLength = 25;
            this.FatherName_TXT.Name = "FatherName_TXT";
            this.FatherName_TXT.Size = new System.Drawing.Size(99, 20);
            this.FatherName_TXT.TabIndex = 110;
            // 
            // Nationality_CBOX
            // 
            this.Nationality_CBOX.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Code", true));
            this.Nationality_CBOX.FormattingEnabled = true;
            this.Nationality_CBOX.Items.AddRange(new object[] {
            "434"});
            this.Nationality_CBOX.Location = new System.Drawing.Point(411, 69);
            this.Nationality_CBOX.Name = "Nationality_CBOX";
            this.Nationality_CBOX.Size = new System.Drawing.Size(166, 21);
            this.Nationality_CBOX.TabIndex = 115;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 134;
            this.label3.Text = "Nationality";
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
            // CountryPhoneCode_CBox
            // 
            this.CountryPhoneCode_CBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Code", true));
            this.CountryPhoneCode_CBox.FormattingEnabled = true;
            this.CountryPhoneCode_CBox.Location = new System.Drawing.Point(413, 232);
            this.CountryPhoneCode_CBox.Name = "CountryPhoneCode_CBox";
            this.CountryPhoneCode_CBox.Size = new System.Drawing.Size(75, 21);
            this.CountryPhoneCode_CBox.TabIndex = 120;
            // 
            // branchsystem1DataSetBindingSource
            // 
            this.branchsystem1DataSetBindingSource.DataSource = this.branch_system1DataSet;
            this.branchsystem1DataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 133;
            this.label2.Text = "Exp Date";
            // 
            // PassportExpDate
            // 
            this.PassportExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PassportExpDate.Location = new System.Drawing.Point(583, 118);
            this.PassportExpDate.Name = "PassportExpDate";
            this.PassportExpDate.Size = new System.Drawing.Size(170, 20);
            this.PassportExpDate.TabIndex = 118;
            // 
            // Birthdate
            // 
            this.Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthdate.Location = new System.Drawing.Point(23, 276);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(114, 20);
            this.Birthdate.TabIndex = 114;
            // 
            // CustomerID_TXT
            // 
            this.CustomerID_TXT.Location = new System.Drawing.Point(23, 70);
            this.CustomerID_TXT.MaxLength = 7;
            this.CustomerID_TXT.Name = "CustomerID_TXT";
            this.CustomerID_TXT.Size = new System.Drawing.Size(93, 20);
            this.CustomerID_TXT.TabIndex = 106;
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(390, 413);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(363, 33);
            this.Back_BTN.TabIndex = 124;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Location = new System.Drawing.Point(390, 375);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(363, 32);
            this.Submit_BTN.TabIndex = 123;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(408, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 131;
            this.label14.Text = "Passport Number";
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(411, 118);
            this.Passport.MaxLength = 10;
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(166, 20);
            this.Passport.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 130;
            this.label8.Text = "Phone Number";
            // 
            // PhoneNo_TXT
            // 
            this.PhoneNo_TXT.Location = new System.Drawing.Point(497, 232);
            this.PhoneNo_TXT.MaxLength = 9;
            this.PhoneNo_TXT.Name = "PhoneNo_TXT";
            this.PhoneNo_TXT.Size = new System.Drawing.Size(141, 20);
            this.PhoneNo_TXT.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 129;
            this.label7.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 127;
            this.label5.Text = "National ID";
            // 
            // NID_TXT
            // 
            this.NID_TXT.Location = new System.Drawing.Point(583, 70);
            this.NID_TXT.MaxLength = 12;
            this.NID_TXT.Name = "NID_TXT";
            this.NID_TXT.Size = new System.Drawing.Size(170, 20);
            this.NID_TXT.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "First Name";
            // 
            // cTS_PTS_Programs
            // 
            this.cTS_PTS_Programs.DataSetName = "CTS_PTS_Programs";
            this.cTS_PTS_Programs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FirstName_TXT
            // 
            this.FirstName_TXT.Location = new System.Drawing.Point(23, 118);
            this.FirstName_TXT.MaxLength = 25;
            this.FirstName_TXT.Name = "FirstName_TXT";
            this.FirstName_TXT.Size = new System.Drawing.Size(93, 20);
            this.FirstName_TXT.TabIndex = 109;
            // 
            // pTSProgramBindingSource
            // 
            this.pTSProgramBindingSource.DataMember = "PTS_Program";
            this.pTSProgramBindingSource.DataSource = this.cTS_PTS_Programs;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 128;
            this.label6.Text = "Customer ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(84, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 140;
            this.label16.Text = "رقم الزبون";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 539);
            this.Controls.Add(this.Email_CHBox);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.Email_TXT);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.Address_TXT);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Gender_CBOX);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EmbossedName_TXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LastName_TXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FatherName_TXT);
            this.Controls.Add(this.Nationality_CBOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CountryPhoneCode_CBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassportExpDate);
            this.Controls.Add(this.Birthdate);
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
            this.Controls.Add(this.FirstName_TXT);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch_system1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTS_PTS_Programs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTSProgramBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Email_CHBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Email_TXT;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox Address_TXT;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox Gender_CBOX;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private CTSMain cTSMain;
        private System.Windows.Forms.Label label22;
        private CTS_PTS_ProgramsTableAdapters.PTS_ProgramTableAdapter pTS_ProgramTableAdapter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmbossedName_TXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LastName_TXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FatherName_TXT;
        private System.Windows.Forms.ComboBox Nationality_CBOX;
        private CTSMainTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Label label3;
        private Branch_system1DataSet branch_system1DataSet;
        private System.Windows.Forms.BindingSource cTSDataSetBindingSource1;
        private CTSDataSet cTSDataSet;
        private System.Windows.Forms.BindingSource cTSDataSetBindingSource;
        private System.Windows.Forms.ComboBox CountryPhoneCode_CBox;
        private System.Windows.Forms.BindingSource branchsystem1DataSetBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PassportExpDate;
        private System.Windows.Forms.DateTimePicker Birthdate;
        private System.Windows.Forms.TextBox CustomerID_TXT;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Button Submit_BTN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PhoneNo_TXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NID_TXT;
        private System.Windows.Forms.Label label4;
        private CTS_PTS_Programs cTS_PTS_Programs;
        private System.Windows.Forms.TextBox FirstName_TXT;
        private System.Windows.Forms.BindingSource pTSProgramBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
    }
}