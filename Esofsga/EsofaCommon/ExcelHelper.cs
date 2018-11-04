using System;
using MsExcel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EsofaCommon
{
    public partial class ExcelHelper
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);  
        //MsExcel.Application xlApp = new MsExcel.Application();
        //int k = 0;
        //MsExcel.Workbooks workbooks = xlApp.Workbooks;
        //MsExcel.Workbook workbook = workbooks.Add(MsExcel.XlWBATemplate.xlWBATWorksheet);
        /// <summary>
        /// 使用Excel打开文档。
        /// </summary>
        /// <param name="fileName"></param>
        public void OpenExcel(string saveFileName)
        {
            MsExcel.Application app = new MsExcel.Application();
           
            if (!string.IsNullOrEmpty(saveFileName))
            {
                MsExcel.Workbook workbook = app.Application.Workbooks.Open(saveFileName);
                app.Visible = true;
            }
            //app.Quit();
        }

        public void QuitExcelApp(MsExcel.Application xlApp, int pid)
        {
            xlApp.Quit();
            //杀死打开的Excel进程
            Process myPro = new Process();
            Process excelPro = Process.GetProcessById(pid);
            excelPro.Kill();
        }
        public string DialogSaveExcel()
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel文件|*.xlsx;*.xls";
            //saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            return saveFileName;
        }
        /// <summary>
        /// 将DataGridView中显示的数据存储为Excel表
        /// </summary>
        /// <param name="dgv"></param>
        public bool Dgv2Excel(DataGridView dgv, string saveFileName)
        {
            MsExcel.Application xlApp = new MsExcel.Application();
            IntPtr t = new IntPtr(xlApp.Hwnd);
            int k = 0;
            GetWindowThreadProcessId(t, out k);
            if (saveFileName.IndexOf(":") < 0)//被点了取消
            {
                return false;
            }            
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            MsExcel.Workbooks workbooks = xlApp.Workbooks;
            MsExcel.Workbook workbook = workbooks.Add(MsExcel.XlWBATemplate.xlWBATWorksheet);
            MsExcel.Worksheet worksheet = (MsExcel.Worksheet)workbook.Worksheets[1];//取得sheet1 
            //写入标题             
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = dgv.Rows[r].Cells[i].Value;
                }
                //System.Windows.Forms.Application.DoEvents(); //实时刷新窗体的显示界面
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应

            try
            {
                if (saveFileName != "")
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);  //fileSaved = true;       
                }
                return true;
            }
            catch (Exception ex)
            {//fileSaved = false;                      
                MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                return false;
            }
            finally
            {
                workbook.Close();
                workbooks.Close();
                QuitExcelApp(xlApp, k);
            }
            
        }

        /// <summary>
        /// 重载DataGridView输出另存为Excel
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="strKeyWord"></param>
        /// <param name="saveFileName"></param>
        /// <returns></returns>
        public bool Dgv2Excel(DataGridView dgv,string strKeyWord,string saveFileName)
        {
            //string fileName = "";
            MsExcel.Application xlApp = new MsExcel.Application();
            IntPtr t = new IntPtr(xlApp.Hwnd);
            int k = 0;
            GetWindowThreadProcessId(t, out k);
            if (saveFileName.IndexOf(":") < 0)//被点了取消
            {
                return false;
            }
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            MsExcel.Workbooks workbooks = xlApp.Workbooks;
            MsExcel.Workbook workbook = workbooks.Add(MsExcel.XlWBATemplate.xlWBATWorksheet);
            MsExcel.Worksheet worksheet = (MsExcel.Worksheet)workbook.Worksheets[1];//取得sheet1 
            
            //当存储总分值表格时
            if (strKeyWord.Equals("总分值"))
            {
                //写入标题  
                int clmnCounter = 0;
                for (int i = 0,j = 0; i < dgv.ColumnCount; i++)
                {
                    if (dgv.Columns[i].HeaderText.Contains("排序") ||
                        dgv.Columns[i].HeaderText.Contains("区块") ||
                        dgv.Columns[i].HeaderText.Contains("总分值"))
                    {
                        worksheet.Cells[1, j + 1] = dgv.Columns[i].HeaderText;
                        j++;
                    }
                    if (dgv.Columns[i].HeaderText.Contains("总分值"))
                    {
                        i++;
                        clmnCounter = i;
                        break;
                    }
                }
                //写入数值
                for (int r = 0; r < dgv.Rows.Count; r++)
                {
                    for (int i = 0,j = 0; i < clmnCounter; i++)
                    {
                        if (dgv.Columns[i].HeaderText.Contains("排序") ||
                        dgv.Columns[i].HeaderText.Contains("区块") ||
                        dgv.Columns[i].HeaderText.Contains("总分值"))
                        {
                            worksheet.Cells[r + 2, j + 1] = dgv.Rows[r].Cells[i].Value;
                            j++;
                        }
                    }
                    //System.Windows.Forms.Application.DoEvents(); //实时刷新窗体的显示界面
                }
            }

            //当存储权重值表格时
            if (strKeyWord.Equals("权重"))
            {
                //写入标题  
                //int clmnCounter = 0;
                for (int i = 0,j = 0; i < dgv.ColumnCount; i++)
                {
                    if (dgv.Columns[i].HeaderText.Contains("权重"))
                    {
                        worksheet.Cells[1, j+ 1] = dgv.Columns[i].HeaderText;
                        j++;
                    }
                }
                //写入数值
                //for (int r = 0; r < dgv.Rows.Count; r++)
                //{
                    for (int i = 0,j = 0; i < dgv.ColumnCount; i++)
                    {
                        if (dgv.Columns[i].HeaderText.Contains("权重"))
                        {
                            worksheet.Cells[2, j+ 1] = dgv.Rows[2].Cells[i].Value;
                            j++;
                        }
                    }
                    //System.Windows.Forms.Application.DoEvents(); //实时刷新窗体的显示界面
                //}
            }


            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应

            try
            {
                if (saveFileName != "")
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);  //fileSaved = true;       
                }
                return true;
            }
            catch (Exception ex)
            {//fileSaved = false;                      
                MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                return false;
            }
            finally
            {
                workbook.Close();
                workbooks.Close();
                QuitExcelApp(xlApp,k);
            }
        }

    }
}
