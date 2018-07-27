using EsofaBLL;
using EsofaModel;
using EsofaCommon;
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
        //定义委托
        private DelCloseTabPage _delCloseTabPage;
        public GradingFrm()
        {
            InitializeComponent();
        }

        //重载构造函数，用委托做传递参数
        public GradingFrm(DelCloseTabPage delCloseTabPage)
        {
            this._delCloseTabPage = delCloseTabPage;
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TargetAreaParameters tap = new TargetAreaParameters();
            tap.Show();
            //if (tabControlGrading.SelectedTab == tabPageBasin)
            //{
            //    //远景区为当前选定区域 创建远景区矩阵窗体实例
            //    ProspectAreaMatrixFrm prospectFrm = new ProspectAreaMatrixFrm();
            //    //显示远景区矩阵窗体
            //    prospectFrm.Show();
            //}

            //if (tabControlGrading.SelectedTab == tabPageBlock)
            //{
            //    //有利区为当前选定区域 创建有利区矩阵窗体实例
            //    FavorableAreaMatrixFrm favorableFrm = new FavorableAreaMatrixFrm();
            //    //显示有利区矩阵窗体
            //    favorableFrm.Show();
            //}

            //if (tabControlGrading.SelectedTab == tabPageTarget)
            //{
            //    //核心区为当前选定区域 创建核心区矩阵窗体实例
            //    CoreAreaMatrixFrm coreFrm = new CoreAreaMatrixFrm();
            //    //显示核心区矩阵窗体
            //    coreFrm.Show();
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _delCloseTabPage();
        }
        //视图数据对应的列标题
        string[] viewHeaderTxt = new string[] { "目标区", "盆地/区域 ", "主力层系", "保存条件", "平均地质资源量 (万亿方)","平均富有机质页岩厚度",
            "平均TOC(%)","干酪根类型","平均Ro(%)","有效圈定面积(1-4km深,km^2)","平均含气量 (m^3/t)","平均资源丰度(亿m^3/km^2)",
            "平均孔隙度(%)","构造复杂度","顶底板岩性","平均埋深范围","平均压力系数","渗透率","裂缝发育度","平均主应力差异系数",
            "平均脆性矿物含量","水系","区域勘探度","市场气价","市场需求","交通设施","管网条件","地表地貌" };
        //视图数据对应的各属性变量
        //string[] parasView = new string[] {"tgt_Name","bsn_Name","tgt_Ps","tgt_Sc","tgt_Gr_Avg","tgt_TrRoms_Avg",
        //    "tgt_Toc_Avg","tgt_Kt","tgt_Ro_Avg","tgt_Ea","tgt_Gc_Avg","tgt_Rr_Avg","tgt_Por_Avg","tgt_Scd","tgt_Rfc",
        //    "tgt_Dr_Avg","tgt_Pc_Avg","tgt_Per","tgt_Fdd","tgt_Psdc_Avg","tgt_Bmc_Avg","tgt_Ds","tgt_Led","tgt_Gp",
        //    "tgt_Dmd","tgt_Tu","tgt_Pn","tgt_Sg" };

        DataTable dt = new DataTable();
        List<AverageValuesTargetEntity> listAvgTgtEnty = null;
        string sql = "select * from view_target";
        RawDataBLL rawDataBLL = new RawDataBLL();
        
        private void GradingFrm_Load(object sender, EventArgs e)
        {
            listAvgTgtEnty = rawDataBLL.GetAvg_List(sql);
            dt = DataSourceToDataTable.GetListToDataTable(listAvgTgtEnty);
            List<string> list_BsnName = new List<string>();
            List<string> list_TgtName = new List<string>();
            TreeNode tN = new TreeNode();
            string otherBsn = "";
           
            //将所有数据存在dt表内，后面的操作就是从该表中来读取数据
            //dt = DataSourceToDataTable.GetListToDataTable(listAvgTgtEnty);
            foreach(AverageValuesTargetEntity val in listAvgTgtEnty)
            {
                //下面的判断语句是为了避免有重复值出现，其等同于下面的Linq语句：
                //list_BsnName.Where((x,i) => list_BsnName.FindIndex(z => z.bsn_Att_Name == x.bsn_Att_Name) == i);
                //list_BsnName.Where((x,i) => list_BsnName.FindIndex(z =>z == x) == i);
                if (val.bsn_Att_Name.Trim() == "")
                {
                    otherBsn = "其它";
                }
                if (!list_BsnName.Contains(val.bsn_Att_Name) && !val.bsn_Att_Name.Equals(""))
                {
                    list_BsnName.Add(val.bsn_Att_Name);
                }           
                //list_TgtName不用去判断，因为这个值在数据库中就不会有相重的
                list_TgtName.Add(val.tgt_Att_Name);                
            }
            if (otherBsn.Equals("其它") && !list_BsnName.Exists(x=>x== "其它"))
            {
                list_BsnName.Add("其它");
            }
            foreach(TreeNode var in treeViewGrad.Nodes)
            {
                if (var.Name == "para_Bsn")
                {
                    foreach(string str in list_BsnName)
                    {
                        tN = var.Nodes.Add(str);
                        foreach (AverageValuesTargetEntity avte in listAvgTgtEnty)
                        {
                            if (avte.bsn_Att_Name.Equals(str))
                            {
                                tN.Nodes.Add(avte.tgt_Att_Name);
                            }
                            if(avte.bsn_Att_Name.Equals("") && str.Equals("其它"))
                            {
                                tN.Nodes.Add(avte.tgt_Att_Name);
                            }
                        } 
                    }
                }
            }
        }
        int Counter;
        int tgtSn = 0;
        List<string> lstTgtName = new List<string>();
        TargetListTransfomer tlt = new TargetListTransfomer();
      
        //SetNodeCheckState sncs = new SetNodeCheckState();
        TreeViewNodesCheckStateSetting tvncs = new TreeViewNodesCheckStateSetting();
        List<AverageValuesTargetEntity> lstTgtSelected = new List<AverageValuesTargetEntity>();
        List<AverageValuesBasinEntity> lstBsnSelected = new List<AverageValuesBasinEntity>();
        List<AverageValuesBlockEntity> lstBlkSelected = new List<AverageValuesBlockEntity>();
        private void treeViewGrad_AfterCheck(object sender, TreeViewEventArgs e)
        {
            lstTgtSelected.Clear();
            lstBlkSelected.Clear();
            lstBsnSelected.Clear();
            if (e.Action != TreeViewAction.Unknown)
            {
                tvncs.Set(e,out Counter,out lstTgtName);
            }
            if (Counter != 0)
            {
                foreach(string var in lstTgtName)
                {
                    tgtSn++;
                    for(int i = 0; i < listAvgTgtEnty.Count; i++)
                    {
                        if(var == listAvgTgtEnty[i].tgt_Att_Name)
                        {
                            listAvgTgtEnty[i].tgt_Att_Sn = tgtSn;
                            lstTgtSelected.Add(listAvgTgtEnty[i]);
                            break;
                        }
                    }
                }
                //MessageBox.Show("The value of Counter is : " + str);
                dgvView_Target.DataSource = DataSourceToDataTable.GetListToDataTable(lstTgtSelected);
                dgvView_Basin.DataSource = DataSourceToDataTable.GetListToDataTable(tlt.ToBasin(lstTgtSelected, lstBsnSelected));
                dgvView_Block.DataSource = DataSourceToDataTable.GetListToDataTable(tlt.ToBlock(lstTgtSelected, lstBlkSelected));
                tgtSn = 0;
                //dgvView_Target.Refresh();
            }
        }

    }
}
