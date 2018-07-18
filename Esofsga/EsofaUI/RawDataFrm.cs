using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsofaModel;
using EsofaBLL;

namespace EsofaUI
{
    public delegate void DelCloseTabPage();
    public partial class RawDataFrm : Form
    {
        private DelCloseTabPage _delCloseTabPage;
        public RawDataFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 用委托作参数构建构造函数
        /// </summary>
        /// <param name="delCloseTabPage"></param>
        public RawDataFrm(DelCloseTabPage delCloseTabPage)
        {
            this._delCloseTabPage = delCloseTabPage;
            InitializeComponent();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if(rawDataGridView.SelectedRows.Count > 0)
            {
                RawDataBLL rdb = new RawDataBLL();
                string sql = "";
                int counter=0;
                //int rowCounts;
                DialogResult RSS = MessageBox.Show(this, "确定要写入选中行数据吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (RSS)
                {
                    case DialogResult.Yes:
                        for (int i = this.rawDataGridView.SelectedRows.Count; i > 0; i--)
                        {
                            sql = "insert into target " +
                                "(tgt_Att_Name, bsn_Att_Name, tgt_Att_Ps, tgt_Att_Para_Sc, tgt_Att_Para_Gr_Min, " +
                                "tgt_Att_Para_Gr_Max, tgt_Geo_Para_TrRoms_Min, tgt_Geo_Para_TrRoms_Max, tgt_Geo_Para_Toc_Min, tgt_Geo_Para_Toc_Max," +
                                " tgt_Geo_Para_Kt, tgt_Geo_Para_Ro_Min, tgt_Geo_Para_Ro_Max, tgt_Geo_Para_Ea, tgt_Geo_Para_Gc_Min, " +
                                "tgt_Geo_Para_Gc_Max, tgt_Geo_Para_Rr_Min, tgt_Geo_Para_Rr_Max, tgt_Geo_Para_Por_Min, tgt_Geo_Para_Por_Max, " +
                                "tgt_Geo_Para_Scd, tgt_Geo_Para_Rfc, tgt_Eng_Para_Dr_Min, tgt_Eng_Para_Dr_Max, tgt_Eng_Para_Pc_Min, " +
                                "tgt_Eng_Para_Pc_Max, tgt_Eng_Para_Per, tgt_Eng_Para_Fdd, tgt_Eng_Para_Psdc_Min, tgt_Eng_Para_Psdc_Max, " +
                                "tgt_Eng_Para_Bmc_Min, tgt_Eng_Para_Bmc_Max, tgt_Eng_Para_Ds, tgt_Eng_Para_Led, tgt_Mkt_Para_Gp," +
                                "tgt_Mkt_Para_Dmd, tgt_Mkt_Para_Tu, tgt_Mkt_Para_Pn, tgt_Mkt_Para_Sg) " +
                                "values ("
                                 +"\""+rawDataGridView.SelectedRows[i - 1].Cells[0].Value + "\",\"" + rawDataGridView.SelectedRows[i - 1].Cells[1].Value + "\",\"" + rawDataGridView.SelectedRows[i - 1].Cells[2].Value + "\",\""
                                 + rawDataGridView.SelectedRows[i - 1].Cells[3].Value + "\"," + rawDataGridView.SelectedRows[i - 1].Cells[4].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[5].Value + ","
                                 + rawDataGridView.SelectedRows[i - 1].Cells[6].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[7].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[8].Value + ","
                                 + rawDataGridView.SelectedRows[i - 1].Cells[9].Value + ",\"" + rawDataGridView.SelectedRows[i - 1].Cells[10].Value + "\"," + rawDataGridView.SelectedRows[i - 1].Cells[11].Value + ","
                                 + rawDataGridView.SelectedRows[i - 1].Cells[12].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[13].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[14].Value + ","
                                 + rawDataGridView.SelectedRows[i - 1].Cells[15].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[16].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[17].Value + ","
                                 + rawDataGridView.SelectedRows[i - 1].Cells[18].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[19].Value + ",\"" + rawDataGridView.SelectedRows[i - 1].Cells[20].Value + "\",\""
                                 +Convert.ToString (rawDataGridView.SelectedRows[i - 1].Cells[21].Value).Trim() + "\"," + rawDataGridView.SelectedRows[i - 1].Cells[22].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[23].Value + ","
                                 + rawDataGridView.SelectedRows[i - 1].Cells[24].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[25].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[26].Value + ",\""
                                 + Convert.ToString(rawDataGridView.SelectedRows[i - 1].Cells[27].Value).Trim() + "\"," + rawDataGridView.SelectedRows[i - 1].Cells[28].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[29].Value + ","
                                 + rawDataGridView.SelectedRows[i - 1].Cells[30].Value + "," + rawDataGridView.SelectedRows[i - 1].Cells[31].Value + ",\"" + rawDataGridView.SelectedRows[i - 1].Cells[32].Value + "\",\""
                                 + rawDataGridView.SelectedRows[i - 1].Cells[33].Value + "\",\"" + rawDataGridView.SelectedRows[i - 1].Cells[34].Value + "\",\"" + rawDataGridView.SelectedRows[i - 1].Cells[35].Value + "\",\""
                                 + rawDataGridView.SelectedRows[i - 1].Cells[36].Value + "\",\"" + rawDataGridView.SelectedRows[i - 1].Cells[37].Value + "\",\"" + rawDataGridView.SelectedRows[i - 1].Cells[38].Value + "\""
                                 + ")";
                            counter += rdb.Insert(sql);




                            //int ID = Convert.ToInt32(rawDataGridView.SelectedRows[i - 1].Cells[0].Value);
                            //rawDataGridView.Rows.RemoveAt(rawDataGridView.SelectedRows[i - 1].Index);
                            //使用获得的ID删除数据库的数据
                            //string SQL = "delete from UserInfo where UserId='" + ID.ToString() + "'";
                            //int s = Convert.ToInt32(cl.Execute(SQL)); //cl是操作类的一个对像，Execute()是类中的一个方法
                            if (counter != 0)
                            {
                                MessageBox.Show("成功插入选中"+counter +"行数据！");
                            }
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                MessageBox.Show("请选择需要写入的行。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
           // */
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            _delCloseTabPage();
        }
    }
}
