using EsofaDAL;
using EsofaModel;
using System.Collections.Generic;
namespace EsofaBLL
{
   public partial class BlockEntityBLL
    {
        public List<BlockEntity> GetList()
        {
            //创建数据层对象
            BlockEntityDAL rDataDal = new BlockEntityDAL();

            //调用查询方法，返回数据
            return rDataDal.GetList();
        }
    }
}
