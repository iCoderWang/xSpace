using EsofaCommon;
using EsofaModel;
using System;
using System.Collections.Generic;
using MyWord = Microsoft.Office.Interop.Word;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MyImage = System.Drawing.Imaging;
using System.Windows.Forms;

namespace EsofaUI
{
    public partial class SortedBasinsFrm : Form
    {

        #region 单例模式
        private static SortedBasinsFrm frm;
        private List<SortedBasinsParas> lst_SBP;
        private double[] arr_TotalScores;
        private string[] arr_TgtName;

        //构造函数
        private SortedBasinsFrm()
        {
            InitializeComponent();
        }

        private SortedBasinsFrm(List<SortedBasinsParas> list)
        {
            InitializeComponent();
            lst_SBP = list;
        }
     
        private SortedBasinsFrm(double[] scores, string[] names)
        {
            InitializeComponent();
            arr_TotalScores = scores;
            arr_TgtName = names;
        }

        public static SortedBasinsFrm CreateInstance()
        {
            if(frm == null || frm.IsDisposed)
            {
                frm = new SortedBasinsFrm();
            }
            return frm;
        }

        public static SortedBasinsFrm CreateInstance(List<SortedBasinsParas> list)
        {
            if(frm == null || frm.IsDisposed)
            {
                frm = new SortedBasinsFrm(list);
            }
            return frm;
        }

        public static SortedBasinsFrm CreateInstance(double[] scores, string[] names)
        {
            if(frm == null || frm.IsDisposed)
            {
                frm = new SortedBasinsFrm(scores, names);
            }
            return frm;
        }
        #endregion

