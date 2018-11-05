using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EsofaBLL;
using EsofaCommon;
using EsofaModel;

namespace EsofaUI
{
    public partial class Login_Form : Form
    {
        //1.声明自适应类实例  
        //AutoSizeForm asc = new AutoSizeForm();
        public Login_Form()
        {
            InitializeComponent();
        }

        //2. 为窗体添加Load事件，并在其方法Form1_Load中，调用类的初始化方法，记录窗体和其控件的初始位置和大小 
        private void Login_Form_Load(object sender, EventArgs e)
        {
            //Bitmap bm = new Bitmap();
            //asc.ControllInitializeSize(this);
        }

        private void Login_Form_SizeChanged(object sender, EventArgs e)
        {
            //asc.ControlAutoSize(this);
        }




        public string userName, user_Role;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string pathStr = Application.StartupPath + "\\"+"ConnConfig.ini"; //INI文件的物理地址
            if (!File.Exists(pathStr))
            {
                MessageBox.Show("配置文件不存在，请创建数据库服务器连接配置文件。",
                   "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                UserInfoBLL uib = new UserInfoBLL();
                List<UserInfo> list_Ui = new List<UserInfo>();
               // string userName;
                string userPwd;
                string user_Pwd;
                //string user_Role;
                userName = txtBox_UserName.Text.Trim();
                userPwd = txtBox_UserPwd.Text.Trim();
                if (userName == "" || userPwd == "")
                {
                    MessageBox.Show("用户名或密码不能为空。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string sql = "select * from user_info where user_name=" + "\"" + userName + "\"";
                    list_Ui = uib.GetList(sql);
                    if (list_Ui.Count == 1)
                    {
                        user_Pwd = list_Ui[0].UserPwd;
                        user_Role = list_Ui[0].UserType;
                        if (userPwd == user_Pwd)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("用户密码不正确。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名不存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
            //this.SetVisibleCore(false);
            //frmMain.Show();
        }

 
        private void btn_Configuration_Click(object sender, EventArgs e)
        {
            ServerConnConfiguration sccf = new ServerConnConfiguration();
            // ShowDialog()方法，将焦点放在当前显示的窗体上，并且，该窗体不关闭，其它窗体无法获取焦点，这是与Show()方法的区别
            sccf.ShowDialog();
        }
    }
}
