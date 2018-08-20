using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaCommon
{
    /// <summary>
    /// Technique for Order Preference by Similarity to an Ideal Solution
    /// TOPSIS法根据有限个评价对象与理想化目标的接近程度进行排序的方法，是在现有的对象中进行相对优劣的评价。
    /// </summary>
    public partial class TopsisDecisionMatrixOperation
    {
        /// <summary>
        /// 矩阵列规范化，2.0 是norm范数值，表示列所有元素先平方再求和，然后再进行求根，再对列中的每个元素除以该根值
        /// 如果函数NormalizedColumns()中的参数使用1.0，则是对列所有元素直接求和，然后再进行求根，再然后对列中的每个元素除以该 根值 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public double[,] ToNormalize(double [,] arr)
        {
            Matrix<double> mtb = Matrix<double>.Build.DenseOfArray(arr);
            return mtb.NormalizeColumns(2.0).ToArray();
        }
        /// <summary>
        /// 计算出每行的各列对应的元素到 “正理想解” 的距离列表
        /// 该列表中的每个元素，则是对应的一个区块的求解值
        /// </summary>
        /// <param name="arr_ValNormalizedByWgt"></param>
        /// <param name="lst_MaxVal"></param>
        /// <returns></returns>
        public List<double> ToGetDistToPIS(double[,] arr_ValNormalizedByWgt, 
            List<double> lst_MaxVal)
        {
            //定义 list of Positive Ideal Solution
            List<double> lst_PIS = new List<double>();
            //定义 distance of Positive Ideal Solution
            double dist_PIS = 0;
            //定义 每行的各列的元素值 与对应的列的正理想解的差值 的平方和
            double sum_Difference = 0;
            //获取二维数组的列数，当函数GetLength中的参数为 1 时，表示是二维，即列
            int columnCounts = arr_ValNormalizedByWgt.GetLength(1);
            //获取二维数组的行数，当函数GetLength中的参数为 0 时，表示是一维，即行
            int rowCounts = arr_ValNormalizedByWgt.GetLength(0);
            for(int i = 0; i < rowCounts; i++)
            {
                for(int j = 0; j < columnCounts; j++)
                {
                    sum_Difference += Math.Pow((arr_ValNormalizedByWgt[i,j]-lst_MaxVal[j]),2);
                }
                dist_PIS = Math.Sqrt(sum_Difference);
                lst_PIS.Add(dist_PIS);
                sum_Difference = 0;
                dist_PIS = 0;
            }
            return lst_PIS;
        }
        /// <summary>
        /// 计算出每行的各列对应的元素到 “负理想解” 的距离列表
        /// 该列表中的每个元素，则是对应的一个区块的求解值
        /// </summary>
        /// <param name="arr_ValNormalizedByWgt"></param>
        /// <param name="lst_MinVal"></param>
        /// <returns></returns>
        public List<double> ToGetDistToNIS(double[,] arr_ValNormalizedByWgt, 
            List<double> lst_MinVal)
        {
            //定义 list of Negative Ideal Solution
            List<double> lst_NIS = new List<double>();
            //定义 distance of Negative Ideal Solution
            double dist_NIS = 0;
            //定义 每行的各列的元素值 与对应的列的正理想解的差值 的平方和
            double sum_Difference = 0;
            //获取二维数组的列数，当函数GetLength中的参数为 1 时，表示是二维，即列
            int columnCounts = arr_ValNormalizedByWgt.GetLength(1);
            //获取二维数组的行数，当函数GetLength中的参数为 0 时，表示是一维，即行
            int rowCounts = arr_ValNormalizedByWgt.GetLength(0);
            for (int i = 0; i < rowCounts; i++)
            {
                for (int j = 0; j < columnCounts; j++)
                {
                    sum_Difference += Math.Pow((arr_ValNormalizedByWgt[i, j] - lst_MinVal[j]), 2);
                }
                dist_NIS = Math.Sqrt(sum_Difference);
                lst_NIS.Add(dist_NIS);
                sum_Difference = 0;
                dist_NIS = 0;
            }
            return lst_NIS;
        }
    }
}
