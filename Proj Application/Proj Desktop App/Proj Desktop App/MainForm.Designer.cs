namespace Proj_Desktop_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navbar = new System.Windows.Forms.MenuStrip();
            this.tabEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.tabContracts = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDepartments = new System.Windows.Forms.ToolStripMenuItem();
            this.tabProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRestocks = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.topbar = new System.Windows.Forms.MenuStrip();
            this.tabLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaBazaarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.navbar.SuspendLayout();
            this.topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.AutoSize = false;
            this.navbar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.GripMargin = new System.Windows.Forms.Padding(0);
            this.navbar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabEmployees,
            this.tabContracts,
            this.tabDepartments,
            this.tabProducts,
            this.tabStatistics,
            this.tabRestocks,
            this.tabSchedule});
            this.navbar.Location = new System.Drawing.Point(0, 44);
            this.navbar.Name = "navbar";
            this.navbar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.navbar.Size = new System.Drawing.Size(128, 767);
            this.navbar.TabIndex = 45;
            this.navbar.Text = "menuStrip1";
            // 
            // tabEmployees
            // 
            this.tabEmployees.AutoSize = false;
            this.tabEmployees.BackColor = System.Drawing.Color.Transparent;
            this.tabEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmployees.Image = ((System.Drawing.Image)(resources.GetObject("tabEmployees.Image")));
            this.tabEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(0);
            this.tabEmployees.Size = new System.Drawing.Size(121, 70);
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tabEmployees.Visible = false;
            this.tabEmployees.Click += new System.EventHandler(this.tabEmployees_Click);
            // 
            // tabContracts
            // 
            this.tabContracts.AutoSize = false;
            this.tabContracts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabContracts.Image = ((System.Drawing.Image)(resources.GetObject("tabContracts.Image")));
            this.tabContracts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabContracts.Name = "tabContracts";
            this.tabContracts.Size = new System.Drawing.Size(121, 70);
            this.tabContracts.Text = "Contracts";
            this.tabContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tabContracts.Visible = false;
            this.tabContracts.Click += new System.EventHandler(this.tabContracts_Click);
            // 
            // tabDepartments
            // 
            this.tabDepartments.AutoSize = false;
            this.tabDepartments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDepartments.Image = ((System.Drawing.Image)(resources.GetObject("tabDepartments.Image")));
            this.tabDepartments.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabDepartments.Name = "tabDepartments";
            this.tabDepartments.Padding = new System.Windows.Forms.Padding(0);
            this.tabDepartments.Size = new System.Drawing.Size(121, 70);
            this.tabDepartments.Text = "Departments";
            this.tabDepartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tabDepartments.Visible = false;
            this.tabDepartments.Click += new System.EventHandler(this.tabDepartments_Click);
            // 
            // tabProducts
            // 
            this.tabProducts.AutoSize = false;
            this.tabProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProducts.Image = ((System.Drawing.Image)(resources.GetObject("tabProducts.Image")));
            this.tabProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(0);
            this.tabProducts.Size = new System.Drawing.Size(121, 70);
            this.tabProducts.Text = "Products";
            this.tabProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tabProducts.Visible = false;
            this.tabProducts.Click += new System.EventHandler(this.tabProducts_Click);
            // 
            // tabStatistics
            // 
            this.tabStatistics.AutoSize = false;
            this.tabStatistics.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tabStatistics.Image")));
            this.tabStatistics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(121, 70);
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tabStatistics.Visible = false;
            this.tabStatistics.Click += new System.EventHandler(this.tabStatistics_Click);
            // 
            // tabRestocks
            // 
            this.tabRestocks.AutoSize = false;
            this.tabRestocks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRestocks.Image = ((System.Drawing.Image)(resources.GetObject("tabRestocks.Image")));
            this.tabRestocks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabRestocks.Name = "tabRestocks";
            this.tabRestocks.Padding = new System.Windows.Forms.Padding(0);
            this.tabRestocks.Size = new System.Drawing.Size(121, 70);
            this.tabRestocks.Text = "Restocks";
            this.tabRestocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tabRestocks.Visible = false;
            this.tabRestocks.Click += new System.EventHandler(this.tabRestocks_Click);
            // 
            // tabSchedule
            // 
            this.tabSchedule.AutoSize = false;
            this.tabSchedule.BackColor = System.Drawing.Color.Transparent;
            this.tabSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSchedule.Image = ((System.Drawing.Image)(resources.GetObject("tabSchedule.Image")));
            this.tabSchedule.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(0);
            this.tabSchedule.Size = new System.Drawing.Size(121, 70);
            this.tabSchedule.Text = "Schedule";
            this.tabSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tabSchedule.Visible = false;
            this.tabSchedule.Click += new System.EventHandler(this.tabSchedule_Click);
            // 
            // topbar
            // 
            this.topbar.AutoSize = false;
            this.topbar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.topbar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.topbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabLogOut,
            this.mediaBazaarToolStripMenuItem,
            this.lblUser});
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(1534, 44);
            this.topbar.TabIndex = 0;
            this.topbar.Text = "menuStrip2";
            // 
            // tabLogOut
            // 
            this.tabLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tabLogOut.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabLogOut.Image = ((System.Drawing.Image)(resources.GetObject("tabLogOut.Image")));
            this.tabLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabLogOut.Name = "tabLogOut";
            this.tabLogOut.Size = new System.Drawing.Size(110, 40);
            this.tabLogOut.Text = "Log out";
            this.tabLogOut.Click += new System.EventHandler(this.tabLogOut_Click);
            // 
            // mediaBazaarToolStripMenuItem
            // 
            this.mediaBazaarToolStripMenuItem.Enabled = false;
            this.mediaBazaarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaBazaarToolStripMenuItem.Name = "mediaBazaarToolStripMenuItem";
            this.mediaBazaarToolStripMenuItem.Size = new System.Drawing.Size(125, 40);
            this.mediaBazaarToolStripMenuItem.Text = "Media Bazaar";
            // 
            // lblUser
            // 
            this.lblUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblUser.Enabled = false;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(164, 40);
            this.lblUser.Text = "<position> | <user>";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(128, 44);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1406, 767);
            this.pnlContent.TabIndex = 48;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 811);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.topbar);
            this.MainMenuStrip = this.topbar;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip navbar;
        private System.Windows.Forms.ToolStripMenuItem tabEmployees;
        private System.Windows.Forms.ToolStripMenuItem tabDepartments;
        private System.Windows.Forms.ToolStripMenuItem tabRestocks;
        private System.Windows.Forms.ToolStripMenuItem tabProducts;
        private System.Windows.Forms.ToolStripMenuItem tabSchedule;
        private System.Windows.Forms.ToolStripMenuItem tabContracts;
        private System.Windows.Forms.ToolStripMenuItem tabStatistics;
        private System.Windows.Forms.MenuStrip topbar;
        private System.Windows.Forms.ToolStripMenuItem tabLogOut;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem mediaBazaarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lblUser;
    }
}