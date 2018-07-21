using System;
using EsofaBLL;
using EsofaCommon;
using System.Windows.Forms;

namespace EsofaUI
{
    public partial class DbDataQueryFrm : Form
    {
        bool flag = true;
        private DelCloseTabPage _delCloseTabPage;
        public DbDataQueryFrm()
        {
            InitializeComponent();
        }
        public DbDataQueryFrm(DelCloseTabPage delCTP)
        {
            this._delCloseTabPage = delCTP;
            InitializeComponent();
        }
        
        private void tlStrip_DbQueryAll_Click(object sender, EventArgs e)
        {
            string sql = "select * from target";
            RawDataBLL rawDataBLL = new RawDataBLL();
            this.dgv_DbQuery.AutoGenerateColumns = true;
            DataGridViewColumnEditor dgvCE = new DataGridViewColumnEditor();
            this.dgv_DbQuery.Name = "dgvView";
            this.dgv_DbQuery.ReadOnly = true;
            this.dgv_DbQuery.DataSource = rawDataBLL.GetAvg_List(sql);
            dgvCE.ColumHeaderEdit(this.dgv_DbQuery, this.dgv_DbQuery.Name);
        }

        private void tlStrip_DbQueryBy_Click(object sender, EventArgs e)
        {
            this.dgv_DbQuery.DataSource = null;
            ConditionalQueryFrm cqf = new ConditionalQueryFrm();
            cqf.Show();
        }

        private void tlStripBtn_Edit_Click(object sender, EventArgs e)
        {
            
            if (flag == true)
            {
                this.tlStripBtn_MultiDel.Enabled = true;
                this.tlStripBtn_SingleDel.Enabled = true;
                this.tlStripBtn_Refresh.Enabled = true;
                this.tlStripBtn_BlankRowAdd.Enabled = true;
                this.tlStripBtn_BlankRowDel.Enabled = true;
                this.tlStripBtn_DbUpdate.Enabled = true;
                this.dgv_DbQuery.ReadOnly = false;
                flag = false;
            }
            else
            {
                this.tlStripBtn_MultiDel.Enabled = false;
                this.tlStripBtn_SingleDel.Enabled = false;
                this.tlStripBtn_Refresh.Enabled = false;
                this.tlStripBtn_BlankRowAdd.Enabled = false;
                this.tlStripBtn_BlankRowDel.Enabled = false;
                this.tlStripBtn_DbUpdate.Enabled = false;
                this.dgv_DbQuery.ReadOnly = true;
                flag = true;
            }
            
        }

        private void tlStripBtn_Close_Click(object sender, EventArgs e)
        {
            _delCloseTabPage();
        }
    }
}
