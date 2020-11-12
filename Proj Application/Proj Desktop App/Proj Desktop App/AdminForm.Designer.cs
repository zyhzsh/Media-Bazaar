namespace Proj_Desktop_App
{
    partial class AdminForm
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
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.pnlEmployeeCard = new System.Windows.Forms.Panel();
            this.lblEmployed = new System.Windows.Forms.Label();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.lblInfoContracts = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblInfoLanguages = new System.Windows.Forms.Label();
            this.lblInfoCertificates = new System.Windows.Forms.Label();
            this.lblInfoBirthdate = new System.Windows.Forms.Label();
            this.lblInfoGender = new System.Windows.Forms.Label();
            this.btnTerminateCon = new System.Windows.Forms.Button();
            this.btnExtendCon = new System.Windows.Forms.Button();
            this.btnPromote = new System.Windows.Forms.Button();
            this.lblInfoEmail = new System.Windows.Forms.Label();
            this.lblInfoAddress = new System.Windows.Forms.Label();
            this.lblInfoPhone = new System.Windows.Forms.Label();
            this.lblLanguages = new System.Windows.Forms.Label();
            this.lblCertificates = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBSN = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cbShowEmployed = new System.Windows.Forms.CheckBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblInfoTotalEmployees = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.pnlAllEmployees = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lvContracts = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFTE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlEmployeeCard.SuspendLayout();
            this.pnlAllEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 18;
            this.lbEmployees.Items.AddRange(new object[] {
            "<BSN> - <LastName>",
            "<BSN> - <LastName>",
            "<BSN> - <LastName>"});
            this.lbEmployees.Location = new System.Drawing.Point(16, 123);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(286, 310);
            this.lbEmployees.TabIndex = 0;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged);
            // 
            // pnlEmployeeCard
            // 
            this.pnlEmployeeCard.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlEmployeeCard.Controls.Add(this.lvContracts);
            this.pnlEmployeeCard.Controls.Add(this.lblEmployed);
            this.pnlEmployeeCard.Controls.Add(this.btnUpdateDetails);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoContracts);
            this.pnlEmployeeCard.Controls.Add(this.lblEmail);
            this.pnlEmployeeCard.Controls.Add(this.lblAddress);
            this.pnlEmployeeCard.Controls.Add(this.lblPhone);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoLanguages);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoCertificates);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoBirthdate);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoGender);
            this.pnlEmployeeCard.Controls.Add(this.btnTerminateCon);
            this.pnlEmployeeCard.Controls.Add(this.btnExtendCon);
            this.pnlEmployeeCard.Controls.Add(this.btnPromote);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoEmail);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoAddress);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoPhone);
            this.pnlEmployeeCard.Controls.Add(this.lblLanguages);
            this.pnlEmployeeCard.Controls.Add(this.lblCertificates);
            this.pnlEmployeeCard.Controls.Add(this.lblBirthdate);
            this.pnlEmployeeCard.Controls.Add(this.lblGender);
            this.pnlEmployeeCard.Controls.Add(this.lblBSN);
            this.pnlEmployeeCard.Controls.Add(this.lblNames);
            this.pnlEmployeeCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeeCard.Location = new System.Drawing.Point(323, 0);
            this.pnlEmployeeCard.Name = "pnlEmployeeCard";
            this.pnlEmployeeCard.Size = new System.Drawing.Size(692, 497);
            this.pnlEmployeeCard.TabIndex = 1;
            // 
            // lblEmployed
            // 
            this.lblEmployed.AutoSize = true;
            this.lblEmployed.Location = new System.Drawing.Point(452, 50);
            this.lblEmployed.Name = "lblEmployed";
            this.lblEmployed.Size = new System.Drawing.Size(90, 18);
            this.lblEmployed.TabIndex = 26;
            this.lblEmployed.Text = "<employed>";
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDetails.Location = new System.Drawing.Point(533, 259);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(143, 32);
            this.btnUpdateDetails.TabIndex = 25;
            this.btnUpdateDetails.Text = "Uptate details";
            this.btnUpdateDetails.UseVisualStyleBackColor = false;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // lblInfoContracts
            // 
            this.lblInfoContracts.AutoSize = true;
            this.lblInfoContracts.Location = new System.Drawing.Point(15, 300);
            this.lblInfoContracts.Name = "lblInfoContracts";
            this.lblInfoContracts.Size = new System.Drawing.Size(77, 18);
            this.lblInfoContracts.TabIndex = 24;
            this.lblInfoContracts.Text = "Contracts:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(452, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 18);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "<email>";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(452, 183);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(160, 54);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "<address>";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(452, 123);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(67, 18);
            this.lblPhone.TabIndex = 21;
            this.lblPhone.Text = "<phone>";
            // 
            // lblInfoLanguages
            // 
            this.lblInfoLanguages.AutoSize = true;
            this.lblInfoLanguages.Location = new System.Drawing.Point(14, 183);
            this.lblInfoLanguages.Name = "lblInfoLanguages";
            this.lblInfoLanguages.Size = new System.Drawing.Size(84, 18);
            this.lblInfoLanguages.TabIndex = 20;
            this.lblInfoLanguages.Text = "Languages:";
            // 
            // lblInfoCertificates
            // 
            this.lblInfoCertificates.AutoSize = true;
            this.lblInfoCertificates.Location = new System.Drawing.Point(14, 237);
            this.lblInfoCertificates.Name = "lblInfoCertificates";
            this.lblInfoCertificates.Size = new System.Drawing.Size(86, 18);
            this.lblInfoCertificates.TabIndex = 19;
            this.lblInfoCertificates.Text = "Certificates:";
            // 
            // lblInfoBirthdate
            // 
            this.lblInfoBirthdate.AutoSize = true;
            this.lblInfoBirthdate.Location = new System.Drawing.Point(15, 153);
            this.lblInfoBirthdate.Name = "lblInfoBirthdate";
            this.lblInfoBirthdate.Size = new System.Drawing.Size(70, 18);
            this.lblInfoBirthdate.TabIndex = 18;
            this.lblInfoBirthdate.Text = "Birthdate:";
            // 
            // lblInfoGender
            // 
            this.lblInfoGender.AutoSize = true;
            this.lblInfoGender.Location = new System.Drawing.Point(15, 123);
            this.lblInfoGender.Name = "lblInfoGender";
            this.lblInfoGender.Size = new System.Drawing.Size(61, 18);
            this.lblInfoGender.TabIndex = 17;
            this.lblInfoGender.Text = "Gender:";
            // 
            // btnTerminateCon
            // 
            this.btnTerminateCon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTerminateCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminateCon.Location = new System.Drawing.Point(235, 448);
            this.btnTerminateCon.Name = "btnTerminateCon";
            this.btnTerminateCon.Size = new System.Drawing.Size(143, 32);
            this.btnTerminateCon.TabIndex = 16;
            this.btnTerminateCon.Text = "Terminate contract";
            this.btnTerminateCon.UseVisualStyleBackColor = false;
            this.btnTerminateCon.Click += new System.EventHandler(this.btnTerminateCon_Click);
            // 
            // btnExtendCon
            // 
            this.btnExtendCon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExtendCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtendCon.Location = new System.Drawing.Point(384, 448);
            this.btnExtendCon.Name = "btnExtendCon";
            this.btnExtendCon.Size = new System.Drawing.Size(143, 32);
            this.btnExtendCon.TabIndex = 15;
            this.btnExtendCon.Text = "Extend contract";
            this.btnExtendCon.UseVisualStyleBackColor = false;
            this.btnExtendCon.Click += new System.EventHandler(this.btnExtendCon_Click);
            // 
            // btnPromote
            // 
            this.btnPromote.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPromote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromote.Location = new System.Drawing.Point(533, 448);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(143, 32);
            this.btnPromote.TabIndex = 14;
            this.btnPromote.Text = "Promote";
            this.btnPromote.UseVisualStyleBackColor = false;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // lblInfoEmail
            // 
            this.lblInfoEmail.AutoSize = true;
            this.lblInfoEmail.Location = new System.Drawing.Point(341, 153);
            this.lblInfoEmail.Name = "lblInfoEmail";
            this.lblInfoEmail.Size = new System.Drawing.Size(49, 18);
            this.lblInfoEmail.TabIndex = 12;
            this.lblInfoEmail.Text = "Email:";
            // 
            // lblInfoAddress
            // 
            this.lblInfoAddress.AutoSize = true;
            this.lblInfoAddress.Location = new System.Drawing.Point(341, 183);
            this.lblInfoAddress.Name = "lblInfoAddress";
            this.lblInfoAddress.Size = new System.Drawing.Size(66, 18);
            this.lblInfoAddress.TabIndex = 11;
            this.lblInfoAddress.Text = "Address:";
            // 
            // lblInfoPhone
            // 
            this.lblInfoPhone.AutoSize = true;
            this.lblInfoPhone.Location = new System.Drawing.Point(341, 123);
            this.lblInfoPhone.Name = "lblInfoPhone";
            this.lblInfoPhone.Size = new System.Drawing.Size(55, 18);
            this.lblInfoPhone.TabIndex = 10;
            this.lblInfoPhone.Text = "Phone:";
            // 
            // lblLanguages
            // 
            this.lblLanguages.Location = new System.Drawing.Point(125, 183);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(160, 54);
            this.lblLanguages.TabIndex = 9;
            this.lblLanguages.Text = "<languages>";
            // 
            // lblCertificates
            // 
            this.lblCertificates.Location = new System.Drawing.Point(125, 237);
            this.lblCertificates.Name = "lblCertificates";
            this.lblCertificates.Size = new System.Drawing.Size(160, 54);
            this.lblCertificates.TabIndex = 8;
            this.lblCertificates.Text = "<certificates>";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(126, 153);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(82, 18);
            this.lblBirthdate.TabIndex = 7;
            this.lblBirthdate.Text = "<birthdate>";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(126, 123);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(71, 18);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "<gender>";
            // 
            // lblBSN
            // 
            this.lblBSN.AutoSize = true;
            this.lblBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSN.Location = new System.Drawing.Point(14, 50);
            this.lblBSN.Name = "lblBSN";
            this.lblBSN.Size = new System.Drawing.Size(60, 20);
            this.lblBSN.TabIndex = 5;
            this.lblBSN.Text = "<BSN>";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.Location = new System.Drawing.Point(14, 16);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(251, 24);
            this.lblNames.TabIndex = 3;
            this.lblNames.Text = "<FirstName> <LastName>";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Location = new System.Drawing.Point(16, 448);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(286, 32);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "Add new employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cbShowEmployed
            // 
            this.cbShowEmployed.AutoSize = true;
            this.cbShowEmployed.Location = new System.Drawing.Point(211, 15);
            this.cbShowEmployed.Name = "cbShowEmployed";
            this.cbShowEmployed.Size = new System.Drawing.Size(91, 22);
            this.cbShowEmployed.TabIndex = 15;
            this.cbShowEmployed.Text = "employed";
            this.cbShowEmployed.UseVisualStyleBackColor = true;
            this.cbShowEmployed.CheckedChanged += new System.EventHandler(this.cbShowEmployed_CheckedChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(121, 47);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(181, 26);
            this.tbSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(166, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 32);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblInfoTotalEmployees
            // 
            this.lblInfoTotalEmployees.AutoSize = true;
            this.lblInfoTotalEmployees.Location = new System.Drawing.Point(13, 16);
            this.lblInfoTotalEmployees.Name = "lblInfoTotalEmployees";
            this.lblInfoTotalEmployees.Size = new System.Drawing.Size(125, 18);
            this.lblInfoTotalEmployees.TabIndex = 18;
            this.lblInfoTotalEmployees.Text = "Total employees: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(144, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 18);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "<total>";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Location = new System.Drawing.Point(16, 47);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(99, 26);
            this.cbSearchBy.TabIndex = 19;
            // 
            // pnlAllEmployees
            // 
            this.pnlAllEmployees.Controls.Add(this.btnShowAll);
            this.pnlAllEmployees.Controls.Add(this.lbEmployees);
            this.pnlAllEmployees.Controls.Add(this.cbSearchBy);
            this.pnlAllEmployees.Controls.Add(this.btnAddEmployee);
            this.pnlAllEmployees.Controls.Add(this.lblTotal);
            this.pnlAllEmployees.Controls.Add(this.cbShowEmployed);
            this.pnlAllEmployees.Controls.Add(this.lblInfoTotalEmployees);
            this.pnlAllEmployees.Controls.Add(this.tbSearch);
            this.pnlAllEmployees.Controls.Add(this.btnSearch);
            this.pnlAllEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAllEmployees.Location = new System.Drawing.Point(0, 0);
            this.pnlAllEmployees.Name = "pnlAllEmployees";
            this.pnlAllEmployees.Size = new System.Drawing.Size(323, 497);
            this.pnlAllEmployees.TabIndex = 20;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Location = new System.Drawing.Point(16, 79);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(136, 32);
            this.btnShowAll.TabIndex = 20;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // lvContracts
            // 
            this.lvContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chStartDate,
            this.chEndDate,
            this.chPosition,
            this.chDepartment,
            this.chFTE,
            this.chSalary,
            this.chStatus});
            this.lvContracts.HideSelection = false;
            this.lvContracts.Location = new System.Drawing.Point(18, 321);
            this.lvContracts.MultiSelect = false;
            this.lvContracts.Name = "lvContracts";
            this.lvContracts.Size = new System.Drawing.Size(658, 112);
            this.lvContracts.TabIndex = 27;
            this.lvContracts.UseCompatibleStateImageBehavior = false;
            this.lvContracts.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 26;
            // 
            // chStartDate
            // 
            this.chStartDate.Text = "Start date";
            this.chStartDate.Width = 100;
            // 
            // chEndDate
            // 
            this.chEndDate.Text = "End date";
            this.chEndDate.Width = 100;
            // 
            // chPosition
            // 
            this.chPosition.Text = "Position";
            this.chPosition.Width = 120;
            // 
            // chDepartment
            // 
            this.chDepartment.Text = "Department";
            this.chDepartment.Width = 100;
            // 
            // chFTE
            // 
            this.chFTE.Text = "FTE";
            this.chFTE.Width = 45;
            // 
            // chSalary
            // 
            this.chSalary.Text = "Salary";
            this.chSalary.Width = 77;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 86;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 497);
            this.Controls.Add(this.pnlEmployeeCard);
            this.Controls.Add(this.pnlAllEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.pnlEmployeeCard.ResumeLayout(false);
            this.pnlEmployeeCard.PerformLayout();
            this.pnlAllEmployees.ResumeLayout(false);
            this.pnlAllEmployees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Panel pnlEmployeeCard;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBSN;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblLanguages;
        private System.Windows.Forms.Label lblCertificates;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Button btnTerminateCon;
        private System.Windows.Forms.Button btnExtendCon;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Label lblInfoEmail;
        private System.Windows.Forms.Label lblInfoAddress;
        private System.Windows.Forms.Label lblInfoPhone;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.CheckBox cbShowEmployed;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblInfoTotalEmployees;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblInfoLanguages;
        private System.Windows.Forms.Label lblInfoCertificates;
        private System.Windows.Forms.Label lblInfoBirthdate;
        private System.Windows.Forms.Label lblInfoGender;
        private System.Windows.Forms.Label lblInfoContracts;
        private System.Windows.Forms.Label lblEmployed;
        private System.Windows.Forms.Panel pnlAllEmployees;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ListView lvContracts;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chStartDate;
        private System.Windows.Forms.ColumnHeader chEndDate;
        private System.Windows.Forms.ColumnHeader chPosition;
        private System.Windows.Forms.ColumnHeader chDepartment;
        private System.Windows.Forms.ColumnHeader chFTE;
        private System.Windows.Forms.ColumnHeader chSalary;
        private System.Windows.Forms.ColumnHeader chStatus;
    }
}