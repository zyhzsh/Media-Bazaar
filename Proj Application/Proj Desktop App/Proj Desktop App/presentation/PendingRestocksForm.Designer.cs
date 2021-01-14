namespace Proj_Desktop_App
{
    partial class PendingRestocksForm
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
            this.btnAcceptRestock = new System.Windows.Forms.Button();
            this.btnRejectRestock = new System.Windows.Forms.Button();
            this.btnDepotRefresh = new System.Windows.Forms.Button();
            this.rtbRestockJustification = new System.Windows.Forms.RichTextBox();
            this.lvRestocks = new System.Windows.Forms.ListView();
            this.RestockId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequesterDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequestedAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAcceptRestock
            // 
            this.btnAcceptRestock.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAcceptRestock.Location = new System.Drawing.Point(1133, 19);
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
            this.btnRejectRestock.Location = new System.Drawing.Point(1267, 19);
            this.btnRejectRestock.Name = "btnRejectRestock";
            this.btnRejectRestock.Size = new System.Drawing.Size(134, 113);
            this.btnRejectRestock.TabIndex = 2;
            this.btnRejectRestock.Text = "Reject restock";
            this.btnRejectRestock.UseVisualStyleBackColor = false;
            this.btnRejectRestock.Click += new System.EventHandler(this.btnRejectRestock_Click);
            // 
            // btnDepotRefresh
            // 
            this.btnDepotRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDepotRefresh.Location = new System.Drawing.Point(1133, 323);
            this.btnDepotRefresh.Name = "btnDepotRefresh";
            this.btnDepotRefresh.Size = new System.Drawing.Size(268, 78);
            this.btnDepotRefresh.TabIndex = 7;
            this.btnDepotRefresh.Text = "Refresh";
            this.btnDepotRefresh.UseVisualStyleBackColor = false;
            this.btnDepotRefresh.Click += new System.EventHandler(this.btnDepotRefresh_Click);
            // 
            // rtbRestockJustification
            // 
            this.rtbRestockJustification.Location = new System.Drawing.Point(1134, 139);
            this.rtbRestockJustification.Name = "rtbRestockJustification";
            this.rtbRestockJustification.Size = new System.Drawing.Size(267, 178);
            this.rtbRestockJustification.TabIndex = 8;
            this.rtbRestockJustification.Text = "Description...";
            // 
            // lvRestocks
            // 
            this.lvRestocks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RestockId,
            this.ProductId,
            this.ProdName,
            this.RequesterDesc,
            this.RequestedAmount});
            this.lvRestocks.FullRowSelect = true;
            this.lvRestocks.HideSelection = false;
            this.lvRestocks.Location = new System.Drawing.Point(12, 19);
            this.lvRestocks.MultiSelect = false;
            this.lvRestocks.Name = "lvRestocks";
            this.lvRestocks.Size = new System.Drawing.Size(1115, 705);
            this.lvRestocks.TabIndex = 52;
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
            this.ProductId.Text = "Product Code ";
            this.ProductId.Width = 120;
            // 
            // ProdName
            // 
            this.ProdName.Text = "Product Name ";
            this.ProdName.Width = 160;
            // 
            // RequesterDesc
            // 
            this.RequesterDesc.Text = "Request Message ";
            this.RequesterDesc.Width = 300;
            // 
            // RequestedAmount
            // 
            this.RequestedAmount.Text = "Requested Amount ";
            this.RequestedAmount.Width = 160;
            // 
            // PendingRestocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 736);
            this.Controls.Add(this.lvRestocks);
            this.Controls.Add(this.rtbRestockJustification);
            this.Controls.Add(this.btnDepotRefresh);
            this.Controls.Add(this.btnRejectRestock);
            this.Controls.Add(this.btnAcceptRestock);
            this.Name = "PendingRestocksForm";
            this.Text = "DepotManager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAcceptRestock;
        private System.Windows.Forms.Button btnRejectRestock;
        private System.Windows.Forms.Button btnDepotRefresh;
        private System.Windows.Forms.RichTextBox rtbRestockJustification;
        private System.Windows.Forms.ListView lvRestocks;
        private System.Windows.Forms.ColumnHeader RestockId;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProdName;
        private System.Windows.Forms.ColumnHeader RequesterDesc;
        private System.Windows.Forms.ColumnHeader RequestedAmount;
    }
}