namespace Proj_Desktop_App
{
    partial class WorkerStockRequestsForm
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
            this.btnCompleteRestock = new System.Windows.Forms.Button();
            this.rtbRestockRequestComment = new System.Windows.Forms.RichTextBox();
            this.numRestockedAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lvRestocks = new System.Windows.Forms.ListView();
            this.RestockId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequesterDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JudgeDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequestedAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numRestockedAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompleteRestock
            // 
            this.btnCompleteRestock.Location = new System.Drawing.Point(6, 237);
            this.btnCompleteRestock.Name = "btnCompleteRestock";
            this.btnCompleteRestock.Size = new System.Drawing.Size(384, 69);
            this.btnCompleteRestock.TabIndex = 32;
            this.btnCompleteRestock.Text = "Completed";
            this.btnCompleteRestock.UseVisualStyleBackColor = true;
            this.btnCompleteRestock.Click += new System.EventHandler(this.btnCompleteRestock_Click);
            // 
            // rtbRestockRequestComment
            // 
            this.rtbRestockRequestComment.Location = new System.Drawing.Point(6, 82);
            this.rtbRestockRequestComment.Name = "rtbRestockRequestComment";
            this.rtbRestockRequestComment.Size = new System.Drawing.Size(384, 149);
            this.rtbRestockRequestComment.TabIndex = 33;
            this.rtbRestockRequestComment.Text = "";
            // 
            // numRestockedAmount
            // 
            this.numRestockedAmount.Location = new System.Drawing.Point(140, 18);
            this.numRestockedAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRestockedAmount.Name = "numRestockedAmount";
            this.numRestockedAmount.Size = new System.Drawing.Size(120, 22);
            this.numRestockedAmount.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Restocked amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbRestockRequestComment);
            this.groupBox1.Controls.Add(this.btnCompleteRestock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numRestockedAmount);
            this.groupBox1.Location = new System.Drawing.Point(954, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 317);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Pending restock requests";
            // 
            // lvRestocks
            // 
            this.lvRestocks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RestockId,
            this.ProductId,
            this.ProdName,
            this.RequesterDesc,
            this.JudgeDesc,
            this.RequestedAmount});
            this.lvRestocks.FullRowSelect = true;
            this.lvRestocks.HideSelection = false;
            this.lvRestocks.Location = new System.Drawing.Point(15, 25);
            this.lvRestocks.MultiSelect = false;
            this.lvRestocks.Name = "lvRestocks";
            this.lvRestocks.Size = new System.Drawing.Size(936, 744);
            this.lvRestocks.TabIndex = 52;
            this.lvRestocks.UseCompatibleStateImageBehavior = false;
            this.lvRestocks.View = System.Windows.Forms.View.Details;
            // 
            // RestockId
            // 
            this.RestockId.Text = "Restock ID";
            this.RestockId.Width = 78;
            // 
            // ProductId
            // 
            this.ProductId.Text = "Product code";
            this.ProductId.Width = 92;
            // 
            // ProdName
            // 
            this.ProdName.Text = "Product Name";
            this.ProdName.Width = 98;
            // 
            // RequesterDesc
            // 
            this.RequesterDesc.Text = "Request Message";
            this.RequesterDesc.Width = 207;
            // 
            // JudgeDesc
            // 
            this.JudgeDesc.Text = "Reponse Message";
            this.JudgeDesc.Width = 241;
            // 
            // RequestedAmount
            // 
            this.RequestedAmount.Text = "Requested Amount";
            this.RequestedAmount.Width = 244;
            // 
            // WorkerStockRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 781);
            this.Controls.Add(this.lvRestocks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "WorkerStockRequestsForm";
            this.Text = "WorkerStockRequests";
            ((System.ComponentModel.ISupportInitialize)(this.numRestockedAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompleteRestock;
        private System.Windows.Forms.RichTextBox rtbRestockRequestComment;
        private System.Windows.Forms.NumericUpDown numRestockedAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvRestocks;
        private System.Windows.Forms.ColumnHeader RestockId;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProdName;
        private System.Windows.Forms.ColumnHeader RequesterDesc;
        private System.Windows.Forms.ColumnHeader RequestedAmount;
        private System.Windows.Forms.ColumnHeader JudgeDesc;
    }
}