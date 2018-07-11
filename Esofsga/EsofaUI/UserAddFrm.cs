using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsofaBLL;

namespace EsofaUI
{
    public partial class UserAddFrm : Form
    {
        public UserAddFrm()
        {
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            UserAddBLL uab = new UserAddBLL();
            if(txtUserName.Text =="")
            {
                MessageBox.Show("用户名不能为空。", "警告", MessageBoxButtons.OK);
                return;
            }
            else if(txtUserPwd.Text == "")
            {
                MessageBox.Show("用户密码不能为空。", "警告", MessageBoxButtons.OK);
                return;
            }
            else if(txtConfirmPwd.Text == "")
            {
                MessageBox.Show("请确认用户密码。", "警告", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if(txtUserPwd.Text !="" && txtConfirmPwd.Text != "" )
                {
                    if (txtUserPwd.Text.Trim() == txtConfirmPwd.Text.Trim())
                    {
                        if (radioBtnManager.Checked == true)
                        {
                            int rowCount = uab.Add(txtUserName.Text, txtUserPwd.Text.Trim(), radioBtnManager.Text.Trim());
                            txtUserName.Text = "";
                            txtUserPwd.Text = "";
                            txtConfirmPwd.Text = "";
                            MessageBox.Show(rowCount + "行数据成功写入数据库。");
                        }
                        else if (radioBtnComUser.Checked == true)
                        {
                            int rowCount = uab.Add(txtUserName.Text, txtUserPwd.Text.Trim(), radioBtnComUser.Text.Trim());
                            txtUserName.Text = "";
                            txtUserPwd.Text = "";
                            txtConfirmPwd.Text = "";
                            MessageBox.Show(rowCount + "行数据成功写入数据库。");
                        }
                    }
                    if(txtUserPwd.Text.Trim() != txtConfirmPwd.Text.Trim())
                    {
                        MessageBox.Show("用户密码不一致。", "警告", MessageBoxButtons.OK);
                        return;
                    }
                    
                }
            }
        }
    }
}
