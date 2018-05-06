using DevExpress.XtraTab;
using EsofaBLL;
using System;
using System.Windows.Forms;


namespace EsofaUI
{
    //定义委托，将Main_Frm下的RawDataImport方法传递给ImportingRawDataFrm窗体。
    public delegate void DelRawDataImport(string filePath);
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
           // ImportingRawDataBLL iRdb = new ImportingRawDataBLL();
            //Main_Form mFrm = new Main_Form();
           // RawDataFrm rawDataFrm = new RawDataFrm();
            //XtraTabPage tabPage = new XtraTabPage();
            //设置文件路径变量
            string filePath = txtSourceDataPath.Text;
            if (filePath != "")
            {
                //对当前窗体进行卸载并释放资源
                Dispose();
               
                //运行委托所传递进来的函数
                _del(filePath);
                //RawDataImport(filePath);
                // rawDataFrm.Show();
               // rawDataFrm.TopLevel = false;
                
               // tabPage.Text = "数据导入预览";
                //tabPage.Controls.Add(rawDataFrm);
                //xtraTabControl1.TabPages.Add(tabPage);
                // mFrm.workAreaTabPageController.TabPages.Add(tabPage);
                 //mFrm.TabPageCreate("数据导入预览", rawDataFrm);
                 //mFrm.LoadList(rawDataFrm,iRdb,filePath);
                //rawDataFrm.Dock =DockStyle.Fill;
               // rawDataFrm.rawDataGridView.DataSource = iRdb.ReadfromExcel(filePath );
                //rawDataFrm.Show();
                //importingRawDataBLL.ReadfromExcel(filePath);
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
