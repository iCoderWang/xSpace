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

        public List<double> ToGetPositiveIdealSolution(double[,] arr_ValNormalizedByWgt, 
            List<double> lst_MaxVal)
        {
            List<double> lst_PIS = new List<double>();
            double dist_PIS = 0;
            double sum_ValNormalizedByWgt = 0;
            int columnCounts = arr_ValNormalizedByWgt.GetLength(1);
            int rowCounts = arr_ValNormalizedByWgt.GetLength(0);
            for(int i = 0; i < rowCounts; i++)
            {
                for(int j = 0; j < columnCounts; j++)
                {
                    sum_ValNormalizedByWgt += Math.Pow((arr_ValNormalizedByWgt[i,j]-lst_MaxVal[j]),2);
                }
                dist_PIS = Math.Sqrt(sum_ValNormalizedByWgt);
                lst_PIS.Add(dist_PIS);
                sum_ValNormalizedByWgt = 0;
                dist_PIS = 0;
            }
            return lst_PIS;
        }

        public double ToGetNegativeIdealSolution(double[,] arr_ValNormalizedByWgt, 
            List<double> lst_MinVal)
        {
            return 0;
        }
    }
}
