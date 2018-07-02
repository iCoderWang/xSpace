using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Collections;

namespace EsofaDAL
{
    /// <summary>
    /// MySqlHelper的摘要说明
    /// </summary>
    public abstract class MySqlHelper
    {
        /*
         配置你的MYSQL数据库链接字符串如下： 数据库连接字符串
         public static string Conn = "Database='数据库名';Data Source='数据库服务器地址';User Id='数据库用户名';Password='密码';charset='utf8';pooling=true";
        */
        //数据库连接字符串
        //public static string Conn = "Database='';Data Source='localhost';User Id='root';Password='4585';charset='utf8';pooling='true'";
        
        //定义静态数据库连接字符串,从配置文件中读取数据库连接字符串
        private static string connStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        //用于缓存参数的 HASH 表
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());

        /// <summary>
        /// 给定连接的数据库用假设参数执行个一个 sql 命令（不返回数据集）
        /// </summary>
        /// <param name="connectionString">一个有效的连接字符串</param>
        /// <param name="cmdType">命令类型（存储过程、文本，等等）</param>
        /// <param name="cmdText">存储过程名称或者 sql 命令语句</param>
        /// <param name="commandParameters">执行命令所用参数的集合</param>
        /// <returns>执行命令所影响的行数</returns>
        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, 
            params MySqlParameter[] commandParameters)
        {
            
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        /// <summary>
        /// 用现有的数据库连接执行一个 sql 命令（不返回数据集）
        /// </summary>
        /// <param name="connection">一个现有的数据库连接</param>
        /// <param name="cmdType">命令类型（存储过程，文本，等等）</param>
        /// <param name="cmdText">存储过程名称或者sql命令语句</param>
        /// <param name="commandParameters">执行命令所用参数的集合</param>
        /// <returns>执行命令所影响的行数</returns>
        public static int ExecuteNonQuery(MySqlConnection connection, CommandType cmdType, string cmdText,
            params MySqlParameter[] commandParameters)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
                
        }

        /// <summary>
        /// 使用现有的 SQL事务 执行一个 sql 命令（不返回数据集）
        /// </summary>
        /// <remaks>
        /// 举例：
        /// int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", 
        ///           new MySqlParameter("@prodid",24))
        /// </remaks>
        /// <param name="trans">一个现有的事务</param>
        /// <param name="cmdType">命令类型（存储过程，文本，等等）</param>
        /// <param name="cmdText">存储过程名称或者sql命令语句</param>
        /// <param name="commandParameters">执行命令所用参数的集合</param>
        /// <returns>执行命令所影响的行数</returns>
        public static int ExecuteNonQuery(MySqlTransaction trans, CommandType cmdType, string cmdText,
           params MySqlParameter[] commandParameters)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
               
        }

        /// <summary>
        /// 用执行的数据库连接执行一个返回数据集的 sql 命令
        /// </summary>
        /// <remarks>
        /// 举例：
        ///   MySqlDataReader r = ExecuteReader(connString, CommandType.StoredProcedure, "PublishOrders", 
        ///                 new MySqlParameter("@prodid",24))
        /// </remarks>
        /// <param name="connectionString">一个有效的连接字符串</param>
        /// <param name="cmdType">命令类型（存储过程，文本，等等）</param>
        /// <param name="cmdText">存储过程名称或者 sql 命令语句</param>
        /// <param name="commandParameters">执行命令所用参数的集合</param>
        /// <returns>包含结果的读取器</returns>
        public static MySqlDataReader ExecuteReader(string cmdText, CommandType cmdType, 
            params MySqlParameter[] commandParameters)
        {
            
            //创建一个 MySQLConnection 对象
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                //创建一个 MySQLCommand 对象
                MySqlCommand cmd = new MySqlCommand();
                //在这里我们用一个 try/catch 结构执行 sql 文本命令/存储过程，因为如果这个方法产生一个异常，我们要关闭连接，
                //因为没有读取器存在。
                //因此，commandBehavior.CloseConnection 就不会执行
                try
                {
                    //调用  PrepareCommand 方法，对 MySQLCommand 对象设置参数
                    PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                    //调用 MySQLCommand 的 ExecuteReader 方法
                    MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    //清除参数
                    cmd.Parameters.Clear();
                    return reader;
                }
                catch
                {
                    //关闭连接，抛出异常
                    conn.Close();
                    throw;
                }
            }            
        }

        /// <summary>
        /// 返回 DataSet
        /// </summary>
        /// <param name="connectionString">一个有效的连接字符串</param>
        /// <param name="cmdType">命令类型（存储过程，文本，等等）</param>
        /// <param name="cmdText">存储过程名称或者 sql 命令语句</param>
        /// <param name="commandParameters">执行命令所用参数的集合</param>
        /// <returns></returns>
        public static DataTable GetDataTable( string cmdText, CommandType cmdType, 
            params MySqlParameter[] commandParameters)
        {
            
            //创建一个 MySQLConnection 对象
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                //创建一个 MySQLCommand 对象
                MySqlCommand cmd = new MySqlCommand();
                //在这里我们用一个 try/catch 结构执行 sql 文本命令/存储过程，因为如果这个方法产生一个异常，我们要关闭连接，
                //因为没有读取器存在。
                //因此，commandBehavior.CloseConnection 就不会执行
                try
                {
                    //调用  PrepareCommand 方法，对 MySQLCommand 对象设置参数
                    PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                    //创建 MySqlDataAdapter 对象，将 cmd 赋值给 SelectCommand 属性
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    //创建 Dataset 对象
                    //DataSet ds = new DataSet();
                    //创建 Datatable对象
                    DataTable dt = new DataTable();
                    //adapter.Fill(ds);
                    adapter.Fill(dt);
                    //清除参数
                    cmd.Parameters.Clear();
                    conn.Close();
                    return dt; // ds;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }                
        }

        /// <summary>
        /// 用指定的数据库连接字符串执行一个命令并返回一个数据集的第一列
        /// </summary>
        /// <remarks>
        /// 例如：
        ///     Object obj = ExecuteScalar(connString, CommandType.StoredProcedure, "PublishOrders", 
        ///                new MySqlParameter("@prodid",24));
        /// </remarks>
        /// <param name="connectionString">一个有效的连接字符串</param>
        /// <param name="cmdType">命令类型（存储过程，文本，等等）</param>
        /// <param name="cmdText">存储过程名称或者 sql 命令语句</param>
        /// <param name="commandParameters">执行命令所用参数的集合</param>
        /// <returns>
        /// 用 Convert.To{Type} 把类型转换为想要的 
        /// </returns>
        public static object ExecuteScalar (string connectionString, CommandType cmdType, string cmdText, 
            params MySqlParameter[] commandParameters)
        {
            
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand();
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }

        /// <summary>
        /// 用指定的数据库连接字符串执行一个命令并返回一个数据集的第一列
        /// </summary>
        /// <remarks>
        /// 例如：
        ///     Object obj = ExecuteScalar(connString, CommandType.StoredProcedure, "PublishOrders", 
        ///                new MySqlParameter("@prodid",24));
        /// </remarks>
        /// <param name="connectionString">一个存在的数据库连接</param>
        /// <param name="cmdType">命令类型（存储过程，文本，等等）</param>
        /// <param name="cmdText">存储过程名称或者 sql 命令语句</param>
        /// <param name="commandParameters">执行命令所用参数的集合</param>
        /// <returns>
        /// 用 Convert.To{Type} 把类型转换为想要的 
        /// </returns>
        public static object ExecuteScalar(MySqlConnection connection, CommandType cmdType, string cmdText, 
            params MySqlParameter[] commandParameters)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
               
        }

        /// <summary>
        /// 将集合参数添加到缓存
        /// </summary>
        /// <param name="cacheKey">添加到缓存的变量</param>
        /// <param name="commandParameters">一个将要添加到缓存的 sql 参数集合</param>
        public static void CacheParameters(string cacheKey, params MySqlParameter[] commandParameters)
        {
            parmCache[cacheKey] = commandParameters;
        }

        /// <summary>
        /// 找回缓存参数集合
        /// </summary>
        /// <param name="cacheKey">用于找回参数的关键字</param>
        /// <returns>缓存的参数集合</returns>
        public static MySqlParameter[] GetCachedParameters(string cacheKey)
        {
            MySqlParameter[] cachedParms = (MySqlParameter[])parmCache[cacheKey];
            if(cachedParms == null)
            {
                return null;
            }
            MySqlParameter[] clonedParms = new MySqlParameter[cachedParms.Length];
            for (int i = 0, j = cachedParms.Length; i < j; i++)
            {
                clonedParms[i] = (MySqlParameter)((ICloneable)cachedParms[i]).Clone();
            }
            return clonedParms;
        }

        /// <summary>
        /// 准备执行一个命令
        /// </summary>
        /// <param name="cmd"> sql 命令</param>
        /// <param name="conn"> OleDb 连接</param>
        /// <param name="trans"> OleDb 事务</param>
        /// <param name="cmdType">命令类型，例如：存储过程或者文本</param>
        /// <param name="cmdText">命令文本，例如：Select * from Products</param>
        /// <param name="cmdParms">执行命令的参数</param>
        private static void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, 
            CommandType cmdType, string cmdText, MySqlParameter[] cmdParms)
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if(trans != null)
            {
                cmd.Transaction = trans;
            }
            cmd.CommandType = cmdType;
            if(cmdParms != null)
            {
                foreach(MySqlParameter parm in cmdParms)
                {
                    cmd.Parameters.Add(parm);
                }
            }
        }
    }
}
