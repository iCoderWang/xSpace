using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsofaUI
{
    public partial class ConditionalQueryFrm : Form
    {
        public ConditionalQueryFrm()
        {
            InitializeComponent();
        }

        private void btn_ExitCmd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
