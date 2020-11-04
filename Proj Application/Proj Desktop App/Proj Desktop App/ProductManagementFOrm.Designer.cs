namespace Proj_Desktop_App
{
    partial class ProductManagementForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.gbProductDetails = new System.Windows.Forms.GroupBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numBuyingPrice = new System.Windows.Forms.NumericUpDown();
            this.lblBuyingPrice = new System.Windows.Forms.Label();
            this.numSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
<<<<<<< HEAD
            this.btnCancel.Location = new System.Drawing.Point(68, 334);
=======
            this.btnCancel.Location = new System.Drawing.Point(68, 360);
>>>>>>> website
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(204, 43);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Floor 1",
            "Floor 2",
            "Floor 3",
            "Floor 4"});
            this.cbDepartment.Location = new System.Drawing.Point(109, 136);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(204, 24);
            this.cbDepartment.TabIndex = 11;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(17, 139);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(86, 17);
            this.lblDepartment.TabIndex = 19;
            this.lblDepartment.Text = "Department:";
            // 
            // gbProductDetails
            // 
            this.gbProductDetails.Controls.Add(this.rtbDescription);
            this.gbProductDetails.Controls.Add(this.label1);
            this.gbProductDetails.Controls.Add(this.numBuyingPrice);
            this.gbProductDetails.Controls.Add(this.lblBuyingPrice);
            this.gbProductDetails.Controls.Add(this.cbDepartment);
            this.gbProductDetails.Controls.Add(this.numSellingPrice);
            this.gbProductDetails.Controls.Add(this.lblSellingPrice);
            this.gbProductDetails.Controls.Add(this.lblDepartment);
            this.gbProductDetails.Controls.Add(this.lblProductName);
            this.gbProductDetails.Controls.Add(this.lblBrand);
            this.gbProductDetails.Controls.Add(this.tbProductName);
            this.gbProductDetails.Controls.Add(this.tbBrand);
            this.gbProductDetails.Location = new System.Drawing.Point(12, 12);
            this.gbProductDetails.Name = "gbProductDetails";
            this.gbProductDetails.Size = new System.Drawing.Size(324, 266);
            this.gbProductDetails.TabIndex = 33;
            this.gbProductDetails.TabStop = false;
            this.gbProductDetails.Text = "Product Details";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(109, 169);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(204, 91);
            this.rtbDescription.TabIndex = 22;
            this.rtbDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Description:";
            // 
            // numBuyingPrice
            // 
            this.numBuyingPrice.DecimalPlaces = 2;
            this.numBuyingPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBuyingPrice.Location = new System.Drawing.Point(109, 106);
            this.numBuyingPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.numBuyingPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBuyingPrice.Name = "numBuyingPrice";
            this.numBuyingPrice.Size = new System.Drawing.Size(204, 22);
            this.numBuyingPrice.TabIndex = 9;
            this.numBuyingPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lblBuyingPrice
            // 
            this.lblBuyingPrice.AutoSize = true;
            this.lblBuyingPrice.Location = new System.Drawing.Point(13, 108);
            this.lblBuyingPrice.Name = "lblBuyingPrice";
            this.lblBuyingPrice.Size = new System.Drawing.Size(90, 17);
            this.lblBuyingPrice.TabIndex = 8;
            this.lblBuyingPrice.Text = "Buying price:";
            // 
            // numSellingPrice
            // 
            this.numSellingPrice.DecimalPlaces = 2;
            this.numSellingPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSellingPrice.Location = new System.Drawing.Point(109, 78);
            this.numSellingPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.numSellingPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSellingPrice.Name = "numSellingPrice";
            this.numSellingPrice.Size = new System.Drawing.Size(204, 22);
            this.numSellingPrice.TabIndex = 7;
            this.numSellingPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Location = new System.Drawing.Point(14, 80);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(89, 17);
            this.lblSellingPrice.TabIndex = 6;
            this.lblSellingPrice.Text = "Selling price:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(3, 24);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(100, 17);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product name:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(53, 52);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(50, 17);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Brand:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(109, 21);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(204, 22);
            this.tbProductName.TabIndex = 2;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(110, 49);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(204, 22);
            this.tbBrand.TabIndex = 3;
            // 
            // btnConfirm
            // 
<<<<<<< HEAD
            this.btnConfirm.Location = new System.Drawing.Point(68, 284);
=======
            this.btnConfirm.Location = new System.Drawing.Point(68, 310);
>>>>>>> website
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(204, 43);
            this.btnConfirm.TabIndex = 31;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(345, 383);
=======
            this.ClientSize = new System.Drawing.Size(345, 407);
>>>>>>> website
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbProductDetails);
            this.Controls.Add(this.btnConfirm);
            this.Name = "ProductManagementForm";
            this.Text = "ProductManagementForm";
            this.gbProductDetails.ResumeLayout(false);
            this.gbProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.GroupBox gbProductDetails;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.NumericUpDown numBuyingPrice;
        private System.Windows.Forms.Label lblBuyingPrice;
        private System.Windows.Forms.NumericUpDown numSellingPrice;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label1;
    }
}