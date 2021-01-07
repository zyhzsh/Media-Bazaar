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
            this.pnlEmployeeCard = new System.Windows.Forms.Panel();
            this.lblEmployed = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblInfoLanguages = new System.Windows.Forms.Label();
            this.lblInfoCertificates = new System.Windows.Forms.Label();
            this.lblInfoBirthdate = new System.Windows.Forms.Label();
            this.lblInfoGender = new System.Windows.Forms.Label();
            this.lblInfoEmail = new System.Windows.Forms.Label();
            this.lblInfoAddress = new System.Windows.Forms.Label();
            this.lblInfoPhone = new System.Windows.Forms.Label();
            this.lblLanguages = new System.Windows.Forms.Label();
            this.lblCertificates = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBSN = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.pnlEmployeeCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAccept.Location = new System.Drawing.Point(22, 433);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(191, 44);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // brnReject
            // 
            this.brnReject.BackColor = System.Drawing.Color.Brown;
            this.brnReject.Location = new System.Drawing.Point(509, 433);
            this.brnReject.Name = "brnReject";
            this.brnReject.Size = new System.Drawing.Size(191, 44);
            this.brnReject.TabIndex = 2;
            this.brnReject.Text = " Reject";
            this.brnReject.UseVisualStyleBackColor = false;
            this.brnReject.Click += new System.EventHandler(this.brnReject_Click);
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
            this.lvrequests.Location = new System.Drawing.Point(0, 255);
            this.lvrequests.Name = "lvrequests";
            this.lvrequests.Size = new System.Drawing.Size(780, 172);
            this.lvrequests.TabIndex = 3;
            this.lvrequests.UseCompatibleStateImageBehavior = false;
            this.lvrequests.View = System.Windows.Forms.View.Details;
            this.lvrequests.SelectedIndexChanged += new System.EventHandler(this.lvrequests_SelectedIndexChanged_1);
            // 
            // BSN
            // 
            this.BSN.Text = "BSN";
            this.BSN.Width = 78;
            // 
            // firstName
            // 
            this.firstName.Text = "First name";
            this.firstName.Width = 94;
            // 
            // lastName
            // 
            this.lastName.Text = "Last name";
            this.lastName.Width = 98;
            // 
            // gender
            // 
            this.gender.Text = "Gender";
            this.gender.Width = 91;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 92;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 92;
            // 
            // language
            // 
            this.language.DisplayIndex = 8;
            this.language.Text = "Language";
            this.language.Width = 116;
            // 
            // certificates
            // 
            this.certificates.DisplayIndex = 6;
            this.certificates.Text = "certificates";
            this.certificates.Width = 92;
            // 
            // Email
            // 
            this.Email.DisplayIndex = 7;
            this.Email.Text = "Email";
            this.Email.Width = 106;
            // 
            // pnlEmployeeCard
            // 
            this.pnlEmployeeCard.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlEmployeeCard.Controls.Add(this.btRefresh);
            this.pnlEmployeeCard.Controls.Add(this.lvrequests);
            this.pnlEmployeeCard.Controls.Add(this.brnReject);
            this.pnlEmployeeCard.Controls.Add(this.btnAccept);
            this.pnlEmployeeCard.Controls.Add(this.lblEmployed);
            this.pnlEmployeeCard.Controls.Add(this.lblEmail);
            this.pnlEmployeeCard.Controls.Add(this.lblAddress);
            this.pnlEmployeeCard.Controls.Add(this.lblPhone);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoLanguages);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoCertificates);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoBirthdate);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoGender);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoEmail);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoAddress);
            this.pnlEmployeeCard.Controls.Add(this.lblInfoPhone);
            this.pnlEmployeeCard.Controls.Add(this.lblLanguages);
            this.pnlEmployeeCard.Controls.Add(this.lblCertificates);
            this.pnlEmployeeCard.Controls.Add(this.lblBirthdate);
            this.pnlEmployeeCard.Controls.Add(this.lblGender);
            this.pnlEmployeeCard.Controls.Add(this.lblBSN);
            this.pnlEmployeeCard.Controls.Add(this.lblNames);
            this.pnlEmployeeCard.Location = new System.Drawing.Point(8, 8);
            this.pnlEmployeeCard.Name = "pnlEmployeeCard";
            this.pnlEmployeeCard.Size = new System.Drawing.Size(793, 500);
            this.pnlEmployeeCard.TabIndex = 4;
            // 
            // lblEmployed
            // 
            this.lblEmployed.AutoSize = true;
            this.lblEmployed.Location = new System.Drawing.Point(456, 35);
            this.lblEmployed.Name = "lblEmployed";
            this.lblEmployed.Size = new System.Drawing.Size(64, 13);
            this.lblEmployed.TabIndex = 26;
            this.lblEmployed.Text = "<employed>";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(456, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 13);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "<email>";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(456, 168);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(160, 54);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "<address>";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(456, 108);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 13);
            this.lblPhone.TabIndex = 21;
            this.lblPhone.Text = "<phone>";
            // 
            // lblInfoLanguages
            // 
            this.lblInfoLanguages.AutoSize = true;
            this.lblInfoLanguages.Location = new System.Drawing.Point(18, 168);
            this.lblInfoLanguages.Name = "lblInfoLanguages";
            this.lblInfoLanguages.Size = new System.Drawing.Size(63, 13);
            this.lblInfoLanguages.TabIndex = 20;
            this.lblInfoLanguages.Text = "Languages:";
            // 
            // lblInfoCertificates
            // 
            this.lblInfoCertificates.AutoSize = true;
            this.lblInfoCertificates.Location = new System.Drawing.Point(18, 222);
            this.lblInfoCertificates.Name = "lblInfoCertificates";
            this.lblInfoCertificates.Size = new System.Drawing.Size(62, 13);
            this.lblInfoCertificates.TabIndex = 19;
            this.lblInfoCertificates.Text = "Certificates:";
            // 
            // lblInfoBirthdate
            // 
            this.lblInfoBirthdate.AutoSize = true;
            this.lblInfoBirthdate.Location = new System.Drawing.Point(19, 138);
            this.lblInfoBirthdate.Name = "lblInfoBirthdate";
            this.lblInfoBirthdate.Size = new System.Drawing.Size(52, 13);
            this.lblInfoBirthdate.TabIndex = 18;
            this.lblInfoBirthdate.Text = "Birthdate:";
            // 
            // lblInfoGender
            // 
            this.lblInfoGender.AutoSize = true;
            this.lblInfoGender.Location = new System.Drawing.Point(19, 108);
            this.lblInfoGender.Name = "lblInfoGender";
            this.lblInfoGender.Size = new System.Drawing.Size(45, 13);
            this.lblInfoGender.TabIndex = 17;
            this.lblInfoGender.Text = "Gender:";
            // 
            // lblInfoEmail
            // 
            this.lblInfoEmail.AutoSize = true;
            this.lblInfoEmail.Location = new System.Drawing.Point(345, 138);
            this.lblInfoEmail.Name = "lblInfoEmail";
            this.lblInfoEmail.Size = new System.Drawing.Size(35, 13);
            this.lblInfoEmail.TabIndex = 12;
            this.lblInfoEmail.Text = "Email:";
            // 
            // lblInfoAddress
            // 
            this.lblInfoAddress.AutoSize = true;
            this.lblInfoAddress.Location = new System.Drawing.Point(345, 168);
            this.lblInfoAddress.Name = "lblInfoAddress";
            this.lblInfoAddress.Size = new System.Drawing.Size(48, 13);
            this.lblInfoAddress.TabIndex = 11;
            this.lblInfoAddress.Text = "Address:";
            // 
            // lblInfoPhone
            // 
            this.lblInfoPhone.AutoSize = true;
            this.lblInfoPhone.Location = new System.Drawing.Point(345, 108);
            this.lblInfoPhone.Name = "lblInfoPhone";
            this.lblInfoPhone.Size = new System.Drawing.Size(41, 13);
            this.lblInfoPhone.TabIndex = 10;
            this.lblInfoPhone.Text = "Phone:";
            // 
            // lblLanguages
            // 
            this.lblLanguages.Location = new System.Drawing.Point(129, 168);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(160, 54);
            this.lblLanguages.TabIndex = 9;
            this.lblLanguages.Text = "<languages>";
            // 
            // lblCertificates
            // 
            this.lblCertificates.Location = new System.Drawing.Point(129, 222);
            this.lblCertificates.Name = "lblCertificates";
            this.lblCertificates.Size = new System.Drawing.Size(160, 54);
            this.lblCertificates.TabIndex = 8;
            this.lblCertificates.Text = "<certificates>";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(130, 138);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(60, 13);
            this.lblBirthdate.TabIndex = 7;
            this.lblBirthdate.Text = "<birthdate>";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(130, 108);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "<gender>";
            // 
            // lblBSN
            // 
            this.lblBSN.AutoSize = true;
            this.lblBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSN.Location = new System.Drawing.Point(18, 35);
            this.lblBSN.Name = "lblBSN";
            this.lblBSN.Size = new System.Drawing.Size(60, 20);
            this.lblBSN.TabIndex = 5;
            this.lblBSN.Text = "<BSN>";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.Location = new System.Drawing.Point(18, 1);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(251, 24);
            this.lblNames.TabIndex = 3;
            this.lblNames.Text = "<FirstName> <LastName>";
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btRefresh.Location = new System.Drawing.Point(599, 206);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(191, 44);
            this.btRefresh.TabIndex = 27;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // RequestInfoChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.pnlEmployeeCard);
            this.Name = "RequestInfoChangeForm";
            this.Text = "RequestInfoChangeForm";
            this.pnlEmployeeCard.ResumeLayout(false);
            this.pnlEmployeeCard.PerformLayout();
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
        private System.Windows.Forms.Panel pnlEmployeeCard;
        private System.Windows.Forms.Label lblEmployed;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblInfoLanguages;
        private System.Windows.Forms.Label lblInfoCertificates;
        private System.Windows.Forms.Label lblInfoBirthdate;
        private System.Windows.Forms.Label lblInfoGender;
        private System.Windows.Forms.Label lblInfoEmail;
        private System.Windows.Forms.Label lblInfoAddress;
        private System.Windows.Forms.Label lblInfoPhone;
        private System.Windows.Forms.Label lblLanguages;
        private System.Windows.Forms.Label lblCertificates;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBSN;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Button btRefresh;
    }
}