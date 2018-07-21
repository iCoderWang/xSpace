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
    //public delegate void DelCloseTabPage();
    public partial class RawDataEditorFrm: Form
    {
        private DelCloseTabPage _delCloseTabPage;
        public RawDataEditorFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 用委托作参数构建构造函数
        /// </summary>
        /// <param name="delCloseTabPage"></param>
        public RawDataEditorFrm(DelCloseTabPage delCloseTabPage)
        {
            this._delCloseTabPage = delCloseTabPage;
            InitializeComponent();
        }
    }
}
