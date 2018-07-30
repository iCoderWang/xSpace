using EsofaUI;
using System.Data;
using System.Windows.Forms;
using EsofaCommon;
using System.Collections.Generic;

namespace EsofaModel
{
    public partial class SortedTargetsFrm : Form
    {
        public SortedTargetsFrm()
        {
            InitializeComponent();
        }

        private List<SortedTargetsParas> lst_SBP;
        public SortedTargetsFrm(List<SortedTargetsParas> list)
        {
            InitializeComponent();
            lst_SBP = list;
        }
        //private Form1 m_parent;

        //public Form2(Form1 frm1)
        //{
        //    InitializeComponent();
        //    m_parent = frm1;
        //}
        //private GradingFrm gf= new GradingFrm();
        //public SortedBlocksFrm(GradingFrm gFrm)
        //{
        //    InitializeComponent();
        //    gf = gFrm;
        //}

        private void SortedBlocksFrm_Load(object sender, System.EventArgs e)
        {
            dgv_Tgt_Sorted.DataSource = DataSourceToDataTable.GetListToDataTable(lst_SBP);
        }

    }
}
