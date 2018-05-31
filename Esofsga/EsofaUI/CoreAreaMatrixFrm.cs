using System;
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
        double[,] R1;
        //double[,] Rtest = {
        //                            {-1,1,0 },
        //                            { -4,3,0},
        //                            {1,0,2 }
        //                        };
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
            double [,] coreAreaWeight_R1 = { {1,1,3 }, 
                                                               {1,1,3 }, 
                                                               {1/3.0,1/3.0,1 } };
            R1 = coreAreaWeight_R1;
            //R1 ={ {-1,1,0 },{ -4,3,0},{ 1,0,2} };

            //定义核心区区块(分层方法中的 第二层)地质条件参数的权重矩阵数据
            double[,] coreGeoWeight_R21 = { {1,3,7,3,3,3,1,6,1,8,9 },
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0,5,6 }, 
                                                               {1/7.0,1/3.0,1,1/3.0,1/3.0,1/3.0,1/7.0,1/1.5,1/7.0,2,3 },
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0,5,6 }, 
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0,5,6},
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0,5,6 },
                                                               {1,3,7,3,3,3,1,6,1,8,9 }, 
                                                               {1/6.0,1/2.5,1.5,1/2.5,1/2.5,1/2.5,1/6.0,1,1/6.0,3,4 }, 
                                                               {1,3,7,3,3,3,1,6,1,8,9 }, 
                                                               {1/8.0,1/5.0,1/2.0,1/5.0,1/5.0,1/5.0,1/8.0,1/3.0,1/8.0,1,2 }, 
                                                               {1/9.0,1/6.0,1/3.0,1/6.0,1/6.0,1/6.0,1/9.0,1/4.0,1/9.0,1/2.0,1 } };
            R21 = coreGeoWeight_R21;
            ////定义核心区区块(分层方法中的 第二层)工程条件参数的权重矩阵数据
            double[,] coreEngiWeight_R22 = { {1,3,3,8,6,1,6,9 },
                                                               {1/3.0,1,1,5,4,1/3.0,4,6 },
                                                               {1/3.0,1,1,5,4,1/3.0,4,6 },
                                                               {1/8.0,1/5.0,1/5.0,1,1/3.0,1/8.0,1/3.0,2 },
                                                               {1/6.0,1/6.0,1/4.0,3,1,1/6.0,1,5 },
                                                               {1,3,3,8,6,1,6,9  },
                                                               {1/6.0,1/6.0,1/4.0,3,1,1/6.0,1,5 },
                                                               {1/9.0,1/6.0,1/6.0,1/2.0,1/5.0,1/9.0,1/5.0,1 } };
            R22 = coreEngiWeight_R22;
            ////定义核心区区块(分层方法中的 第二层)经济条件参数的权重矩阵数据
            double[,] coreEcoWeight_R23 = { {1,1,3,3,1/3.0 },
                                                               {1,1,3,3,1/3.0 },
                                                               {1/3.0,1/3.0,1,1,1/6.0 },
                                                               {1/3.0,1/3.0,1,1,1/6.0 },
                                                               {3,3,6,6,1 } };
            R23 = coreEcoWeight_R23;
           
            //调用通用数据加载方法，返回DataTable类型数据表格
           dt = paraWeightLoader.ParaWeightLoad(coreAreaWeight_R1);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dGridViewCor.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(coreGeoWeight_R21);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dGridViewGeoPara.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(coreEngiWeight_R22);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dGridViewEngiPara.DataSource = dt;

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(coreEcoWeight_R23);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dGridViewEcoPara.DataSource = dt;
        }
        // EigenValues eignFrm = new EigenValues();
        //StringBuilder strB = new StringBuilder();
        /// <summary>
        /// 计算特征值和特征向量
        /// </summary>
        /// <param name="arr"></param>
        private Vector<double> ArrayLoad(double [,] arr,out StringBuilder strB)
        {
            double maxEigenValue;
             strB = new StringBuilder();
            //EigenValues eignFrm = new EigenValues();
            CoincidenceChecker cChecker = new CoincidenceChecker();
            Vector<double> eigenVector = cChecker.Caculate(arr, out maxEigenValue);
            Vector<double> normalizedVector = eigenVector.Normalize(1);
            double CR=cChecker.CrGenerate(maxEigenValue, arr);
            #region
            //foreach (double num in eigenVector)
            //{
            //    if (Math.Abs(num) < 0.000001)
            //    {
            //        eignFrm.textBox1.Text += num.ToString("#0.0") + "\r\n";
            //    }
            //    else
            //    {
            //        eignFrm.textBox1.Text += num.ToString("#0.000") + "\r\n";
            //    }
            // }
            //eignFrm.textBox1.Text += eigenVector.EigenVectors.ToString("#0.00") + "\r\n";
            #endregion
            strB.Append("  ===============================================" + "\r\n");
            strB.Append("  Maximum Eigenvalue: " + maxEigenValue + "\r\n");
            strB.Append("  ===============================================" + "\r\n");
            strB.Append("  Maximum Eigenvalue's Eigenvector:\r\n" + eigenVector.ToString("#0.000000") + "\r\n");
            strB.Append("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + "\r\n");
            strB.Append("  Maximum Eigenvalue's Eigenvector:\r\n" + normalizedVector.ToString("#0.000000") + "\r\n" + "CR Value is: " + CR.ToString("#0.000") + "\r\n");
            strB.Append("  ******************************************" + "\r\n");
            return normalizedVector;
        }

        /// <summary>
        /// 对矩阵进行一致性检验，主要是计算一致性比例CR = CI(一致性指标)/RI(平均随机一致性指标)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCoincidenceCheck_Click(object sender, EventArgs e)
        {
            //ArrayLoad(Rtest);
            //定义地质条件的权重变量
            //依次：厚度、含量、成熟度、面积、含气量、丰度、孔隙度
            double wgt_StromAt;
            double wgt_Toc;
            double wgt_Ro;
            double wgt_Ea;
            double wgt_Gc;
            double wgt_Rr;
            double wgt_Por;

            //定义 工程条件的权重变量
            //依次：埋深、压力系数、主应力差、脆矿
            double wgt_Ad;
            double wgt_Pc;
            double wgt_Psdf;
            double wgt_Bmc;

            double tempTotalSocres = 0;
            int counter = Main_Form.listBlockPara.Count;
            //
            SortedBlocksFrm sBf = new SortedBlocksFrm();
            EigenValues eignFrm = new EigenValues();
            StringBuilder strB = new StringBuilder();
           Vector<double> vR1 = ArrayLoad(R1, out strB);
            eignFrm.textBox1.Text += "R1: \r\n"+strB.ToString() + "\r\n\r\n";
            Vector<double> vR21 = ArrayLoad(R21, out strB) * vR1.ElementAt(0);
            eignFrm.textBox1.Text += "R21: \r\n" + strB.ToString() + "\r\n\r\n";
            Vector<double> vR22 = ArrayLoad(R22, out strB) * vR1.ElementAt(1);
            eignFrm.textBox1.Text += "R22: \r\n" + strB.ToString() + "\r\n\r\n";
            Vector<double> vR23 = ArrayLoad(R23, out strB) * vR1.ElementAt(2);
            #region
            //Evd<double> eigen = cc.Caculate(Rtest);
            ////int index = eigen.EigenValues.MaximumIndex();
            //double ei = eigen.EigenValues.AbsoluteMaximum().Real;
            //int j = eigen.EigenValues.AbsoluteMaximumIndex();
            //Vector<double> eigenV = eigen.EigenVectors.Column(j);
            //foreach (double num in eigen.EigenValues.Real())
            //{
            //    if (Math.Abs(num) < 0.000001)
            //    {
            //        eignFrm.textBox1.Text += num.ToString("#0.0") + "\r\n";
            //    }
            //    else
            //    {
            //        eignFrm.textBox1.Text += num.ToString("#0.000") + "\r\n";
            //    }
            //}
            //eignFrm.textBox1.Text += eigen.EigenVectors.ToString("#0.00") + "\r\n";
            //eignFrm.textBox1.Text += "===============================================" + "\r\n";
            //eignFrm.textBox1.Text += "Maximum Eigenvalue: "+ei+"\r\n";
            //eignFrm.textBox1.Text += "===============================================" + "\r\n";
            //eignFrm.textBox1.Text += "Maximum Eigenvalue's Eigenvector:\r\n"+eigenV.ToString("#0.00") +"\r\n";
            //eignFrm.textBox1.Text += "******************************************" + "\r\n";
            //Evd<double> eigen1 = cc.Caculate(R21);
            //double d = eigen1.EigenValues.AbsoluteMaximum().Real;
            //int i = eigen1.EigenValues.AbsoluteMaximumIndex();
            //Vector<double> eigenV2 = eigen1.EigenVectors.Column(i);
            //foreach (double num in eigen1.EigenValues.Real())
            //{
            //    if (Math.Abs(num) < 0.000001)
            //    {
            //        eignFrm.textBox1.Text += num.ToString("#0.0") + "\r\n";
            //    }
            //    else
            //    {
            //        eignFrm.textBox1.Text += num.ToString("#0.00") + "\r\n";
            //    }
            //}
            //eignFrm.textBox1.Text += eigen1.EigenVectors.ToString("#0.00") + "\r\n";
            //eignFrm.textBox1.Text += "===============================================" + "\r\n";
            //eignFrm.textBox1.Text += "Maximum Eigenvalue: " + d + "\r\n";
            //eignFrm.textBox1.Text += "===============================================" + "\r\n";
            //eignFrm.textBox1.Text += "Maximum Eigenvalue's Eigenvector:\r\n" + eigenV2.ToString("#0.00") + "\r\n";
            //eignFrm.textBox1.Text += "*********************" + "\r\n";

            ////Evd<double> eigen2 = cc.Caculate(R22);
            ////foreach (double num in eigen2.EigenValues.Real())
            ////{
            ////    if (Math.Abs(num) < 0.000001)
            ////    {
            ////        eignFrm.textBox1.Text += num.ToString("#0.0") + "\r\n";
            ////    }
            ////    else
            ////    {
            ////        eignFrm.textBox1.Text += num.ToString("#0.0000") + "\r\n";
            ////    }
            ////}
            ////eignFrm.textBox1.Text += eigen2.EigenVectors.ToString()+"\r\n";
            ////eignFrm.textBox1.Text += "*********************" + "\r\n";
            ////Evd<double> eigen3 = cc.Caculate(R23);
            ////foreach (double num in eigen3.EigenValues.Real())
            ////{
            ////    if (Math.Abs(num) < 0.000001)
            ////    {
            ////        eignFrm.textBox1.Text += num.ToString("#0.0") + "\r\n";
            ////    }
            ////    else
            ////    {
            ////        eignFrm.textBox1.Text += num.ToString("#0.0000") + "\r\n";
            ////    }
            ////}
            #endregion
            eignFrm.textBox1.Text += "R23: \r\n" + strB.ToString() + "\r\n"+ vR21 + "\r\n" + vR22 + "\r\n" + vR23;

            //从地质条件的参数权重向量 vR21 中对应地对权重变量进行赋值
            wgt_StromAt = vR21[0];
            wgt_Toc = vR21[1];
            wgt_Ro = vR21[3];
            wgt_Ea = vR21[4];
            wgt_Gc = vR21[5];
            wgt_Rr = vR21[6];
            wgt_Por = vR21[7];

            //从工程条件的参数权重向量中对应地对权重变量进行赋值
            wgt_Ad = vR22[0];
            wgt_Pc = vR22[1];
            wgt_Psdf = vR22[4];
            wgt_Bmc = vR22[5];
            foreach(SortedBlocksParas sBp in Main_Form.listBlockPara)
            {
                //地质条件
                sBp.para_AdWeight = wgt_StromAt;
                tempTotalSocres += sBp.para_AdWeight * sBp.para_AdScores;

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
                sBp.para_AdWeight = wgt_Ad;
                tempTotalSocres += sBp.para_AdWeight * sBp.para_AdScores;

                sBp.para_PcWeight = wgt_Pc;
                tempTotalSocres += sBp.para_PcWeight * sBp.para_PcScores;

                sBp.para_PsdfWeight = wgt_Psdf;
                tempTotalSocres += sBp.para_PsdfWeight * sBp.para_PsdfScores;

                sBp.para_BmcWeight = wgt_Bmc;
                tempTotalSocres += sBp.para_BmcWeight * sBp.para_BmcScores;

                sBp.para_TotalScores = tempTotalSocres + sBp.para_PsScores+sBp.para_FddScores+sBp.para_ScScores;
                tempTotalSocres = 0;
            }
            Main_Form.listBlockPara.Sort((x, y) => x.para_TotalScores.CompareTo(y.para_TotalScores));
            foreach(SortedBlocksParas sBp in Main_Form.listBlockPara)
            {
                sBp.para_Rank = counter ;
                counter--;
            }
           Main_Form.listBlockPara.Sort((x, y) => x.para_Rank.CompareTo(y.para_Rank));
            sBf.dGVSortedBlockParas.DataSource = Main_Form.listBlockPara;
            eignFrm.Show();
            sBf.Show();

        }

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
    }
}
