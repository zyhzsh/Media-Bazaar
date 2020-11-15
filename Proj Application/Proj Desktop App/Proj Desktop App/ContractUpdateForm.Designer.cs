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
            this.SuspendLayout();
            // 
            // lblActiveContract
            // 
            this.lblActiveContract.AutoSize = true;
            this.lblActiveContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveContract.Location = new System.Drawing.Point(12, 18);
            this.lblActiveContract.Name = "lblActiveContract";
            this.lblActiveContract.Size = new System.Drawing.Size(129, 20);
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
            this.lvActiveContract.Location = new System.Drawing.Point(15, 41);
            this.lvActiveContract.MultiSelect = false;
            this.lvActiveContract.Name = "lvActiveContract";
            this.lvActiveContract.Size = new System.Drawing.Size(572, 52);
            this.lvActiveContract.TabIndex = 28;
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
            this.lblAction.Location = new System.Drawing.Point(12, 115);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(80, 20);
            this.lblAction.TabIndex = 29;
            this.lblAction.Text = "<Action>";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(444, 109);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(143, 32);
            this.btnConfirm.TabIndex = 31;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ContractUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 157);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lvActiveContract);
            this.Controls.Add(this.lblActiveContract);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ContractUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContractUpdateForm";
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
    }
}