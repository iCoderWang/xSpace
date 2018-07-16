using System;
using System.Data;
using System.Windows.Forms;
using EsofaBLL;


namespace EsofaUI
{
    public partial class UserInfoDataViewFrm : Form
    {
        //定义委托
        private DelCloseTabPage _delCloseTabPage;
        public UserInfoDataViewFrm()
        {
            InitializeComponent();
        }

        //重载构造函数，用委托做传递参数
        public UserInfoDataViewFrm(DelCloseTabPage delCloseTabPage)
        {
            this._delCloseTabPage = delCloseTabPage;
            InitializeComponent();
        }
        private void UserInfoDataViewFrm_Load(object sender, System.EventArgs e)
        {
            
        }

        private void userDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null && e.Value.ToString().Length > 0)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void btnUserDel_Click(object sender, System.EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count>0)
            {
                UserManageBLL umb = new UserManageBLL();
                UserInfoBLL uib = new UserInfoBLL();
                DialogResult RSS = MessageBox.Show(this, "确定要删除选中行数据吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (RSS)
                {
                    case DialogResult.Yes:
                        for (int i = this.userDataGridView.SelectedRows.Count; i > 0; i--)
                        {
                            int ID = Convert.ToInt32(userDataGridView.SelectedRows[i - 1].Cells[0].Value);
                            umb.Delete(ID);
                        }
                        MessageBox.Show("成功删除选中行数据！","信息",MessageBoxButtons.OK,MessageBoxIcon.Information );
                        userDataGridView.DataSource = uib.GetList();                       
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                MessageBox.Show("请选择所要删除的行。","提示", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            if(userDataGridView.SelectedRows.Count > 0)
            {
                UserManageBLL umb = new UserManageBLL();
                //UserInfoBLL uib = new UserInfoBLL();
                AccessChangeFrm acf = new AccessChangeFrm();
                DialogResult RSS = MessageBox.Show(this, "确定要变更选中行数据吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (RSS)
                {
                    case DialogResult.Yes:
                        //int i = this.userDataGridView.SelectedRows.Count;
                        //int ID = Convert.ToInt32(userDataGridView.SelectedRows[i - 1].Cells[0].Value);
                        acf.txtBox_UserID.Text = (userDataGridView.SelectedRows[0].Cells[0].Value).ToString();
                        acf.txtBox_UserName.Text = (userDataGridView.SelectedRows[0].Cells[1].Value).ToString();
                        acf.Show();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                MessageBox.Show("请选择所要更新的用户行。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnQuite_Click(object sender, EventArgs e)
        {
            _delCloseTabPage();
        }
    }
}
