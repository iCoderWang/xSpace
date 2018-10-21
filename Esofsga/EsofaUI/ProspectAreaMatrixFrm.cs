using EsofaCommon;
using EsofaModel;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsofaUI
{
    public partial class ProspectAreaMatrixFrm : Form
    {
        public ProspectAreaMatrixFrm()
        {
            InitializeComponent();
        }
        private List<AverageValuesBasinEntity> lst_Bsn;
        public ProspectAreaMatrixFrm(List<AverageValuesBasinEntity> list)
        {
            InitializeComponent();
            lst_Bsn = list;
        }

        double[,] R1;
        double[,] R21;
        double[,] R22;
        /// <summary>
        /// 加载远景区参数矩阵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProspectAreaMatrixFrm_Load(object sender, EventArgs e)
        {
            //调用通用方法模块中的数据加载方法，将数组里的数据加载到datagridview的cell中
            ParametersWeightLoader paraWeightLoader = new ParametersWeightLoader();

            //创建DataTable变量，用于中间转载数据
            DataTable dt = new DataTable();

            //定义有利区区块(分层方法中的 第一层)参数的权重矩阵数据
            double[,] bsnAreaWeight_R1 = {  {1,3 },
                                                               {1/3.0,1} };
            R1 = bsnAreaWeight_R1;
            //定义有利区区块(分层方法中的 第二层)地质条件参数的权重矩阵数据
            double[,] bsnGeoWeight_R21 = { {1,3,7,3,3,1,1 },
                                                               {1/3.0,1,3,1,1,1/3.0,1/3.0 },
                                                               {1/7.0,1/3.0,1,1/3.0,1/3.0,1/7.0,1/7.0 },
                                                               {1/3.0,1,3,1,1,1/3.0,1/3.0 },
                                                               {1/3.0,1,3,1,1,1/3.0,1/3.0},
                                                               {1,3,7,3,3,1,1 },
                                                               {1,3,7,3,3,1,1 } };
            R21 = bsnGeoWeight_R21;

            ////定义有利区区块(分层方法中的 第二层)工程条件参数的权重矩阵数据
            double[,] bsnEngiWeight_R22 = { {1,1 },{1,1 } };
            R22 = bsnEngiWeight_R22;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(bsnAreaWeight_R1);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Bsn.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(bsnGeoWeight_R21);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Bsn_GeoPara.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(bsnEngiWeight_R22);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Bsn_EngPara.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            //dt = paraWeightLoader.ParaWeightLoad(blkEcoWeight_R23);

            //将DataTable数据类型变量赋值给dataGridView的源数据
           // this.dgv_Blk_EcoPara.DataSource = dt;
        }

        //定义地质条件的权重变量
        #region
        //依次：厚度、含量、干酪根类型、成熟度、面积、丰度、构造复杂度
        double wgt_StromAt;
        double wgt_Toc;
        double wgt_Kt;
        double wgt_Ro;
        double wgt_Ea;
        double wgt_Rr;
        double wgt_Scd;
        #endregion

        //定义 工程条件的权重变量
        #region
        //依次：埋深、压力系数、脆矿
        double wgt_Dr;
        double wgt_Bmc;
        #endregion
        
        bool chkFlag = false;
        /// <summary>
        ///  对矩阵进行一致性检验，主要是计算一致性比例CR = CI(一致性指标)/RI(平均随机一致性指标)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CoincidenceCheck_Click(object sender, EventArgs e)
        {
            CoincidenceChecker cc = new CoincidenceChecker();
            EigenValues eignFrm = new EigenValues();
            StringBuilder strB = new StringBuilder();
            StringBuilder cRstr = new StringBuilder();
            PublicValues.dgv_GEE = dgv_Bsn;
            PublicValues.dgv_Geo = dgv_Bsn_GeoPara;
            PublicValues.dgv_Eng = dgv_Bsn_EngPara;
            //PublicValues.dgv_Eco = dgv_Blk_EcoPara;
            string[] cR_arr = null;
            int flag = 0;
            string cR1 = null, cR21 = null, cR22 = null;// cR = null;
            Vector<double> vR1 = cc.ArrayLoad(R1, out strB, out cR1);
            eignFrm.textBox1.Text += "R1: \r\n" + strB.ToString() + "\r\n\r\n";
            foreach (double dbl in vR1)
            {
                if (dbl != vR1.Last())
                {
                    PublicValues.GEE_Wgt += dbl.ToString() + ",";
                }
                else
                {
                    PublicValues.GEE_Wgt += dbl.ToString() + ";";
                }
            }
            Vector<double> vR21 = cc.ArrayLoad(R21, out strB, out cR21) * vR1.ElementAt(0);
            eignFrm.textBox1.Text += "R21: \r\n" + strB.ToString() + "\r\n\r\n";
            foreach (double dbl in vR21)
            {
                if (dbl != vR21.Last())
                {
                    PublicValues.GeoWgt += dbl.ToString() + ",";
                }
                else
                {
                    PublicValues.GeoWgt += dbl.ToString() + ";";
                }
            }
            Vector<double> vR22 = cc.ArrayLoad(R22, out strB, out cR22) * vR1.ElementAt(1);
            eignFrm.textBox1.Text += "R22: \r\n" + strB.ToString() + "\r\n\r\n";
            foreach (double dbl in vR22)
            {
                if (dbl != vR22.Last())
                {
                    PublicValues.EngWgt += dbl.ToString() + ",";
                }
                else
                {
                    PublicValues.EngWgt += dbl.ToString() + ";";
                }
            }
            cR_arr = new string[] { cR1, cR21, cR22};
            eignFrm.textBox1.Text +=  vR21 + "\r\n" + vR22 + "\r\n" ;
            cRstr.Append("层次单排序结果一致性指标");
            foreach (string str in cR_arr)
            {
                if (Convert.ToDouble(str) >= 0.1)
                {
                    flag++;
                    if (flag == 1)
                    {
                        cRstr.Append(" : " + str);
                    }
                    else
                    {
                        cRstr.Append("," + str);
                    }
                }
            }
            if (flag != 0)
            {
                cRstr.Append(" 大于了 “0.1” 限差。排序结果一致性失败。是否查看详细信息？");
                flag = 0;
            }
            else
            {
                cRstr.Append("通过。是否查看详细信息？");

            }
            //从地质条件的参数权重向量 vR21 中对应地对权重变量进行赋值
            wgt_StromAt = Convert.ToDouble(vR21[0].ToString("0.0000"));
            wgt_Toc = Convert.ToDouble(vR21[1].ToString("0.0000"));
            wgt_Kt = Convert.ToDouble(vR21[2].ToString("0.0000"));
            wgt_Ro = Convert.ToDouble(vR21[3].ToString("0.0000"));
            wgt_Ea = Convert.ToDouble(vR21[4].ToString("0.0000"));
            wgt_Rr = Convert.ToDouble(vR21[5].ToString("0.0000"));
            wgt_Scd = Convert.ToDouble(vR21[6].ToString("0.0000"));

            //从工程条件的参数权重向量中对应地对权重变量进行赋值
            wgt_Dr = Convert.ToDouble(vR22[0].ToString("0.0000"));
            wgt_Bmc = Convert.ToDouble(vR22[1].ToString("0.0000"));
            DialogResult = MessageBox.Show(cRstr.ToString(), "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.Yes)
            {
                eignFrm.Show();
            }
            //eignFrm.Show();
            chkFlag = true;
            btn_Sort.Enabled = true;
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            double[] arr_Scores = null;
            string[] arr_TgtName = null;
            //SortedBasinsFrm sBf = new SortedBasinsFrm();
            int counterFlag = 0;
            //SortedTargetsFrm stf = new SortedTargetsFrm(arr);
            foreach (string str in lstBx_Selected_GeoPara.Items)
            {
                counterFlag++;
                if (counterFlag != lstBx_Selected_GeoPara.Items.Count)
                {
                    PublicValues.GeoParas += str + ",";
                }
                else
                {
                    PublicValues.GeoParas += str + ";";
                }
            }
            counterFlag = 0;
            foreach (string str in lstBx_Selected_EngPara.Items)
            {
                counterFlag++;
                if (counterFlag != lstBx_Selected_EngPara.Items.Count)
                {
                    PublicValues.EngParas += str + ",";
                }
                else
                {
                    PublicValues.EngParas += str + ";";
                }
            }
            if (chkFlag)
            {
                List<SortedBasinsParas> lst_SBP = BlockGrade(lst_Bsn);
                int counter = lst_SBP.Count;
                arr_Scores = new double[counter];
                arr_TgtName = new string[counter];
                lst_SBP.Sort((x, y) => x.para_TotalScores.CompareTo(y.para_TotalScores));
                foreach (SortedBasinsParas sBp in lst_SBP)
                {
                    sBp.para_Rank = counter;
                    counter--;
                }
                lst_SBP.Sort((x, y) => x.para_Rank.CompareTo(y.para_Rank));
                arr_Scores = lst_SBP.Select(x => x.para_TotalScores).ToArray();
                arr_TgtName = lst_SBP.Select(x => x.para_Tgt).ToArray();
                SortedBasinsFrm sBf = new SortedBasinsFrm(arr_Scores, arr_TgtName);
                sBf.dgv_Bsn_Sorted.DataSource = DataSourceToDataTable.GetListToDataTable(lst_SBP);
                sBf.Show();
                btn_GenerateReport.Enabled = true;
            }
            else
            {
                MessageBox.Show("尚未进行参数矩阵的检验计算操作，所有参数的权重值为 0 .", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 对数据进行评分加权赋值等操作
        /// </summary>
        /// <param name="list_AvBlk"></param>
        /// <returns></returns>
        #region
        public List<SortedBasinsParas> BlockGrade(List<AverageValuesBasinEntity> list_AvBsn)
        {
            //定义模糊隶属函数的实例
            FuzzyMembershipFunction fMf = new FuzzyMembershipFunction();
            SubjectiveGrading sG = new SubjectiveGrading();
            List<SortedBasinsParas> list_Sbp = new List<SortedBasinsParas>();

            //定义赋值分数变量
            double gradeScore;

            //定义SortedBlocksParas Entity类变量

            SortedBasinsParas[] tmpSBP = new SortedBasinsParas[list_AvBsn.Count];
            //定义数值变量
            double values;
            for (int i = 0; i < list_AvBsn.Count; i++)
            {
                tmpSBP[i] = new SortedBasinsParas();
                tmpSBP[i].para_TotalScores = 0;
                //区块名称 没有分值
                tmpSBP[i].para_Tgt = list_AvBsn[i].tgt_Att_Name;

                //盆地/区域名称 没有分值
                tmpSBP[i].para_Bsn = list_AvBsn[i].bsn_Att_Name;

                //主力层系 分值
                tmpSBP[i].para_Ps = list_AvBsn[i].bsn_Att_Ps;

                //保存条件 分值
                tmpSBP[i].para_Sc = list_AvBsn[i].bsn_Att_Para_Sc;

                //地质资源量 (赋值标准没有制定)
                tmpSBP[i].para_Gr = list_AvBsn[i].bsn_Att_Para_Gr;

                //地质条件

                #region
                //对富含有机质页岩厚度的平均值进行增大型隶属函数求值
                if (list_AvBsn[i].bsn_Geo_Para_TrRoms.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("页岩厚度(m)"))
                {
                    values = Convert.ToDouble(list_AvBsn[i].bsn_Geo_Para_TrRoms);
                    gradeScore = fMf.FuzzyLarge(1.6, 15, values);
                    tmpSBP[i].para_StromAt = list_AvBsn[i].bsn_Geo_Para_TrRoms;
                    tmpSBP[i].para_StromAtScores = gradeScore;
                    tmpSBP[i].para_StromAtWeight = wgt_StromAt;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_StromAtScores * tmpSBP[i].para_StromAtWeight;
                }
                else
                {
                    tmpSBP[i].para_StromAt = list_AvBsn[i].bsn_Geo_Para_TrRoms;
                    tmpSBP[i].para_StromAtScores = 0;
                    tmpSBP[i].para_StromAtWeight = wgt_StromAt;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Toc 的平均值进行增大型隶属函数求值
                if (list_AvBsn[i].bsn_Geo_Para_Toc.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("含量TOC(%)"))
                {
                    values = Convert.ToDouble(list_AvBsn[i].bsn_Geo_Para_Toc);
                    gradeScore = fMf.FuzzyLarge(1.6, 2, values);
                    tmpSBP[i].para_Toc = list_AvBsn[i].bsn_Geo_Para_Toc;
                    tmpSBP[i].para_TocScores = gradeScore;
                    tmpSBP[i].para_TocWeight = wgt_Toc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_TocScores * tmpSBP[i].para_TocWeight;
                }
                else
                {
                    tmpSBP[i].para_Toc = list_AvBsn[i].bsn_Geo_Para_Toc;
                    tmpSBP[i].para_TocScores = 0;
                    tmpSBP[i].para_TocWeight = wgt_Toc;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对干酪根类型求值 干酪根类型没有赋值函数，没有完成该函数的条件
                if (list_AvBsn[i].bsn_Geo_Para_Kt.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("干酪根类型"))
                {
                    string val = list_AvBsn[i].bsn_Geo_Para_Kt;
                    gradeScore = fMf.ToAssignForKerogenType(val);
                    tmpSBP[i].para_Kt = list_AvBsn[i].bsn_Geo_Para_Kt;
                    tmpSBP[i].para_KtScores = gradeScore;
                    tmpSBP[i].para_KtWeight = wgt_Kt;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_KtScores * tmpSBP[i].para_KtWeight;
                }
                else
                {
                    tmpSBP[i].para_Kt = list_AvBsn[i].bsn_Geo_Para_Kt;
                    tmpSBP[i].para_KtScores = 0;
                    tmpSBP[i].para_KtWeight = wgt_Kt;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Ro 的平均值进行高斯型隶属函数求值
                if (list_AvBsn[i].bsn_Geo_Para_Ro.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("成熟度Ro(%)"))
                {
                    values = Convert.ToDouble(list_AvBsn[i].bsn_Geo_Para_Ro);
                    gradeScore = fMf.FuzzyGussian(values);
                    tmpSBP[i].para_Ro = list_AvBsn[i].bsn_Geo_Para_Ro;
                    tmpSBP[i].para_RoScores = gradeScore;
                    tmpSBP[i].para_RoWeight = wgt_Ro;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_RoScores * tmpSBP[i].para_RoWeight;
                }
                else
                {
                    tmpSBP[i].para_Ro = list_AvBsn[i].bsn_Geo_Para_Ro;
                    tmpSBP[i].para_RoScores = 0;
                    tmpSBP[i].para_RoWeight = wgt_Ro;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Ea 的平均值进行增大型隶属函数求值
                if (list_AvBsn[i].bsn_Geo_Para_Ea.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("圈定面积(km^2)"))
                {
                    values = Convert.ToDouble(list_AvBsn[i].bsn_Geo_Para_Ea);
                    gradeScore = fMf.FuzzyLarge(1.2, 200, values);
                    tmpSBP[i].para_Ea = list_AvBsn[i].bsn_Geo_Para_Ea;
                    tmpSBP[i].para_EaScores = gradeScore;
                    tmpSBP[i].para_EaWeight = wgt_Ea;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_EaScores * tmpSBP[i].para_EaWeight;
                }
                else
                {
                    tmpSBP[i].para_Ea = list_AvBsn[i].bsn_Geo_Para_Ea;
                    tmpSBP[i].para_EaScores = 0;
                    tmpSBP[i].para_EaWeight = wgt_Ea;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Rr 的平均值进行增大型隶属函数求值
                if (list_AvBsn[i].bsn_Geo_Para_Rr.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("丰度(亿方/km^2)"))
                {
                    values = Convert.ToDouble(list_AvBsn[i].bsn_Geo_Para_Rr.Trim());
                    gradeScore = fMf.FuzzyLarge(1, 0.5, values);
                    tmpSBP[i].para_Rr = list_AvBsn[i].bsn_Geo_Para_Rr.Trim();
                    tmpSBP[i].para_RrScores = gradeScore;
                    tmpSBP[i].para_RrWeight = wgt_Rr;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_RrScores * tmpSBP[i].para_RrWeight;
                }
                else
                {
                    tmpSBP[i].para_Rr = list_AvBsn[i].bsn_Geo_Para_Rr.Trim();
                    tmpSBP[i].para_RrScores = 0;
                    tmpSBP[i].para_RrWeight = wgt_Rr;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对构造复杂度Scd 求值
                if (list_AvBsn[i].bsn_Geo_Para_Scd.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("构造复杂度"))
                {
                    string val = list_AvBsn[i].bsn_Geo_Para_Scd.Trim();
                    gradeScore = fMf.FuzzyRankScore(val);
                    tmpSBP[i].para_Scd = list_AvBsn[i].bsn_Geo_Para_Scd;
                    tmpSBP[i].para_ScdScores = gradeScore;
                    tmpSBP[i].para_ScdWeight = wgt_Scd;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_ScdScores * tmpSBP[i].para_ScdWeight;
                }
                else
                {
                    tmpSBP[i].para_Scd = list_AvBsn[i].bsn_Geo_Para_Scd;
                    tmpSBP[i].para_ScdScores = 0;
                    tmpSBP[i].para_ScdWeight = wgt_Scd;
                    tmpSBP[i].para_TotalScores += 0;
                }

                #endregion

                //工程条件
                #region
                //埋深 Dr Depth Range先计算平均值，然后利用高斯型隶属函数赋分
                if (list_AvBsn[i].bsn_Eng_Para_Dr.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("埋深(m)"))
                {
                    values = Convert.ToDouble(list_AvBsn[i].bsn_Eng_Para_Dr.Trim());
                    gradeScore = fMf.FuzzyGussian(values);
                    tmpSBP[i].para_Dr = list_AvBsn[i].bsn_Eng_Para_Dr.Trim();
                    tmpSBP[i].para_DrScores = gradeScore;
                    tmpSBP[i].para_DrWeight = wgt_Dr;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_DrScores * tmpSBP[i].para_DrWeight;
                }
                else
                {
                    tmpSBP[i].para_Dr = list_AvBsn[i].bsn_Eng_Para_Dr.Trim();
                    tmpSBP[i].para_DrScores = 0;
                    tmpSBP[i].para_DrWeight = wgt_Dr;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对脆矿 Bmc  的平均值进行增大型隶属函数求值
                if (list_AvBsn[i].bsn_Eng_Para_Bmc.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("脆性矿物含量(%)"))
                {
                    values = Convert.ToDouble(list_AvBsn[i].bsn_Eng_Para_Bmc.Trim());
                    gradeScore = fMf.FuzzyLarge(2.15, 30, values);
                    tmpSBP[i].para_Bmc = list_AvBsn[i].bsn_Eng_Para_Bmc.Trim();
                    tmpSBP[i].para_BmcScores = gradeScore;
                    tmpSBP[i].para_BmcWeight = wgt_Bmc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_BmcScores * tmpSBP[i].para_BmcWeight;
                }
                else
                {
                    tmpSBP[i].para_Bmc = list_AvBsn[i].bsn_Eng_Para_Bmc.Trim();
                    tmpSBP[i].para_BmcScores = 0;
                    tmpSBP[i].para_BmcWeight = wgt_Bmc;
                    tmpSBP[i].para_TotalScores += 0;
                }
                #endregion
                list_Sbp.Add(tmpSBP[i]);
            }
            return list_Sbp;
        }
        #endregion

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region
        private void btn_Geo_ToRight_Click(object sender, EventArgs e)
        {
            lstBx_Selected_GeoPara.Items.AddRange(lstBx_All_GeoPara.Items);
            lstBx_All_GeoPara.Items.Clear();
        }

        private void lstBx_All_GeoPara_DoubleClick(object sender, EventArgs e)
        {
            if (lstBx_All_GeoPara.SelectedIndex != -1)
            {
                lstBx_Selected_GeoPara.Items.Add(lstBx_All_GeoPara.SelectedItem);
                lstBx_All_GeoPara.Items.Remove(lstBx_All_GeoPara.SelectedItem);
            }
        }

        private void btn_Geo_ToLeft_Click(object sender, EventArgs e)
        {
            lstBx_All_GeoPara.Items.AddRange(lstBx_Selected_GeoPara.Items);
            lstBx_Selected_GeoPara.Items.Clear();
        }

        private void lstBx_Selected_GeoPara_DoubleClick(object sender, EventArgs e)
        {
            if (lstBx_Selected_GeoPara.SelectedIndex != -1)
            {
                lstBx_All_GeoPara.Items.Add(lstBx_Selected_GeoPara.SelectedItem);
                lstBx_Selected_GeoPara.Items.Remove(lstBx_Selected_GeoPara.SelectedItem);
            }
        }

        private void lstBx_All_EngPara_DoubleClick(object sender, EventArgs e)
        {
            if (lstBx_All_EngPara.SelectedIndex != -1)
            {
                lstBx_Selected_EngPara.Items.Add(lstBx_All_EngPara.SelectedItem);
                lstBx_All_EngPara.Items.Remove(lstBx_All_EngPara.SelectedItem);
            }
        }
        private void lstBx_Selected_EngPara_DoubleClick(object sender, EventArgs e)
        {
            if (lstBx_Selected_EngPara.SelectedIndex != -1)
            {
                lstBx_All_EngPara.Items.Add(lstBx_Selected_EngPara.SelectedItem);
                lstBx_Selected_EngPara.Items.Remove(lstBx_Selected_EngPara.SelectedItem);
            }
        }

        private void btn_Eng_ToRight_Click(object sender, EventArgs e)
        {
            lstBx_Selected_EngPara.Items.AddRange(lstBx_All_EngPara.Items);
            lstBx_All_EngPara.Items.Clear();
        }

        private void btn_Eng_ToLeft_Click(object sender, EventArgs e)
        {
            lstBx_All_EngPara.Items.AddRange(lstBx_Selected_EngPara.Items);

            lstBx_Selected_EngPara.Items.Clear();
        }

        private void lstBx_All_EcoPara_DoubleClick(object sender, EventArgs e)
        {
            if (lstBx_All_EcoPara.SelectedIndex != -1)
            {
                lstBx_Selected_EcoPara.Items.Add(lstBx_All_EcoPara.SelectedItem);
                lstBx_All_EcoPara.Items.Remove(lstBx_All_EcoPara.SelectedItem);
            }
        }

        private void lstBx_Selected_EcoPara_DoubleClick(object sender, EventArgs e)
        {
            if (lstBx_Selected_EcoPara.SelectedIndex != -1)
            {
                lstBx_All_EcoPara.Items.Add(lstBx_Selected_EcoPara.SelectedItem);
                lstBx_Selected_EcoPara.Items.Remove(lstBx_Selected_EcoPara.SelectedItem);
            }
        }

        private void btn_Eco_ToRight_Click(object sender, EventArgs e)
        {
            lstBx_Selected_EcoPara.Items.AddRange(lstBx_All_EcoPara.Items);
            lstBx_All_EcoPara.Items.Clear();
        }

        private void btn_Eco_ToLeft_Click(object sender, EventArgs e)
        {
            lstBx_All_EcoPara.Items.AddRange(lstBx_Selected_EcoPara.Items);
            lstBx_Selected_EcoPara.Items.Clear();
        }
        #endregion

    }
}
