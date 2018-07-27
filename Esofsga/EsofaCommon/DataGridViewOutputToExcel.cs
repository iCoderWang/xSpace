using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsofaCommon
{
    public class DataGridViewOutputToExcel
    {
        private void OutputAsExcelFile(DataGridView dgv)
        {
            //将datagridView中的数据导出到一张表中
            DataTable tempTable = (DataTable)dgv.DataSource;
            //导出信息到Excel表
            Microsoft.Office.Interop.Excel.ApplicationClass myExcel;
            Microsoft.Office.Interop.Excel.Workbooks myWorkBooks;
            Microsoft.Office.Interop.Excel.Workbook myWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet myWorkSheet;
            char myColumns;
            Microsoft.Office.Interop.Excel.Range myRange;
            object[,] myData = new object[500, 35];
            int i, j;//j代表行,i代表列
            myExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
            //显示EXCEL
            myExcel.Visible = true;
            if (myExcel == null)
            {
                MessageBox.Show("本地Excel程序无法启动!请检查您的Microsoft Office正确安装并能正常使用", "提示");
                return;
            }
            myWorkBooks = myExcel.Workbooks;
            myWorkBook = myWorkBooks.Add(System.Reflection.Missing.Value);
            myWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)myWorkBook.Worksheets[1];
            myColumns = (char)(tempTable.Columns.Count + 64);//设置列
            myRange = myWorkSheet.get_Range("A1", myColumns.ToString() + "5");//设置列宽
            int count = 0;
            //设置列名
            foreach (DataColumn myNewColumn in tempTable.Columns)
            {
                myData[0, count] = myNewColumn.ColumnName;
                count = count + 1;
            }
            //输出datagridview中的数据记录并放在一个二维数组中
            j = 1;
            int rows = 0;
            foreach (DataRow myRow in tempTable.Rows)//循环行
            {
                if (dgv.Rows[rows].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    for (i = 0; i < tempTable.Columns.Count; i++)//循环列
                    {
                        switch (tempTable.Columns[i].DataType.Name)   //根据不同数据类型分别处理
                        {
                            case "Decimal":
                                myData[j, i] = ((decimal)myRow[tempTable.Columns[i].ColumnName]).ToString("0.00") + ",";
                                break;
                            //case "int":
                            //    myData[j, i] = ((decimal)myRow[tempTable.Columns[i].ColumnName]).ToString("0") + ",";
                            //    break;
                            case "Double":
                                myData[j, i] = ((double)myRow[tempTable.Columns[i].ColumnName]).ToString("0.00");
                                break;
                            case "DateTime":
                                myData[j, i] = ((DateTime)myRow[tempTable.Columns[i].ColumnName]).ToShortDateString() + "',";
                                break;
                            default:
                                myData[j, i] = "'" + myRow[tempTable.Columns[i].ColumnName].ToString();
                                break;
                        }

                        // myData[j, i] = myRow[i].ToString();
                    }
                    j++;

                }
                rows = rows + 1;
            }
            //将二维数组中的数据写到Excel中
            myRange = myRange.get_Resize(tempTable.Rows.Count + 1, tempTable.Columns.Count);//创建列和行
            myRange.Value2 = myData;
            myRange.EntireColumn.AutoFit();
        }
    }
}
