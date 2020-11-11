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
            this.lbIncomingRestocks = new System.Windows.Forms.ListBox();
            this.btnDepotRefresh = new System.Windows.Forms.Button();
            this.rtbRestockJustification = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAcceptRestock
            // 
            this.btnAcceptRestock.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAcceptRestock.Location = new System.Drawing.Point(721, 19);
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
            this.btnRejectRestock.Location = new System.Drawing.Point(855, 19);
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
            this.lbIncomingRestocks.Location = new System.Drawing.Point(12, 19);
            this.lbIncomingRestocks.Name = "lbIncomingRestocks";
            this.lbIncomingRestocks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbIncomingRestocks.Size = new System.Drawing.Size(704, 580);
            this.lbIncomingRestocks.TabIndex = 3;
            // 
            // btnDepotRefresh
            // 
            this.btnDepotRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDepotRefresh.Location = new System.Drawing.Point(721, 323);
            this.btnDepotRefresh.Name = "btnDepotRefresh";
            this.btnDepotRefresh.Size = new System.Drawing.Size(268, 78);
            this.btnDepotRefresh.TabIndex = 7;
            this.btnDepotRefresh.Text = "Refresh";
            this.btnDepotRefresh.UseVisualStyleBackColor = false;
            this.btnDepotRefresh.Click += new System.EventHandler(this.btnDepotRefresh_Click);
            // 
            // rtbRestockJustification
            // 
            this.rtbRestockJustification.Location = new System.Drawing.Point(722, 139);
            this.rtbRestockJustification.Name = "rtbRestockJustification";
            this.rtbRestockJustification.Size = new System.Drawing.Size(267, 178);
            this.rtbRestockJustification.TabIndex = 8;
            this.rtbRestockJustification.Text = "Description...";
            // 
            // PendingRestocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 615);
            this.Controls.Add(this.rtbRestockJustification);
            this.Controls.Add(this.btnDepotRefresh);
            this.Controls.Add(this.lbIncomingRestocks);
            this.Controls.Add(this.btnRejectRestock);
            this.Controls.Add(this.btnAcceptRestock);
            this.Name = "PendingRestocksForm";
            this.Text = "DepotManager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAcceptRestock;
        private System.Windows.Forms.Button btnRejectRestock;
        private System.Windows.Forms.ListBox lbIncomingRestocks;
        private System.Windows.Forms.Button btnDepotRefresh;
        private System.Windows.Forms.RichTextBox rtbRestockJustification;
    }
}