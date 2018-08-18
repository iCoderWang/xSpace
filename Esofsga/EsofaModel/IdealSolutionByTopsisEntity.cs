using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaModel
{
    public partial class IdealSolutionByTopsisEntity
    {
        //定义排名序号属性
        public int para_Rank { get; set; }

        //定义字段 目标区块 block
        public string para_Tgt { get; set; }

        //定义正理想解的距离
        public double para_PostiveDist { get; set; }

        //定义负理想解的距离
        public double para_NegativeDist { get; set; }

        //定义用于排序的距离值C=para_NegativeDist/(para_NegativeDist+para_PostiveDist)
        public double para_Ci { get; set; }
    }
}
