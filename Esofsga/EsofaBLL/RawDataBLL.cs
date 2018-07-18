using EsofaDAL;
using EsofaModel;
using System.Collections.Generic;

namespace EsofaBLL
{
    public partial class RawDataBLL
    {
        public List<RawData> GetList()
        {
            //创建数据层对象
            RawDataDAL rDataDal = new RawDataDAL();

            //调用查询方法，返回数据
            return rDataDal.GetList();
        }

        public int Insert(string sql)
        {
            RawDataDAL rdd = new RawDataDAL();
            return rdd.Insert(sql);
        }
    }
}
