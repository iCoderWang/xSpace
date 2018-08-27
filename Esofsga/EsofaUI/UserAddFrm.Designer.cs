namespace EsofaUI
{
    partial class UserAddFrm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnComUser = new System.Windows.Forms.RadioButton();
            this.radioBtnManager = new System.Windows.Forms.RadioButton();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.lblUserPwd = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnComUser);
            this.groupBox2.Controls.Add(this.radioBtnManager);
            this.groupBox2.Controls.Add(this.txtConfirmPwd);
            this.groupBox2.Controls.Add(this.txtUserPwd);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.lblUserType);
            this.groupBox2.Controls.Add(this.lblConfirmPwd);
            this.groupBox2.Controls.Add(this.lblUserPwd);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Location = new System.Drawing.Point(24, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(548, 308);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加";
            // 
            // radioBtnComUser
            // 
            this.radioBtnComUser.AutoSize = true;
            this.radioBtnComUser.Checked = true;
            this.radioBtnComUser.Location = new System.Drawing.Point(336, 252);
            this.radioBtnComUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioBtnComUser.Name = "radioBtnComUser";
            this.radioBtnComUser.Size = new System.Drawing.Size(127, 29);
            this.radioBtnComUser.TabIndex = 8;
            this.radioBtnComUser.TabStop = true;
            this.radioBtnComUser.Text = "普通用户";
            this.radioBtnComUser.UseVisualStyleBackColor = true;
            // 
            // radioBtnManager
            // 
            this.radioBtnManager.AutoSize = true;
            this.radioBtnManager.Location = new System.Drawing.Point(172, 252);
            this.radioBtnManager.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioBtnManager.Name = "radioBtnManager";
            this.radioBtnManager.Size = new System.Drawing.Size(106, 29);
            this.radioBtnManager.TabIndex = 7;
            this.radioBtnManager.TabStop = true;
            this.radioBtnManager.Text = "管理员";
            this.radioBtnManager.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Location = new System.Drawing.Point(148, 188);
            this.txtConfirmPwd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(330, 31);
            this.txtConfirmPwd.TabIndex = 6;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(148, 125);
            this.txtUserPwd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(330, 31);
            this.txtUserPwd.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(148, 50);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(330, 31);
            this.txtUserName.TabIndex = 4;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(26, 256);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(117, 25);
            this.lblUserType.TabIndex = 3;
            this.lblUserType.Text = "用户类型：";
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.Location = new System.Drawing.Point(26, 194);
            this.lblConfirmPwd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(117, 25);
            this.lblConfirmPwd.TabIndex = 2;
            this.lblConfirmPwd.Text = "确认密码：";
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.AutoSize = true;
            this.lblUserPwd.Location = new System.Drawing.Point(20, 131);
            this.lblUserPwd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(117, 25);
            this.lblUserPwd.TabIndex = 1;
            this.lblUserPwd.Text = "用户密码：";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(14, 56);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(96, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用户名：";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(422, 502);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(150, 44);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "退出";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(260, 502);
            this.btn_AddUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(150, 44);
            this.btn_AddUser.TabIndex = 10;
            this.btn_AddUser.Text = "添加用户";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // UserAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 563);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAddFrm";
            this.Text = "添加用户";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.RadioButton radioBtnComUser;
        private System.Windows.Forms.RadioButton radioBtnManager;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.Label lblUserPwd;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnAddUser;
    }
}