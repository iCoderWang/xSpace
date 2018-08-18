using System;
using EsofaCommon;
using System.Windows.Forms;

namespace EsofaUI
{
    public partial class TOPSISDecisionMatrixFrm : Form
    {
        public TOPSISDecisionMatrixFrm()
        {
            InitializeComponent();
        }

        private void TOPSISDecisionMatrixFrm_Load(object sender, EventArgs e)
        {
            DataGridViewColumnEditor dgvce = new DataGridViewColumnEditor();
            dgvce.ColumHeaderEdit(this.dgv_DecisionMatrix, "dgvTgt_TDM");
        }
    }
}
