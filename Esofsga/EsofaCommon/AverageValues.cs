using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaCommon
{
    public partial class AverageValues
    {
        /// <summary>
        /// 判断字符串中是否含有小括号“(”
        /// 返回平均值
        /// </summary>
        /// <param name="strPara"></param
        /// <returns></returns>
        public double Calculate(string str)
        {
            double meanVal = 0;
            string tempStr = null;
            if (! str.Contains("("))
            {
                meanVal = ValConvert(str.Trim());
            }
            else
            {
                tempStr = str.Substring(0, str.IndexOf('(') - 1);
                meanVal = ValConvert(tempStr);
            }
            return meanVal;
        }

        /// <summary>
        /// 给定一个包含指定格式的数值字符串
        /// 返回平均值
        /// </summary>
        /// <param name="strPara"></param>
        /// <returns></returns>
        private double ValConvert(string strPara)
        {
            double avgVal = 0;
            int counter = 0;
            double tempSum = 0;
            string[] strArr = strPara.Split(new char[3] { '-', '>', '<' });
            foreach (string str in strArr)
            {
                if (str != "")
                {
                    counter++;
                    tempSum += Convert.ToDouble(str.Trim());
                }
            }
            if (counter != 0)
            {
               return avgVal = tempSum / counter;
            }
            else
            {
                return 0;
            }
        }
    }
}
