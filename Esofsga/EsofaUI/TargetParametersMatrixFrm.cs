using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EsofaCommon;
using EsofaModel;
using MathNet.Numerics.LinearAlgebra;


namespace EsofaUI
{
    public partial class TargetParametersMatrixFrm : Form
    {
        public TargetParametersMatrixFrm()
        {
            InitializeComponent();
        }

        private List<AverageValuesTargetEntity> lst_Tgt;
        public TargetParametersMatrixFrm(List<AverageValuesTargetEntity> list)
        {
            InitializeComponent();
            lst_Tgt = list;
        }

        double[,] R1;
        double[,] R21;
        double[,] R22;
        double[,] R23;

        /// <summary>
        /// 加载核心区参数矩阵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///  private void TargetParametersMatrixFrm_Load(object sender, EventArgs e)

        private void TargetParametersMatrixFrm_Load(object sender, EventArgs e)
        {
            MatrixLoad();
        }

        private void MatrixLoad()
        {
            //调用通用方法模块中的数据加载方法，将数组里的数据加载到datagridview的cell中
            ParametersWeightLoader paraWeightLoader = new ParametersWeightLoader();

            //创建DataTable变量，用于中间转载数据
            DataTable dt = new DataTable();

            //定义核心区区块(分层方法中的 第一层)参数的权重矩阵数据
            double[,] tgtAreaWeight_R1 = { {1,1,3 },
                                                                {1,1,3 },
                                                                {1/3.0,1/3.0,1 } };
            R1 = tgtAreaWeight_R1;
            //R1 ={ {-1,1,0 },{ -4,3,0},{ 1,0,2} };

            //定义核心区区块(分层方法中的 第二层)地质条件参数的权重矩阵数据
            double[,] tgtGeoWeight_R21 = { {1,3,7,3,3,3,1,6,1,8 },
                                                                {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0,5 },
                                                                {1/7.0,1/3.0,1,1/3.0,1/3.0,1/3.0,1/7.0,1/1.5,1/7.0,2 },
                                                                {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0,5 },
                                                                {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0,5},
                                                                {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0,5 },
                                                                {1,3,7,3,3,3,1,6,1,8 },
                                                                {1/6.0,1/2.5,1.5,1/2.5,1/2.5,1/2.5,1/6.0,1,1/6.0,3},
                                                                {1,3,7,3,3,3,1,6,1,8 },
                                                                {1/8.0,1/5.0,1/2.0,1/5.0,1/5.0,1/5.0,1/8.0,1/3.0,1/8.0,1}};
            R21 = tgtGeoWeight_R21;
            ////定义核心区区块(分层方法中的 第二层)工程条件参数的权重矩阵数据
            double[,] tgtEngiWeight_R22 = { {1,3,3,8,6,1,6,9 },
                                                                {1/3.0,1,1,5,4,1/3.0,4,6 },
                                                                {1/3.0,1,1,5,4,1/3.0,4,6 },
                                                                {1/8.0,1/5.0,1/5.0,1,1/3.0,1/8.0,1/3.0,2 },
                                                                {1/6.0,1/6.0,1/4.0,3,1,1/6.0,1,5 },
                                                                {1,3,3,8,6,1,6,9  },
                                                                {1/6.0,1/6.0,1/4.0,3,1,1/6.0,1,5 },
                                                                {1/9.0,1/6.0,1/6.0,1/2.0,1/5.0,1/9.0,1/5.0,1 } };
            R22 = tgtEngiWeight_R22;
            ////定义核心区区块(分层方法中的 第二层)经济条件参数的权重矩阵数据
            double[,] tgtEcoWeight_R23 = { {1,1,3,3,1/3.0 },
                                                                {1,1,3,3,1/3.0 },
                                                                {1/3.0,1/3.0,1,1,1/6.0 },
                                                                {1/3.0,1/3.0,1,1,1/6.0 },
                                                                {3,3,6,6,1 } };
            R23 = tgtEcoWeight_R23;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(tgtAreaWeight_R1);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Tgt.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(tgtGeoWeight_R21);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Tgt_GeoPara.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(tgtEngiWeight_R22);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Tgt_EngPara.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(tgtEcoWeight_R23);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Tgt_EcoPara.DataSource = dt;
        }




