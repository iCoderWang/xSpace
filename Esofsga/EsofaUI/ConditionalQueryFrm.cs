using System;
using EsofaBLL;
using System.Windows.Forms;
using System.Collections.Generic;
using EsofaModel;
using EsofaCommon;
using System.Collections;
using System.Linq;

namespace EsofaUI
{
    //定义委托，将Main_Frm下的RawDataImport方法传递给ImportingRawDataFrm窗体。
    public delegate void DelViewQuery(string sql,string dgvName); //这儿委托方法的参数标签，对应它所传递的方法的参数标签，这两个签名必须一致。
    public partial class ConditionalQueryFrm : Form
    {
        //定义变量_del用于存储DbDataQuery窗体传过来的方法。
        private DelViewQuery _dvq;
        public string dgvName;
        public ConditionalQueryFrm()
        {
            InitializeComponent();
        }
        //创建带有参数的构造函数
        public ConditionalQueryFrm(DelViewQuery dvq)
        {
            //将委托变量赋值，当ConditionalQueryFrm在 DbDataQuery下被初始化时，函数将被传递到
            //ConditionalQueryFrm下，即 del的值将是被传参的函数名字
            this._dvq = dvq;
            InitializeComponent();
        }
        List<AverageValuesTargetEntity> listAvgTgtEnty = null;
        List<TargetEntity> listTgtEnty = null;
        string sql = "";
        string sqlPlus = "";
        bool veryfied = false;
        //数据库原始数据表对应的列标题
        string[] tgtHeaderTxt = new string[] { "目标区", "盆地/区域 ", "主力层系", "保存条件", "最小_地质资源量 (万亿方)",
            "最大_地质资源量 (万亿方)","最小_富有机质页岩厚度","最大_富有机质页岩厚度","最小_TOC(%)","最大_TOC(%)","干酪根类型",
            "最小_Ro(%)","最大_Ro(%)","有效圈定面积(1-4km深,km^2)","最小_含气量 (m^3/t)","最大_含气量 (m^3/t)",
            "最小_资源丰度(亿m^3/km^2)","最大_资源丰度(亿m^3/km^2)", "最小_孔隙度(%)","最大_孔隙度(%)","构造复杂度",
            "顶底板岩性","最小_埋深范围","最大_埋深范围","最小_压力系数","最大_压力系数","渗透率","裂缝发育度",
            "最小_主应力差异系数","最大_主应力差异系数", "最小_脆性矿物含量","最大_脆性矿物含量","水系","区域勘探度",
            "市场气价","市场需求","交通设施","管网条件","地表地貌" };
        //数据库原始数据表对应的TargetEntity的各个属性值变量
        string[] parasTgtEnty = new string[] { "tgt_Att_Name", "bsn_Att_Name", "tgt_Att_Ps", "tgt_Att_Para_Sc", "tgt_Att_Para_Gr_Min",
            "tgt_Att_Para_Gr_Max","tgt_Geo_Para_TrRoms_Min", "tgt_Geo_Para_TrRoms_Max", "tgt_Geo_Para_Toc_Min",
            "tgt_Geo_Para_Toc_Max", "tgt_Geo_Para_Kt","tgt_Geo_Para_Ro_Min", "tgt_Geo_Para_Ro_Max", "tgt_Geo_Para_Ea",
            "tgt_Geo_Para_Gc_Min", "tgt_Geo_Para_Gc_Max", "tgt_Geo_Para_Rr_Min","tgt_Geo_Para_Rr_Max", "tgt_Geo_Para_Por_Min",
            "tgt_Geo_Para_Por_Max", "tgt_Geo_Para_Scd", "tgt_Geo_Para_Rfc", "tgt_Eng_Para_Dr_Min","tgt_Eng_Para_Dr_Max",
            "tgt_Eng_Para_Pc_Min", "tgt_Eng_Para_Pc_Max", "tgt_Eng_Para_Per", "tgt_Eng_Para_Fdd", "tgt_Eng_Para_Psdc_Min",
            "tgt_Eng_Para_Psdc_Max", " tgt_Eng_Para_Bmc_Min", " tgt_Eng_Para_Bmc_Max", "tgt_Eng_Para_Ds", "tgt_Eng_Para_Led",
            "tgt_Mkt_Para_Gp","tgt_Mkt_Para_Dmd", "tgt_Mkt_Para_Tu", "tgt_Mkt_Para_Pn","tgt_Mkt_Para_Sg" };

