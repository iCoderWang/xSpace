﻿using EsofaCommon;
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
    public partial class BasinParametersMatrixFrm : Form
    {
        public BasinParametersMatrixFrm()
        {
            InitializeComponent();
        }
        private List<AverageValuesBasinEntity> lst_Bsn;
        public BasinParametersMatrixFrm(List<AverageValuesBasinEntity> list)
        {
            InitializeComponent();
            lst_Bsn = list;
        }

        double[,] R1;
        double[,] R21;
        double[,] R22;

        //******************************************************//
        string[] geoParasAll;
        string[] engParasAll;
       // string[] ecoParasAll;
        //******************************************************//

        /// <summary>
        /// 加载远景区参数矩阵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BasinParametersMatrixFrm_Load(object sender, EventArgs e)
        {
            //******************************************************//
            geoParasAll = new string[lstBx_All_GeoPara.Items.Count];
            engParasAll = new string[lstBx_All_EngPara.Items.Count];
            //ecoParasAll = new string[lstBx_All_EcoPara.Items.Count];
            for (int i = 0; i < lstBx_All_GeoPara.Items.Count; i++)
            {
                geoParasAll[i] = (string)lstBx_All_GeoPara.Items[i];
                if (i < lstBx_All_EngPara.Items.Count)
                {
                    engParasAll[i] = (string)lstBx_All_EngPara.Items[i];
                }
                //if (i < lstBx_All_EcoPara.Items.Count)
                //{
                //    ecoParasAll[i] = (string)lstBx_All_EcoPara.Items[i];
                //}
            }
            //******************************************************//

            MatrixLoad();
        }
        private void MatrixLoad()
        {
            //调用通用方法模块中的数据加载方法，将数组里的数据加载到datagridview的cell中
            ParametersWeightLoader paraWeightLoader = new ParametersWeightLoader();

            //创建DataTable变量，用于中间转载数据
            DataTable dt = new DataTable();

            //定义有利区区块(分层方法中的 第一层)参数的权重矩阵数据
            double[,] bsnAreaWeight_R1 = {  {1,7 },
                                                               {1/7.0,1} };
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
            double[,] bsnEngiWeight_R22 = { { 1, 3 }, { 1/3.0, 1 } };
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
        private void btnCoincidenceCheck_Click(object sender, EventArgs e)
        {
            CoincidenceChecker cc = new CoincidenceChecker();
            EigenValues eignFrm = new EigenValues();
            StringBuilder strB = new StringBuilder();
            StringBuilder cRstr = new StringBuilder();
            //PublicValues.dgv_GEE = dgv_Bsn;
            PublicValues.dgv_Geo = dgv_Bsn_GeoPara;
            PublicValues.dgv_Eng = dgv_Bsn_EngPara;
            //PublicValues.dgv_Eco = dgv_Tgt_EcoPara;
            string[] cR_arr = null;
            int flag = 0;
            string cR1 = null, cR21 = null, cR22 = null;// cR = null;
            Vector<double> vR1 = cc.ArrayLoad(R1, out strB,out cR1);
            eignFrm.textBox1.Text += "R1: \r\n" + strB.ToString() + "\r\n\r\n";
            //foreach (double dbl in vR1)
            //{
            //    if (dbl != vR1.Last())
            //    {
            //        PublicValues.GEE_Wgt += dbl.ToString() + ",";
            //    }
            //    else
            //    {
            //        PublicValues.GEE_Wgt += dbl.ToString() + ";";
            //    }
            //}
            Vector<double> vR21 = cc.ArrayLoad(R21, out strB , out cR21) * vR1.ElementAt(0);
            eignFrm.textBox1.Text += "R21: \r\n" + strB.ToString() + "\r\n\r\n";

            //******************************************************//
            PublicValues.ArrGeoWgt = new double[vR21.ToArray().Length];
            PublicValues.ArrGeoWgt = vR21.ToArray();
            //******************************************************//

            //foreach (double dbl in vR21)
            //{
            //    if (dbl != vR21.Last())
            //    {
            //        PublicValues.GeoWgt += dbl.ToString() + ",";
            //    }
            //    else
            //    {
            //        PublicValues.GeoWgt += dbl.ToString() + ";";
            //    }
            //}
            Vector<double> vR22 = cc.ArrayLoad(R22, out strB, out cR22) * vR1.ElementAt(1);
            eignFrm.textBox1.Text += "R22: \r\n" + strB.ToString() + "\r\n\r\n";

            //******************************************************//
            PublicValues.ArrEngWgt = new double[vR22.ToArray().Length];
            PublicValues.ArrEngWgt = vR22.ToArray();
            //******************************************************//

            //foreach (double dbl in vR22)
            //{
            //    if (dbl != vR22.Last())
            //    {
            //        PublicValues.EngWgt += dbl.ToString() + ",";
            //    }
            //    else
            //    {
            //        PublicValues.EngWgt += dbl.ToString() + ";";
            //    }
            //}
            cR_arr = new string[] { cR1, cR21, cR22 };
            eignFrm.textBox1.Text += vR21 + "\r\n" + vR22 + "\r\n";
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
            this.btn_Next.Enabled = true;
        }


        private void btn_Next_Click(object sender, EventArgs e)
        {
            List<double> lst_paraWgt = new List<double>();
            List<string> lst_BlkName = new List<string>();
            int counterFlag = 0;
            //******************************************************//
            PublicValues.GeoParas = "";
            PublicValues.EngParas = "";
            PublicValues.EcoParas = "";
            //SortedTargetsFrm stf = new SortedTargetsFrm(arr);
            PublicValues.ArrGeoParas = new string[lstBx_Selected_GeoPara.Items.Count];
            foreach (string str in lstBx_Selected_GeoPara.Items)
            {
                PublicValues.ArrGeoParas[counterFlag] = str;
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

            //将所有参数对应的权重值赋值给对应的参数，并形成一个字典变量，以供后面绘图时调用
            //此目的是为了绘制柱状图时，所用参数对应 相应的权重值
            PublicValues.DicGeoP_W = new Dictionary<string, double>();
            PublicValues.DicEngP_W = new Dictionary<string, double>();
            PublicValues.DicEcoP_W = new Dictionary<string, double>();
            for (int i = 0; i < geoParasAll.Length; i++)
            {
                PublicValues.DicGeoP_W.Add(geoParasAll[i], (double)PublicValues.ArrGeoWgt[i]);
                if (i < engParasAll.Length)
                {
                    PublicValues.DicEngP_W.Add(engParasAll[i], (double)PublicValues.ArrEngWgt[i]);
                }
                //if (i < ecoParasAll.Length)
                //{
                //    PublicValues.DicEcoP_W.Add(ecoParasAll[i], (double)PublicValues.ArrEcoWgt[i]);
                //}
            }

            counterFlag = 0;
            PublicValues.ArrEngParas = new string[lstBx_Selected_EngPara.Items.Count];
            foreach (string str in lstBx_Selected_EngPara.Items)
            {
                PublicValues.ArrEngParas[counterFlag] = str;
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
            //counterFlag = 0;
            //PublicValues.ArrEcoParas = new string[lstBx_Selected_EcoPara.Items.Count];
            //foreach (string str in lstBx_Selected_EcoPara.Items)
            //{
            //    PublicValues.ArrEcoParas[counterFlag] = str;
            //    counterFlag++;
            //    if (counterFlag != lstBx_Selected_EcoPara.Items.Count)
            //    {
            //        PublicValues.EcoParas += str + ",";
            //    }
            //    else
            //    {
            //        PublicValues.EcoParas += str + ";";
            //    }
            //}
            //******************************************************//
            if (chkFlag)
            {
                int sn = 0;
                List<SortedBasinsParas> lst_STP = BlockGrade(lst_Bsn);
                List<TopsisBasinDecisionMatrixEntity> lst_TTDME = new List<TopsisBasinDecisionMatrixEntity>();
                foreach (SortedBasinsParas var in lst_STP)
                {
                    sn++;
                    lst_TTDME.Add(new TopsisBasinDecisionMatrixEntity
                    {
                        //序号
                        para_Rank = sn,
                        //区块名称
                        para_Tgt = var.para_Tgt,
                        //地质参数得分
                        para_StromAtScores = var.para_StromAtScores,
                        para_TocScores = var.para_TocScores,
                        para_KtScores = var.para_KtScores,
                        para_RoScores = var.para_RoScores,
                        para_EaScores = var.para_EaScores,
                        //para_GcScores = var.para_GcScores,
                        para_RrScores = var.para_RrScores,
                        //para_PorScores = var.para_PorScores,
                        para_ScdScores = var.para_ScdScores,
                        //para_RfcScores = var.para_RfcScores,
                        //工程参数得分
                        para_DrScores = var.para_DrScores,
                        //para_PcScores = var.para_PcScores,
                        //para_PerScores = var.para_PerScores,
                        //para_FddScores = var.para_FddScores,
                        //para_PsdcScores = var.para_PsdcScores,
                        para_BmcScores = var.para_BmcScores,
                        //para_DsScores = var.para_DsScores,
                        //para_LedScores = var.para_LedScores,
                        //市场参数得分
                        //para_GpScores = var.para_GpScores,
                        //para_DmdScores = var.para_DmdScores,
                        //para_TuScores = var.para_TuScores,
                        //para_PnScores = var.para_PnScores,
                        //para_SgScores = var.para_SgScores
                    });
                }
                //int counter = lst_STP.Count;
                ////arr_Scores = new double[counter];
                double arr_StromAt_Wgt = lst_STP.Select(x => x.para_StromAtWeight).First();
                double arr_Toc_Wgt = lst_STP.Select(x => x.para_TocWeight).First();
                double arr_Kt_Wgt = lst_STP.Select(x => x.para_KtWeight).First();
                double arr_Ro_Wgt = lst_STP.Select(x => x.para_RoWeight).First();
                double arr_Ea_Wgt = lst_STP.Select(x => x.para_EaWeight).First();
                //double arr_Gc_Wgt = lst_STP.Select(x => x.para_GcWeight).First();
                double arr_Rr_Wgt = lst_STP.Select(x => x.para_RrWeight).First();
                //double arr_Por_Wgt = lst_STP.Select(x => x.para_PorWeight).First();
                double arr_Scd_Wgt = lst_STP.Select(x => x.para_ScdWeight).First();
                //double arr_Rfc_Wgt = lst_STP.Select(x => x.para_RfcWeight).First();
                double arr_Dr_Wgt = lst_STP.Select(x => x.para_DrWeight).First();
                //double arr_Pc_Wgt = lst_STP.Select(x => x.para_PcWeight).First();
                //double arr_Per_Wgt = lst_STP.Select(x => x.para_PerWeight).First();
                //double arr_Fdd_Wgt = lst_STP.Select(x => x.para_FddWeight).First();
                //double arr_Psdc_Wgt = lst_STP.Select(x => x.para_PsdcWeight).First();
                double arr_Bmc_Wgt = lst_STP.Select(x => x.para_BmcWeight).First();
                //double arr_Ds_Wgt = lst_STP.Select(x => x.para_DsWeight).First();
                //double arr_Led_Wgt = lst_STP.Select(x => x.para_LedWeight).First();
                //double arr_Gp_Wgt = lst_STP.Select(x => x.para_GpWeight).First();
                //double arr_Dmd_Wgt = lst_STP.Select(x => x.para_DmdWeight).First();
                //double arr_Tu_Wgt = lst_STP.Select(x => x.para_TuWeight).First();
                //double arr_Pn_Wgt = lst_STP.Select(x => x.para_PnWeight).First();
                //double arr_Sg_Wgt = lst_STP.Select(x => x.para_SgWeight).First();
                lst_paraWgt.Add(arr_StromAt_Wgt);
                lst_paraWgt.Add(arr_Toc_Wgt);
                lst_paraWgt.Add(arr_Kt_Wgt);
                lst_paraWgt.Add(arr_Ro_Wgt);
                lst_paraWgt.Add(arr_Ea_Wgt);
                //lst_paraWgt.Add(arr_Gc_Wgt);
                lst_paraWgt.Add(arr_Rr_Wgt);
                //lst_paraWgt.Add(arr_Por_Wgt);
                lst_paraWgt.Add(arr_Scd_Wgt);
                //lst_paraWgt.Add(arr_Rfc_Wgt);
                lst_paraWgt.Add(arr_Dr_Wgt);
                //lst_paraWgt.Add(arr_Pc_Wgt);
                //lst_paraWgt.Add(arr_Per_Wgt);
                //lst_paraWgt.Add(arr_Fdd_Wgt);
                //lst_paraWgt.Add(arr_Psdc_Wgt);
                lst_paraWgt.Add(arr_Bmc_Wgt);
                //lst_paraWgt.Add(arr_Ds_Wgt);
                //lst_paraWgt.Add(arr_Led_Wgt);
                //lst_paraWgt.Add(arr_Gp_Wgt);
                //lst_paraWgt.Add(arr_Dmd_Wgt);
                //lst_paraWgt.Add(arr_Tu_Wgt);
                //lst_paraWgt.Add(arr_Pn_Wgt);
                //lst_paraWgt.Add(arr_Sg_Wgt);
                //lst_TgtName.Add(lst_TTDME.Select(x => x.para_Tgt).ToArray());
                foreach (TopsisBasinDecisionMatrixEntity var in lst_TTDME)
                {
                    lst_BlkName.Add(var.para_Tgt);
                }
                //SortedTargetsFrm stf = new SortedTargetsFrm(arr_Scores, arr_TgtName);
                //stf.dgv_Tgt_Sorted.DataSource = DataSourceToDataTable.GetListToDataTable(lst_STP);
                //stf.Show();
                //btn_GenerateReport.Enabled = true;
                TOPSISDecisionMatrixFrm tdm = TOPSISDecisionMatrixFrm.CreateInstance(lst_paraWgt, lst_BlkName, "dgvBsn_TDM");
                tdm.dgv_DecisionMatrix.DataSource = lst_TTDME;
                tdm.Show();
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

        private void btn_DefaultMatrix_Click(object sender, EventArgs e)
        {
            MatrixLoad();
            this.dgv_Bsn.ReadOnly = true;
            //this.dgv_Bsn_EcoPara.ReadOnly = true;
            this.dgv_Bsn_EngPara.ReadOnly = true;
            this.dgv_Bsn_GeoPara.ReadOnly = true;
        }

        private void btn_CustomedMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgv_Bsn.ReadOnly = false;
                //this.dgv_Blk_EcoPara.ReadOnly = false;
                this.dgv_Bsn_EngPara.ReadOnly = false;
                this.dgv_Bsn_GeoPara.ReadOnly = false;
                MessageBox.Show("参数表格处于可编辑状态，只有数字允许被输入！", "信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("参数矩阵表格内，只有数字允许被输入！", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

    }
}
