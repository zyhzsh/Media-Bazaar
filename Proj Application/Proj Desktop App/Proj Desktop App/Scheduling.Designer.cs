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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeachAvailableEmpByBsn = new System.Windows.Forms.Button();
            this.btnSearchAssignedEmpByBsn = new System.Windows.Forms.Button();
            this.textBoxSearchAssignedEmployees = new System.Windows.Forms.TextBox();
            this.textBoxSearchAvailableList = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRmvEmployeeShift
            // 
            this.btnRmvEmployeeShift.Location = new System.Drawing.Point(5, 14);
            this.btnRmvEmployeeShift.Margin = new System.Windows.Forms.Padding(2);
            this.btnRmvEmployeeShift.Name = "btnRmvEmployeeShift";
            this.btnRmvEmployeeShift.Size = new System.Drawing.Size(217, 50);
            this.btnRmvEmployeeShift.TabIndex = 17;
            this.btnRmvEmployeeShift.Text = "<<< Remove";
            this.btnRmvEmployeeShift.UseVisualStyleBackColor = true;
            this.btnRmvEmployeeShift.Click += new System.EventHandler(this.btnRmvEmployeeShift_Click);
            // 
            // btnAddEmpShift
            // 
            this.btnAddEmpShift.Location = new System.Drawing.Point(5, 89);
            this.btnAddEmpShift.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmpShift.Name = "btnAddEmpShift";
            this.btnAddEmpShift.Size = new System.Drawing.Size(217, 50);
            this.btnAddEmpShift.TabIndex = 16;
            this.btnAddEmpShift.Text = "Assign >>>";
            this.btnAddEmpShift.UseVisualStyleBackColor = true;
            this.btnAddEmpShift.Click += new System.EventHandler(this.btnAddEmpShift_Click);
            // 
            // listboxAssignedEmployees
            // 
            this.listboxAssignedEmployees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listboxAssignedEmployees.FormattingEnabled = true;
            this.listboxAssignedEmployees.Location = new System.Drawing.Point(514, 32);
            this.listboxAssignedEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.listboxAssignedEmployees.Name = "listboxAssignedEmployees";
            this.listboxAssignedEmployees.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listboxAssignedEmployees.Size = new System.Drawing.Size(418, 394);
            this.listboxAssignedEmployees.TabIndex = 15;
            this.listboxAssignedEmployees.SelectedIndexChanged += new System.EventHandler(this.listboxAssignedEmployees_SelectedIndexChanged);
            // 
            // listboxAvailableEmployees
            // 
            this.listboxAvailableEmployees.FormattingEnabled = true;
            this.listboxAvailableEmployees.Location = new System.Drawing.Point(18, 32);
            this.listboxAvailableEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.listboxAvailableEmployees.Name = "listboxAvailableEmployees";
            this.listboxAvailableEmployees.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listboxAvailableEmployees.Size = new System.Drawing.Size(251, 394);
            this.listboxAvailableEmployees.TabIndex = 13;
            this.listboxAvailableEmployees.SelectedIndexChanged += new System.EventHandler(this.listboxAvailableEmployees_SelectedIndexChanged);
            // 
            // monthCalendarScheduling
            // 
            this.monthCalendarScheduling.Location = new System.Drawing.Point(278, 32);
            this.monthCalendarScheduling.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendarScheduling.Name = "monthCalendarScheduling";
            this.monthCalendarScheduling.TabIndex = 12;
            this.monthCalendarScheduling.TrailingForeColor = System.Drawing.Color.Gray;
            this.monthCalendarScheduling.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarScheduling_DateChanged);
            this.monthCalendarScheduling.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarScheduling_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Employee(s)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Assigned Employee(s)";
            // 
            // listBoxEmployeesDetails
            // 
            this.listBoxEmployeesDetails.FormattingEnabled = true;
            this.listBoxEmployeesDetails.Location = new System.Drawing.Point(18, 448);
            this.listBoxEmployeesDetails.Name = "listBoxEmployeesDetails";
            this.listBoxEmployeesDetails.Size = new System.Drawing.Size(914, 134);
            this.listBoxEmployeesDetails.TabIndex = 21;
            this.listBoxEmployeesDetails.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Employee\'s information";
            // 
            // ckbMorning
            // 
            this.ckbMorning.AutoSize = true;
            this.ckbMorning.Location = new System.Drawing.Point(29, 22);
            this.ckbMorning.Name = "ckbMorning";
            this.ckbMorning.Size = new System.Drawing.Size(121, 17);
            this.ckbMorning.TabIndex = 28;
            this.ckbMorning.Text = "Morning(8:00-12:00)";
            this.ckbMorning.UseVisualStyleBackColor = true;
            // 
            // ckbAfternoon
            // 
            this.ckbAfternoon.AutoSize = true;
            this.ckbAfternoon.Location = new System.Drawing.Point(29, 44);
            this.ckbAfternoon.Name = "ckbAfternoon";
            this.ckbAfternoon.Size = new System.Drawing.Size(135, 17);
            this.ckbAfternoon.TabIndex = 29;
            this.ckbAfternoon.Text = "Afternoon(12:30-17:00)";
            this.ckbAfternoon.UseVisualStyleBackColor = true;
            // 
            // CkbEvening
            // 
            this.CkbEvening.AutoSize = true;
            this.CkbEvening.Location = new System.Drawing.Point(29, 67);
            this.CkbEvening.Name = "CkbEvening";
            this.CkbEvening.Size = new System.Drawing.Size(128, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(278, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 147);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign Shift";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRmvEmployeeShift);
            this.groupBox2.Location = new System.Drawing.Point(278, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 69);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Employee\'s Shift";
            // 
            // btnSeachAvailableEmpByBsn
            // 
            this.btnSeachAvailableEmpByBsn.Location = new System.Drawing.Point(208, 8);
            this.btnSeachAvailableEmpByBsn.Name = "btnSeachAvailableEmpByBsn";
            this.btnSeachAvailableEmpByBsn.Size = new System.Drawing.Size(61, 23);
            this.btnSeachAvailableEmpByBsn.TabIndex = 36;
            this.btnSeachAvailableEmpByBsn.Text = "Search";
            this.btnSeachAvailableEmpByBsn.UseVisualStyleBackColor = true;
            this.btnSeachAvailableEmpByBsn.Click += new System.EventHandler(this.btnSeachAvailableEmpByBsn_Click);
            // 
            // btnSearchAssignedEmpByBsn
            // 
            this.btnSearchAssignedEmpByBsn.Location = new System.Drawing.Point(872, 8);
            this.btnSearchAssignedEmpByBsn.Name = "btnSearchAssignedEmpByBsn";
            this.btnSearchAssignedEmpByBsn.Size = new System.Drawing.Size(60, 23);
            this.btnSearchAssignedEmpByBsn.TabIndex = 37;
            this.btnSearchAssignedEmpByBsn.Text = "Search";
            this.btnSearchAssignedEmpByBsn.UseVisualStyleBackColor = true;
            this.btnSearchAssignedEmpByBsn.Click += new System.EventHandler(this.btnSearchAssignedEmpByBsn_Click);
            // 
            // textBoxSearchAssignedEmployees
            // 
            this.textBoxSearchAssignedEmployees.Location = new System.Drawing.Point(764, 9);
            this.textBoxSearchAssignedEmployees.Name = "textBoxSearchAssignedEmployees";
            this.textBoxSearchAssignedEmployees.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchAssignedEmployees.TabIndex = 39;
            // 
            // textBoxSearchAvailableList
            // 
            this.textBoxSearchAvailableList.Location = new System.Drawing.Point(102, 9);
            this.textBoxSearchAvailableList.Name = "textBoxSearchAvailableList";
            this.textBoxSearchAvailableList.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchAvailableList.TabIndex = 40;
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 598);
            this.Controls.Add(this.textBoxSearchAvailableList);
            this.Controls.Add(this.textBoxSearchAssignedEmployees);
            this.Controls.Add(this.btnSearchAssignedEmpByBsn);
            this.Controls.Add(this.btnSeachAvailableEmpByBsn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxEmployeesDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxAssignedEmployees);
            this.Controls.Add(this.listboxAvailableEmployees);
            this.Controls.Add(this.monthCalendarScheduling);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Scheduling";
            this.Text = "Scheduling";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeachAvailableEmpByBsn;
        private System.Windows.Forms.Button btnSearchAssignedEmpByBsn;
        private System.Windows.Forms.TextBox textBoxSearchAssignedEmployees;
        private System.Windows.Forms.TextBox textBoxSearchAvailableList;
    }
}