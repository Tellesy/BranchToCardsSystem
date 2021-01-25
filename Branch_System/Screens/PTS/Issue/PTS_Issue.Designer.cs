namespace MPBS.Screens.PTS.Issue
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
            this.productsTableAdapter = new MPBS.CTSMainTableAdapters.ProductsTableAdapter();

            this.cTSDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cTSDataSet = new MPBS.CTSDataSet();
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
            this.FirstName_TXT = new System.Windows.Forms.TextBox();
            this.branchsystem1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTSMain = new MPBS.CTSMain();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainAccount_TXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Program_CBox = new System.Windows.Forms.ComboBox();
            this.pTSProgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTS_PTS_Programs = new MPBS.CTS_PTS_Programs();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerID_TXT = new System.Windows.Forms.TextBox();
            this.Birthdate = new System.Windows.Forms.DateTimePicker();
            this.PassportExpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CountryPhoneCode_CBox = new System.Windows.Forms.ComboBox();
            this.Nationality_CBOX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FatherName_TXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LastName_TXT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EmbossedName_TXT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ProgramAccount_TXT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Gender_CBOX = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Address_TXT = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Email_TXT = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.pTS_ProgramTableAdapter = new MPBS.CTS_PTS_ProgramsTableAdapters.PTS_ProgramTableAdapter();
            this.label31 = new System.Windows.Forms.Label();
            this.Email_CHBox = new System.Windows.Forms.CheckBox();

            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTSProgramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTS_PTS_Programs)).BeginInit();
            this.SuspendLayout();
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
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
            this.Back_BTN.Location = new System.Drawing.Point(387, 430);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(363, 33);
            this.Back_BTN.TabIndex = 26;
            this.Back_BTN.Text = "رجوع";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Enabled = false;
            this.Submit_BTN.Location = new System.Drawing.Point(387, 392);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(363, 32);
            this.Submit_BTN.TabIndex = 25;
            this.Submit_BTN.Text = "إضافة";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(405, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "Passport Number";
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(408, 135);
            this.Passport.MaxLength = 10;
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(166, 20);
            this.Passport.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Phone Number";
            // 
            // PhoneNo_TXT
            // 
            this.PhoneNo_TXT.Location = new System.Drawing.Point(494, 249);
            this.PhoneNo_TXT.MaxLength = 9;
            this.PhoneNo_TXT.Name = "PhoneNo_TXT";
            this.PhoneNo_TXT.Size = new System.Drawing.Size(141, 20);
            this.PhoneNo_TXT.TabIndex = 17;
            this.PhoneNo_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_ONLY_NUMBER_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 392);
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
            this.label5.Location = new System.Drawing.Point(575, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "National ID";
            // 
            // NID_TXT
            // 
            this.NID_TXT.Location = new System.Drawing.Point(580, 87);
            this.NID_TXT.MaxLength = 12;
            this.NID_TXT.Name = "NID_TXT";
            this.NID_TXT.Size = new System.Drawing.Size(170, 20);
            this.NID_TXT.TabIndex = 12;
            this.NID_TXT.TextChanged += new System.EventHandler(this.NID_TXT_TextChanged);
            this.NID_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_ONLY_NUMBER_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "First Name";
            // 
            // FirstName_TXT
            // 
            this.FirstName_TXT.Location = new System.Drawing.Point(20, 250);
            this.FirstName_TXT.MaxLength = 25;
            this.FirstName_TXT.Name = "FirstName_TXT";
            this.FirstName_TXT.Size = new System.Drawing.Size(93, 20);
            this.FirstName_TXT.TabIndex = 5;
            this.FirstName_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_ONLY_CHAR_KeyPress);
            this.FirstName_TXT.Leave += new System.EventHandler(this.TEXTB_Leave);
            // 
            // branchsystem1DataSetBindingSource
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
            // MainAccount_TXT
            // 
            this.MainAccount_TXT.Location = new System.Drawing.Point(20, 135);
            this.MainAccount_TXT.MaxLength = 15;
            this.MainAccount_TXT.Name = "MainAccount_TXT";
            this.MainAccount_TXT.Size = new System.Drawing.Size(233, 20);
            this.MainAccount_TXT.TabIndex = 3;
            this.MainAccount_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_ONLY_NUMBER_KeyPress);
            this.MainAccount_TXT.Leave += new System.EventHandler(this.TextBox_Leave);
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
            // Program_CBox
            // 
            this.Program_CBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pTSProgramBindingSource, "program_code", true));
            this.Program_CBox.FormattingEnabled = true;
            this.Program_CBox.Location = new System.Drawing.Point(20, 47);
            this.Program_CBox.Name = "Program_CBox";
            this.Program_CBox.Size = new System.Drawing.Size(209, 21);
            this.Program_CBox.TabIndex = 1;
            // 
            // pTSProgramBindingSource
            // 
            this.pTSProgramBindingSource.DataMember = "PTS_Program";
            this.pTSProgramBindingSource.DataSource = this.cTS_PTS_Programs;
            // 
            // cTS_PTS_Programs
            // 
            this.cTS_PTS_Programs.DataSetName = "CTS_PTS_Programs";
            this.cTS_PTS_Programs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Main LYD Account Number";
            // 
            // CustomerID_TXT
            // 
            this.CustomerID_TXT.Location = new System.Drawing.Point(20, 87);
            this.CustomerID_TXT.MaxLength = 7;
            this.CustomerID_TXT.Name = "CustomerID_TXT";
            this.CustomerID_TXT.Size = new System.Drawing.Size(93, 20);
            this.CustomerID_TXT.TabIndex = 2;
            this.CustomerID_TXT.TextChanged += new System.EventHandler(this.CustomerID_TXT_TextChanged);
            this.CustomerID_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_ONLY_NUMBER_KeyPress);
            this.CustomerID_TXT.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // Birthdate
            // 
            this.Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthdate.Location = new System.Drawing.Point(20, 408);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(114, 20);
            this.Birthdate.TabIndex = 10;
            this.Birthdate.ValueChanged += new System.EventHandler(this.Birthdate_ValueChanged);
            // 
            // PassportExpDate
            // 
            this.PassportExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PassportExpDate.Location = new System.Drawing.Point(580, 135);
            this.PassportExpDate.Name = "PassportExpDate";
            this.PassportExpDate.Size = new System.Drawing.Size(170, 20);
            this.PassportExpDate.TabIndex = 14;
            this.PassportExpDate.ValueChanged += new System.EventHandler(this.PassportExpDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Exp Date";
            // 
            // CountryPhoneCode_CBox
            // 
            this.CountryPhoneCode_CBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Code", true));
            this.CountryPhoneCode_CBox.FormattingEnabled = true;
            this.CountryPhoneCode_CBox.Location = new System.Drawing.Point(410, 249);
            this.CountryPhoneCode_CBox.Name = "CountryPhoneCode_CBox";
            this.CountryPhoneCode_CBox.Size = new System.Drawing.Size(75, 21);
            this.CountryPhoneCode_CBox.TabIndex = 16;
            // 
            // Nationality_CBOX
            // 
            this.Nationality_CBOX.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Code", true));
            this.Nationality_CBOX.FormattingEnabled = true;
            this.Nationality_CBOX.Items.AddRange(new object[] {
            "434"});
            this.Nationality_CBOX.Location = new System.Drawing.Point(408, 86);
            this.Nationality_CBOX.Name = "Nationality_CBOX";
            this.Nationality_CBOX.Size = new System.Drawing.Size(166, 21);
            this.Nationality_CBOX.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nationality";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Father Name";
            // 
            // FatherName_TXT
            // 
            this.FatherName_TXT.Location = new System.Drawing.Point(124, 250);
            this.FatherName_TXT.MaxLength = 25;
            this.FatherName_TXT.Name = "FatherName_TXT";
            this.FatherName_TXT.Size = new System.Drawing.Size(99, 20);
            this.FatherName_TXT.TabIndex = 6;
            this.FatherName_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_ONLY_CHAR_KeyPress);
            this.FatherName_TXT.Leave += new System.EventHandler(this.TEXTB_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Last Name";
            // 
            // LastName_TXT
            // 
            this.LastName_TXT.Location = new System.Drawing.Point(238, 250);
            this.LastName_TXT.MaxLength = 25;
            this.LastName_TXT.Name = "LastName_TXT";
            this.LastName_TXT.Size = new System.Drawing.Size(106, 20);
            this.LastName_TXT.TabIndex = 7;
            this.LastName_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_ONLY_CHAR_KeyPress);
            this.LastName_TXT.Leave += new System.EventHandler(this.TEXTB_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "Embossed Name";
            // 
            // EmbossedName_TXT
            // 
            this.EmbossedName_TXT.Location = new System.Drawing.Point(20, 306);
            this.EmbossedName_TXT.MaxLength = 25;
            this.EmbossedName_TXT.Name = "EmbossedName_TXT";
            this.EmbossedName_TXT.Size = new System.Drawing.Size(203, 20);
            this.EmbossedName_TXT.TabIndex = 8;
            this.EmbossedName_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_ONLY_CHAR_KeyPress);
            this.EmbossedName_TXT.Leave += new System.EventHandler(this.TEXTB_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Program Account Number";
            // 
            // ProgramAccount_TXT
            // 
            this.ProgramAccount_TXT.Location = new System.Drawing.Point(20, 193);
            this.ProgramAccount_TXT.MaxLength = 15;
            this.ProgramAccount_TXT.Name = "ProgramAccount_TXT";
            this.ProgramAccount_TXT.Size = new System.Drawing.Size(233, 20);
            this.ProgramAccount_TXT.TabIndex = 4;
            this.ProgramAccount_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_ONLY_NUMBER_KeyPress);
            this.ProgramAccount_TXT.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(195, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 81;
            this.label15.Text = "المنتج";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(81, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 82;
            this.label16.Text = "رقم الزبون";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(172, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 13);
            this.label17.TabIndex = 83;
            this.label17.Text = "رقم الحساب الأساسي (دينار ليبي)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(202, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 13);
            this.label18.TabIndex = 84;
            this.label18.Text = "رقم الحساب الخاص بالمنتج ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(527, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 85;
            this.label19.Text = "الجنسية";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(685, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 86;
            this.label20.Text = "الرقم الوطني";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(557, 234);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 13);
            this.label21.TabIndex = 87;
            this.label21.Text = "رقم الهاتف (نقال)";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 342);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 13);
            this.label22.TabIndex = 88;
            this.label22.Text = "Gender";
            // 
            // Gender_CBOX
            // 
            this.Gender_CBOX.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Code", true));
            this.Gender_CBOX.FormattingEnabled = true;
            this.Gender_CBOX.ItemHeight = 13;
            this.Gender_CBOX.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Gender_CBOX.Location = new System.Drawing.Point(20, 358);
            this.Gender_CBOX.Name = "Gender_CBOX";
            this.Gender_CBOX.Size = new System.Drawing.Size(75, 21);
            this.Gender_CBOX.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(81, 342);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 90;
            this.label23.Text = "الجنس";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(73, 392);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 13);
            this.label24.TabIndex = 91;
            this.label24.Text = "تاريخ الميلاد";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(405, 177);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 13);
            this.label27.TabIndex = 93;
            this.label27.Text = "Address";
            // 
            // Address_TXT
            // 
            this.Address_TXT.Location = new System.Drawing.Point(410, 193);
            this.Address_TXT.MaxLength = 25;
            this.Address_TXT.Name = "Address_TXT";
            this.Address_TXT.Size = new System.Drawing.Size(340, 20);
            this.Address_TXT.TabIndex = 15;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(711, 177);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 13);
            this.label28.TabIndex = 97;
            this.label28.Text = "العنوان";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(668, 290);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 13);
            this.label25.TabIndex = 99;
            this.label25.Text = "البريد الإلكتروني";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Email_TXT
            // 
            this.Email_TXT.Enabled = false;
            this.Email_TXT.Location = new System.Drawing.Point(529, 305);
            this.Email_TXT.MaxLength = 50;
            this.Email_TXT.Name = "Email_TXT";
            this.Email_TXT.Size = new System.Drawing.Size(221, 20);
            this.Email_TXT.TabIndex = 18;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(407, 290);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 13);
            this.label26.TabIndex = 100;
            this.label26.Text = "Email";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(499, 119);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 13);
            this.label29.TabIndex = 101;
            this.label29.Text = "رقم جواز السفر";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(647, 119);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(103, 13);
            this.label30.TabIndex = 102;
            this.label30.Text = "تاريخ انتهاء الصلاحية";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pTS_ProgramTableAdapter
            // 
            this.pTS_ProgramTableAdapter.ClearBeforeFill = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(124, 290);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 13);
            this.label31.TabIndex = 103;
            this.label31.Text = "الإسم على البطاقة";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Email_CHBox
            // 
            this.Email_CHBox.AutoSize = true;
            this.Email_CHBox.Location = new System.Drawing.Point(410, 309);
            this.Email_CHBox.Name = "Email_CHBox";
            this.Email_CHBox.Size = new System.Drawing.Size(90, 17);
            this.Email_CHBox.TabIndex = 104;
            this.Email_CHBox.Text = "تفعيل الرسائل";
            this.Email_CHBox.UseVisualStyleBackColor = true;
            this.Email_CHBox.CheckedChanged += new System.EventHandler(this.Email_CHBox_CheckedChanged);
            // 
            // Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 549);
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
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ProgramAccount_TXT);
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
            this.Controls.Add(this.FirstName_TXT);
            this.Controls.Add(this.MainAccount_TXT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Program_CBox);
            this.Name = "Issue";
            this.Text = "PTS_Issue";
            this.Load += new System.EventHandler(this.PTS_Issue_Load);

            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchsystem1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTSMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTSProgramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTS_PTS_Programs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTSMainTableAdapters.ProductsTableAdapter productsTableAdapter;
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
        private System.Windows.Forms.TextBox FirstName_TXT;
        private System.Windows.Forms.BindingSource branchsystem1DataSetBindingSource;
        private CTSMain cTSMain;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.TextBox MainAccount_TXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Program_CBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerID_TXT;
        private System.Windows.Forms.DateTimePicker Birthdate;
        private System.Windows.Forms.DateTimePicker PassportExpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CountryPhoneCode_CBox;
        private System.Windows.Forms.ComboBox Nationality_CBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FatherName_TXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LastName_TXT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmbossedName_TXT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ProgramAccount_TXT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox Gender_CBOX;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox Address_TXT;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Email_TXT;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private CTS_PTS_Programs cTS_PTS_Programs;
        private System.Windows.Forms.BindingSource pTSProgramBindingSource;
        private CTS_PTS_ProgramsTableAdapters.PTS_ProgramTableAdapter pTS_ProgramTableAdapter;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox Email_CHBox;
    }
}