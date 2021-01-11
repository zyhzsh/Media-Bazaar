
namespace Proj_Desktop_App.presentation
{
    partial class DepartmentsForm
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
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.lbEmployees = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.Label();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.lblNrOfEmployees = new System.Windows.Forms.Label();
            this.lblNrOfProducts = new System.Windows.Forms.Label();
            this.chBSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(132, 26);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(315, 28);
            this.cbDepartment.TabIndex = 0;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(17, 29);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(109, 20);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Department:";
            // 
            // lvEmployees
            // 
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBSN,
            this.chFName,
            this.chLName,
            this.chPosition});
            this.lvEmployees.HideSelection = false;
            this.lvEmployees.Location = new System.Drawing.Point(21, 113);
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(426, 314);
            this.lvEmployees.TabIndex = 2;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCode,
            this.chName,
            this.chBrand});
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(463, 113);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(426, 314);
            this.lvProducts.TabIndex = 3;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.Location = new System.Drawing.Point(751, 25);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(138, 28);
            this.btnAddDepartment.TabIndex = 4;
            this.btnAddDepartment.Text = "Add department";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // lbEmployees
            // 
            this.lbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployees.AutoSize = true;
            this.lbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployees.Location = new System.Drawing.Point(18, 87);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(101, 20);
            this.lbEmployees.TabIndex = 5;
            this.lbEmployees.Text = "Employees:";
            // 
            // lbProducts
            // 
            this.lbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProducts.AutoSize = true;
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.Location = new System.Drawing.Point(460, 87);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(85, 20);
            this.lbProducts.TabIndex = 6;
            this.lbProducts.Text = "Products:";
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDepartment.Location = new System.Drawing.Point(463, 25);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(138, 28);
            this.btnEditDepartment.TabIndex = 7;
            this.btnEditDepartment.Text = "Edit";
            this.btnEditDepartment.UseVisualStyleBackColor = false;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRemoveDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDepartment.Location = new System.Drawing.Point(607, 25);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(138, 28);
            this.btnRemoveDepartment.TabIndex = 8;
            this.btnRemoveDepartment.Text = "Remove";
            this.btnRemoveDepartment.UseVisualStyleBackColor = false;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // lblNrOfEmployees
            // 
            this.lblNrOfEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNrOfEmployees.AutoSize = true;
            this.lblNrOfEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOfEmployees.Location = new System.Drawing.Point(125, 87);
            this.lblNrOfEmployees.Name = "lblNrOfEmployees";
            this.lblNrOfEmployees.Size = new System.Drawing.Size(27, 20);
            this.lblNrOfEmployees.TabIndex = 9;
            this.lblNrOfEmployees.Text = "00";
            // 
            // lblNrOfProducts
            // 
            this.lblNrOfProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNrOfProducts.AutoSize = true;
            this.lblNrOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOfProducts.Location = new System.Drawing.Point(551, 87);
            this.lblNrOfProducts.Name = "lblNrOfProducts";
            this.lblNrOfProducts.Size = new System.Drawing.Size(27, 20);
            this.lblNrOfProducts.TabIndex = 10;
            this.lblNrOfProducts.Text = "00";
            // 
            // chBSN
            // 
            this.chBSN.Text = "123456789";
            this.chBSN.Width = 90;
            // 
            // chFName
            // 
            this.chFName.Text = "First name";
            this.chFName.Width = 100;
            // 
            // chLName
            // 
            this.chLName.Text = "Last name";
            this.chLName.Width = 100;
            // 
            // chPosition
            // 
            this.chPosition.Text = "Position";
            this.chPosition.Width = 100;
            // 
            // chCode
            // 
            this.chCode.Text = "Code";
            this.chCode.Width = 120;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 120;
            // 
            // chBrand
            // 
            this.chBrand.Text = "Brand";
            this.chBrand.Width = 120;
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 447);
            this.Controls.Add(this.lblNrOfProducts);
            this.Controls.Add(this.lblNrOfEmployees);
            this.Controls.Add(this.btnRemoveDepartment);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.lbEmployees);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.lvEmployees);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.cbDepartment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentsForm";
            this.Text = "DepartmentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ListView lvEmployees;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Label lbEmployees;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.Label lblNrOfEmployees;
        private System.Windows.Forms.Label lblNrOfProducts;
        private System.Windows.Forms.ColumnHeader chBSN;
        private System.Windows.Forms.ColumnHeader chFName;
        private System.Windows.Forms.ColumnHeader chLName;
        private System.Windows.Forms.ColumnHeader chPosition;
        private System.Windows.Forms.ColumnHeader chCode;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chBrand;
    }
}