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

namespace EsofaUI
{
    public partial class FavorableAreaMatrixFrm : Form
    {
        public FavorableAreaMatrixFrm()
        {
            InitializeComponent();
        }

        private void FavorableAreaMatrixFrm_Load(object sender, EventArgs e)
        {
            //调用通用方法模块中的数据加载方法，将数组里的数据加载到datagridview的cell中
            ParametersWeightLoader paraWeightLoader = new ParametersWeightLoader();

            //创建DataTable变量，用于中间转载数据
            DataTable dt = new DataTable();

            //定义有利区区块(分层方法中的 第一层)参数的权重矩阵数据
            double[,] coreAreaWeight_R1 = {  {1,3,7 },
                                                               {1/3.0,1,5 },
                                                               {1/7.0,1/5.0,1 } };

            //定义有利区区块(分层方法中的 第二层)地质条件参数的权重矩阵数据
            double[,] coreGeoWeight_R21 = { {1,3,7,3,3,3,1,6,1 },
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0 },
                                                               {1/7.0,1/3.0,1,1/3.0,1/3.0,1/3.0,1/7.0,1/1.5,1/7.0 },
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0 },
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0},
                                                               {1/3.0,1,3,1,1,1,1/3.0,2.5,1/3.0 },
                                                               {1,3,7,3,3,3,1,6,1 },
                                                               {1/6.0,1/2.5,1.5,1/2.5,1/2.5,1/2.5,1/6.0,1,1/6.0 },
                                                               {1,3,7,3,3,3,1,6,1 } };
                                                              

            ////定义有利区区块(分层方法中的 第二层)工程条件参数的权重矩阵数据
            double[,] coreEngiWeight_R22 = { {1,7,1 },
                                                               {1/7.0,1,1/7.0 },
                                                               {1,7,1 } };

            ////定义核心区区块(分层方法中的 第二层)经济条件参数的权重矩阵数据
            double[,] coreEcoWeight_R23 = { {7 } };

            //调用通用数据加载方法，返回DataTable类型数据表格
            dt = paraWeightLoader.ParaWeightLoad(coreAreaWeight_R1);

            //将DataTable数据类型变量赋值给dataGridView的源数据
            this.dGridViewFav.DataSource = dt;

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
    }
}
