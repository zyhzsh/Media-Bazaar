namespace Proj_Desktop_App
{
    partial class ProductStatistics
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
            this.tbSelectedProductStock = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSelectedProductSales = new System.Windows.Forms.TextBox();
            this.lbProductListStatistics = new System.Windows.Forms.ListBox();
            this.cbSalesLastTime = new System.Windows.Forms.ComboBox();
            this.btnRequestRestock = new System.Windows.Forms.Button();
            this.cbProductDepartmentSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(247, 29);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(96, 24);
            this.btnProductSearch.TabIndex = 40;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // cbProductSearchMethod
            // 
            this.cbProductSearchMethod.FormattingEnabled = true;
            this.cbProductSearchMethod.Items.AddRange(new object[] {
            "Product code",
            "Product name"});
            this.cbProductSearchMethod.Location = new System.Drawing.Point(14, 29);
            this.cbProductSearchMethod.Name = "cbProductSearchMethod";
            this.cbProductSearchMethod.Size = new System.Drawing.Size(121, 24);
            this.cbProductSearchMethod.TabIndex = 39;
            this.cbProductSearchMethod.Text = "Product code";
            // 
            // tbProductSearchAttribute
            // 
            this.tbProductSearchAttribute.Location = new System.Drawing.Point(141, 30);
            this.tbProductSearchAttribute.Name = "tbProductSearchAttribute";
            this.tbProductSearchAttribute.Size = new System.Drawing.Size(100, 22);
            this.tbProductSearchAttribute.TabIndex = 38;
            this.tbProductSearchAttribute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSelectedProductStock
            // 
            this.tbSelectedProductStock.Location = new System.Drawing.Point(604, 92);
            this.tbSelectedProductStock.Name = "tbSelectedProductStock";
            this.tbSelectedProductStock.Size = new System.Drawing.Size(55, 22);
            this.tbSelectedProductStock.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(555, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "Stock";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(555, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Sales in the last";
            // 
            // tbSelectedProductSales
            // 
            this.tbSelectedProductSales.Location = new System.Drawing.Point(821, 166);
            this.tbSelectedProductSales.Name = "tbSelectedProductSales";
            this.tbSelectedProductSales.Size = new System.Drawing.Size(168, 22);
            this.tbSelectedProductSales.TabIndex = 30;
            // 
            // lbProductListStatistics
            // 
            this.lbProductListStatistics.FormattingEnabled = true;
            this.lbProductListStatistics.ItemHeight = 16;
            this.lbProductListStatistics.Location = new System.Drawing.Point(10, 73);
            this.lbProductListStatistics.Name = "lbProductListStatistics";
            this.lbProductListStatistics.Size = new System.Drawing.Size(539, 132);
            this.lbProductListStatistics.TabIndex = 29;
            // 
            // cbSalesLastTime
            // 
            this.cbSalesLastTime.FormattingEnabled = true;
            this.cbSalesLastTime.Items.AddRange(new object[] {
            "Week",
            "30 Days",
            "3 Months",
            "Year",
            "All time"});
            this.cbSalesLastTime.Location = new System.Drawing.Point(679, 166);
            this.cbSalesLastTime.Name = "cbSalesLastTime";
            this.cbSalesLastTime.Size = new System.Drawing.Size(121, 24);
            this.cbSalesLastTime.TabIndex = 43;
            // 
            // btnRequestRestock
            // 
            this.btnRequestRestock.Location = new System.Drawing.Point(558, 120);
            this.btnRequestRestock.Name = "btnRequestRestock";
            this.btnRequestRestock.Size = new System.Drawing.Size(101, 43);
            this.btnRequestRestock.TabIndex = 44;
            this.btnRequestRestock.Text = "Request Restock";
            this.btnRequestRestock.UseVisualStyleBackColor = true;
            this.btnRequestRestock.Click += new System.EventHandler(this.btnRequestRestock_Click);
            // 
            // cbProductDepartmentSelector
            // 
            this.cbProductDepartmentSelector.FormattingEnabled = true;
            this.cbProductDepartmentSelector.Items.AddRange(new object[] {
            "Floor 1",
            "Floor 2",
            "Floor 3",
            "Floor 4",
            "All Floors"});
            this.cbProductDepartmentSelector.Location = new System.Drawing.Point(349, 30);
            this.cbProductDepartmentSelector.Name = "cbProductDepartmentSelector";
            this.cbProductDepartmentSelector.Size = new System.Drawing.Size(121, 24);
            this.cbProductDepartmentSelector.TabIndex = 45;
            this.cbProductDepartmentSelector.Text = "All Floors";
            // 
            // ProductStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 548);
            this.Controls.Add(this.cbProductDepartmentSelector);
            this.Controls.Add(this.btnRequestRestock);
            this.Controls.Add(this.cbSalesLastTime);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.cbProductSearchMethod);
            this.Controls.Add(this.tbProductSearchAttribute);
            this.Controls.Add(this.tbSelectedProductStock);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbSelectedProductSales);
            this.Controls.Add(this.lbProductListStatistics);
            this.Name = "ProductStatistics";
            this.Text = "ProductStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.ComboBox cbProductSearchMethod;
        private System.Windows.Forms.TextBox tbProductSearchAttribute;
        private System.Windows.Forms.TextBox tbSelectedProductStock;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSelectedProductSales;
        private System.Windows.Forms.ListBox lbProductListStatistics;
        private System.Windows.Forms.ComboBox cbSalesLastTime;
        private System.Windows.Forms.Button btnRequestRestock;
        private System.Windows.Forms.ComboBox cbProductDepartmentSelector;
    }
}