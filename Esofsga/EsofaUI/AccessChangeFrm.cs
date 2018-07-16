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
                txtBox_NewPwd.Enabled = false; 
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
            //string userName = this.txtBox_UserName.Text;
            string userNewPwd;
            string userConfirmedNewPwd;
            string userNewRole;
            string sql_UpdatePwd;
            string sql_UpdateRole;
            string sql_UpdateBoth;
           
            if (txtBox_NewPwd.Text != "" && txtBox_ConfirmedNewPwd.Text != ""
            && (txtBox_NewPwd.Text == txtBox_ConfirmedNewPwd.Text))
            {
                userNewPwd = txtBox_NewPwd.Text;
                sql_UpdatePwd = " update user_info set user_password = " + userNewPwd; 
            }
            else if (txtBox_NewPwd.Text == "" || txtBox_ConfirmedNewPwd.Text == "")
            {
                MessageBox.Show("密码项不能为空，请检查。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if(rdoBtn_Admin.Checked == true)
            {
                userNewRole = rdoBtn_Admin.Text;
                sql_UpdateRole = " update user_info set user_role = " + userNewRole;
            }
            if(rdoBtn_CommenUser.Checked == true)
            {
                userNewRole = rdoBtn_CommenUser.Text;
                sql_UpdateRole = " update user_info set user_role = " + userNewRole;
            }
        }
    }
}
