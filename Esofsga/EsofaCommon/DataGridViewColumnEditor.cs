using System;
using System.Windows.Forms;

namespace EsofaCommon
{
    public partial class DataGridViewColumnEditor
    {
        public void ColumHeaderEdit(DataGridView dgv, string dgvName)
        {
            dgv.AutoGenerateColumns = true;
            //dgv.Name = dgvName;
            //int[] columnsIndex_Basin = new int[] { };
            //int[] columnsIndex_BLock = new int[] { };
            //int[] columnsIndex_Target = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29 };
            string[] headerTxt = null;
            if (dgvName == "dgvTarget")
            {
                string[] tgtHeaderTxt = new string[] { "目标区", "盆地/区域 ", "主力层系", "保存条件", "最小_地质资源量 (万亿方)",
                    "最大_地质资源量 (万亿方)","最小_富有机质页岩厚度","最大_富有机质页岩厚度","最小_TOC(%)","最大_TOC(%)",
                    "干酪根类型","最小_Ro(%)","最大_Ro(%)","有效圈定面积(1-4k米深,km^2)","最小_含气量 (m^3/t)",
                    "最大_含气量 (m^3/t)","最小_资源丰度(亿m^3/km^3)","最大_资源丰度(亿m^3/km^3)","最小_孔隙度(%)",
                    "最大_孔隙度(%)","构造复杂度","顶底板岩性","最小_埋深范围","最大_埋深范围","最小_压力系数","最大_压力系数",
                    "渗透率","裂缝发育度","最小_主应力差异系数","最大_主应力差异系数","最小_脆性矿物含量","最大_脆性矿物含量","水系",
                    "区域勘探度","市场气价","市场需求","交通设施","管网条件","地表地貌","Id" };
                //定义数组变量，存放参数名
                headerTxt = tgtHeaderTxt;
            }
            if (dgvName == "dgvView_Basin")
            {
                string[] bsnViewHeaderTxt = new string[] {"目标区", "盆地/区域 ", "主力层系", "保存条件", "平均_地质资源量 (万亿方)",
                    "平均_富有机质页岩厚度", "平均_TOC(%)","干酪根类型","平均_Ro(%)","有效圈定面积(1-4k米深,km^2)",
                    "平均_资源丰度(亿m^3/km^3)","构造复杂度","平均_埋深范围","平均_脆性矿物含量","Id" };
                //定义数组变量，存放参数名
                headerTxt = bsnViewHeaderTxt;
            }
            if (dgvName == "dgvView_Block")
            {
                string[] blkViewHeaderTxt = new string[] { "目标区", "盆地/区域 ", "主力层系", "保存条件", "平均_地质资源量 (万亿方)",
                    "平均_富有机质页岩厚度", "平均_TOC(%)","干酪根类型","平均_Ro(%)","有效圈定面积(1-4k米深,km^2)",
                    "平均_含气量 (m^3/t)","平均_资源丰度(亿m^3/km^3)","平均_孔隙度(%)","构造复杂度",
                    "平均_埋深范围","平均_压力系数","平均_脆性矿物含量","地表地貌","Id" };
                //定义数组变量，存放参数名
                headerTxt = blkViewHeaderTxt;
            }
            if (dgvName == "dgvView")
            {
                string[] viewHeaderTxt = new string[] { "目标区", "盆地/区域 ", "主力层系", "保存条件", "平均_地质资源量 (万亿方)",
                    "平均_富有机质页岩厚度", "平均_TOC(%)","干酪根类型","平均_Ro(%)","有效圈定面积(1-4k米深,km^2)",
                    "平均_含气量 (m^3/t)","平均_资源丰度(亿m^3/km^3)","平均_孔隙度(%)","构造复杂度","顶底板岩性",
                    "平均_埋深范围","平均_压力系数","渗透率","裂缝发育度","平均_主应力差异系数","平均_脆性矿物含量","水系",
                    "区域勘探度","市场气价","市场需求","交通设施","管网条件","地表地貌","Id" };
                //定义数组变量，存放参数名
                headerTxt = viewHeaderTxt;
            }
            if(dgvName == "dgvTgt_TDM")
            {
                //定义TOPSIS Decision Matrix (TDM) 的 DataGridView的 Column Header Text
                string[] dgvTgtTDMHeaderTxt = new string[] { "目标区",
                    "平均_富有机质页岩厚度", "平均_TOC(%)","干酪根类型","平均_Ro(%)","有效圈定面积(1-4k米深,km^2)",
                    "平均_含气量 (m^3/t)","平均_资源丰度(亿m^3/km^3)","平均_孔隙度(%)","构造复杂度","顶底板岩性",
                    "平均_埋深范围","平均_压力系数","渗透率","裂缝发育度","平均_主应力差异系数","平均_脆性矿物含量","水系",
                    "区域勘探度","市场气价","市场需求","交通设施","管网条件","地表地貌"};
                //定义数组变量，存放参数名
                headerTxt = dgvTgtTDMHeaderTxt;
            }
            if (dgvName == "dgvBlk_TDM")
            {
                string[] dgvBlkTDMHeaderTxt = new string[] { "目标区", 
                    "平均_富有机质页岩厚度", "平均_TOC(%)","干酪根类型","平均_Ro(%)","有效圈定面积(1-4k米深,km^2)",
                    "平均_含气量 (m^3/t)","平均_资源丰度(亿m^3/km^3)","平均_孔隙度(%)","构造复杂度",
                    "平均_埋深范围","平均_压力系数","平均_脆性矿物含量","地表地貌" };
                //定义数组变量，存放参数名
                headerTxt = dgvBlkTDMHeaderTxt;
            }
            if (dgvName == "dgvBsn_TDM")
            {
                string[] dgvBsnTDMHeaderTxt = new string[] {"目标区", 
                    "平均_富有机质页岩厚度", "平均_TOC(%)","干酪根类型","平均_Ro(%)","有效圈定面积(1-4k米深,km^2)",
                    "平均_资源丰度(亿m^3/km^3)","构造复杂度","平均_埋深范围","平均_脆性矿物含量"};
                //定义数组变量，存放参数名
                headerTxt = dgvBsnTDMHeaderTxt;
            }
            //System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            //watch.Start();
            dgv.ColumnHeadersDefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            for (int i=0; i <= headerTxt.Length; i++)
            {
                
                //表头单元格中间对齐
                //dgv.Columns[i].HeaderCell.DataGridView.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
                //去掉了系统默认的表头单元格内预留的空白格，使其内文本，真正实现居中
                //dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //非表头的单元格元素居中对齐
                //dgv.Columns[i].DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //单元格实现自动换行
                //dgv.Columns[i].HeaderCell.DataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                
                //表头赋值
                if (i == 0)
                {
                    dgv.Columns[i].HeaderText = "序号";                   
                }
                else if(i == headerTxt.Length && headerTxt[i-1].Equals("Id"))
                {
                    //dgv.Columns[i].HeaderText = "序号";
                    dgv.Columns[i].Visible = false;
                }
                else
                {
                    dgv.Columns[i].HeaderText = headerTxt[i - 1];
                }
            }
            //watch.Stop();
            //TimeSpan ts = watch.Elapsed;
        }
    }
}
