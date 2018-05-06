using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using EsofaModel;

namespace EsofaDAL
{
    public partial class UserInfoDAL
    {
        public List <UserInfo> GetList()
        {
            //构造要查询的sql语句
            string sql = "select UserId,UserName,UserType from UserInfo";

            //使用SqliteHelper进行查询，得到结果
            DataTable dt = SqliteHelper.GetDataTable(sql);

            //将Dt中的数据转存到list中
            List<UserInfo> list = new List<UserInfo>();
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new UserInfo()
                {
                    UserId = Convert.ToInt32(row["UserId"]),
                    UserName = row["UserName"].ToString(),
                    //UserPwd = row["UserPwd"].ToString(),
                    UserType = Convert.ToInt32 (row["UserType"])
                });
            }
            //将集合返回
            return list;
        }

    }
}