        StringBuilder strClass_1 = new StringBuilder();
        StringBuilder strClass_2 = new StringBuilder();
        StringBuilder strClass_3 = new StringBuilder();
        private void ToolStripMenuItem_Classify_Click(object sender, EventArgs e)
        {
            //使用linq根据数组的index对某一个范围内的元素求和
            //double s1 = _arr.Where((num, index) => index > 1 && index <=3).Sum();f
            int s1 = 0, s2 = 0;
            NaturalBreaksClassification nbc = new NaturalBreaksClassification();
            //对排序结果进行分类，并返回出三类值中的第一类的数量和第3类的数量
            nbc.ToClassify(arr_TotalScores, out s1, out s2);
            for (int i = 0; i < arr_TgtName.Length; i++)
            {
                if (i < s1)
                {
                    dgv_Bsn_Sorted.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                if (i >= arr_TgtName.Length - s2)
                {
                    dgv_Bsn_Sorted.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;//.YellowGreen;
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
            ////将一类数据中目标区域名筛选出来
            //arr_TgtName.Where((num, index) => index >= 0 && index < s1).ToList().ForEach(a => strClass_1.Append(a + ", "));
            ////将二类数据中目标区域名筛选出来
            //arr_TgtName.Where((num, index) => index >= s1 && index < arr_TgtName.Length - s2).ToList().ForEach(a => strClass_2.Append(a + ", "));
            ////将三类数据中目标区域名筛选出来
            //arr_TgtName.Where((num, index) => index >= arr_TgtName.Length - s2 && index < arr_TgtName.Length).ToList().ForEach(a => strClass_3.Append(a + ", "));
            //MessageBox.Show("有利区：  " + strClass_1.ToString() + "; \r\n一般区：  " + strClass_2.ToString() +
            //    "; \r\n较差区：  " + strClass_3.ToString(), "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        private void ToolStripMenuItem_Generate_Click(object sender, EventArgs e)
        {
            WordHelper wh = new WordHelper();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word File|*.doc|(*.*)|*.*";
            sfd.Title = "保存文件";
            //sfd.ShowDialog();
            StringBuilder strBlocks = new StringBuilder();
            //***************************//
            double dbVal;
            List<double> wgtGeo = new List<double>();
            List<double> wgtEng = new List<double>();
            List<double> wgtEco = new List<double>();
            DrawGraph dgGeo = null;
            Bitmap bmGeo = null;
            string bmGeoPath = null;
            DrawGraph dgEng = null;
            Bitmap bmEng = null;
            string bmEngPath = null;
            //对地质参数用画图类的构造函数进行实例化
            if (PublicValues.ArrGeoParas.Length != 0)
            {
                foreach (string str in PublicValues.ArrGeoParas)
                {
                    PublicValues.DicGeoP_W.TryGetValue(str, out dbVal);
                    wgtGeo.Add(dbVal);
                }
                dgGeo = new DrawGraph(PublicValues.ArrGeoParas, wgtGeo.ToArray(), "参数", "权重值", "黑体", 180);
                bmGeo = dgGeo.DrawBarGraph();
                bmGeoPath = System.Windows.Forms.Application.StartupPath + "\\geoWgtBar.jpeg";
                bmGeo.Save(bmGeoPath, MyImage.ImageFormat.Jpeg);
            }


            //对工程参数用画图类的构造函数进行实例化
            if (PublicValues.ArrEngParas.Length != 0)
            {
                foreach (string str in PublicValues.ArrEngParas)
                {
                    PublicValues.DicEngP_W.TryGetValue(str, out dbVal);
                    wgtEng.Add(dbVal);
                }
                dgEng = new DrawGraph(PublicValues.ArrEngParas, wgtEng.ToArray(), "参数", "权重值", "黑体", 180);
                bmEng = dgEng.DrawBarGraph();
                bmEngPath = System.Windows.Forms.Application.StartupPath + "\\engWgtBar.jpeg";
                bmEng.Save(bmEngPath, MyImage.ImageFormat.Jpeg);
            }
            bool isOpen = false;
            bool flag = true;

            //**************************************************//



            foreach (string str in arr_TgtName)
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
            string strFileName = null;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                strFileName = sfd.FileName;
                wh.CreateWord(strFileName);
                wh.InsertText("页岩气选区评价结果分析", 18, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphCenter, 0);
                wh.NewLine();
                wh.InsertText("一、远景区参与评价区块", 16, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 0);
                wh.NewLine();
                wh.InsertText(strBlocks.ToString(), 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("二、层次分析法（AHP）评价参数、判断矩阵及权重", 16, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 0);
                wh.NewLine();
                wh.InsertText("2.1、地质因素", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                wh.NewLine();
                wh.InsertText("2.1.1、评价参数", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                if (PublicValues.ArrGeoParas.Length != 0)
                {
                    wh.InsertText(PublicValues.GeoParas, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                }
                else
                {
                    wh.InsertText("没有地质参数参与评价。", 10, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                }
                //wh.InsertText(PublicValues.GeoParas, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("2.1.2、判断矩阵", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                flag = wh.DGV2Word(PublicValues.dgv_Geo);
                if (flag == false)
                {
                    return;
                }
                //wh.NewLine();
                wh.InsertText("2.1.3、地质参数权重", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                if (PublicValues.ArrGeoParas.Length != 0)
                {
                    wh.InsertPicture(bmGeoPath);
                }
                else
                {
                    wh.InsertText("没有地质参数参与评价。", 10, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                }
                //wh.InsertText(PublicValues.GeoWgt, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("2.2、工程因素", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                wh.NewLine();
                wh.InsertText("2.2.1、评价参数", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                if (PublicValues.ArrEngParas.Length != 0)
                {
                    wh.InsertText(PublicValues.EngParas, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                }
                else
                {
                    wh.InsertText("没有工程参数参与评价。", 10, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                }
                //wh.InsertText(PublicValues.EngParas, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("2.2.2、判断矩阵", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                wh.DGV2Word(PublicValues.dgv_Eng);
                //wh.NewLine();
                wh.InsertText("2.2.3、工程参数权重", 14, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 25);
                wh.NewLine();
                if (PublicValues.ArrEngParas.Length != 0)
                {
                    wh.InsertPicture(bmEngPath);
                }
                else
                {
                    wh.InsertText("没有工程参数参与评价。", 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                }
                //wh.InsertText(PublicValues.EngWgt, 12, 0, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 30);
                wh.NewLine();
                wh.InsertText("三、评价结果", 16, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 0);
                wh.NewLine();
                wh.InsertText("3.1、有利区", 14, 1, "SimHei", MyWord.WdParagraphAlignment.wdAlignParagraphLeft, 20);
                wh.NewLine();
                if (strClass_1.Equals(null))
                {
                    MessageBox.Show("未对参数进行自然分类，所以分类评价结果为Null。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                isOpen = wh.SaveWord(strFileName);
                if (isOpen == false)
                {
                    return;
                }
            }
            DialogResult dr = MessageBox.Show("报告已完成，是否打开该报告？。", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                wh.OpenWordDoc(strFileName);
            }
            else
            {
                wh.QuitWordApp(strFileName);
            }
        }

        private void ToolStripMenuItem_SaveAsbyWeight_Click(object sender, EventArgs e)
        {
            string fileName = eh.DialogSaveExcel();
            bool flag = eh.Dgv2Excel(this.dgv_Bsn_Sorted, "权重", fileName);
            if (flag)
            {
                DialogResult dr = MessageBox.Show("数据另存已完成，是否打开？", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    eh.OpenExcel(fileName);
                }
                return;
            }
            else
            {
                MessageBox.Show("数据另存失败！");
                //eh.QuitExcelApp(fileName, k);
                return;
            }
        }
        ExcelHelper eh = new ExcelHelper();
        private void ToolStripMenuItem_SaveAsbyScores_Click(object sender, EventArgs e)
        {
            string fileName = eh.DialogSaveExcel();
            bool flag = eh.Dgv2Excel(this.dgv_Bsn_Sorted, "总分值", fileName);
            if (flag)
            {
                DialogResult dr = MessageBox.Show("数据另存已完成，是否打开？", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    eh.OpenExcel(fileName);
                }
                return;
            }
            else
            {
                MessageBox.Show("数据另存失败！");
                return;
            }
        }

        private void ToolStripMenuItem_SaveAs_Click(object sender, EventArgs e)
        {
            string fileName = eh.DialogSaveExcel();
            bool flag = eh.Dgv2Excel(this.dgv_Bsn_Sorted, fileName);
            if (flag)
            {
                DialogResult dr = MessageBox.Show("数据另存已完成，是否打开？", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    eh.OpenExcel(fileName);
                }
                return;
            }
            else
            {
                MessageBox.Show("数据另存失败！");
                //eh.QuitExcelApp(fileName, k);
                return;

            }
        }

        private void SortedBasinsFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }
    }
}
