using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaModel
{
    //盆地数据实体 (Basin: Prosepctive Area)
    //public partial class BasinEntity
    //{
    //    //盆地（远景区）实体所有参数用 bsn_ 开始
    //    //盆地（远景区） 关联参数 Basin Attribute Params
    //    public string bsn_Att_Name { get; set; }
    //    //public string bsn_Att_Code { get; set; }

    //    /* 盆地（远景区）实体所有参数用 bsn_ 开始
    //      * 属性条件 bsn_Att_ ,
    //      * 地质条件 bsn_Geo_ ,
    //      * 工程条件 bsn_Eng_ , 
    //      */

    //    //盆地（远景区）属性参数 Basin Attribute Params
    //    //定义字段 区块 block  
    //    //public string para_Blk { get; set; }
    //    //public string bsn_Att_Name { get; set; }
    //    //public string bsn_Att_Code { get; set; }
    //    //定义字段 主力层系 primary Strata
    //    public string bsn_Att_Ps { get; set; }

    //    //定义字段 保存条件 Storage Condition
    //    //public string Para_Sc { get; set; }
    //    public string bsn_Att_Para_Sc { get; set; }

    //    //定义字段 地质资源量 (万亿方) geological resource
    //    //public string Para_Gr { get; set; }
    //    public string bsn_Att_Para_Gr { get; set; }


    //    /* 盆地区 （远景区）地质参数
    //     * Basin Geology Params:  bsn_Geo_Para_
    //     */
    //    //定义字段 富有机质页岩平均厚度(m) Average Shale Thickness Riching Organic Matters 
    //    //public string Para_StromAt { get; set; }
    //   // public string bsn_Geo_Para_Astrom { get; set; }

    //    //定义字段 富有机质页岩厚度范围(m) Thinckness Range Riching Organic Matters Shale
    //    public string bsn_Geo_Para_TrRoms { get; set; }

    //    //定义字段 Toc 总有机碳
    //    //public string Para_Toc { get; set; }
    //    public string bsn_Geo_Para_Toc { get; set; }

    //    //定义字段 Kt 有机质类型 Kerogen Type
    //    public string bsn_Geo_Para_Kt { get; set; }

    //    //定义字段 Ro 有机质成熟度
    //    // public string Para_Ro { get; set; }
    //    public string bsn_Geo_Para_Ro { get; set; }

    //    //定义字段 有效圈定面积(km2) Effective Area
    //    // public string Para_Ea { get; set; }
    //    public string bsn_Geo_Para_Ea { get; set; }

    //    //定义字段 含气量 (m3/t) Gas Content
    //    // public string Para_Gc { get; set; }
    //    //public string bsn_Geo_Para_Gc { get; set; }

    //    //定义字段 资源丰度 (108 m3/km2) Resource richness
    //    // public string Para_Rr { get; set; }
    //    public string bsn_Geo_Para_Rr { get; set; }

    //    //定义字段 孔隙度 (%) Porosity
    //    //public string Para_Por { get; set; }
    //    //public string bsn_Geo_Para_Por { get; set; }

    //    //定义字段 构造复杂程度 Structure Complexity degree
    //    //public string Para_Scd { get; set; }
    //    public string bsn_Geo_Para_Scd { get; set; }

    //    //定义字段 顶底板厚度 (m) roof-floor Thickness
    //    //public string Para_Trf { get; set; }
    //    //定义字段 顶板岩性 Roof Lithology
    //    //public string bsn_Geo_Para_Rfl { get; set; }

    //    //定义字段 顶板厚度 Roof Thickness
    //    //public string bsn_Geo_Para_Rft { get; set; }

    //    //定义字段 底板岩性 Floor Lithology
    //    //public string bsn_Geo_Para_Frl { get; set; }

    //    //定义字段 底板厚度 Floor Thickness
    //    //public string bsn_Geo_Para_Frt { get; set; }


    //    /* 盆地区 （远景区）工程参数
    //     * Basin Engineering Params: bsn_Eng_Para_
    //     */
    //    //定义字段 埋深范围均值(m) Average Depth 
    //    // public string Para_Dr { get; set; }
    //    //public string bsn_Eng_Para_Ad { get; set; }

    //    //定义字段 埋深范围(m)  Depth Range 
    //    public string bsn_Eng_Para_Dr { get; set; }

    //    //定义字段 压力系数 Pressure Coefficient (Factor)
    //    //public string Para_Pf { get; set; }
    //    //public string bsn_Eng_Para_Pc { get; set; }

    //    //定义字段 渗透率 Permeability
    //    //public string bsn_Eng_Para_Per { get; set; }

    //    //定义字段 裂缝发育程度 Fracture Development Degree
    //    //public string Para_Fdd { get; set; }
    //    // public string bsn_Eng_Para_Fdd { get; set; }

    //    //定义字段 主应力差异系数 Principle Stress Diversity Coefficient (Factor)
    //    // public string Para_Psdf { get; set; }
    //    //public string bsn_Eng_Para_Psdc { get; set; }

    //    //定义字段 脆性矿物含量 Brittle Mineral Content
    //    //public string Para_Bmc { get; set; }
    //    public string bsn_Eng_Para_Bmc { get; set; }

    //    //定义字段 水系 Drainage System
    //    //public string bsn_Eng_Para_Ds { get; set; }

    //    //定义字段 区域勘探程度 Local Exploring Degree
    //    //public string bsn_Eng_Para_Led { get; set; }

    //    /* 盆地区 （远景区）没有 市场参数 
    //     * Basin Market Params : bsn_Mkt_Para_
         
    //    //定义字段 市场气价 Gas Price
    //    public string bsn_Mkt_Para_Gp { get; set; }

    //    //定义字段 市场需求 Demand
    //    public string bsn_Mkt_Para_Dmd { get; set; }

    //    //定义字段 交通设施 Transport Utility
    //    public string bsn_Mkt_Para_Tu { get; set; }

    //    //定义字段 管网条件 Pipe Net
    //    public string bsn_Mkt_Para_Pn { get; set; }

    //    //定义字段 地表地貌 Suface and Geography
    //    public string bsn_Mkt_Para_Sg { get; set; }


    //    //定义字段 富有机质页岩厚度(m) shale Thickness Riching Organic Matters
    //    //public string Para_Strom { get; set; }
    //    */
    //}
}
