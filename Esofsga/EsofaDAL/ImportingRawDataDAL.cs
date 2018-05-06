using EsofaModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using EsofaCommon;

namespace EsofaDAL
{
    public partial class ImportingRawDataDAL
    {
        public List<RawData> GetList(string filePath)
        {
            //RawDataDAL rdd = new RawDataDAL();
            DataTable dt = ReadFromExcel(filePath);
            List<RawData> list = new List<RawData>();
            DataAssignment dA = new DataAssignment();
            return dA.Assign(list,dt);
        }

        /// <summary>
        /// 从Excel读取数据
        /// 只支持单表
        /// </summary>
        /// <param name="FilePath">文件路径</param>
        private DataTable ReadFromExcel(string FilePath)
        {
            DataTable dt = null;
            IWorkbook wk = null;
            string extension = Path.GetExtension(FilePath); //获取扩展名
            try
            {
                /*
                    HSSFWorkbook wb = new HSSFWorkbook(filepath);
                    int i=wb.NumberOfSheets; 这个是总共的个数
                    NPOI.SS.UserModel.ISheet sheet = hssfworkbook.GetSheetAt(0); 获取指定的那一个
                    */
                using (FileStream fs = File.OpenRead(FilePath))
                {
                    if (extension.Equals(".xls")) //2003
                    {
                        wk = new HSSFWorkbook(fs);
                    }
                    else                         //2007以上
                    {
                        wk = new XSSFWorkbook(fs);
                    }
                }

                //读取当前表数据
                ISheet sheet = wk.GetSheetAt(0);

                //构建DataTable
                IRow row = sheet.GetRow(0);
                dt = BuildDataTable(row);
                if (dt != null)
                {
                    if (sheet.LastRowNum >= 1)
                    {
                        for (int i = 1; i < sheet.LastRowNum + 1; i++)
                        {
                            IRow temp_row = sheet.GetRow(i);
                            List<object> itemArray = new List<object>();
                            for (int j = 0; j < temp_row.LastCellNum; j++)
                            {
                                itemArray.Add(temp_row.GetCell(j) == null ? string.Empty : temp_row.GetCell(j).ToString());
                            }

                            dt.Rows.Add(itemArray.ToArray());
                        }
                    }
                }

                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 构建DataTable框架
        /// </summary>
        /// <param name="Row">Excel第一行</param>
        /// <returns></returns>
        private DataTable BuildDataTable(IRow Row)
        {
            DataTable dt = null;
            if (Row.Cells.Count == 20)
            {
                dt = new DataTable();
                for (int i = 0; i < Row.LastCellNum; i++)
                {
                    dt.Columns.Add(Row.GetCell(i).ToString());
                }
            }
            return dt;
        }

    }
}
