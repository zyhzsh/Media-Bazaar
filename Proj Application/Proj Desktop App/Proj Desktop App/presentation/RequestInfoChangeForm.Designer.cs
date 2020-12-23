namespace Proj_Desktop_App.presentation
{
    partial class RequestInfoChangeForm
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.brnReject = new System.Windows.Forms.Button();
            this.lvrequests = new System.Windows.Forms.ListView();
            this.BSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.certificates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(163, 269);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(191, 67);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // brnReject
            // 
            this.brnReject.Location = new System.Drawing.Point(424, 269);
            this.brnReject.Name = "brnReject";
            this.brnReject.Size = new System.Drawing.Size(191, 67);
            this.brnReject.TabIndex = 2;
            this.brnReject.Text = " Reject";
            this.brnReject.UseVisualStyleBackColor = true;
            // 
            // lvrequests
            // 
            this.lvrequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BSN,
            this.firstName,
            this.lastName,
            this.gender,
            this.phone,
            this.Address,
            this.language,
            this.certificates,
            this.Email});
            this.lvrequests.HideSelection = false;
            this.lvrequests.HoverSelection = true;
            this.lvrequests.Location = new System.Drawing.Point(12, 38);
            this.lvrequests.Name = "lvrequests";
            this.lvrequests.Size = new System.Drawing.Size(776, 225);
            this.lvrequests.TabIndex = 3;
            this.lvrequests.UseCompatibleStateImageBehavior = false;
            this.lvrequests.View = System.Windows.Forms.View.Details;
            // 
            // BSN
            // 
            this.BSN.Text = "BSN";
            // 
            // firstName
            // 
            this.firstName.Text = "First name";
            // 
            // lastName
            // 
            this.lastName.Text = "Last name";
            // 
            // gender
            // 
            this.gender.Text = "Gender";
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            // 
            // Address
            // 
            this.Address.Text = "Address";
            // 
            // language
            // 
            this.language.DisplayIndex = 8;
            this.language.Text = "Language";
            // 
            // certificates
            // 
            this.certificates.DisplayIndex = 6;
            this.certificates.Text = "certificates";
            // 
            // Email
            // 
            this.Email.DisplayIndex = 7;
            this.Email.Text = "Email";
            // 
            // RequestInfoChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvrequests);
            this.Controls.Add(this.brnReject);
            this.Controls.Add(this.btnAccept);
            this.Name = "RequestInfoChangeForm";
            this.Text = "RequestInfoChangeForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button brnReject;
        private System.Windows.Forms.ListView lvrequests;
        private System.Windows.Forms.ColumnHeader BSN;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader certificates;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader language;
    }
}