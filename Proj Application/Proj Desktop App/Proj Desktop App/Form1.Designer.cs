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
            this.button2 = new System.Windows.Forms.Button();
            this.btEmployeeStatics = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();

            this.SuspendLayout();
            //LoginUsername 
            this.tbLogInUsername.Location = new System.Drawing.Point(85, 21);
            this.tbLogInUsername.Name = "tbLogInUsername";
            this.tbLogInUsername.Size = new System.Drawing.Size(160, 22);
            this.tbLogInUsername.TabIndex = 0;
            //Password
            this.tbLogInPassword.Location = new System.Drawing.Point(85, 47);
            this.tbLogInPassword.Name = "tbLogInPassword";
            this.tbLogInPassword.PasswordChar = '*';
            this.tbLogInPassword.Size = new System.Drawing.Size(160, 22);
            this.tbLogInPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(21, 62);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(187, 56);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Log In";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
                // 
            // btnOpenScheduling
            // 
            this.button2.Location = new System.Drawing.Point(20, 122);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "Schedule";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btEmployeeStatics
            // 
            this.btEmployeeStatics.Location = new System.Drawing.Point(212, 122);
            this.btEmployeeStatics.Margin = new System.Windows.Forms.Padding(2);
            this.btEmployeeStatics.Name = "btEmployeeStatics";
            this.btEmployeeStatics.Size = new System.Drawing.Size(187, 56);
            this.btEmployeeStatics.TabIndex = 6;
            this.btEmployeeStatics.Text = "Employee Statistics";
            this.btEmployeeStatics.UseVisualStyleBackColor = true;
            this.btEmployeeStatics.Click += new System.EventHandler(this.btStatistics_Click);
            // 
            // btnOpenEmpStatistics
            // 
            // 
            // btnOpenDptmtManagement
            // 
            this.button4.Location = new System.Drawing.Point(728, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 56);
            this.button4.TabIndex = 7;
            this.button4.Text = "Department Management";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 572);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btEmployeeStatics);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.ClientSize = new System.Drawing.Size(1246, 704);
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
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btEmployeeStatics;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnOpenScheduling;
        private System.Windows.Forms.Button btnOpenEmpStatistics;
        private System.Windows.Forms.Button btnOpenDptmtManagement;
        private System.Windows.Forms.Button btnOpenPrdtStatistics;
        private System.Windows.Forms.Button btnOpenEmpManagement;
    }
}

