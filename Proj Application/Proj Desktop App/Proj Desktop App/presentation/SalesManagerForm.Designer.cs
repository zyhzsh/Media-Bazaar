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
            this.ProductBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRestocks = new System.Windows.Forms.ListView();
            this.RestockId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequesterDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequestedAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numStockRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(249, 6);
            this.btnProductSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(55, 24);
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
            this.cbProductSearchMethod.Location = new System.Drawing.Point(9, 10);
            this.cbProductSearchMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProductSearchMethod.Name = "cbProductSearchMethod";
            this.cbProductSearchMethod.Size = new System.Drawing.Size(84, 21);
            this.cbProductSearchMethod.TabIndex = 39;
            // 
            // tbProductSearchAttribute
            // 
            this.tbProductSearchAttribute.Location = new System.Drawing.Point(96, 10);
            this.tbProductSearchAttribute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProductSearchAttribute.Name = "tbProductSearchAttribute";
            this.tbProductSearchAttribute.Size = new System.Drawing.Size(150, 20);
            this.tbProductSearchAttribute.TabIndex = 38;
            this.tbProductSearchAttribute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRequestRestock
            // 
            this.btnRequestRestock.Location = new System.Drawing.Point(849, 7);
            this.btnRequestRestock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRequestRestock.Name = "btnRequestRestock";
            this.btnRequestRestock.Size = new System.Drawing.Size(129, 20);
            this.btnRequestRestock.TabIndex = 44;
            this.btnRequestRestock.Text = "Request Restock";
            this.btnRequestRestock.UseVisualStyleBackColor = true;
            this.btnRequestRestock.Click += new System.EventHandler(this.btnRequestRestock_Click);
            // 
            // numStockRequest
            // 
            this.numStockRequest.Location = new System.Drawing.Point(770, 10);
            this.numStockRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numStockRequest.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStockRequest.Name = "numStockRequest";
            this.numStockRequest.Size = new System.Drawing.Size(75, 20);
            this.numStockRequest.TabIndex = 46;
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.Location = new System.Drawing.Point(491, 7);
            this.btnProductRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(73, 20);
            this.btnProductRefresh.TabIndex = 48;
            this.btnProductRefresh.Text = "Refresh";
            this.btnProductRefresh.UseVisualStyleBackColor = true;
            this.btnProductRefresh.Click += new System.EventHandler(this.btnProductRefresh_Click);
            // 
            // tbRestockDescription
            // 
            this.tbRestockDescription.Location = new System.Drawing.Point(581, 10);
            this.tbRestockDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRestockDescription.Name = "tbRestockDescription";
            this.tbRestockDescription.Size = new System.Drawing.Size(185, 20);
            this.tbRestockDescription.TabIndex = 49;
            this.tbRestockDescription.Text = "Request message....";
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductCode,
            this.ProductName,
            this.ProductBrand,
            this.ProductDepartment,
            this.ProductStock});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(9, 33);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(478, 518);
            this.lvProducts.TabIndex = 50;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvProducts_ColumnClick);
            // 
            // ProductCode
            // 
            this.ProductCode.Text = "Prod. Code ";
            this.ProductCode.Width = 100;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Name ";
            this.ProductName.Width = 200;
            // 
            // ProductBrand
            // 
            this.ProductBrand.Text = "Brand ";
            this.ProductBrand.Width = 100;
            // 
            // ProductDepartment
            // 
            this.ProductDepartment.Text = "Department ";
            this.ProductDepartment.Width = 100;
            // 
            // ProductStock
            // 
            this.ProductStock.Text = "In Stock ";
            this.ProductStock.Width = 100;
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
            this.lvRestocks.Location = new System.Drawing.Point(491, 32);
            this.lvRestocks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvRestocks.Name = "lvRestocks";
            this.lvRestocks.Size = new System.Drawing.Size(542, 519);
            this.lvRestocks.TabIndex = 51;
            this.lvRestocks.UseCompatibleStateImageBehavior = false;
            this.lvRestocks.View = System.Windows.Forms.View.Details;
            this.lvRestocks.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvRestocks_ColumnClick);
            // 
            // RestockId
            // 
            this.RestockId.Text = "Restock ID ";
            this.RestockId.Width = 100;
            // 
            // ProductId
            // 
            this.ProductId.Text = "Prod. Code ";
            this.ProductId.Width = 100;
            // 
            // ProdName
            // 
            this.ProdName.Text = "Product Name ";
            this.ProdName.Width = 180;
            // 
            // RequesterDesc
            // 
            this.RequesterDesc.Text = "Request Message ";
            this.RequesterDesc.Width = 200;
            // 
            // RequestedAmount
            // 
            this.RequestedAmount.Text = "Requested Amount ";
            this.RequestedAmount.Width = 120;
            // 
            // SalesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 561);
            this.Controls.Add(this.lvRestocks);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.tbRestockDescription);
            this.Controls.Add(this.btnProductRefresh);
            this.Controls.Add(this.numStockRequest);
            this.Controls.Add(this.btnRequestRestock);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.cbProductSearchMethod);
            this.Controls.Add(this.tbProductSearchAttribute);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ColumnHeader ProductDepartment;
        private System.Windows.Forms.ColumnHeader ProductStock;
        private System.Windows.Forms.ColumnHeader ProductBrand;
        private System.Windows.Forms.ListView lvRestocks;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProdName;
        private System.Windows.Forms.ColumnHeader RequesterDesc;
        private System.Windows.Forms.ColumnHeader RequestedAmount;
        private System.Windows.Forms.ColumnHeader RestockId;
    }
}