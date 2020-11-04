namespace Proj_Desktop_App
{
    partial class EmployeesForm
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnViewContract = new System.Windows.Forms.Button();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.tbBSN = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 20;
            this.lbEmployees.Location = new System.Drawing.Point(16, 55);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(767, 344);
            this.lbEmployees.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(16, 412);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(180, 41);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(212, 411);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(180, 41);
            this.btnShowDetails.TabIndex = 3;
            this.btnShowDetails.Text = "Show details";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Location = new System.Drawing.Point(407, 412);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(180, 41);
            this.btnUpdateDetails.TabIndex = 4;
            this.btnUpdateDetails.Text = "Update details";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // btnViewContract
            // 
            this.btnViewContract.Location = new System.Drawing.Point(603, 412);
            this.btnViewContract.Name = "btnViewContract";
            this.btnViewContract.Size = new System.Drawing.Size(180, 41);
            this.btnViewContract.TabIndex = 5;
            this.btnViewContract.Text = "View contract";
            this.btnViewContract.UseVisualStyleBackColor = true;
            this.btnViewContract.Click += new System.EventHandler(this.btnViewContract_Click);
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.AutoSize = true;
            this.lblTotalEmployees.Location = new System.Drawing.Point(12, 16);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(132, 20);
            this.lblTotalEmployees.TabIndex = 9;
            this.lblTotalEmployees.Text = "Total employees: ";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "BSN",
            "Name"});
            this.cbSearchBy.Location = new System.Drawing.Point(212, 12);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(99, 28);
            this.cbSearchBy.TabIndex = 6;
            // 
            // tbBSN
            // 
            this.tbBSN.Location = new System.Drawing.Point(317, 12);
            this.tbBSN.Multiline = true;
            this.tbBSN.Name = "tbBSN";
            this.tbBSN.Size = new System.Drawing.Size(367, 28);
            this.tbBSN.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(690, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 29);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 478);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTotalEmployees);
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.tbBSN);
            this.Controls.Add(this.btnViewContract);
            this.Controls.Add(this.btnUpdateDetails);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lbEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnViewContract;
        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.TextBox tbBSN;
        private System.Windows.Forms.Button btnSearch;
    }
}