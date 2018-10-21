using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsofaCommon;
using EsofaModel;
using MathNet.Numerics.LinearAlgebra;

namespace EsofaUI
{
    public partial class FavorableAreaMatrixFrm : Form
    {
        public FavorableAreaMatrixFrm()
        {
            InitializeComponent();
        }
        private List<AverageValuesBlockEntity> lst_Blk;
        public FavorableAreaMatrixFrm(List<AverageValuesBlockEntity> list)
        {
            InitializeComponent();
            lst_Blk = list;
        }

        double[,] R1;
        double[,] R21;
        double[,] R22;
        double[,] R23;
        /// <summary>
        /// 加载有利区参数矩阵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FavorableAreaMatrixFrm_Load(object sender, EventArgs e)
        {
            //调用通用方法模块中的数据加载方法，将数组里的数据加载到datagridview的cell中
            ParametersWeightLoader paraWeightLoader = new ParametersWeightLoader();

            //创建DataTable变量，用于中间转载数据
            DataTable dt = new DataTable();

            //定义有利区区块(分层方法中的 第一层)参数的权重矩阵数据
            double[,] blkAreaWeight_R1 = {  {1,3,7 },
                                                               {1/3.0,1,5 },
                                                               {1/7.0,1/5.0,1 } };
            R1 = blkAreaWeight_R1;
            //定义有利区区块(分层方法中的 第二层)地质条件参数的权重矩阵数据
            double[,] blkGeoWeight_R21 = { {1,3,7,3,3,3,1,6,1 },
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0 },
                                                               {1/7.0,1/3.0,1,1/3.0,1/3.0,1/3.0,1/7.0,1/1.5,1/7.0 },
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0 },
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0},
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0 },
                                                               {1,3,7,3,3,3,1,6,1 },
                                                               {1/6.0,1/2.5,1.5,1/2.5,1/2.5,1/2.5,1/6.0,1,1/6.0 },
                                                               {1,3,7,3,3,3,1,6,1 } };
            R21 = blkGeoWeight_R21;

            ////定义有利区区块(分层方法中的 第二层)工程条件参数的权重矩阵数据
            double[,] blkEngiWeight_R22 = { {1,7,1 },
                                                               {1/7.0,1,1/7.0 },
                                                               {1,7,1 } };
            R22 = blkEngiWeight_R22;
            ////定义核心区区块(分层方法中的 第二层)经济条件参数的权重矩阵数据
            double[,] blkEcoWeight_R23 = { {7 } };
            R23 = blkEcoWeight_R23;
            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(blkAreaWeight_R1);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Blk.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(blkGeoWeight_R21);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Blk_GeoPara.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(blkEngiWeight_R22);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Blk_EngPara.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(blkEcoWeight_R23);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dgv_Blk_EcoPara.DataSource = dt;
        }
       
        //定义地质条件的权重变量
        #region
        //依次：厚度、含量、干酪根类型、成熟度、面积、含气量、丰度、孔隙度、构造复杂度
        double wgt_StromAt;
        double wgt_Toc;
        double wgt_Kt;
        double wgt_Ro;
        double wgt_Ea;
        double wgt_Gc;
        double wgt_Rr;
        double wgt_Por;
        double wgt_Scd;
        #endregion

        //定义 工程条件的权重变量
        #region
        //依次：埋深、压力系数、脆矿
        double wgt_Dr;
        double wgt_Pc;
        double wgt_Bmc;
        #endregion

        //定义经济条件的权重变量
        #region
        //依次：地表地貌
        double wgt_Sg;
        bool chkFlag = false;
        #endregion

        /// <summary>
        /// 对矩阵进行一致性检验，主要是计算一致性比例CR = CI(一致性指标)/RI(平均随机一致性指标)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CoincidenceCheck_Click(object sender, EventArgs e)
        {
            CoincidenceChecker cc = new CoincidenceChecker();
            EigenValues eignFrm = new EigenValues();
            StringBuilder strB = new StringBuilder();
            StringBuilder cRstr = new StringBuilder();
            PublicValues.dgv_GEE = dgv_Blk;
            PublicValues.dgv_Geo = dgv_Blk_GeoPara;
            PublicValues.dgv_Eng = dgv_Blk_EngPara;
            PublicValues.dgv_Eco = dgv_Blk_EcoPara;
            string[] cR_arr = null;
            int flag = 0;
            string cR1 = null, cR21 = null, cR22 = null, cR23 = null;// cR = null;
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
            Vector<double> vR23 = cc.ArrayLoad(R23, out strB, out cR23) * vR1.ElementAt(2);
            cR_arr = new string[] { cR1, cR21, cR22, cR23 };
            eignFrm.textBox1.Text += "R23: \r\n" + strB.ToString() + "\r\n" + vR21 + "\r\n" + vR22 + "\r\n" + vR23;
            foreach (double dbl in vR23)
            {
                if (dbl != vR23.Last())
                {
                    PublicValues.EcoWgt += dbl.ToString() + ",";
                }
                else
                {
                    PublicValues.EcoWgt += dbl.ToString() + ";";
                }
            }
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
            wgt_Gc = Convert.ToDouble(vR21[5].ToString("0.0000"));
            wgt_Rr = Convert.ToDouble(vR21[6].ToString("0.0000"));
            wgt_Por = Convert.ToDouble(vR21[7].ToString("0.0000"));
            wgt_Scd = Convert.ToDouble(vR21[8].ToString("0.0000"));

            //从工程条件的参数权重向量中对应地对权重变量进行赋值
            wgt_Dr = Convert.ToDouble(vR22[0].ToString("0.0000"));
            wgt_Pc = Convert.ToDouble(vR22[1].ToString("0.0000"));
            wgt_Bmc = Convert.ToDouble(vR22[2].ToString("0.0000"));

            //从经济条件的参数权重向量中对应地对权重变量进行赋值
            wgt_Sg = Convert.ToDouble(vR23[0].ToString("0.0000"));
            DialogResult = MessageBox.Show(cRstr.ToString(), "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.Yes)
            {
                eignFrm.Show();
            }
            //eignFrm.Show();
            chkFlag = true;
            btn_Sort.Enabled = true;
        }


        /// <summary>
        /// 对数据进行评分加权赋值等操作
        /// </summary>
        /// <param name="list_AvBlk"></param>
        /// <returns></returns>
        #region
        public List<SortedBlocksParas> BlockGrade(List<AverageValuesBlockEntity> list_AvBlk)
        {
            //定义模糊隶属函数的实例
            FuzzyMembershipFunction fMf = new FuzzyMembershipFunction();
            SubjectiveGrading sG = new SubjectiveGrading();
            List<SortedBlocksParas> list_Sbp = new List<SortedBlocksParas>();

            //定义赋值分数变量
            double gradeScore;

            //定义SortedBlocksParas Entity类变量

            SortedBlocksParas[] tmpSBP = new SortedBlocksParas[list_AvBlk.Count];
            //定义数值变量
            double values;
            for (int i = 0; i < list_AvBlk.Count; i++)
            {
                tmpSBP[i] = new SortedBlocksParas();
                tmpSBP[i].para_TotalScores = 0;
                //区块名称 没有分值
                tmpSBP[i].para_Tgt = list_AvBlk[i].tgt_Att_Name;

                //盆地/区域名称 没有分值
                tmpSBP[i].para_Bsn = list_AvBlk[i].bsn_Att_Name;

                //主力层系 分值
                tmpSBP[i].para_Ps = list_AvBlk[i].blk_Att_Ps;
                //tmpSBP[i].para_PsScores = sG.Grade(list_AvBlk[i].blk_Att_Ps);
                //tmpSBP[i].para_TotalScores += tmpSBP[i].para_PsScores;

                //保存条件 分值
                tmpSBP[i].para_Sc = list_AvBlk[i].blk_Att_Para_Sc;
                //tmpSBP[i].para_ScScores = fMf.FuzzyRankScore(list_AvBlk[i].blk_Att_Para_Sc);
                //tmpSBP[i].para_TotalScores += tmpSBP[i].para_ScScores;

                //地质资源量 (赋值标准没有制定)
                tmpSBP[i].para_Gr = list_AvBlk[i].blk_Att_Para_Gr;
                //tmpSBP[i].para_GrScores = 0;
                //tmpSBP[i].para_TotalScores += tmpSBP[i].para_GrScores;

                //地质条件

                #region
                //对富含有机质页岩厚度的平均值进行增大型隶属函数求值
                if (list_AvBlk[i].blk_Geo_Para_TrRoms.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("页岩厚度(m)"))
                {
                    values = Convert.ToDouble(list_AvBlk[i].blk_Geo_Para_TrRoms);
                    gradeScore = fMf.FuzzyLarge(1.6, 15, values);
                    tmpSBP[i].para_StromAt = list_AvBlk[i].blk_Geo_Para_TrRoms;
                    tmpSBP[i].para_StromAtScores = gradeScore;
                    tmpSBP[i].para_StromAtWeight = wgt_StromAt;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_StromAtScores * tmpSBP[i].para_StromAtWeight;
                }
                else
                {
                    tmpSBP[i].para_StromAt = list_AvBlk[i].blk_Geo_Para_TrRoms;
                    tmpSBP[i].para_StromAtScores = 0;
                    tmpSBP[i].para_StromAtWeight = wgt_StromAt;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Toc 的平均值进行增大型隶属函数求值
                if (list_AvBlk[i].blk_Geo_Para_Toc.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("含量TOC(%)"))
                {
                    values = Convert.ToDouble(list_AvBlk[i].blk_Geo_Para_Toc);
                    gradeScore = fMf.FuzzyLarge(1.6, 2, values);
                    tmpSBP[i].para_Toc = list_AvBlk[i].blk_Geo_Para_Toc;
                    tmpSBP[i].para_TocScores = gradeScore;
                    tmpSBP[i].para_TocWeight = wgt_Toc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_TocScores * tmpSBP[i].para_TocWeight;
                }
                else
                {
                    tmpSBP[i].para_Toc = list_AvBlk[i].blk_Geo_Para_Toc;
                    tmpSBP[i].para_TocScores = 0;
                    tmpSBP[i].para_TocWeight = wgt_Toc;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对干酪根类型求值 干酪根类型没有赋值函数，没有完成该函数的条件
                if (list_AvBlk[i].blk_Geo_Para_Kt.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("干酪根类型"))
                {
                    string val = list_AvBlk[i].blk_Geo_Para_Kt;
                    gradeScore = fMf.ToAssignForKerogenType(val);
                    tmpSBP[i].para_Kt = list_AvBlk[i].blk_Geo_Para_Kt;
                    tmpSBP[i].para_KtScores = gradeScore;
                    tmpSBP[i].para_KtWeight = wgt_Kt;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_KtScores * tmpSBP[i].para_KtWeight;
                }
                else
                {
                    tmpSBP[i].para_Kt = list_AvBlk[i].blk_Geo_Para_Kt;
                    tmpSBP[i].para_KtScores = 0;
                    tmpSBP[i].para_KtWeight = wgt_Kt;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Ro 的平均值进行高斯型隶属函数求值
                if (list_AvBlk[i].blk_Geo_Para_Ro.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("成熟度Ro(%)"))
                {
                    values = Convert.ToDouble(list_AvBlk[i].blk_Geo_Para_Ro);
                    gradeScore = fMf.FuzzyGussian(values);
                    tmpSBP[i].para_Ro = list_AvBlk[i].blk_Geo_Para_Ro;
                    tmpSBP[i].para_RoScores = gradeScore;
                    tmpSBP[i].para_RoWeight = wgt_Ro;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_RoScores * tmpSBP[i].para_RoWeight;
                }
                else
                {
                    tmpSBP[i].para_Ro = list_AvBlk[i].blk_Geo_Para_Ro;
                    tmpSBP[i].para_RoScores = 0;
                    tmpSBP[i].para_RoWeight = wgt_Ro;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Ea 的平均值进行增大型隶属函数求值
                if (list_AvBlk[i].blk_Geo_Para_Ea.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("圈定面积(km^2)"))
                {
                    values = Convert.ToDouble(list_AvBlk[i].blk_Geo_Para_Ea);
                    gradeScore = fMf.FuzzyLarge(1.2, 200, values);
                    tmpSBP[i].para_Ea = list_AvBlk[i].blk_Geo_Para_Ea;
                    tmpSBP[i].para_EaScores = gradeScore;
                    tmpSBP[i].para_EaWeight = wgt_Ea;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_EaScores * tmpSBP[i].para_EaWeight;
                }
                else
                {
                    tmpSBP[i].para_Ea = list_AvBlk[i].blk_Geo_Para_Ea;
                    tmpSBP[i].para_EaScores = 0;
                    tmpSBP[i].para_EaWeight = wgt_Ea;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Gc 的平均值进行增大型隶属函数求值
                if (list_AvBlk[i].blk_Geo_Para_Gc.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("含气量(m^3/t)"))
                {
                    values = Convert.ToDouble(list_AvBlk[i].blk_Geo_Para_Gc.Trim());
                    gradeScore = fMf.FuzzyLarge(1.6, 2, values);
                    tmpSBP[i].para_Gc = list_AvBlk[i].blk_Geo_Para_Gc.Trim();
                    tmpSBP[i].para_GcScores = gradeScore;
                    tmpSBP[i].para_GcWeight = wgt_Gc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_GcScores * tmpSBP[i].para_GcWeight;
                }
                else
                {
                    tmpSBP[i].para_Gc = list_AvBlk[i].blk_Geo_Para_Gc.Trim();
                    tmpSBP[i].para_GcScores = 0;
                    tmpSBP[i].para_GcWeight = wgt_Gc;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Rr 的平均值进行增大型隶属函数求值
                if (list_AvBlk[i].blk_Geo_Para_Rr.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("丰度(亿方/km^2)"))
                {
                    values = Convert.ToDouble(list_AvBlk[i].blk_Geo_Para_Rr.Trim());
                    gradeScore = fMf.FuzzyLarge(1, 0.5, values);
                    tmpSBP[i].para_Rr = list_AvBlk[i].blk_Geo_Para_Rr.Trim();
                    tmpSBP[i].para_RrScores = gradeScore;
                    tmpSBP[i].para_RrWeight = wgt_Rr;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_RrScores * tmpSBP[i].para_RrWeight;
                }
                else
                {
                    tmpSBP[i].para_Rr = list_AvBlk[i].blk_Geo_Para_Rr.Trim();
                    tmpSBP[i].para_RrScores = 0;
                    tmpSBP[i].para_RrWeight = wgt_Rr;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Por 的平均值进行增大型隶属函数求值
                if (list_AvBlk[i].blk_Geo_Para_Por.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("孔隙度(%)"))
                {
                    values = Convert.ToDouble(list_AvBlk[i].blk_Geo_Para_Por.Trim());
                    gradeScore = fMf.FuzzyLarge(1.2, 2, values);
                    tmpSBP[i].para_Por = list_AvBlk[i].blk_Geo_Para_Por.Trim();
                    tmpSBP[i].para_PorScores = gradeScore;
                    tmpSBP[i].para_PorWeight = wgt_Por;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_PorScores * tmpSBP[i].para_PorWeight;
                }
                else
                {
                    tmpSBP[i].para_Por = list_AvBlk[i].blk_Geo_Para_Por.Trim();
                    tmpSBP[i].para_PorScores = 0;
                    tmpSBP[i].para_PorWeight = wgt_Por;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对构造复杂度Scd 求值
                if (list_AvBlk[i].blk_Geo_Para_Scd.Trim() != ""
                    && lstBx_Selected_GeoPara.Items.Contains("构造复杂度"))
                {
                    string val = list_AvBlk[i].blk_Geo_Para_Scd.Trim();
                    gradeScore = fMf.FuzzyRankScore(val);
                    tmpSBP[i].para_Scd = list_AvBlk[i].blk_Geo_Para_Scd;
                    tmpSBP[i].para_ScdScores = gradeScore;
                    tmpSBP[i].para_ScdWeight = wgt_Scd;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_ScdScores * tmpSBP[i].para_ScdWeight;
                }
                else
                {
                    tmpSBP[i].para_Scd = list_AvBlk[i].blk_Geo_Para_Scd;
                    tmpSBP[i].para_ScdScores = 0;
                    tmpSBP[i].para_ScdWeight = wgt_Scd;
                    tmpSBP[i].para_TotalScores += 0;
                }

                #endregion

                //工程条件
                #region
                //埋深 Dr Depth Range先计算平均值，然后利用高斯型隶属函数赋分
                if (list_AvBlk[i].blk_Eng_Para_Dr.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("埋深(m)"))
                {
                    values = Convert.ToDouble(list_AvBlk[i].blk_Eng_Para_Dr.Trim());
                    gradeScore = fMf.FuzzyGussian(values);
                    tmpSBP[i].para_Dr = list_AvBlk[i].blk_Eng_Para_Dr.Trim();
                    tmpSBP[i].para_DrScores = gradeScore;
                    tmpSBP[i].para_DrWeight = wgt_Dr;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_DrScores * tmpSBP[i].para_DrWeight;
                }
                else
                {
                    tmpSBP[i].para_Dr = list_AvBlk[i].blk_Eng_Para_Dr.Trim();
                    tmpSBP[i].para_DrScores = 0;
                    tmpSBP[i].para_DrWeight = wgt_Dr;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对Pc 压力系数 的平均值进行增大型隶属函数求值
                if (list_AvBlk[i].blk_Eng_Para_Pc.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("压力系数"))
                {
                    values = Convert.ToDouble(list_AvBlk[i].blk_Eng_Para_Pc.Trim());
                    gradeScore = fMf.FuzzyLarge(6, 1, values);
                    tmpSBP[i].para_Pc = list_AvBlk[i].blk_Eng_Para_Pc.Trim();
                    tmpSBP[i].para_PcScores = gradeScore;
                    tmpSBP[i].para_PcWeight = wgt_Pc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_PcScores * tmpSBP[i].para_PcWeight;
                }
                else
                {
                    tmpSBP[i].para_Pc = list_AvBlk[i].blk_Eng_Para_Pc.Trim();
                    tmpSBP[i].para_PcScores = 0;
                    tmpSBP[i].para_PcWeight = wgt_Pc;
                    tmpSBP[i].para_TotalScores += 0;
                }

                //对脆矿 Bmc  的平均值进行增大型隶属函数求值
                if (list_AvBlk[i].blk_Eng_Para_Bmc.Trim() != ""
                    && lstBx_Selected_EngPara.Items.Contains("脆性矿物含量(%)"))
                {
                    values = Convert.ToDouble(list_AvBlk[i].blk_Eng_Para_Bmc.Trim());
                    gradeScore = fMf.FuzzyLarge(2.15, 30, values);
                    tmpSBP[i].para_Bmc = list_AvBlk[i].blk_Eng_Para_Bmc.Trim();
                    tmpSBP[i].para_BmcScores = gradeScore;
                    tmpSBP[i].para_BmcWeight = wgt_Bmc;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_BmcScores * tmpSBP[i].para_BmcWeight;
                }
                else
                {
                    tmpSBP[i].para_Bmc = list_AvBlk[i].blk_Eng_Para_Bmc.Trim();
                    tmpSBP[i].para_BmcScores = 0;
                    tmpSBP[i].para_BmcWeight = wgt_Bmc;
                    tmpSBP[i].para_TotalScores += 0;
                }
                #endregion


                //市场经济条件

                #region
                //地表地貌求值
                if (list_AvBlk[i].blk_Mkt_Para_Sg.Trim() != ""
                    && lstBx_Selected_EcoPara.Items.Contains("地表地貌"))
                {
                    //values = Convert.ToDouble(list_AvBlk[i].blk_Eng_Para_Pc.Trim());
                    //gradeScore = fMf.FuzzyLarge(6, 1, values);
                    // tmpSBP[i].para_Pc = list_AvBlk[i].blk_Eng_Para_Pc.Trim();
                    tmpSBP[i].para_SgScores = 0;
                    tmpSBP[i].para_SgWeight = wgt_Sg;
                    tmpSBP[i].para_TotalScores += tmpSBP[i].para_SgScores * tmpSBP[i].para_SgWeight;
                }
                else
                {
                    tmpSBP[i].para_Sg = list_AvBlk[i].blk_Mkt_Para_Sg.Trim();
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
            //SortedBlocksFrm sBf = new SortedBlocksFrm();
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
            counterFlag = 0;
            foreach (string str in lstBx_Selected_EcoPara.Items)
            {
                counterFlag++;
                if (counterFlag != lstBx_Selected_EcoPara.Items.Count)
                {
                    PublicValues.EcoParas += str + ",";
                }
                else
                {
                    PublicValues.EcoParas += str + ";";
                }
            }
            if (chkFlag)
            {
                List<SortedBlocksParas> lst_SBP = BlockGrade(lst_Blk);
                int counter = lst_SBP.Count;
                arr_Scores = new double[counter];
                arr_TgtName = new string[counter];
                lst_SBP.Sort((x, y) => x.para_TotalScores.CompareTo(y.para_TotalScores));
                foreach (SortedBlocksParas sBp in lst_SBP)
                {
                    sBp.para_Rank = counter;
                    counter--;
                }
                lst_SBP.Sort((x, y) => x.para_Rank.CompareTo(y.para_Rank));
                arr_Scores = lst_SBP.Select(x => x.para_TotalScores).ToArray();
                arr_TgtName = lst_SBP.Select(x => x.para_Tgt).ToArray();
                SortedBlocksFrm sbf = new SortedBlocksFrm(arr_Scores, arr_TgtName);
                sbf.dgv_Blk_Sorted.DataSource = DataSourceToDataTable.GetListToDataTable(lst_SBP);
                sbf.Show();
                //btn_GenerateReport.Enabled = true;
            }
            else
            {
                MessageBox.Show("尚未进行参数矩阵的检验计算操作，所有参数的权重值为 0 .", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            PDFCreator pdfCreator = new PDFCreator();
            pdfCreator.Create("有利区");
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


    }
}
