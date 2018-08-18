using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaModel
{
    public partial class TopsisBlockDecisionMatrixEntity
    {
        //定义排名序号属性
        public int para_Rank { get; set; }

        //定义字段 目标区块 block
        public string para_Tgt { get; set; }

        ////定义字段 目标区块所属盆地/区域
        //public string para_Bsn { get; set; }

        ////定义总分数属性
        //public double para_TotalScores { get; set; }

        ////定义字段 主力层系 primary Strata 及赋分属性
        //public string para_Ps{ get; set; }
        ////public double para_PsScores { get; set; }

        ////定义字段 保存条件 storage Condition
        //public string para_Sc { get; set; }
        ////public double para_ScScores { get; set; }


        ////定义字段 地质资源量 (万亿方) geological resource
        //public string para_Gr { get; set; }
        ////public double para_GrScores { get; set; }


        //地质参数
        //定义字段 平均厚度(m) average Thickness
        //public string para_StromAt { get; set; }
        //public double para_StromAtWeight { get; set; }
        public double para_StromAtScores { get; set; }

        //定义字段 Toc 总有机碳
        //public string para_Toc { get; set; }
        //public double para_TocWeight { get; set; }
        public double para_TocScores { get; set; }

        //定义字段 干酪根类型 Kt
        //public string para_Kt { get; set; }
        //public double para_KtWeight { get; set; }
        public double para_KtScores { get; set; }

        //定义字段 RO
        //public string para_Ro { get; set; }
        //public double para_RoWeight { get; set; }
        public double para_RoScores { get; set; }

        //定义字段 有效面积(km2) effective Area 及权重属性和赋分属性
        //public string para_Ea { get; set; }
        //public double para_EaWeight { get; set; }
        public double para_EaScores { get; set; }

        //定义字段 含气量 (m3/t) gas Content
        //public string para_Gc { get; set; }
        //public double para_GcWeight { get; set; }
        public double para_GcScores { get; set; }

        //定义字段 资源丰度 (108 m3/km2) resource richness
        //public string para_Rr { get; set; }
        //public double para_RrWeight { get; set; }
        public double para_RrScores { get; set; }

        //定义字段 孔隙度 (%) porosity
        //public string para_Por { get; set; }
        //public double para_PorWeight { get; set; }
        public double para_PorScores { get; set; }

        //定义字段 构造复杂程度 structure complexity degree
        //public string para_Scd { get; set; }
        //public double para_ScdWeight { get; set; }
        public double para_ScdScores { get; set; }

        //定义字段 顶底板岩性 Roof-floor Condition
        //public string para_Rfc { get; set; }
        //public double para_RfcWeight { get; set; }
        //public double para_RfcScores { get; set; }


        //工程参数

        //定义字段 埋深范围(m) Dr Depth Range
        //public string para_Dr { get; set; }
        //public double para_DrWeight { get; set; }
        public double para_DrScores { get; set; }

        //定义字段 压力系数 Pressure Coefficient
        //public string para_Pc { get; set; }
        //public double para_PcWeight { get; set; }
        public double para_PcScores { get; set; }

        //定义字段 渗透率 Permerbility
        //public string para_Per { get; set; }
        //public double para_PerWeight { get; set; }
        //public double para_PerScores { get; set; }

        //定义字段 裂缝发育程度 fracture Development Degree
        //public string para_Fdd { get; set; }
        //public double para_FddWeight { get; set; }
        //public double para_FddScores { get; set; }

        //定义字段 主应力差异系数 principle Stress Diversity Coefficient
        //public string para_Psdc { get; set; }
        //public double para_PsdcWeight { get; set; }
        //public double para_PsdcScores { get; set; }

        //定义字段 脆性矿物含量 brittle Mineral Content
        //public string para_Bmc { get; set; }
        //public double para_BmcWeight { get; set; }
        public double para_BmcScores { get; set; }

        //定义字段 水系 Drainage System
        //public string para_Ds { get; set; }
        //public double para_DsWeight { get; set; }
        //public double para_DsScores { get; set; }

        ////定义字段 区域勘探程度Led
        //public string para_Led { get; set; }
        //public double para_LedWeight { get; set; }
        //public double para_LedScores { get; set; }

        ////定义字段 市场气价 Gp
        //public string para_Gp { get; set; }
        //public double para_GpWeight { get; set; }
        //public double para_GpScores { get; set; }

        ////定义字段 市场需求 Dmd
        //public string para_Dmd { get; set; }
        //public double para_DmdWeight { get; set; }
        //public double para_DmdScores { get; set; }

        ////定义字段 交通设施 Tu
        //public string para_Tu { get; set; }
        //public double para_TuWeight { get; set; }
        //public double para_TuScores { get; set; }

        ////定义字段 管网条件 Pn
        //public string para_Pn { get; set; }
        //public double para_PnWeight { get; set; }
        //public double para_PnScores { get; set; }

        ////定义字段 地表地貌 Sg
        //public string para_Sg { get; set; }
        //public double para_SgWeight { get; set; }
        public double para_SgScores { get; set; }
    }
}
