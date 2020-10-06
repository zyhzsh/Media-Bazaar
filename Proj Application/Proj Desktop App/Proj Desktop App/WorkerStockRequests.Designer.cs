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
            this.btnCompleteRestock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRestockRequests
            // 
            this.lbRestockRequests.FormattingEnabled = true;
            this.lbRestockRequests.ItemHeight = 16;
            this.lbRestockRequests.Location = new System.Drawing.Point(12, 12);
            this.lbRestockRequests.Name = "lbRestockRequests";
            this.lbRestockRequests.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbRestockRequests.Size = new System.Drawing.Size(416, 388);
            this.lbRestockRequests.TabIndex = 30;
            // 
            // btnCompleteRestock
            // 
            this.btnCompleteRestock.Location = new System.Drawing.Point(434, 12);
            this.btnCompleteRestock.Name = "btnCompleteRestock";
            this.btnCompleteRestock.Size = new System.Drawing.Size(205, 386);
            this.btnCompleteRestock.TabIndex = 32;
            this.btnCompleteRestock.Text = "Completed";
            this.btnCompleteRestock.UseVisualStyleBackColor = true;
            this.btnCompleteRestock.Click += new System.EventHandler(this.btnCompleteRestock_Click);
            // 
            // WorkerStockRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 410);
            this.Controls.Add(this.btnCompleteRestock);
            this.Controls.Add(this.lbRestockRequests);
            this.Name = "WorkerStockRequests";
            this.Text = "WorkerStockRequests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRestockRequests;
        private System.Windows.Forms.Button btnCompleteRestock;
    }
}