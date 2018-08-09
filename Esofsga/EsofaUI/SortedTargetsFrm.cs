using EsofaModel;
using System;
using System.Collections.Generic;
using EsofaCommon;
using System.Windows.Forms;
using System.Text;
using System.Linq;

namespace EsofaUI
{
    public partial class SortedTargetsFrm : Form
    {
        public SortedTargetsFrm()
        {
            InitializeComponent();
        }
        private List<SortedTargetsParas> lst_STP;
        public SortedTargetsFrm(List<SortedTargetsParas> list)
        {
            InitializeComponent();
            lst_STP = list;
        }

        private double[] arr_TotalScores;
        private string[] arr_TgtName;
        public SortedTargetsFrm(double[] scores,string [] names )
        {
            InitializeComponent();
            arr_TotalScores = scores;
            arr_TgtName = names;
        }

        private void ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //使用linq根据数组的index对某一个范围内的元素求和
            //double s1 = _arr.Where((num, index) => index > 1 && index <=3).Sum();f
            int s1 = 0, s2 = 0;
            StringBuilder strClass_1 = new StringBuilder();
            StringBuilder strClass_2 = new StringBuilder();
            StringBuilder strClass_3 = new StringBuilder();
            NaturalBreaksClassification nbc = new NaturalBreaksClassification();
            //对排序结果进行分类，并返回出三类值中的第一类的数量和第3类的数量
            nbc.ToClassify(arr_TotalScores,out s1,out s2);
            //将一类数据中目标区域名筛选出来
            arr_TgtName.Where((num,index)=>index>=0 && index<s1).ToList().ForEach(a=>strClass_1.Append(a+", "));
            //将二类数据中目标区域名筛选出来
            arr_TgtName.Where((num, index) => index >= s1 && index < arr_TgtName.Length-s2).ToList().ForEach(a => strClass_2.Append(a + ", "));
            //将三类数据中目标区域名筛选出来
            arr_TgtName.Where((num, index) => index >= arr_TgtName.Length - s2 && index < arr_TgtName.Length-1).ToList().ForEach(a => strClass_3.Append(a + ", "));
            MessageBox.Show("优等类:\r\n " + strClass_1.ToString() + "; \r\n\r\n中等类：\r\n " + strClass_2.ToString() +
                "; \r\n\r\n三等类：\r\n " + strClass_3.ToString());
        }
        
    }
}
