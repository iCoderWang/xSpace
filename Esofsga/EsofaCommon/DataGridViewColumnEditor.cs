using System.Windows.Forms;

namespace EsofaCommon
{
    public partial class DataGridViewColumnEditor
    {
        public void ColumHeaderEdit(DataGridView dgv, string dgvName)
        {
            dgv.AutoGenerateColumns = true;
            dgv.Name = dgvName;
             if(dgvName == "dgvTarget")
            {
                //定义数组变量，存放参数名
                string[] headerTxt = new string[] { "目标区", "盆地", "主力层系", "保存条件", "最小_地质资源量 (万亿方)", "最大_地质资源量 (万亿方)",
                                                                  "最小_富有机质页岩厚度","最大_富有机质页岩厚度","最小_TOC(%)","最大_TOC(%)","干酪根类型",
                                                                  "最小_Ro(%)","最大_Ro(%)","有效圈定面积(1000-4000米深,平方千米)","最小_含气量 (立方米/吨)","最大_含气量 (立方米/吨)","最小_资源丰度(亿立方米/平方千米)","最大_资源丰度(亿立方米/平方千米)",
                                                                  "最小_孔隙度(%)","最大_孔隙度(%)","构造复杂度","顶底板岩性","最小_埋深范围","最大_埋深范围",
                                                                  "最小_压力系数","最大_压力系数","渗透率","裂缝发育度","最小_主应力差异系数","最大_主应力差异系数",
                                                                  "最小_脆性矿物含量","最大_脆性矿物含量","水系","区域勘探度","市场气价","市场需求","交通设施","管网条件","地表地貌" };
                for (int i=0; i < headerTxt.Length; i++)
                {
                    //表头单元格中间对齐
                    dgv.Columns[i].HeaderCell.DataGridView.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
                    //去掉了系统默认的表头单元格内预留的空白格，使其内文本，真正实现居中
                    dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    //非表头的单元格元素居中对齐
                    dgv.Columns[i].DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //单元格实现自动换行
                    dgv.Columns[i].HeaderCell.DataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    //表头赋值
                    dgv.Columns[i].HeaderText = headerTxt[i];
                 }
              }
        }
    }
}
