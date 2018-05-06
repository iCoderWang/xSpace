using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaCommon
{
    public partial class ParametersWeightLoader
    {
        //int[,] TABLE = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        //DataTable dt = new DataTable();
        //    for (int i = 0; i<TABLE.GetLength(1); i++)
        //        dt.Columns.Add(i.ToString(), typeof(int));
        //    for (int i = 0; i<TABLE.GetLength(0); i++)
        //    {
        //        DataRow dr = dt.NewRow();
        //        for (int j = 0; j<TABLE.GetLength(1); j++)
        //            dr[j] = TABLE[i, j];
        //        dt.Rows.Add(dr);
        //    }
        //    this.dataGridView1.DataSource = dt;
        public DataTable ParaWeightLoad(double [,] arr)
        {
            //创建表格变量
            DataTable dt = new DataTable();

            //获取数组的列的数目(arr.GetLength(1))，并以此确定需要在表格dt中创建的列数
            for(int i =0; i<arr.GetLength(1);i++)
            {
                dt.Columns.Add(i.ToString(), typeof(double));
            }
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                DataRow dr = dt.NewRow();
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    dr[j] = arr[i, j];                   
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
