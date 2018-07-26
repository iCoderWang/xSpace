using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaModel
{
    //盆地数据实体 (Basin: Prosepctive Area)
    public partial class AverageValuesBasinEntity
    {
        //盆地（远景区）实体所有参数用 bsn_ 开始
        
        //目标区块的序号
        public int tgt_Att_Sn { get; set; }

        //定义字段 区块 block  
        public string tgt_Att_Name { get; set; }
        //盆地（远景区） 关联参数 Basin Attribute Params
        public string bsn_Att_Name { get; set; }
        //public string bsn_Att_Code { get; set; }

        /* 盆地（远景区）实体所有参数用 bsn_ 开始
          * 属性条件 bsn_Att_ ,
          * 地质条件 bsn_Geo_ ,
          * 工程条件 bsn_Eng_ , 
          */

        //盆地（远景区）属性参数 Basin Attribute Params
        //主力层系 Primary Strata
        public string bsn_Att_Ps { get; set; }

        //定义字段 保存条件 Storage Condition
        //public string Para_Sc { get; set; }
        public string bsn_Att_Para_Sc { get; set; }

        //定义字段 地质资源量 (万亿方) geological resource
        //public string Para_Gr { get; set; }
        public string bsn_Att_Para_Gr { get; set; }


        /* 盆地区 （远景区）地质参数
         * Basin Geology Params:  bsn_Geo_Para_
         */

        //定义字段 富有机质页岩厚度范围(m) Thinckness Range Riching Organic Matters Shale
        public string bsn_Geo_Para_TrRoms { get; set; }

        //定义字段 Toc 总有机碳
        //public string Para_Toc { get; set; }
        public string bsn_Geo_Para_Toc { get; set; }

        //定义字段 Kt 有机质类型 Kerogen Type
        public string bsn_Geo_Para_Kt { get; set; }

        //定义字段 Ro 有机质成熟度
        // public string Para_Ro { get; set; }
        public string bsn_Geo_Para_Ro { get; set; }

        //定义字段 有效圈定面积(km2) Effective Area
        // public string Para_Ea { get; set; }
        public string bsn_Geo_Para_Ea { get; set; }

        //定义字段 资源丰度 (108 m3/km2) Resource richness
        public string bsn_Geo_Para_Rr { get; set; }

        //定义字段 构造复杂程度 Structure Complexity degree
        public string bsn_Geo_Para_Scd { get; set; }
        
        //定义字段 埋深范围(m)  Depth Range 
        public string bsn_Eng_Para_Dr { get; set; }

        //定义字段 平均——脆性矿物含量 Brittle Mineral Content
        public string bsn_Eng_Para_Bmc { get; set; }
        
        //目标区块的Id
        public int tgt_Att_Id { get; set; }
    }
}
