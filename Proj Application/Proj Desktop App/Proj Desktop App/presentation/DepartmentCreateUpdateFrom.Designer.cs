
namespace Proj_Desktop_App.presentation
{
    partial class DepartmentCreateUpdateFrom
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbSellsProducts = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.gbDepartment = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSellsProducts = new System.Windows.Forms.Label();
            this.gbDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(123, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(229, 27);
            this.tbName.TabIndex = 0;
            // 
            // cbSellsProducts
            // 
            this.cbSellsProducts.AutoSize = true;
            this.cbSellsProducts.Checked = true;
            this.cbSellsProducts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSellsProducts.Location = new System.Drawing.Point(123, 93);
            this.cbSellsProducts.Name = "cbSellsProducts";
            this.cbSellsProducts.Size = new System.Drawing.Size(15, 14);
            this.cbSellsProducts.TabIndex = 1;
            this.cbSellsProducts.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(55, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 40);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(242, 168);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(178, 40);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(123, 24);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(71, 27);
            this.tbId.TabIndex = 21;
            // 
            // gbDepartment
            // 
            this.gbDepartment.Controls.Add(this.lblId);
            this.gbDepartment.Controls.Add(this.lblName);
            this.gbDepartment.Controls.Add(this.tbId);
            this.gbDepartment.Controls.Add(this.lblSellsProducts);
            this.gbDepartment.Controls.Add(this.tbName);
            this.gbDepartment.Controls.Add(this.cbSellsProducts);
            this.gbDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepartment.Location = new System.Drawing.Point(55, 25);
            this.gbDepartment.Name = "gbDepartment";
            this.gbDepartment.Size = new System.Drawing.Size(365, 126);
            this.gbDepartment.TabIndex = 30;
            this.gbDepartment.TabStop = false;
            this.gbDepartment.Text = "Add Departement";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(9, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 19);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 19);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblSellsProducts
            // 
            this.lblSellsProducts.AutoSize = true;
            this.lblSellsProducts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellsProducts.Location = new System.Drawing.Point(9, 90);
            this.lblSellsProducts.Name = "lblSellsProducts";
            this.lblSellsProducts.Size = new System.Drawing.Size(103, 19);
            this.lblSellsProducts.TabIndex = 16;
            this.lblSellsProducts.Text = "Sells products:";
            // 
            // DepartmentCreateUpdateFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 237);
            this.Controls.Add(this.gbDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DepartmentCreateUpdateFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentCreateUpdateFrom";
            this.gbDepartment.ResumeLayout(false);
            this.gbDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox cbSellsProducts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.GroupBox gbDepartment;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSellsProducts;
    }
}