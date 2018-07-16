using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using EsofaCommon;
using EsofaModel;

namespace EsofaDAL
{
   public partial class UserManageDAL
    {
        /// <summary>
        /// 添加记录语句
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strUserPwd"></param>
        /// <param name="strUserRole"></param>
        /// <returns></returns>
        public int Add(string strUserName, string strUserPwd, string strUserRole)
        {
            //构造要增加的sql语句
            string sql = "insert into user_info (user_name,user_password,user_role) values ('"
                + strUserName+"','"+ strUserPwd+"','"+ strUserRole+"')";

            //使用SqliteHelper进行查询，得到结果
            int rowCount = MySqlHelper.ExecuteNonQuery(sql, CommandType.Text);

            return rowCount;
        }
        /// <summary>
        /// 删除记录语句
        /// </summary>
        /// <param name="userID"></param>
        public void Delete(int userID)
        {
            //构造要执行的删除语句
            string sql = "delete from user_info where user_id=" + userID;
            //使用MySQLHelper进行删除
            int rowCount = MySqlHelper.ExecuteNonQuery(sql, CommandType.Text);
        }

        public void Update(string sqlTemp,int userID)
        {
            //构造要执行的更新语句
            //string sql = "update user_info set user_role=" + userRole + "where user_id =" + userID;
            string sql = sqlTemp + "where user_id =" + userID;
            //使用MySQLHelper进行更新
            int rowCount = MySqlHelper.ExecuteNonQuery(sql, CommandType.Text);
        }
    }
}
