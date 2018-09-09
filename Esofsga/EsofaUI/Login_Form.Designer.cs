namespace EsofaUI
{
    partial class Login_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtBox_UserName = new System.Windows.Forms.TextBox();
            this.txtBox_UserPwd = new System.Windows.Forms.TextBox();
            this.btn_Configuration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSize = true;
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Login.Image = global::EsofaUI.Properties.Resources.未标题_1;
            this.btn_Login.Location = new System.Drawing.Point(904, 542);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(136, 68);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_UserName.Location = new System.Drawing.Point(814, 298);
            this.txtBox_UserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(350, 62);
            this.txtBox_UserName.TabIndex = 0;
            this.txtBox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBox_UserPwd
            // 
            this.txtBox_UserPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_UserPwd.Location = new System.Drawing.Point(814, 420);
            this.txtBox_UserPwd.Margin = new System.Windows.Forms.Padding(6);
            this.txtBox_UserPwd.Name = "txtBox_UserPwd";
            this.txtBox_UserPwd.PasswordChar = '*';
            this.txtBox_UserPwd.Size = new System.Drawing.Size(348, 62);
            this.txtBox_UserPwd.TabIndex = 1;
            this.txtBox_UserPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox_UserPwd.UseSystemPasswordChar = true;
            // 
            // btn_Configuration
            // 
            this.btn_Configuration.BackColor = System.Drawing.Color.Transparent;
            this.btn_Configuration.FlatAppearance.BorderSize = 0;
            this.btn_Configuration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Configuration.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Configuration.Location = new System.Drawing.Point(1146, 866);
            this.btn_Configuration.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Configuration.Name = "btn_Configuration";
            this.btn_Configuration.Size = new System.Drawing.Size(230, 46);
            this.btn_Configuration.TabIndex = 3;
            this.btn_Configuration.Text = "服务器连接设置";
            this.btn_Configuration.UseVisualStyleBackColor = false;
            this.btn_Configuration.Click += new System.EventHandler(this.btn_Configuration_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::EsofaUI.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 930);
            this.Controls.Add(this.btn_Configuration);
            this.Controls.Add(this.txtBox_UserPwd);
            this.Controls.Add(this.txtBox_UserName);
            this.Controls.Add(this.btn_Login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "页岩气选区评价系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txtBox_UserName;
        private System.Windows.Forms.TextBox txtBox_UserPwd;
        private System.Windows.Forms.Button btn_Configuration;
    }
}

