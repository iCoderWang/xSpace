namespace EsofaUI
{
    partial class ServerConnConfiguration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_Passwd = new System.Windows.Forms.TextBox();
            this.txtBox_LoginUser = new System.Windows.Forms.TextBox();
            this.txtBox_DbName = new System.Windows.Forms.TextBox();
            this.txtBox_ServerIp = new System.Windows.Forms.TextBox();
            this.lbl_Passwd = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_DataBase = new System.Windows.Forms.Label();
            this.lbl_ServerIp = new System.Windows.Forms.Label();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_Passwd);
            this.groupBox1.Controls.Add(this.txtBox_LoginUser);
            this.groupBox1.Controls.Add(this.txtBox_DbName);
            this.groupBox1.Controls.Add(this.txtBox_ServerIp);
            this.groupBox1.Controls.Add(this.lbl_Passwd);
            this.groupBox1.Controls.Add(this.lbl_User);
            this.groupBox1.Controls.Add(this.lbl_DataBase);
            this.groupBox1.Controls.Add(this.lbl_ServerIp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接参数配置";
            // 
            // txtBox_Passwd
            // 
            this.txtBox_Passwd.Location = new System.Drawing.Point(173, 310);
            this.txtBox_Passwd.Name = "txtBox_Passwd";
            this.txtBox_Passwd.PasswordChar = '*';
            this.txtBox_Passwd.Size = new System.Drawing.Size(324, 35);
            this.txtBox_Passwd.TabIndex = 7;
            // 
            // txtBox_LoginUser
            // 
            this.txtBox_LoginUser.Location = new System.Drawing.Point(173, 235);
            this.txtBox_LoginUser.Name = "txtBox_LoginUser";
            this.txtBox_LoginUser.Size = new System.Drawing.Size(324, 35);
            this.txtBox_LoginUser.TabIndex = 6;
            // 
            // txtBox_DbName
            // 
            this.txtBox_DbName.Location = new System.Drawing.Point(173, 160);
            this.txtBox_DbName.Name = "txtBox_DbName";
            this.txtBox_DbName.Size = new System.Drawing.Size(324, 35);
            this.txtBox_DbName.TabIndex = 5;
            // 
            // txtBox_ServerIp
            // 
            this.txtBox_ServerIp.Location = new System.Drawing.Point(173, 75);
            this.txtBox_ServerIp.Name = "txtBox_ServerIp";
            this.txtBox_ServerIp.Size = new System.Drawing.Size(324, 35);
            this.txtBox_ServerIp.TabIndex = 4;
            // 
            // lbl_Passwd
            // 
            this.lbl_Passwd.AutoSize = true;
            this.lbl_Passwd.Location = new System.Drawing.Point(25, 310);
            this.lbl_Passwd.Name = "lbl_Passwd";
            this.lbl_Passwd.Size = new System.Drawing.Size(133, 29);
            this.lbl_Passwd.TabIndex = 3;
            this.lbl_Passwd.Text = "登录密码：";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(25, 235);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(133, 29);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "登录身份：";
            // 
            // lbl_DataBase
            // 
            this.lbl_DataBase.AutoSize = true;
            this.lbl_DataBase.Location = new System.Drawing.Point(25, 160);
            this.lbl_DataBase.Name = "lbl_DataBase";
            this.lbl_DataBase.Size = new System.Drawing.Size(109, 29);
            this.lbl_DataBase.TabIndex = 1;
            this.lbl_DataBase.Text = "数据库：";
            // 
            // lbl_ServerIp
            // 
            this.lbl_ServerIp.AutoSize = true;
            this.lbl_ServerIp.Location = new System.Drawing.Point(25, 75);
            this.lbl_ServerIp.Name = "lbl_ServerIp";
            this.lbl_ServerIp.Size = new System.Drawing.Size(137, 29);
            this.lbl_ServerIp.TabIndex = 0;
            this.lbl_ServerIp.Text = "服务器 IP：";
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(257, 508);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(100, 40);
            this.btn_Modify.TabIndex = 1;
            this.btn_Modify.Text = "修改";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(409, 508);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 40);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ServerConnConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(560, 586);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerConnConfiguration";
            this.Text = "服务器连接设置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ServerConnConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Passwd;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_DataBase;
        private System.Windows.Forms.Label lbl_ServerIp;
        private System.Windows.Forms.TextBox txtBox_Passwd;
        private System.Windows.Forms.TextBox txtBox_LoginUser;
        private System.Windows.Forms.TextBox txtBox_DbName;
        private System.Windows.Forms.TextBox txtBox_ServerIp;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Close;
    }
}