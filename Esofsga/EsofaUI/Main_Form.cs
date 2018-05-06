﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraTab;
using EsofaBLL;
using EsofaModel;
using EsofaCommon;
using System.Collections;

namespace EsofaUI
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        public static List<SortedBlocksParas> listBlockPara = new List<SortedBlocksParas>();
      
        /** 
         * 重写窗体关闭按钮的方法（事件）
         *将加载窗体（真正的主窗体）的关闭功能，即释放所有被占用资源的功能
         * 赋给Main_Form上的关闭按钮，当该按钮被点击时，关闭当前窗体，以及
         * 被隐藏的主加载窗体，从而用于释放所有被占用资源
        */
        
       
        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Environment.Exit(0);
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*
         * 重写xtrTgabControl 控件的关闭按钮功能
         * 当关闭按钮被点击时，用于释放当前tabPage页的资源
         */

        /*
         * 调用窗体的关闭按钮功能方法，用于关闭当前窗体，及被隐藏的主加载窗体
         * 用于释放程序所占用的所有资源
         */

        private void MenuSub_Close_Click(object sender, EventArgs e)
        {
            //关闭主窗体
            Main_Form_FormClosed(menuSub_Close, null);
        }

        //实例化About_Box对象，用于操作
        About_Box aboutBox = new About_Box();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuSub_About_Click(object sender, EventArgs e)
        {
            //关于界面显示
            aboutBox.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SideBar_BtnAbout_Click(object sender, EventArgs e)
        {
            //显示关于界面
            MenuSub_About_Click(sideBar_BtnAbout, null);
            //aboutBox.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        //关闭选中的页面
        private void TabPage_Close()
        {
            workAreaTabPageController.SelectedTabPage.Dispose();
        }
        private void WorkAreaTabPageController_CloseButtonClick(object sender, EventArgs e)
        {
            workAreaTabPageController.SelectedTabPage.Dispose();
            int tabPageCounts = workAreaTabPageController.TabPages.Count;
            if (tabPageCounts != 0)
            {
                workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages[tabPageCounts - 1];
            }
            //workAreaTabPageController.TabPages.Add("New page added");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SideBar_BtnUsersList_Click(object sender, EventArgs e)
        {
            //点击“用户浏览”产生新的用户TabPage，并在该Page上显示后台数据库中
            //所有在册用户的信息
            //XtraTabPage  newPage = workAreaTabPageController.TabPages.Add("注册用户信息表");
            // workAreaTabPageController.SelectedTabPage = newPage;
            UserInfoDataViewFrm frmUserInfo = new UserInfoDataViewFrm();
            frmUserInfo.TopLevel = false;
            TabPageCreate("注册用户信息表", frmUserInfo);
            LoadList(frmUserInfo);
            frmUserInfo.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageText"></param>
        /// <param name="frmUserInfo"></param>
        // 创建新的TabPage页面的方法，便于其它功能的调用。
        private void TabPageCreate(string pageText, UserInfoDataViewFrm frmUserInfo)
        {
            //TabPage tab = new TabPage();
           // UserInfoDataView userInfoFrm = new UserInfoDataView();

            workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(pageText);
            workAreaTabPageController.SelectedTabPage.Controls.Add(frmUserInfo);
            workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);
           
            //LoadList(frmUserInfo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageText"></param>
        /// <param name="rawdataFrm"></param>
        //重载TabPageCreate方法
        public void TabPageCreate(string pageText,RawDataFrm rawdataFrm)
        {
            
            workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(pageText);
            workAreaTabPageController.SelectedTabPage.Controls.Add(rawdataFrm);
            workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);
            
            //设置窗体的宽度和新建Page的宽度相等
            rawdataFrm.Width = workAreaTabPageController.Width;

            //设置窗体的高度和新建Page的高度相等
            rawdataFrm.Height = workAreaTabPageController.Height;

            //将窗体上的两个按钮禁止显示
            rawdataFrm.btnCancle.Visible = false;
            rawdataFrm.btnImport.Visible = false;

            //设置rawDataGridView的dock属性，使其填充窗体
            rawdataFrm.rawDataGridView.Dock = DockStyle.Fill;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuSub_UserQuery_Click(object sender, EventArgs e)
        {
            SideBar_BtnUsersList_Click( sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfoDataViewFrm"></param>
        private void LoadList(UserInfoDataViewFrm userInfoDataViewFrm)
        {
            //创建业务逻辑层对象
            UserInfoBLL userInfoBLL = new UserInfoBLL();

            //创建数据表窗体的对象
            //UserInfoDataViewFrm userInfoDataViewFrm = new UserInfoDataViewFrm();

            //禁用列表的自动生成
            userInfoDataViewFrm.userDataGridView.AutoGenerateColumns = false;

            //调用方法获取数据，绑定到列表的数据源上
            userInfoDataViewFrm.userDataGridView.DataSource = userInfoBLL.GetList();
        }

        //重载LoadList方法
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rawDataFrm"></param>
        private void LoadList(RawDataFrm rawDataFrm)
        {
            RawDataBLL rawDataBLL = new RawDataBLL();
            rawDataFrm.rawDataGridView.AutoGenerateColumns = false;
            rawDataFrm.rawDataGridView.DataSource = rawDataBLL.GetList();
        }
        //重载LoadList方法

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBar_BtnQuery_Click(object sender, EventArgs e)
        {
            RawDataFrm rawDataFrm = new RawDataFrm();
            // rawDataFrm.Show();
            rawDataFrm.TopLevel = false;
            TabPageCreate("数据浏览",rawDataFrm);
            LoadList(rawDataFrm);
            //rawdataFrm.Dock =DockStyle.Fill;
            rawDataFrm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rawDataFrm"></param>
        /// <param name="ird"></param>
        /// <param name="filePath"></param>
        public void LoadList(RawDataFrm rawDataFrm,ImportingRawDataBLL ird,string filePath)
        {
            //RawDataBLL rawDataBLL = new RawDataBLL();
           List<SortedBlocksParas> listSbp = new List<SortedBlocksParas>();
            List<RawData> rawDataList = new List<RawData>();
            rawDataFrm.rawDataGridView.AutoGenerateColumns = false;
            rawDataList = ird.ReadfromExcel(filePath);
            BlockGrade(rawDataList, listSbp);
            //if (rawDataFrm.rawDataGridView.Columns[0].HeaderText != rawDataList[0].para_Blk)
            //{
            //    rawDataFrm.rawDataGridView.HeaderCell.DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 0, 0);
            //    // rawDataFrm.rawDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 0, 0);
            //}
            rawDataFrm.rawDataGridView.DataSource = ird.ReadfromExcel(filePath);
            
        }

        public void BlockGrade( List<RawData> rawDataList,  List<SortedBlocksParas> tempListSbp)
        {
            //定义模糊隶属函数的实例
            FuzzyMembershipFunction fMf = new FuzzyMembershipFunction();
            SubjectiveGrading sG = new SubjectiveGrading();
            //定义求平均值的类实例
            AverageValues avgVal = new AverageValues();

            //定义 BlockParametersGrade类型的变量
            SortedBlocksParas  []tempSbp = new SortedBlocksParas [rawDataList.Count] ;

            
            // 定义BlockParametersGrade类型元素的列表变量
            tempListSbp = new List<SortedBlocksParas>();

            //定义赋值分数变量
            double gradeScore;

            //定义数值和变量
           //double tempSum =0;

            //定义数值变量
            double values;

            //定义临时字符串
            string strTemp;
           // rawDataList.IndexOf()
           for (int i = 1; i<rawDataList.Count; i++)
            {
                tempSbp[i] = new SortedBlocksParas();
                //区块名称 没有分值
                tempSbp[i].para_Blk = rawDataList[i].para_Blk;

                //主力层系 分值
                tempSbp[i].para_Ps = rawDataList[i].para_Ps;
                tempSbp[i].para_PsScores = sG.Grade(rawDataList[i].para_Ps);

                //保存条件 分值
                tempSbp[i].para_Sc = rawDataList[i].para_Sc;
                tempSbp[i].para_ScScores = sG.Grade(rawDataList[i].para_Sc);

                //构造复杂度 分值
                tempSbp[i].para_Scd = rawDataList[i].para_Scd;
                tempSbp[i].para_ScdScores = 80;

                //裂缝发育度 分值
                tempSbp[i].para_Fdd = rawDataList[i].para_Fdd;
                tempSbp[i].para_FddScores = sG.Grade(rawDataList[i].para_Fdd);

                //地质条件
                //对富含有机质页岩厚度的平均值进行增大型隶属函数求值
                if (rawDataList[i].para_StromAt != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_StromAt.Trim());
                    gradeScore = fMf.FuzzyLarge(1.6, 15, values);
                    tempSbp[i].para_StromAt = rawDataList[i].para_StromAt;
                    tempSbp[i].para_StromAtScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_StromAt = rawDataList[i].para_StromAt;
                    tempSbp[i].para_StromAtScores = 0;
                }

                //对Toc 的平均值进行增大型隶属函数求值
                if (rawDataList[i].para_Toc != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_Toc.Trim());
                    gradeScore = fMf.FuzzyLarge(1.6, 2, values);
                    tempSbp[i].para_Toc = rawDataList[i].para_Toc;
                    tempSbp[i].para_TocScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_Toc = rawDataList[i].para_Toc;
                    tempSbp[i].para_TocScores = 0;
                }

                //对Ro 的平均值进行高斯型隶属函数求值
                if (rawDataList[i].para_Ro != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_Ro.Trim());
                    gradeScore = fMf.FuzzyGussian(values);
                    tempSbp[i].para_Ro = rawDataList[i].para_Ro;
                    tempSbp[i].para_RoScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_Ro = rawDataList[i].para_Ro;
                    tempSbp[i].para_RoScores = 0;
                }

                //对Ea 的平均值进行增大型隶属函数求值
                if (rawDataList[i].para_Ea != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_Ea.Trim());
                    gradeScore = fMf.FuzzyLarge(1.2, 200, values);
                    tempSbp[i].para_Ea = rawDataList[i].para_Ea;
                    tempSbp[i].para_EaScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_Ea = rawDataList[i].para_Ea;
                    tempSbp[i].para_EaScores = 0;
                }

                //对Gc 的平均值进行增大型隶属函数求值
                if (rawDataList[i].para_Gc != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_Gc.Trim());
                    gradeScore = fMf.FuzzyLarge(1.6, 2, values);
                    tempSbp[i].para_Gc = rawDataList[i].para_Gc;
                    tempSbp[i].para_GcScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_Gc = rawDataList[i].para_Gc;
                    tempSbp[i].para_GcScores = 0;
                }

                //对Rr 的平均值进行增大型隶属函数求值
                if (rawDataList[i].para_Rr != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_Rr.Trim());
                    gradeScore = fMf.FuzzyLarge(1, 0.5, values);
                    tempSbp[i].para_Rr = rawDataList[i].para_Rr;
                    tempSbp[i].para_RrScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_Rr = rawDataList[i].para_Rr;
                    tempSbp[i].para_RrScores = 0;
                }

                //对Por 的平均值进行增大型隶属函数求值
                if (rawDataList[i].para_Por != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_Por.Trim());
                    gradeScore = fMf.FuzzyLarge(1.2, 2, values);
                    tempSbp[i].para_Por = rawDataList[i].para_Por;
                    tempSbp[i].para_PorScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_Por = rawDataList[i].para_Por;
                    tempSbp[i].para_PorScores = 0;
                }

                //工程条件
                //埋深先计算平均值，然后利用高斯型隶属函数赋分
                if (rawDataList[i].para_Dr != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_Dr);
                    gradeScore = fMf.FuzzyGussian(values);
                    tempSbp[i].para_Ad = rawDataList[i].para_Dr;
                    tempSbp[i].para_AdScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_Ad = rawDataList[i].para_Dr;
                    tempSbp[i].para_AdScores = 0;
                }
               
                //对Pc 压力系数 的平均值进行增大型隶属函数求值
                if (rawDataList[i].para_Pf != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_Pf.Trim());
                    gradeScore = fMf.FuzzyLarge(6, 1, values);
                    tempSbp[i].para_Pc = rawDataList[i].para_Pf;
                    tempSbp[i].para_PcScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_Pc = rawDataList[i].para_Pf;
                    tempSbp[i].para_PcScores = 0;
                }

                //对Psdf 主应力差异 的平均值进行增大型隶属函数求值
                if (rawDataList[i].para_Psdf != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_Psdf.Trim());
                    gradeScore = fMf.FuzzySmall(2.15, 0.5, values);
                    tempSbp[i].para_Psdf = rawDataList[i].para_Psdf;
                    tempSbp[i].para_PsdfScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_Psdf = rawDataList[i].para_Psdf;
                    tempSbp[i].para_PsdfScores = 0;
                }

                //对Bmc  的平均值进行增大型隶属函数求值
                if (rawDataList[i].para_Bmc != "")
                {
                    values = avgVal.Calculate(rawDataList[i].para_Bmc.Trim());
                    gradeScore = fMf.FuzzyLarge(2.15, 30, values);
                    tempSbp[i].para_Bmc = rawDataList[i].para_Bmc;
                    tempSbp[i].para_BmcScores = gradeScore;
                }
                else
                {
                    tempSbp[i].para_Bmc = rawDataList[i].para_Bmc;
                    tempSbp[i].para_BmcScores = 0;
                }
                tempListSbp.Add(tempSbp[i]);
            }
            listBlockPara = tempListSbp;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBar_BtnImport_Click(object sender, EventArgs e)
        {
            //
            ImportingRawDataFrm importingRawDataFrm = new ImportingRawDataFrm(RawDataImport);
            //importingRawDataFrm.TopLevel = false;
            //XtraTabPage xtraTabPage = new XtraTabPage();
            //xtraTabPage.Text = "数据导入";
            ////xtraTabPage.Controls.Add(importingRawDataFrm);
            ////xtraTabPage.Select();
            ////workAreaTabPageController.TabPages.Add(xtraTabPage);
            //workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(xtraTabPage.Text);
            //workAreaTabPageController.SelectedTabPage.Controls.Add(importingRawDataFrm);
            //workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);
            importingRawDataFrm.Show();
            //RawDataImport(@"C:\Users\wangg\Desktop\南方海相页岩18个有利区块评价参数表 - Copy.xlsx");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        private void RawDataImport(string filePath)
        {
            ImportingRawDataBLL iRdb = new ImportingRawDataBLL();
            RawDataFrm rawDataFrm = new RawDataFrm(TabPage_Close);
            rawDataFrm.TopLevel = false;
            XtraTabPage tabPage = new XtraTabPage();
            tabPage.Text = "数据导入预览";
            rawDataFrm.Width = workAreaTabPageController.Width-5;
            //rawDataFrm.rawDataGridView.Height = rawDataFrm.Height - 100;
            rawDataFrm.Height = workAreaTabPageController.Height;
            rawDataFrm.rawDataGridView.Height = rawDataFrm.Height - 80;
            rawDataFrm.btnImport.Location = new System.Drawing.Point(rawDataFrm.Width -260,rawDataFrm.Height -70);
            rawDataFrm.btnCancle.Location = new System.Drawing.Point(rawDataFrm.Width - 160, rawDataFrm.Height - 70);
            //rawDataFrm.rawDataGridView.Height = rawDataFrm.Height;
            workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(tabPage.Text);
            workAreaTabPageController.SelectedTabPage.Controls.Add(rawDataFrm);
            workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);
            
            //TabPageCreate("数据导入预览", rawDataFrm);
            LoadList(rawDataFrm, iRdb, filePath);
            rawDataFrm.Show();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBar_BtnAHP_Click(object sender, EventArgs e)
        {
            TargetAreaParameters tAreaPara = new TargetAreaParameters();
            tAreaPara.Show();
        }
    }
}
