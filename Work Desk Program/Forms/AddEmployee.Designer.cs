
namespace Work_Desk_Program.Forms
{
    partial class formAddEmployee
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelNickName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbJobTitle = new System.Windows.Forms.ComboBox();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.labelHireDate = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.listboxPhones = new System.Windows.Forms.ListBox();
            this.listboxEmails = new System.Windows.Forms.ListBox();
            this.btnAddPhoneRecord = new System.Windows.Forms.Button();
            this.txtNewPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNewEmailAddress = new System.Windows.Forms.TextBox();
            this.btnAddEmailRecord = new System.Windows.Forms.Button();
            this.btnAddCertificationRecord = new System.Windows.Forms.Button();
            this.listboxCertifications = new System.Windows.Forms.ListBox();
            this.cbNewCertificationType = new System.Windows.Forms.ComboBox();
            this.cbNewRestrictionType = new System.Windows.Forms.ComboBox();
            this.btnAddRestrictionRecord = new System.Windows.Forms.Button();
            this.listboxRestrictions = new System.Windows.Forms.ListBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.cbNewPhoneType = new System.Windows.Forms.ComboBox();
            this.cbNewEmailType = new System.Windows.Forms.ComboBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCertifications = new System.Windows.Forms.Label();
            this.txtNewCertificationIssueDate = new System.Windows.Forms.TextBox();
            this.txtNewCertificationExpirationDate = new System.Windows.Forms.TextBox();
            this.labelRestrictions = new System.Windows.Forms.Label();
            this.txtNewRestrictionEndDate = new System.Windows.Forms.TextBox();
            this.btnSubmitUserRecord = new System.Windows.Forms.Button();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.labelNewRestrictionExpirationDate = new System.Windows.Forms.Label();
            this.labelNewRestrictionType = new System.Windows.Forms.Label();
            this.btnGetEmployeePicture = new System.Windows.Forms.Button();
            this.pbEmployeePicture = new System.Windows.Forms.PictureBox();
            this.labelCertificationIssueDate = new System.Windows.Forms.Label();
            this.labelCertificationType = new System.Windows.Forms.Label();
            this.labelCertificationRenewalDate = new System.Windows.Forms.Label();
            this.listboxDocuments = new System.Windows.Forms.ListBox();
            this.btnAttachDocuments = new System.Windows.Forms.Button();
            this.documentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(49, 18);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(221, 30);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "New Employee Record";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(43, 66);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(42, 92);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(38, 199);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(62, 13);
            this.labelDepartment.TabIndex = 4;
            this.labelDepartment.Text = "Department";
            // 
            // labelNickName
            // 
            this.labelNickName.AutoSize = true;
            this.labelNickName.Location = new System.Drawing.Point(45, 119);
            this.labelNickName.Name = "labelNickName";
            this.labelNickName.Size = new System.Drawing.Size(55, 13);
            this.labelNickName.TabIndex = 3;
            this.labelNickName.Text = "Nickname";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(106, 64);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(264, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(106, 90);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(264, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(106, 117);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(264, 20);
            this.txtNickname.TabIndex = 7;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(106, 196);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(264, 21);
            this.cbDepartment.TabIndex = 8;
            // 
            // cbJobTitle
            // 
            this.cbJobTitle.FormattingEnabled = true;
            this.cbJobTitle.Location = new System.Drawing.Point(106, 227);
            this.cbJobTitle.Name = "cbJobTitle";
            this.cbJobTitle.Size = new System.Drawing.Size(264, 21);
            this.cbJobTitle.TabIndex = 10;
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(53, 230);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(47, 13);
            this.labelJobTitle.TabIndex = 9;
            this.labelJobTitle.Text = "Job Title";
            // 
            // labelHireDate
            // 
            this.labelHireDate.AutoSize = true;
            this.labelHireDate.Location = new System.Drawing.Point(48, 146);
            this.labelHireDate.Name = "labelHireDate";
            this.labelHireDate.Size = new System.Drawing.Size(52, 13);
            this.labelHireDate.TabIndex = 11;
            this.labelHireDate.Text = "Hire Date";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(106, 169);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(264, 21);
            this.cbStatus.TabIndex = 14;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(63, 171);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 13;
            this.labelStatus.Text = "Status";
            // 
            // listboxPhones
            // 
            this.listboxPhones.FormattingEnabled = true;
            this.listboxPhones.Location = new System.Drawing.Point(107, 340);
            this.listboxPhones.Name = "listboxPhones";
            this.listboxPhones.Size = new System.Drawing.Size(264, 82);
            this.listboxPhones.TabIndex = 15;
            // 
            // listboxEmails
            // 
            this.listboxEmails.FormattingEnabled = true;
            this.listboxEmails.Location = new System.Drawing.Point(393, 340);
            this.listboxEmails.Name = "listboxEmails";
            this.listboxEmails.Size = new System.Drawing.Size(315, 82);
            this.listboxEmails.TabIndex = 16;
            // 
            // btnAddPhoneRecord
            // 
            this.btnAddPhoneRecord.Location = new System.Drawing.Point(207, 310);
            this.btnAddPhoneRecord.Name = "btnAddPhoneRecord";
            this.btnAddPhoneRecord.Size = new System.Drawing.Size(164, 21);
            this.btnAddPhoneRecord.TabIndex = 17;
            this.btnAddPhoneRecord.Text = "Add Phone Record";
            this.btnAddPhoneRecord.UseVisualStyleBackColor = true;
            this.btnAddPhoneRecord.Click += new System.EventHandler(this.btnAddPhoneRecord_Click);
            // 
            // txtNewPhoneNumber
            // 
            this.txtNewPhoneNumber.Location = new System.Drawing.Point(106, 287);
            this.txtNewPhoneNumber.Name = "txtNewPhoneNumber";
            this.txtNewPhoneNumber.Size = new System.Drawing.Size(264, 20);
            this.txtNewPhoneNumber.TabIndex = 18;
            // 
            // txtNewEmailAddress
            // 
            this.txtNewEmailAddress.Location = new System.Drawing.Point(393, 287);
            this.txtNewEmailAddress.Name = "txtNewEmailAddress";
            this.txtNewEmailAddress.Size = new System.Drawing.Size(314, 20);
            this.txtNewEmailAddress.TabIndex = 20;
            // 
            // btnAddEmailRecord
            // 
            this.btnAddEmailRecord.Location = new System.Drawing.Point(518, 309);
            this.btnAddEmailRecord.Name = "btnAddEmailRecord";
            this.btnAddEmailRecord.Size = new System.Drawing.Size(192, 22);
            this.btnAddEmailRecord.TabIndex = 19;
            this.btnAddEmailRecord.Text = "Add Email Record";
            this.btnAddEmailRecord.UseVisualStyleBackColor = true;
            this.btnAddEmailRecord.Click += new System.EventHandler(this.btnAddEmailRecord_Click);
            // 
            // btnAddCertificationRecord
            // 
            this.btnAddCertificationRecord.Location = new System.Drawing.Point(107, 539);
            this.btnAddCertificationRecord.Name = "btnAddCertificationRecord";
            this.btnAddCertificationRecord.Size = new System.Drawing.Size(264, 26);
            this.btnAddCertificationRecord.TabIndex = 22;
            this.btnAddCertificationRecord.Text = "Add Certification Record";
            this.btnAddCertificationRecord.UseVisualStyleBackColor = true;
            this.btnAddCertificationRecord.Click += new System.EventHandler(this.btnAddCertificationRecord_Click);
            // 
            // listboxCertifications
            // 
            this.listboxCertifications.FormattingEnabled = true;
            this.listboxCertifications.Location = new System.Drawing.Point(393, 457);
            this.listboxCertifications.Name = "listboxCertifications";
            this.listboxCertifications.Size = new System.Drawing.Size(315, 108);
            this.listboxCertifications.TabIndex = 21;
            // 
            // cbNewCertificationType
            // 
            this.cbNewCertificationType.FormattingEnabled = true;
            this.cbNewCertificationType.Location = new System.Drawing.Point(107, 457);
            this.cbNewCertificationType.Name = "cbNewCertificationType";
            this.cbNewCertificationType.Size = new System.Drawing.Size(264, 21);
            this.cbNewCertificationType.TabIndex = 23;
            // 
            // cbNewRestrictionType
            // 
            this.cbNewRestrictionType.FormattingEnabled = true;
            this.cbNewRestrictionType.Location = new System.Drawing.Point(107, 601);
            this.cbNewRestrictionType.Name = "cbNewRestrictionType";
            this.cbNewRestrictionType.Size = new System.Drawing.Size(264, 21);
            this.cbNewRestrictionType.TabIndex = 26;
            // 
            // btnAddRestrictionRecord
            // 
            this.btnAddRestrictionRecord.Location = new System.Drawing.Point(107, 659);
            this.btnAddRestrictionRecord.Name = "btnAddRestrictionRecord";
            this.btnAddRestrictionRecord.Size = new System.Drawing.Size(264, 24);
            this.btnAddRestrictionRecord.TabIndex = 25;
            this.btnAddRestrictionRecord.Text = "Add Restriction Record";
            this.btnAddRestrictionRecord.UseVisualStyleBackColor = true;
            this.btnAddRestrictionRecord.Click += new System.EventHandler(this.btnAddRestrictionRecord_Click);
            // 
            // listboxRestrictions
            // 
            this.listboxRestrictions.FormattingEnabled = true;
            this.listboxRestrictions.Location = new System.Drawing.Point(393, 601);
            this.listboxRestrictions.Name = "listboxRestrictions";
            this.listboxRestrictions.Size = new System.Drawing.Size(316, 82);
            this.listboxRestrictions.TabIndex = 24;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(108, 267);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(47, 16);
            this.labelPhone.TabIndex = 30;
            this.labelPhone.Text = "Phone";
            // 
            // cbNewPhoneType
            // 
            this.cbNewPhoneType.FormattingEnabled = true;
            this.cbNewPhoneType.Location = new System.Drawing.Point(106, 310);
            this.cbNewPhoneType.Name = "cbNewPhoneType";
            this.cbNewPhoneType.Size = new System.Drawing.Size(95, 21);
            this.cbNewPhoneType.TabIndex = 31;
            // 
            // cbNewEmailType
            // 
            this.cbNewEmailType.FormattingEnabled = true;
            this.cbNewEmailType.Location = new System.Drawing.Point(393, 310);
            this.cbNewEmailType.Name = "cbNewEmailType";
            this.cbNewEmailType.Size = new System.Drawing.Size(116, 21);
            this.cbNewEmailType.TabIndex = 32;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(390, 267);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 16);
            this.labelEmail.TabIndex = 33;
            this.labelEmail.Text = "Email";
            // 
            // labelCertifications
            // 
            this.labelCertifications.AutoSize = true;
            this.labelCertifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCertifications.Location = new System.Drawing.Point(104, 438);
            this.labelCertifications.Name = "labelCertifications";
            this.labelCertifications.Size = new System.Drawing.Size(84, 16);
            this.labelCertifications.TabIndex = 34;
            this.labelCertifications.Text = "Certifications";
            // 
            // txtNewCertificationIssueDate
            // 
            this.txtNewCertificationIssueDate.Location = new System.Drawing.Point(107, 483);
            this.txtNewCertificationIssueDate.Name = "txtNewCertificationIssueDate";
            this.txtNewCertificationIssueDate.Size = new System.Drawing.Size(264, 20);
            this.txtNewCertificationIssueDate.TabIndex = 35;
            // 
            // txtNewCertificationExpirationDate
            // 
            this.txtNewCertificationExpirationDate.Location = new System.Drawing.Point(107, 509);
            this.txtNewCertificationExpirationDate.Name = "txtNewCertificationExpirationDate";
            this.txtNewCertificationExpirationDate.Size = new System.Drawing.Size(264, 20);
            this.txtNewCertificationExpirationDate.TabIndex = 36;
            // 
            // labelRestrictions
            // 
            this.labelRestrictions.AutoSize = true;
            this.labelRestrictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestrictions.Location = new System.Drawing.Point(110, 582);
            this.labelRestrictions.Name = "labelRestrictions";
            this.labelRestrictions.Size = new System.Drawing.Size(78, 16);
            this.labelRestrictions.TabIndex = 37;
            this.labelRestrictions.Text = "Restrictions";
            // 
            // txtNewRestrictionEndDate
            // 
            this.txtNewRestrictionEndDate.Location = new System.Drawing.Point(107, 628);
            this.txtNewRestrictionEndDate.Name = "txtNewRestrictionEndDate";
            this.txtNewRestrictionEndDate.Size = new System.Drawing.Size(264, 20);
            this.txtNewRestrictionEndDate.TabIndex = 38;
            // 
            // btnSubmitUserRecord
            // 
            this.btnSubmitUserRecord.Location = new System.Drawing.Point(112, 830);
            this.btnSubmitUserRecord.Name = "btnSubmitUserRecord";
            this.btnSubmitUserRecord.Size = new System.Drawing.Size(600, 25);
            this.btnSubmitUserRecord.TabIndex = 39;
            this.btnSubmitUserRecord.Text = "Submit New User Record";
            this.btnSubmitUserRecord.UseVisualStyleBackColor = true;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(106, 143);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(264, 20);
            this.txtHireDate.TabIndex = 40;
            // 
            // labelNewRestrictionExpirationDate
            // 
            this.labelNewRestrictionExpirationDate.AutoSize = true;
            this.labelNewRestrictionExpirationDate.Location = new System.Drawing.Point(22, 630);
            this.labelNewRestrictionExpirationDate.Name = "labelNewRestrictionExpirationDate";
            this.labelNewRestrictionExpirationDate.Size = new System.Drawing.Size(79, 13);
            this.labelNewRestrictionExpirationDate.TabIndex = 46;
            this.labelNewRestrictionExpirationDate.Text = "Expiration Date";
            // 
            // labelNewRestrictionType
            // 
            this.labelNewRestrictionType.AutoSize = true;
            this.labelNewRestrictionType.Location = new System.Drawing.Point(17, 604);
            this.labelNewRestrictionType.Name = "labelNewRestrictionType";
            this.labelNewRestrictionType.Size = new System.Drawing.Size(84, 13);
            this.labelNewRestrictionType.TabIndex = 45;
            this.labelNewRestrictionType.Text = "Restriction Type";
            // 
            // btnGetEmployeePicture
            // 
            this.btnGetEmployeePicture.Location = new System.Drawing.Point(433, 227);
            this.btnGetEmployeePicture.Name = "btnGetEmployeePicture";
            this.btnGetEmployeePicture.Size = new System.Drawing.Size(236, 21);
            this.btnGetEmployeePicture.TabIndex = 48;
            this.btnGetEmployeePicture.Text = "Select Photo";
            this.btnGetEmployeePicture.UseVisualStyleBackColor = true;
            // 
            // pbEmployeePicture
            // 
            this.pbEmployeePicture.Image = global::Work_Desk_Program.Properties.Resources.defaultUserImage3;
            this.pbEmployeePicture.InitialImage = global::Work_Desk_Program.Properties.Resources.defaultUserImage;
            this.pbEmployeePicture.Location = new System.Drawing.Point(433, 21);
            this.pbEmployeePicture.Name = "pbEmployeePicture";
            this.pbEmployeePicture.Size = new System.Drawing.Size(236, 201);
            this.pbEmployeePicture.TabIndex = 47;
            this.pbEmployeePicture.TabStop = false;
            // 
            // labelCertificationIssueDate
            // 
            this.labelCertificationIssueDate.AutoSize = true;
            this.labelCertificationIssueDate.Location = new System.Drawing.Point(43, 482);
            this.labelCertificationIssueDate.Name = "labelCertificationIssueDate";
            this.labelCertificationIssueDate.Size = new System.Drawing.Size(58, 13);
            this.labelCertificationIssueDate.TabIndex = 50;
            this.labelCertificationIssueDate.Text = "Issue Date";
            // 
            // labelCertificationType
            // 
            this.labelCertificationType.AutoSize = true;
            this.labelCertificationType.Location = new System.Drawing.Point(12, 457);
            this.labelCertificationType.Name = "labelCertificationType";
            this.labelCertificationType.Size = new System.Drawing.Size(89, 13);
            this.labelCertificationType.TabIndex = 49;
            this.labelCertificationType.Text = "Certification Type";
            // 
            // labelCertificationRenewalDate
            // 
            this.labelCertificationRenewalDate.AutoSize = true;
            this.labelCertificationRenewalDate.Location = new System.Drawing.Point(26, 509);
            this.labelCertificationRenewalDate.Name = "labelCertificationRenewalDate";
            this.labelCertificationRenewalDate.Size = new System.Drawing.Size(75, 13);
            this.labelCertificationRenewalDate.TabIndex = 51;
            this.labelCertificationRenewalDate.Text = "Renewal Date";
            // 
            // listboxDocuments
            // 
            this.listboxDocuments.FormattingEnabled = true;
            this.listboxDocuments.Location = new System.Drawing.Point(107, 754);
            this.listboxDocuments.Name = "listboxDocuments";
            this.listboxDocuments.Size = new System.Drawing.Size(603, 69);
            this.listboxDocuments.TabIndex = 53;
            // 
            // btnAttachDocuments
            // 
            this.btnAttachDocuments.Location = new System.Drawing.Point(107, 724);
            this.btnAttachDocuments.Name = "btnAttachDocuments";
            this.btnAttachDocuments.Size = new System.Drawing.Size(112, 24);
            this.btnAttachDocuments.TabIndex = 54;
            this.btnAttachDocuments.Text = "Add Document";
            this.btnAttachDocuments.UseVisualStyleBackColor = true;
            // 
            // documentsLabel
            // 
            this.documentsLabel.AutoSize = true;
            this.documentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentsLabel.Location = new System.Drawing.Point(110, 705);
            this.documentsLabel.Name = "documentsLabel";
            this.documentsLabel.Size = new System.Drawing.Size(92, 16);
            this.documentsLabel.TabIndex = 55;
            this.documentsLabel.Text = "Document List";
            // 
            // formAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 886);
            this.Controls.Add(this.documentsLabel);
            this.Controls.Add(this.btnAttachDocuments);
            this.Controls.Add(this.listboxDocuments);
            this.Controls.Add(this.labelCertificationRenewalDate);
            this.Controls.Add(this.labelCertificationIssueDate);
            this.Controls.Add(this.labelCertificationType);
            this.Controls.Add(this.btnGetEmployeePicture);
            this.Controls.Add(this.pbEmployeePicture);
            this.Controls.Add(this.labelNewRestrictionExpirationDate);
            this.Controls.Add(this.labelNewRestrictionType);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.btnSubmitUserRecord);
            this.Controls.Add(this.txtNewRestrictionEndDate);
            this.Controls.Add(this.labelRestrictions);
            this.Controls.Add(this.txtNewCertificationExpirationDate);
            this.Controls.Add(this.txtNewCertificationIssueDate);
            this.Controls.Add(this.labelCertifications);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.cbNewEmailType);
            this.Controls.Add(this.cbNewPhoneType);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.cbNewRestrictionType);
            this.Controls.Add(this.btnAddRestrictionRecord);
            this.Controls.Add(this.listboxRestrictions);
            this.Controls.Add(this.cbNewCertificationType);
            this.Controls.Add(this.btnAddCertificationRecord);
            this.Controls.Add(this.listboxCertifications);
            this.Controls.Add(this.txtNewEmailAddress);
            this.Controls.Add(this.btnAddEmailRecord);
            this.Controls.Add(this.txtNewPhoneNumber);
            this.Controls.Add(this.btnAddPhoneRecord);
            this.Controls.Add(this.listboxEmails);
            this.Controls.Add(this.listboxPhones);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelHireDate);
            this.Controls.Add(this.cbJobTitle);
            this.Controls.Add(this.labelJobTitle);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelNickName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelHeader);
            this.Name = "formAddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.formAddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelNickName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbJobTitle;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.Label labelHireDate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ListBox listboxPhones;
        private System.Windows.Forms.ListBox listboxEmails;
        private System.Windows.Forms.Button btnAddPhoneRecord;
        private System.Windows.Forms.TextBox txtNewPhoneNumber;
        private System.Windows.Forms.TextBox txtNewEmailAddress;
        private System.Windows.Forms.Button btnAddEmailRecord;
        private System.Windows.Forms.Button btnAddCertificationRecord;
        private System.Windows.Forms.ListBox listboxCertifications;
        private System.Windows.Forms.ComboBox cbNewCertificationType;
        private System.Windows.Forms.ComboBox cbNewRestrictionType;
        private System.Windows.Forms.Button btnAddRestrictionRecord;
        private System.Windows.Forms.ListBox listboxRestrictions;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.ComboBox cbNewPhoneType;
        private System.Windows.Forms.ComboBox cbNewEmailType;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCertifications;
        private System.Windows.Forms.TextBox txtNewCertificationIssueDate;
        private System.Windows.Forms.TextBox txtNewCertificationExpirationDate;
        private System.Windows.Forms.Label labelRestrictions;
        private System.Windows.Forms.TextBox txtNewRestrictionEndDate;
        private System.Windows.Forms.Button btnSubmitUserRecord;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.Label labelNewRestrictionExpirationDate;
        private System.Windows.Forms.Label labelNewRestrictionType;
        private System.Windows.Forms.PictureBox pbEmployeePicture;
        private System.Windows.Forms.Button btnGetEmployeePicture;
        private System.Windows.Forms.Label labelCertificationIssueDate;
        private System.Windows.Forms.Label labelCertificationType;
        private System.Windows.Forms.Label labelCertificationRenewalDate;
        private System.Windows.Forms.ListBox listboxDocuments;
        private System.Windows.Forms.Button btnAttachDocuments;
        private System.Windows.Forms.Label documentsLabel;
    }
}