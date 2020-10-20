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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.tbBSN = new System.Windows.Forms.TextBox();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnFireEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.miDepartments = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddEmployee.Location = new System.Drawing.Point(24, 360);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(160, 41);
            this.btnAddEmployee.TabIndex = 32;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(356, 360);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(160, 41);
            this.btnUpdateEmployee.TabIndex = 33;
            this.btnUpdateEmployee.Text = "Update info";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // tbBSN
            // 
            this.tbBSN.Location = new System.Drawing.Point(401, 24);
            this.tbBSN.Multiline = true;
            this.tbBSN.Name = "tbBSN";
            this.tbBSN.Size = new System.Drawing.Size(183, 26);
            this.tbBSN.TabIndex = 34;
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 29;
            this.lbEmployees.Location = new System.Drawing.Point(24, 62);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(658, 265);
            this.lbEmployees.TabIndex = 36;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowInfo.Location = new System.Drawing.Point(190, 360);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(160, 41);
            this.btnShowInfo.TabIndex = 37;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.btnFireEmployee.Location = new System.Drawing.Point(522, 360);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(160, 41);
            this.btnFireEmployee.TabIndex = 38;
            this.btnFireEmployee.Text = "Fire employee";
            this.btnFireEmployee.UseVisualStyleBackColor = false;
            this.btnFireEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(590, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 43;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEmployees,
            this.miDepartments,
            this.miLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(128, 421);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miEmployees
            // 
            this.miEmployees.AutoSize = false;
            this.miEmployees.BackColor = System.Drawing.Color.Transparent;
            this.miEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miEmployees.Image = ((System.Drawing.Image)(resources.GetObject("miEmployees.Image")));
            this.miEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miEmployees.Name = "miEmployees";
            this.miEmployees.Padding = new System.Windows.Forms.Padding(0);
            this.miEmployees.Size = new System.Drawing.Size(121, 70);
            this.miEmployees.Text = "Employees";
            this.miEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miEmployees.Click += new System.EventHandler(this.EmployeesTab_Click);
            // 
            // miDepartments
            // 
            this.miDepartments.AutoSize = false;
            this.miDepartments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miDepartments.Image = ((System.Drawing.Image)(resources.GetObject("miDepartments.Image")));
            this.miDepartments.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miDepartments.Name = "miDepartments";
            this.miDepartments.Padding = new System.Windows.Forms.Padding(0);
            this.miDepartments.Size = new System.Drawing.Size(121, 70);
            this.miDepartments.Text = "Departments";
            this.miDepartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miDepartments.Click += new System.EventHandler(this.DepartmentsTab_Click);
            // 
            // miLogout
            // 
            this.miLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miLogout.AutoSize = false;
            this.miLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miLogout.Image = ((System.Drawing.Image)(resources.GetObject("miLogout.Image")));
            this.miLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miLogout.Name = "miLogout";
            this.miLogout.Padding = new System.Windows.Forms.Padding(0);
            this.miLogout.Size = new System.Drawing.Size(121, 70);
            this.miLogout.Text = "Log out";
            this.miLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miLogout.Click += new System.EventHandler(this.LogoutTab_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BSN",
            "Name",
            "Email"});
            this.comboBox1.Location = new System.Drawing.Point(317, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 37);
            this.comboBox1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Total employees: ";
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.Controls.Add(this.label1);
            this.pnlEmployees.Controls.Add(this.btnAddEmployee);
            this.pnlEmployees.Controls.Add(this.comboBox1);
            this.pnlEmployees.Controls.Add(this.btnUpdateEmployee);
            this.pnlEmployees.Controls.Add(this.button1);
            this.pnlEmployees.Controls.Add(this.tbBSN);
            this.pnlEmployees.Controls.Add(this.btnFireEmployee);
            this.pnlEmployees.Controls.Add(this.lbEmployees);
            this.pnlEmployees.Controls.Add(this.btnShowInfo);
            this.pnlEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployees.Location = new System.Drawing.Point(128, 0);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(711, 421);
            this.pnlEmployees.TabIndex = 47;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 421);
            this.Controls.Add(this.pnlEmployees);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.TextBox tbBSN;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnFireEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miEmployees;
        private System.Windows.Forms.ToolStripMenuItem miDepartments;
        private System.Windows.Forms.ToolStripMenuItem miLogout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEmployees;
    }
}