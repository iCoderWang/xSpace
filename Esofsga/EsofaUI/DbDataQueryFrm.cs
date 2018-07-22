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
        
        private void ViewQuery(string sql,string dgvName)
        {
            RawDataBLL rawDataBLL = new RawDataBLL();
            this.dgv_DbQuery.AutoGenerateColumns = true;
            DataGridViewColumnEditor dgvCE = new DataGridViewColumnEditor();
            this.dgv_DbQuery.Name = dgvName; // "dgvView";
            if(dgvName == "dgvView")
            {
                this.dgv_DbQuery.ReadOnly = true;
                this.dgv_DbQuery.DataSource = rawDataBLL.GetAvg_List(sql);
            }
            if (dgvName == "dgvTarget")
            {
                this.dgv_DbQuery.ReadOnly = false ;
                this.dgv_DbQuery.DataSource = rawDataBLL.GetList(sql);
            }
            dgvCE.ColumHeaderEdit(this.dgv_DbQuery, this.dgv_DbQuery.Name);
        }
        private void tlStrip_DbQueryAll_Click(object sender, EventArgs e)
        {
            string str = null;
            string sql = null;
           if(this.tlStrip_DbQueryAll.Tag != null)
            {
                if ((this.tlStrip_DbQueryAll.Tag).ToString() != "" && (this.tlStrip_DbQueryAll.Tag).ToString() == "dgvTarget")
                {
                    str = "dgvTarget";
                }
                else if ((this.tlStrip_DbQueryAll.Tag).ToString() == "" || (this.tlStrip_DbQueryAll.Tag).ToString() == "dgvView")
                {
                    str = "dgvView";
                }
                else
                {
                    MessageBox.Show("表格列对应错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
           else if(this.tlStrip_DbQueryAll.Tag == null)
            {
                str = "dgvView";
            }
            else
            {
                MessageBox.Show("表格列对应错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            switch (str)
            {
                case "dgvView":
                    sql = "select * from view_target";
                    ViewQuery(sql,str);
                    break;

                case "dgvTarget":
                    sql = "select * from target";
                    ViewQuery(sql, str);
                    break;
            }
        }

        private void tlStrip_DbQueryBy_Click(object sender, EventArgs e)
        {
            this.dgv_DbQuery.DataSource = null;
            ConditionalQueryFrm cqf = new ConditionalQueryFrm(ViewQuery);
            if (this.tlStrip_DbQueryBy.Tag != null)
            {
                if ((this.tlStrip_DbQueryBy.Tag).ToString() != "" && (this.tlStrip_DbQueryBy.Tag).ToString() == "dgvTarget")
                {
                    cqf.dgvName = "dgvTarget";
                }
                else if ((this.tlStrip_DbQueryBy.Tag).ToString() == "" || (this.tlStrip_DbQueryBy.Tag).ToString() == "dgvView")
                {
                    cqf.dgvName = "dgvView";
                }
                else
                {
                    MessageBox.Show("表格列对应错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (this.tlStrip_DbQueryBy.Tag == null)
            {
                cqf.dgvName = "dgvView";
            }
            else
            {
                MessageBox.Show("表格列对应错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                this.tlStrip_DbQueryAll.Tag = "dgvTarget";
                this.tlStrip_DbQueryBy.Tag = "dgvTarget";
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
                this.tlStrip_DbQueryAll.Tag = "dgvView";
                this.tlStrip_DbQueryBy.Tag = "dgvView";
                flag = true;
            }
            
        }

        private void tlStripBtn_Close_Click(object sender, EventArgs e)
        {
            _delCloseTabPage();
        }
    }
}
