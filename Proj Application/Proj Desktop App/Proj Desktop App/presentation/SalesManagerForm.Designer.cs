namespace Proj_Desktop_App
{
    partial class SalesManagerForm
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
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.cbProductSearchMethod = new System.Windows.Forms.ComboBox();
            this.tbProductSearchAttribute = new System.Windows.Forms.TextBox();
            this.btnRequestRestock = new System.Windows.Forms.Button();
            this.numStockRequest = new System.Windows.Forms.NumericUpDown();
            this.btnProductRefresh = new System.Windows.Forms.Button();
            this.tbRestockDescription = new System.Windows.Forms.TextBox();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.ProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductSold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductBought = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRestocks = new System.Windows.Forms.ListView();
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequesterDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequestedAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RestockId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numStockRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(332, 8);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(73, 29);
            this.btnProductSearch.TabIndex = 40;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // cbProductSearchMethod
            // 
            this.cbProductSearchMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductSearchMethod.FormattingEnabled = true;
            this.cbProductSearchMethod.Items.AddRange(new object[] {
            "Product code",
            "Product name"});
            this.cbProductSearchMethod.Location = new System.Drawing.Point(12, 12);
            this.cbProductSearchMethod.Name = "cbProductSearchMethod";
            this.cbProductSearchMethod.Size = new System.Drawing.Size(110, 24);
            this.cbProductSearchMethod.TabIndex = 39;
            // 
            // tbProductSearchAttribute
            // 
            this.tbProductSearchAttribute.Location = new System.Drawing.Point(128, 12);
            this.tbProductSearchAttribute.Name = "tbProductSearchAttribute";
            this.tbProductSearchAttribute.Size = new System.Drawing.Size(198, 22);
            this.tbProductSearchAttribute.TabIndex = 38;
            this.tbProductSearchAttribute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRequestRestock
            // 
            this.btnRequestRestock.Location = new System.Drawing.Point(1132, 9);
            this.btnRequestRestock.Name = "btnRequestRestock";
            this.btnRequestRestock.Size = new System.Drawing.Size(172, 25);
            this.btnRequestRestock.TabIndex = 44;
            this.btnRequestRestock.Text = "Request Restock";
            this.btnRequestRestock.UseVisualStyleBackColor = true;
            this.btnRequestRestock.Click += new System.EventHandler(this.btnRequestRestock_Click);
            // 
            // numStockRequest
            // 
            this.numStockRequest.Location = new System.Drawing.Point(1026, 12);
            this.numStockRequest.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStockRequest.Name = "numStockRequest";
            this.numStockRequest.Size = new System.Drawing.Size(100, 22);
            this.numStockRequest.TabIndex = 46;
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.Location = new System.Drawing.Point(672, 9);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(97, 25);
            this.btnProductRefresh.TabIndex = 48;
            this.btnProductRefresh.Text = "Refresh";
            this.btnProductRefresh.UseVisualStyleBackColor = true;
            this.btnProductRefresh.Click += new System.EventHandler(this.btnProductRefresh_Click);
            // 
            // tbRestockDescription
            // 
            this.tbRestockDescription.Location = new System.Drawing.Point(775, 12);
            this.tbRestockDescription.Name = "tbRestockDescription";
            this.tbRestockDescription.Size = new System.Drawing.Size(245, 22);
            this.tbRestockDescription.TabIndex = 49;
            this.tbRestockDescription.Text = "Request message....";
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
            this.lvProducts.Location = new System.Drawing.Point(12, 41);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(719, 637);
            this.lvProducts.TabIndex = 50;
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
            // ProductBrand
            // 
            this.ProductBrand.Text = "Brand";
            this.ProductBrand.Width = 66;
            // 
            // lvRestocks
            // 
            this.lvRestocks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RestockId,
            this.ProductId,
            this.ProdName,
            this.RequesterDesc,
            this.RequestedAmount});
            this.lvRestocks.HideSelection = false;
            this.lvRestocks.Location = new System.Drawing.Point(737, 40);
            this.lvRestocks.Name = "lvRestocks";
            this.lvRestocks.Size = new System.Drawing.Size(639, 638);
            this.lvRestocks.TabIndex = 51;
            this.lvRestocks.UseCompatibleStateImageBehavior = false;
            this.lvRestocks.View = System.Windows.Forms.View.Details;
            // 
            // ProductId
            // 
            this.ProductId.Text = "Product code";
            this.ProductId.Width = 92;
            // 
            // RequesterDesc
            // 
            this.RequesterDesc.Text = "Request Message";
            this.RequesterDesc.Width = 123;
            // 
            // RequestedAmount
            // 
            this.RequestedAmount.Text = "Requested Amount";
            this.RequestedAmount.Width = 244;
            // 
            // ProdName
            // 
            this.ProdName.Text = "Product Name";
            this.ProdName.Width = 98;
            // 
            // RestockId
            // 
            this.RestockId.Text = "Restock ID";
            this.RestockId.Width = 78;
            // 
            // ProductDescription
            // 
            this.ProductDescription.Text = "Description";
            this.ProductDescription.Width = 100;
            // 
            // SalesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 690);
            this.Controls.Add(this.lvRestocks);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.tbRestockDescription);
            this.Controls.Add(this.btnProductRefresh);
            this.Controls.Add(this.numStockRequest);
            this.Controls.Add(this.btnRequestRestock);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.cbProductSearchMethod);
            this.Controls.Add(this.tbProductSearchAttribute);
            this.Name = "SalesManagerForm";
            this.Text = "ProductStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.numStockRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.ComboBox cbProductSearchMethod;
        private System.Windows.Forms.TextBox tbProductSearchAttribute;
        private System.Windows.Forms.Button btnRequestRestock;
        private System.Windows.Forms.NumericUpDown numStockRequest;
        private System.Windows.Forms.Button btnProductRefresh;
        private System.Windows.Forms.TextBox tbRestockDescription;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader ProductCode;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductSold;
        private System.Windows.Forms.ColumnHeader ProductBought;
        private System.Windows.Forms.ColumnHeader ProductDepartment;
        private System.Windows.Forms.ColumnHeader ProductStock;
        private System.Windows.Forms.ColumnHeader ProductBrand;
        private System.Windows.Forms.ListView lvRestocks;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProdName;
        private System.Windows.Forms.ColumnHeader RequesterDesc;
        private System.Windows.Forms.ColumnHeader RequestedAmount;
        private System.Windows.Forms.ColumnHeader RestockId;
        private System.Windows.Forms.ColumnHeader ProductDescription;
    }
}