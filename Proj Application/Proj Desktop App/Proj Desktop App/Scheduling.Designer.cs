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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listboxAvailableEmployees = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btnRmvEmployeeShift
            // 
            this.btnRmvEmployeeShift.Location = new System.Drawing.Point(278, 386);
            this.btnRmvEmployeeShift.Name = "btnRmvEmployeeShift";
            this.btnRmvEmployeeShift.Size = new System.Drawing.Size(86, 89);
            this.btnRmvEmployeeShift.TabIndex = 17;
            this.btnRmvEmployeeShift.Text = "Remove employee from shift";
            this.btnRmvEmployeeShift.UseVisualStyleBackColor = true;
            // 
            // btnAddEmpShift
            // 
            this.btnAddEmpShift.Location = new System.Drawing.Point(8, 386);
            this.btnAddEmpShift.Name = "btnAddEmpShift";
            this.btnAddEmpShift.Size = new System.Drawing.Size(86, 89);
            this.btnAddEmpShift.TabIndex = 16;
            this.btnAddEmpShift.Text = "Assign employee to shift";
            this.btnAddEmpShift.UseVisualStyleBackColor = true;
            // 
            // listboxAssignedEmployees
            // 
            this.listboxAssignedEmployees.FormattingEnabled = true;
            this.listboxAssignedEmployees.ItemHeight = 16;
            this.listboxAssignedEmployees.Location = new System.Drawing.Point(278, 8);
            this.listboxAssignedEmployees.Name = "listboxAssignedEmployees";
            this.listboxAssignedEmployees.Size = new System.Drawing.Size(264, 372);
            this.listboxAssignedEmployees.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.comboBox1.Location = new System.Drawing.Point(695, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // listboxAvailableEmployees
            // 
            this.listboxAvailableEmployees.FormattingEnabled = true;
            this.listboxAvailableEmployees.ItemHeight = 16;
            this.listboxAvailableEmployees.Location = new System.Drawing.Point(8, 8);
            this.listboxAvailableEmployees.Name = "listboxAvailableEmployees";
            this.listboxAvailableEmployees.Size = new System.Drawing.Size(264, 372);
            this.listboxAvailableEmployees.TabIndex = 13;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(554, 8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 486);
            this.Controls.Add(this.btnRmvEmployeeShift);
            this.Controls.Add(this.btnAddEmpShift);
            this.Controls.Add(this.listboxAssignedEmployees);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listboxAvailableEmployees);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Scheduling";
            this.Text = "Scheduling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRmvEmployeeShift;
        private System.Windows.Forms.Button btnAddEmpShift;
        private System.Windows.Forms.ListBox listboxAssignedEmployees;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listboxAvailableEmployees;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}