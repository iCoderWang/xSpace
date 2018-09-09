using System;
using System.Text;
using System.Security.Cryptography;//MD5命名空间
using System.IO;

namespace EsofaCommon
{
   public partial class Encryption
    {
        /// <summary>
        /// 64位MD5加密
        /// </summary>
        /// <param name="strPasswd"></param>
        /// <returns></returns>
        public string  MD5Encrypt64(string strPasswd)
        {
            //实例化一个md5对像
            MD5 md5 = MD5.Create();
            //加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择
            byte[] bStr = md5.ComputeHash(Encoding.UTF8.GetBytes(strPasswd));
            return Convert.ToBase64String(bStr);
        }

        private byte[] keyvi = new byte[] { 0x12, 0x34, 0x56, 120, 0x90, 0xab, 0xcd, 0xef };
        /// <summary>
        /// Des加密
        /// </summary>
        /// <param name="normalTxt"></param>
        /// <param name="EncryptKey"></param>
        /// <returns></returns>
        public string DesEncrypt(string normalTxt, string EncryptKey)
        {
            var bytes = Encoding.Default.GetBytes(normalTxt);
            var key = Encoding.UTF8.GetBytes(EncryptKey.PadLeft(8, '0').Substring(0, 8));
            using (MemoryStream ms = new MemoryStream())
            {
                var encry = new DESCryptoServiceProvider();
                CryptoStream cs = new CryptoStream(ms, encry.CreateEncryptor(key, keyvi), CryptoStreamMode.Write);
                cs.Write(bytes, 0, bytes.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        /// <summary>
        /// Des解密
        /// </summary>
        /// <param name="securityTxt"></param>
        /// <param name="EncryptKey"></param>
        /// <returns></returns>
        public string DesDecrypt(string securityTxt, string EncryptKey)//解密
        {
            try
            {
                var bytes = Convert.FromBase64String(securityTxt);
                var key = Encoding.UTF8.GetBytes(EncryptKey.PadLeft(8, '0').Substring(0, 8));
                using (MemoryStream ms = new MemoryStream())
                {
                    var descrypt = new DESCryptoServiceProvider();
                    CryptoStream cs = new CryptoStream(ms, descrypt.CreateDecryptor(key, keyvi), CryptoStreamMode.Write);
                    cs.Write(bytes, 0, bytes.Length);
                    cs.FlushFinalBlock();
                    return Encoding.UTF8.GetString(ms.ToArray());
                }

            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


    }
}
