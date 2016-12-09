namespace HospRecMan
{
    partial class Adminform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewPatRecord = new System.Windows.Forms.Button();
            this.btnAddMedStaff = new System.Windows.Forms.Button();
            this.btnDelProfile = new System.Windows.Forms.Button();
            this.btnUpdRecord = new System.Windows.Forms.Button();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.panelDeleteRecords = new System.Windows.Forms.Panel();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.panelResetPassword = new System.Windows.Forms.Panel();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVerifyPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBUsername = new System.Windows.Forms.TextBox();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxVerifyPassword = new System.Windows.Forms.TextBox();
            this.txtBxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDeleteRecords.SuspendLayout();
            this.panelResetPassword.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewPatRecord
            // 
            this.btnViewPatRecord.Location = new System.Drawing.Point(224, 12);
            this.btnViewPatRecord.Name = "btnViewPatRecord";
            this.btnViewPatRecord.Size = new System.Drawing.Size(140, 23);
            this.btnViewPatRecord.TabIndex = 15;
            this.btnViewPatRecord.Text = "View Records";
            this.btnViewPatRecord.UseVisualStyleBackColor = true;
            this.btnViewPatRecord.Click += new System.EventHandler(this.btnViewPatRecord_Click);
            // 
            // btnAddMedStaff
            // 
            this.btnAddMedStaff.Location = new System.Drawing.Point(224, 51);
            this.btnAddMedStaff.Name = "btnAddMedStaff";
            this.btnAddMedStaff.Size = new System.Drawing.Size(140, 23);
            this.btnAddMedStaff.TabIndex = 16;
            this.btnAddMedStaff.Text = "Add User";
            this.btnAddMedStaff.UseVisualStyleBackColor = true;
            this.btnAddMedStaff.Click += new System.EventHandler(this.btnAddMedStaff_Click);
            // 
            // btnDelProfile
            // 
            this.btnDelProfile.Location = new System.Drawing.Point(224, 89);
            this.btnDelProfile.Name = "btnDelProfile";
            this.btnDelProfile.Size = new System.Drawing.Size(140, 23);
            this.btnDelProfile.TabIndex = 17;
            this.btnDelProfile.Text = "Delete Profile";
            this.btnDelProfile.UseVisualStyleBackColor = true;
            this.btnDelProfile.Click += new System.EventHandler(this.btnDelProfile_Click);
            // 
            // btnUpdRecord
            // 
            this.btnUpdRecord.Location = new System.Drawing.Point(224, 133);
            this.btnUpdRecord.Name = "btnUpdRecord";
            this.btnUpdRecord.Size = new System.Drawing.Size(140, 23);
            this.btnUpdRecord.TabIndex = 18;
            this.btnUpdRecord.Text = "Update record";
            this.btnUpdRecord.UseVisualStyleBackColor = true;
            this.btnUpdRecord.Click += new System.EventHandler(this.btnUpdRecord_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(224, 172);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(140, 23);
            this.btnResetPass.TabIndex = 19;
            this.btnResetPass.Text = "Reset Password";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // panelDeleteRecords
            // 
            this.panelDeleteRecords.Controls.Add(this.buttonDeleteAccount);
            this.panelDeleteRecords.Controls.Add(this.label6);
            this.panelDeleteRecords.Controls.Add(this.textBoxAdminPassword);
            this.panelDeleteRecords.Controls.Add(this.label2);
            this.panelDeleteRecords.Controls.Add(this.textBoxUser);
            this.panelDeleteRecords.Location = new System.Drawing.Point(370, 12);
            this.panelDeleteRecords.Name = "panelDeleteRecords";
            this.panelDeleteRecords.Size = new System.Drawing.Size(289, 272);
            this.panelDeleteRecords.TabIndex = 20;
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.Location = new System.Drawing.Point(115, 82);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteAccount.TabIndex = 24;
            this.buttonDeleteAccount.Text = "Delete Account";
            this.buttonDeleteAccount.UseVisualStyleBackColor = true;
            this.buttonDeleteAccount.Click += new System.EventHandler(this.buttonDeleteAccount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Admin Password";
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Location = new System.Drawing.Point(97, 56);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.Size = new System.Drawing.Size(161, 20);
            this.textBoxAdminPassword.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(97, 17);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(161, 20);
            this.textBoxUser.TabIndex = 5;
            // 
            // panelResetPassword
            // 
            this.panelResetPassword.Controls.Add(this.comboBoxUserType);
            this.panelResetPassword.Controls.Add(this.label11);
            this.panelResetPassword.Controls.Add(this.btnResetPassword);
            this.panelResetPassword.Controls.Add(this.label5);
            this.panelResetPassword.Controls.Add(this.label4);
            this.panelResetPassword.Controls.Add(this.label3);
            this.panelResetPassword.Controls.Add(this.label1);
            this.panelResetPassword.Controls.Add(this.textBoxVerifyPassword);
            this.panelResetPassword.Controls.Add(this.textBoxNewPassword);
            this.panelResetPassword.Controls.Add(this.textBoxOldPassword);
            this.panelResetPassword.Controls.Add(this.textBUsername);
            this.panelResetPassword.Location = new System.Drawing.Point(370, 12);
            this.panelResetPassword.Name = "panelResetPassword";
            this.panelResetPassword.Size = new System.Drawing.Size(289, 275);
            this.panelResetPassword.TabIndex = 22;
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBoxUserType.Location = new System.Drawing.Point(115, 14);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(159, 21);
            this.comboBoxUserType.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "User type";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(131, 179);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(100, 23);
            this.btnResetPassword.TabIndex = 21;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Old Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Verify Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // textBoxVerifyPassword
            // 
            this.textBoxVerifyPassword.Location = new System.Drawing.Point(113, 153);
            this.textBoxVerifyPassword.Name = "textBoxVerifyPassword";
            this.textBoxVerifyPassword.PasswordChar = '*';
            this.textBoxVerifyPassword.Size = new System.Drawing.Size(161, 20);
            this.textBoxVerifyPassword.TabIndex = 3;
            this.textBoxVerifyPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(113, 114);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(161, 20);
            this.textBoxNewPassword.TabIndex = 2;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(113, 82);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(161, 20);
            this.textBoxOldPassword.TabIndex = 1;
            // 
            // textBUsername
            // 
            this.textBUsername.Location = new System.Drawing.Point(113, 49);
            this.textBUsername.Name = "textBUsername";
            this.textBUsername.Size = new System.Drawing.Size(161, 20);
            this.textBUsername.TabIndex = 0;
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.comboBoxUser);
            this.panelAddUser.Controls.Add(this.label12);
            this.panelAddUser.Controls.Add(this.buttonCreateUser);
            this.panelAddUser.Controls.Add(this.label7);
            this.panelAddUser.Controls.Add(this.label8);
            this.panelAddUser.Controls.Add(this.label9);
            this.panelAddUser.Controls.Add(this.label10);
            this.panelAddUser.Controls.Add(this.txtBxVerifyPassword);
            this.panelAddUser.Controls.Add(this.txtBxNewPassword);
            this.panelAddUser.Controls.Add(this.textBoxNewUserName);
            this.panelAddUser.Controls.Add(this.textBoxUserID);
            this.panelAddUser.Location = new System.Drawing.Point(2, 9);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(235, 275);
            this.panelAddUser.TabIndex = 23;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBoxUser.Location = new System.Drawing.Point(98, 17);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(118, 21);
            this.comboBoxUser.TabIndex = 32;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "User type";
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(103, 179);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(100, 23);
            this.buttonCreateUser.TabIndex = 30;
            this.buttonCreateUser.Text = "Create User";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "User Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "New Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Verify Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "UserID";
            // 
            // txtBxVerifyPassword
            // 
            this.txtBxVerifyPassword.Location = new System.Drawing.Point(98, 153);
            this.txtBxVerifyPassword.Name = "txtBxVerifyPassword";
            this.txtBxVerifyPassword.Size = new System.Drawing.Size(118, 20);
            this.txtBxVerifyPassword.TabIndex = 25;
            this.txtBxVerifyPassword.UseSystemPasswordChar = true;
            // 
            // txtBxNewPassword
            // 
            this.txtBxNewPassword.Location = new System.Drawing.Point(98, 114);
            this.txtBxNewPassword.Name = "txtBxNewPassword";
            this.txtBxNewPassword.Size = new System.Drawing.Size(118, 20);
            this.txtBxNewPassword.TabIndex = 24;
            this.txtBxNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewUserName
            // 
            this.textBoxNewUserName.Location = new System.Drawing.Point(98, 82);
            this.textBoxNewUserName.Name = "textBoxNewUserName";
            this.textBoxNewUserName.Size = new System.Drawing.Size(118, 20);
            this.textBoxNewUserName.TabIndex = 23;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(98, 49);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(118, 20);
            this.textBoxUserID.TabIndex = 22;
            // 
            // Adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 326);
            this.Controls.Add(this.panelAddUser);
            this.Controls.Add(this.panelResetPassword);
            this.Controls.Add(this.panelDeleteRecords);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.btnUpdRecord);
            this.Controls.Add(this.btnDelProfile);
            this.Controls.Add(this.btnAddMedStaff);
            this.Controls.Add(this.btnViewPatRecord);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Adminform";
            this.Text = "Adminform";
            this.Load += new System.EventHandler(this.Adminform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDeleteRecords.ResumeLayout(false);
            this.panelDeleteRecords.PerformLayout();
            this.panelResetPassword.ResumeLayout(false);
            this.panelResetPassword.PerformLayout();
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewPatRecord;
        private System.Windows.Forms.Button btnAddMedStaff;
        private System.Windows.Forms.Button btnDelProfile;
        private System.Windows.Forms.Button btnUpdRecord;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Panel panelDeleteRecords;
        private System.Windows.Forms.Panel panelResetPassword;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVerifyPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBUsername;
        private System.Windows.Forms.Button buttonDeleteAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBxVerifyPassword;
        private System.Windows.Forms.TextBox txtBxNewPassword;
        private System.Windows.Forms.TextBox textBoxNewUserName;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label label12;
    }
}