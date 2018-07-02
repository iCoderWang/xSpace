using EsofaDAL;
using EsofaModel;
using System.Collections.Generic;

namespace EsofaBLL
{
    public partial class ImportingRawDataBLL
    {
        public List<RawData> ReadfromExcel(string filePath)
        {
            ImportingRawDataDAL importingRawDataDAL = new ImportingRawDataDAL();
            return importingRawDataDAL.GetList(filePath);
           //return importingRawDataDAL.ReadFromExcel(filePath);

        }

        public List<TargetEntity> ReadTgtfromExcel(string filePath)
        {
            ImportingRawDataDAL importingRawDataDAL = new ImportingRawDataDAL();
            return importingRawDataDAL.GetTargetList(filePath);
            //return importingRawDataDAL.ReadFromExcel(filePath);

        }
    }
}
