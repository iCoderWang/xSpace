using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaCommon
{
    public partial class NaturalBreaksClassification
    {
        /// <summary>
        /// 自然分类法，对排好序的数组根据最小方差值进行分类
        /// </summary>
        /// <param name="var">是用于排序的数值构成的数组，比如用于排名的每个区块计算后的总分值由大到小
        /// 排序后构成的数组</param>
        /// <param name="session1"></param>
        /// <param name="session2"></param>
        public void ToClassify(IEnumerable<double> var, out int session1, out int session2)
        {
            session1 = 0;
            session2 = 0;
            int minValueIndex = 0;
            double stdDev1 = 0, stdDev2 = 0, stdDev3 = 0;// stdDevSum = 0;
            List<double> lst_StdDevSum = new List<double>();
            List<int> lst_Class_1_Flag = new List<int>();
            List<int> lst_Class_2_Flag = new List<int>();
            for (int i = 0; i < var.Count(); i++)
            {
                if(i == var.Count() - 2)
                {
                    minValueIndex = lst_StdDevSum.IndexOf(lst_StdDevSum.Min());
                    session1 = lst_Class_1_Flag[minValueIndex];
                    session2 = lst_Class_2_Flag[minValueIndex];
                    break;
                }
                stdDev1 = 0;
                stdDev1 = CalculateStdDev(var, 0, i);

                for(int j = var.Count()-1;j>= var.Count() - (i+1) ; j--)
                {
                    if ((i + 1) <= (j - 1))
                    {
                        stdDev2 = 0;
                        stdDev3 = 0;
                        // 从后往前计算第3类的Sigma值
                        stdDev3 = CalculateStdDev(var, j, (var.Count() - 1));
                        stdDev2 = CalculateStdDev(var, (i + 1), (j - 1));
                        lst_StdDevSum.Add(stdDev1 + stdDev2 + stdDev3);
                        lst_Class_1_Flag.Add(i+1);
                        lst_Class_2_Flag.Add(var.Count()-j);
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
        }
        /// <summary>
        /// 计算均方差 standard deviation
        /// </summary>
        /// <param name="values"></param>
        /// <param name="firstIndex"></param>
        /// <param name="lastIndex"></param>
        /// <returns></returns>
        private double CalculateStdDev(IEnumerable<double> values, int firstIndex, int lastIndex)
        {
            double stdDev = 0;
            if (values.Count() > 0 && lastIndex > firstIndex)
            {
                //  计算平均数   
                //double avg = values.Average();
                double avg = values.Where((num, index) => index >= firstIndex && index <= lastIndex).Average();
                //  计算各数值与平均数的差值的平方，然后求和 
                double sum = values.Where((num, index) => index >= firstIndex && index <= lastIndex).Sum(d => Math.Pow(d - avg, 2));
                //  除以数量，然后开方
                stdDev = Math.Sqrt(sum / (lastIndex - firstIndex + 1));
            }
            return stdDev;
        }
    }
}
