using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaModel
{
    public partial class UserInfo
    {
        //定义字段 用户ID
        public int UserId { get; set; }

        //定义字段 用户名
        public string UserName { get; set; }

        //定义字段 用户密码
        public string UserPwd { get; set; }

        //定义字段 用户类型
        public string UserType { get; set; }
    }
}
