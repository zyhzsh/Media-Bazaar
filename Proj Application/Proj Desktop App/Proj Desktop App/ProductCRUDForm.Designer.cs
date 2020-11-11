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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btnProductRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(651, 19);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(129, 113);
            this.btnUpdateProduct.TabIndex = 10;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnRemProduct
            // 
            this.btnRemProduct.Location = new System.Drawing.Point(651, 257);
            this.btnRemProduct.Name = "btnRemProduct";
            this.btnRemProduct.Size = new System.Drawing.Size(129, 113);
            this.btnRemProduct.TabIndex = 9;
            this.btnRemProduct.Text = "Remove Product";
            this.btnRemProduct.UseVisualStyleBackColor = true;
            this.btnRemProduct.Click += new System.EventHandler(this.btnRemProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(651, 138);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(129, 113);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 16;
            this.lbProducts.Location = new System.Drawing.Point(12, 19);
            this.lbProducts.MultiColumn = true;
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbProducts.Size = new System.Drawing.Size(633, 580);
            this.lbProducts.TabIndex = 7;
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProductRefresh.Location = new System.Drawing.Point(651, 376);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(129, 100);
            this.btnProductRefresh.TabIndex = 11;
            this.btnProductRefresh.Text = "Refresh";
            this.btnProductRefresh.UseVisualStyleBackColor = false;
            this.btnProductRefresh.Click += new System.EventHandler(this.btnProductRefresh_Click);
            // 
            // ProductCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 612);
            this.Controls.Add(this.btnProductRefresh);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnRemProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lbProducts);
            this.Name = "ProductCRUDForm";
            this.Text = "ProductCRUD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnRemProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Button btnProductRefresh;
    }
}