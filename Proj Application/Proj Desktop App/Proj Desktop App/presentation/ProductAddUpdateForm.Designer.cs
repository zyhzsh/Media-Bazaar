namespace Proj_Desktop_App
{
    partial class ProductAddUpdateForm
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
            this.lblOptional1 = new System.Windows.Forms.Label();
            this.gbProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(14, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 41);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(124, 156);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(228, 27);
            this.cbDepartment.TabIndex = 11;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(6, 159);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(90, 19);
            this.lblDepartment.TabIndex = 19;
            this.lblDepartment.Text = "Department:";
            // 
            // gbProductDetails
            // 
            this.gbProductDetails.Controls.Add(this.lblOptional1);
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
            this.gbProductDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductDetails.Location = new System.Drawing.Point(14, 14);
            this.gbProductDetails.Name = "gbProductDetails";
            this.gbProductDetails.Size = new System.Drawing.Size(364, 305);
            this.gbProductDetails.TabIndex = 33;
            this.gbProductDetails.TabStop = false;
            this.gbProductDetails.Text = "Product Details";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(123, 189);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(228, 102);
            this.rtbDescription.TabIndex = 22;
            this.rtbDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Description:";
            // 
            // numBuyingPrice
            // 
            this.numBuyingPrice.DecimalPlaces = 2;
            this.numBuyingPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBuyingPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBuyingPrice.Location = new System.Drawing.Point(123, 123);
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
            this.numBuyingPrice.Size = new System.Drawing.Size(229, 27);
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
            this.lblBuyingPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyingPrice.Location = new System.Drawing.Point(6, 125);
            this.lblBuyingPrice.Name = "lblBuyingPrice";
            this.lblBuyingPrice.Size = new System.Drawing.Size(93, 19);
            this.lblBuyingPrice.TabIndex = 8;
            this.lblBuyingPrice.Text = "Buying price:";
            // 
            // numSellingPrice
            // 
            this.numSellingPrice.DecimalPlaces = 2;
            this.numSellingPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSellingPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSellingPrice.Location = new System.Drawing.Point(123, 90);
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
            this.numSellingPrice.Size = new System.Drawing.Size(229, 27);
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
            this.lblSellingPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPrice.Location = new System.Drawing.Point(6, 92);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(92, 19);
            this.lblSellingPrice.TabIndex = 6;
            this.lblSellingPrice.Text = "Selling price:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(6, 27);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(102, 19);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product name:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(6, 60);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(51, 19);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Brand:";
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductName.Location = new System.Drawing.Point(123, 24);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(229, 27);
            this.tbProductName.TabIndex = 2;
            // 
            // tbBrand
            // 
            this.tbBrand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrand.Location = new System.Drawing.Point(123, 57);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(229, 27);
            this.tbBrand.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(200, 325);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(178, 41);
            this.btnConfirm.TabIndex = 31;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblOptional1
            // 
            this.lblOptional1.AutoSize = true;
            this.lblOptional1.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptional1.Location = new System.Drawing.Point(6, 211);
            this.lblOptional1.Name = "lblOptional1";
            this.lblOptional1.Size = new System.Drawing.Size(62, 17);
            this.lblOptional1.TabIndex = 39;
            this.lblOptional1.Text = "(optional)";
            // 
            // ProductAddUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 382);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbProductDetails);
            this.Controls.Add(this.btnConfirm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProductAddUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblOptional1;
    }
}