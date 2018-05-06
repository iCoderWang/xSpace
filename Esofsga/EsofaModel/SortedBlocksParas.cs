using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaModel
{
    public partial class SortedBlocksParas
    {
        //定义排名序号属性
         public int para_Rank { get; set; }

        //定义字段 区块 block
        public string para_Blk { get; set; }

        //定义总分数属性
        public double para_TotalScores { get; set; }

        //定义字段 主力层系 primary Strata 及赋分属性
        public string para_Ps{ get; set; }
        public double para_PsScores { get; set; }

        //定义字段 有效面积(km2) effective Area 及权重属性和赋分属性
        public string para_Ea { get; set; }
        public double para_EaWeight { get; set; }
        public double para_EaScores { get; set; }

        //定义字段 平均厚度(m) average Thickness
        public string para_StromAt { get; set; }
        public double para_StromAtWeight { get; set; }
        public double para_StromAtScores { get; set; }

        //定义字段 Toc 总有机碳
        public string para_Toc { get; set; }
        public double para_TocWeight { get; set; }
        public double para_TocScores { get; set; }

        //定义字段 RO
        public string para_Ro { get; set; }
        public double para_RoWeight { get; set; }
        public double para_RoScores { get; set; }

        //定义字段 保存条件 storage Condition
        public string para_Sc { get; set; }
        public double para_ScScores { get; set; }

        //定义字段 资源丰度 (108 m3/km2) resource richness
        public string para_Rr { get; set; }
        public double para_RrWeight { get; set; }
        public double para_RrScores { get; set; }

        //定义字段 含气量 (m3/t) gas Content
        public string para_Gc { get; set; }
        public double para_GcWeight { get; set; }
        public double para_GcScores { get; set; }

        //定义字段 孔隙度 (%) porosity
        public string para_Por { get; set; }
        public double para_PorWeight { get; set; }
        public double para_PorScores { get; set; }

        //定义字段 构造复杂程度 structure complexity degree
        public string para_Scd { get; set; }
        public double para_ScdScores { get; set; }

        //定义字段 脆性矿物含量 brittle Mineral Content
        public string para_Bmc { get; set; }
        public double para_BmcWeight { get; set; }
        public double para_BmcScores { get; set; }

        //定义字段 埋深范围(m) Average depth Ad
        public string para_Ad { get; set; }
        public double para_AdWeight { get; set; }
        public double para_AdScores { get; set; }

        //定义字段 压力系数 Pressure Coefficient
        public string para_Pc { get; set; }
        public double para_PcWeight { get; set; }
        public double para_PcScores { get; set; }

        //定义字段 主应力差异系数 principle Stress Diversity Factor
        public string para_Psdf { get; set; }
        public double para_PsdfWeight { get; set; }
        public double para_PsdfScores { get; set; }

        //定义字段 裂缝发育程度 fracture Development Degree
        public string para_Fdd { get; set; }
        public double para_FddScores { get; set; }

        //定义字段 富有机质页岩厚度(m) shale Thickness Riching Organic Matters
        // public string para_Strom { get; set; }

        //定义字段 顶底板厚度 (m) roof-floor Thickness
        //public string para_Trf { get; set; }

        //定义字段 地质资源量 (万亿方) geological resource
       // public string para_Gr { get; set; }
    }
}
