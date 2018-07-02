using System.Collections.Generic;
using System.Data;
using EsofaModel;
using EsofaCommon;

namespace EsofaDAL
{
    public partial class UserInfoDAL
    {
        public List <UserInfo> GetList()
        {
            //构造要查询的sql语句
            string sql = "select * from user_info";

            //使用SqliteHelper进行查询，得到结果
            DataTable dt = MySqlHelper.GetDataTable(sql,CommandType.Text);

            DataAssignment da = new DataAssignment();
            //将Dt中的数据转存到list中
            List<UserInfo> list = new List<UserInfo>();
            return da.Assign(list, dt);
        }

    }
}
