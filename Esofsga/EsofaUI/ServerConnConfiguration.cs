using System;
using EsofaCommon;
using System.Windows.Forms;
using System.IO;

namespace EsofaUI
{
    public partial class ServerConnConfiguration : Form
    {
        public ServerConnConfiguration()
        {
            InitializeComponent();
        }

        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if(txtBox_ServerIp.Text == "")
            {
                MessageBox.Show("数据库服务器IP地址不能为空，请指定数据库服务器IP地址。本机数据库服务器IP地址：127.0.0.1 。",
                    "警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (txtBox_DbName.Text == "")
            {
                MessageBox.Show("数据库名称不能为空，请指定需要连接的数据库名称。", 
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBox_LoginUser.Text == "")
            {
                MessageBox.Show("数据库登录用户名不能为空，请指定需要连接的数据库登录用户的名称。",
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBox_Passwd.Text == "")
            {
                MessageBox.Show("数据库登录用户密码不能为空，请指定需要连接的数据库登录用户密码。",
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string serverIp = txtBox_ServerIp.Text.Trim();
            string dbName = txtBox_DbName.Text.Trim();
            string usrName = txtBox_LoginUser.Text.Trim();
            string usrPwd = txtBox_Passwd.Text.Trim();
            IniFileConfigurer.Write(serverIp, dbName, usrName, usrPwd);
            if(this.btn_Modify.Text == "创建")
            {
                MessageBox.Show("数据库连接配置文件创建成功。","信息",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("数据库连接配置文件修改成功。", "信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ServerConnConfiguration_Load(object sender, EventArgs e)
        {
            string fileName = "ConnConfig.ini";
            string pathStr = Application.StartupPath + "\\"+fileName; //INI文件的物理地址
            if (File.Exists(pathStr))
            {
                string[] str = IniFileConfigurer.Load();
                txtBox_ServerIp.Text = str[0].Trim();
                txtBox_DbName.Text = str[1].Trim();
                txtBox_LoginUser.Text = str[2].Trim();
                txtBox_Passwd.Text = str[3].Trim();
            }
            else
            {
                //MessageBox.Show("配置文件不存在，请创建数据库服务器连接配置文件。", 
                   // "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btn_Modify.Text = "创建";
            }
        }
    }
}
