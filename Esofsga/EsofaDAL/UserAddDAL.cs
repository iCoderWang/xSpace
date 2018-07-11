using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using EsofaCommon;
using EsofaModel;

namespace EsofaDAL
{
   public partial class UserAddDAL
    {
        public int Add(string strUserName, string strUserPwd, string strUserRole)
        {
            //构造要增加的sql语句
            string sql = "insert into user_info (user_name,user_password,user_role) values ('"
                + strUserName+"','"+ strUserPwd+"','"+ strUserRole+"')";

            //使用SqliteHelper进行查询，得到结果
            int rowCount = MySqlHelper.ExecuteNonQuery(sql, CommandType.Text);

            return rowCount;
        }
    }
}
