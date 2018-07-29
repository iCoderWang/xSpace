using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaCommon
{
    public partial class FuzzyMembershipFunction
    {
        /// <summary>
        /// 模糊度隶属函数（Fuzzy Membership Function）
        /// 增大（FuzzyLarge）函数，放大100倍（100分制）
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public double FuzzyLarge(double  f1, double f2,double x)
        {
            double u;
            u = 100 * (1 / (1 + Math.Pow((x / f2) , (-f1))));
            return u;
        }

        /// <summary>
        /// 模糊度隶属函数（Fuzzy Membership Function）
        /// 减小（FuzzySmall）函数，放大100倍（100分制）
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public double FuzzySmall(double f1,double f2,double x)
        {
            double u;
            u = 100 * (1 / (1 + Math.Pow((x / f2), (f1))));
            return u;
        }

        /// <summary>
        // 当x>4或x<0.7时，符合高斯中间型函数
        //当 0.7<x<4时，符合线性增长模式
        /// </summary>
        /// <param name="x"></param>
        /// <param name="c"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double FuzzyGussian(double x)
        {
            double u = 0;
            double f1 = 0;
            double f2 = 0;
            
            if(x >0 && x < 1.3)
            {
                f1 = 0.243697875164997;
                f2 = 2.38650199498608;
            }
            if( x>=1.3 && x <= 2.5)
            {
                f1 = 0.799116867921614;
                f2 = 1.9;
            }
            if (x > 2.5 && x < 10)
            {
                f1 = 0.0389916600263996;
                f2 = -0.21625498746520;
            }
            if (x < 1500 && x > 10)
            {
                f1 = 0.000000087731235059399;
                f2 = 3310.836658;
            }
            if(x >=1500 && x<= 3500)
            {
                f1 = 0.000000287682072451781;
                f2 = 2500;
            }
            if( x > 3500)
            {
                f1 = 0.000000118925254742741;
                f2 = 1085.7864376269;
            }
            u = 100 * Math.Exp(-f1 * (x - f2) * (x - f2));
            return u;
        }
        
        /// <summary>
        /// 对于等级性评价，比如，好，较好，中，差，这种参数的赋分
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public double FuzzyRankScore(string str)
        {
            switch (str.Trim())
            {
                case "好":
                    return 100;
                case "较好":
                    return 75;
                case "中":
                    return 50;
                case "差":
                    return 25;

            }
            return 0;
        }

        public double ToAssignForKerogenType(string str)
        {
            if (str.Trim() != "")
            {
                return 50;
            }
            return 0;
        }
    }
}
