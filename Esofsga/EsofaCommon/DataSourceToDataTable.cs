using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsofaCommon
{
    public static class DataSourceToDataTable
    {
        /// <summary>
        /// 将List转换成DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable GetListToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable dt = new DataTable();
            for (int i = 0; i < properties.Count; i++)
            {
                PropertyDescriptor property = properties[i];
                dt.Columns.Add(property.Name, property.PropertyType);
            }
            object[] values = new object[properties.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = properties[i].GetValue(item);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        /// <summary>
        /// 将datagridview的datasource给DataTable
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static double[,] GetDgvToArray(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            dt = GetDgvToTable(dgv);
            int col = dt.Columns.Count;
            double[,] array = new double[dt.Rows.Count, col];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    array[i, j] = Convert.ToDouble(dt.Rows[i][j]);
                }
            }
            return array;
        }

        public static double[,] GetDgvToArray(DataGridView dgv,int rowFirst, int columnFirst)
        {
            DataTable dt = new DataTable();
            dt = GetDgvToTable(dgv);
            int col = dt.Columns.Count;
            double[,] array = new double[dt.Rows.Count, col- columnFirst];
            if (columnFirst < dt.Columns.Count)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (columnFirst < dt.Columns.Count)
                    {
                        for (int j = 0; j + columnFirst < dt.Columns.Count; j++)
                        {
                            array[i, j] = Convert.ToDouble(dt.Rows[i][j + columnFirst]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("方法 DataSourceToDataTable.GetDgvToArray(DataGridView dgv,int rowFirst, int columnFirst)中，列" +
                            "的初始值 错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("方法 DataSourceToDataTable.GetDgvToArray(DataGridView dgv,int rowFirst, int columnFirst)中，行" +
                            "的初始值 错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return array;
        }

        //public static DataTable ConvertArratyToDataTable(double[,] arr)
        //{
        //    DataTable dt = new DataTable();
        //    for (int i = 0; i < arr.GetLength(1); i++)
        //    {
        //        DataColumn newColumn = new DataColumn(GetCode(i), arr[0, 0].GetType());
        //        dt.Columns.Add(newColumn);
        //    }
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        DataRow newRow = dt.NewRow();
        //        for (int j = 0; j < arr.GetLength(1); j++)
        //        {
        //            newRow[GetCode(j)] = arr[i, j];
        //        }
        //        dataSouce.Rows.Add(newRow);
        //    }
        //    return dataSouce;
        //}
    }
}
