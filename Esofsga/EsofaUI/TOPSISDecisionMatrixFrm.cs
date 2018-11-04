using System;
using EsofaCommon;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using EsofaModel;
using System.Linq;

namespace EsofaUI
{
    public partial class TOPSISDecisionMatrixFrm : Form
    {
        private static TOPSISDecisionMatrixFrm frm;
        private List<double> lst_paraWgt;
        private List<string> lst_paraTgt;
        private string strDgvName;
        private TOPSISDecisionMatrixFrm()
        {
            InitializeComponent();
        }
        private TOPSISDecisionMatrixFrm(List<double> lstWgt,List<string> lstTgt,string dgvName)
        {
            lst_paraWgt = lstWgt;
            lst_paraTgt = lstTgt;
            strDgvName = dgvName;
            InitializeComponent();
        }

        public static TOPSISDecisionMatrixFrm CreateInstance()
        {
            if(frm == null || frm.IsDisposed)
            {
                frm = new TOPSISDecisionMatrixFrm();
            }
            return frm;
        }
        public static TOPSISDecisionMatrixFrm CreateInstance(List<double> lstWgt, List<string> lstTgt, string dgvName)
        {
            if(frm == null || frm.IsDisposed)
            {
                frm = new TOPSISDecisionMatrixFrm(lstWgt, lstTgt, dgvName);
            }
            return frm;
        }

        private void TOPSISDecisionMatrixFrm_Load(object sender, EventArgs e)
        {
            DataGridViewColumnEditor dgvce = new DataGridViewColumnEditor();

            dgvce.ColumHeaderEdit(this.dgv_DecisionMatrix, strDgvName);
            if (strDgvName.Contains("dgvBlk_TDM"))
            {
                this.Text += "_ _有利区";
            }
            if (strDgvName.Contains("dgvBsn_TDM"))
            {
                this.Text += "_ _远景区";
            }
            if (strDgvName.Contains("dgvTgt_TDM"))
            {
                this.Text += "_ _核心区";
            }
        }

        private void ToolStripMenuItem_Sort_Click(object sender, EventArgs e)
        {
            //double[,] testarr = new double [,]{ { 1, 2, 3, 4, 5, 6 }, { 2, 3, 4, 5, 6, 7 },{3,4,5,6,7,8 },{4,5,6,7,8,9 }};
            List<double> lst_MaxVal = new List<double>();
            List<double> lst_MinVal = new List<double>();
            //定义正理想解的距离值列表
            List<double> lst_DistPIS = new List<double>();
            //定义负理想解的距离值列表
            List<double> lst_DistNIS = new List<double>();
            //定义用于排序的最终值的列表
            List<double> lst_Ci = new List<double>();
            //定义理想值列表，用于排序
            List<IdealSolutionByTopsisEntity> lst_ISBTE = new List<IdealSolutionByTopsisEntity>(); 
            double maxVal = 0, minVal = 0;
            TopsisDecisionMatrixOperation tdmo = new TopsisDecisionMatrixOperation();
            //double[,] arr = new double[dgv_DecisionMatrix.RowCount, dgv_DecisionMatrix.ColumnCount - 2];
            double[,]  arr_paraValNormalized = tdmo.ToNormalize( DataSourceToDataTable.GetDgvToArray(dgv_DecisionMatrix, 0, 2));
            //double[,] arr = tdmo.ToNormalize(testarr);
            double[,] arr_paraValByWgt= new double[arr_paraValNormalized.GetLength(0), arr_paraValNormalized.GetLength(1)];
            int counter=0;
            for(int j = 0; j< arr_paraValNormalized.GetLength(1); j++)
            {
                //arrColumnMaxVal[j] = arr[]
                //minVal[j, 0] = arr_paraValByWgt[i, j];
                for (int i = 0; i < arr_paraValNormalized.GetLength(0); i++)
                {
                    //minVal = 
                    arr_paraValByWgt[i,j]= arr_paraValNormalized[i, j]*lst_paraWgt[j];
                    if(i == 0)
                    {
                        minVal = arr_paraValByWgt[i, j];
                    }
                    if(minVal> arr_paraValByWgt[i, j])
                    {
                        minVal = arr_paraValByWgt[i,j];
                    }
                    if(arr_paraValByWgt[i,j] > maxVal)
                    {
                        maxVal = arr_paraValByWgt[i,j];
                    }
                }
                lst_MaxVal.Add(maxVal);
                maxVal = 0;
                lst_MinVal.Add(minVal);
                minVal = 0;
            }
            lst_DistPIS = tdmo.ToGetDistToPIS(arr_paraValByWgt, lst_MaxVal);
            lst_DistNIS = tdmo.ToGetDistToNIS(arr_paraValByWgt, lst_MinVal);
            string[] arr_TgtName = new string[lst_paraTgt.Count];
            lst_paraTgt.CopyTo(arr_TgtName,0);
            for (int i = 0; i < lst_DistNIS.Count; i++)
            {
                lst_ISBTE.Add(new IdealSolutionByTopsisEntity
                {
                    para_Tgt = arr_TgtName[i],
                    para_PostiveDist = lst_DistPIS[i],
                    para_NegativeDist = lst_DistNIS[i],
                    para_Ci = lst_DistNIS[i]/(lst_DistNIS[i]+ lst_DistPIS[i])
                });
            }
            lst_ISBTE.Sort((x, y) => x.para_Ci.CompareTo(y.para_Ci));
            counter = lst_ISBTE.Count;
            foreach(IdealSolutionByTopsisEntity var in lst_ISBTE)
            {
                var.para_Rank = counter;
                counter--;
            }
            lst_ISBTE.Sort((x, y) => x.para_Rank.CompareTo(y.para_Rank));
            double [] arr_Ci = lst_ISBTE.Select(x => x.para_Ci).ToArray();
            string [] arr_Tgt = lst_ISBTE.Select(x => x.para_Tgt).ToArray();
            ResultSortedByTopsisFrm rsbtf = ResultSortedByTopsisFrm.CreateInstance(lst_ISBTE,arr_Ci,arr_Tgt,strDgvName);
            rsbtf.dgv_SortedByTopsis.DataSource = lst_ISBTE;
            rsbtf.Show();
        }

        private void ToolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
