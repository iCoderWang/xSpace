using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using EsofaBLL;
using EsofaModel;

namespace EsofaUI
{
    public partial class Login_Form : Form
    {
        
        Main_Form frmMain = new Main_Form();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //UserInfoBLL uib = new UserInfoBLL();
            //List<UserInfo> list_Ui = new List<UserInfo>();
            //string userName;
            //string userPwd;
            //string user_Pwd;
            //string user_Role;
            //userName = txtBox_UserName.Text.Trim();
            //userPwd = txtBox_UserPwd.Text.Trim();
            //if ( userName == "" || userPwd== "")
            //{
            //    MessageBox.Show("用户名或密码不能为空。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //else
            //{
            //    string sql = "select * from user_info where user_name=" + "\"" + userName + "\"";
            //    list_Ui = uib.GetList(sql);
            //    if (list_Ui.Count  == 1)
            //    {
            //        user_Pwd = list_Ui[0].UserPwd;
            //        user_Role = list_Ui[0].UserType;
            //        if(userPwd == user_Pwd)
            //        {
            //            SetVisibleCore(false);
            //            frmMain.lbl_UserName.Text = userName;
            //            frmMain.lbl_UserRole.Text = user_Role;
            //            if(user_Role == "普通用户")
            //            {
            //                frmMain.sideBar_BtnUsersList.Enabled = false;
            //                frmMain.sideBar_BtnAccessChange.Enabled = false;
            //                frmMain.sideBar_BtnUserDel.Enabled = false;
            //                frmMain.sideBar_BtnUserAdd.Enabled = false;
            //                frmMain.menuMain_UserMn.Enabled = false;
            //            }
            //            frmMain.Show();
            //        }
            //        else
            //        {
            //            MessageBox.Show("用户密码不正确。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("用户名不存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }                
            //}
            SetVisibleCore(false);
            frmMain.Show();
        }
    }
}
