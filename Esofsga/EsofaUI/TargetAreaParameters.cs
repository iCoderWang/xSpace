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
    public partial class TargetAreaParameters : Form
    {
        public TargetAreaParameters()
        {
            InitializeComponent();
        }

        private void TargetAreaParameters_Load(object sender, EventArgs e)
        {
            //窗体启动加载，默认为核心区被选中
            this.rBtnCore.Checked = true;
            //this.rBtnCore.Enabled = false;

            //清除变化区域参数值列表框
            this.listBox_Diff_GeoPara.Items.Clear();
            this.listBox_Diff_EngiPara.Items.Clear();
            this.listBox_Diff_EcoPara.Items.Clear();

            //清空表示当前选择区域的标签
           // this.lab_TargetEco.Text = "";
            //this.lab_TargetEngi.Text = "";
           // this.lab_TargetGeo.Text = "";
            
            //标准表示当前选择区域的标签
           // this.lab_TargetEco.Text = "核\r\n心\r\n区";
            //this.lab_TargetEngi.Text = "核\r\n心\r\n区";
            //this.lab_TargetGeo.Text = "核\r\n心\r\n区";
            //添加核心区的地质参数
            foreach (string str in this.listBox_GeoPara.Items)
            {
                this.listBox_Diff_GeoPara.Items.Add(str);
            }

            ////添加核心区的工程参数
            foreach (string str in this.listBox_EngPara.Items)
            {
                this.listBox_Diff_EngiPara.Items.Add(str);
            }

            //添加核心区的经济参数
            foreach (string str in this.listBox_EcoPara.Items)
            {
                this.listBox_Diff_EcoPara.Items.Add(str);
            }

        }

        //有利区
        private void rBtnFavorable_CheckedChanged(object sender, EventArgs e)
        {
            //清除变化区域参数值列表框
            this.listBox_Diff_GeoPara.Items.Clear();
            this.listBox_Diff_EngiPara.Items.Clear();
            this.listBox_Diff_EcoPara.Items.Clear();

            //非远景区经济参数参与评估
            this.listBox_Diff_EcoPara.Enabled = true;
            this.listBox_Diff_EcoPara.Visible = true;
            
            //添加有利区的地质参数
            foreach (string str in this.listBox_GeoPara.Items)
            {
                if(this.listBox_GeoPara.Items.IndexOf(str) < 9 )
                {
                    this.listBox_Diff_GeoPara.Items.Add(str);
                }
                else
                {
                    break;
                }
            }

            ////添加有利区的工程参数
            foreach (string str in this.listBox_EngPara.Items)
            {
                if(this.listBox_EngPara.Items.IndexOf(str) < 2)
                {
                    this.listBox_Diff_EngiPara.Items.Add(str);
                }
                else if(this.listBox_EngPara.Items.IndexOf(str) == 5)
                {
                    this.listBox_Diff_EngiPara.Items.Add(str);
                }
                else if (this.listBox_EngPara.Items.IndexOf(str) > 5)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            //添加有利区的经济参数
            foreach (string str in this.listBox_EcoPara.Items)
            {
                if(this.listBox_EcoPara.Items.IndexOf(str) == 4)
                {
                    this.listBox_Diff_EcoPara.Items.Add(str);
                }
                else
                {
                    continue;
                }
            }
        }

        //远景区
        private void rBtnProspective_CheckedChanged(object sender, EventArgs e)
        {
            //清除变化区域参数值列表框
            this.listBox_Diff_GeoPara.Items.Clear();
            this.listBox_Diff_EngiPara.Items.Clear();
            this.listBox_Diff_EcoPara.Items.Clear();

            //清空表示当前选择区域的标签
            //this.lab_TargetEco.Text = "";
            //this.lab_TargetEngi.Text = "";
            //this.lab_TargetGeo.Text = "";

            //标准表示当前选择区域的标签
            //this.lab_TargetEco.Text = "远\r\n景\r\n区";
            //this.lab_TargetEngi.Text = "远\r\n景\r\n区";
            //this.lab_TargetGeo.Text = "远\r\n景\r\n区";

            //添加远景区的地质参数
            foreach (string str in this.listBox_GeoPara.Items)
            {
                if (this.listBox_GeoPara.Items.IndexOf(str) < 5 ||
                    this.listBox_GeoPara.Items.IndexOf(str) == 6 ||
                        this.listBox_GeoPara.Items.IndexOf(str) == 8)
                {
                    this.listBox_Diff_GeoPara.Items.Add(str);
                }
                else if(this.listBox_GeoPara.Items.IndexOf(str) >8)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            ////添加远景区的工程参数
            foreach (string str in this.listBox_EngPara.Items)
            {
                if (this.listBox_EngPara.Items.IndexOf(str) ==0 ||
                    this.listBox_EngPara.Items.IndexOf(str) == 5)
                {
                    this.listBox_Diff_EngiPara.Items.Add(str);
                }
                else if (this.listBox_EngPara.Items.IndexOf(str) > 5)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            //远景区没有经济参数
            this.listBox_Diff_EcoPara.Enabled = false;
            this.listBox_Diff_EcoPara.Visible = false;
            //foreach (string str in this.listBox_EcoPara.Items)
            //{
            //    if (this.listBox_EcoPara.Items.IndexOf(str) == 4)
            //    {
            //        this.listBox_Diff_EcoPara.Items.Add(str);
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
        }

        //核心区
        private void rBtnCore_CheckedChanged(object sender, EventArgs e)
        {
            //清除变化区域参数值列表框
            this.listBox_Diff_GeoPara.Items.Clear();
            this.listBox_Diff_EngiPara.Items.Clear();
            this.listBox_Diff_EcoPara.Items.Clear();

            //非远景区经济参数参与评估
            this.listBox_Diff_EcoPara.Enabled = true;
            this.listBox_Diff_EcoPara.Visible = true;

            //清空表示当前选择区域的标签
            //this.lab_TargetEco.Text = "";
            //this.lab_TargetEngi.Text = "";
            //this.lab_TargetGeo.Text = "";

            //标准表示当前选择区域的标签
           // this.lab_TargetEco.Text = "核\r\n心\r\n区";
            //this.lab_TargetEngi.Text = "核\r\n心\r\n区";
            //this.lab_TargetGeo.Text = "核\r\n心\r\n区";
            //添加核心区的地质参数
            foreach (string str in this.listBox_GeoPara.Items)
            {
                this.listBox_Diff_GeoPara.Items.Add(str);
            }

            ////添加核心区的工程参数
            foreach (string str in this.listBox_EngPara.Items)
            {
                this.listBox_Diff_EngiPara.Items.Add(str);
            }

            //添加核心区的经济参数
            foreach (string str in this.listBox_EcoPara.Items)
            {
                this.listBox_Diff_EcoPara.Items.Add(str);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //核心区为当前选定区域
            if(rBtnCore.Checked ==true)
            {
                //创建核心区矩阵窗体实例
                CoreAreaMatrixFrm coreFrm = new CoreAreaMatrixFrm();

                //显示核心区矩阵窗体
                coreFrm.Show();
            }

            //有利区为当前选定区域
            if (rBtnFavorable.Checked == true)
            {
                //创建有利区矩阵窗体实例
                FavorableAreaMatrixFrm favorableFrm = new FavorableAreaMatrixFrm();

                //显示有利区矩阵窗体
                favorableFrm.Show();
            }

            ////远景区为当前选定区域
            if (rBtnProspective.Checked == true)
            {
                //创建远景区矩阵窗体实例
                ProspectAreaMatrixFrm prospectFrm = new ProspectAreaMatrixFrm();

                //显示远景区矩阵窗体
                prospectFrm.Show();

            }
        }
    }
}
