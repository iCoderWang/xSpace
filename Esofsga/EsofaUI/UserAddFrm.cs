using System;
using System.Windows.Forms;
using EsofaBLL;

namespace EsofaUI
{
    public partial class UserAddFrm : Form
    {
        //定义委托
        private DelCloseTabPage _delCloseTabPage;
        public UserAddFrm()
        {
            InitializeComponent();
        }
        public UserAddFrm(DelCloseTabPage delCloseTabPage)
        {
            this._delCloseTabPage = delCloseTabPage;
            InitializeComponent();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                UserManageBLL uab = new UserManageBLL();
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("用户名不能为空。       ", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtUserPwd.Text == "")
                {
                    MessageBox.Show("用户密码不能为空 。     ", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtConfirmPwd.Text == "")
                {
                    MessageBox.Show("请确认用户密码。      ", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (txtUserPwd.Text != "" && txtConfirmPwd.Text != "")
                    {
                        if (txtUserPwd.Text.Trim() == txtConfirmPwd.Text.Trim())
                        {
                            if (radioBtnManager.Checked == true)
                            {
                                int rowCount = uab.Add(txtUserName.Text, txtUserPwd.Text.Trim(), radioBtnManager.Text.Trim());
                                txtUserName.Text = "";
                                txtUserPwd.Text = "";
                                txtConfirmPwd.Text = "";
                                MessageBox.Show(rowCount + "行数据成功写入数据库。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (radioBtnComUser.Checked == true)
                            {
                                int rowCount = uab.Add(txtUserName.Text, txtUserPwd.Text.Trim(), radioBtnComUser.Text.Trim());
                                txtUserName.Text = "";
                                txtUserPwd.Text = "";
                                txtConfirmPwd.Text = "";
                                MessageBox.Show(rowCount + " 行数据成功写入数据库。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        if (txtUserPwd.Text.Trim() != txtConfirmPwd.Text.Trim())
                        {
                            MessageBox.Show("用户密码不一致。     ", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                }
            }
            catch 
            {
                MessageBox.Show("用户名称已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _delCloseTabPage();
        }
    }
}
