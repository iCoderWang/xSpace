using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsofaDAL;

namespace EsofaBLL
{
    public partial class UserAddBLL
    {
        public int Add(string strUserName, string strUserPwd, string strUserRole)
        {
            //创建数据层对象
            UserAddDAL uad = new UserAddDAL();

            //调用查询方法
            return uad.Add(strUserName,strUserPwd,strUserRole);
        }
    }
}
