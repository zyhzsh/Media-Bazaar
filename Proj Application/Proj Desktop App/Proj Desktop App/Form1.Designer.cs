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
            this.SuspendLayout();
            // 
            // tbLogInUsername
            // 
            this.tbLogInUsername.Location = new System.Drawing.Point(108, 73);
            this.tbLogInUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogInUsername.Name = "tbLogInUsername";
            this.tbLogInUsername.Size = new System.Drawing.Size(238, 24);
            this.tbLogInUsername.TabIndex = 0;
            // 
            // tbLogInPassword
            // 
            this.tbLogInPassword.Location = new System.Drawing.Point(108, 130);
            this.tbLogInPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogInPassword.Name = "tbLogInPassword";
            this.tbLogInPassword.PasswordChar = '*';
            this.tbLogInPassword.Size = new System.Drawing.Size(238, 24);
            this.tbLogInPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(108, 175);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(238, 53);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Log In";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 299);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLogInPassword);
            this.Controls.Add(this.tbLogInUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogInUsername;
        private System.Windows.Forms.TextBox tbLogInPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogin;
    }
}

