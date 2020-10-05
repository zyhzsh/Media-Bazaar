namespace Proj_Desktop_App
{
    partial class DepotManager
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btnAcceptRestock = new System.Windows.Forms.Button();
            this.btnRejectRestock = new System.Windows.Forms.Button();
            this.lbIncomingRestocks = new System.Windows.Forms.ListBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDepotRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 16;
            this.lbProducts.Location = new System.Drawing.Point(12, 131);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbProducts.Size = new System.Drawing.Size(481, 388);
            this.lbProducts.TabIndex = 0;
            // 
            // btnAcceptRestock
            // 
            this.btnAcceptRestock.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAcceptRestock.Location = new System.Drawing.Point(614, 12);
            this.btnAcceptRestock.Name = "btnAcceptRestock";
            this.btnAcceptRestock.Size = new System.Drawing.Size(128, 113);
            this.btnAcceptRestock.TabIndex = 1;
            this.btnAcceptRestock.Text = "Accept restock";
            this.btnAcceptRestock.UseVisualStyleBackColor = false;
            this.btnAcceptRestock.Click += new System.EventHandler(this.btnAcceptRestock_Click);
            // 
            // btnRejectRestock
            // 
            this.btnRejectRestock.BackColor = System.Drawing.Color.Brown;
            this.btnRejectRestock.Location = new System.Drawing.Point(748, 12);
            this.btnRejectRestock.Name = "btnRejectRestock";
            this.btnRejectRestock.Size = new System.Drawing.Size(134, 113);
            this.btnRejectRestock.TabIndex = 2;
            this.btnRejectRestock.Text = "Reject restock";
            this.btnRejectRestock.UseVisualStyleBackColor = false;
            this.btnRejectRestock.Click += new System.EventHandler(this.btnRejectRestock_Click);
            // 
            // lbIncomingRestocks
            // 
            this.lbIncomingRestocks.FormattingEnabled = true;
            this.lbIncomingRestocks.ItemHeight = 16;
            this.lbIncomingRestocks.Location = new System.Drawing.Point(499, 131);
            this.lbIncomingRestocks.Name = "lbIncomingRestocks";
            this.lbIncomingRestocks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbIncomingRestocks.Size = new System.Drawing.Size(383, 388);
            this.lbIncomingRestocks.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(147, 12);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(129, 113);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemProduct
            // 
            this.btnRemProduct.Location = new System.Drawing.Point(282, 12);
            this.btnRemProduct.Name = "btnRemProduct";
            this.btnRemProduct.Size = new System.Drawing.Size(129, 113);
            this.btnRemProduct.TabIndex = 5;
            this.btnRemProduct.Text = "Remove Product";
            this.btnRemProduct.UseVisualStyleBackColor = true;
            this.btnRemProduct.Click += new System.EventHandler(this.btnRemProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(12, 12);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(129, 113);
            this.btnUpdateProduct.TabIndex = 6;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDepotRefresh
            // 
            this.btnDepotRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDepotRefresh.Location = new System.Drawing.Point(417, 12);
            this.btnDepotRefresh.Name = "btnDepotRefresh";
            this.btnDepotRefresh.Size = new System.Drawing.Size(191, 113);
            this.btnDepotRefresh.TabIndex = 7;
            this.btnDepotRefresh.Text = "Refresh";
            this.btnDepotRefresh.UseVisualStyleBackColor = false;
            this.btnDepotRefresh.Click += new System.EventHandler(this.btnDepotRefresh_Click);
            // 
            // DepotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 531);
            this.Controls.Add(this.btnDepotRefresh);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnRemProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lbIncomingRestocks);
            this.Controls.Add(this.btnRejectRestock);
            this.Controls.Add(this.btnAcceptRestock);
            this.Controls.Add(this.lbProducts);
            this.Name = "DepotManager";
            this.Text = "DepotManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Button btnAcceptRestock;
        private System.Windows.Forms.Button btnRejectRestock;
        private System.Windows.Forms.ListBox lbIncomingRestocks;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDepotRefresh;
    }
}