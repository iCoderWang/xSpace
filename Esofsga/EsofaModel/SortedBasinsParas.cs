using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaModel
{
    public partial class SortedBasinsParas
    {
        //定义排名序号属性
        public int para_Rank { get; set; }

        //定义字段 目标区块 block
        public string para_Tgt { get; set; }

        //定义字段 目标区块所属盆地/区域
        public string para_Bsn { get; set; }

        //定义总分数属性
        public double para_TotalScores { get; set; }

        //定义字段 主力层系 primary Strata 及赋分属性
        public string para_Ps { get; set; }
        public double para_PsScores { get; set; }

        //定义字段 保存条件 storage Condition
        public string para_Sc { get; set; }
        public double para_ScScores { get; set; }


        //定义字段 地质资源量 (万亿方) geological resource
        public string para_Gr { get; set; }
        public double para_GrScores { get; set; }


        //地质参数
        //定义字段 平均厚度(m) average Thickness
        public string para_StromAt { get; set; }
        public double para_StromAtWeight { get; set; }
        public double para_StromAtScores { get; set; }

        //定义字段 Toc 总有机碳
        public string para_Toc { get; set; }
        public double para_TocWeight { get; set; }
        public double para_TocScores { get; set; }

        //定义字段 干酪根类型 Kt
        public string para_Kt { get; set; }
        public double para_KtWeight { get; set; }
        public double para_KtScores { get; set; }

        //定义字段 RO
        public string para_Ro { get; set; }
        public double para_RoWeight { get; set; }
        public double para_RoScores { get; set; }

        //定义字段 有效面积(km2) effective Area 及权重属性和赋分属性
        public string para_Ea { get; set; }
        public double para_EaWeight { get; set; }
        public double para_EaScores { get; set; }

        //定义字段 资源丰度 (108 m3/km2) resource richness
        public string para_Rr { get; set; }
        public double para_RrWeight { get; set; }
        public double para_RrScores { get; set; }

        //定义字段 孔隙度 (%) porosity
        public string para_Por { get; set; }
        public double para_PorWeight { get; set; }
        public double para_PorScores { get; set; }



        //工程参数

        //定义字段 埋深范围(m) Dr Depth Range
        public string para_Dr { get; set; }
        public double para_DrWeight { get; set; }
        public double para_DrScores { get; set; }
        
        //定义字段 脆性矿物含量 brittle Mineral Content
        public string para_Bmc { get; set; }
        public double para_BmcWeight { get; set; }
        public double para_BmcScores { get; set; }
        
    }
}
