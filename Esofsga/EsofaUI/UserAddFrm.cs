using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsofaBLL;

namespace EsofaUI
{
    public partial class UserAddFrm : Form
    {
        public UserAddFrm()
        {
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            UserAddBLL uab = new UserAddBLL();

        }
    }
}
