using System;
using EsofaBLL;
using System.Windows.Forms;

namespace EsofaUI
{
    public partial class AccessChangeFrm : Form
    {

        public AccessChangeFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 使用CheckBox的CheckStateChanged事件，当checkBox状态发生改变时同步下面的代码功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBox_UpdatePwd_CheckStateChanged(object sender, EventArgs e)
        {
            if(chkBox_UpdatePwd.Checked == true)
            {
                txtBox_NewPwd.Enabled = true;
                txtBox_ConfirmedNewPwd.Enabled = true;
            }
            if(chkBox_UpdatePwd.Checked == false)
            {
                txtBox_NewPwd.Text = "";
                txtBox_NewPwd.Enabled = false;
                txtBox_ConfirmedNewPwd.Text = "";
                txtBox_ConfirmedNewPwd.Enabled = false;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkBox_UpdateRole_CheckStateChanged(object sender, EventArgs e)
        {
            if(chkBox_UpdateRole.Checked == true)
            {
                rdoBtn_Admin.Enabled = true;
                rdoBtn_CommenUser.Enabled = true;
            }
            if(chkBox_UpdateRole.Checked == false)
            {
                rdoBtn_Admin.Enabled = false;
                rdoBtn_Admin.Checked = false;
                rdoBtn_CommenUser.Enabled = false;
                rdoBtn_CommenUser.Checked = false;
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string userID = this.txtBox_UserID.Text;
            string userNewPwd;
            //string userConfirmedNewPwd;
            string userNewRole = "";
            string sql_Update="";
            UserManageBLL umb = new UserManageBLL();
           if(chkBox_UpdatePwd.Checked ==true)
            {
                
                if(chkBox_UpdateRole.Checked != true)
                {
                    if (txtBox_NewPwd.Text != "" && txtBox_ConfirmedNewPwd.Text != ""
            && (txtBox_NewPwd.Text == txtBox_ConfirmedNewPwd.Text))
                    {
                        userNewPwd = txtBox_NewPwd.Text;
                        sql_Update = " update user_info set user_password = " + "\"" + userNewPwd + "\"";
                    }
                    else if (txtBox_NewPwd.Text == "" || txtBox_ConfirmedNewPwd.Text == "")
                    {
                        MessageBox.Show("密码项不能为空，请检查。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if(chkBox_UpdateRole.Checked == true)
                {
                    if (rdoBtn_Admin.Checked == true)
                    {
                        userNewRole = rdoBtn_Admin.Text;
                    }
                    if (rdoBtn_CommenUser.Checked == true)
                    {
                        userNewRole = rdoBtn_CommenUser.Text;
                    }
                    if (txtBox_NewPwd.Text != "" && txtBox_ConfirmedNewPwd.Text != ""
           && (txtBox_NewPwd.Text == txtBox_ConfirmedNewPwd.Text))
                    {
                        userNewPwd = txtBox_NewPwd.Text;
                        sql_Update = " update user_info set user_password = " + "\"" + userNewPwd + "\"" + ", user_role = " + "\"" + userNewRole + "\"";
                    }
                    else if (txtBox_NewPwd.Text == "" || txtBox_ConfirmedNewPwd.Text == "")
                    {
                        MessageBox.Show("密码项不能为空，请检查。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            
            if(chkBox_UpdateRole.Checked == true && chkBox_UpdatePwd.Checked == false)
            {
                if (rdoBtn_Admin.Checked == true)
                {
                    userNewRole = rdoBtn_Admin.Text;                    
                }
                if (rdoBtn_CommenUser.Checked == true)
                {
                    userNewRole = rdoBtn_CommenUser.Text;
                }
                sql_Update = " update user_info set user_role = " +"\"" + userNewRole + "\"";
            }
            umb.Update(sql_Update, Convert.ToInt32(userID));
            MessageBox.Show("更新完成，请检查", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
