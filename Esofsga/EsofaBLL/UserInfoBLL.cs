using EsofaDAL;
using EsofaModel;
using System.Collections.Generic;

namespace EsofaBLL
{
    public partial class UserInfoBLL
    {
        public List<UserInfo> GetList()
        {
            //创建数据层对象
            UserInfoDAL userInfoDAL = new UserInfoDAL();

            //调用查询方法
            return userInfoDAL.GetList();
        }
    }
}
