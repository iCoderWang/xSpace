using EsofaModel;
using System.Collections.Generic;
using System.Data;
using EsofaCommon;

namespace EsofaDAL
{
    public partial class RawDataDAL
    {
       
        
        //public List<RawData> Assign(List<RawData> list,DataTable dt )
        //{
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        list.Add(new RawData()
        //        {
        //            //获取字段 区块 block
        //            para_Blk = row["para_Blk"].ToString(),

        //            //获取字段 主力层系 primary Strata
        //            para_Ps = row["para_Ps"].ToString(),

        //            //获取字段 埋深范围(m) depth Range
        //            para_Dr = row["para_Dr"].ToString(),

        //            //获取字段 有效面积(km2) effective Area
        //            para_Ea = row["para_Ea"].ToString(),

        //            //获取字段 富有机质页岩厚度(m) shale Thickness Riching Organic Matters
        //            para_Strom = row["para_Strom"].ToString(),

        //            //获取字段 平均厚度(m) average Thickness
        //            para_StromAt = row["para_StromAt"].ToString(),

        //            //获取字段 Toc 总有机碳
        //            para_Toc = row["para_Toc"].ToString(),

        //            //获取字段 RO
        //            para_Ro = row["para_Ro"].ToString(),

        //            //获取字段 保存条件 storage Condition
        //            para_Sc = row["para_Sc"].ToString(),

        //            //获取字段 资源丰度 (108 m3/km2) resource richness
        //            para_Rr = row["para_Rr"].ToString(),

        //            //获取字段 含气量 (m3/t) gas Content
        //            para_Gc = row["para_Gc"].ToString(),

        //            //获取字段 孔隙度 (%) porosity
        //            para_Por = row["para_Por"].ToString(),

        //            //获取字段 构造复杂程度 structure complexity degree
        //            para_Scd = row["para_Scd"].ToString(),

        //            //获取字段 顶底板厚度 (m) roof-floor Thickness
        //            para_Trf = row["para_Trf"].ToString(),

        //            //获取字段 裂缝发育程度 fracture Development Degree
        //            para_Fdd = row["para_Fdd"].ToString(),

        //            //获取字段 脆性矿物含量 brittle Mineral Content
        //            para_Bmc = row["para_Bmc"].ToString(),

        //            //获取字段 主应力差异系数 principle Stress Diversity Factor
        //            para_Psdf = row["para_Psdf"].ToString(),

        //            //获取字段 压力系数 pressure Factor
        //            para_Pf = row["para_Pf"].ToString(),

        //            //获取字段 地质资源量 (万亿方) geological resource
        //            para_Gr = row["para_Gr"].ToString()
        //        });
               
        //    }
        //    //将集合返回
        //    return list;
        //}
        public List <RawData> GetList()
        {
            string sql = "select * from RawData";
            DataTable dt = SqliteHelper.GetDataTable(sql);
            DataAssignment dA = new DataAssignment();
        //构造要查询的 sql语句
        // string sql = "select * from RawData";

        //使用SQLIT额Helper进行查询
        // DataTable dt = SqliteHelper.GetDataTable(sql);

        //将dt中的数据转存到list当中
            List<RawData> list = new List<RawData>();
            //DataTable dt = new DataTable();
            return dA.Assign(list,dt);
            //foreach(DataRow row in dt.Rows)
            //{
            //    list.Add(new RawData()
            //    {
            //        //获取字段 区块 block
            //        para_Blk = row["para_Blk"].ToString(),

            //        //获取字段 主力层系 primary Strata
            //        para_Ps = row["para_Ps"].ToString(),

            //        //获取字段 埋深范围(m) depth Range
            //        para_Dr = row["para_Dr"].ToString(),

            //        //获取字段 有效面积(km2) effective Area
            //        para_Ea = row["para_Ea"].ToString(),

            //        //获取字段 富有机质页岩厚度(m) shale Thickness Riching Organic Matters
            //        para_Strom = row["para_Strom"].ToString(),

            //        //获取字段 平均厚度(m) average Thickness
            //        para_StromAt = row["para_StromAt"].ToString(),

            //        //获取字段 Toc 总有机碳
            //        para_Toc = row["para_Toc"].ToString(),

            //        //获取字段 RO
            //        para_Ro = row["para_Ro"].ToString(),

            //        //获取字段 保存条件 storage Condition
            //        para_Sc = row["para_Sc"].ToString(),

            //        //获取字段 资源丰度 (108 m3/km2) resource richness
            //        para_Rr = row["para_Rr"].ToString(),

            //        //获取字段 含气量 (m3/t) gas Content
            //        para_Gc = row["para_Gc"].ToString(),

            //        //获取字段 孔隙度 (%) porosity
            //        para_Por = row["para_Por"].ToString(),

            //        //获取字段 构造复杂程度 structure complexity degree
            //        para_Scd = row["para_Scd"].ToString(),

            //        //获取字段 顶底板厚度 (m) roof-floor Thickness
            //        para_Trf = row["para_Trf"].ToString(),

            //        //获取字段 裂缝发育程度 fracture Development Degree
            //        para_Fdd = row["para_Fdd"].ToString(),

            //        //获取字段 脆性矿物含量 brittle Mineral Content
            //        para_Bmc = row["para_Bmc"].ToString(),

            //        //获取字段 主应力差异系数 principle Stress Diversity Factor
            //        para_Psdf = row["para_Psdf"].ToString(),

            //        //获取字段 压力系数 pressure Factor
            //        para_Pf = row["para_Pf"].ToString(),

            //        //获取字段 地质资源量 (万亿方) geological resource
            //        para_Gr = row["para_Gr"].ToString()
            //    });
            //}
            //将集合返回
           // return list;

        }
    }
}
