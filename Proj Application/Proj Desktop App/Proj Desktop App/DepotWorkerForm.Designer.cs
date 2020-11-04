namespace Proj_Desktop_App
{
    partial class DepotWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepotWorkerForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.miRestocks = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLogout,
            this.miRestocks});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(128, 421);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miLogout
            // 
            this.miLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miLogout.AutoSize = false;
            this.miLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miLogout.Image = ((System.Drawing.Image)(resources.GetObject("miLogout.Image")));
            this.miLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miLogout.Name = "miLogout";
            this.miLogout.Padding = new System.Windows.Forms.Padding(0);
            this.miLogout.Size = new System.Drawing.Size(121, 70);
            this.miLogout.Text = "Log out";
            this.miLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miLogout.Click += new System.EventHandler(this.miLogout_Click);
            // 
            // miRestocks
            // 
            this.miRestocks.AutoSize = false;
            this.miRestocks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miRestocks.Image = ((System.Drawing.Image)(resources.GetObject("miRestocks.Image")));
            this.miRestocks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miRestocks.Name = "miRestocks";
            this.miRestocks.Padding = new System.Windows.Forms.Padding(0);
            this.miRestocks.Size = new System.Drawing.Size(121, 70);
            this.miRestocks.Text = "Restocks";
            this.miRestocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miRestocks.Click += new System.EventHandler(this.miRestocks_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(128, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(711, 421);
            this.pnlContent.TabIndex = 47;
            // 
            // DepotWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 421);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DepotWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepotWorkerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepotWorkerForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miLogout;
        private System.Windows.Forms.ToolStripMenuItem miRestocks;
        private System.Windows.Forms.Panel pnlContent;
    }
}