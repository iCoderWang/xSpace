using System;
using EsofaCommon;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;

namespace EsofaUI
{
    public partial class TOPSISDecisionMatrixFrm : Form
    {
        public TOPSISDecisionMatrixFrm()
        {
            InitializeComponent();
        }
        private List<double> lst_paraWgt;
        private ArrayList lst_paraTgt;
        public TOPSISDecisionMatrixFrm(List<double> lstWgt,ArrayList lstTgt)
        {
            lst_paraWgt = lstWgt;
            lst_paraTgt = lstTgt;
            InitializeComponent();
        }
        private void TOPSISDecisionMatrixFrm_Load(object sender, EventArgs e)
        {
            DataGridViewColumnEditor dgvce = new DataGridViewColumnEditor();
            dgvce.ColumHeaderEdit(this.dgv_DecisionMatrix, "dgvTgt_TDM");
        }

        private void ToolStripMenuItem_MatrixNormalize_Click(object sender, EventArgs e)
        {
            //double[,] testarr = new double [,]{ { 1, 2, 3, 4, 5, 6 }, { 2, 3, 4, 5, 6, 7 },{3,4,5,6,7,8 },{4,5,6,7,8,9 }};
            List<double> lst_MaxVal = new List<double>();
            List<double> lst_MinVal = new List<double>();
            double maxVal = 0, minVal = 0;
            TopsisDecisionMatrixOperation tdmo = new TopsisDecisionMatrixOperation();
            //double[,] arr = new double[dgv_DecisionMatrix.RowCount, dgv_DecisionMatrix.ColumnCount - 2];
            double[,]  arr_paraValNormalized = tdmo.ToNormalize( DataSourceToDataTable.GetDgvToArray(dgv_DecisionMatrix, 0, 2));
            //double[,] arr = tdmo.ToNormalize(testarr);
            double[,] arr_paraValByWgt= new double[arr_paraValNormalized.GetLength(0), arr_paraValNormalized.GetLength(1)];
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
        }
    }
}
