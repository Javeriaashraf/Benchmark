namespace CsharpSqlserver2
{
    partial class FormPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrint));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RecieptNo = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.FatherName = new System.Windows.Forms.Label();
            this.Programme = new System.Windows.Forms.Label();
            this.GRNo = new System.Windows.Forms.Label();
            this.RecieptNoText = new System.Windows.Forms.Label();
            this.DateText = new System.Windows.Forms.Label();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testdb1DataSet1 = new CsharpSqlserver2.testdb1DataSet1();
            this.StudentNameText = new System.Windows.Forms.Label();
            this.registrationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FatherNameText = new System.Windows.Forms.Label();
            this.ProgrammeText = new System.Windows.Forms.Label();
            this.registrationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.GRNoText = new System.Windows.Forms.Label();
            this.registrationBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AdmissionFee = new System.Windows.Forms.Label();
            this.SecurityDeposit = new System.Windows.Forms.Label();
            this.MonthlyFee = new System.Windows.Forms.Label();
            this.CertificateFee = new System.Windows.Forms.Label();
            this.ExamFee = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.AdmissionFeeText = new System.Windows.Forms.Label();
            this.registrationBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.MonthlyFeeText = new System.Windows.Forms.Label();
            this.registrationBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.CertificateFeeText = new System.Windows.Forms.Label();
            this.registrationBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.ExamFeeText = new System.Windows.Forms.Label();
            this.registrationBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.TotalText = new System.Windows.Forms.Label();
            this.registrationBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.SecurityDepositText = new System.Windows.Forms.Label();
            this.registrationTableAdapter = new CsharpSqlserver2.testdb1DataSet1TableAdapters.RegistrationTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdb1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource4)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource9)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.9863F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0137F));
            this.tableLayoutPanel1.Controls.Add(this.RecieptNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Date, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StudentName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FatherName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Programme, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.GRNo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.RecieptNoText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DateText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.StudentNameText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FatherNameText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ProgrammeText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.GRNoText, 1, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 241);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // RecieptNo
            // 
            this.RecieptNo.AutoSize = true;
            this.RecieptNo.Location = new System.Drawing.Point(5, 2);
            this.RecieptNo.Name = "RecieptNo";
            this.RecieptNo.Size = new System.Drawing.Size(79, 16);
            this.RecieptNo.TabIndex = 4;
            this.RecieptNo.Text = "Reciept No.";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(5, 41);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(37, 16);
            this.Date.TabIndex = 5;
            this.Date.Text = "Date";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(5, 81);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(93, 16);
            this.StudentName.TabIndex = 6;
            this.StudentName.Text = "Student Name";
            // 
            // FatherName
            // 
            this.FatherName.AutoSize = true;
            this.FatherName.Location = new System.Drawing.Point(5, 123);
            this.FatherName.Name = "FatherName";
            this.FatherName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FatherName.Size = new System.Drawing.Size(86, 16);
            this.FatherName.TabIndex = 7;
            this.FatherName.Text = "Father Name";
            // 
            // Programme
            // 
            this.Programme.AutoSize = true;
            this.Programme.Location = new System.Drawing.Point(5, 164);
            this.Programme.Name = "Programme";
            this.Programme.Size = new System.Drawing.Size(79, 16);
            this.Programme.TabIndex = 7;
            this.Programme.Text = "Programme";
            // 
            // GRNo
            // 
            this.GRNo.AutoSize = true;
            this.GRNo.Location = new System.Drawing.Point(5, 203);
            this.GRNo.Name = "GRNo";
            this.GRNo.Size = new System.Drawing.Size(55, 16);
            this.GRNo.TabIndex = 7;
            this.GRNo.Text = "GR. No.";
            // 
            // RecieptNoText
            // 
            this.RecieptNoText.AutoSize = true;
            this.RecieptNoText.Location = new System.Drawing.Point(122, 2);
            this.RecieptNoText.Name = "RecieptNoText";
            this.RecieptNoText.Size = new System.Drawing.Size(45, 16);
            this.RecieptNoText.TabIndex = 8;
            this.RecieptNoText.Text = "label7";
            // 
            // DateText
            // 
            this.DateText.AutoSize = true;
            this.DateText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "AdmissionDate", true));
            this.DateText.Location = new System.Drawing.Point(122, 41);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(45, 16);
            this.DateText.TabIndex = 9;
            this.DateText.Text = "label8";
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.testdb1DataSet1;
            // 
            // testdb1DataSet1
            // 
            this.testdb1DataSet1.DataSetName = "testdb1DataSet1";
            this.testdb1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentNameText
            // 
            this.StudentNameText.AutoSize = true;
            this.StudentNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource1, "StudentName", true));
            this.StudentNameText.Location = new System.Drawing.Point(122, 81);
            this.StudentNameText.Name = "StudentNameText";
            this.StudentNameText.Size = new System.Drawing.Size(45, 16);
            this.StudentNameText.TabIndex = 10;
            this.StudentNameText.Text = "label9";
            // 
            // registrationBindingSource1
            // 
            this.registrationBindingSource1.DataMember = "Registration";
            this.registrationBindingSource1.DataSource = this.testdb1DataSet1;
            // 
            // FatherNameText
            // 
            this.FatherNameText.AutoSize = true;
            this.FatherNameText.Location = new System.Drawing.Point(122, 123);
            this.FatherNameText.Name = "FatherNameText";
            this.FatherNameText.Size = new System.Drawing.Size(52, 16);
            this.FatherNameText.TabIndex = 11;
            this.FatherNameText.Text = "label10";
            // 
            // ProgrammeText
            // 
            this.ProgrammeText.AutoSize = true;
            this.ProgrammeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource3, "Program", true));
            this.ProgrammeText.Location = new System.Drawing.Point(122, 164);
            this.ProgrammeText.Name = "ProgrammeText";
            this.ProgrammeText.Size = new System.Drawing.Size(52, 16);
            this.ProgrammeText.TabIndex = 12;
            this.ProgrammeText.Text = "label11";
            // 
            // registrationBindingSource3
            // 
            this.registrationBindingSource3.DataMember = "Registration";
            this.registrationBindingSource3.DataSource = this.testdb1DataSet1;
            // 
            // GRNoText
            // 
            this.GRNoText.AutoSize = true;
            this.GRNoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource4, "GR_No", true));
            this.GRNoText.Location = new System.Drawing.Point(122, 203);
            this.GRNoText.Name = "GRNoText";
            this.GRNoText.Size = new System.Drawing.Size(52, 16);
            this.GRNoText.TabIndex = 13;
            this.GRNoText.Text = "label12";
            // 
            // registrationBindingSource4
            // 
            this.registrationBindingSource4.DataMember = "Registration";
            this.registrationBindingSource4.DataSource = this.testdb1DataSet1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.9863F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0137F));
            this.tableLayoutPanel2.Controls.Add(this.AdmissionFee, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SecurityDeposit, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MonthlyFee, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CertificateFee, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ExamFee, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Total, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.AdmissionFeeText, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MonthlyFeeText, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.CertificateFeeText, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.ExamFeeText, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TotalText, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.SecurityDepositText, 1, 1);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(365, 95);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.35065F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.64935F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(334, 241);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // AdmissionFee
            // 
            this.AdmissionFee.AutoSize = true;
            this.AdmissionFee.Location = new System.Drawing.Point(5, 2);
            this.AdmissionFee.Name = "AdmissionFee";
            this.AdmissionFee.Size = new System.Drawing.Size(98, 16);
            this.AdmissionFee.TabIndex = 4;
            this.AdmissionFee.Text = "Admission Fee";
            // 
            // SecurityDeposit
            // 
            this.SecurityDeposit.AutoSize = true;
            this.SecurityDeposit.Location = new System.Drawing.Point(5, 41);
            this.SecurityDeposit.Name = "SecurityDeposit";
            this.SecurityDeposit.Size = new System.Drawing.Size(106, 16);
            this.SecurityDeposit.TabIndex = 5;
            this.SecurityDeposit.Text = "Security Deposit";
            // 
            // MonthlyFee
            // 
            this.MonthlyFee.AutoSize = true;
            this.MonthlyFee.Location = new System.Drawing.Point(5, 80);
            this.MonthlyFee.Name = "MonthlyFee";
            this.MonthlyFee.Size = new System.Drawing.Size(72, 32);
            this.MonthlyFee.TabIndex = 6;
            this.MonthlyFee.Text = "Tution Fee\r\n(month)";
            // 
            // CertificateFee
            // 
            this.CertificateFee.AutoSize = true;
            this.CertificateFee.Location = new System.Drawing.Point(5, 120);
            this.CertificateFee.Name = "CertificateFee";
            this.CertificateFee.Size = new System.Drawing.Size(94, 16);
            this.CertificateFee.TabIndex = 7;
            this.CertificateFee.Text = "Certificate Fee";
            // 
            // ExamFee
            // 
            this.ExamFee.AutoSize = true;
            this.ExamFee.Location = new System.Drawing.Point(5, 162);
            this.ExamFee.Name = "ExamFee";
            this.ExamFee.Size = new System.Drawing.Size(108, 16);
            this.ExamFee.TabIndex = 7;
            this.ExamFee.Text = "Examination Fee";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(5, 203);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(39, 16);
            this.Total.TabIndex = 7;
            this.Total.Text = "Total";
            // 
            // AdmissionFeeText
            // 
            this.AdmissionFeeText.AutoSize = true;
            this.AdmissionFeeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource5, "AdmissionFeeAmount", true));
            this.AdmissionFeeText.Location = new System.Drawing.Point(128, 2);
            this.AdmissionFeeText.Name = "AdmissionFeeText";
            this.AdmissionFeeText.Size = new System.Drawing.Size(52, 16);
            this.AdmissionFeeText.TabIndex = 8;
            this.AdmissionFeeText.Text = "label19";
            // 
            // registrationBindingSource5
            // 
            this.registrationBindingSource5.DataMember = "Registration";
            this.registrationBindingSource5.DataSource = this.testdb1DataSet1;
            // 
            // MonthlyFeeText
            // 
            this.MonthlyFeeText.AutoSize = true;
            this.MonthlyFeeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource6, "MonthlyFeeAmount", true));
            this.MonthlyFeeText.Location = new System.Drawing.Point(128, 80);
            this.MonthlyFeeText.Name = "MonthlyFeeText";
            this.MonthlyFeeText.Size = new System.Drawing.Size(52, 16);
            this.MonthlyFeeText.TabIndex = 10;
            this.MonthlyFeeText.Text = "label21";
            // 
            // registrationBindingSource6
            // 
            this.registrationBindingSource6.DataMember = "Registration";
            this.registrationBindingSource6.DataSource = this.testdb1DataSet1;
            // 
            // CertificateFeeText
            // 
            this.CertificateFeeText.AutoSize = true;
            this.CertificateFeeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource7, "CertifucateFeeAmount", true));
            this.CertificateFeeText.Location = new System.Drawing.Point(128, 120);
            this.CertificateFeeText.Name = "CertificateFeeText";
            this.CertificateFeeText.Size = new System.Drawing.Size(52, 16);
            this.CertificateFeeText.TabIndex = 11;
            this.CertificateFeeText.Text = "label22";
            // 
            // registrationBindingSource7
            // 
            this.registrationBindingSource7.DataMember = "Registration";
            this.registrationBindingSource7.DataSource = this.testdb1DataSet1;
            // 
            // ExamFeeText
            // 
            this.ExamFeeText.AutoSize = true;
            this.ExamFeeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource8, "ExaminationFeeAmount", true));
            this.ExamFeeText.Location = new System.Drawing.Point(128, 162);
            this.ExamFeeText.Name = "ExamFeeText";
            this.ExamFeeText.Size = new System.Drawing.Size(52, 16);
            this.ExamFeeText.TabIndex = 12;
            this.ExamFeeText.Text = "label23";
            // 
            // registrationBindingSource8
            // 
            this.registrationBindingSource8.DataMember = "Registration";
            this.registrationBindingSource8.DataSource = this.testdb1DataSet1;
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource9, "TotalFeeAmount", true));
            this.TotalText.Location = new System.Drawing.Point(128, 203);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(52, 16);
            this.TotalText.TabIndex = 13;
            this.TotalText.Text = "label24";
            // 
            // registrationBindingSource9
            // 
            this.registrationBindingSource9.DataMember = "Registration";
            this.registrationBindingSource9.DataSource = this.testdb1DataSet1;
            // 
            // SecurityDepositText
            // 
            this.SecurityDepositText.AutoSize = true;
            this.SecurityDepositText.Location = new System.Drawing.Point(128, 41);
            this.SecurityDepositText.Name = "SecurityDepositText";
            this.SecurityDepositText.Size = new System.Drawing.Size(52, 16);
            this.SecurityDepositText.TabIndex = 9;
            this.SecurityDepositText.Text = "label20";
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "______________________________";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(502, 418);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(187, 13);
            this.label25.TabIndex = 9;
            this.label25.Text = "______________________________";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(73, 456);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(142, 16);
            this.label26.TabIndex = 10;
            this.label26.Text = "Student\'s Signature";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(524, 456);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(145, 16);
            this.label27.TabIndex = 11;
            this.label27.Text = "Account\'s Signature";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrint";
            this.Text = "FormPrint";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdb1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource4)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private testdb1DataSet1 testdb1DataSet1;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private testdb1DataSet1TableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label RecieptNo;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label FatherName;
        private System.Windows.Forms.Label Programme;
        private System.Windows.Forms.Label GRNo;
        private System.Windows.Forms.Label RecieptNoText;
        private System.Windows.Forms.Label DateText;
        private System.Windows.Forms.Label StudentNameText;
        private System.Windows.Forms.Label FatherNameText;
        private System.Windows.Forms.Label ProgrammeText;
        private System.Windows.Forms.Label GRNoText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label AdmissionFee;
        private System.Windows.Forms.Label SecurityDeposit;
        private System.Windows.Forms.Label MonthlyFee;
        private System.Windows.Forms.Label CertificateFee;
        private System.Windows.Forms.Label ExamFee;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label AdmissionFeeText;
        private System.Windows.Forms.Label MonthlyFeeText;
        private System.Windows.Forms.Label CertificateFeeText;
        private System.Windows.Forms.Label ExamFeeText;
        private System.Windows.Forms.Label TotalText;
        private System.Windows.Forms.Label SecurityDepositText;
        private System.Windows.Forms.BindingSource registrationBindingSource1;
        private System.Windows.Forms.BindingSource registrationBindingSource3;
        private System.Windows.Forms.BindingSource registrationBindingSource4;
        private System.Windows.Forms.BindingSource registrationBindingSource5;
        private System.Windows.Forms.BindingSource registrationBindingSource6;
        private System.Windows.Forms.BindingSource registrationBindingSource7;
        private System.Windows.Forms.BindingSource registrationBindingSource8;
        private System.Windows.Forms.BindingSource registrationBindingSource9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}