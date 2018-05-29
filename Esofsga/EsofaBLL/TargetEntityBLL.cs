using EsofaDAL;
using EsofaModel;
using System.Collections.Generic;

namespace EsofaBLL
{
    public partial class TargetEntityBLL
    {
        public List<TargetEntity> GetList()
        {
            //创建数据层对象
            TargetEntityDAL rDataDal = new TargetEntityDAL();

            //调用查询方法，返回数据
            return rDataDal.GetList();
        }
    }
}
