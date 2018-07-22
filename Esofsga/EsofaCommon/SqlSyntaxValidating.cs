using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaCommon
{
    public partial class SqlSyntaxValidating
    {
        //定义静态数据库连接字符串,从配置文件中读取数据库连接字符串
        private static string connStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        /// <summary>
        ///   只检查SQL语法，不执行SQL语句。
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public  bool ValidateSQL(string sql)
        {
            bool bResult;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    cmd.Connection = conn;
                    //cmd.CommandText = "SET PARSEONLY ON";
                    // cmd.ExecuteNonQuery();
                    try
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        bResult = true;
                    }
                    catch (Exception ex)
                    {
                        bResult = false;
                    }                    
                }
            }
            return bResult;
        }
    }
}
