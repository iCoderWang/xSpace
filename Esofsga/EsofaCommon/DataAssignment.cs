using EsofaModel;
using System.Collections.Generic;
using System.Data;

namespace EsofaCommon
{
    public partial class DataAssignment
    {
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
    }
}
