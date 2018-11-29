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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBox_UserPwd = new System.Windows.Forms.TextBox();
            this.txtBox_UserName = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Configuration = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::EsofaUI.Properties.Resources.LoginESOFSGA;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.73196F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.98599F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.711485F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.08403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.812325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.84594F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.6389208F));
            this.tableLayoutPanel1.Controls.Add(this.txtBox_UserPwd, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBox_UserName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Login, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Configuration, 5, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.49531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.347092F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.876173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.065666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.345216F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.816135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.83114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.698925F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.397849F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1428, 1066);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtBox_UserPwd
            // 
            this.txtBox_UserPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtBox_UserPwd, 3);
            this.txtBox_UserPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_UserPwd.Location = new System.Drawing.Point(925, 530);
            this.txtBox_UserPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtBox_UserPwd.Name = "txtBox_UserPwd";
            this.txtBox_UserPwd.PasswordChar = '*';
            this.txtBox_UserPwd.Size = new System.Drawing.Size(280, 49);
            this.txtBox_UserPwd.TabIndex = 1;
            this.txtBox_UserPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox_UserPwd.UseSystemPasswordChar = true;
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.txtBox_UserName, 3);
            this.txtBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_UserName.Location = new System.Drawing.Point(925, 453);
            this.txtBox_UserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(280, 49);
            this.txtBox_UserName.TabIndex = 0;
            this.txtBox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.AutoSize = true;
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BackgroundImage = global::EsofaUI.Properties.Resources.未标题_1;
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Login.Location = new System.Drawing.Point(978, 609);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(144, 62);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Configuration
            // 
            this.btn_Configuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Configuration.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Configuration.FlatAppearance.BorderSize = 0;
            this.btn_Configuration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Configuration.ForeColor = System.Drawing.Color.White;
            this.btn_Configuration.Location = new System.Drawing.Point(1205, 996);
            this.btn_Configuration.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Configuration.Name = "btn_Configuration";
            this.btn_Configuration.Size = new System.Drawing.Size(212, 53);
            this.btn_Configuration.TabIndex = 3;
            this.btn_Configuration.Text = "服务器连接设置";
            this.btn_Configuration.UseVisualStyleBackColor = false;
            this.btn_Configuration.Click += new System.EventHandler(this.btn_Configuration_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1428, 1066);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "页岩气有利区优选评价系统";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.SizeChanged += new System.EventHandler(this.Login_Form_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txtBox_UserName;
        private System.Windows.Forms.TextBox txtBox_UserPwd;
        private System.Windows.Forms.Button btn_Configuration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

