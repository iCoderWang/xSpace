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
    public partial class TOPSIS
    {
        public void ToNormalize(double [,] arr)
        {
            Matrix<double> mtb = Matrix<double>.Build.DenseOfArray(arr);
        }
    }
}
