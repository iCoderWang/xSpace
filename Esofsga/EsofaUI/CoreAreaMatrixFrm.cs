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
    public partial class CoreAreaMatrixFrm : Form
    {
        public CoreAreaMatrixFrm()
        {
            InitializeComponent();
        }

        private List<AverageValuesTargetEntity> lst_Tgt;
        public CoreAreaMatrixFrm(List<AverageValuesTargetEntity> list)
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
        private void CoreAreaMatrixFrm_Load(object sender, EventArgs e)
        {
            //调用通用方法模块中的数据加载方法，将数组里的数据加载到datagridview的cell中
            ParametersWeightLoader paraWeightLoader = new ParametersWeightLoader();

            //创建DataTable变量，用于中间转载数据
            DataTable dt = new DataTable();

            //定义核心区区块(分层方法中的 第一层)参数的权重矩阵数据
            double [,] tgtAreaWeight_R1 = { {1,1,3 }, 
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

        #region
        /// <summary>
        /// 计算特征值和特征向量
        /// </summary>
        /// <param name="arr"></param>
        //private Vector<double> ArrayLoad(double [,] arr,out StringBuilder strB)
        //{
        //    double maxEigenValue;
        //     strB = new StringBuilder();
        //    //EigenValues eignFrm = new EigenValues();
        //    CoincidenceChecker cChecker = new CoincidenceChecker();
        //    Vector<double> eigenVector = cChecker.Caculate(arr, out maxEigenValue);
        //    Vector<double> normalizedVector = eigenVector.Normalize(1);
        //    double CR=cChecker.CrGenerate(maxEigenValue, arr);
        //    strB.Append("  ===============================================" + "\r\n");
        //    strB.Append("  Maximum Eigenvalue: " + maxEigenValue + "\r\n");
        //    strB.Append("  ===============================================" + "\r\n");
        //    strB.Append("  Maximum Eigenvalue's Eigenvector:\r\n" + eigenVector.ToString("#0.000000") + "\r\n");
        //    strB.Append("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + "\r\n");
        //    strB.Append("  Maximum Eigenvalue's Eigenvector:\r\n" + normalizedVector.ToString("#0.000000") + "\r\n" + "CR Value is: " + CR.ToString("#0.000") + "\r\n");
        //    strB.Append("  ******************************************" + "\r\n");
        //    return normalizedVector;
        //}
        #endregion
        /// <summary>
        /// 对矩阵进行一致性检验，主要是计算一致性比例CR = CI(一致性指标)/RI(平均随机一致性指标)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCoincidenceCheck_Click(object sender, EventArgs e)
        {
            //ArrayLoad(Rtest);
            //定义地质条件的权重变量
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

            //定义 工程条件的权重变量
            //依次：埋深、压力系数、渗透率、裂缝发育程度、主应力差、脆矿、水系、区域勘探程度
            double wgt_Ad;
            double wgt_Pc;
            double wgt_Per;
            double wgt_Fdd;
            double wgt_Psdf;
            double wgt_Bmc;
            double wgt_Ds;
            double wgt_Led;

            //定义经济条件的权重变量
            //依次：市场气价、市场需求、交通设施、管网条件、地表地貌
            double wgt_Gp;
            double wgt_Dmd;
            double wgt_Tu;
            double wgt_Pn;
            double wgt_Sg;

            CoincidenceChecker cc = new CoincidenceChecker();
            double tempTotalSocres = 0;
            //int counter = Main_Form.listBlockPara.Count;
            //
            SortedBlocksFrm sBf = new SortedBlocksFrm();
            EigenValues eignFrm = new EigenValues();
            StringBuilder strB = new StringBuilder();
           Vector<double> vR1 = cc.ArrayLoad(R1, out strB);
            eignFrm.textBox1.Text += "R1: \r\n"+strB.ToString() + "\r\n\r\n";
            Vector<double> vR21 = cc.ArrayLoad(R21, out strB) * vR1.ElementAt(0);
            eignFrm.textBox1.Text += "R21: \r\n" + strB.ToString() + "\r\n\r\n";
            Vector<double> vR22 = cc.ArrayLoad(R22, out strB) * vR1.ElementAt(1);
            eignFrm.textBox1.Text += "R22: \r\n" + strB.ToString() + "\r\n\r\n";
            Vector<double> vR23 = cc.ArrayLoad(R23, out strB) * vR1.ElementAt(2);
            eignFrm.textBox1.Text += "R23: \r\n" + strB.ToString() + "\r\n"+ vR21 + "\r\n" + vR22 + "\r\n" + vR23;

            //从地质条件的参数权重向量 vR21 中对应地对权重变量进行赋值
            wgt_StromAt = vR21[0];
            wgt_Toc = vR21[1];
            wgt_Kt = vR21[2];
            wgt_Ro = vR21[3];
            wgt_Ea = vR21[4];
            wgt_Gc = vR21[5];
            wgt_Rr = vR21[6];
            wgt_Por = vR21[7];
            wgt_Scd = vR21[8];
            wgt_Rfc = vR21[9];

            //从工程条件的参数权重向量中对应地对权重变量进行赋值
            wgt_Ad = vR22[0];
            wgt_Pc = vR22[1];
            wgt_Per = vR22[2];
            wgt_Fdd = vR22[3];
            wgt_Psdf = vR22[4];
            wgt_Bmc = vR22[5];
            wgt_Ds = vR22[6];
            wgt_Led = vR22[7];

            //从经济条件的参数权重向量中对应地对权重变量进行赋值
            wgt_Gp = vR23[0];
            wgt_Dmd = vR23[1];
            wgt_Tu = vR23[2];
            wgt_Pn = vR23[3];
            wgt_Sg = vR23[4];

            List<SortedBlocksParas> lst_SBP = BlockGrade(lst_Tgt);
            int counter = lst_SBP.Count;
            foreach (SortedBlocksParas sBp in lst_SBP)
            {
                //地质条件
                sBp.para_StromAtWeight = wgt_StromAt;
                tempTotalSocres += sBp.para_StromAtWeight * sBp.para_StromAtScores;

                sBp.para_TocWeight = wgt_Toc;
                tempTotalSocres += sBp.para_TocWeight * sBp.para_TocScores;

                sBp.para_RoWeight = wgt_Ro;
                tempTotalSocres += sBp.para_RoWeight * sBp.para_RoScores;

                sBp.para_EaWeight = wgt_Ea;
                tempTotalSocres += sBp.para_EaWeight * sBp.para_EaScores;

                sBp.para_GcWeight = wgt_Gc;
                tempTotalSocres += sBp.para_GcWeight * sBp.para_GcScores;

                sBp.para_RrWeight = wgt_Rr;
                tempTotalSocres += sBp.para_RrWeight * sBp.para_RrScores;

                sBp.para_PorWeight = wgt_Por;
                tempTotalSocres += sBp.para_PorWeight * sBp.para_PorScores;

                //工程条件
                sBp.para_DrWeight = wgt_Ad;
                tempTotalSocres += sBp.para_DrWeight * sBp.para_DrScores;

                sBp.para_PcWeight = wgt_Pc;
                tempTotalSocres += sBp.para_PcWeight * sBp.para_PcScores;

                sBp.para_PsdcWeight = wgt_Psdf;
                tempTotalSocres += sBp.para_PsdcWeight * sBp.para_PsdcScores;

                sBp.para_BmcWeight = wgt_Bmc;
                tempTotalSocres += sBp.para_BmcWeight * sBp.para_BmcScores;

                sBp.para_TotalScores = tempTotalSocres + sBp.para_PsScores+sBp.para_FddScores+sBp.para_ScScores;
                tempTotalSocres = 0;
            }
            lst_SBP.Sort((x, y) => x.para_TotalScores.CompareTo(y.para_TotalScores));
            foreach(SortedBlocksParas sBp in lst_SBP)
            {
                sBp.para_Rank = counter ;
                counter--;
            }
           //Main_Form.listBlockPara.Sort((x, y) => x.para_Rank.CompareTo(y.para_Rank));
            //sBf.dgv_Tgt_Sorted.DataSource = Main_Form.listBlockPara;
            eignFrm.Show();
            sBf.Show();

        }
        #region
        public List<SortedBlocksParas> BlockGrade(List<AverageValuesTargetEntity> list_AvTgt)
        {
            //定义模糊隶属函数的实例
            FuzzyMembershipFunction fMf = new FuzzyMembershipFunction();
            SubjectiveGrading sG = new SubjectiveGrading();
            List<SortedBlocksParas> list_Sbp = new List<SortedBlocksParas>();

            //定义赋值分数变量
            double gradeScore;

            //定义SortedBlocksParas Entity类变量
            
            SortedBlocksParas tmpSBP = new SortedBlocksParas();
            //定义数值变量
            double values;
            for (int i = 0; i < list_AvTgt.Count; i++)
            {
                //tmpSBP = new SortedBlocksParas();
                //区块名称 没有分值
                tmpSBP.para_Tgt = list_AvTgt[i].tgt_Att_Name;

                //盆地/区域名称 没有分值
                tmpSBP.para_Bsn = list_AvTgt[i].bsn_Att_Name;

                //主力层系 分值
                tmpSBP.para_Ps = list_AvTgt[i].tgt_Att_Ps;
                tmpSBP.para_PsScores = sG.Grade(list_AvTgt[i].tgt_Att_Ps);

                //保存条件 分值
                tmpSBP.para_Sc = list_AvTgt[i].tgt_Att_Para_Sc;
                tmpSBP.para_ScScores = sG.Grade(list_AvTgt[i].tgt_Att_Para_Sc);

                //地质资源量
                tmpSBP.para_Gr = list_AvTgt[i].tgt_Att_Para_Gr_Avg;
                tmpSBP.para_GrScores = 0;

                //地质条件

                #region
                //对富含有机质页岩厚度的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_TrRoms_Avg.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_TrRoms_Avg);
                    gradeScore = fMf.FuzzyLarge(1.6, 15, values);
                    tmpSBP.para_StromAt = list_AvTgt[i].tgt_Geo_Para_TrRoms_Avg;
                    tmpSBP.para_StromAtScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_StromAt = list_AvTgt[i].tgt_Geo_Para_TrRoms_Avg;
                    tmpSBP.para_StromAtScores = 0;
                }

                //对Toc 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Toc_Avg.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Toc_Avg);
                    gradeScore = fMf.FuzzyLarge(1.6, 2, values);
                    tmpSBP.para_Toc = list_AvTgt[i].tgt_Geo_Para_Toc_Avg;
                    tmpSBP.para_TocScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Toc = list_AvTgt[i].tgt_Geo_Para_Toc_Avg;
                    tmpSBP.para_TocScores = 0;
                }

                //对干酪根类型求值 干酪根类型没有赋值函数，没有完成该函数的条件
                if (list_AvTgt[i].tgt_Geo_Para_Kt.Trim() != "")
                {
                    string val = list_AvTgt[i].tgt_Geo_Para_Kt;
                    gradeScore = fMf.ToAssignForKerogenType(val);
                    tmpSBP.para_Kt = list_AvTgt[i].tgt_Geo_Para_Kt;
                    tmpSBP.para_KtScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Kt = list_AvTgt[i].tgt_Geo_Para_Kt;
                    tmpSBP.para_KtScores = 0;
                }

                //对Ro 的平均值进行高斯型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Ro_Avg.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Ro_Avg);
                    gradeScore = fMf.FuzzyGussian(values);
                    tmpSBP.para_Ro = list_AvTgt[i].tgt_Geo_Para_Ro_Avg;
                    tmpSBP.para_RoScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Ro = list_AvTgt[i].tgt_Geo_Para_Ro_Avg;
                    tmpSBP.para_RoScores = 0;
                }

                //对Ea 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Ea.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Ea);
                    gradeScore = fMf.FuzzyLarge(1.2, 200, values);
                    tmpSBP.para_Ea = list_AvTgt[i].tgt_Geo_Para_Ea;
                    tmpSBP.para_EaScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Ea = list_AvTgt[i].tgt_Geo_Para_Ea;
                    tmpSBP.para_EaScores = 0;
                }

                //对Gc 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Gc_Avg.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Gc_Avg.Trim());
                    gradeScore = fMf.FuzzyLarge(1.6, 2, values);
                    tmpSBP.para_Gc = list_AvTgt[i].tgt_Geo_Para_Gc_Avg.Trim();
                    tmpSBP.para_GcScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Gc = list_AvTgt[i].tgt_Geo_Para_Gc_Avg.Trim();
                    tmpSBP.para_GcScores = 0;
                }

                //对Rr 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Rr_Avg.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Rr_Avg.Trim());
                    gradeScore = fMf.FuzzyLarge(1, 0.5, values);
                    tmpSBP.para_Rr = list_AvTgt[i].tgt_Geo_Para_Rr_Avg.Trim();
                    tmpSBP.para_RrScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Rr = list_AvTgt[i].tgt_Geo_Para_Rr_Avg.Trim();
                    tmpSBP.para_RrScores = 0;
                }

                //对Por 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Geo_Para_Por_Avg.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Geo_Para_Por_Avg.Trim());
                    gradeScore = fMf.FuzzyLarge(1.2, 2, values);
                    tmpSBP.para_Por = list_AvTgt[i].tgt_Geo_Para_Por_Avg.Trim();
                    tmpSBP.para_PorScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Por = list_AvTgt[i].tgt_Geo_Para_Por_Avg.Trim();
                    tmpSBP.para_PorScores = 0;
                }

                //对构造复杂度Scd 求值
                if (list_AvTgt[i].tgt_Geo_Para_Scd.Trim() != "")
                {
                    string val = list_AvTgt[i].tgt_Geo_Para_Scd.Trim();
                    gradeScore = fMf.FuzzyRankScore(val);
                    tmpSBP.para_Scd = list_AvTgt[i].tgt_Geo_Para_Scd;
                    tmpSBP.para_ScdScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Scd = list_AvTgt[i].tgt_Geo_Para_Scd;
                    tmpSBP.para_ScdScores = 0;
                }

                //对顶底板岩性Rfc求值
                if (list_AvTgt[i].tgt_Geo_Para_Rfc.Trim() != "")
                {
                    string val = list_AvTgt[i].tgt_Geo_Para_Rfc.Trim();
                    gradeScore = fMf.FuzzyRankScore(val);
                    tmpSBP.para_Rfc = list_AvTgt[i].tgt_Geo_Para_Rfc;
                    tmpSBP.para_RfcScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Rfc = list_AvTgt[i].tgt_Geo_Para_Rfc;
                    tmpSBP.para_RfcScores = 0;
                }
                #endregion

                //工程条件
                #region
                //埋深先计算平均值，然后利用高斯型隶属函数赋分
                if (list_AvTgt[i].tgt_Eng_Para_Dr_Avg.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Dr_Avg.Trim());
                    gradeScore = fMf.FuzzyGussian(values);
                    tmpSBP.para_Dr = list_AvTgt[i].tgt_Eng_Para_Dr_Avg.Trim();
                    tmpSBP.para_DrScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Dr = list_AvTgt[i].tgt_Eng_Para_Dr_Avg.Trim();
                    tmpSBP.para_DrScores = 0;
                }

                //对Pc 压力系数 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    gradeScore = fMf.FuzzyLarge(6, 1, values);
                    tmpSBP.para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP.para_PcScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP.para_PcScores = 0;
                }

                //渗透率（对页岩气，没必要的一个参数)求值
                if (list_AvTgt[i].tgt_Eng_Para_Per.Trim() != "")
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP.para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP.para_PcScores = 0;
                }
                else
                {
                    tmpSBP.para_Per = list_AvTgt[i].tgt_Eng_Para_Per.Trim();
                    tmpSBP.para_PerScores = 0;
                }

                //裂缝发育度 分值
                if (list_AvTgt[i].tgt_Eng_Para_Fdd.Trim() != "")
                {
                    string val = list_AvTgt[i].tgt_Eng_Para_Fdd.Trim();
                    gradeScore = fMf.FuzzyRankScore(val);
                    tmpSBP.para_Fdd = list_AvTgt[i].tgt_Eng_Para_Fdd.Trim();
                    tmpSBP.para_FddScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Fdd = list_AvTgt[i].tgt_Eng_Para_Fdd.Trim();
                    tmpSBP.para_FddScores = 0;
                }

                //对Psdc 主应力差异 的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Eng_Para_Psdc_Avg.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Psdc_Avg.Trim());
                    gradeScore = fMf.FuzzySmall(2.15, 0.5, values);
                    tmpSBP.para_Psdc = list_AvTgt[i].tgt_Eng_Para_Psdc_Avg.Trim();
                    tmpSBP.para_PsdcScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Psdc = list_AvTgt[i].tgt_Eng_Para_Psdc_Avg.Trim();
                    tmpSBP.para_PsdcScores = 0;
                }

                //对Bmc  的平均值进行增大型隶属函数求值
                if (list_AvTgt[i].tgt_Eng_Para_Bmc_Avg.Trim() != "")
                {
                    values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Bmc_Avg.Trim());
                    gradeScore = fMf.FuzzyLarge(2.15, 30, values);
                    tmpSBP.para_Bmc = list_AvTgt[i].tgt_Eng_Para_Bmc_Avg.Trim();
                    tmpSBP.para_BmcScores = gradeScore;
                }
                else
                {
                    tmpSBP.para_Bmc = list_AvTgt[i].tgt_Eng_Para_Bmc_Avg.Trim();
                    tmpSBP.para_BmcScores = 0;
                }

                //水系求值
                if (list_AvTgt[i].tgt_Eng_Para_Ds.Trim() != "")
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP.para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP.para_DsScores = 0;
                }
                else
                {
                    tmpSBP.para_Ds = list_AvTgt[i].tgt_Eng_Para_Ds.Trim();
                    tmpSBP.para_DsScores = 0;
                }

                //区域勘探程度求值
                if (list_AvTgt[i].tgt_Eng_Para_Led.Trim() != "")
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP.para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP.para_LedScores = 0;
                }
                else
                {
                    tmpSBP.para_Led = list_AvTgt[i].tgt_Eng_Para_Led.Trim();
                    tmpSBP.para_LedScores = 0;
                }

                #endregion


                //市场经济条件

                #region
                //市场气价求值
                if (list_AvTgt[i].tgt_Mkt_Para_Gp.Trim() != "")
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP.para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP.para_GpScores = 0;
                }
                else
                {
                    tmpSBP.para_Gp = list_AvTgt[i].tgt_Mkt_Para_Gp.Trim();
                    tmpSBP.para_GpScores = 0;
                }

                //交通设施求值
                if (list_AvTgt[i].tgt_Mkt_Para_Tu.Trim() != "")
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP.para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP.para_TuScores = 0;
                }
                else
                {
                    tmpSBP.para_Tu = list_AvTgt[i].tgt_Mkt_Para_Tu.Trim();
                    tmpSBP.para_TuScores = 0;
                }

                //管网条件求值
                if (list_AvTgt[i].tgt_Mkt_Para_Pn.Trim() != "")
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP.para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP.para_PnScores = 0;
                }
                else
                {
                    tmpSBP.para_Pn = list_AvTgt[i].tgt_Mkt_Para_Pn.Trim();
                    tmpSBP.para_PnScores = 0;
                }

                //地表地貌求值
                if (list_AvTgt[i].tgt_Mkt_Para_Sg.Trim() != "")
                {
                    //values = Convert.ToDouble(list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP.para_Pc = list_AvTgt[i].tgt_Eng_Para_Pc_Avg.Trim();
                    tmpSBP.para_SgScores = 0;
                }
                else
                {
                    tmpSBP.para_Sg = list_AvTgt[i].tgt_Mkt_Para_Sg.Trim();
                    tmpSBP.para_SgScores = 0;
                }
                #endregion
                list_Sbp.Add(tmpSBP);
            }
            return list_Sbp;
        }
        #endregion

        private void btnPDF_Click(object sender, EventArgs e)
        {
            //PdfGeneratorFrm pdfG = new PdfGeneratorFrm();
            //pdfG.Generate("核心区");
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
            if (lstBx_All_GeoPara.SelectedIndex!=-1)
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
            if(lstBx_Selected_EngPara.SelectedIndex != -1)
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
