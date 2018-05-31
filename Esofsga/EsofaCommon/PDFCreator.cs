using System;
using System.IO;
using iTextSharp.text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace EsofaCommon
{
    public partial class PDFCreator
    {
        public void Create(string str)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF 文件 (*.PDF)|*.PDF";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //开始创建PDF文档，首先声明一个Document对象
                Document doc = new Document(PageSize.A4, 45, 45, 45, 45);
                try
                {
                    string filePath = saveFileDialog.FileName;
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();
                    BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\simsun.ttc,0",
                        BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    //设置文档字体样式
                    //标题字体样式
                    Font fontTitle = new Font(baseFont, 26);
                    //主要内容字体样式 
                    Font fontContent = new Font(baseFont, 16);
                    //创建新的段落
                    Paragraph titleParText = new Paragraph("页岩" + str + "评价报告", fontTitle);
                    //设置居中
                    titleParText.Alignment = Rectangle.ALIGN_CENTER;
                    //添加内容至PDF文档中
                    doc.Add(titleParText);
                    string strContent = "\n核心区块：\n\n。。。。。\n\n 。。。。。\n\n参数矩阵一致性因子：  \n\n。。。。。" +
                        "\n\n\n\n...。。。。。\n\n排序结果：\n\n。。。。。\n\n。。。。。\n\n\n\n\n\n。。。。\n\n等级分区图：\n\n。。。。";
                    Paragraph contentMain = new Paragraph(strContent, fontContent);
                    doc.Add(contentMain);
                    doc.Close();
                    MessageBox.Show("报告创建完成!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(filePath);
                }
                catch (Exception)
                {
                    if (doc != null)
                    {
                        doc.Close();
                        MessageBox.Show("请查看文件是否被打开？", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}
