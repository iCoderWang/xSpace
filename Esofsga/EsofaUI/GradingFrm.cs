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
    //private delegate void DelCloseTabPage();
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
            if (tabControlGrading.SelectedTab == tabPageBasin)
            {
                //远景区为当前选定区域 创建远景区矩阵窗体实例
                ProspectAreaMatrixFrm prospectFrm = new ProspectAreaMatrixFrm();
                //显示远景区矩阵窗体
                prospectFrm.Show();
            }

            if (tabControlGrading.SelectedTab == tabPageBlock)
            {
                //有利区为当前选定区域 创建有利区矩阵窗体实例
                FavorableAreaMatrixFrm favorableFrm = new FavorableAreaMatrixFrm();
                //显示有利区矩阵窗体
                favorableFrm.Show();
            }

            if (tabControlGrading.SelectedTab == tabPageTarget)
            {
                //核心区为当前选定区域 创建核心区矩阵窗体实例
                CoreAreaMatrixFrm coreFrm = new CoreAreaMatrixFrm();
                //显示核心区矩阵窗体
                coreFrm.Show();
            }
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
        string[] parasView = new string[] {"tgt_Name","bsn_Name","tgt_Ps","tgt_Sc","tgt_Gr_Avg","tgt_TrRoms_Avg",
            "tgt_Toc_Avg","tgt_Kt","tgt_Ro_Avg","tgt_Ea","tgt_Gc_Avg","tgt_Rr_Avg","tgt_Por_Avg","tgt_Scd","tgt_Rfc",
            "tgt_Dr_Avg","tgt_Pc_Avg","tgt_Per","tgt_Fdd","tgt_Psdc_Avg","tgt_Bmc_Avg","tgt_Ds","tgt_Led","tgt_Gp",
            "tgt_Dmd","tgt_Tu","tgt_Pn","tgt_Sg" };

        DataTable dt = null;
        private void GradingFrm_Load(object sender, EventArgs e)
        {
            List<AverageValuesTargetEntity> listAvgTgtEnty = null;
            List<string> list_BsnName = new List<string>();
            List<string> list_TgtName = new List<string>();
            TreeNode tN = new TreeNode();
            string otherBsn = "";
            string sql = "select * from view_target";
            RawDataBLL rawDataBLL = new RawDataBLL();
            listAvgTgtEnty = rawDataBLL.GetAvg_List(sql);
            //将所有数据存在dt表内，后面的操作就是从该表中来读取数据
            dt = DataSourceToDataTable.GetListToDataTable(listAvgTgtEnty);
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

            //DataTable 
            //// < summary >
            //// 执行DataTable中的查询返回新的DataTable 
            //// </summary> 
            //// dt 是源数据DataTable 
            //// condition 是查询条件 

            //DataTable newdt = new DataTable();
            //newdt = dt.Clone(); // 克隆dt 的结构，包括所有 dt 架构和约束,并无数据； 
            //DataRow[] rows = dt.Select(conditions); // 从dt 中查询符合条件的记录； 
            //foreach (DataRow row in rows)  // 将查询的结果添加到dt中； 
            //{
            //    newdt.Rows.Add(row.ItemArray);
            //}






            ////this.listBox_Values.Items.Clear();
            ////int indexItem = parasView[1];
            //// object obj = null;
            ////List<object> list = new List<object>();
            ////List<object>变量和List<实体类>变量之间的相互转换
            ////示例：List<UIData> datalist = null;
            ////示例：datalist.ConvertAll<object>(input => input as object);
            ////操作： AverageValuesTargetEntity 实体类 转化为 object 类，ConverAll<目的类型>，这个目的类型可以省略
            ////list = listAvgTgtEnty.ConvertAll(s=> s as object);
            ////操作：  object 类 转化为AverageValuesTargetEntity 实体类，ConverAll<目的类型>，这个目的类型可以省略
            ////list.ConvertAll(s=> s as AverageValuesTargetEntity);
            //foreach (AverageValuesTargetEntity avte in listAvgTgtEnty)
            //{
            //    //利用反射机制，将string类型的值转变为变量，变获取 对象变量(avte)中对应的该名称属性的值。
            //    Type tp = avte.GetType(); //获取对象(obj) avte 的变量类型为： AverageValuesTargeEntity
            //                              //对字符串（属性 Property）即 parasAvgTE[indexItem]进行判断，发现属性(Property)的属性(Attribute),
            //                              //并提供对属性(Property)的访问，比如获取该属性的值 （.GetValue( 对象 (obj))）
            //    System.Reflection.PropertyInfo pi = tp.GetProperty(parasAvgTgtEnty[indexItem].Trim());
            //    // pi.GetVaue(avte); 语句是获得对象avte的属性 parasAvgTE[indexItem] 所对应的值 
            //    //下面的判断语句是为了剔除重复值 
            //    if (!listBox_Values.Items.Contains((pi.GetValue(avte)).ToString()))
            //    {
            //        listBox_Values.Items.Add((pi.GetValue(avte)).ToString());
            //    }
            //}
        }

        private void treeViewGrad_AfterCheck(object sender, TreeViewEventArgs e)
        {
            #region
            //TreeViewNodesCheckState.ParentChildNodeCheck(e);
            #endregion
            TreeViewNodesCheckState.CheckControl(e);
            if (e.Node.Level == 0 && e.Node.Checked == true)
            {
                MessageBox.Show("根节点被选中，数据表中添加所有的数据进去。。。。");
            }
            else if (e.Node.Level == 0 && e.Node.Checked == false)
            {
                MessageBox.Show("根节点被取消，数据表中所有的数据被清除。。。。");
            }
            else if (e.Node.Level == 1 && e.Node.Checked == true)
            {
                MessageBox.Show("一级子节点被选中，数据表中添加所有盆地名称等于这个名字的的数据进去。。。。");
            }
            else if (e.Node.Level == 1 && e.Node.Checked == false)
            {
                MessageBox.Show("一级子节点被取消，数据表中 清除 所有盆地名称等于这个名字的的数据进去。。。。");
            }
            else if (e.Node.Level == 2 && e.Node.Checked == true)
            {
                MessageBox.Show("二级子节点被选中，数据表中添加 区块 名称等于这个名字的的数据进去。。。。");
            }
            else if (e.Node.Level == 2 && e.Node.Checked == false)
            {
                MessageBox.Show("二级子节点被 取消，数据表中清除  区块 名称等于这个名字的的数据进去。。。。");
            }

        }


        private void treeViewGrad_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeViewGrad.SelectedNode.Checked = true;

            //if (e.Node.Level == 0 && e.Node.Checked == true)
            //{
            //    MessageBox.Show("根节点被选中，数据表中添加所有的数据进去。。。。");
            //}
            //else if (e.Node.Level == 0 && e.Node.Checked == false)
            //{
            //    MessageBox.Show("根节点被取消，数据表中所有的数据被清除。。。。");
            //}
            //else if (e.Node.Level == 1 && e.Node.Checked == true)
            //{
            //    MessageBox.Show("一级子节点被选中，数据表中添加所有盆地名称等于这个名字的的数据进去。。。。");
            //}
            //else if (e.Node.Level == 1 && e.Node.Checked == false)
            //{
            //    MessageBox.Show("一级子节点被取消，数据表中 清除 所有盆地名称等于这个名字的的数据进去。。。。");
            //}
            //else if (e.Node.Level == 2 && e.Node.Checked == true)
            //{
            //    MessageBox.Show("二级子节点被选中，数据表中添加 区块 名称等于这个名字的的数据进去。。。。");
            //}
            //else if (e.Node.Level == 2 && e.Node.Checked == false)
            //{
            //    MessageBox.Show("二级子节点被 取消，数据表中清除  区块 名称等于这个名字的的数据进去。。。。");
            //}
            }

        private void CheckTest(TreeViewEventArgs e)
        {

        }
    }
}
