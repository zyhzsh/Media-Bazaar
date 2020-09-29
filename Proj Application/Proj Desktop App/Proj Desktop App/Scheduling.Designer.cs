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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbMorning = new System.Windows.Forms.CheckBox();
            this.ckbAfternoon = new System.Windows.Forms.CheckBox();
            this.CkbEvening = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRmvEmployeeShift
            // 
            this.btnRmvEmployeeShift.Location = new System.Drawing.Point(315, 359);
            this.btnRmvEmployeeShift.Margin = new System.Windows.Forms.Padding(2);
            this.btnRmvEmployeeShift.Name = "btnRmvEmployeeShift";
            this.btnRmvEmployeeShift.Size = new System.Drawing.Size(227, 67);
            this.btnRmvEmployeeShift.TabIndex = 17;
            this.btnRmvEmployeeShift.Text = "<----Remove employee from shift";
            this.btnRmvEmployeeShift.UseVisualStyleBackColor = true;
            this.btnRmvEmployeeShift.Click += new System.EventHandler(this.btnRmvEmployeeShift_Click);
            // 
            // btnAddEmpShift
            // 
            this.btnAddEmpShift.Location = new System.Drawing.Point(315, 214);
            this.btnAddEmpShift.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmpShift.Name = "btnAddEmpShift";
            this.btnAddEmpShift.Size = new System.Drawing.Size(227, 67);
            this.btnAddEmpShift.TabIndex = 16;
            this.btnAddEmpShift.Text = "Assign employee to shift---->";
            this.btnAddEmpShift.UseVisualStyleBackColor = true;
            this.btnAddEmpShift.Click += new System.EventHandler(this.btnAddEmpShift_Click);
            // 
            // listboxAssignedEmployees
            // 
            this.listboxAssignedEmployees.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.listboxAssignedEmployees.FormattingEnabled = true;
            this.listboxAssignedEmployees.Location = new System.Drawing.Point(551, 32);
            this.listboxAssignedEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.listboxAssignedEmployees.Name = "listboxAssignedEmployees";
            this.listboxAssignedEmployees.Size = new System.Drawing.Size(281, 394);
            this.listboxAssignedEmployees.TabIndex = 15;
            // 
            // listboxAvailableEmployees
            // 
            this.listboxAvailableEmployees.FormattingEnabled = true;
            this.listboxAvailableEmployees.Location = new System.Drawing.Point(18, 32);
            this.listboxAvailableEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.listboxAvailableEmployees.Name = "listboxAvailableEmployees";
            this.listboxAvailableEmployees.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listboxAvailableEmployees.Size = new System.Drawing.Size(288, 394);
            this.listboxAvailableEmployees.TabIndex = 13;
            this.listboxAvailableEmployees.SelectedIndexChanged += new System.EventHandler(this.listboxAvailableEmployees_SelectedIndexChanged);
            // 
            // monthCalendarScheduling
            // 
            this.monthCalendarScheduling.Location = new System.Drawing.Point(315, 32);
            this.monthCalendarScheduling.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendarScheduling.Name = "monthCalendarScheduling";
            this.monthCalendarScheduling.TabIndex = 12;
            this.monthCalendarScheduling.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarScheduling_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Employee(s)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Assigned Employee(s)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 446);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(814, 82);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.ckbMorning.Location = new System.Drawing.Point(359, 288);
            this.ckbMorning.Name = "ckbMorning";
            this.ckbMorning.Size = new System.Drawing.Size(121, 17);
            this.ckbMorning.TabIndex = 28;
            this.ckbMorning.Text = "Morning(8:00-12:00)";
            this.ckbMorning.UseVisualStyleBackColor = true;
            // 
            // ckbAfternoon
            // 
            this.ckbAfternoon.AutoSize = true;
            this.ckbAfternoon.Location = new System.Drawing.Point(359, 310);
            this.ckbAfternoon.Name = "ckbAfternoon";
            this.ckbAfternoon.Size = new System.Drawing.Size(135, 17);
            this.ckbAfternoon.TabIndex = 29;
            this.ckbAfternoon.Text = "Afternoon(12:30-17:00)";
            this.ckbAfternoon.UseVisualStyleBackColor = true;
            // 
            // CkbEvening
            // 
            this.CkbEvening.AutoSize = true;
            this.CkbEvening.Location = new System.Drawing.Point(359, 333);
            this.CkbEvening.Name = "CkbEvening";
            this.CkbEvening.Size = new System.Drawing.Size(128, 17);
            this.CkbEvening.TabIndex = 31;
            this.CkbEvening.Text = "Evening(17:00-21:30)";
            this.CkbEvening.UseVisualStyleBackColor = true;
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 535);
            this.Controls.Add(this.CkbEvening);
            this.Controls.Add(this.ckbAfternoon);
            this.Controls.Add(this.ckbMorning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRmvEmployeeShift);
            this.Controls.Add(this.btnAddEmpShift);
            this.Controls.Add(this.listboxAssignedEmployees);
            this.Controls.Add(this.listboxAvailableEmployees);
            this.Controls.Add(this.monthCalendarScheduling);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Scheduling";
            this.Text = "Scheduling";
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbMorning;
        private System.Windows.Forms.CheckBox ckbAfternoon;
        private System.Windows.Forms.CheckBox CkbEvening;
    }
}