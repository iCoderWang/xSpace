using DevExpress.XtraTab;
using EsofaModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace EsofaUI
{
    //定义委托，将Main_Frm下的RawDataImport方法传递给ImportingRawDataFrm窗体。
    public delegate void DelRawDataImport(string filePath, object objList);

    public partial class ImportingRawDataFrm : Form
    {
        //定义变量_del用于存储Main_Frm窗体传过来的方法。
        private DelRawDataImport _del;
        //创建带有参数的构造函数
        public ImportingRawDataFrm(DelRawDataImport del)
        {
            //将委托变量赋值，当ImportingRawDataFrm在 Main_Frm下被初始化时，函数将被传递到
            //ImportingRawDataFrm下，即 del的值将是被传参的函数名字
            this._del = del;
            InitializeComponent();
        }

       
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            //打开文件的类型，限定在Excel表格式
            openFileDialog1.Filter = "Excel文件| *.xlsx|Excel文件|*.xls";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSourceDataPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //设置文件路径变量
            string filePath = txtSourceDataPath.Text;
            if (filePath != "")
            {
                //对当前窗体进行卸载并释放资源
                Dispose();
                List<TargetEntity> targetEntityList = new List<TargetEntity>();
                object objList = targetEntityList;
                _del(filePath, objList);
                // _del(filePath, targetEntityList.ConvertAll<object>(x => (object)x));
            }
            else
            {
                MessageBox.Show("文件路径不能为空，请选择文件！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
