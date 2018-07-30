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

        private void btn_CoincidenceCheck_Click(object sender, EventArgs e)
        {
            CoincidenceChecker cc = new CoincidenceChecker();
            EigenValues eignFrm = new EigenValues();
            StringBuilder strB = new StringBuilder();
            Vector<double> vR1 = cc.ArrayLoad(R1, out strB);
            eignFrm.textBox1.Text += "R1: \r\n" + strB.ToString() + "\r\n\r\n";
            Vector<double> vR21 = cc.ArrayLoad(R21, out strB) * vR1.ElementAt(0);
            eignFrm.textBox1.Text += "R21: \r\n" + strB.ToString() + "\r\n\r\n";
            Vector<double> vR22 = cc.ArrayLoad(R22, out strB) * vR1.ElementAt(1);
            eignFrm.textBox1.Text += "R22: \r\n" + strB.ToString() + "\r\n\r\n";
            //Vector<double> vR23 = cc.ArrayLoad(R23, out strB) * vR1.ElementAt(2);
            eignFrm.textBox1.Text +=  vR21 + "\r\n" + vR22 + "\r\n" ;

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

        private void btn_Sort_Click(object sender, EventArgs e)
        {

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