        //定义地质条件的权重变量
        #region
        //依次：厚度、含量、干酪根类型、成熟度、面积、含气量、丰度、孔隙度、构造、顶底板岩性
        double wgt_StromAt;
        double wgt_Toc;
        double wgt_Kt;
        double wgt_Ro;
        double wgt_Ea;
        double wgt_Gc;
        double wgt_Rr;
        double wgt_Por;
        double wgt_Scd;
        double wgt_Rfc;
        #endregion

        //定义 工程条件的权重变量
        #region
        //依次：埋深、压力系数、渗透率、裂缝发育程度、主应力差、脆矿、水系、区域勘探程度
        double wgt_Dr;
        double wgt_Pc;
        double wgt_Per;
        double wgt_Fdd;
        double wgt_Psdc;
        double wgt_Bmc;
        double wgt_Ds;
        double wgt_Led;
        #endregion

        //定义经济条件的权重变量
        #region
        //依次：市场气价、市场需求、交通设施、管网条件、地表地貌
        double wgt_Gp;
        double wgt_Dmd;
        double wgt_Tu;
        double wgt_Pn;
        double wgt_Sg;
        bool chkFlag = false;
        #endregion

        /// <summary>
        /// 对矩阵进行一致性检验，主要是计算一致性比例CR = CI(一致性指标)/RI(平均随机一致性指标)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCoincidenceCheck_Click(object sender, EventArgs e)
        {
            CoincidenceChecker cc = new CoincidenceChecker();
            EigenValues eignFrm = new EigenValues();
            StringBuilder strB = new StringBuilder();
            double[,] dgv_R1 = DataSourceToDataTable.GetDgvToArray(this.dgv_Tgt);
            double[,] dgv_R21 = DataSourceToDataTable.GetDgvToArray(this.dgv_Tgt_GeoPara);
            double[,] dgv_R22 = DataSourceToDataTable.GetDgvToArray(this.dgv_Tgt_EngPara);
            double[,] dgv_R23 = DataSourceToDataTable.GetDgvToArray(this.dgv_Tgt_EcoPara);
            Vector<double> vR1 = cc.ArrayLoad(dgv_R1, out strB);
            eignFrm.textBox1.Text += "R1: \r\n" + strB.ToString() + "\r\n\r\n";
            Vector<double> vR21 = cc.ArrayLoad(dgv_R21, out strB) * vR1.ElementAt(0);
            eignFrm.textBox1.Text += "R21: \r\n" + strB.ToString() + "\r\n\r\n";
            Vector<double> vR22 = cc.ArrayLoad(dgv_R22, out strB) * vR1.ElementAt(1);
            eignFrm.textBox1.Text += "R22: \r\n" + strB.ToString() + "\r\n\r\n";
            Vector<double> vR23 = cc.ArrayLoad(dgv_R23, out strB) * vR1.ElementAt(2);
            eignFrm.textBox1.Text += "R23: \r\n" + strB.ToString() + "\r\n" + vR21 + "\r\n" + vR22 + "\r\n" + vR23;

            //从地质条件的参数权重向量 vR21 中对应地对权重变量进行赋值
            wgt_StromAt = Convert.ToDouble(vR21[0].ToString("0.###"));
            wgt_Toc = Convert.ToDouble(vR21[1].ToString("0.###"));
            wgt_Kt = Convert.ToDouble(vR21[2].ToString("0.###"));
            wgt_Ro = Convert.ToDouble(vR21[3].ToString("0.0000"));
            wgt_Ea = Convert.ToDouble(vR21[4].ToString("0.0000"));
            wgt_Gc = Convert.ToDouble(vR21[5].ToString("0.0000"));
            wgt_Rr = Convert.ToDouble(vR21[6].ToString("0.0000"));
            wgt_Por = Convert.ToDouble(vR21[7].ToString("0.0000"));
            wgt_Scd = Convert.ToDouble(vR21[8].ToString("0.0000"));
            wgt_Rfc = Convert.ToDouble(vR21[9].ToString("0.0000"));

            //从工程条件的参数权重向量中对应地对权重变量进行赋值
            wgt_Dr = Convert.ToDouble(vR22[0].ToString("0.0000"));
            wgt_Pc = Convert.ToDouble(vR22[1].ToString("0.0000"));
            wgt_Per = Convert.ToDouble(vR22[2].ToString("0.0000"));
            wgt_Fdd = Convert.ToDouble(vR22[3].ToString("0.0000"));
            wgt_Psdc = Convert.ToDouble(vR22[4].ToString("0.0000"));
            wgt_Bmc = Convert.ToDouble(vR22[5].ToString("0.0000"));
            wgt_Ds = Convert.ToDouble(vR22[6].ToString("0.0000"));
            wgt_Led = Convert.ToDouble(vR22[7].ToString("0.0000"));

            //从经济条件的参数权重向量中对应地对权重变量进行赋值
            wgt_Gp = Convert.ToDouble(vR23[0].ToString("0.0000"));
            wgt_Dmd = Convert.ToDouble(vR23[1].ToString("0.0000"));
            wgt_Tu = Convert.ToDouble(vR23[2].ToString("0.0000"));
            wgt_Pn = Convert.ToDouble(vR23[3].ToString("0.0000"));
            wgt_Sg = Convert.ToDouble(vR23[4].ToString("0.0000"));
            eignFrm.Show();
            #region
            //List<SortedBlocksParas> lst_SBP = BlockGrade(lst_Tgt);
            //int counter = lst_SBP.Count;
            //lst_SBP.Sort((x, y) => x.para_TotalScores.CompareTo(y.para_TotalScores));
            //foreach(SortedBlocksParas sBp in lst_SBP)
            //{
            //    sBp.para_Rank = counter ;
            //    counter--;
            //}
            //lst_SBP.Sort((x, y) => x.para_Rank.CompareTo(y.para_Rank));
            //sBf.dgv_Tgt_Sorted.DataSource = DataSourceToDataTable.GetListToDataTable(lst_SBP);
            //sBf.Show();
            #endregion
            chkFlag = true;
        }
        #region
        /// <summary>
        /// 对数据进行评分加权赋值等操作
        /// </summary>
        /// <param name="list_AvTgt"></param>
        /// <returns></returns>
        private List<SortedTargetsParas> BlockGrade(List<AverageValuesTargetEntity> list_AvTgt)
        {
            //定义模糊隶属函数的实例
            FuzzyMembershipFunction fMf = new FuzzyMembershipFunction();
            SubjectiveGrading sG = new SubjectiveGrading();
            List<SortedTargetsParas> list_Sbp = new List<SortedTargetsParas>();

            //定义赋值分数变量
            double gradeScore;

            //定义SortedBlocksParas Entity类变量

            SortedTargetsParas[] tmpSBP = new SortedTargetsParas[list_AvTgt.Count];
            //定义数值变量
            double values;
            for (int i = 0; i < list_AvTgt.Count; i++)
            {
                tmpSBP[i] = new SortedTargetsParas();
                tmpSBP[i].para_TotalScores = 0;
                //区块名称 没有分值
                tmpSBP[i].para_Tgt = list_AvTgt[i].tgt_Att_Name;

                //盆地/区域名称 没有分值
                tmpSBP[i].para_Bsn = list_AvTgt[i].bsn_Att_Name;

                //主力层系 分值
                tmpSBP[i].para_Ps = list_AvTgt[i].tgt_Att_Ps;
                //tmpSBP[i].para_PsScores = sG.Grade(list_AvTgt[i].tgt_Att_Ps);
                //tmpSBP[i].para_TotalScores += tmpSBP[i].para_PsScores;

                //保存条件 分值
                tmpSBP[i].para_Sc = list_AvTgt[i].tgt_Att_Para_Sc;
                //tmpSBP[i].para_ScScores = fMf.FuzzyRankScore(list_AvTgt[i].tgt_Att_Para_Sc);
                //tmpSBP[i].para_TotalScores += tmpSBP[i].para_ScScores;

                //地质资源量 (赋值标准没有制定)
                tmpSBP[i].para_Gr = list_AvTgt[i].tgt_Att_Para_Gr_Avg;
                //tmpSBP[i].para_GrScores = 0;
                //tmpSBP[i].para_TotalScores += tmpSBP[i].para_GrScores;

                //地质条件

                #region
                //对富含有机质页岩厚度的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_TrRoms_Avg.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("页岩厚度(m)"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_TrRoms_Avg);
                    gradeScore = fMf.FuzzyLarge(1.6, 15, values);
                    tmpSBP[i].para_StromAt = list_AvTgt[i].tgt_Geo_Para_TrRoms_Avg;
                    tmpSBP[i].para_StromAtScores = gradeScore;
                    tmpSBP[i].para_StromAtWeight = wgt_StromAt;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_StromAtScores * tmpSBP[i].para_StromAtWeight;
                }
                else
                {
                    tmpSBP[i].para_StromAt = list_AvTgt[i].tgt_Geo_Para_TrRoms_Avg;
                    tmpSBP[i].para_StromAtScores = 0;
                    tmpSBP[i].para_StromAtWeight = wgt_StromAt;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Toc 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Toc_Avg.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("含量TOC(%)"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Toc_Avg);
                    gradeScore = fMf.FuzzyLarge(1.6, 2, values);
                    tmpSBP[i].para_Toc = list_AvTgt[i].tgt_Geo_Para_Toc_Avg;
                    tmpSBP[i].para_TocScores = gradeScore;
                    tmpSBP[i].para_TocWeight = wgt_Toc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_TocScores * tmpSBP[i].para_TocWeight;
                }
                else
                {
                    tmpSBP[i].para_Toc = list_AvTgt[i].tgt_Geo_Para_Toc_Avg;
                    tmpSBP[i].para_TocScores = 0;
                    tmpSBP[i].para_TocWeight = wgt_Toc;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对干酪根类型求值 干酪根类型没有赋值函数，没有完成该函数的条件
                if (list_AvTgt[i].tgt_Geo_Para_Kt.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("干酪根类型"))
                {
                    string val = list_AvTgt[i].tgt_Geo_Para_Kt;
                    gradeScore = fMf.ToAssignForKerogenType(val);
                    tmpSBP[i].para_Kt = list_AvTgt[i].tgt_Geo_Para_Kt;
                    tmpSBP[i].para_KtScores = gradeScore;
                    tmpSBP[i].para_KtWeight = wgt_Kt;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_KtScores * tmpSBP[i].para_KtWeight;
                }
                else
                {
                    tmpSBP[i].para_Kt = list_AvTgt[i].tgt_Geo_Para_Kt;
                    tmpSBP[i].para_KtScores = 0;
                    tmpSBP[i].para_KtWeight = wgt_Kt;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Ro 的平均值进行高斯型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Ro_Avg.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("成熟度Ro(%)"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Ro_Avg);
                    gradeScore = fMf.FuzzyGussian(values);
                    tmpSBP[i].para_Ro = list_AvTgt[i].tgt_Geo_Para_Ro_Avg;
                    tmpSBP[i].para_RoScores = gradeScore;
                    tmpSBP[i].para_RoWeight = wgt_Ro;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_RoScores * tmpSBP[i].para_RoWeight;
                }
                else
                {
                    tmpSBP[i].para_Ro = list_AvTgt[i].tgt_Geo_Para_Ro_Avg;
                    tmpSBP[i].para_RoScores = 0;
                    tmpSBP[i].para_RoWeight = wgt_Ro;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Ea 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Ea.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("圈定面积(km^2)"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Ea);
                    gradeScore = fMf.FuzzyLarge(1.2, 200, values);
                    tmpSBP[i].para_Ea = list_AvTgt[i].tgt_Geo_Para_Ea;
                    tmpSBP[i].para_EaScores = gradeScore;
                    tmpSBP[i].para_EaWeight = wgt_Ea;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_EaScores * tmpSBP[i].para_EaWeight;
                }
                else
                {
                    tmpSBP[i].para_Ea = list_AvTgt[i].tgt_Geo_Para_Ea;
                    tmpSBP[i].para_EaScores = 0;
                    tmpSBP[i].para_EaWeight = wgt_Ea;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Gc 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Gc_Avg.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("含气量(m^3/t)"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Gc_Avg.Trim());
                    gradeScore = fMf.FuzzyLarge(1.6, 2, values);
                    tmpSBP[i].para_Gc = list_AvTgt[i].tgt_Geo_Para_Gc_Avg.Trim();
                    tmpSBP[i].para_GcScores = gradeScore;
                    tmpSBP[i].para_GcWeight = wgt_Gc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_GcScores * tmpSBP[i].para_GcWeight;
                }
                else
                {
                    tmpSBP[i].para_Gc = list_AvTgt[i].tgt_Geo_Para_Gc_Avg.Trim();
                    tmpSBP[i].para_GcScores = 0;
                    tmpSBP[i].para_GcWeight = wgt_Gc;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Rr 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Rr_Avg.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("丰度(亿方/km^2)"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Rr_Avg.Trim());
                    gradeScore = fMf.FuzzyLarge(1, 0.5, values);
                    tmpSBP[i].para_Rr = list_AvTgt[i].tgt_Geo_Para_Rr_Avg.Trim();
                    tmpSBP[i].para_RrScores = gradeScore;
                    tmpSBP[i].para_RrWeight = wgt_Rr;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_RrScores * tmpSBP[i].para_RrWeight;
                }
                else
                {
                    tmpSBP[i].para_Rr = list_AvTgt[i].tgt_Geo_Para_Rr_Avg.Trim();
                    tmpSBP[i].para_RrScores = 0;
                    tmpSBP[i].para_RrWeight = wgt_Rr;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Por 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Por_Avg.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("孔隙度(%)"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Por_Avg.Trim());
                    gradeScore = fMf.FuzzyLarge(1.2, 2, values);
                    tmpSBP[i].para_Por = list_AvTgt[i].tgt_Geo_Para_Por_Avg.Trim();
                    tmpSBP[i].para_PorScores = gradeScore;
                    tmpSBP[i].para_PorWeight = wgt_Por;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_PorScores * tmpSBP[i].para_PorWeight;
                }
                else
                {
                    tmpSBP[i].para_Por = list_AvTgt[i].tgt_Geo_Para_Por_Avg.Trim();
                    tmpSBP[i].para_PorScores = 0;
                    tmpSBP[i].para_PorWeight = wgt_Por;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对构造复杂度Scd 求值
                if (list_AvTgt[i].tgt_Geo_Para_Scd.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("构造复杂度"))
                {
                    string val = list_AvTgt[i].tgt_Geo_Para_Scd.Trim();
                    gradeScore = fMf.FuzzyRankScore(val);
                    tmpSBP[i].para_Scd = list_AvTgt[i].tgt_Geo_Para_Scd;
                    tmpSBP[i].para_ScdScores = gradeScore;
                    tmpSBP[i].para_ScdWeight = wgt_Scd;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_ScdScores * tmpSBP[i].para_ScdWeight;
                }
                else
                {
                    tmpSBP[i].para_Scd = list_AvTgt[i].tgt_Geo_Para_Scd;
                    tmpSBP[i].para_ScdScores = 0;
                    tmpSBP[i].para_ScdWeight = wgt_Scd;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对顶底板岩性Rfc求值
                if (list_AvTgt[i].tgt_Geo_Para_Rfc.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("顶底板岩性"))
                {
                    string val = list_AvTgt[i].tgt_Geo_Para_Rfc.Trim();
                    gradeScore = fMf.FuzzyRankScore(val);
                    tmpSBP[i].para_Rfc = list_AvTgt[i].tgt_Geo_Para_Rfc;
                    tmpSBP[i].para_RfcScores = gradeScore;
                    tmpSBP[i].para_RfcWeight = wgt_Rfc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_RfcScores * tmpSBP[i].para_RfcWeight;
                }
                else
                {
                    tmpSBP[i].para_Rfc = list_AvTgt[i].tgt_Geo_Para_Rfc;
                    tmpSBP[i].para_RfcScores = 0;
                    tmpSBP[i].para_RfcWeight = wgt_Rfc;
                    tmpSBP[i].para_TotalScores += 0;
                }
                #endregion

                //工程条件
                #region
                //埋深 Dr Depth Range先计算平均值，然后利用高斯型隶属函数赋分
                if (list_AvTgt[i].tgt_Eng_Para_Dr_Avg.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("埋深(m)"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Dr_Avg.Trim());
                    gradeScore = fMf.FuzzyGussian(values);
                    tmpSBP[i].para_Dr = list_AvTgt[i].tgt_Eng_Para_Dr_Avg.Trim();
                    tmpSBP[i].para_DrScores = gradeScore;
                    tmpSBP[i].para_DrWeight = wgt_Dr;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_DrScores * tmpSBP[i].para_DrWeight;
                }
                else
                {
                    tmpSBP[i].para_Dr = list_AvTgt[i].tgt_Eng_Para_Dr_Avg.Trim();
                    tmpSBP[i].para_DrScores = 0;
                    tmpSBP[i].para_DrWeight = wgt_Dr;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Pc 压力系数 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("压力系数"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    gradeScore = fMf.FuzzyLarge(6, 1, values);
                    tmpSBP[i].para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP[i].para_PcScores = gradeScore;
                    tmpSBP[i].para_PcWeight = wgt_Pc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_PcScores * tmpSBP[i].para_PcWeight;
                }
                else
                {
                    tmpSBP[i].para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP[i].para_PcScores = 0;
                    tmpSBP[i].para_PcWeight = wgt_Pc;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //渗透率（对页岩气，没必要的一个参数)求值
                if (list_AvTgt[i].tgt_Eng_Para_Per.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("渗透率(mD)"))
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP[i].para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP[i].para_PerScores = 0;
                    tmpSBP[i].para_PerWeight = wgt_Per;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_PerScores * tmpSBP[i].para_PerWeight;
                }
                else
                {
                    tmpSBP[i].para_Per = list_AvTgt[i].tgt_Eng_Para_Per.Trim();
                    tmpSBP[i].para_PerScores = 0;
                    tmpSBP[i].para_PerWeight = wgt_Per;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //裂缝发育度 分值
                if (list_AvTgt[i].tgt_Eng_Para_Fdd.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("裂缝发育程度"))
                {
                    string val = list_AvTgt[i].tgt_Eng_Para_Fdd.Trim();
                    gradeScore = fMf.FuzzyRankScore(val);
                    tmpSBP[i].para_Fdd = list_AvTgt[i].tgt_Eng_Para_Fdd.Trim();
                    tmpSBP[i].para_FddScores = gradeScore;
                    tmpSBP[i].para_FddWeight = wgt_Fdd;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_FddScores * tmpSBP[i].para_FddWeight;
                }
                else
                {
                    tmpSBP[i].para_Fdd = list_AvTgt[i].tgt_Eng_Para_Fdd.Trim();
                    tmpSBP[i].para_FddScores = 0;
                    tmpSBP[i].para_FddWeight = wgt_Fdd;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Psdc 主应力差异 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Eng_Para_Psdc_Avg.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("主应力差异系数"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Psdc_Avg.Trim());
                    gradeScore = fMf.FuzzySmall(2.15, 0.5, values);
                    tmpSBP[i].para_Psdc = list_AvTgt[i].tgt_Eng_Para_Psdc_Avg.Trim();
                    tmpSBP[i].para_PsdcScores = gradeScore;
                    tmpSBP[i].para_PsdcWeight = wgt_Psdc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_PsdcScores * tmpSBP[i].para_PsdcWeight;
                }
                else
                {
                    tmpSBP[i].para_Psdc = list_AvTgt[i].tgt_Eng_Para_Psdc_Avg.Trim();
                    tmpSBP[i].para_PsdcScores = 0;
                    tmpSBP[i].para_PsdcWeight = wgt_Psdc;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Bmc  的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Eng_Para_Bmc_Avg.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("脆性矿物含量(%)"))
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Bmc_Avg.Trim());
                    gradeScore = fMf.FuzzyLarge(2.15, 30, values);
                    tmpSBP[i].para_Bmc = list_AvTgt[i].tgt_Eng_Para_Bmc_Avg.Trim();
                    tmpSBP[i].para_BmcScores = gradeScore;
                    tmpSBP[i].para_BmcWeight = wgt_Bmc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_BmcScores * tmpSBP[i].para_BmcWeight;
                }
                else
                {
                    tmpSBP[i].para_Bmc = list_AvTgt[i].tgt_Eng_Para_Bmc_Avg.Trim();
                    tmpSBP[i].para_BmcScores = 0;
                    tmpSBP[i].para_BmcWeight = wgt_Bmc;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //水系求值
                if (list_AvTgt[i].tgt_Eng_Para_Ds.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("水系"))
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP[i].para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP[i].para_DsScores = 0;
                    tmpSBP[i].para_DsWeight = wgt_Ds;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_DsScores * tmpSBP[i].para_DsWeight;
                }
                else
                {
                    tmpSBP[i].para_Ds = list_AvTgt[i].tgt_Eng_Para_Ds.Trim();
                    tmpSBP[i].para_DsScores = 0;
                    tmpSBP[i].para_DsWeight = wgt_Ds;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //区域勘探程度求值
                if (list_AvTgt[i].tgt_Eng_Para_Led.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("区域勘探程度"))
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP[i].para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP[i].para_LedScores = 0;
                    tmpSBP[i].para_LedWeight = wgt_Led;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_LedScores * tmpSBP[i].para_LedWeight;
                }
                else
                {
                    tmpSBP[i].para_Led = list_AvTgt[i].tgt_Eng_Para_Led.Trim();
                    tmpSBP[i].para_LedScores = 0;
                    tmpSBP[i].para_LedWeight = wgt_Led;
                    tmpSBP[i].para_TotalScores += 0;
                }

                #endregion


                //市场经济条件

                #region
                //市场气价求值
                if (list_AvTgt[i].tgt_Mkt_Para_Gp.Trim() != ""
                    && lstBx_Selected_EcoPara.Items.Contains("市场气价"))
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP[i].para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP[i].para_GpScores = 0;
                    tmpSBP[i].para_GpWeight = wgt_Gp;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_GpScores * tmpSBP[i].para_GpWeight;
                }
                else
                {
                    tmpSBP[i].para_Gp = list_AvTgt[i].tgt_Mkt_Para_Gp.Trim();
                    tmpSBP[i].para_GpScores = 0;
                    tmpSBP[i].para_GpWeight = wgt_Gp;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //市场需求求值
                if (list_AvTgt[i].tgt_Mkt_Para_Dmd.Trim() != ""
                    && lstBx_Selected_EcoPara.Items.Contains("市场需求"))
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP[i].para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP[i].para_DmdScores = 0;
                    tmpSBP[i].para_DmdWeight = wgt_Dmd;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_DmdScores * tmpSBP[i].para_DmdWeight;
                }
                else
                {
                    tmpSBP[i].para_Dmd = list_AvTgt[i].tgt_Mkt_Para_Dmd.Trim();
                    tmpSBP[i].para_DmdScores = 0;
                    tmpSBP[i].para_DmdWeight = wgt_Dmd;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //交通设施求值
                if (list_AvTgt[i].tgt_Mkt_Para_Tu.Trim() != ""
                    && lstBx_Selected_EcoPara.Items.Contains("交通设施"))
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP[i].para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP[i].para_TuScores = 0;
                    tmpSBP[i].para_TuWeight = wgt_Tu;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_TuScores * tmpSBP[i].para_TuWeight;
                }
                else
                {
                    tmpSBP[i].para_Tu = list_AvTgt[i].tgt_Mkt_Para_Tu.Trim();
                    tmpSBP[i].para_TuScores = 0;
                    tmpSBP[i].para_TuWeight = wgt_Tu;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //管网条件求值
                if (list_AvTgt[i].tgt_Mkt_Para_Pn.Trim() != ""
                    && lstBx_Selected_EcoPara.Items.Contains("管网条件"))
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP[i].para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP[i].para_PnScores = 0;
                    tmpSBP[i].para_PnWeight = wgt_Pn;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_PnScores * tmpSBP[i].para_PnWeight;
                }
                else
                {
                    tmpSBP[i].para_Pn = list_AvTgt[i].tgt_Mkt_Para_Pn.Trim();
                    tmpSBP[i].para_PnScores = 0;
                    tmpSBP[i].para_PnWeight = wgt_Pn;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //地表地貌求值
                if (list_AvTgt[i].tgt_Mkt_Para_Sg.Trim() != ""
                    && lstBx_Selected_EcoPara.Items.Contains("地表地貌"))
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP[i].para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP[i].para_SgScores = 0;
                    tmpSBP[i].para_SgWeight = wgt_Sg;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_SgScores * tmpSBP[i].para_SgWeight;
                }
                else
                {
                    tmpSBP[i].para_Sg = list_AvTgt[i].tgt_Mkt_Para_Sg.Trim();
                    tmpSBP[i].para_SgScores = 0;
                    tmpSBP[i].para_SgWeight = wgt_Sg;
                    tmpSBP[i].para_TotalScores += 0;
                }
                #endregion
                list_Sbp.Add(tmpSBP[i]);
            }
            return list_Sbp;
        }
        #endregion

        /// <summary>
        /// 对计算结果进行排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            double[] arr_Scores = null;
            string[] arr_TgtName = null;
            //SortedTargetsFrm stf = new SortedTargetsFrm(arr);
            if (chkFlag)
            {
                List<SortedTargetsParas> lst_STP = BlockGrade(lst_Tgt);
                List<TopsisTargetDecisionMatrixEntity> lst_TTDME = new List<TopsisTargetDecisionMatrixEntity>();
                foreach (SortedTargetsParas var in lst_STP)
                {
                    lst_TTDME.Add(new TopsisTargetDecisionMatrixEntity
                    {
                        //序号
                        para_Rank = var.para_Rank,
                        //区块名称
                        para_Tgt = var.para_Tgt,
                        //地质参数得分
                        para_StromAtScores = var.para_StromAtScores,
                        para_TocScores = var.para_TocScores,
                        para_KtScores = var.para_KtScores,
                        para_RoScores = var.para_RoScores,
                        para_EaScores = var.para_EaScores,
                        para_GcScores = var.para_GcScores,
                        para_RrScores = var.para_RrScores,
                        para_PorScores = var.para_PorScores,
                        para_ScdScores = var.para_ScdScores,
                        para_RfcScores = var.para_RfcScores,
                        //工程参数得分
                        para_DrScores = var.para_DrScores,
                        para_PcScores = var.para_PcScores,
                        para_PerScores = var.para_PerScores,
                        para_FddScores = var.para_FddScores,
                        para_PsdcScores = var.para_PsdcScores,
                        para_BmcScores = var.para_BmcScores,
                        para_DsScores = var.para_DsScores,
                        para_LedScores = var.para_LedScores,
                        //市场参数得分
                        para_GpScores = var.para_GpScores,
                        para_DmdScores = var.para_DmdScores,
                        para_TuScores = var.para_TuScores,
                        para_PnScores = var.para_PnScores,
                        para_SgScores = var.para_SgScores
                    });
                }
                int counter = lst_STP.Count;
                arr_Scores = new double[counter];
                arr_TgtName = new string[counter];
                lst_STP.Sort((x, y) => x.para_TotalScores.CompareTo(y.para_TotalScores));
                foreach (SortedTargetsParas sBp in lst_STP)
                {
                    sBp.para_Rank = counter;
                    counter--;
                }
                lst_STP.Sort((x, y) => x.para_Rank.CompareTo(y.para_Rank));
                arr_Scores = lst_STP.Select(x => x.para_TotalScores).ToArray();
                arr_TgtName = lst_STP.Select(x => x.para_Tgt).ToArray();
                //SortedTargetsFrm stf = new SortedTargetsFrm(arr_Scores, arr_TgtName);
                //stf.dgv_Tgt_Sorted.DataSource = DataSourceToDataTable.GetListToDataTable(lst_STP);
                //stf.Show();
                //btn_GenerateReport.Enabled = true;
                TOPSISDecisionMatrixFrm tdm = new TOPSISDecisionMatrixFrm();
                //tdm.dgv_DecisionMatrix.DataSource = ;
                tdm.Show();
            }
            else
            {
                MessageBox.Show("尚未进行参数矩阵的检验计算操作，所有参数的权重值为 0 .", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            PDFCreator pdfCreator = new PDFCreator();
            pdfCreator.Create("核心区");
        }

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

        private void btn_DefaultMatrix_Click(object sender, EventArgs e)
        {
            MatrixLoad();
            this.dgv_Tgt.ReadOnly = true;
            this.dgv_Tgt_EcoPara.ReadOnly = true;
            this.dgv_Tgt_EngPara.ReadOnly = true;
            this.dgv_Tgt_GeoPara.ReadOnly = true;
        }

        private void btn_CustomedMatrix_Click(object sender, EventArgs e)
        {
            this.dgv_Tgt.ReadOnly = false;
            this.dgv_Tgt_EcoPara.ReadOnly = false;
            this.dgv_Tgt_EngPara.ReadOnly = false;
            this.dgv_Tgt_GeoPara.ReadOnly = false;
        }
    }
}
