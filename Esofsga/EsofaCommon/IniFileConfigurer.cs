using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsofaCommon
{
    public static partial class IniFileConfigurer
    {
        //private string connStr = "server=127.0.0.1;database=esosb;port=3306;uid=root;pwd=4585;charset=utf8;pooling=true;SslMode = none";
        //private string connStr = "server=10.3.50.34;database=esosb;port=3306;uid=WangGQ;pwd=W4a5n8g5$%*%;charset=utf8;pooling=true;SslMode = none";
        /// <summary>
        /// 读取二进制文件，并返回字符串
        /// </summary>
        /// <returns></returns>
        public static string Read()
        {
            string conn="";
            string pathStr = Application.StartupPath +"\\"+ "ConnConfig.ini"; //INI文件的物理地址
            FileStream fs = null;
            BinaryReader br = null;
            //string fileName = Path.GetFileNameWithoutExtension(pathStr); //获取INI文件的文件名
            if (File.Exists(pathStr))
            {
                fs = new FileStream(pathStr, FileMode.Open,FileAccess.Read);
                br = new BinaryReader(fs,Encoding.UTF8);
                conn = br.ReadString();
            }
            else
            {
                MessageBox.Show("配置文件不存在，请配置数据库服务器连接配置文件。");
            }
            br.Close();
            fs.Close();
            return conn;
        }

        /// <summary>
        /// 将连接数据库的服务器IP，数据库名称，用户名，用户密码，写成一个二进制文件，并保存下来，以供需要时读取。
        /// </summary>
        /// <param name="serverIp"></param>
        /// <param name="dbName"></param>
        /// <param name="usrName"></param>
        /// <param name="usrPasswd"></param>
        public static void Write(string serverIp,string dbName,string usrName, string usrPasswd)
        {
            //private string connStr = "server=127.0.0.1;database=esosb;port=3306;uid=root;pwd=4585;charset=utf8;pooling=true;SslMode = none";
            try
            {
                StringBuilder conn = new StringBuilder();
                string fileName = "ConnConfig.ini";
                string pathStr = Application.StartupPath +"\\"+fileName; //INI文件的物理地址
                conn.Append("server=");
                conn.Append(serverIp + ";");
                conn.Append("database=");
                conn.Append(dbName + ";");
                conn.Append("port=3306;");
                conn.Append("uid=");
                conn.Append(usrName + ";");
                conn.Append("pwd=");
                conn.Append(usrPasswd + ";");
                conn.Append("charset=utf8;pooling=true;SslMode = none");
                FileStream fs = new FileStream(pathStr, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                bw.Write(conn.ToString());
                bw.Close();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("请检查当前文件ConnConfig.ini是否处于打开状态。", 
                    "警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }
        
        public static string [] Load()
        {
            string[] str = new string[4];
            string [] connStr = Read().Split(';');
            str[0] = connStr[0].Substring((connStr[0].IndexOf('=')+1), (connStr[0].Length- (connStr[0].IndexOf('=')+1)));
            str[1] = connStr[1].Substring((connStr[1].IndexOf('=') + 1), (connStr[1].Length - (connStr[1].IndexOf('=') + 1)));
            str[2]= connStr[3].Substring((connStr[3].IndexOf('=') + 1), (connStr[3].Length - (connStr[3].IndexOf('=') + 1)));
            str[3] = connStr[4].Substring((connStr[4].IndexOf('=') + 1), (connStr[4].Length - (connStr[4].IndexOf('=') + 1)));
            return str;
        }
    }
}
