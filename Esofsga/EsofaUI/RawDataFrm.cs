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
        enum TgtSc { 好, 较好, 中, 差 };
        enum TgtScd { 好, 较好, 中, 差 };
        enum TgtRfc { 好, 较好, 中, 差 };
        enum TgtFdd { 好, 较好, 中, 差 };
        
        private void btnImport_Click(object sender, EventArgs e)
        {
            int counter = 0;
            try
            {
                if (rawDataGridView.SelectedRows.Count > 0)
                {
                    RawDataBLL rdb = new RawDataBLL();
                    string tgtName, bsnName, tgtPs, tgtSc = "";
                    float tgtGrN, tgtGrX, tgtTrRomsN, tgtTrRomsX, tgtTocN, tgtTocX;
                    string tgtKt;
                    float tgtRoN, tgtRoX, tgtEa, tgtGcN, tgtGcX, tgtRrN, tgtRrX, tgtPorN, tgtPorX;
                    string tgtScd = "", tgtRfc = "";
                    int tgtDrN, tgtDrX;
                    float tgtPcN, tgtPcX, tgtPer;
                    string tgtFdd = "";
                    float tgtPsdcN, tgtPsdcX;
                    int tgtBmcN, tgtBmcX;
                    string tgtDs, tgtLed, tgtGp, tgtDmd, tgtTu, tgtPn, tgtSg;
                    int[] colIndex = { 4, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19, 22, 23, 24, 25, 26, 28, 29, 30, 31 };


                    StringBuilder sql = new StringBuilder("insert ignore into target " +
                                    "(tgt_Att_Name, bsn_Att_Name, tgt_Att_Ps, tgt_Att_Para_Sc, tgt_Att_Para_Gr_Min, " +
                                    "tgt_Att_Para_Gr_Max, tgt_Geo_Para_TrRoms_Min, tgt_Geo_Para_TrRoms_Max, tgt_Geo_Para_Toc_Min, tgt_Geo_Para_Toc_Max," +
                                    " tgt_Geo_Para_Kt, tgt_Geo_Para_Ro_Min, tgt_Geo_Para_Ro_Max, tgt_Geo_Para_Ea, tgt_Geo_Para_Gc_Min, " +
                                    "tgt_Geo_Para_Gc_Max, tgt_Geo_Para_Rr_Min, tgt_Geo_Para_Rr_Max, tgt_Geo_Para_Por_Min, tgt_Geo_Para_Por_Max, " +
                                    "tgt_Geo_Para_Scd, tgt_Geo_Para_Rfc, tgt_Eng_Para_Dr_Min, tgt_Eng_Para_Dr_Max, tgt_Eng_Para_Pc_Min, " +
                                    "tgt_Eng_Para_Pc_Max, tgt_Eng_Para_Per, tgt_Eng_Para_Fdd, tgt_Eng_Para_Psdc_Min, tgt_Eng_Para_Psdc_Max, " +
                                    "tgt_Eng_Para_Bmc_Min, tgt_Eng_Para_Bmc_Max, tgt_Eng_Para_Ds, tgt_Eng_Para_Led, tgt_Mkt_Para_Gp," +
                                    "tgt_Mkt_Para_Dmd, tgt_Mkt_Para_Tu, tgt_Mkt_Para_Pn, tgt_Mkt_Para_Sg) values (\"");
                    //int rowCounts;
                    DialogResult RSS = MessageBox.Show(this, "确定要写入选中行数据吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (RSS)
                    {
                        case DialogResult.Yes:
                            for (int i = this.rawDataGridView.SelectedRows.Count; i > 0; i--)
                            {
                                for (int j = 0; j < colIndex.Length; j++)
                                {
                                    if (rawDataGridView.SelectedRows[i - 1].Cells[colIndex[j]].Value.ToString() == "")
                                    {
                                        rawDataGridView.SelectedRows[i - 1].Cells[colIndex[j]].Value = 0;
                                    }
                                }
                                if ((rawDataGridView.SelectedRows[i - 1].Cells[0].Value).ToString() != "")
                                {
                                    tgtName = (rawDataGridView.SelectedRows[i - 1].Cells[0].Value).ToString() + "\",";
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[1].Value).ToString() != "")
                                    {
                                        bsnName = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[1].Value).ToString() + "\",";
                                    }
                                    else
                                    {
                                        bsnName = "NULL,";
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[2].Value).ToString() != "")
                                    {
                                        tgtPs = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[2].Value).ToString() + "\",";
                                    }
                                    else
                                    {
                                        tgtPs = "NULL,";
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[3].Value).ToString() != "")
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[3].Value).ToString().Equals("中")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[3].Value).ToString().Equals("好")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[3].Value).ToString().Equals("差")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[3].Value).ToString().Equals("较好"))
                                        {
                                            tgtSc = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[3].Value).ToString() + "\",";
                                        }
                                        else
                                        {
                                            MessageBox.Show("'保存条件' 该字段值是枚举类型，只能是“好，较好，中，差”值中的一个。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        tgtSc = "NULL,";
                                    }

                                    if (Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[5].Value) >=
                                        Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[4].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[4].Value).ToString() != "")
                                        {
                                            tgtGrN = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[4].Value);
                                        }
                                        else
                                        {
                                            tgtGrN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[5].Value).ToString() != "")
                                        {
                                            tgtGrX = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[5].Value);
                                        }
                                        else
                                        {
                                            tgtGrX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大地质资源量应该大于或等于最小地质资源量！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if (Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[7].Value) >=
                                       Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[6].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[6].Value).ToString() != "")
                                        {
                                            tgtTrRomsN = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[6].Value);
                                        }
                                        else
                                        {
                                            tgtTrRomsN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[7].Value).ToString() != "")
                                        {
                                            tgtTrRomsX = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[7].Value);
                                        }
                                        else
                                        {
                                            tgtTrRomsX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大富有机质页岩厚度应该大于或等于最小富有机质页岩厚度！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if (Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[9].Value) >=
                                       Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[8].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[8].Value).ToString() != "")
                                        {
                                            tgtTocN = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[8].Value);
                                        }
                                        else
                                        {
                                            tgtTocN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[9].Value).ToString() != "")
                                        {
                                            tgtTocX = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[9].Value);
                                        }
                                        else
                                        {
                                            tgtTocX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大Toc值应该大于或等于最小Toc值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[10].Value).ToString() != "")
                                    {
                                        tgtKt = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[10].Value).ToString() + "\",";
                                    }
                                    else
                                    {
                                        tgtKt = "NULL,";
                                    }
                                    if (Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[12].Value) >=
                                      Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[11].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[11].Value).ToString() != "")
                                        {
                                            tgtRoN = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[11].Value);
                                        }
                                        else
                                        {
                                            tgtRoN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[12].Value).ToString() != "")
                                        {
                                            tgtRoX = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[12].Value);
                                        }
                                        else
                                        {
                                            tgtRoX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大Ro值应该大于或等于最小Ro值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[13].Value).ToString() != "")
                                    {
                                        tgtEa = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[13].Value);
                                    }
                                    else
                                    {
                                        tgtEa = 0;
                                    }
                                    if (Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[15].Value) >=
                                     Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[14].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[14].Value).ToString() != "")
                                        {
                                            tgtGcN = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[14].Value);
                                        }
                                        else
                                        {
                                            tgtGcN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[15].Value).ToString() != "")
                                        {
                                            tgtGcX = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[15].Value);
                                        }
                                        else
                                        {
                                            tgtGcX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大含气量值应该大于或等于最小含气量值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if (Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[17].Value) >=
                                     Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[16].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[16].Value).ToString() != "")
                                        {
                                            tgtRrN = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[16].Value);
                                        }
                                        else
                                        {
                                            tgtRrN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[17].Value).ToString() != "")
                                        {
                                            tgtRrX = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[17].Value);
                                        }
                                        else
                                        {
                                            tgtRrX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大资源丰度值应该大于或等于最小资源丰度值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if (Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[19].Value) >=
                                    Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[18].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[18].Value).ToString() != "")
                                        {
                                            tgtPorN = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[18].Value);
                                        }
                                        else
                                        {
                                            tgtPorN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[19].Value).ToString() != "")
                                        {
                                            tgtPorX = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[19].Value);
                                        }
                                        else
                                        {
                                            tgtPorX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大孔隙度值应该大于或等于最小孔隙度值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[20].Value).ToString() != "")
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[20].Value).ToString().Equals("中")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[20].Value).ToString().Equals("好")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[20].Value).ToString().Equals("差")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[20].Value).ToString().Equals("较好"))
                                        {
                                            tgtScd = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[20].Value).ToString() + "\",";
                                        }
                                        else
                                        {
                                            MessageBox.Show("'构造复杂程度' 该字段值是枚举类型，只能是“好，较好，中，差”值中的一个。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        tgtScd = "NULL,";
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[21].Value).ToString() != "")
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[21].Value).ToString().Equals("中")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[21].Value).ToString().Equals("好")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[21].Value).ToString().Equals("差")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[21].Value).ToString().Equals("较好"))
                                        {
                                            tgtRfc = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[21].Value).ToString() + "\",";
                                        }
                                        else
                                        {
                                            MessageBox.Show("'顶底板条件' 该字段值是枚举类型，只能是“好，较好，中，差”值中的一个。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        tgtRfc = "NULL,";
                                    }
                                    if (Convert.ToInt32(rawDataGridView.SelectedRows[i - 1].Cells[23].Value) >=
                                   Convert.ToInt32(rawDataGridView.SelectedRows[i - 1].Cells[22].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[22].Value).ToString() != "")
                                        {
                                            tgtDrN = Convert.ToInt32(rawDataGridView.SelectedRows[i - 1].Cells[22].Value);
                                        }
                                        else
                                        {
                                            tgtDrN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[23].Value).ToString() != "")
                                        {
                                            tgtDrX = Convert.ToInt32(rawDataGridView.SelectedRows[i - 1].Cells[23].Value);
                                        }
                                        else
                                        {
                                            tgtDrX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大埋深范围值应该大于或等于最小埋深范围值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if (Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[25].Value) >=
                                    Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[24].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[24].Value).ToString() != "")
                                        {
                                            tgtPcN = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[24].Value);
                                        }
                                        else
                                        {
                                            tgtPcN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[25].Value).ToString() != "")
                                        {
                                            tgtPcX = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[25].Value);
                                        }
                                        else
                                        {
                                            tgtPcX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大压力系数值应该大于或等于最小压力系数值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[26].Value).ToString() != "")
                                    {
                                        tgtPer = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[26].Value);
                                    }
                                    else
                                    {
                                        tgtPer = 0;
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[27].Value).ToString() != "")
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[27].Value).ToString().Equals("中")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[27].Value).ToString().Equals("好")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[27].Value).ToString().Equals("差")
                                            || (rawDataGridView.SelectedRows[i - 1].Cells[27].Value).ToString().Equals("较好"))
                                        {
                                            tgtFdd = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[27].Value).ToString() + "\",";
                                        }
                                        else
                                        {
                                            MessageBox.Show("'裂缝发育程度' 该字段值是枚举类型，只能是“好，较好，中，差”值中的一个。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        tgtFdd = "NULL,";
                                    }
                                    if (Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[29].Value) >=
                                   Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[28].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[28].Value).ToString() != "")
                                        {
                                            tgtPsdcN = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[28].Value);
                                        }
                                        else
                                        {
                                            tgtPsdcN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[29].Value).ToString() != "")
                                        {
                                            tgtPsdcX = Convert.ToSingle(rawDataGridView.SelectedRows[i - 1].Cells[29].Value);
                                        }
                                        else
                                        {
                                            tgtPsdcX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大主应力差异系数值应该大于或等于最小主应力差异系数值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if (Convert.ToInt32(rawDataGridView.SelectedRows[i - 1].Cells[31].Value) >=
                                  Convert.ToInt32(rawDataGridView.SelectedRows[i - 1].Cells[30].Value))
                                    {
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[30].Value).ToString() != "")
                                        {
                                            tgtBmcN = Convert.ToInt32(rawDataGridView.SelectedRows[i - 1].Cells[30].Value);
                                        }
                                        else
                                        {
                                            tgtBmcN = 0;
                                        }
                                        if ((rawDataGridView.SelectedRows[i - 1].Cells[31].Value).ToString() != "")
                                        {
                                            tgtBmcX = Convert.ToInt32(rawDataGridView.SelectedRows[i - 1].Cells[31].Value);
                                        }
                                        else
                                        {
                                            tgtBmcX = 0;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("最大脆性矿物含量值应该大于或等于最小脆性矿物含量值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[32].Value).ToString() != "")
                                    {
                                        tgtDs = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[32].Value).ToString() + "\",";
                                    }
                                    else
                                    {
                                        tgtDs = "NULL,";
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[33].Value).ToString() != "")
                                    {
                                        tgtLed = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[33].Value).ToString() + "\",";
                                    }
                                    else
                                    {
                                        tgtLed = "NULL,";
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[34].Value).ToString() != "")
                                    {
                                        tgtGp = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[34].Value).ToString() + "\",";
                                    }
                                    else
                                    {
                                        tgtGp = "NULL,";
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[35].Value).ToString() != "")
                                    {
                                        tgtDmd = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[35].Value).ToString() + "\",";
                                    }
                                    else
                                    {
                                        tgtDmd = "NULL,";
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[36].Value).ToString() != "")
                                    {
                                        tgtTu = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[36].Value).ToString() + "\",";
                                    }
                                    else
                                    {
                                        tgtTu = "NULL,";
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[37].Value).ToString() != "")
                                    {
                                        tgtPn = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[37].Value).ToString() + "\",";
                                    }
                                    else
                                    {
                                        tgtPn = "NULL,";
                                    }
                                    if ((rawDataGridView.SelectedRows[i - 1].Cells[38].Value).ToString() != "")
                                    {
                                        tgtSg = "\"" + (rawDataGridView.SelectedRows[i - 1].Cells[38].Value).ToString() + "\")";
                                    }
                                    else
                                    {
                                        tgtSg = "NULL)";
                                    }
                                    sql.Append(tgtName);
                                    sql.Append(bsnName);
                                    sql.Append(tgtPs);
                                    sql.Append(tgtSc);
                                    sql.Append(tgtGrN);
                                    sql.Append(",");
                                    sql.Append(tgtGrX);
                                    sql.Append(",");
                                    sql.Append(tgtTrRomsN);
                                    sql.Append(",");
                                    sql.Append(tgtTrRomsX);
                                    sql.Append(",");
                                    sql.Append(tgtTocN);
                                    sql.Append(",");
                                    sql.Append(tgtTocX);
                                    sql.Append(",");
                                    sql.Append(tgtKt);
                                    sql.Append(tgtRoN);
                                    sql.Append(",");
                                    sql.Append(tgtRoX);
                                    sql.Append(",");
                                    sql.Append(tgtEa);
                                    sql.Append(",");
                                    sql.Append(tgtGcN);
                                    sql.Append(",");
                                    sql.Append(tgtGcX);
                                    sql.Append(",");
                                    sql.Append(tgtRrN);
                                    sql.Append(",");
                                    sql.Append(tgtRrX);
                                    sql.Append(",");
                                    sql.Append(tgtPorN);
                                    sql.Append(",");
                                    sql.Append(tgtPorX);
                                    sql.Append(",");
                                    sql.Append(tgtScd);
                                    sql.Append(tgtRfc);
                                    sql.Append(tgtDrN);
                                    sql.Append(",");
                                    sql.Append(tgtDrX);
                                    sql.Append(",");
                                    sql.Append(tgtPcN);
                                    sql.Append(",");
                                    sql.Append(tgtPcX);
                                    sql.Append(",");
                                    sql.Append(tgtPer);
                                    sql.Append(",");
                                    sql.Append(tgtFdd);
                                    sql.Append(tgtPsdcN);
                                    sql.Append(",");
                                    sql.Append(tgtPsdcX);
                                    sql.Append(",");
                                    sql.Append(tgtBmcN);
                                    sql.Append(",");
                                    sql.Append(tgtBmcX);
                                    sql.Append(",");
                                    sql.Append(tgtDs);
                                    sql.Append(tgtLed);
                                    sql.Append(tgtGp);
                                    sql.Append(tgtDmd);
                                    sql.Append(tgtTu);
                                    sql.Append(tgtPn);
                                    sql.Append(tgtSg);
                                    //sql.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("目标区块名称不能为空，数据导入中止！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                counter += rdb.Insert(sql.ToString());
                            }
                            if (counter != 0)
                            {
                                MessageBox.Show("成功插入选中" + counter + "行数据！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            catch
            {
                MessageBox.Show("目标区块名称冲突，数据库中已存在当前要插入的第 "+(counter+1)+" 行数据！" , "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            _delCloseTabPage();
        }
    }
}
