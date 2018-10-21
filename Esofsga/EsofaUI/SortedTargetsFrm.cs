using EsofaModel;
using System;
using System.Collections.Generic;
using EsofaCommon;
using System.Windows.Forms;
using System.Text;
using System.Linq;
using System.Drawing;
using MyWord = Microsoft.Office.Interop.Word;


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
        StringBuilder strClass_1 = new StringBuilder();
        StringBuilder strClass_2 = new StringBuilder();
        StringBuilder strClass_3 = new StringBuilder();
        //private string strBlocks;
        public SortedTargetsFrm(double[] scores,string [] names )
        {
            InitializeComponent();
            arr_TotalScores = scores;
            arr_TgtName = names;
        }

        private void ToolStripMenuItem_Classify_Click(object sender, System.EventArgs e)
        {
            //使用linq根据数组的index对某一个范围内的元素求和
            //double s1 = _arr.Where((num, index) => index > 1 && index <=3).Sum();f
            int s1 = 0, s2 = 0;           
            NaturalBreaksClassification nbc = new NaturalBreaksClassification();
            //对排序结果进行分类，并返回出三类值中的第一类的数量和第3类的数量
            nbc.ToClassify(arr_TotalScores,out s1,out s2);
            for(int i = 0; i < arr_TgtName.Length; i++)
            {
                if (i < s1)
                {
                    dgv_Tgt_Sorted.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                if( i>= arr_TgtName.Length - s2)
                {
                    dgv_Tgt_Sorted.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;//.YellowGreen;
                }
            }
            //将一类数据中目标区域名筛选出来
            //arr_TgtName.Where((num, index) => index >= 0 && index < s1).ToList().ForEach(a => strClass_1.Append(a + "、 "));
            var favList = arr_TgtName.Where((num, index) => index >= 0 && index < s1).ToList();
            favList.ForEach(a => { if (a != favList.Last()) { strClass_1.Append(a + "、 "); } else { strClass_1.Append(a); } });
            //将二类数据中目标区域名筛选出来
            var normList = arr_TgtName.Where((num, index) => index >= s1 && index < arr_TgtName.Length - s2).ToList();
            normList.ForEach(a => { if (a != normList.Last()) { strClass_2.Append(a + "、 "); } else { strClass_2.Append(a); } });
            //将三类数据中目标区域名筛选出来
            var worseList = arr_TgtName.Where((num, index) => index >= arr_TgtName.Length - s2 && index < arr_TgtName.Length).ToList();
            worseList.ForEach(a => { if (a != worseList.Last()) { strClass_3.Append(a + "、"); } else { strClass_3.Append(a); } });
            MessageBox.Show("有利区：  " + strClass_1.ToString() + " ; \r\n\r\n一般区：  " + strClass_2.ToString() +
                " ; \r\n\r\n较差区：  " + strClass_3.ToString() + " ;", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem_GenerateReport_Click(object sender, EventArgs e)
        {
            WordHelper wh = new WordHelper();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word File|*.docx|(*.*)|*.*";
            sfd.Title = "保存文件";
            //sfd.ShowDialog();
            StringBuilder strBlocks = new StringBuilder();
            foreach(string str in arr_TgtName)
            {
                if (str != arr_TgtName.Last())
                {
                    strBlocks.Append(str + "、");
                }
                else
                {
                    strBlocks.Append(str + ";");
                }
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string strFileName = sfd.FileName;
                wh.CreateWord(strFileName);
                wh.InsertText("页岩气选区评价结果分析", 18, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphCenter,0);
                wh.NewLine();
                wh.InsertText("一、核心区参与评价区块",16,1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft,0);
                wh.NewLine();
                wh.InsertText(strBlocks.ToString(), 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft,30);
                wh.NewLine();
                wh.InsertText("二、层次分析法（AHP）评价参数、判断矩阵及权重", 16, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft,0);
                wh.NewLine();
                wh.InsertText("2.1、地质因素", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                wh.NewLine();
                wh.InsertText("2.1.1、评价参数", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                wh.InsertText(PublicValues.GeoParas, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("2.1.2、判断矩阵", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                wh.DGV2Word(PublicValues.dgv_Geo);
                //wh.NewLine();
                wh.InsertText("2.1.3、地质参数权重", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                wh.InsertText(PublicValues.GeoWgt, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("2.2、工程因素", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                wh.NewLine();
                wh.InsertText("2.2.1、评价参数", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                wh.InsertText(PublicValues.EngParas, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("2.2.2、判断矩阵", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                wh.DGV2Word(PublicValues.dgv_Eng);
                //wh.NewLine();
                wh.InsertText("2.2.3、工程参数权重", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                wh.InsertText(PublicValues.EngWgt, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("2.3、经济因素", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                wh.NewLine();
                wh.InsertText("2.3.1、评价参数", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                wh.InsertText(PublicValues.EcoParas, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("2.3.2、判断矩阵", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                wh.DGV2Word(PublicValues.dgv_Eco);
                //wh.NewLine();
                wh.InsertText("2.3.3、经济参数权重", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                wh.InsertText(PublicValues.EcoWgt, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("三、评价结果", 16, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft,0);
                wh.NewLine();
                wh.InsertText("3.1、有利区", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                wh.NewLine();
                if (strClass_1.Equals(null))
                {
                    MessageBox.Show("未对参数进行自然分类，所以分类评价结果为Null。","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    wh.InsertText("Null", 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                    wh.NewLine();
                    wh.InsertText("3.2、一般区", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                    wh.NewLine();
                    wh.InsertText("Null", 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                    wh.NewLine();
                    wh.InsertText("3.3、较差区", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                    wh.NewLine();
                    wh.InsertText("Null", 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                }
                else
                {
                    wh.InsertText(strClass_1.ToString(), 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                    wh.NewLine();
                    wh.InsertText("3.2、一般区", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                    wh.NewLine();
                    wh.InsertText(strClass_2.ToString(), 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                    wh.NewLine();
                    wh.InsertText("3.3、较差区", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                    wh.NewLine();
                    wh.InsertText(strClass_3.ToString(), 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                }
                wh.SaveWord(strFileName);
            }
            MessageBox.Show("报告已完成。", "信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            PublicValues.GEE_Wgt = null;
            PublicValues.GeoWgt = null;
            PublicValues.EngWgt = null;
            PublicValues.EcoWgt = null;
            PublicValues.GeoParas = null;
            PublicValues.EngParas = null;
            PublicValues.EcoParas = null;
            PublicValues.dgv_Geo = null;
            PublicValues.dgv_GEE = null;
            PublicValues.dgv_Eng = null;
            PublicValues.dgv_Eco = null;
        }
    }
}