        //视图数据对应的列标题
        string[] viewHeaderTxt = new string[] { "目标区", "盆地/区域 ", "主力层系", "保存条件", "平均地质资源量 (万亿方)","平均富有机质页岩厚度",
            "平均TOC(%)","干酪根类型","平均Ro(%)","有效圈定面积(1-4km深,km^2)","平均含气量 (m^3/t)","平均资源丰度(亿m^3/km^2)",
            "平均孔隙度(%)","构造复杂度","顶底板岩性","平均埋深范围","平均压力系数","渗透率","裂缝发育度","平均主应力差异系数",
            "平均脆性矿物含量","水系","区域勘探度","市场气价","市场需求","交通设施","管网条件","地表地貌" };
        //平均值实体对应的各属性变量
        string[] parasAvgTgtEnty = new string[] { "tgt_Att_Name", "bsn_Att_Name", "tgt_Att_Ps", "tgt_Att_Para_Sc", "tgt_Att_Para_Gr_Avg",
            "tgt_Geo_Para_TrRoms_Avg","tgt_Geo_Para_Toc_Avg","tgt_Geo_Para_Kt"," tgt_Geo_Para_Ro_Avg"," tgt_Geo_Para_Ea",
            "tgt_Geo_Para_Gc_Avg","tgt_Geo_Para_Rr_Avg","tgt_Geo_Para_Por_Avg","tgt_Geo_Para_Scd","tgt_Geo_Para_Rfc",
            "tgt_Eng_Para_Dr_Avg","tgt_Eng_Para_Pc_Avg","tgt_Eng_Para_Per","tgt_Eng_Para_Fdd","tgt_Eng_Para_Psdc_Avg",
            "tgt_Eng_Para_Bmc_Avg","tgt_Eng_Para_Ds","tgt_Eng_Para_Led"," tgt_Mkt_Para_Gp","tgt_Mkt_Para_Dmd","tgt_Mkt_Para_Tu",
            "tgt_Mkt_Para_Pn","tgt_Mkt_Para_Sg"};

        //视图数据对应的各属性变量
        string[] parasView = new string[] {"tgt_Name","bsn_Name","tgt_Ps","tgt_Sc","tgt_Gr_Avg","tgt_TrRoms_Avg",
            "tgt_Toc_Avg","tgt_Kt","tgt_Ro_Avg","tgt_Ea","tgt_Gc_Avg","tgt_Rr_Avg","tgt_Por_Avg","tgt_Scd","tgt_Rfc",
            "tgt_Dr_Avg","tgt_Pc_Avg","tgt_Per","tgt_Fdd","tgt_Psdc_Avg","tgt_Bmc_Avg","tgt_Ds","tgt_Led","tgt_Gp",
            "tgt_Dmd","tgt_Tu","tgt_Pn","tgt_Sg" };

