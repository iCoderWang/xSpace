using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaCommon
{
    public partial class SubjectiveGrading
    {
        public double Grade(string str)
        {
            double score = 0;
            if (str != "")
            {
                if (str.Contains("S1为主") && !str.Contains("兼探"))
                {
                    score = 85;
                }
                if (str.Contains("1q为主") && !str.Contains("兼探"))
                {
                    score = 70;
                }
                if (str.Contains("S1为主") && str.Contains("兼探") && str.Contains("1q"))
                {
                    score = 80;
                }
                if (str.Contains("1q为主") && str.Contains("S1为主") && str.Contains("兼探"))
                {
                    score = 75;
                }
                if(str.Contains("好") && !str.Contains("-"))
                {
                    score = 85;
                }
                if (str.Contains("中") && !str.Contains("-"))
                {
                    score = 75;
                }
                if(str.Contains("差") && !str.Contains("-"))
                {
                    score = 50;
                }
                if (str.Contains("好") && str.Contains("-") && str.Contains("中"))
                {
                    score = 80;
                }
                if (str.Contains("差") && str.Contains("-") && str.Contains("中"))
                {
                    score = 65;
                }
                if (str.Contains("局部") && str.Contains("发育"))
                {
                    score = 80;
                }
                if (!str.Contains("局部") && str.Contains("发育") && !str.Contains("不"))
                {
                    score = 85;
                }
                if (str.Contains("不") && str.Contains("发育"))
                {
                    score = 70;
                }


            }
           else
            {
                score = 0;
            }
            return score;
        }
    }
}
