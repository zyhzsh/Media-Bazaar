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
            this.lbBestSoldProducts = new System.Windows.Forms.ListBox();
            this.dateTimeSalesFrom = new System.Windows.Forms.DateTimePicker();
            this.btnProductStatFilter = new System.Windows.Forms.Button();
            this.dateTimeSalesTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBestSoldProducts
            // 
            this.lbBestSoldProducts.FormattingEnabled = true;
            this.lbBestSoldProducts.ItemHeight = 16;
            this.lbBestSoldProducts.Location = new System.Drawing.Point(12, 49);
            this.lbBestSoldProducts.Name = "lbBestSoldProducts";
            this.lbBestSoldProducts.Size = new System.Drawing.Size(580, 548);
            this.lbBestSoldProducts.TabIndex = 0;
            // 
            // dateTimeSalesFrom
            // 
            this.dateTimeSalesFrom.Location = new System.Drawing.Point(59, 12);
            this.dateTimeSalesFrom.Name = "dateTimeSalesFrom";
            this.dateTimeSalesFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimeSalesFrom.TabIndex = 1;
            // 
            // btnProductStatFilter
            // 
            this.btnProductStatFilter.Location = new System.Drawing.Point(504, 12);
            this.btnProductStatFilter.Name = "btnProductStatFilter";
            this.btnProductStatFilter.Size = new System.Drawing.Size(88, 22);
            this.btnProductStatFilter.TabIndex = 2;
            this.btnProductStatFilter.Text = "Filter";
            this.btnProductStatFilter.UseVisualStyleBackColor = true;
            this.btnProductStatFilter.Click += new System.EventHandler(this.btnProductStatFilter_Click);
            // 
            // dateTimeSalesTo
            // 
            this.dateTimeSalesTo.Location = new System.Drawing.Point(291, 12);
            this.dateTimeSalesTo.Name = "dateTimeSalesTo";
            this.dateTimeSalesTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimeSalesTo.TabIndex = 3;
            this.dateTimeSalesTo.Value = new System.DateTime(2020, 11, 5, 10, 9, 50, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            // 
            // ProductStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeSalesTo);
            this.Controls.Add(this.btnProductStatFilter);
            this.Controls.Add(this.dateTimeSalesFrom);
            this.Controls.Add(this.lbBestSoldProducts);
            this.Name = "ProductStatistics";
            this.Text = "ProductStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBestSoldProducts;
        private System.Windows.Forms.DateTimePicker dateTimeSalesFrom;
        private System.Windows.Forms.Button btnProductStatFilter;
        private System.Windows.Forms.DateTimePicker dateTimeSalesTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}