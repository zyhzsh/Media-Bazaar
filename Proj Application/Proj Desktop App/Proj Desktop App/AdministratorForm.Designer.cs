namespace Proj_Desktop_App
{
    partial class AdministratorForm
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.tbBSN = new System.Windows.Forms.TextBox();
            this.lblBSN = new System.Windows.Forms.Label();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnFireEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 12);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(204, 43);
            this.btnAddEmployee.TabIndex = 32;
            this.btnAddEmployee.Text = "Add new employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(12, 234);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(204, 43);
            this.btnUpdateEmployee.TabIndex = 33;
            this.btnUpdateEmployee.Text = "Update employee info";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // tbBSN
            // 
            this.tbBSN.Location = new System.Drawing.Point(53, 152);
            this.tbBSN.Name = "tbBSN";
            this.tbBSN.Size = new System.Drawing.Size(163, 37);
            this.tbBSN.TabIndex = 34;
            // 
            // lblBSN
            // 
            this.lblBSN.AutoSize = true;
            this.lblBSN.Location = new System.Drawing.Point(8, 155);
            this.lblBSN.Name = "lblBSN";
            this.lblBSN.Size = new System.Drawing.Size(59, 29);
            this.lblBSN.TabIndex = 35;
            this.lblBSN.Text = "BSN:";
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 29;
            this.lbEmployees.Location = new System.Drawing.Point(222, 12);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(400, 294);
            this.lbEmployees.TabIndex = 36;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(12, 185);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(204, 43);
            this.btnShowInfo.TabIndex = 37;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.Location = new System.Drawing.Point(12, 283);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(204, 43);
            this.btnFireEmployee.TabIndex = 38;
            this.btnFireEmployee.Text = "Fire employee";
            this.btnFireEmployee.UseVisualStyleBackColor = true;
            this.btnFireEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 620);
            this.Controls.Add(this.btnFireEmployee);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.lbEmployees);
            this.Controls.Add(this.tbBSN);
            this.Controls.Add(this.lblBSN);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.TextBox tbBSN;
        private System.Windows.Forms.Label lblBSN;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnFireEmployee;
    }
}