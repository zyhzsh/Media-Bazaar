namespace Proj_Desktop_App
{
    partial class Form1
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
            this.tbLogInUsername = new System.Windows.Forms.TextBox();
            this.tbLogInPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btnOpenSchedule = new System.Windows.Forms.Button();
            this.btnEmpStatistics = new System.Windows.Forms.Button();
            this.btnProductStatisticsMenu = new System.Windows.Forms.Button();
            this.btnDepotManager = new System.Windows.Forms.Button();
            this.btnDepotWorkerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLogInUsername
            // 
            this.tbLogInUsername.Location = new System.Drawing.Point(127, 32);
            this.tbLogInUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLogInUsername.Name = "tbLogInUsername";
            this.tbLogInUsername.Size = new System.Drawing.Size(238, 26);
            this.tbLogInUsername.TabIndex = 0;
            // 
            // tbLogInPassword
            // 
            this.tbLogInPassword.Location = new System.Drawing.Point(127, 72);
            this.tbLogInPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLogInPassword.Name = "tbLogInPassword";
            this.tbLogInPassword.PasswordChar = '*';
            this.tbLogInPassword.Size = new System.Drawing.Size(238, 26);
            this.tbLogInPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(11, 118);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(280, 86);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Log In";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btnOpenSchedule
            // 
            this.btnOpenSchedule.Location = new System.Drawing.Point(10, 210);
            this.btnOpenSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenSchedule.Name = "btnOpenSchedule";
            this.btnOpenSchedule.Size = new System.Drawing.Size(280, 86);
            this.btnOpenSchedule.TabIndex = 5;
            this.btnOpenSchedule.Text = "Schedule";
            this.btnOpenSchedule.UseVisualStyleBackColor = true;
            this.btnOpenSchedule.Click += new System.EventHandler(this.btnOpenSchedule_Click);
            // 
            // btnEmpStatistics
            // 
            this.btnEmpStatistics.Location = new System.Drawing.Point(298, 210);
            this.btnEmpStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpStatistics.Name = "btnEmpStatistics";
            this.btnEmpStatistics.Size = new System.Drawing.Size(280, 86);
            this.btnEmpStatistics.TabIndex = 6;
            this.btnEmpStatistics.Text = "Employee Managment";
            this.btnEmpStatistics.UseVisualStyleBackColor = true;
            this.btnEmpStatistics.Click += new System.EventHandler(this.btStatistics_Click);
            // 
            // btnProductStatisticsMenu
            // 
            this.btnProductStatisticsMenu.Location = new System.Drawing.Point(585, 210);
            this.btnProductStatisticsMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductStatisticsMenu.Name = "btnProductStatisticsMenu";
            this.btnProductStatisticsMenu.Size = new System.Drawing.Size(280, 86);
            this.btnProductStatisticsMenu.TabIndex = 8;
            this.btnProductStatisticsMenu.Text = "Product Statistics";
            this.btnProductStatisticsMenu.UseVisualStyleBackColor = true;
            this.btnProductStatisticsMenu.Click += new System.EventHandler(this.btnProductStatisticsMenu_Click);
            // 
            // btnDepotManager
            // 
            this.btnDepotManager.Location = new System.Drawing.Point(585, 301);
            this.btnDepotManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepotManager.Name = "btnDepotManager";
            this.btnDepotManager.Size = new System.Drawing.Size(280, 86);
            this.btnDepotManager.TabIndex = 9;
            this.btnDepotManager.Text = "Depot Manager";
            this.btnDepotManager.UseVisualStyleBackColor = true;
            this.btnDepotManager.Click += new System.EventHandler(this.btnDepotManager_Click);
            // 
            // btnDepotWorkerForm
            // 
            this.btnDepotWorkerForm.Location = new System.Drawing.Point(585, 392);
            this.btnDepotWorkerForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepotWorkerForm.Name = "btnDepotWorkerForm";
            this.btnDepotWorkerForm.Size = new System.Drawing.Size(280, 86);
            this.btnDepotWorkerForm.TabIndex = 10;
            this.btnDepotWorkerForm.Text = "Depot Worker";
            this.btnDepotWorkerForm.UseVisualStyleBackColor = true;
            this.btnDepotWorkerForm.Click += new System.EventHandler(this.btnDepotWorkerForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 601);
            this.Controls.Add(this.btnDepotWorkerForm);
            this.Controls.Add(this.btnDepotManager);
            this.Controls.Add(this.btnProductStatisticsMenu);
            this.Controls.Add(this.btnEmpStatistics);
            this.Controls.Add(this.btnOpenSchedule);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLogInPassword);
            this.Controls.Add(this.tbLogInUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Manager Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogInUsername;
        private System.Windows.Forms.TextBox tbLogInPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btnOpenSchedule;
        private System.Windows.Forms.Button btnEmpStatistics;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnOpenScheduling;
        private System.Windows.Forms.Button btnOpenEmpStatistics;
        private System.Windows.Forms.Button btnOpenDptmtManagement;
        private System.Windows.Forms.Button btnOpenPrdtStatistics;
        private System.Windows.Forms.Button btnOpenEmpManagement;
        private System.Windows.Forms.Button btnProductStatisticsMenu;
        private System.Windows.Forms.Button btnDepotManager;
        private System.Windows.Forms.Button btnDepotWorkerForm;
    }
}

