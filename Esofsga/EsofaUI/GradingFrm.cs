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
    public partial class GradingFrm : Form
    {
        public GradingFrm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //核心区为当前选定区域
           // if (rBtnCore.Checked == true)
           // {
                //创建核心区矩阵窗体实例
                CoreAreaMatrixFrm coreFrm = new CoreAreaMatrixFrm();

                //显示核心区矩阵窗体
                coreFrm.Show();
           // }

            ////有利区为当前选定区域
            //if (rBtnFavorable.Checked == true)
            //{
            //    //创建有利区矩阵窗体实例
            //    FavorableAreaMatrixFrm favorableFrm = new FavorableAreaMatrixFrm();

            //    //显示有利区矩阵窗体
            //    favorableFrm.Show();
            //}

            //////远景区为当前选定区域
            //if (rBtnProspective.Checked == true)
            //{
            //    //创建远景区矩阵窗体实例
            //    ProspectAreaMatrixFrm prospectFrm = new ProspectAreaMatrixFrm();

            //    //显示远景区矩阵窗体
            //    prospectFrm.Show();

            //}
        }
    }
}
