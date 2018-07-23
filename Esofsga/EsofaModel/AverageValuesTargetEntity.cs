using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaModel
{
    //取平均值 的目标区块数据实体（Target: Core Area）
    public partial class AverageValuesTargetEntity
    {
        //目标区块的序号
        public int tgt_Att_Sn { get; set; }
        /* 目标区实体所有参数用 tgt_ 开始
          * 属性条件 tgt_Att_ ,
          * 地质条件 tgt_Geo_ ,
          * 工程条件 tgt_Eng_ , 
          * 市场条件 tgt_Mkt_ ,
          */

        //目标区 （核心区）属性参数 Target Attribute Params
        //定义字段 区块 block  
        //public string para_Blk { get; set; }
        public string tgt_Att_Name { get; set; }

        //盆地（远景区） 关联参数 Basin Attribution Params
        public string bsn_Att_Name { get; set; }

        // public string tgt_Att_Code { get; set; }
        //定义字段 主力层系 primary Strata
        public string tgt_Att_Ps { get; set; }

        //定义字段 保存条件 Storage Condition
        //public string Para_Sc { get; set; }
        public string tgt_Att_Para_Sc { get; set; }

        //定义字段 平均——地质资源量 (万亿方) geological resource
        public string tgt_Att_Para_Gr_Avg { get; set; }

        /* 目标区 （核心区）地质参数
         * Target Geology Params:  tgt_Geo_Para_
         */

        //定义字段 平均——富有机质页岩厚度范围(m) Thinckness Range Riching Organic Matters Shale
        public string tgt_Geo_Para_TrRoms_Avg { get; set; }
        
        //定义字段 平均——Toc 总有机碳
        public string tgt_Geo_Para_Toc_Avg { get; set; }

        //定义字段 Kt 有机质类型 Kerogen Type
        public string tgt_Geo_Para_Kt { get; set; }

        //定义字段 平均——Ro 有机质成熟度
        public string tgt_Geo_Para_Ro_Avg { get; set; }

        //定义字段 有效圈定面积(km2) Effective Area
        // public string Para_Ea { get; set; }
        public string tgt_Geo_Para_Ea { get; set; }

        //定义字段 平均——含气量 (m3/t) Gas Content
        public string tgt_Geo_Para_Gc_Avg { get; set; }

        //定义字段 平均——资源丰度 (108 m3/km2) Resource richness
        public string tgt_Geo_Para_Rr_Avg { get; set; }

        //定义字段 平均——孔隙度 (%) Porosity
        public string tgt_Geo_Para_Por_Avg { get; set; }

        //定义字段 构造复杂程度 Structure Complexity degree
        //public string Para_Scd { get; set; }
        public string tgt_Geo_Para_Scd { get; set; }

        //定义字段 顶底板条件 (m) roof-floor Thickness
        public string tgt_Geo_Para_Rfc { get; set; }

        /* 目标区 （核心区）工程参数
         * Target Engineering Params: tgt_Eng_Para_
         */
        
        //定义字段 平均——埋深范围(m)  Depth Range 
        public string tgt_Eng_Para_Dr_Avg { get; set; }

        //定义字段 平均——压力系数 Pressure Coefficient (Factor)
        public string tgt_Eng_Para_Pc_Avg { get; set; }

        //定义字段 渗透率 Permeability(页岩气开采中，这个参数实际上没用，因为是自生、自储、自盖)
        public string tgt_Eng_Para_Per { get; set; }

        //定义字段 裂缝发育程度 Fracture Development Degree
        //public string Para_Fdd { get; set; }
        public string tgt_Eng_Para_Fdd { get; set; }

        //定义字段 平均——主应力差异系数 Principle Stress Diversity Coefficient (Factor)
        //[(最大主应力-最小主应力)/最小主应力]
        public string tgt_Eng_Para_Psdc_Avg { get; set; }

        //定义字段 平均——脆性矿物含量 Brittle Mineral Content
        public string tgt_Eng_Para_Bmc_Avg { get; set; }

        //定义字段 水系 Drainage System
        public string tgt_Eng_Para_Ds { get; set; }

        //定义字段 区域勘探程度 Local Exploring Degree
        public string tgt_Eng_Para_Led { get; set; }

        /* 目标区 （核心区）市场参数 
         * Target Market Params : tgt_Mkt_Para_
         */

        //定义字段 市场气价 Gas Price
        public string tgt_Mkt_Para_Gp { get; set; }

        //定义字段 市场需求 Demand
        public string tgt_Mkt_Para_Dmd { get; set; }

        //定义字段 交通设施 Transport Utility
        public string tgt_Mkt_Para_Tu { get; set; }

        //定义字段 管网条件 Pipe Net
        public string tgt_Mkt_Para_Pn { get; set; }

        //定义字段 地表地貌 Suface and Geography
        public string tgt_Mkt_Para_Sg { get; set; }

        //目标区块的Id
        public int tgt_Att_Id { get; set; }

    }
}

