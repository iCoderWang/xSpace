using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace EsofaDAL
{
    //封装数据库的连接，关闭，命令注入，增，删，改，查的功能
    public  static class SqliteHelper
    {
        //定义静态数据库连接字符串,从配置文件中读取数据库连接字符串
        private static string connStr = ConfigurationManager.ConnectionStrings["esofsga"].ConnectionString;

        //封装支持读取，增加，删除，查询功能的方法，及读取首列的方法，和读取集合的方法
        //执行命令的方法：insert, update, delete
        //params: 可变参数，目的是省略了手动构造数组的过程，直接指定对象，编译器会帮助构造数组，并将对象加入数组中，传递过来
        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] ps)
        {
            using(SQLiteConnection conn =new SQLiteConnection(connStr))
            {
                //创建命令对象
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                //添加参数
                cmd.Parameters.AddRange(ps);

                //打开连接
                conn.Open();

                //执行命令，并返回受影响的行数
                return cmd.ExecuteNonQuery(); 
            }    
        }
        //获取首行首列值的方法
        public static object ExecuteScalar(string sql, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddRange(ps);
                conn.Open();

                //执行命令，获取查询结果中首行首列的值，返回
                return cmd.ExecuteScalar();
            }
        }
        
        //获取结果集
        public static DataTable GetDataTable(string sql, params SQLiteParameter[] ps)
        {
            using(SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                //构造适配器对象
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);

                //构造DATa Table数据表，用来接收查询结果数据
                DataTable dt = new DataTable();

                //添加参数
                adapter.SelectCommand.Parameters.AddRange(ps);

                //执行结果
                adapter.Fill(dt);

                //返回结果集
                return dt;
            }
        }

    }
}
