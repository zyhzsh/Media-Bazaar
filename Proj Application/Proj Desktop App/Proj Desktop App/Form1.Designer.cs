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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnOpenScheduling = new System.Windows.Forms.Button();
            this.btnOpenEmpStatistics = new System.Windows.Forms.Button();
            this.btnOpenDptmtManagement = new System.Windows.Forms.Button();
            this.btnOpenPrdtStatistics = new System.Windows.Forms.Button();
            this.btnOpenEmpManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLogInUsername
            // 
            this.tbLogInUsername.Location = new System.Drawing.Point(85, 21);
            this.tbLogInUsername.Name = "tbLogInUsername";
            this.tbLogInUsername.Size = new System.Drawing.Size(160, 22);
            this.tbLogInUsername.TabIndex = 0;
            // 
            // tbLogInPassword
            // 
            this.tbLogInPassword.Location = new System.Drawing.Point(85, 47);
            this.tbLogInPassword.Name = "tbLogInPassword";
            this.tbLogInPassword.PasswordChar = '*';
            this.tbLogInPassword.Size = new System.Drawing.Size(160, 22);
            this.tbLogInPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(12, 75);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(233, 69);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnOpenScheduling
            // 
            this.btnOpenScheduling.Location = new System.Drawing.Point(12, 150);
            this.btnOpenScheduling.Name = "btnOpenScheduling";
            this.btnOpenScheduling.Size = new System.Drawing.Size(233, 69);
            this.btnOpenScheduling.TabIndex = 5;
            this.btnOpenScheduling.Text = "Schedule";
            this.btnOpenScheduling.UseVisualStyleBackColor = true;
            // 
            // btnOpenEmpStatistics
            // 
            this.btnOpenEmpStatistics.Location = new System.Drawing.Point(251, 150);
            this.btnOpenEmpStatistics.Name = "btnOpenEmpStatistics";
            this.btnOpenEmpStatistics.Size = new System.Drawing.Size(233, 69);
            this.btnOpenEmpStatistics.TabIndex = 6;
            this.btnOpenEmpStatistics.Text = "Employee Statistics";
            this.btnOpenEmpStatistics.UseVisualStyleBackColor = true;
            // 
            // btnOpenDptmtManagement
            // 
            this.btnOpenDptmtManagement.Location = new System.Drawing.Point(968, 150);
            this.btnOpenDptmtManagement.Name = "btnOpenDptmtManagement";
            this.btnOpenDptmtManagement.Size = new System.Drawing.Size(233, 69);
            this.btnOpenDptmtManagement.TabIndex = 7;
            this.btnOpenDptmtManagement.Text = "Department Management";
            this.btnOpenDptmtManagement.UseVisualStyleBackColor = true;
            // 
            // btnOpenPrdtStatistics
            // 
            this.btnOpenPrdtStatistics.Location = new System.Drawing.Point(490, 150);
            this.btnOpenPrdtStatistics.Name = "btnOpenPrdtStatistics";
            this.btnOpenPrdtStatistics.Size = new System.Drawing.Size(233, 69);
            this.btnOpenPrdtStatistics.TabIndex = 8;
            this.btnOpenPrdtStatistics.Text = "Product Statistics";
            this.btnOpenPrdtStatistics.UseVisualStyleBackColor = true;
            // 
            // btnOpenEmpManagement
            // 
            this.btnOpenEmpManagement.Location = new System.Drawing.Point(729, 150);
            this.btnOpenEmpManagement.Name = "btnOpenEmpManagement";
            this.btnOpenEmpManagement.Size = new System.Drawing.Size(233, 69);
            this.btnOpenEmpManagement.TabIndex = 9;
            this.btnOpenEmpManagement.Text = "Employee Management";
            this.btnOpenEmpManagement.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 704);
            this.Controls.Add(this.btnOpenEmpManagement);
            this.Controls.Add(this.btnOpenPrdtStatistics);
            this.Controls.Add(this.btnOpenDptmtManagement);
            this.Controls.Add(this.btnOpenEmpStatistics);
            this.Controls.Add(this.btnOpenScheduling);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLogInPassword);
            this.Controls.Add(this.tbLogInUsername);
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
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnOpenScheduling;
        private System.Windows.Forms.Button btnOpenEmpStatistics;
        private System.Windows.Forms.Button btnOpenDptmtManagement;
        private System.Windows.Forms.Button btnOpenPrdtStatistics;
        private System.Windows.Forms.Button btnOpenEmpManagement;
    }
}

