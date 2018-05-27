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
           if (tabControlGrading.SelectedTab == tabPageBasin)
            {
                //////远景区为当前选定区域
                //if (rBtnProspective.Checked == true)
                //{
                //    //创建远景区矩阵窗体实例
                   ProspectAreaMatrixFrm prospectFrm = new ProspectAreaMatrixFrm();

                //    //显示远景区矩阵窗体
                   prospectFrm.Show();

                //}
            }

            if (tabControlGrading.SelectedTab == tabPageBlock)
            {
                ////有利区为当前选定区域
                //if (rBtnFavorable.Checked == true)
                //{
                //    //创建有利区矩阵窗体实例
                    FavorableAreaMatrixFrm favorableFrm = new FavorableAreaMatrixFrm();

                //    //显示有利区矩阵窗体
                    favorableFrm.Show();
                //}
            }

            if(tabControlGrading.SelectedTab == tabPageTarget)
            {
                //核心区为当前选定区域
                // if (rBtnCore.Checked == true)
                // {
                //创建核心区矩阵窗体实例
                CoreAreaMatrixFrm coreFrm = new CoreAreaMatrixFrm();

                //显示核心区矩阵窗体
                coreFrm.Show();
                // }
            }

           
        }

        //private void GradingFrm_Load(object sender, EventArgs e)
        //{
        //    this.treeViewGrad.CheckBoxes = true;
        //    this.treeViewGrad.ShowLines = true;
        //    this.treeViewGrad.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
        //    this.treeViewGrad.DrawNode += new DrawTreeNodeEventHandler(treeViewGrad_DrawNode);
        //}
        //private void treeViewGrad_DrawNode(object sender, DrawTreeNodeEventArgs e)
        //{
        //    if(e.Node.Level == 0)
        //    {
                
        //    }
        //}
    }
}
