using System;
using EsofaBLL;
using EsofaCommon;
using System.Windows.Forms;
using System.Data;
using System.Text;
using EsofaModel;
using EsofaBLL;
using System.Collections.Generic;

namespace EsofaUI
{
    public partial class DbDataQueryFrm : Form
    {
        int clickCounterSingle = 0;
        int clickCounterMulti = 0;
        DataTable dt;
        private DelCloseTabPage _delCloseTabPage;
        StringBuilder sqlSingle = new StringBuilder("delete  from target where tgt_id in (");
        StringBuilder sqlMulti = new StringBuilder("delete  from target where tgt_id in (");
        public DbDataQueryFrm()
        {
            InitializeComponent();
        }
        public DbDataQueryFrm(DelCloseTabPage delCTP)
        {
            this._delCloseTabPage = delCTP;
            InitializeComponent();
        }
        /// <summary>
        /// 定义的查询方法，以供窗体间委托调用
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="dgvName"></param>
        private void ViewQuery(string sql,string dgvName)
        {
            RawDataBLL rawDataBLL = new RawDataBLL();
            this.dgv_DbQuery.AutoGenerateColumns = true;
            DataGridViewColumnEditor dgvCE = new DataGridViewColumnEditor();
            this.dgv_DbQuery.Name = dgvName; // "dgvView";
            this.dgv_DbQuery.ReadOnly = true;
            if(dgvName == "dgvView")
            {
                this.dgv_DbQuery.ReadOnly = true;
                //将List数据转变成DataTable类型
                dt = DataSourceToDataTable.GetListToDataTable<AverageValuesTargetEntity>
                    (rawDataBLL.GetAvg_List(sql));
                //this.dgv_DbQuery.DataSource = rawDataBLL.GetAvg_List(sql);
                this.dgv_DbQuery.DataSource = dt;
            }
            if (dgvName == "dgvTarget")
            {
                this.dgv_DbQuery.ReadOnly = false ;
                dt = DataSourceToDataTable.GetListToDataTable<TargetEntity>(rawDataBLL.GetList(sql));
                this.dgv_DbQuery.DataSource = dt;// rawDataBLL.GetList(sql);
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
                    {
                        sql = "select * from view_target";
                        ViewQuery(sql, str);
                        break;
                    }
                case "dgvTarget":
                    {
                        sql = "select * from target";
                        ViewQuery(sql, str);
                        break;
                    }
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

        private void tlStripBtn_Close_Click(object sender, EventArgs e)
        {
            _delCloseTabPage();
        }

        

        /// <summary>
        /// 删除datagridview中的行，每次删除一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlStripBtn_SingleDel_Click(object sender, EventArgs e)
        {
            int tgtId = 0;
            string cellValue = "";
            if (dgv_DbQuery.DataSource == null)
            {
                MessageBox.Show(" 数据表为空，无法删除，请先查询数据。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (dgv_DbQuery.SelectedRows.Count == 0)
                {
                    MessageBox.Show(" 请选择将要删除的行。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult dss = MessageBox.Show("数据被删除后将不可恢复，请确认是否要删除当前\r\n所选中的行记录？",
                        "信息",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                    switch (dss)
                    {
                        case DialogResult.Yes:
                            {
                                
                                //删除DataGridView 的行，数据源必须绑定（公用 DataTable变量 dt用于存储源数据）
                                DataGridViewRow dgvRow = dgv_DbQuery.SelectedRows[0];
                                int rowIndex = dgv_DbQuery.SelectedRows[0].Index;
                                cellValue = (dgvRow.Cells[dgvRow.Cells.Count - 1].Value).ToString();
                                if (cellValue != "")
                                {
                                    if (dgvRow.Selected)
                                    {
                                        tgtId = Convert.ToInt32(dgvRow.Cells[dgvRow.Cells.Count - 1].Value);
                                        dgv_DbQuery.Rows.Remove(dgvRow);
                                        //dgv_DbQuery.InvalidateRow(rowIndex);
                                        dgv_DbQuery.Refresh();
                                    }
                                    if (clickCounterSingle == 0)
                                    {
                                        sqlSingle.Append(tgtId);
                                        clickCounterSingle++;
                                    }
                                    else
                                    {
                                        sqlSingle.Append("," + tgtId);
                                    }
                                }
                                else
                                {
                                    if (dgvRow.Selected)
                                    {
                                        //tgtId = Convert.ToInt32(dgvRow.Cells[dgvRow.Cells.Count - 1].Value);
                                        dgv_DbQuery.Rows.Remove(dgvRow);
                                        //dgv_DbQuery.InvalidateRow(rowIndex);
                                        dgv_DbQuery.Refresh();
                                    }
                                }  
                            }
                            if (cellValue != "")
                            {
                                if (!this.tlStripBtn_DbUpdate.Enabled)
                                {
                                    tlStripBtn_DbUpdate.Enabled = true;
                                }
                                MessageBox.Show("请更新数据库，完成数据记录删除动作。", "信息",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }                                
                            break;
                        case DialogResult.No:
                            break;
                    }      
                }
            }  
        }

       
        private void tlStripBtn_MultiDel_Click(object sender, EventArgs e)
        {
            int tgtId = 0;
            string cellValue="";
            if (dgv_DbQuery.DataSource == null)
            {
                MessageBox.Show(" 数据表为空，无法删除，请先查询数据。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (dgv_DbQuery.SelectedRows.Count == 0)
                {
                    MessageBox.Show(" 请选择将要删除的行。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult dss = MessageBox.Show("数据被删除后将不可恢复，请确认是否要删除当前\r\n所选中的行记录？",
                        "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    switch (dss)
                    {
                        case DialogResult.Yes:
                            {
                                ////删除DataGridView 的行，数据源必须绑定（公用 DataTable变量 dt用于存储源数据）
                                foreach (DataGridViewRow dgvRow in dgv_DbQuery.SelectedRows)
                                {
                                    cellValue = (dgvRow.Cells[dgvRow.Cells.Count - 1].Value).ToString();
                                    if (cellValue != "")
                                    {
                                        tgtId = Convert.ToInt32(dgvRow.Cells[dgvRow.Cells.Count - 1].Value);
                                        dgv_DbQuery.Rows.Remove(dgvRow);
                                        if (clickCounterMulti == 0)
                                        {
                                            sqlMulti.Append(tgtId);
                                        }
                                        else
                                        {
                                            sqlMulti.Append("," + tgtId);
                                        }
                                        clickCounterMulti++;
                                    }
                                    else
                                    {
                                        dgv_DbQuery.Rows.Remove(dgvRow);
                                    }
                                }
                                dgv_DbQuery.Refresh();
                            }
                            
                            if (cellValue != "")
                            {
                                if (!this.tlStripBtn_DbUpdate.Enabled)
                                {
                                    tlStripBtn_DbUpdate.Enabled = true;
                                    //tlStripBtn_DbUpdate.AutoToolTip = false;
                                    //tlStripBtn_DbUpdate.ToolTipText = " 更新数据库";
                                }
                                MessageBox.Show("请更新数据库，完成数据记录删除动作。", "信息", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
    }

        //private void tlStripBtn_Refresh_Click(object sender, EventArgs e)
        //{
        //    dgv_DbQuery.DataSource = dt;
        //    dgv_DbQuery.Refresh();
        //}
        int sn = 0;
        private void tlStripBtn_BlankRowAdd_Click(object sender, EventArgs e)
        {
            dgv_DbQuery.AllowUserToAddRows = false;
            dgv_DbQuery.ReadOnly = false;

            ////DataTable dt = DataSourceToDataTable.GetListToDataTable(new List<TargetEntity>());
            ////dgv_DbQuery.DataSource = dt;
            ////DataGridViewColumnEditor dgvce = new DataGridViewColumnEditor();
            ////dgvce.ColumHeaderEdit(dgv_DbQuery, "dgvTarget");
            ////dt = (DataTable)this.dgv_DbQuery.DataSource;
            ////DataRow dR = dt.NewRow();
            ////dt.Rows.Add(dR);
            ////dgv_DbQuery.Refresh();
            DataRow dR = null;
            if (dgv_DbQuery.DataSource == null)
            {
                sn = 0;
                //System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                //watch.Start();
                DataTable dt = DataSourceToDataTable.GetListToDataTable(new List<TargetEntity>());
                //watch.Stop();
                //TimeSpan ts = watch.Elapsed;
                dgv_DbQuery.DataSource = dt;
                DataGridViewColumnEditor dgvce = new DataGridViewColumnEditor();
                //watch.Start();
                dgvce.ColumHeaderEdit(dgv_DbQuery, "dgvTarget");
                //watch.Stop();
                //ts = watch.Elapsed;
                //rowIndex = dgv_DbQuery.NewRowIndex;
                //dgv_DbQuery.Rows[rowIndex].Cells[0].Value = (++sn).ToString();
                dt = (DataTable)this.dgv_DbQuery.DataSource;
                //DataRow dR = dt.NewRow();
                dR = dt.NewRow();
                dt.Rows.Add(dR);
                dgv_DbQuery.Refresh();
            }
            else
            {
                dt = (DataTable)this.dgv_DbQuery.DataSource;
                //DataRow dR = dt.NewRow();
                dR = dt.NewRow();
                // int rowscount = dt.Rows.Count;
                //dR.Rows.InsertAt(row, rowscount);
                dt.Rows.Add(dR);
                dgv_DbQuery.Refresh();
            }

        }

        private void Dgv_DbQuery_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tlStripBtn_BlankRowDel_Click(object sender, EventArgs e)
        {

        }

        private void tlStripBtn_DbUpdate_Click(object sender, EventArgs e)
        {
            RawDataBLL rdb = new RawDataBLL();
            if (clickCounterSingle == 0 && clickCounterMulti == 0)
            {
                MessageBox.Show("没有要删除的数据记录存在。","信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.tlStripBtn_DbUpdate.Enabled = false;
                return;
            }
            if(clickCounterSingle != 0)
            {
                //RawDataBLL rdb = new RawDataBLL();
                sqlSingle.Append(")");
                rdb.ExecuteCmd(sqlSingle.ToString());
                sqlSingle.Replace(sqlSingle.ToString(), "delete  from target where tgt_id in (");
                //sqlSingle="delete  from target where tgt_id in (";
                clickCounterSingle = 0;
            }
            if (clickCounterMulti != 0)
            {
                //RawDataBLL rdb = new RawDataBLL();
                sqlMulti.Append(")");
                rdb.ExecuteCmd(sqlMulti.ToString());
                sqlMulti.Replace(sqlMulti.ToString(), "delete  from target where tgt_id in (");
                //sqlSingle="delete  from target where tgt_id in (";
                clickCounterMulti = 0;
            }
            this.tlStripBtn_DbUpdate.Enabled = false;
            MessageBox.Show("数据已成功从数据库删除。","信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void tlStrip_ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tlStrip_ChkBox.Checked)
            {
                dgv_DbQuery.DataSource = null;
                this.tlStripBtn_MultiDel.Enabled = true;
                this.tlStripBtn_SingleDel.Enabled = true;
                this.tlStripBtn_BlankRowAdd.Enabled = true;
                this.tlStripBtn_BlankRowDel.Enabled = true;
                //this.tlStripBtn_DbUpdate.Enabled = true;
                this.dgv_DbQuery.ReadOnly = false;
                this.tlStrip_DbQueryAll.Tag = "dgvTarget";
                this.tlStrip_DbQueryBy.Tag = "dgvTarget";
                return;
                }
            if(!tlStrip_ChkBox.Checked)
            {
                this.tlStripBtn_MultiDel.Enabled = false;
                this.tlStripBtn_SingleDel.Enabled = false;
                this.tlStripBtn_BlankRowAdd.Enabled = false;
                this.tlStripBtn_BlankRowDel.Enabled = false;
                this.tlStripBtn_DbUpdate.Enabled = false;
                this.dgv_DbQuery.ReadOnly = true;
                this.tlStrip_DbQueryAll.Tag = "dgvView";
                this.tlStrip_DbQueryBy.Tag = "dgvView";
            }
        }


    }
}
