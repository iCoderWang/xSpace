using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaModel
{
   public partial class BlockParametersGrade
    {
        //定义字段 区块 block
        public string para_Blk;

        //定义字段 主力层系 primary Strata
        public string para_Ps;//{ get; set; }

        //定义字段 埋深范围(m) depth Range
        public string para_Dr { get; set; }

        //定义字段 埋深范围(m)的赋分  depth Range Score
       // public double para_DrScore { get; set; }

        //定义字段 有效面积(km2) effective Area
        public string para_Ea { get; set; }

        //定义字段 富有机质页岩厚度(m) shale Thickness Riching Organic Matters
        public string para_Strom { get; set; }

        //定义字段 平均厚度(m) average Thickness
        public string para_StromAt { get; set; }

        //定义字段 平均厚度(m)赋分 average Thickness Score
       // public double para_StromAtScore { get; set; }

        //定义字段 Toc 总有机碳
        public string para_Toc { get; set; }

        //定义字段 RO
        public string para_Ro { get; set; }

        //定义字段 保存条件 storage Condition
        public string para_Sc { get; set; }

        //定义字段 资源丰度 (108 m3/km2) resource richness
        public string para_Rr { get; set; }

        //定义字段 含气量 (m3/t) gas Content
        public string para_Gc { get; set; }

        //定义字段 孔隙度 (%) porosity
        public string para_Por { get; set; }

        //定义字段 构造复杂程度 structure complexity degree
        public string para_Scd { get; set; }

        //定义字段 顶底板厚度 (m) roof-floor Thickness
        public string para_Trf { get; set; }

        //定义字段 裂缝发育程度 fracture Development Degree
        public string para_Fdd { get; set; }

        //定义字段 脆性矿物含量 brittle Mineral Content
        public string para_Bmc { get; set; }

        //定义字段 主应力差异系数 principle Stress Diversity Factor
        public string para_Psdf { get; set; }

        //定义字段 压力系数 pressure Factor
        public string para_Pf { get; set; }

        //定义字段 地质资源量 (万亿方) geological resource
        public string para_Gr { get; set; }
    }
}