        private void ConditionalQueryFrm_Load(object sender, EventArgs e)
        {

            sql = "select * from ";
            RawDataBLL rawDataBLL = new RawDataBLL();
            if (dgvName.Equals("dgvView"))
            {
                sql += "view_target";
                sqlPlus = sql;
                listAvgTgtEnty = rawDataBLL.GetAvg_List(sql);
                foreach (string item in viewHeaderTxt)
                {
                    this.cmbBox_Paras.Items.Add(item);
                }
            }
            else if (dgvName.Equals("dgvTarget"))
            {
                sql += "target";
                sqlPlus = sql;
                listTgtEnty = rawDataBLL.GetList(sql);
                foreach (string item in tgtHeaderTxt)
                {
                    this.cmbBox_Paras.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("  源数据访问错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }  
        }
        private void btn_ValidateMySqlSyntax_Click(object sender, EventArgs e)
        {
            sql = sqlPlus;
            SqlSyntaxValidating ssv = new SqlSyntaxValidating();
            if (dgvName.Equals("dgvView"))
            {
                sql += " where " + txtBox_QuerySql.Text;
            }
            if (dgvName.Equals("dgvTarget"))
            {
                sql += " where " + txtBox_QuerySql.Text;
            }
            bool flag = ssv.ValidateSQL(sql);
            if (flag)
            {
                veryfied = true;
                MessageBox.Show("    语法正确！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                veryfied = false;
                MessageBox.Show("    语法错误！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_QueryCmd_Click(object sender, EventArgs e)
        {
            if (veryfied)
            {
                this.Close();
                _dvq(sql, dgvName);//利用委托将父窗体下的函数（ViewQuery）传递进来。
            }
            else
            {
                MessageBox.Show(" 请先校验条件查询语句的语法。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void cmbBox_Paras_SelectedValueChanged(object sender, EventArgs e)
        {          
            this.listBox_Values.Items.Clear();
            int indexItem = cmbBox_Paras.SelectedIndex;
           // object obj = null;
            List<object> list = new List<object>();
            if (dgvName.Equals("dgvView"))
            {
                //List<object>变量和List<实体类>变量之间的相互转换
                //示例：List<UIData> datalist = null;
                //示例：datalist.ConvertAll<object>(input => input as object);
                //操作： AverageValuesTargetEntity 实体类 转化为 object 类，ConverAll<目的类型>，这个目的类型可以省略
                //list = listAvgTgtEnty.ConvertAll(s=> s as object);
                //操作：  object 类 转化为AverageValuesTargetEntity 实体类，ConverAll<目的类型>，这个目的类型可以省略
                //list.ConvertAll(s=> s as AverageValuesTargetEntity);
                foreach (AverageValuesTargetEntity avte in listAvgTgtEnty)
                {
                    //利用反射机制，将string类型的值转变为变量，变获取 对象变量(avte)中对应的该名称属性的值。
                    Type tp = avte.GetType(); //获取对象(obj) avte 的变量类型为： AverageValuesTargeEntity
                    //对字符串（属性 Property）即 parasAvgTE[indexItem]进行判断，发现属性(Property)的属性(Attribute),
                    //并提供对属性(Property)的访问，比如获取该属性的值 （.GetValue( 对象 (obj))）
                    System.Reflection.PropertyInfo pi = tp.GetProperty(parasAvgTgtEnty[indexItem].Trim());
                    // pi.GetVaue(avte); 语句是获得对象avte的属性 parasAvgTE[indexItem] 所对应的值 
                    //下面的判断语句是为了剔除重复值 
                    if (!listBox_Values.Items.Contains((pi.GetValue(avte)).ToString()))
                    {
                        listBox_Values.Items.Add((pi.GetValue(avte)).ToString());
                    }
                }
            }
            if (dgvName.Equals("dgvTarget"))
            {
                //list = listTgtEnty.ConvertAll(s => s as object);
                foreach (TargetEntity te in listTgtEnty)
                {
                    //利用反射机制，将string类型的值转变为变量，变获取 对象变量(avte)中对应的该名称属性的值。
                    Type tp = te.GetType(); //获取对象(obj) avte 的变量类型为： AverageValuesTargeEntity
                                              //对字符串（属性 Property）即 parasAvgTE[indexItem]进行判断，发现属性(Property)的属性(Attribute),
                                              //并提供对属性(Property)的访问，比如获取该属性的值 （.GetValue( 对象 (obj))）
                    System.Reflection.PropertyInfo pi = tp.GetProperty(parasTgtEnty[indexItem].Trim());
                    // pi.GetVaue(avte); 语句是获得对象avte的属性 parasAvgTE[indexItem] 所对应的值 
                    //下面的判断语句是为了剔除重复值 
                    if (!listBox_Values.Items.Contains((pi.GetValue(te)).ToString()))
                    {
                        listBox_Values.Items.Add((pi.GetValue(te)).ToString());
                    }
                }
            }
        }

        private void btn_ExitCmd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void listBox_Values_DoubleClick(object sender, EventArgs e)
        {
            //int indexFlag = cmbBox_Paras.SelectedIndex;
           if( Single.TryParse (listBox_Values.SelectedItem.ToString(), out float num))
            {
                if (dgvName.Equals("dgvView"))
                {
                    txtBox_QuerySql.Text += parasView[cmbBox_Paras.SelectedIndex] + num + " ";
                }
                if (dgvName.Equals("dgvTarget"))
                {
                    txtBox_QuerySql.Text += parasTgtEnty[cmbBox_Paras.SelectedIndex] + num + " ";
                }
            }
           else
            {
                if (dgvName.Equals("dgvView"))
                {
                    txtBox_QuerySql.Text += parasView[cmbBox_Paras.SelectedIndex] + "=\"" + listBox_Values.SelectedItem + "\" ";
                }
                if (dgvName.Equals("dgvTarget"))
                {
                    txtBox_QuerySql.Text += parasTgtEnty[cmbBox_Paras.SelectedIndex] + "=\"" + listBox_Values.SelectedItem + "\" ";
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_QuerySql.Text = "";
        }

        

        private void txtBox_QuerySql_TextChanged(object sender, EventArgs e)
        {
            txtBox_QuerySql.Text = txtBox_QuerySql.Text;
        }
        private void txtBox_QuerySqlTextInsert(string str)
        {
            //获取当前光标的位置
            int start = txtBox_QuerySql.SelectionStart;
            //利用Insert函数在光标处将字符串str插入到当前光标位置
            txtBox_QuerySql.Text = txtBox_QuerySql.Text.Insert(start, str);
            //计算下一光标的位置，这儿利用的选择函数Select，它带有两个参数，即光标当前位置（start+str.Length)
            //和选择的字符长度,这儿为0
            txtBox_QuerySql.Select(start + str.Length, 0);
            //光标聚焦在当前位置，并不断闪烁。若缺少上一句，则这一句的运行结果是该文本框内所有文本被选中。
            txtBox_QuerySql.Focus();
        }
        private void btn_EqualSign_Click(object sender, EventArgs e)
        {
            txtBox_QuerySqlTextInsert("=");
        }

        private void btn_NotEqualSign_Click(object sender, EventArgs e)
        {
            txtBox_QuerySqlTextInsert("<>");
        }

        private void btn_GreaterSign_Click(object sender, EventArgs e)
        {
            txtBox_QuerySqlTextInsert(">");
        }

        private void btn_SmallerSign_Click(object sender, EventArgs e)
        {
            txtBox_QuerySqlTextInsert("<");
        }

        private void btn_NotKeyWord_Click(object sender, EventArgs e)
        {
            txtBox_QuerySqlTextInsert(" NOT ");
        }

        private void btn_INKeyWord_Click(object sender, EventArgs e)
        {
            txtBox_QuerySqlTextInsert(" IN ( , ) ");
        }

        private void btn_AndKeyWord_Click(object sender, EventArgs e)
        {
            txtBox_QuerySqlTextInsert(" AND ");
        }

        private void btn_BetweenKeyWord_Click(object sender, EventArgs e)
        {
            txtBox_QuerySqlTextInsert(" BETWEEN ");
        }
    }
}
