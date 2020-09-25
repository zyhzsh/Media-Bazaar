namespace Proj_Desktop_App
{
    partial class WorkerStockRequests
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
            this.lbRestockRequests = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompleteRestock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRestockRequests
            // 
            this.lbRestockRequests.FormattingEnabled = true;
            this.lbRestockRequests.ItemHeight = 16;
            this.lbRestockRequests.Items.AddRange(new object[] {
            "Product1",
            "Product2",
            "Product3",
            "Product4"});
            this.lbRestockRequests.Location = new System.Drawing.Point(12, 75);
            this.lbRestockRequests.Name = "lbRestockRequests";
            this.lbRestockRequests.Size = new System.Drawing.Size(416, 388);
            this.lbRestockRequests.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Restock Requests";
            // 
            // btnCompleteRestock
            // 
            this.btnCompleteRestock.Location = new System.Drawing.Point(435, 75);
            this.btnCompleteRestock.Name = "btnCompleteRestock";
            this.btnCompleteRestock.Size = new System.Drawing.Size(159, 59);
            this.btnCompleteRestock.TabIndex = 32;
            this.btnCompleteRestock.Text = "Completed";
            this.btnCompleteRestock.UseVisualStyleBackColor = true;
            // 
            // WorkerStockRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 475);
            this.Controls.Add(this.btnCompleteRestock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRestockRequests);
            this.Name = "WorkerStockRequests";
            this.Text = "WorkerStockRequests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRestockRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompleteRestock;
    }
}