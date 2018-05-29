using EsofaModel;
using System.Collections.Generic;
using System.Data;
using EsofaCommon;

namespace EsofaDAL
{
    public partial class TargetEntityDAL
    {
        public List<TargetEntity> GetList()
        {
            string sql = "select * from RawData";
            DataTable dt = SqliteHelper.GetDataTable(sql);
            DataAssignment dA = new DataAssignment();
            //构造要查询的 sql语句
            // string sql = "select * from RawData";

            //使用SQLIT额Helper进行查询
            // DataTable dt = SqliteHelper.GetDataTable(sql);

            //将dt中的数据转存到list当中
            List<TargetEntity> list = new List<TargetEntity>();
            //DataTable dt = new DataTable();
            return dA.Assign(list, dt);

        }
    }
}
