namespace Proj_Desktop_App
{
    partial class SalesProductForm
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
            this.lbProductListStatistics = new System.Windows.Forms.ListBox();
            this.btnRequestRestock = new System.Windows.Forms.Button();
            this.cbProductDepartmentSelector = new System.Windows.Forms.ComboBox();
            this.numStockRequest = new System.Windows.Forms.NumericUpDown();
            this.lbPendingRestocks = new System.Windows.Forms.ListBox();
            this.btnProductRefresh = new System.Windows.Forms.Button();
            this.tbRestockDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStockRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(10, 89);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(239, 29);
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
            this.cbProductSearchMethod.Location = new System.Drawing.Point(12, 59);
            this.cbProductSearchMethod.Name = "cbProductSearchMethod";
            this.cbProductSearchMethod.Size = new System.Drawing.Size(110, 24);
            this.cbProductSearchMethod.TabIndex = 39;
            this.cbProductSearchMethod.Text = "Product code";
            // 
            // tbProductSearchAttribute
            // 
            this.tbProductSearchAttribute.Location = new System.Drawing.Point(128, 59);
            this.tbProductSearchAttribute.Name = "tbProductSearchAttribute";
            this.tbProductSearchAttribute.Size = new System.Drawing.Size(121, 22);
            this.tbProductSearchAttribute.TabIndex = 38;
            this.tbProductSearchAttribute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbProductListStatistics
            // 
            this.lbProductListStatistics.FormattingEnabled = true;
            this.lbProductListStatistics.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lbProductListStatistics.ItemHeight = 16;
            this.lbProductListStatistics.Location = new System.Drawing.Point(10, 124);
            this.lbProductListStatistics.Name = "lbProductListStatistics";
            this.lbProductListStatistics.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbProductListStatistics.Size = new System.Drawing.Size(460, 404);
            this.lbProductListStatistics.TabIndex = 29;
            // 
            // btnRequestRestock
            // 
            this.btnRequestRestock.Location = new System.Drawing.Point(709, 59);
            this.btnRequestRestock.Name = "btnRequestRestock";
            this.btnRequestRestock.Size = new System.Drawing.Size(92, 60);
            this.btnRequestRestock.TabIndex = 44;
            this.btnRequestRestock.Text = "Request Restock";
            this.btnRequestRestock.UseVisualStyleBackColor = true;
            this.btnRequestRestock.Click += new System.EventHandler(this.btnRequestRestock_Click);
            // 
            // cbProductDepartmentSelector
            // 
            this.cbProductDepartmentSelector.FormattingEnabled = true;
            this.cbProductDepartmentSelector.Items.AddRange(new object[] {
            "Floor One",
            "Floor Two",
            "Floor Three",
            "Floor Four",
            "All Floors"});
            this.cbProductDepartmentSelector.Location = new System.Drawing.Point(255, 59);
            this.cbProductDepartmentSelector.Name = "cbProductDepartmentSelector";
            this.cbProductDepartmentSelector.Size = new System.Drawing.Size(121, 24);
            this.cbProductDepartmentSelector.TabIndex = 45;
            this.cbProductDepartmentSelector.Text = "All Floors";
            this.cbProductDepartmentSelector.SelectedIndexChanged += new System.EventHandler(this.cbProductDepartmentSelector_SelectedIndexChanged);
            // 
            // numStockRequest
            // 
            this.numStockRequest.Location = new System.Drawing.Point(603, 67);
            this.numStockRequest.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStockRequest.Name = "numStockRequest";
            this.numStockRequest.Size = new System.Drawing.Size(100, 22);
            this.numStockRequest.TabIndex = 46;
            // 
            // lbPendingRestocks
            // 
            this.lbPendingRestocks.FormattingEnabled = true;
            this.lbPendingRestocks.ItemHeight = 16;
            this.lbPendingRestocks.Location = new System.Drawing.Point(476, 124);
            this.lbPendingRestocks.Name = "lbPendingRestocks";
            this.lbPendingRestocks.Size = new System.Drawing.Size(325, 404);
            this.lbPendingRestocks.TabIndex = 47;
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.Location = new System.Drawing.Point(10, 12);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(791, 41);
            this.btnProductRefresh.TabIndex = 48;
            this.btnProductRefresh.Text = "Refresh";
            this.btnProductRefresh.UseVisualStyleBackColor = true;
            this.btnProductRefresh.Click += new System.EventHandler(this.btnProductRefresh_Click);
            // 
            // tbRestockDescription
            // 
            this.tbRestockDescription.Location = new System.Drawing.Point(476, 95);
            this.tbRestockDescription.Name = "tbRestockDescription";
            this.tbRestockDescription.Size = new System.Drawing.Size(227, 22);
            this.tbRestockDescription.TabIndex = 49;
            // 
            // ProductStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 548);
            this.Controls.Add(this.tbRestockDescription);
            this.Controls.Add(this.btnProductRefresh);
            this.Controls.Add(this.lbPendingRestocks);
            this.Controls.Add(this.numStockRequest);
            this.Controls.Add(this.cbProductDepartmentSelector);
            this.Controls.Add(this.btnRequestRestock);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.cbProductSearchMethod);
            this.Controls.Add(this.tbProductSearchAttribute);
            this.Controls.Add(this.lbProductListStatistics);
            this.Name = "ProductStatistics";
            this.Text = "ProductStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.numStockRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.ComboBox cbProductSearchMethod;
        private System.Windows.Forms.TextBox tbProductSearchAttribute;
        private System.Windows.Forms.ListBox lbProductListStatistics;
        private System.Windows.Forms.Button btnRequestRestock;
        private System.Windows.Forms.ComboBox cbProductDepartmentSelector;
        private System.Windows.Forms.NumericUpDown numStockRequest;
        private System.Windows.Forms.ListBox lbPendingRestocks;
        private System.Windows.Forms.Button btnProductRefresh;
        private System.Windows.Forms.TextBox tbRestockDescription;
    }
}