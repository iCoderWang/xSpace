using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
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

        public Main_Form(string str)
        {
            InitializeComponent();
            lbl_Status.Text = str;
        }

        

       public static List<TargetEntity> temTgtList = new List<TargetEntity>();

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

        //实例化 UserInfoDataViewFrm 对象，用于操作
        UserInfoDataViewFrm tempFrm = new UserInfoDataViewFrm();

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
        public void TabPage_Close()
        {
            workAreaTabPageController.SelectedTabPage.Dispose();
        }
        public void WorkAreaTabPageController_CloseButtonClick(object sender, EventArgs e)
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
            UserInfoDataViewFrm frmUserInfo = new UserInfoDataViewFrm(TabPage_Close);
            tempFrm = frmUserInfo;
            //Toplevel属性，用于设置窗体在TabPage上的显示层级
            frmUserInfo.TopLevel = false;
            TabPageCreate("注册用户信息表", frmUserInfo);
            LoadList(frmUserInfo);
            frmUserInfo.Show();
        }

        private void sideBar_BtnUserAdd_Click(object sender, EventArgs e)
        {
            //使用委托，通过构造函数，将主窗体的TabPage_Close方法传递给子窗体 UserAddFrm
            UserAddFrm frmUserAdd = new UserAddFrm(TabPage_Close);
            frmUserAdd.TopLevel = false;
            TabPageCreate("注册用户信息表",frmUserAdd);
            frmUserAdd.Show();
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

        private void TabPageCreate(string pageText, Form frm)
        {
            workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(pageText);
            workAreaTabPageController.SelectedTabPage.Controls.Add(frm);
            workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);
        }




        /// <summary>
        /// 重载TabPageCreate方法，实现对RawDataFrm窗体创建Page的功能
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
        /// 重载TabPageCreate方法，实现对GradingFrm窗体创建Page的功能
        /// </summary>
        /// <param name="pageText"></param>
        /// <param name="rawdataFrm"></param>
        public void TabPageCreate(string pageText, GradingFrm gradingFrm)
        {
            DataGridViewColumnEditor dgvCE = new DataGridViewColumnEditor();
            List<AverageValuesTargetEntity> listAV_Te = new List<AverageValuesTargetEntity>();
            List<AverageValuesBlockEntity> listAV_Blk = new List<AverageValuesBlockEntity>();
            List<AverageValuesBasinEntity> listAV_Bsn = new List<AverageValuesBasinEntity>();
            workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(pageText);
            workAreaTabPageController.SelectedTabPage.Controls.Add(gradingFrm);
            workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);

            //设置窗体的宽度和新建Page的宽度相等
            gradingFrm.Width = workAreaTabPageController.Width;

            //设置窗体的高度和新建Page的高度相等
            gradingFrm.Height = workAreaTabPageController.Height;

            //gradingFrm.dgvView_Target.AutoGenerateColumns = true;
            gradingFrm.dgvView_Target.DataSource = listAV_Te;
            gradingFrm.dgvView_Block.DataSource = listAV_Blk;
            gradingFrm.dgvView_Basin.DataSource = listAV_Bsn;       
            dgvCE.ColumHeaderEdit(gradingFrm.dgvView_Target, "dgvView");
            dgvCE.ColumHeaderEdit(gradingFrm.dgvView_Block, "dgvView_Block");
            dgvCE.ColumHeaderEdit(gradingFrm.dgvView_Basin, "dgvView_Basin");


            //设置rawDataGridView的dock属性，使其填充窗体
            gradingFrm.Dock = DockStyle.Fill;

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
        private void menuSub_UserAdd_Click(object sender, EventArgs e)
        {
            sideBar_BtnUserAdd_Click(sender,e);
        }

        private void menuSub_UserDel_Click(object sender, EventArgs e)
        {
            sideBar_BtnUserDel_Click(sender,e);
        }

        private void menuSub_UserPm_Click(object sender, EventArgs e)
        {
            sideBar_BtnAccessChange_Click(sender,e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfoDataViewFrm"></param>
        private void LoadList(UserInfoDataViewFrm userInfoDataViewFrm)
        {
            //创建业务逻辑层对象
            UserInfoBLL userInfoBLL = new UserInfoBLL();
    
            //禁用列表的自动生成
            userInfoDataViewFrm.userDataGridView.AutoGenerateColumns = false;

            //调用方法获取数据，绑定到列表的数据源上
            userInfoDataViewFrm.userDataGridView.DataSource = userInfoBLL.GetList();
        }

        /// <summary>
        /// 重载LoadList方法
        /// </summary>
        /// <param name="rawDataFrm"></param>
        private void LoadList(RawDataFrm rawDataFrm)
        {
            RawDataBLL rawDataBLL = new RawDataBLL();
            rawDataFrm.rawDataGridView.AutoGenerateColumns = true;
            DataGridViewColumnEditor dgvCE = new DataGridViewColumnEditor();
            rawDataFrm.rawDataGridView.Name = "dgvTarget";
            
            rawDataFrm.rawDataGridView.DataSource = rawDataBLL.GetList();
            dgvCE.ColumHeaderEdit(rawDataFrm.rawDataGridView, rawDataFrm.rawDataGridView.Name);
            
        }
        
        /// <summary>
        /// 重载LoadList方法
        /// </summary>
        /// <param name="rawDataFrm"></param>
        /// <param name="sql"></param>
        private void LoadList(DbDataQueryFrm dbDataQueryFrm)
        {
            RawDataBLL rawDataBLL = new RawDataBLL();
            dbDataQueryFrm.dgv_DbQuery.AutoGenerateColumns = true;
            DataGridViewColumnEditor dgvCE = new DataGridViewColumnEditor();
            dbDataQueryFrm.dgv_DbQuery.Name = "dgvTarget";
            dbDataQueryFrm.dgv_DbQuery.DataSource = rawDataBLL.GetList();
            dgvCE.ColumHeaderEdit(dbDataQueryFrm.dgv_DbQuery, dbDataQueryFrm.dgv_DbQuery.Name);
        }

        /// <summary>
        /// 加载RawDataFrm窗体
        /// </summary>
        /// <param name="rawDataFrm"></param>
        /// <param name="ird"></param>
        /// <param name="filePath"></param>
        public int LoadList(RawDataFrm rawDataFrm, ImportingRawDataBLL ird, string filePath, object objList, out string name)
        {
            List<SortedBlocksParas> listSbp = new List<SortedBlocksParas>();
            List<RawData> rawDataList = new List<RawData>();
            List<TargetEntity> targetEntityList = new List<TargetEntity>();
            DataGridViewColumnEditor dgvCE = new DataGridViewColumnEditor();
            name = "";
            int flag = 0;
            if (objList as List<TargetEntity> != null)
            {
                rawDataFrm.rawDataGridView.AutoGenerateColumns = true;
                targetEntityList = ird.ReadTgtfromExcel(filePath);
                if (targetEntityList != null)
                //if(targetEntityList.Count !=0)
                {
                    rawDataFrm.rawDataGridView.Name = "dgvTarget";
                    rawDataFrm.rawDataGridView.DataSource = targetEntityList;
                    dgvCE.ColumHeaderEdit(rawDataFrm.rawDataGridView, rawDataFrm.rawDataGridView.Name);
                    name = "目标区_";
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }
            return flag;
        }

        /// <summary>
        /// 查询数据窗口，数据从数据库获得
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBar_BtnQuery_Click(object sender, EventArgs e)
        {
            DbDataQueryFrm dbDataQueryFrm = new DbDataQueryFrm(TabPage_Close);
            dbDataQueryFrm.TopLevel = false;
            dbDataQueryFrm.tlStripBtn_MultiDel.Visible = false;
            dbDataQueryFrm.tlStripBtn_SingleDel.Visible = false;
            dbDataQueryFrm.tlStripBtn_BlankRowAdd.Visible = false;
            dbDataQueryFrm.tlStripBtn_BlankRowDel.Visible = false;
            dbDataQueryFrm.tlStripBtn_DbUpdate.Visible = false;
            dbDataQueryFrm.tlStripBtn_DataModify.Visible = false;
            dbDataQueryFrm.tlStrip_ChkBox.Visible = false;
            dbDataQueryFrm.toolStripSeparator1.Visible = false;
            dbDataQueryFrm.toolStripSeparator3.Visible = false;
            dbDataQueryFrm.toolStripSeparator4.Visible = false;
            dbDataQueryFrm.toolStripSeparator5.Visible = false;
            XtraTabPage tabPage = new XtraTabPage();
            dbDataQueryFrm.Width = workAreaTabPageController.Width - 5;
            dbDataQueryFrm.Height = workAreaTabPageController.Height;
            dbDataQueryFrm.dgv_DbQuery.Height = dbDataQueryFrm.Height - 62;
            tabPage.Text = "目标区_数据查询";
            workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(tabPage.Text);
            workAreaTabPageController.SelectedTabPage.Controls.Add(dbDataQueryFrm);
            workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);
            dbDataQueryFrm.Show();
            
        }


        //public static List<SortedBlocksParas> listBlockPara = new List<SortedBlocksParas>();
        #region
        //public void BlockGrade( List<RawData> rawDataList,  List<SortedBlocksParas> tempListSbp)
        //{
        //    //定义模糊隶属函数的实例
        //    FuzzyMembershipFunction fMf = new FuzzyMembershipFunction();
        //    SubjectiveGrading sG = new SubjectiveGrading();
        //    //定义求平均值的类实例
        //    AverageValues avgVal = new AverageValues();

        //    //定义 BlockParametersGrade类型的变量
        //    SortedBlocksParas  []tempSbp = new SortedBlocksParas [rawDataList.Count] ;

            
        //    // 定义BlockParametersGrade类型元素的列表变量
        //    tempListSbp = new List<SortedBlocksParas>();

        //    //定义赋值分数变量
        //    double gradeScore;

        //    //定义数值和变量
        //   //double tempSum =0;

        //    //定义数值变量
        //    double values;

        //    //定义临时字符串
        //    //string strTemp;
        //   // rawDataList.IndexOf()
        //   for (int i = 1; i<rawDataList.Count; i++)
        //    {
        //        tempSbp[i] = new SortedBlocksParas();
        //        //区块名称 没有分值
        //        tempSbp[i].para_Tgt = rawDataList[i].para_Blk;

        //        //主力层系 分值
        //        tempSbp[i].para_Ps = rawDataList[i].para_Ps;
        //        tempSbp[i].para_PsScores = sG.Grade(rawDataList[i].para_Ps);

        //        //保存条件 分值
        //        tempSbp[i].para_Sc = rawDataList[i].para_Sc;
        //        tempSbp[i].para_ScScores = sG.Grade(rawDataList[i].para_Sc);

        //        //构造复杂度 分值
        //        tempSbp[i].para_Scd = rawDataList[i].para_Scd;
        //        tempSbp[i].para_ScdScores = 80;

        //        //裂缝发育度 分值
        //        tempSbp[i].para_Fdd = rawDataList[i].para_Fdd;
        //        tempSbp[i].para_FddScores = sG.Grade(rawDataList[i].para_Fdd);

        //        //地质条件
        //        //对富含有机质页岩厚度的平均值进行增大型隶属函数求值
        //        if (rawDataList[i].para_StromAt != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_StromAt.Trim());
        //            gradeScore = fMf.FuzzyLarge(1.6, 15, values);
        //            tempSbp[i].para_StromAt = rawDataList[i].para_StromAt;
        //            tempSbp[i].para_StromAtScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_StromAt = rawDataList[i].para_StromAt;
        //            tempSbp[i].para_StromAtScores = 0;
        //        }

        //        //对Toc 的平均值进行增大型隶属函数求值
        //        if (rawDataList[i].para_Toc != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_Toc.Trim());
        //            gradeScore = fMf.FuzzyLarge(1.6, 2, values);
        //            tempSbp[i].para_Toc = rawDataList[i].para_Toc;
        //            tempSbp[i].para_TocScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_Toc = rawDataList[i].para_Toc;
        //            tempSbp[i].para_TocScores = 0;
        //        }

        //        //对Ro 的平均值进行高斯型隶属函数求值
        //        if (rawDataList[i].para_Ro != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_Ro.Trim());
        //            gradeScore = fMf.FuzzyGussian(values);
        //            tempSbp[i].para_Ro = rawDataList[i].para_Ro;
        //            tempSbp[i].para_RoScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_Ro = rawDataList[i].para_Ro;
        //            tempSbp[i].para_RoScores = 0;
        //        }

        //        //对Ea 的平均值进行增大型隶属函数求值
        //        if (rawDataList[i].para_Ea != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_Ea.Trim());
        //            gradeScore = fMf.FuzzyLarge(1.2, 200, values);
        //            tempSbp[i].para_Ea = rawDataList[i].para_Ea;
        //            tempSbp[i].para_EaScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_Ea = rawDataList[i].para_Ea;
        //            tempSbp[i].para_EaScores = 0;
        //        }

        //        //对Gc 的平均值进行增大型隶属函数求值
        //        if (rawDataList[i].para_Gc != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_Gc.Trim());
        //            gradeScore = fMf.FuzzyLarge(1.6, 2, values);
        //            tempSbp[i].para_Gc = rawDataList[i].para_Gc;
        //            tempSbp[i].para_GcScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_Gc = rawDataList[i].para_Gc;
        //            tempSbp[i].para_GcScores = 0;
        //        }

        //        //对Rr 的平均值进行增大型隶属函数求值
        //        if (rawDataList[i].para_Rr != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_Rr.Trim());
        //            gradeScore = fMf.FuzzyLarge(1, 0.5, values);
        //            tempSbp[i].para_Rr = rawDataList[i].para_Rr;
        //            tempSbp[i].para_RrScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_Rr = rawDataList[i].para_Rr;
        //            tempSbp[i].para_RrScores = 0;
        //        }

        //        //对Por 的平均值进行增大型隶属函数求值
        //        if (rawDataList[i].para_Por != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_Por.Trim());
        //            gradeScore = fMf.FuzzyLarge(1.2, 2, values);
        //            tempSbp[i].para_Por = rawDataList[i].para_Por;
        //            tempSbp[i].para_PorScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_Por = rawDataList[i].para_Por;
        //            tempSbp[i].para_PorScores = 0;
        //        }

        //        //工程条件
        //        //埋深先计算平均值，然后利用高斯型隶属函数赋分
        //        if (rawDataList[i].para_Dr != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_Dr);
        //            gradeScore = fMf.FuzzyGussian(values);
        //            tempSbp[i].para_Ad = rawDataList[i].para_Dr;
        //            tempSbp[i].para_AdScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_Ad = rawDataList[i].para_Dr;
        //            tempSbp[i].para_AdScores = 0;
        //        }
               
        //        //对Pc 压力系数 的平均值进行增大型隶属函数求值
        //        if (rawDataList[i].para_Pf != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_Pf.Trim());
        //            gradeScore = fMf.FuzzyLarge(6, 1, values);
        //            tempSbp[i].para_Pc = rawDataList[i].para_Pf;
        //            tempSbp[i].para_PcScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_Pc = rawDataList[i].para_Pf;
        //            tempSbp[i].para_PcScores = 0;
        //        }

        //        //对Psdf 主应力差异 的平均值进行增大型隶属函数求值
        //        if (rawDataList[i].para_Psdf != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_Psdf.Trim());
        //            gradeScore = fMf.FuzzySmall(2.15, 0.5, values);
        //            tempSbp[i].para_Psdf = rawDataList[i].para_Psdf;
        //            tempSbp[i].para_PsdfScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_Psdf = rawDataList[i].para_Psdf;
        //            tempSbp[i].para_PsdfScores = 0;
        //        }

        //        //对Bmc  的平均值进行增大型隶属函数求值
        //        if (rawDataList[i].para_Bmc != "")
        //        {
        //            values = avgVal.Calculate(rawDataList[i].para_Bmc.Trim());
        //            gradeScore = fMf.FuzzyLarge(2.15, 30, values);
        //            tempSbp[i].para_Bmc = rawDataList[i].para_Bmc;
        //            tempSbp[i].para_BmcScores = gradeScore;
        //        }
        //        else
        //        {
        //            tempSbp[i].para_Bmc = rawDataList[i].para_Bmc;
        //            tempSbp[i].para_BmcScores = 0;
        //        }
        //        tempListSbp.Add(tempSbp[i]);
        //    }
        //    listBlockPara = tempListSbp;
        //}
        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBar_BtnImport_Click(object sender, EventArgs e)
        {
            //带参数的构造函数，以方法名 RawDataImport为实参，从而实现了委托的传值
            //RawData rawData = new RawData();
            //使用委托，通过构造函数，将主窗体的 RawDataImport 方法 传递给子窗体 ImportingRawDataFrm
            ImportingRawDataFrm importingRawDataFrm = new ImportingRawDataFrm(RawDataImport); // 实现委托，将ImportingRawDataFrm窗体和Main_Frm窗体实现传值
            importingRawDataFrm.Show();
        }
        /// <summary>
        /// RawDataImport方法,将数据从Excel表格读取到RawDataFrm中的DataGridView中
        /// </summary>
        /// <param name="filePath"></param>
        private void RawDataImport(string filePath, object objList)
        {
            string areaName = "";
            int flag;
            ImportingRawDataBLL iRdb = new ImportingRawDataBLL();

            //RawDataFrm 构造方法，以TabPage_Close方法为实参，从而实现了委托中的关闭页面的操作
            //使用委托，通过构造函数，将主窗体的TabPage_Close方法传递给子窗体 RawDataFrm
            RawDataFrm rawDataFrm = new RawDataFrm(TabPage_Close);//实现关闭页面的委托

            rawDataFrm.TopLevel = false;
            XtraTabPage tabPage = new XtraTabPage();
            rawDataFrm.Width = workAreaTabPageController.Width-5;
            rawDataFrm.Height = workAreaTabPageController.Height;
            rawDataFrm.rawDataGridView.Height = rawDataFrm.Height - 80;
            rawDataFrm.btnImport.Location = new System.Drawing.Point(rawDataFrm.Width -260,rawDataFrm.Height -70);
            rawDataFrm.btnCancle.Location = new System.Drawing.Point(rawDataFrm.Width - 160, rawDataFrm.Height - 70);
            flag = LoadList(rawDataFrm, iRdb, filePath, objList, out areaName);
            if (flag != 0)
            {
                tabPage.Text = areaName + "数据导入预览";
                workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(tabPage.Text);
                workAreaTabPageController.SelectedTabPage.Controls.Add(rawDataFrm);
                workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);
                rawDataFrm.Show();
            }            

        }

       
        /// <summary>
        /// 加载AHP分析窗体，主要内容是对数据的选择性加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBar_BtnAHP_Click(object sender, EventArgs e)
        {
            //使用含有委托形参的构造函数，创建GradingFrm窗体，从而实现关闭主界面上TabPage的方法传递。
            GradingFrm gradingFrm = new GradingFrm(TabPage_Close); //实现委托传递关闭当前TabPage的方法
            gradingFrm.TopLevel = false;
            TabPageCreate("层次分析法",gradingFrm);
            gradingFrm.Show();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBar_BtnUserDel_Click(object sender, EventArgs e)
        {
            SideBar_BtnUsersList_Click(sideBar_BtnUsersList,e);
            tempFrm.btnUserDel.Visible = true;
            tempFrm = null;
        }

        private void sideBar_BtnAccessChange_Click(object sender, EventArgs e)
        {
            //调用用户信息预览的功能模块
            SideBar_BtnUsersList_Click(sideBar_BtnUsersList, e);
            //关闭当前窗体上的DataGridView多行选择功能
            tempFrm.userDataGridView.MultiSelect = false;
            tempFrm.btnUpdate.Visible = true;
            tempFrm = null;
        }

        private void menuSub_DataIm_Click(object sender, EventArgs e)
        {
            sideBar_BtnImport_Click(sideBar_BtnImport, e);
        }

        private void menuSub_DataQu_Click(object sender, EventArgs e)
        {
            sideBar_BtnQuery_Click(sideBar_BtnQuery, e);
        }

        private void toolStripBtn_DataImport_Click(object sender, EventArgs e)
        {
            sideBar_BtnImport_Click(sideBar_BtnImport, e);
        }

        private void menuSub_DataBr_Click(object sender, EventArgs e)
        {
            sideBar_BtnBrowse_Click(sideBar_BtnBrowse,e);
        }

        private void sideBar_BtnModify_Click(object sender, EventArgs e)
        {
            DbDataQueryFrm dbDataQueryFrm = new DbDataQueryFrm(TabPage_Close);
            //lbl_Status.Text = "选中行数："+ (dbDataQueryFrm.rowCounter).ToString();
            dbDataQueryFrm.tlStrip_ChkBox.Enabled = true;
            dbDataQueryFrm.tlStrip_ChkBox.Visible = true;
            dbDataQueryFrm.tlStripBtn_BlankRowAdd.Visible = false;
            dbDataQueryFrm.tlStripBtn_BlankRowDel.Visible = false;
            dbDataQueryFrm.tlStripBtn_DataModify.Visible = false;
            dbDataQueryFrm.toolStripSeparator3.Visible = false;
            //dbDataQueryFrm.tlStrip_DbQueryAll.Margin = new Padding(100, 3, 1, 3);
            dbDataQueryFrm.TopLevel = false;
            XtraTabPage tabPage = new XtraTabPage();
            dbDataQueryFrm.Width = workAreaTabPageController.Width - 5;
            dbDataQueryFrm.Height = workAreaTabPageController.Height;
            //dbDataQueryFrm.dgv_DbQuery.Height = dbDataQueryFrm.Height;
            dbDataQueryFrm.dgv_DbQuery.Height = dbDataQueryFrm.Height - 62;
            tabPage.Text = "目标区_数据编辑";
            workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(tabPage.Text);
            workAreaTabPageController.SelectedTabPage.Controls.Add(dbDataQueryFrm);
            workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);
            dbDataQueryFrm.Show();
        }

        private void menuSub_DataMo_Click(object sender, EventArgs e)
        {
            sideBar_BtnModify_Click(sideBar_BtnModify,e);
        }

        private void toolStripBtn_DataModify_Click(object sender, EventArgs e)
        {
            sideBar_BtnModify_Click(sideBar_BtnModify, e);
        }

        private void sideBar_BtnBrowse_Click(object sender, EventArgs e)
        {
            RawDataFrm rawDataFrm = new RawDataFrm(TabPage_Close);
            rawDataFrm.TopLevel = false;
            XtraTabPage tabPage = new XtraTabPage();
            rawDataFrm.Width = workAreaTabPageController.Width - 5;
            rawDataFrm.Height = workAreaTabPageController.Height;
            rawDataFrm.rawDataGridView.Height = rawDataFrm.Height - 80;
            rawDataFrm.btnImport.Visible = false;
            rawDataFrm.btnCancle.Location = new System.Drawing.Point(rawDataFrm.Width - 160, rawDataFrm.Height - 70);
            LoadList(rawDataFrm);
            tabPage.Text = "目标区_数据浏览";
            workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(tabPage.Text);
            workAreaTabPageController.SelectedTabPage.Controls.Add(rawDataFrm);
            workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);
            //workAreaTabPageController.TabPages.Remove (x=>x)
            rawDataFrm.Show();

        }

        private void sideBar_BtnAddData_Click(object sender, EventArgs e)
        {
            DbDataQueryFrm dbDataQueryFrm = new DbDataQueryFrm(TabPage_Close);
            //lbl_Status.Text = "选中行数："+ (dbDataQueryFrm.rowCounter).ToString();
            dbDataQueryFrm.tlStrip_ChkBox.Enabled = false;
            dbDataQueryFrm.tlStrip_ChkBox.Visible = false;
            dbDataQueryFrm.tlStrip_DbQueryAll.Enabled = false;
            dbDataQueryFrm.tlStrip_DbQueryAll.Visible = false;
            dbDataQueryFrm.toolStripSeparator5.Visible = false;
            dbDataQueryFrm.toolStripSeparator2.Visible = false;
            dbDataQueryFrm.tlStrip_DbQueryBy.Enabled = false;
            dbDataQueryFrm.tlStrip_DbQueryBy.Visible = false;
            dbDataQueryFrm.tlStripBtn_DbUpdate.Visible = false;
            dbDataQueryFrm.tlStripBtn_MultiDel.Enabled = true;
            dbDataQueryFrm.tlStripBtn_SingleDel.Enabled = true;
            dbDataQueryFrm.tlStripBtn_BlankRowAdd.Enabled = true;
            dbDataQueryFrm.tlStripBtn_BlankRowDel.Visible = false;
            
            //dbDataQueryFrm.tlStrip_DbQueryAll.Margin = new Padding(3, 3, 1, 3);
            dbDataQueryFrm.TopLevel = false;
            XtraTabPage tabPage = new XtraTabPage();
            dbDataQueryFrm.Width = workAreaTabPageController.Width - 5;
            dbDataQueryFrm.Height = workAreaTabPageController.Height;
            //dbDataQueryFrm.dgv_DbQuery.Height = dbDataQueryFrm.Height;
            dbDataQueryFrm.dgv_DbQuery.Height = dbDataQueryFrm.Height - 62;
            tabPage.Text = "目标区_数据录入";
            workAreaTabPageController.SelectedTabPage = workAreaTabPageController.TabPages.Add(tabPage.Text);
            workAreaTabPageController.SelectedTabPage.Controls.Add(dbDataQueryFrm);
            workAreaTabPageController.TabPages.Add(workAreaTabPageController.SelectedTabPage);
            dbDataQueryFrm.Show();
        }
    }
}
