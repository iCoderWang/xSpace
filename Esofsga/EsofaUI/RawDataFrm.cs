using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsofaModel;

namespace EsofaUI
{
    public delegate void DelCloseTabPage();
    public partial class RawDataFrm : Form
    {
        private DelCloseTabPage _delCloseTabPage;
        public RawDataFrm()
        {
            InitializeComponent();
        }

        public RawDataFrm(DelCloseTabPage delCloseTabPage)
        {
            this._delCloseTabPage = delCloseTabPage;
            InitializeComponent();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            //DataTable dt = (DataTable) this.rawDataGridView.DataSource;
            //DataTable dt = ((DataView)this.rawDataGridView.DataSource).ToTable();
            //Type type = this.rawDataGridView.DataSource.GetType();
            List<RawData> list = (List<RawData>)this.rawDataGridView.DataSource;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            _delCloseTabPage();
        }
    }
}
