using System.Windows.Forms;


namespace EsofaUI
{
    public partial class UserInfoDataViewFrm : Form
    {
        public UserInfoDataViewFrm()
        {
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
    }
}
