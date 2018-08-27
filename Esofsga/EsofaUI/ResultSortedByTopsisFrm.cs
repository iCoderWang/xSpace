using System;
using System.Collections.Generic;
using EsofaCommon;
using System.Windows.Forms;
using EsofaModel;
using System.Text;
using System.Drawing;
using System.Linq;

namespace EsofaUI
{
    public partial class ResultSortedByTopsisFrm : Form
    {
        public ResultSortedByTopsisFrm()
        {
            InitializeComponent();
        }

        private List<IdealSolutionByTopsisEntity> lst_ISTE;
        private double[] arr_Ci;
        private string[] arr_TgtName;
        public ResultSortedByTopsisFrm(List<IdealSolutionByTopsisEntity> lst,double [] arr,string [] arrTgt)
        {
            lst_ISTE = lst;
            arr_Ci = arr;
            arr_TgtName = arrTgt;
            InitializeComponent();
        }

        private void ResultSortedByTopsisFrm_Load(object sender, EventArgs e)
        {
            DataGridViewColumnEditor dgvce = new DataGridViewColumnEditor();
            dgvce.ColumHeaderEdit(dgv_SortedByTopsis, "dgv_SortedByTopsis");
            //dgv_SortedByTopsis.DataSource = DataSourceToDataTable.GetListToDataTable(lst_ISTE);
        }

        private void ToolStripMenuItem_Classify_Click(object sender, EventArgs e)
        {
            //使用linq根据数组的index对某一个范围内的元素求和
            //double s1 = _arr.Where((num, index) => index > 1 && index <=3).Sum();f
            int s1 = 0, s2 = 0;
            StringBuilder strClass_1 = new StringBuilder();
            StringBuilder strClass_2 = new StringBuilder();
            StringBuilder strClass_3 = new StringBuilder();
            NaturalBreaksClassification nbc = new NaturalBreaksClassification();
            //对排序结果进行分类，并返回出三类值中的第一类的数量和第3类的数量
            nbc.ToClassify(arr_Ci, out s1, out s2);
            for (int i = 0; i < arr_TgtName.Length; i++)
            {
                if (i < s1)
                {
                    dgv_SortedByTopsis.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                if (i >= arr_TgtName.Length - s2)
                {
                    dgv_SortedByTopsis.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;//.YellowGreen;
                }
            }
            //将一类数据中目标区域名筛选出来
            arr_TgtName.Where((num, index) => index >= 0 && index < s1).ToList().ForEach(a => strClass_1.Append(a + ", "));
            //将二类数据中目标区域名筛选出来
            arr_TgtName.Where((num, index) => index >= s1 && index < arr_TgtName.Length - s2).ToList().ForEach(a => strClass_2.Append(a + ", "));
            //将三类数据中目标区域名筛选出来
            arr_TgtName.Where((num, index) => index >= arr_TgtName.Length - s2 && index < arr_TgtName.Length).ToList().ForEach(a => strClass_3.Append(a + ", "));
            MessageBox.Show("有利区:\r\n " + strClass_1.ToString() + "; \r\n\r\n一般区：\r\n " + strClass_2.ToString() +
                "; \r\n\r\n较差区：\r\n " + strClass_3.ToString());
        }
    }
}
