using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Authentication; 
using System.Security.Cryptography;//MD5命名空间
namespace EsofaCommon
{
   public partial class MD5Encryption
    {
        /// <summary>
        /// 64位MD5加密
        /// </summary>
        /// <param name="strPasswd"></param>
        /// <returns></returns>
        public string  ToEncry64(string strPasswd)
        {
            //实例化一个md5对像
            MD5 md5 = MD5.Create();
            //加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择
            byte[] bStr = md5.ComputeHash(Encoding.UTF8.GetBytes(strPasswd));
            return Convert.ToBase64String(bStr);
        }
    }
}
