﻿using EsofaModel;
using System.Collections.Generic;
using System.Data;

namespace EsofaCommon
{
    public partial class DataAssignment
    {
        //RawData数据体 实现数据表格化分配的方法 Asssign
        public List<RawData> Assign (List<RawData> list, DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new RawData()
                {
                    //获取字段 区块 block
                    para_Blk = row[0].ToString(),

                    //获取字段 主力层系 primary Strata
                    para_Ps = row[1].ToString(),

                    //获取字段 埋深范围(m) depth Range
                    para_Dr = row[2].ToString(),

                    //获取字段 有效面积(km2) effective Area
                    para_Ea = row[3].ToString(),

                    //获取字段 富有机质页岩厚度(m) shale Thickness Riching Organic Matters
                    para_Strom = row[4].ToString(),

                    //获取字段 平均厚度(m) average Thickness
                    para_StromAt = row[5].ToString(),

                    //获取字段 Toc 总有机碳
                    para_Toc = row[6].ToString(),

                    //获取字段 RO
                    para_Ro = row[7].ToString(),

                    //获取字段 保存条件 storage Condition
                    para_Sc = row[8].ToString(),

                    //获取字段 资源丰度 (108 m3/km2) resource richness
                    para_Rr = row[9].ToString(),

                    //获取字段 含气量 (m3/t) gas Content
                    para_Gc = row[10].ToString(),

                    //获取字段 孔隙度 (%) porosity
                    para_Por = row[11].ToString(),

                    //获取字段 构造复杂程度 structure complexity degree
                    para_Scd = row[12].ToString(),

                    //获取字段 顶底板厚度 (m) roof-floor Thickness
                    para_Trf = row[13].ToString(),

                    //获取字段 裂缝发育程度 fracture Development Degree
                    para_Fdd = row[14].ToString(),

                    //获取字段 脆性矿物含量 brittle Mineral Content
                    para_Bmc = row[15].ToString(),

                    //获取字段 主应力差异系数 principle Stress Diversity Factor
                    para_Psdf = row[16].ToString(),

                    //获取字段 压力系数 pressure Factor
                    para_Pf = row[17].ToString(),

                    //获取字段 地质资源量 (万亿方) geological resource
                    para_Gr = row[18].ToString()
                });

            }
            //将集合返回
            return list;
        }

        //远景区 BasinEntity数据体 实现数据表格化分配方法 Assign 重载
        //public List<BasinEntity> Assign(List<BasinEntity> list, DataTable dt)
        //{
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        list.Add(new BasinEntity()
        //        {
        //            //获取字段 盆地名字 basin name
        //            bsn_Att_Name = row[0].ToString(),

        //            //获取字段 盆地代码 basin code
        //            // bsn_Att_Code = row[0].ToString(),

        //            //获取字段 主力层系 primary Strata
        //            bsn_Att_Ps = row[1].ToString(),

        //            //定义字段 保存条件 Storage Condition
        //            bsn_Att_Para_Sc = row[2].ToString(),

        //            //定义字段 地质资源量 (万亿方) geological resource
        //            bsn_Att_Para_Gr = row[3].ToString(),

        //            //定义字段 富有机质页岩厚度范围(m) Thinckness Range Riching Organic Matters Shale
        //            bsn_Geo_Para_TrRoms = row[4].ToString(),

        //            //定义字段 Toc 总有机碳
        //            bsn_Geo_Para_Toc = row[5].ToString(),

        //            //定义字段 Kt 有机质类型 Kerogen Type
        //            bsn_Geo_Para_Kt = row[6].ToString(),

        //            //定义字段 Ro 有机质成熟度
        //            bsn_Geo_Para_Ro = row[7].ToString(),

        //            //定义字段 有效圈定面积(km2) Effective Area
        //            bsn_Geo_Para_Ea = row[8].ToString(),

        //            //定义字段 资源丰度 (108 m3/km2) Resource richness
        //            bsn_Geo_Para_Rr = row[9].ToString(),

        //            //定义字段 构造复杂程度 Structure Complexity degree
        //            bsn_Geo_Para_Scd = row[10].ToString(),

        //            //定义字段 埋深范围(m)  Depth Range 
        //            bsn_Eng_Para_Dr = row[11].ToString(),

        //            //定义字段 脆性矿物含量 Brittle Mineral Content
        //            bsn_Eng_Para_Bmc = row[12].ToString()
        //        });

        //    }
        //    //将集合返回
        //    return list;
        //}

        //有利区 BlockEntity数据体 实现数据表格化分配方法 Assign 重载
        //public List<BlockEntity> Assign(List<BlockEntity> list, DataTable dt)
        //{
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        list.Add(new BlockEntity()
        //        {
        //            //获取字段 盆地名字 basin name
        //            bsn_Att_Name = row[0].ToString(),

        //            //获取字段 盆地代码 basin code
        //            // bsn_Att_Code = row[0].ToString(),

        //            //获取字段 区块名字 block name
        //            blk_Att_Name = row[1].ToString(),

        //            //获取字段 区块代码 block code
        //            // blk_Att_Code = row[0].ToString(),

        //            //获取字段 主力层系 primary Strata
        //            blk_Att_Ps = row[2].ToString(),

        //            //定义字段 保存条件 Storage Condition
        //            blk_Att_Para_Sc = row[3].ToString(),

        //            //定义字段 地质资源量 (万亿方) geological resource
        //            blk_Att_Para_Gr = row[4].ToString(),

        //            //定义字段 富有机质页岩厚度范围(m) Thinckness Range Riching Organic Matters Shale
        //            blk_Geo_Para_TrRoms = row[5].ToString(),

        //            //定义字段 Toc 总有机碳
        //            blk_Geo_Para_Toc = row[6].ToString(),

        //            //定义字段 Kt 有机质类型 Kerogen Type
        //            blk_Geo_Para_Kt = row[7].ToString(),

        //            //定义字段 Ro 有机质成熟度
        //            blk_Geo_Para_Ro = row[8].ToString(),

        //            //定义字段 有效圈定面积(km2) Effective Area
        //            blk_Geo_Para_Ea = row[9].ToString(),

        //            //定义字段 含气量 (m3/t) Gas Content
        //            blk_Geo_Para_Gc = row[10].ToString(),

        //            //定义字段 资源丰度 (108 m3/km2) Resource richness
        //            blk_Geo_Para_Rr = row[11].ToString(),

        //            //定义字段 孔隙度 (%) Porosity
        //            blk_Geo_Para_Por = row[12].ToString(),

        //            //定义字段 构造复杂程度 Structure Complexity degree
        //            blk_Geo_Para_Scd = row[13].ToString(),

        //            //定义字段 埋深范围(m)  Depth Range 
        //            blk_Eng_Para_Dr = row[14].ToString(),

        //            //定义字段 压力系数 Pressure Coefficient (Factor)
        //            blk_Eng_Para_Pc = row[15].ToString(),

        //            //定义字段 脆性矿物含量 Brittle Mineral Content
        //            blk_Eng_Para_Bmc = row[16].ToString(),

        //            //定义字段 地表地貌 Suface and Geography
        //            blk_Mkt_Para_Sg = row[17].ToString()
        //        });

        //    }
        //    //将集合返回
        //    return list;
        //}

        //核心区 TargetEntity数据体 实现数据表格化分配方法 Assign 重载
        public List<TargetEntity> Assign(List<TargetEntity> list, DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TargetEntity()
                {
                    

                    //获取字段 盆地代码 basin code
                    // bsn_Att_Code = row[0].ToString(),

                    //获取字段 区块名字 block name
                    //blk_Att_Name = row[1].ToString(),

                    //获取字段 区块代码 block code
                    // blk_Att_Code = row[0].ToString(),

                    //获取字段 目标区名字 Target name
                    tgt_Att_Name = row[0].ToString(),

                    //获取字段 盆地名字 basin name
                    bsn_Att_Name = row[1].ToString(),

                    //获取字段 目标区代码 target code
                    // tgt_Att_Code = row[0].ToString(),

                    //获取字段 主力层系 primary Strata
                    tgt_Att_Ps = row[2].ToString(),

                    //定义字段 保存条件 Storage Condition
                    tgt_Att_Para_Sc = row[3].ToString(),

                    //定义字段 最小——地质资源量 (万亿方) geological resource
                    tgt_Att_Para_Gr_Min = row[4].ToString(),

                    //定义字段 最大——地质资源量 (万亿方) geological resource
                    tgt_Att_Para_Gr_Max = row[5].ToString(),

                    //定义字段 最小——富有机质页岩厚度范围(m) Thinckness Range Riching Organic Matters Shale
                    tgt_Geo_Para_TrRoms_Min = row[6].ToString(),

                    //定义字段 最大——富有机质页岩厚度范围(m) Thinckness Range Riching Organic Matters Shale
                    tgt_Geo_Para_TrRoms_Max = row[7].ToString(),

                    //定义字段 最小——Toc 总有机碳
                    tgt_Geo_Para_Toc_Min = row[8].ToString(),

                    //定义字段 最大——Toc 总有机碳
                    tgt_Geo_Para_Toc_Max = row[9].ToString(),

                    //定义字段 Kt 有机质类型 Kerogen Type
                    tgt_Geo_Para_Kt = row[10].ToString(),

                    //定义字段 最小——Ro 有机质成熟度
                    tgt_Geo_Para_Ro_Min = row[11].ToString(),

                    //定义字段 最大——Ro 有机质成熟度
                    tgt_Geo_Para_Ro_Max = row[12].ToString(),

                    //定义字段 有效圈定面积(km2) Effective Area
                    tgt_Geo_Para_Ea = row[13].ToString(),

                    //定义字段 最小——含气量 (m3/t) Gas Content
                    tgt_Geo_Para_Gc_Min = row[14].ToString(),

                    //定义字段 最大——含气量 (m3/t) Gas Content
                    tgt_Geo_Para_Gc_Max = row[15].ToString(),

                    //定义字段 最小——资源丰度 (10^8 m^3/km^2 亿立方/平方公里) Resource richness
                    tgt_Geo_Para_Rr_Min = row[16].ToString(),

                    //定义字段 最大——资源丰度 (10^8 m^3/km^2 亿立方/平方公里) Resource richness
                    tgt_Geo_Para_Rr_Max = row[17].ToString(),

                    //定义字段 最小——孔隙度 (%) Porosity
                    tgt_Geo_Para_Por_Min = row[18].ToString(),

                    //定义字段 最大——孔隙度 (%) Porosity
                    tgt_Geo_Para_Por_Max = row[19].ToString(),

                    //定义字段 构造复杂程度 Structure Complexity degree
                    tgt_Geo_Para_Scd = row[20].ToString(),

                    //定义字段 顶底板条件 Roof—Floor Conditions
                    tgt_Geo_Para_Rfc = row[21].ToString(),

                    //定义字段 顶板岩性 Roof Lithology
                    //tgt_Geo_Para_Rfl = row[15].ToString(),

                    //定义字段 顶板厚度 Roof Thickness
                    //tgt_Geo_Para_Rft = row[16].ToString(),

                    //定义字段 底板岩性 Floor Lithology
                    // tgt_Geo_Para_Frl = row[17].ToString(),

                    //定义字段 底板厚度 Floor Thickness
                    //tgt_Geo_Para_Frt = row[18].ToString(),

                    //定义字段 最小——埋深范围(m)  Depth Range 
                    tgt_Eng_Para_Dr_Min = row[22].ToString(),

                    //定义字段 最大——埋深范围(m)  Depth Range 
                    tgt_Eng_Para_Dr_Max = row[23].ToString(),

                    //定义字段 最小——压力系数 Pressure Coefficient (Factor)
                    tgt_Eng_Para_Pc_Min = row[24].ToString(),

                    //定义字段 最大——压力系数 Pressure Coefficient (Factor)
                    tgt_Eng_Para_Pc_Max = row[25].ToString(),

                    //定义字段 渗透率 Permeability
                    tgt_Eng_Para_Per = row[26].ToString(),

                    //定义字段 裂缝发育程度 Fracture Development Degree
                    tgt_Eng_Para_Fdd = row[27].ToString(),

                    //定义字段 最小——主应力差异系数 Principle Stress Diversity Coefficient (Factor)
                    tgt_Eng_Para_Psdc_Min = row[28].ToString(),

                    //定义字段 最大——主应力差异系数 Principle Stress Diversity Coefficient (Factor)
                    tgt_Eng_Para_Psdc_Max = row[29].ToString(),

                    //定义字段 最小——脆性矿物含量 Brittle Mineral Content
                    tgt_Eng_Para_Bmc_Min = row[30].ToString(),

                    //定义字段 最大——脆性矿物含量 Brittle Mineral Content
                    tgt_Eng_Para_Bmc_Max = row[31].ToString(),

                    //定义字段 水系 Drainage System
                    tgt_Eng_Para_Ds = row[32].ToString(),

                    //定义字段 区域勘探程度 Local Exploring Degree
                    tgt_Eng_Para_Led = row[33].ToString(),

                    //定义字段 市场气价 Gas Price
                    tgt_Mkt_Para_Gp = row[34].ToString(),

                    //定义字段 市场需求 Demand
                    tgt_Mkt_Para_Dmd = row[35].ToString(),

                    //定义字段 交通设施 Transport Utility
                    tgt_Mkt_Para_Tu = row[36].ToString(),

                    //定义字段 管网条件 Pipe Net
                    tgt_Mkt_Para_Pn = row[37].ToString(),

                    //定义字段 地表地貌 Suface and Geography
                    tgt_Mkt_Para_Sg = row[38].ToString()
                });

            }
            //将集合返回
            return list;
        }
    }
}
