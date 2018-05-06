using System;
using System.Windows.Forms;

namespace EsofaUI
{
    public partial class Login_Form : Form
    {
        
        Main_Form frmMain = new Main_Form();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
            //mainForm.Show();
            frmMain.Show();
        }
    }
}
