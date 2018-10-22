using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;
using System.util;
using System.Resources;
using MsWord=Microsoft.Office.Interop.Word;

namespace EsofaCommon
{
    public partial class WordHelper
    {
        /// <summary>word 应用对象 </summary>     
        MsWord.Application _wordApplication = new MsWord.Application();

        /// <summary>word 文件对象 </summary>    
        MsWord.Document _wordDocument = new MsWord.Document();
        Object Nothing = System.Reflection.Missing.Value;
       
        /// <summary>
        /// 创建word应用对象 
        /// </summary>
        /// <param name="strPath">文件目录</param>
        public void CreateWord(string strPath)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Word File|*.docx|(*.*)|*.*";
            //sfd.Title = "保存文件";
            //实例化word应用对象    
            _wordDocument = this._wordApplication.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            //页面设置
            _wordDocument.PageSetup.PaperSize = MsWord.WdPaperSize.wdPaperA4;//设置纸张样式为A4纸
            _wordDocument.PageSetup.Orientation = MsWord.WdOrientation.wdOrientPortrait;//排列方式为垂直方向
            _wordDocument.PageSetup.TopMargin = 57.0f;
            _wordDocument.PageSetup.BottomMargin = 57.0f;
            _wordDocument.PageSetup.LeftMargin = 57.0f;
            _wordDocument.PageSetup.RightMargin = 57.0f;
        }
        /// <summary>
        /// 插入文字
        /// </summary>
        /// <param name="pText">文本信息</param>
        /// <param name="pFontSize">字体大小</param>
        /// <param name="pFontColor">字体颜色</param>
        /// <param name="pFontBold">字体粗体</param>
        /// <param name="ptextAlignment">方向</param>
        public void InsertText(string pText, int pFontSize, int pFontBold, string pFontName,
            MsWord.WdParagraphAlignment ptextAlignment,int newLineIndent)
        {
            //设置字体样式以及方向    
            this._wordApplication.Application.Selection.Font.Size = pFontSize;
            this._wordApplication.Application.Selection.Font.Bold = pFontBold;
            this._wordApplication.Application.Selection.Font.Name = pFontName;
            this._wordApplication.Application.Selection.ParagraphFormat.FirstLineIndent = newLineIndent;
            this._wordApplication.Application.Selection.ParagraphFormat.Alignment = ptextAlignment;
            this._wordApplication.Application.Selection.TypeText(pText);
            //this._wordDocument.Paragraphs.Last.Range.Text = pText;
        }

        /// <summary>
        /// 换行
        /// </summary>
        public void NewLine()
        {
            //换行    
            this._wordApplication.Application.Selection.TypeParagraph();
        }
        /// <summary>
        /// 插入一个图片
        /// </summary>
        /// <param name="pPictureFileName">图片名称</param>
        public void InsertPicture(string pPictureFileName)
        {
            object myNothing = System.Reflection.Missing.Value;
            //图片居中显示    
            this._wordApplication.Selection.ParagraphFormat.Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;
            this._wordApplication.Application.Selection.InlineShapes.AddPicture(pPictureFileName, ref myNothing, ref myNothing, ref myNothing);
        }


        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="pFileName">传入路径和保存的文件名称</param>
        public void SaveWord(string pFileName)
        {
            //object Nothing = System.Reflection.Missing.Value;
            object fileName = pFileName;
            object fileFormat = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocument;
            try
            {
                this._wordDocument.SaveAs(ref fileName, ref fileFormat, ref Nothing, ref Nothing, ref Nothing, ref Nothing,
                    ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing,
                    ref Nothing, ref Nothing);
                _wordDocument.Close();// ref Nothing, ref Nothing, ref Nothing);
                _wordApplication.Quit();
            }
            catch(Exception e)
            {
                //throw new Exception("导出word文档失败!");
                MessageBox.Show(e.Message);
            }
        }


        #region 使用Interop.Word.dll将DataGridView导出到Word
        /// <summary>
        /// 使用Interop.Word.dll将DataGridView导出到Word
        /// </summary>
        /// <param name="dGV"></param>
        /*保会通财务软件公司*/
        public void DGV2Word(DataGridView dGV)//,int paragraphCounter)
        {
            MsWord.Table mytable;
            //声明Word表格
            MsWord.Selection mysel;
            if (dGV == null)
            {
                MessageBox.Show("参数值被归零，请重新检验矩阵，然后再次排序。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //_wordApplication.Selection.TypeParagraph();
            mysel = _wordApplication.Selection;
            object defaultTable = MsWord.WdDefaultTableBehavior.wdWord8TableBehavior;
            object autoFit = MsWord.WdAutoFitBehavior.wdAutoFitContent;
            //将数据生成Word表格文件
            mytable = _wordDocument.Tables.Add(mysel.Range, dGV.RowCount, dGV.ColumnCount, ref defaultTable, ref autoFit);
            //设置列宽
            //mytable.Columns.AutoFit();
            _wordApplication.Selection.Cells.VerticalAlignment = MsWord.WdCellVerticalAlignment.wdCellAlignVerticalCenter;//垂直居中
            _wordApplication.Selection.ParagraphFormat.Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;//水平居中
            mytable.Borders.InsideLineStyle = MsWord.WdLineStyle.wdLineStyleSingle;
            mytable.Borders.OutsideLineStyle = MsWord.WdLineStyle.wdLineStyleSingle;
           
            //输出列标题数据
            for (int i = 0; i < dGV.ColumnCount; i++)
            {
                mytable.Cell(1, i + 1).Range.Font.Size = 10;
                mytable.Cell(1, i + 1).Range.InsertAfter(dGV.Columns[i].HeaderText);
            }
            //输出控件中的记录
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                for (int j = 0; j < dGV.ColumnCount; j++)
                {
                    mytable.Cell(i + 2, j + 1).Range.Font.Size = 10;
                    mytable.Cell(i + 2, j + 1).Range.InsertAfter(dGV[j, i].FormattedValue.ToString());

                }
            }
            //mytable.Columns.AutoFit();
            GC.Collect();
            object unit = MsWord.WdUnits.wdStory;
            _wordApplication.Selection.EndKey(ref unit,ref Nothing);
            //_wordDocument.Content.InsertAfter("\n");
        }
        #endregion
    }
}
    
