using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsofaModel
{
    public static class PublicValues
    {
        public static string GeoParas= null;
        public static string[] ArrGeoParas = null;
        public static string EngParas = null;
        public static string[] ArrEngParas = null;
        public static string EcoParas = null;
        public static string [] ArrEcoParas = null;
        public static string GeoWgt = null;
        public static double[] ArrGeoWgt = null;
        public static string EngWgt = null;
        public static double [] ArrEngWgt = null;
        public static string EcoWgt = null;
        public static double [] ArrEcoWgt = null;
        public static string GEE_Wgt = null;
        public static DataGridView dgv_GEE = null;
        public static DataGridView dgv_Geo = null;
        public static DataGridView dgv_Eng = null;
        public static DataGridView dgv_Eco = null;
        public static Dictionary<string, double> DicGeoP_W = null;
        public static Dictionary<string, double> DicEngP_W = null;
        public static Dictionary<string, double> DicEcoP_W = null;
    }
}
