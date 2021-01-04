namespace Proj_Desktop_App
{
    partial class Scheduling
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
            this.btnRmvEmployeeShift = new System.Windows.Forms.Button();
            this.btnAddEmpShift = new System.Windows.Forms.Button();
            this.listboxAssignedEmployees = new System.Windows.Forms.ListBox();
            this.listboxAvailableEmployees = new System.Windows.Forms.ListBox();
            this.monthCalendarScheduling = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxEmployeesDetails = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbMorning = new System.Windows.Forms.CheckBox();
            this.ckbAfternoon = new System.Windows.Forms.CheckBox();
            this.CkbEvening = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeachAvailableEmpByBsn = new System.Windows.Forms.Button();
            this.btnSearchAssignedEmpByBsn = new System.Windows.Forms.Button();
            this.textBoxSearchAvailableList = new System.Windows.Forms.TextBox();
            this.textBoxSearchAssignedEmployees = new System.Windows.Forms.TextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lbdepartment = new System.Windows.Forms.Label();
            this.listboxEmployeePreferenceShifts = new System.Windows.Forms.ListBox();
            this.labelEmployeePereferenceShifts = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRmvEmployeeShift
            // 
            this.btnRmvEmployeeShift.Location = new System.Drawing.Point(371, 462);
            this.btnRmvEmployeeShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRmvEmployeeShift.Name = "btnRmvEmployeeShift";
            this.btnRmvEmployeeShift.Size = new System.Drawing.Size(289, 63);
            this.btnRmvEmployeeShift.TabIndex = 17;
            this.btnRmvEmployeeShift.Text = "Remove Shift";
            this.btnRmvEmployeeShift.UseVisualStyleBackColor = true;
            this.btnRmvEmployeeShift.Click += new System.EventHandler(this.btnRmvEmployeeShift_Click);
            // 
            // btnAddEmpShift
            // 
            this.btnAddEmpShift.Location = new System.Drawing.Point(7, 116);
            this.btnAddEmpShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmpShift.Name = "btnAddEmpShift";
            this.btnAddEmpShift.Size = new System.Drawing.Size(289, 62);
            this.btnAddEmpShift.TabIndex = 16;
            this.btnAddEmpShift.Text = "Assign>>>";
            this.btnAddEmpShift.UseVisualStyleBackColor = true;
            this.btnAddEmpShift.Click += new System.EventHandler(this.btnAddEmpShift_Click);
            // 
            // listboxAssignedEmployees
            // 
            this.listboxAssignedEmployees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listboxAssignedEmployees.FormattingEnabled = true;
            this.listboxAssignedEmployees.ItemHeight = 16;
            this.listboxAssignedEmployees.Location = new System.Drawing.Point(673, 55);
            this.listboxAssignedEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxAssignedEmployees.Name = "listboxAssignedEmployees";
            this.listboxAssignedEmployees.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listboxAssignedEmployees.Size = new System.Drawing.Size(696, 468);
            this.listboxAssignedEmployees.TabIndex = 15;
            this.listboxAssignedEmployees.SelectedIndexChanged += new System.EventHandler(this.listboxAssignedEmployees_SelectedIndexChanged);
            // 
            // listboxAvailableEmployees
            // 
            this.listboxAvailableEmployees.FormattingEnabled = true;
            this.listboxAvailableEmployees.ItemHeight = 16;
            this.listboxAvailableEmployees.Location = new System.Drawing.Point(20, 55);
            this.listboxAvailableEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxAvailableEmployees.Name = "listboxAvailableEmployees";
            this.listboxAvailableEmployees.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listboxAvailableEmployees.Size = new System.Drawing.Size(331, 468);
            this.listboxAvailableEmployees.TabIndex = 13;
            this.listboxAvailableEmployees.Click += new System.EventHandler(this.listboxAvailableEmployees_Click);
            this.listboxAvailableEmployees.SelectedIndexChanged += new System.EventHandler(this.listboxAvailableEmployees_SelectedIndexChanged);
            // 
            // monthCalendarScheduling
            // 
            this.monthCalendarScheduling.Location = new System.Drawing.Point(364, 55);
            this.monthCalendarScheduling.Name = "monthCalendarScheduling";
            this.monthCalendarScheduling.TabIndex = 12;
            this.monthCalendarScheduling.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarScheduling_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Employee(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Assigned Employee(s)";
            // 
            // listBoxEmployeesDetails
            // 
            this.listBoxEmployeesDetails.FormattingEnabled = true;
            this.listBoxEmployeesDetails.ItemHeight = 16;
            this.listBoxEmployeesDetails.Location = new System.Drawing.Point(24, 549);
            this.listBoxEmployeesDetails.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEmployeesDetails.Name = "listBoxEmployeesDetails";
            this.listBoxEmployeesDetails.Size = new System.Drawing.Size(785, 164);
            this.listBoxEmployeesDetails.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 529);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Employee\'s information";
            // 
            // ckbMorning
            // 
            this.ckbMorning.AutoSize = true;
            this.ckbMorning.Location = new System.Drawing.Point(67, 33);
            this.ckbMorning.Margin = new System.Windows.Forms.Padding(4);
            this.ckbMorning.Name = "ckbMorning";
            this.ckbMorning.Size = new System.Drawing.Size(160, 21);
            this.ckbMorning.TabIndex = 28;
            this.ckbMorning.Text = "Morning(8:00-12:00)";
            this.ckbMorning.UseVisualStyleBackColor = true;
            // 
            // ckbAfternoon
            // 
            this.ckbAfternoon.AutoSize = true;
            this.ckbAfternoon.Location = new System.Drawing.Point(67, 60);
            this.ckbAfternoon.Margin = new System.Windows.Forms.Padding(4);
            this.ckbAfternoon.Name = "ckbAfternoon";
            this.ckbAfternoon.Size = new System.Drawing.Size(179, 21);
            this.ckbAfternoon.TabIndex = 29;
            this.ckbAfternoon.Text = "Afternoon(12:30-17:00)";
            this.ckbAfternoon.UseVisualStyleBackColor = true;
            // 
            // CkbEvening
            // 
            this.CkbEvening.AutoSize = true;
            this.CkbEvening.Location = new System.Drawing.Point(67, 89);
            this.CkbEvening.Margin = new System.Windows.Forms.Padding(4);
            this.CkbEvening.Name = "CkbEvening";
            this.CkbEvening.Size = new System.Drawing.Size(168, 21);
            this.CkbEvening.TabIndex = 31;
            this.CkbEvening.Text = "Evening(17:00-21:30)";
            this.CkbEvening.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbAfternoon);
            this.groupBox1.Controls.Add(this.CkbEvening);
            this.groupBox1.Controls.Add(this.ckbMorning);
            this.groupBox1.Controls.Add(this.btnAddEmpShift);
            this.groupBox1.Location = new System.Drawing.Point(364, 263);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(303, 192);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign Shift";
            // 
            // btnSeachAvailableEmpByBsn
            // 
            this.btnSeachAvailableEmpByBsn.Location = new System.Drawing.Point(252, 23);
            this.btnSeachAvailableEmpByBsn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeachAvailableEmpByBsn.Name = "btnSeachAvailableEmpByBsn";
            this.btnSeachAvailableEmpByBsn.Size = new System.Drawing.Size(100, 26);
            this.btnSeachAvailableEmpByBsn.TabIndex = 33;
            this.btnSeachAvailableEmpByBsn.Text = "Search";
            this.btnSeachAvailableEmpByBsn.UseVisualStyleBackColor = true;
            this.btnSeachAvailableEmpByBsn.Click += new System.EventHandler(this.btnSeachAvailableEmpByBsn_Click);
            // 
            // btnSearchAssignedEmpByBsn
            // 
            this.btnSearchAssignedEmpByBsn.Location = new System.Drawing.Point(1271, 21);
            this.btnSearchAssignedEmpByBsn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchAssignedEmpByBsn.Name = "btnSearchAssignedEmpByBsn";
            this.btnSearchAssignedEmpByBsn.Size = new System.Drawing.Size(100, 28);
            this.btnSearchAssignedEmpByBsn.TabIndex = 34;
            this.btnSearchAssignedEmpByBsn.Text = "Search";
            this.btnSearchAssignedEmpByBsn.UseVisualStyleBackColor = true;
            this.btnSearchAssignedEmpByBsn.Click += new System.EventHandler(this.btnSearchAssignedEmpByBsn_Click);
            // 
            // textBoxSearchAvailableList
            // 
            this.textBoxSearchAvailableList.Location = new System.Drawing.Point(127, 23);
            this.textBoxSearchAvailableList.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchAvailableList.Name = "textBoxSearchAvailableList";
            this.textBoxSearchAvailableList.Size = new System.Drawing.Size(116, 22);
            this.textBoxSearchAvailableList.TabIndex = 35;
            // 
            // textBoxSearchAssignedEmployees
            // 
            this.textBoxSearchAssignedEmployees.Location = new System.Drawing.Point(1128, 23);
            this.textBoxSearchAssignedEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchAssignedEmployees.Name = "textBoxSearchAssignedEmployees";
            this.textBoxSearchAssignedEmployees.Size = new System.Drawing.Size(132, 22);
            this.textBoxSearchAssignedEmployees.TabIndex = 36;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(457, 25);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(160, 24);
            this.cbDepartment.TabIndex = 37;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // lbdepartment
            // 
            this.lbdepartment.AutoSize = true;
            this.lbdepartment.Location = new System.Drawing.Point(367, 28);
            this.lbdepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdepartment.Name = "lbdepartment";
            this.lbdepartment.Size = new System.Drawing.Size(82, 17);
            this.lbdepartment.TabIndex = 38;
            this.lbdepartment.Text = "Department";
            // 
            // listboxEmployeePreferenceShifts
            // 
            this.listboxEmployeePreferenceShifts.FormattingEnabled = true;
            this.listboxEmployeePreferenceShifts.ItemHeight = 16;
            this.listboxEmployeePreferenceShifts.Location = new System.Drawing.Point(819, 549);
            this.listboxEmployeePreferenceShifts.Margin = new System.Windows.Forms.Padding(4);
            this.listboxEmployeePreferenceShifts.Name = "listboxEmployeePreferenceShifts";
            this.listboxEmployeePreferenceShifts.Size = new System.Drawing.Size(551, 164);
            this.listboxEmployeePreferenceShifts.TabIndex = 39;
            // 
            // labelEmployeePereferenceShifts
            // 
            this.labelEmployeePereferenceShifts.AutoSize = true;
            this.labelEmployeePereferenceShifts.Location = new System.Drawing.Point(815, 529);
            this.labelEmployeePereferenceShifts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeePereferenceShifts.Name = "labelEmployeePereferenceShifts";
            this.labelEmployeePereferenceShifts.Size = new System.Drawing.Size(113, 17);
            this.labelEmployeePereferenceShifts.TabIndex = 40;
            this.labelEmployeePereferenceShifts.Text = "PerferenceShifts";
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 725);
            this.Controls.Add(this.labelEmployeePereferenceShifts);
            this.Controls.Add(this.listboxEmployeePreferenceShifts);
            this.Controls.Add(this.lbdepartment);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.textBoxSearchAssignedEmployees);
            this.Controls.Add(this.textBoxSearchAvailableList);
            this.Controls.Add(this.btnSearchAssignedEmpByBsn);
            this.Controls.Add(this.btnSeachAvailableEmpByBsn);
            this.Controls.Add(this.btnRmvEmployeeShift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxEmployeesDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxAssignedEmployees);
            this.Controls.Add(this.listboxAvailableEmployees);
            this.Controls.Add(this.monthCalendarScheduling);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Scheduling";
            this.Text = "Scheduling";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRmvEmployeeShift;
        private System.Windows.Forms.Button btnAddEmpShift;
        private System.Windows.Forms.ListBox listboxAssignedEmployees;
        private System.Windows.Forms.ListBox listboxAvailableEmployees;
        private System.Windows.Forms.MonthCalendar monthCalendarScheduling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxEmployeesDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbMorning;
        private System.Windows.Forms.CheckBox ckbAfternoon;
        private System.Windows.Forms.CheckBox CkbEvening;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeachAvailableEmpByBsn;
        private System.Windows.Forms.Button btnSearchAssignedEmpByBsn;
        private System.Windows.Forms.TextBox textBoxSearchAvailableList;
        private System.Windows.Forms.TextBox textBoxSearchAssignedEmployees;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lbdepartment;
        private System.Windows.Forms.ListBox listboxEmployeePreferenceShifts;
        private System.Windows.Forms.Label labelEmployeePereferenceShifts;
    }
}