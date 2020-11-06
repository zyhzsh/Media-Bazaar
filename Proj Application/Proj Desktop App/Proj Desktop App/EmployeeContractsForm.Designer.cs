namespace Proj_Desktop_App
{
    partial class EmployeeContractsForm
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
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lbContracts = new System.Windows.Forms.ListBox();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(188, 39);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(620, 28);
            this.cbEmployee.TabIndex = 1;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(432, 439);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(376, 41);
            this.btnShowDetails.TabIndex = 4;
            this.btnShowDetails.Text = "Terminate contract";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(41, 439);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(376, 41);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Extend contract";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // lbContracts
            // 
            this.lbContracts.FormattingEnabled = true;
            this.lbContracts.ItemHeight = 20;
            this.lbContracts.Location = new System.Drawing.Point(41, 82);
            this.lbContracts.Name = "lbContracts";
            this.lbContracts.Size = new System.Drawing.Size(767, 344);
            this.lbContracts.TabIndex = 2;
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.AutoSize = true;
            this.lblTotalEmployees.Location = new System.Drawing.Point(46, 43);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(136, 20);
            this.lblTotalEmployees.TabIndex = 17;
            this.lblTotalEmployees.Text = "Select Employee: ";
            // 
            // EmployeeContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 478);
            this.Controls.Add(this.lblTotalEmployees);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lbContracts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeContractsForm";
            this.Text = "EmployeeContractsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ListBox lbContracts;
        private System.Windows.Forms.Label lblTotalEmployees;
    }
}