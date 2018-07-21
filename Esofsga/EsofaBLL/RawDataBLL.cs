using EsofaDAL;
using EsofaModel;
using System.Collections.Generic;

namespace EsofaBLL
{
    public partial class RawDataBLL
    {
        public List<TargetEntity> GetList()
        {
            //创建数据层对象
            RawDataDAL rDataDal = new RawDataDAL();

            //调用查询方法，返回数据
            return rDataDal.GetList();
        }

        public List<TargetEntity> GetList(string sql)
        {
            //创建数据层对象
            RawDataDAL rDataDal = new RawDataDAL();

            //调用查询方法，返回数据
            return rDataDal.GetList(sql);
        }
        public List<AverageValuesTargetEntity> GetAvg_List(string sql)
        {
            //创建数据层对象
            RawDataDAL rDataDal = new RawDataDAL();

            //调用查询方法，返回数据
            return rDataDal.GetAvg_List(sql);
        }
        public int Insert(string sql)
        {
            RawDataDAL rdd = new RawDataDAL();
            return rdd.Insert(sql);
        }

        public void ExecuteCmd(string sql)
        {
            RawDataDAL rdd = new RawDataDAL();
            rdd.ExecuteCmd(sql);
        }
    }
}
