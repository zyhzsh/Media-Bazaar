namespace Proj_Desktop_App
{
    partial class ContractUpdateForm
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
            this.lblActiveContract = new System.Windows.Forms.Label();
            this.lvActiveContract = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFTE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAction = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblMonths = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.dtpOtherStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.nudFTE = new System.Windows.Forms.NumericUpDown();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblFTE = new System.Windows.Forms.Label();
            this.rbEndOfPrevious = new System.Windows.Forms.RadioButton();
            this.rbOtherStartDate = new System.Windows.Forms.RadioButton();
            this.gbStartDate = new System.Windows.Forms.GroupBox();
            this.gbContractDetails = new System.Windows.Forms.GroupBox();
            this.rbChangeDetails = new System.Windows.Forms.RadioButton();
            this.rbSameAsPrevious = new System.Windows.Forms.RadioButton();
            this.gbEndDate = new System.Windows.Forms.GroupBox();
            this.pnlExtendContract = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTE)).BeginInit();
            this.gbStartDate.SuspendLayout();
            this.gbContractDetails.SuspendLayout();
            this.gbEndDate.SuspendLayout();
            this.pnlExtendContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActiveContract
            // 
            this.lblActiveContract.AutoSize = true;
            this.lblActiveContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveContract.Location = new System.Drawing.Point(8, 9);
            this.lblActiveContract.Name = "lblActiveContract";
            this.lblActiveContract.Size = new System.Drawing.Size(182, 29);
            this.lblActiveContract.TabIndex = 0;
            this.lblActiveContract.Text = "Active contract";
            // 
            // lvActiveContract
            // 
            this.lvActiveContract.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chStartDate,
            this.chEndDate,
            this.chPosition,
            this.chDepartment,
            this.chFTE,
            this.chSalary});
            this.lvActiveContract.HideSelection = false;
            this.lvActiveContract.Location = new System.Drawing.Point(12, 32);
            this.lvActiveContract.MultiSelect = false;
            this.lvActiveContract.Name = "lvActiveContract";
            this.lvActiveContract.Size = new System.Drawing.Size(575, 52);
            this.lvActiveContract.TabIndex = 1;
            this.lvActiveContract.UseCompatibleStateImageBehavior = false;
            this.lvActiveContract.View = System.Windows.Forms.View.Details;
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
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(8, 101);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(115, 29);
            this.lblAction.TabIndex = 2;
            this.lblAction.Text = "<Action>";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(444, 339);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(143, 32);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonths.Location = new System.Drawing.Point(118, 55);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(99, 29);
            this.lblMonths.TabIndex = 26;
            this.lblMonths.Text = "(months)";
            // 
            // nudDuration
            // 
            this.nudDuration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDuration.Location = new System.Drawing.Point(41, 53);
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
            this.nudDuration.Size = new System.Drawing.Size(71, 37);
            this.nudDuration.TabIndex = 7;
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
            this.lblDuration.Location = new System.Drawing.Point(20, 23);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(106, 29);
            this.lblDuration.TabIndex = 25;
            this.lblDuration.Text = "Duration:";
            // 
            // dtpOtherStartDate
            // 
            this.dtpOtherStartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOtherStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOtherStartDate.Location = new System.Drawing.Point(38, 56);
            this.dtpOtherStartDate.Name = "dtpOtherStartDate";
            this.dtpOtherStartDate.Size = new System.Drawing.Size(147, 37);
            this.dtpOtherStartDate.TabIndex = 6;
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(130, 93);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(195, 37);
            this.cbPosition.TabIndex = 10;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(130, 126);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(195, 37);
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
            this.nudFTE.Location = new System.Drawing.Point(130, 159);
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
            this.nudFTE.Size = new System.Drawing.Size(195, 37);
            this.nudFTE.TabIndex = 12;
            this.nudFTE.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(34, 129);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(139, 29);
            this.lblDepartment.TabIndex = 19;
            this.lblDepartment.Text = "Department:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(34, 96);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(98, 29);
            this.lblPosition.TabIndex = 21;
            this.lblPosition.Text = "Position:";
            // 
            // lblFTE
            // 
            this.lblFTE.AutoSize = true;
            this.lblFTE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTE.Location = new System.Drawing.Point(34, 161);
            this.lblFTE.Name = "lblFTE";
            this.lblFTE.Size = new System.Drawing.Size(54, 29);
            this.lblFTE.TabIndex = 23;
            this.lblFTE.Text = "FTE:";
            // 
            // rbEndOfPrevious
            // 
            this.rbEndOfPrevious.AutoSize = true;
            this.rbEndOfPrevious.Location = new System.Drawing.Point(18, 28);
            this.rbEndOfPrevious.Name = "rbEndOfPrevious";
            this.rbEndOfPrevious.Size = new System.Drawing.Size(205, 33);
            this.rbEndOfPrevious.TabIndex = 4;
            this.rbEndOfPrevious.TabStop = true;
            this.rbEndOfPrevious.Text = "End of previous";
            this.rbEndOfPrevious.UseVisualStyleBackColor = true;
            this.rbEndOfPrevious.CheckedChanged += new System.EventHandler(this.rbEndOfPrevious_CheckedChanged);
            // 
            // rbOtherStartDate
            // 
            this.rbOtherStartDate.AutoSize = true;
            this.rbOtherStartDate.Location = new System.Drawing.Point(18, 65);
            this.rbOtherStartDate.Name = "rbOtherStartDate";
            this.rbOtherStartDate.Size = new System.Drawing.Size(21, 20);
            this.rbOtherStartDate.TabIndex = 5;
            this.rbOtherStartDate.TabStop = true;
            this.rbOtherStartDate.UseVisualStyleBackColor = true;
            // 
            // gbStartDate
            // 
            this.gbStartDate.Controls.Add(this.rbEndOfPrevious);
            this.gbStartDate.Controls.Add(this.dtpOtherStartDate);
            this.gbStartDate.Controls.Add(this.rbOtherStartDate);
            this.gbStartDate.Location = new System.Drawing.Point(0, 0);
            this.gbStartDate.Name = "gbStartDate";
            this.gbStartDate.Size = new System.Drawing.Size(204, 100);
            this.gbStartDate.TabIndex = 35;
            this.gbStartDate.TabStop = false;
            this.gbStartDate.Text = "Start date";
            // 
            // gbContractDetails
            // 
            this.gbContractDetails.Controls.Add(this.rbChangeDetails);
            this.gbContractDetails.Controls.Add(this.rbSameAsPrevious);
            this.gbContractDetails.Controls.Add(this.cbDepartment);
            this.gbContractDetails.Controls.Add(this.lblDepartment);
            this.gbContractDetails.Controls.Add(this.lblPosition);
            this.gbContractDetails.Controls.Add(this.nudFTE);
            this.gbContractDetails.Controls.Add(this.lblFTE);
            this.gbContractDetails.Controls.Add(this.cbPosition);
            this.gbContractDetails.Location = new System.Drawing.Point(219, 0);
            this.gbContractDetails.Name = "gbContractDetails";
            this.gbContractDetails.Size = new System.Drawing.Size(356, 200);
            this.gbContractDetails.TabIndex = 36;
            this.gbContractDetails.TabStop = false;
            this.gbContractDetails.Text = "Contract details";
            // 
            // rbChangeDetails
            // 
            this.rbChangeDetails.AutoSize = true;
            this.rbChangeDetails.Location = new System.Drawing.Point(18, 60);
            this.rbChangeDetails.Name = "rbChangeDetails";
            this.rbChangeDetails.Size = new System.Drawing.Size(128, 33);
            this.rbChangeDetails.TabIndex = 9;
            this.rbChangeDetails.TabStop = true;
            this.rbChangeDetails.Text = "Change:";
            this.rbChangeDetails.UseVisualStyleBackColor = true;
            // 
            // rbSameAsPrevious
            // 
            this.rbSameAsPrevious.AutoSize = true;
            this.rbSameAsPrevious.Location = new System.Drawing.Point(18, 28);
            this.rbSameAsPrevious.Name = "rbSameAsPrevious";
            this.rbSameAsPrevious.Size = new System.Drawing.Size(329, 33);
            this.rbSameAsPrevious.TabIndex = 8;
            this.rbSameAsPrevious.Text = "Keep the same as previous";
            this.rbSameAsPrevious.UseVisualStyleBackColor = true;
            this.rbSameAsPrevious.CheckedChanged += new System.EventHandler(this.rbSameAsPrevious_CheckedChanged);
            // 
            // gbEndDate
            // 
            this.gbEndDate.Controls.Add(this.lblDuration);
            this.gbEndDate.Controls.Add(this.nudDuration);
            this.gbEndDate.Controls.Add(this.lblMonths);
            this.gbEndDate.Location = new System.Drawing.Point(0, 106);
            this.gbEndDate.Name = "gbEndDate";
            this.gbEndDate.Size = new System.Drawing.Size(204, 94);
            this.gbEndDate.TabIndex = 36;
            this.gbEndDate.TabStop = false;
            this.gbEndDate.Text = "End date";
            // 
            // pnlExtendContract
            // 
            this.pnlExtendContract.Controls.Add(this.gbStartDate);
            this.pnlExtendContract.Controls.Add(this.gbEndDate);
            this.pnlExtendContract.Controls.Add(this.gbContractDetails);
            this.pnlExtendContract.Enabled = false;
            this.pnlExtendContract.Location = new System.Drawing.Point(12, 133);
            this.pnlExtendContract.Name = "pnlExtendContract";
            this.pnlExtendContract.Size = new System.Drawing.Size(575, 200);
            this.pnlExtendContract.TabIndex = 37;
            this.pnlExtendContract.Visible = false;
            // 
            // ContractUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 384);
            this.Controls.Add(this.pnlExtendContract);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lvActiveContract);
            this.Controls.Add(this.lblActiveContract);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContractUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContractUpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTE)).EndInit();
            this.gbStartDate.ResumeLayout(false);
            this.gbStartDate.PerformLayout();
            this.gbContractDetails.ResumeLayout(false);
            this.gbContractDetails.PerformLayout();
            this.gbEndDate.ResumeLayout(false);
            this.gbEndDate.PerformLayout();
            this.pnlExtendContract.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActiveContract;
        private System.Windows.Forms.ListView lvActiveContract;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chStartDate;
        private System.Windows.Forms.ColumnHeader chEndDate;
        private System.Windows.Forms.ColumnHeader chPosition;
        private System.Windows.Forms.ColumnHeader chDepartment;
        private System.Windows.Forms.ColumnHeader chFTE;
        private System.Windows.Forms.ColumnHeader chSalary;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.DateTimePicker dtpOtherStartDate;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.NumericUpDown nudFTE;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblFTE;
        private System.Windows.Forms.RadioButton rbEndOfPrevious;
        private System.Windows.Forms.RadioButton rbOtherStartDate;
        private System.Windows.Forms.GroupBox gbStartDate;
        private System.Windows.Forms.GroupBox gbContractDetails;
        private System.Windows.Forms.RadioButton rbChangeDetails;
        private System.Windows.Forms.RadioButton rbSameAsPrevious;
        private System.Windows.Forms.GroupBox gbEndDate;
        private System.Windows.Forms.Panel pnlExtendContract;
    }
}