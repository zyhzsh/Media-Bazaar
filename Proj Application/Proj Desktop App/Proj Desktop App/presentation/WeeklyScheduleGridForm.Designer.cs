
namespace Proj_Desktop_App.presentation
{
    partial class WeeklyScheduleGridForm
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
            this.dtGrdViewWorkers = new System.Windows.Forms.DataGridView();
            this.dtGrdViewManagers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ckBoxWorkers = new System.Windows.Forms.CheckBox();
            this.ckBoxManagers = new System.Windows.Forms.CheckBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.gbSubmit = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAutoSchedule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEmployeeReports = new System.Windows.Forms.ListBox();
            this.lblWorkerStaff = new System.Windows.Forms.Label();
            this.lblManagerStaff = new System.Windows.Forms.Label();
            this.colMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewManagers)).BeginInit();
            this.gbSubmit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrdViewWorkers
            // 
            this.dtGrdViewWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewWorkers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrdViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonday,
            this.colTuesday,
            this.colWednesday,
            this.colThursday,
            this.colFriday});
            this.dtGrdViewWorkers.Location = new System.Drawing.Point(12, 100);
            this.dtGrdViewWorkers.MultiSelect = false;
            this.dtGrdViewWorkers.Name = "dtGrdViewWorkers";
            this.dtGrdViewWorkers.ReadOnly = true;
            this.dtGrdViewWorkers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtGrdViewWorkers.RowTemplate.Height = 24;
            this.dtGrdViewWorkers.Size = new System.Drawing.Size(648, 122);
            this.dtGrdViewWorkers.TabIndex = 0;
            this.dtGrdViewWorkers.SelectionChanged += new System.EventHandler(this.dtGrdViewWorkers_SelectionChanged);
            // 
            // dtGrdViewManagers
            // 
            this.dtGrdViewManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewManagers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrdViewManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewManagers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtGrdViewManagers.Location = new System.Drawing.Point(722, 100);
            this.dtGrdViewManagers.MultiSelect = false;
            this.dtGrdViewManagers.Name = "dtGrdViewManagers";
            this.dtGrdViewManagers.ReadOnly = true;
            this.dtGrdViewManagers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtGrdViewManagers.RowTemplate.Height = 24;
            this.dtGrdViewManagers.Size = new System.Drawing.Size(648, 122);
            this.dtGrdViewManagers.TabIndex = 1;
            this.dtGrdViewManagers.SelectionChanged += new System.EventHandler(this.dtGrdViewManagers_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Monday";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tuesday";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Wednesday";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Thursday";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Friday";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Workers";
            // 
            // ckBoxWorkers
            // 
            this.ckBoxWorkers.AutoSize = true;
            this.ckBoxWorkers.Location = new System.Drawing.Point(55, 21);
            this.ckBoxWorkers.Name = "ckBoxWorkers";
            this.ckBoxWorkers.Size = new System.Drawing.Size(83, 21);
            this.ckBoxWorkers.TabIndex = 4;
            this.ckBoxWorkers.Text = "Workers";
            this.ckBoxWorkers.UseVisualStyleBackColor = true;
            this.ckBoxWorkers.CheckedChanged += new System.EventHandler(this.ckBoxWorkers_CheckedChanged);
            // 
            // ckBoxManagers
            // 
            this.ckBoxManagers.AutoSize = true;
            this.ckBoxManagers.Location = new System.Drawing.Point(144, 21);
            this.ckBoxManagers.Name = "ckBoxManagers";
            this.ckBoxManagers.Size = new System.Drawing.Size(93, 21);
            this.ckBoxManagers.TabIndex = 5;
            this.ckBoxManagers.Text = "Managers";
            this.ckBoxManagers.UseVisualStyleBackColor = true;
            this.ckBoxManagers.CheckedChanged += new System.EventHandler(this.ckBoxManagers_CheckedChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(6, 73);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(113, 40);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // gbSubmit
            // 
            this.gbSubmit.Controls.Add(this.btnCancel);
            this.gbSubmit.Controls.Add(this.btnAssign);
            this.gbSubmit.Controls.Add(this.ckBoxWorkers);
            this.gbSubmit.Controls.Add(this.ckBoxManagers);
            this.gbSubmit.Enabled = false;
            this.gbSubmit.Location = new System.Drawing.Point(552, 619);
            this.gbSubmit.Name = "gbSubmit";
            this.gbSubmit.Size = new System.Drawing.Size(290, 119);
            this.gbSubmit.TabIndex = 7;
            this.gbSubmit.TabStop = false;
            this.gbSubmit.Text = "Submit";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(171, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAutoSchedule
            // 
            this.btnAutoSchedule.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAutoSchedule.Location = new System.Drawing.Point(588, 12);
            this.btnAutoSchedule.Name = "btnAutoSchedule";
            this.btnAutoSchedule.Size = new System.Drawing.Size(181, 45);
            this.btnAutoSchedule.TabIndex = 10;
            this.btnAutoSchedule.Text = "Run automatic scheduling";
            this.btnAutoSchedule.UseVisualStyleBackColor = false;
            this.btnAutoSchedule.Click += new System.EventHandler(this.btnAutoSchedule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(946, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Managers";
            // 
            // lbEmployeeReports
            // 
            this.lbEmployeeReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeReports.FormattingEnabled = true;
            this.lbEmployeeReports.ItemHeight = 38;
            this.lbEmployeeReports.Location = new System.Drawing.Point(12, 298);
            this.lbEmployeeReports.Name = "lbEmployeeReports";
            this.lbEmployeeReports.Size = new System.Drawing.Size(1358, 194);
            this.lbEmployeeReports.TabIndex = 14;
            // 
            // lblWorkerStaff
            // 
            this.lblWorkerStaff.AutoSize = true;
            this.lblWorkerStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerStaff.Location = new System.Drawing.Point(140, 225);
            this.lblWorkerStaff.Name = "lblWorkerStaff";
            this.lblWorkerStaff.Size = new System.Drawing.Size(284, 39);
            this.lblWorkerStaff.TabIndex = 15;
            this.lblWorkerStaff.Text = "too many workers";
            this.lblWorkerStaff.Visible = false;
            // 
            // lblManagerStaff
            // 
            this.lblManagerStaff.AutoSize = true;
            this.lblManagerStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerStaff.Location = new System.Drawing.Point(881, 225);
            this.lblManagerStaff.Name = "lblManagerStaff";
            this.lblManagerStaff.Size = new System.Drawing.Size(316, 39);
            this.lblManagerStaff.TabIndex = 16;
            this.lblManagerStaff.Text = "too many managers";
            this.lblManagerStaff.Visible = false;
            // 
            // colMonday
            // 
            this.colMonday.HeaderText = "Monday";
            this.colMonday.MinimumWidth = 4;
            this.colMonday.Name = "colMonday";
            // 
            // colTuesday
            // 
            this.colTuesday.HeaderText = "Tuesday";
            this.colTuesday.MinimumWidth = 6;
            this.colTuesday.Name = "colTuesday";
            // 
            // colWednesday
            // 
            this.colWednesday.HeaderText = "Wednesday";
            this.colWednesday.MinimumWidth = 6;
            this.colWednesday.Name = "colWednesday";
            // 
            // colThursday
            // 
            this.colThursday.HeaderText = "Thursday";
            this.colThursday.MinimumWidth = 6;
            this.colThursday.Name = "colThursday";
            // 
            // colFriday
            // 
            this.colFriday.HeaderText = "Friday";
            this.colFriday.MinimumWidth = 6;
            this.colFriday.Name = "colFriday";
            // 
            // WeeklyScheduleGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 750);
            this.Controls.Add(this.lblManagerStaff);
            this.Controls.Add(this.lblWorkerStaff);
            this.Controls.Add(this.lbEmployeeReports);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGrdViewManagers);
            this.Controls.Add(this.btnAutoSchedule);
            this.Controls.Add(this.gbSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGrdViewWorkers);
            this.Name = "WeeklyScheduleGridForm";
            this.Text = "WeeklyScheduleGridForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewManagers)).EndInit();
            this.gbSubmit.ResumeLayout(false);
            this.gbSubmit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdViewWorkers;
        private System.Windows.Forms.DataGridView dtGrdViewManagers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckBoxWorkers;
        private System.Windows.Forms.CheckBox ckBoxManagers;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.GroupBox gbSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAutoSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbEmployeeReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblWorkerStaff;
        private System.Windows.Forms.Label lblManagerStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFriday;
    }
}