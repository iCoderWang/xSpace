using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace EsofaCommon
{
    //方阵设定一致性检验模块
    public partial class CoincidenceChecker
    {
        //Matrix<double> processedData = Matrix<double>.Build.Random(5, 5);
        //Evd<double> eigen = processedData.Evd();
        //Vector<Complex> eigenvector = eigen.EigenValues;
        //Using the constructor
        //Matrix<double> someMatrix = new DenseMatrix(4, 4, someArray)

        //Using the static function
        //Matrix<double> someMatrix = DenseMatrix.OfColumnMajor(4, 4, someArray);

        //计算特征值的方法，返回特征值的最大值
        /// <summary>
        /// 计算最大特征值
        /// 计算最大特征向量，并完成归一化
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="maxEigenValue"></param>
        /// <returns></returns>
        public Vector<double> Caculate(double [,] arr, out double maxEigenValue)
        {
            //double[,] arr = new double [,]{ { 1,-3,3}, {3,-5,3 }, {6,-6,4 } };
            //对out参数 最大特征值变量预先赋值
            maxEigenValue = 0;
            //向量索引
            int index;
            
            //向量元素计数器
            int counter = 0;
            
            //创建新的矩阵，用于存储给定数组的数据
            Matrix<double> mtB = Matrix<double>.Build.DenseOfArray(arr);

            //对矩阵的特征值进行计算
            Evd<double> eigen = mtB.Evd();

            //根据特征值实部的最大值，来判断最大特征值，虚部必须为零
            if(eigen.EigenValues.AbsoluteMaximum().Imaginary == 0)
            {
                maxEigenValue = eigen.EigenValues.AbsoluteMaximum().Real;
            } 
            
            //获取虚部为零，实部为最大值得最大特征值的索引号
            index = eigen.EigenValues.AbsoluteMaximumIndex();

            //根据最大值的索引号将最大特征向量取出，并进行归一化。
            Vector<double> eigenVector = eigen.EigenVectors.Column(index);//.Normalize(1);

            //用计数器对最大向量的每个元素进行计数，看看是否全部元素都为负值
            foreach(double var in eigenVector)
            {
                if(var <= 0)
                {
                    counter++;
                }
            }
            // 元素都为负值，则将最大特征向量的所有元素变号
            if(counter == eigenVector.Count) 
            {
                eigenVector = -eigenVector;
            }
            //Vector<double> v = eigen.EigenValues.Real();
            
                //int i = eigen.EigenValues.MaximumIndex();
            //return eigen.
            return eigenVector;
        }

        /// <summary>
        /// 计算CI值
        /// 利用CI值，计算CR值
        /// </summary>
        /// <param name="maxEigenValue"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public double CrGenerate(double maxEigenValue,double [,] arr)
        {
            //定义CR变量
            double CR;

            //定义CI变量
            double CI;

            //预定义RI数组，并赋值
            double[] arrRiValue = { 0, 0, 0.58, 0.90, 1.12, 1.24, 1.32, 1.41, 1.45, 1.49,1.52,1.54 };

            //定义数组维度的变量
            int arrSize = arr.GetLength(0);

            //当矩阵的维度为1和2时，默认CR值为0
            if(arrSize==1 || arrSize == 2)
            {
                CR = arrRiValue[arrSize-1];
            }

            //矩阵维度大于2时，计算CI值，并获取RI值
            //计算CR值
            else
            {
                CI = (maxEigenValue - arrSize) / (arrSize - 1);
                CR = CI / arrRiValue[arrSize -1];
            }
            return CR;
        }
        
    }
}
