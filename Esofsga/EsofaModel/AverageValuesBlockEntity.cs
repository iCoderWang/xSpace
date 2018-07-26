using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaModel
{
    //区块数据实体（Block: Favorit Area）
    public partial class AverageValuesBlockEntity
    {
        //区块实体所有参数用 blk_ 开始
        //目标区块的序号
        public int tgt_Att_Sn { get; set; }

        //定义字段 区块 block  
        public string tgt_Att_Name { get; set; }

        //盆地名称（远景区） 关联参数 Basin Attribute Params
        public string bsn_Att_Name { get; set; }
        //public string bsn_Att_Code { get; set; }
       

        /* 区块实体所有参数用 blk_ 开始
          * 属性条件 blk_Att_ ,
          * 地质条件 blk_Geo_ ,
          * 工程条件 blk_Eng_ , 
          * 市场条件 blk_Mkt_ ,
          */

        //区块 （有利区）属性参数 Target Attribution Params

        //定义字段 主力层系 primary Strata
        public string blk_Att_Ps { get; set; }

        //定义字段 保存条件 Storage Condition
        //public string Para_Sc { get; set; }
        public string blk_Att_Para_Sc { get; set; }

        //定义字段 地质资源量 (万亿方) geological resource
        //public string Para_Gr { get; set; }
        public string blk_Att_Para_Gr { get; set; }


        /* 区块 （有利区）地质参数
         * Target Geology Params:  blk_Geo_Para_
         */

        //定义字段 富有机质页岩厚度范围(m) Thinckness Range Riching Organic Matters Shale
        public string blk_Geo_Para_TrRoms { get; set; }

        //定义字段 Toc 总有机碳
        //public string Para_Toc { get; set; }
        public string blk_Geo_Para_Toc { get; set; }

        //定义字段 Kt 有机质类型 Kerogen Type
        public string blk_Geo_Para_Kt { get; set; }

        //定义字段 Ro 有机质成熟度
        // public string Para_Ro { get; set; }
        public string blk_Geo_Para_Ro { get; set; }

        //定义字段 有效圈定面积(km2) Effective Area
        // public string Para_Ea { get; set; }
        public string blk_Geo_Para_Ea { get; set; }

        //定义字段 含气量 (m3/t) Gas Content
        // public string Para_Gc { get; set; }
        public string blk_Geo_Para_Gc { get; set; }

        //定义字段 资源丰度 (108 m3/km2) Resource richness
        // public string Para_Rr { get; set; }
        public string blk_Geo_Para_Rr { get; set; }

        //定义字段 孔隙度 (%) Porosity
        //public string Para_Por { get; set; }
        public string blk_Geo_Para_Por { get; set; }

        //定义字段 构造复杂程度 Structure Complexity degree
        //public string Para_Scd { get; set; }
        public string blk_Geo_Para_Scd { get; set; }
        
        /* 区块 （有利区）工程参数
         * Target Engineering Params: blk_Eng_Para_
         */
        //定义字段 埋深范围(m)  Depth Range 
        public string blk_Eng_Para_Dr { get; set; }

        //定义字段 压力系数 Pressure Coefficient (Factor)
        //public string Para_Pf { get; set; }
        public string blk_Eng_Para_Pc { get; set; }

        //定义字段 平均——脆性矿物含量 Brittle Mineral Content
        public string blk_Eng_Para_Bmc { get; set; }
        
        /* 区块 （有利区）市场参数 
         * Target Market Params : blk_Mkt_Para_
         */
         
        //定义字段 地表地貌 Suface and Geography
        public string blk_Mkt_Para_Sg { get; set; }

        //目标区块的Id
        public int tgt_Att_Id { get; set; }
    }
}
