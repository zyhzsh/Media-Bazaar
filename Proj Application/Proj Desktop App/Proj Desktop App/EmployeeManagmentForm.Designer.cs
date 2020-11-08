namespace Proj_Desktop_App
{
    partial class EmployeeManagmentForm
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
            this.tbBSN = new System.Windows.Forms.TextBox();
            this.lblBSN = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblFTE = new System.Windows.Forms.Label();
            this.lblCertificates = new System.Windows.Forms.Label();
            this.tbCertificates = new System.Windows.Forms.TextBox();
            this.gbPersonalDetails = new System.Windows.Forms.GroupBox();
            this.lblOptional1 = new System.Windows.Forms.Label();
            this.tbLanguages = new System.Windows.Forms.TextBox();
            this.lblLanguages = new System.Windows.Forms.Label();
            this.lblOptional2 = new System.Windows.Forms.Label();
            this.gbContactDetails = new System.Windows.Forms.GroupBox();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.nudFTE = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPersonalDetails.SuspendLayout();
            this.gbContactDetails.SuspendLayout();
            this.gbPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTE)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBSN
            // 
            this.tbBSN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBSN.Location = new System.Drawing.Point(109, 26);
            this.tbBSN.Name = "tbBSN";
            this.tbBSN.Size = new System.Drawing.Size(204, 27);
            this.tbBSN.TabIndex = 1;
            // 
            // lblBSN
            // 
            this.lblBSN.AutoSize = true;
            this.lblBSN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSN.Location = new System.Drawing.Point(8, 29);
            this.lblBSN.Name = "lblBSN";
            this.lblBSN.Size = new System.Drawing.Size(39, 19);
            this.lblBSN.TabIndex = 1;
            this.lblBSN.Text = "BSN:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(8, 62);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 19);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(8, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 19);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(8, 145);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 19);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(8, 29);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 19);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(8, 177);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(95, 19);
            this.lblBirthdate.TabIndex = 6;
            this.lblBirthdate.Text = "Date of birth:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(8, 62);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 19);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(109, 59);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(204, 27);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(109, 92);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(204, 27);
            this.tbLastName.TabIndex = 3;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(109, 143);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(60, 23);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(174, 143);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 23);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOther.Location = new System.Drawing.Point(252, 143);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(64, 23);
            this.rbOther.TabIndex = 6;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(109, 26);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(204, 27);
            this.tbPhone.TabIndex = 8;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdate.Location = new System.Drawing.Point(109, 174);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(204, 27);
            this.dtpBirthdate.TabIndex = 7;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(109, 59);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(204, 27);
            this.tbAddress.TabIndex = 9;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(109, 92);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(204, 27);
            this.tbEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(8, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(8, 135);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(90, 19);
            this.lblDepartment.TabIndex = 19;
            this.lblDepartment.Text = "Department:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(8, 102);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 19);
            this.lblPosition.TabIndex = 21;
            this.lblPosition.Text = "Position:";
            // 
            // lblFTE
            // 
            this.lblFTE.AutoSize = true;
            this.lblFTE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTE.Location = new System.Drawing.Point(8, 168);
            this.lblFTE.Name = "lblFTE";
            this.lblFTE.Size = new System.Drawing.Size(36, 19);
            this.lblFTE.TabIndex = 23;
            this.lblFTE.Text = "FTE:";
            // 
            // lblCertificates
            // 
            this.lblCertificates.AutoSize = true;
            this.lblCertificates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificates.Location = new System.Drawing.Point(8, 286);
            this.lblCertificates.Name = "lblCertificates";
            this.lblCertificates.Size = new System.Drawing.Size(87, 19);
            this.lblCertificates.TabIndex = 27;
            this.lblCertificates.Text = "Certificates:";
            // 
            // tbCertificates
            // 
            this.tbCertificates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCertificates.Location = new System.Drawing.Point(109, 283);
            this.tbCertificates.Multiline = true;
            this.tbCertificates.Name = "tbCertificates";
            this.tbCertificates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCertificates.Size = new System.Drawing.Size(204, 49);
            this.tbCertificates.TabIndex = 16;
            // 
            // gbPersonalDetails
            // 
            this.gbPersonalDetails.Controls.Add(this.lblOptional1);
            this.gbPersonalDetails.Controls.Add(this.tbLanguages);
            this.gbPersonalDetails.Controls.Add(this.lblLanguages);
            this.gbPersonalDetails.Controls.Add(this.tbBSN);
            this.gbPersonalDetails.Controls.Add(this.lblBSN);
            this.gbPersonalDetails.Controls.Add(this.lblOptional2);
            this.gbPersonalDetails.Controls.Add(this.lblFirstName);
            this.gbPersonalDetails.Controls.Add(this.dtpBirthdate);
            this.gbPersonalDetails.Controls.Add(this.lblLastName);
            this.gbPersonalDetails.Controls.Add(this.lblGender);
            this.gbPersonalDetails.Controls.Add(this.tbCertificates);
            this.gbPersonalDetails.Controls.Add(this.lblBirthdate);
            this.gbPersonalDetails.Controls.Add(this.lblCertificates);
            this.gbPersonalDetails.Controls.Add(this.tbFirstName);
            this.gbPersonalDetails.Controls.Add(this.tbLastName);
            this.gbPersonalDetails.Controls.Add(this.rbMale);
            this.gbPersonalDetails.Controls.Add(this.rbFemale);
            this.gbPersonalDetails.Controls.Add(this.rbOther);
            this.gbPersonalDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonalDetails.Location = new System.Drawing.Point(12, 11);
            this.gbPersonalDetails.Name = "gbPersonalDetails";
            this.gbPersonalDetails.Size = new System.Drawing.Size(324, 346);
            this.gbPersonalDetails.TabIndex = 28;
            this.gbPersonalDetails.TabStop = false;
            this.gbPersonalDetails.Text = "Personal details";
            // 
            // lblOptional1
            // 
            this.lblOptional1.AutoSize = true;
            this.lblOptional1.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptional1.Location = new System.Drawing.Point(9, 251);
            this.lblOptional1.Name = "lblOptional1";
            this.lblOptional1.Size = new System.Drawing.Size(62, 17);
            this.lblOptional1.TabIndex = 38;
            this.lblOptional1.Text = "(optional)";
            // 
            // tbLanguages
            // 
            this.tbLanguages.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLanguages.Location = new System.Drawing.Point(109, 228);
            this.tbLanguages.Multiline = true;
            this.tbLanguages.Name = "tbLanguages";
            this.tbLanguages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLanguages.Size = new System.Drawing.Size(204, 49);
            this.tbLanguages.TabIndex = 36;
            // 
            // lblLanguages
            // 
            this.lblLanguages.AutoSize = true;
            this.lblLanguages.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguages.Location = new System.Drawing.Point(8, 231);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(83, 19);
            this.lblLanguages.TabIndex = 37;
            this.lblLanguages.Text = "Languages:";
            // 
            // lblOptional2
            // 
            this.lblOptional2.AutoSize = true;
            this.lblOptional2.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptional2.Location = new System.Drawing.Point(9, 305);
            this.lblOptional2.Name = "lblOptional2";
            this.lblOptional2.Size = new System.Drawing.Size(62, 17);
            this.lblOptional2.TabIndex = 35;
            this.lblOptional2.Text = "(optional)";
            // 
            // gbContactDetails
            // 
            this.gbContactDetails.Controls.Add(this.tbPhone);
            this.gbContactDetails.Controls.Add(this.lblPhone);
            this.gbContactDetails.Controls.Add(this.lblAddress);
            this.gbContactDetails.Controls.Add(this.tbAddress);
            this.gbContactDetails.Controls.Add(this.lblEmail);
            this.gbContactDetails.Controls.Add(this.tbEmail);
            this.gbContactDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactDetails.Location = new System.Drawing.Point(342, 11);
            this.gbContactDetails.Name = "gbContactDetails";
            this.gbContactDetails.Size = new System.Drawing.Size(324, 133);
            this.gbContactDetails.TabIndex = 29;
            this.gbContactDetails.TabStop = false;
            this.gbContactDetails.Text = "Contact details";
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.lblMonths);
            this.gbPosition.Controls.Add(this.nudDuration);
            this.gbPosition.Controls.Add(this.lblDuration);
            this.gbPosition.Controls.Add(this.dtpStartDate);
            this.gbPosition.Controls.Add(this.lblStartDate);
            this.gbPosition.Controls.Add(this.cbPosition);
            this.gbPosition.Controls.Add(this.cbDepartment);
            this.gbPosition.Controls.Add(this.nudFTE);
            this.gbPosition.Controls.Add(this.lblDepartment);
            this.gbPosition.Controls.Add(this.lblPosition);
            this.gbPosition.Controls.Add(this.lblFTE);
            this.gbPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPosition.Location = new System.Drawing.Point(342, 150);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(324, 207);
            this.gbPosition.TabIndex = 30;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "Contract";
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonths.Location = new System.Drawing.Point(256, 68);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(57, 19);
            this.lblMonths.TabIndex = 26;
            this.lblMonths.Text = "months";
            // 
            // nudDuration
            // 
            this.nudDuration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDuration.Location = new System.Drawing.Point(109, 66);
            this.nudDuration.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(141, 27);
            this.nudDuration.TabIndex = 24;
            this.nudDuration.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(8, 68);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(69, 19);
            this.lblDuration.TabIndex = 25;
            this.lblDuration.Text = "Duration:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(109, 32);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(204, 27);
            this.dtpStartDate.TabIndex = 9;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(8, 38);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 19);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start date:";
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(109, 99);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(204, 27);
            this.cbPosition.TabIndex = 12;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(109, 132);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(204, 27);
            this.cbDepartment.TabIndex = 11;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // nudFTE
            // 
            this.nudFTE.DecimalPlaces = 1;
            this.nudFTE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFTE.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFTE.Location = new System.Drawing.Point(109, 166);
            this.nudFTE.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFTE.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFTE.Name = "nudFTE";
            this.nudFTE.Size = new System.Drawing.Size(204, 27);
            this.nudFTE.TabIndex = 14;
            this.nudFTE.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(508, 363);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(158, 43);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(342, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 43);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EmployeeManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 417);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbPosition);
            this.Controls.Add(this.gbContactDetails);
            this.Controls.Add(this.gbPersonalDetails);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManagment";
            this.gbPersonalDetails.ResumeLayout(false);
            this.gbPersonalDetails.PerformLayout();
            this.gbContactDetails.ResumeLayout(false);
            this.gbContactDetails.PerformLayout();
            this.gbPosition.ResumeLayout(false);
            this.gbPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbBSN;
        private System.Windows.Forms.Label lblBSN;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblFTE;
        private System.Windows.Forms.Label lblCertificates;
        private System.Windows.Forms.TextBox tbCertificates;
        private System.Windows.Forms.GroupBox gbPersonalDetails;
        private System.Windows.Forms.GroupBox gbContactDetails;
        private System.Windows.Forms.GroupBox gbPosition;
        private System.Windows.Forms.NumericUpDown nudFTE;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label lblOptional2;
        private System.Windows.Forms.Label lblOptional1;
        private System.Windows.Forms.TextBox tbLanguages;
        private System.Windows.Forms.Label lblLanguages;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}