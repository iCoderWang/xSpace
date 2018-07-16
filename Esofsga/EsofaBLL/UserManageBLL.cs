using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsofaDAL;

namespace EsofaBLL
{
    public partial class UserManageBLL
    {
        public int Add(string strUserName, string strUserPwd, string strUserRole)
        {
            //创建数据层对象
            UserManageDAL uad = new UserManageDAL();

            //调用查询方法
            return uad.Add(strUserName,strUserPwd,strUserRole);
        }
        public void Delete(int userID)
        {
            UserManageDAL umd = new UserManageDAL();
            umd.Delete(userID);
        }

        public void Update(string sql, int userID)
        {
            UserManageDAL umd = new UserManageDAL();
            umd.Update(sql, userID);
        }
    }
}
