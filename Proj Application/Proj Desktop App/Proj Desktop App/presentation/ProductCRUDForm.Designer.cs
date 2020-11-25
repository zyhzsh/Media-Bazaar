namespace Proj_Desktop_App
{
    partial class ProductCRUDForm
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
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnRemProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnProductRefresh = new System.Windows.Forms.Button();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.ProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductSold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductBought = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(1149, 19);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(186, 148);
            this.btnUpdateProduct.TabIndex = 10;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnRemProduct
            // 
            this.btnRemProduct.Location = new System.Drawing.Point(1149, 327);
            this.btnRemProduct.Name = "btnRemProduct";
            this.btnRemProduct.Size = new System.Drawing.Size(186, 148);
            this.btnRemProduct.TabIndex = 9;
            this.btnRemProduct.Text = "Remove Product";
            this.btnRemProduct.UseVisualStyleBackColor = true;
            this.btnRemProduct.Click += new System.EventHandler(this.btnRemProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(1149, 173);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(186, 148);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProductRefresh.Location = new System.Drawing.Point(1149, 481);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(186, 148);
            this.btnProductRefresh.TabIndex = 11;
            this.btnProductRefresh.Text = "Refresh";
            this.btnProductRefresh.UseVisualStyleBackColor = false;
            this.btnProductRefresh.Click += new System.EventHandler(this.btnProductRefresh_Click);
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductCode,
            this.ProductName,
            this.ProductBrand,
            this.ProductDescription,
            this.ProductSold,
            this.ProductBought,
            this.ProductDepartment,
            this.ProductStock});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(12, 19);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(1131, 657);
            this.lvProducts.TabIndex = 51;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // ProductCode
            // 
            this.ProductCode.Text = "Product code";
            this.ProductCode.Width = 92;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Name";
            // 
            // ProductBrand
            // 
            this.ProductBrand.Text = "Brand";
            this.ProductBrand.Width = 66;
            // 
            // ProductSold
            // 
            this.ProductSold.Text = "Selling Price";
            this.ProductSold.Width = 87;
            // 
            // ProductBought
            // 
            this.ProductBought.Text = "Bought for";
            this.ProductBought.Width = 72;
            // 
            // ProductDepartment
            // 
            this.ProductDepartment.Text = "Department";
            this.ProductDepartment.Width = 82;
            // 
            // ProductStock
            // 
            this.ProductStock.Text = "In Stock";
            this.ProductStock.Width = 95;
            // 
            // ProductDescription
            // 
            this.ProductDescription.Text = "Description";
            this.ProductDescription.Width = 300;
            // 
            // ProductCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 688);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.btnProductRefresh);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnRemProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "ProductCRUDForm";
            this.Text = "ProductCRUD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnRemProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnProductRefresh;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader ProductCode;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductBrand;
        private System.Windows.Forms.ColumnHeader ProductSold;
        private System.Windows.Forms.ColumnHeader ProductBought;
        private System.Windows.Forms.ColumnHeader ProductDepartment;
        private System.Windows.Forms.ColumnHeader ProductStock;
        private System.Windows.Forms.ColumnHeader ProductDescription;
    }
}