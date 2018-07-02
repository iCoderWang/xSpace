using EsofaModel;
using System.Collections.Generic;
using System.Data;
using EsofaCommon;

namespace EsofaDAL
{
    public partial class RawDataDAL
    {
        public List <RawData> GetList()
        {
            string sql = "select * from target";
            DataTable dt = MySqlHelper.GetDataTable(sql,CommandType.Text);
            DataAssignment dA = new DataAssignment();
            List<RawData> list = new List<RawData>();
            return dA.Assign(list,dt);
            
        }
    }
}
