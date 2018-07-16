namespace EsofaUI
{
    partial class AccessChangeFrm
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
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.txtBox_UserID = new System.Windows.Forms.TextBox();
            this.txtBox_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txtBox_NewPwd = new System.Windows.Forms.TextBox();
            this.lbl_OldPwd = new System.Windows.Forms.Label();
            this.txtBox_ConfirmedNewPwd = new System.Windows.Forms.TextBox();
            this.lbl_NewPwd = new System.Windows.Forms.Label();
            this.chkBox_UpdatePwd = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBox_UpdateRole = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoBtn_Admin = new System.Windows.Forms.RadioButton();
            this.rdoBtn_CommenUser = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Location = new System.Drawing.Point(28, 29);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(57, 13);
            this.lbl_UserID.TabIndex = 0;
            this.lbl_UserID.Text = "用户 ID：";
            // 
            // txtBox_UserID
            // 
            this.txtBox_UserID.Enabled = false;
            this.txtBox_UserID.Location = new System.Drawing.Point(79, 26);
            this.txtBox_UserID.Name = "txtBox_UserID";
            this.txtBox_UserID.Size = new System.Drawing.Size(172, 20);
            this.txtBox_UserID.TabIndex = 1;
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.Enabled = false;
            this.txtBox_UserName.Location = new System.Drawing.Point(79, 67);
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(172, 20);
            this.txtBox_UserName.TabIndex = 3;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(28, 70);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(55, 13);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "用户名：";
            // 
            // txtBox_NewPwd
            // 
            this.txtBox_NewPwd.Enabled = false;
            this.txtBox_NewPwd.Location = new System.Drawing.Point(76, 28);
            this.txtBox_NewPwd.Name = "txtBox_NewPwd";
            this.txtBox_NewPwd.Size = new System.Drawing.Size(172, 20);
            this.txtBox_NewPwd.TabIndex = 5;
            // 
            // lbl_OldPwd
            // 
            this.lbl_OldPwd.AutoSize = true;
            this.lbl_OldPwd.Location = new System.Drawing.Point(25, 31);
            this.lbl_OldPwd.Name = "lbl_OldPwd";
            this.lbl_OldPwd.Size = new System.Drawing.Size(55, 13);
            this.lbl_OldPwd.TabIndex = 4;
            this.lbl_OldPwd.Text = "新密码：";
            // 
            // txtBox_ConfirmedNewPwd
            // 
            this.txtBox_ConfirmedNewPwd.Enabled = false;
            this.txtBox_ConfirmedNewPwd.Location = new System.Drawing.Point(76, 70);
            this.txtBox_ConfirmedNewPwd.Name = "txtBox_ConfirmedNewPwd";
            this.txtBox_ConfirmedNewPwd.Size = new System.Drawing.Size(172, 20);
            this.txtBox_ConfirmedNewPwd.TabIndex = 7;
            // 
            // lbl_NewPwd
            // 
            this.lbl_NewPwd.AutoSize = true;
            this.lbl_NewPwd.Location = new System.Drawing.Point(3, 73);
            this.lbl_NewPwd.Name = "lbl_NewPwd";
            this.lbl_NewPwd.Size = new System.Drawing.Size(79, 13);
            this.lbl_NewPwd.TabIndex = 6;
            this.lbl_NewPwd.Text = "确认新密码：";
            // 
            // chkBox_UpdatePwd
            // 
            this.chkBox_UpdatePwd.AutoSize = true;
            this.chkBox_UpdatePwd.Location = new System.Drawing.Point(7, 105);
            this.chkBox_UpdatePwd.Name = "chkBox_UpdatePwd";
            this.chkBox_UpdatePwd.Size = new System.Drawing.Size(74, 17);
            this.chkBox_UpdatePwd.TabIndex = 8;
            this.chkBox_UpdatePwd.Text = "更新密码";
            this.chkBox_UpdatePwd.UseVisualStyleBackColor = true;
            this.chkBox_UpdatePwd.CheckStateChanged += new System.EventHandler(this.chkBox_UpdatePwd_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_NewPwd);
            this.groupBox1.Controls.Add(this.lbl_OldPwd);
            this.groupBox1.Controls.Add(this.txtBox_ConfirmedNewPwd);
            this.groupBox1.Controls.Add(this.lbl_NewPwd);
            this.groupBox1.Location = new System.Drawing.Point(3, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // chkBox_UpdateRole
            // 
            this.chkBox_UpdateRole.AutoSize = true;
            this.chkBox_UpdateRole.Location = new System.Drawing.Point(7, 266);
            this.chkBox_UpdateRole.Name = "chkBox_UpdateRole";
            this.chkBox_UpdateRole.Size = new System.Drawing.Size(98, 17);
            this.chkBox_UpdateRole.TabIndex = 10;
            this.chkBox_UpdateRole.Text = "变更用户身份";
            this.chkBox_UpdateRole.UseVisualStyleBackColor = true;
            this.chkBox_UpdateRole.CheckStateChanged += new System.EventHandler(this.chkBox_UpdateRole_CheckStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoBtn_CommenUser);
            this.groupBox2.Controls.Add(this.rdoBtn_Admin);
            this.groupBox2.Location = new System.Drawing.Point(3, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 47);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // rdoBtn_Admin
            // 
            this.rdoBtn_Admin.AutoSize = true;
            this.rdoBtn_Admin.Enabled = false;
            this.rdoBtn_Admin.Location = new System.Drawing.Point(28, 19);
            this.rdoBtn_Admin.Name = "rdoBtn_Admin";
            this.rdoBtn_Admin.Size = new System.Drawing.Size(61, 17);
            this.rdoBtn_Admin.TabIndex = 0;
            this.rdoBtn_Admin.TabStop = true;
            this.rdoBtn_Admin.Text = "管理员";
            this.rdoBtn_Admin.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_CommenUser
            // 
            this.rdoBtn_CommenUser.AutoSize = true;
            this.rdoBtn_CommenUser.Enabled = false;
            this.rdoBtn_CommenUser.Location = new System.Drawing.Point(163, 19);
            this.rdoBtn_CommenUser.Name = "rdoBtn_CommenUser";
            this.rdoBtn_CommenUser.Size = new System.Drawing.Size(73, 17);
            this.rdoBtn_CommenUser.TabIndex = 1;
            this.rdoBtn_CommenUser.TabStop = true;
            this.rdoBtn_CommenUser.Text = "普通用户";
            this.rdoBtn_CommenUser.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.chkBox_UpdateRole);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.chkBox_UpdatePwd);
            this.groupBox3.Controls.Add(this.txtBox_UserName);
            this.groupBox3.Controls.Add(this.lbl_UserName);
            this.groupBox3.Controls.Add(this.txtBox_UserID);
            this.groupBox3.Controls.Add(this.lbl_UserID);
            this.groupBox3.Location = new System.Drawing.Point(8, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 354);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基本信息";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(146, 386);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(67, 31);
            this.btn_Ok.TabIndex = 13;
            this.btn_Ok.Text = "确定";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(227, 386);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(67, 31);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // AccessChangeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 438);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessChangeFrm";
            this.Text = "权限变更";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_OldPwd;
        private System.Windows.Forms.Label lbl_NewPwd;
        private System.Windows.Forms.CheckBox chkBox_UpdatePwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBox_UpdateRole;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.TextBox txtBox_UserID;
        public System.Windows.Forms.TextBox txtBox_UserName;
        public System.Windows.Forms.TextBox txtBox_NewPwd;
        public System.Windows.Forms.TextBox txtBox_ConfirmedNewPwd;
        public System.Windows.Forms.RadioButton rdoBtn_CommenUser;
        public System.Windows.Forms.RadioButton rdoBtn_Admin;
    }
}