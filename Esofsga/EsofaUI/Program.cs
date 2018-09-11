using System;
using System.IO;
using System.Windows.Forms;
//using EsofaModel;


namespace EsofaUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
             public static void EnableVisualStyles():此方法为应用程序启用可视样式。如果控件和操作系统支持视觉样式，则控件将以视觉样式进行绘制。若要使EnableVisualStyles
                生效，必须在应用程序中创建任何控件之前调用它；EnableVisualStyles 通常是 Main 函数的第一行。当调用 EnableVisualStyles时，无需单独的清单即可启用可视化样式。
                [STAThread]
                static void Main()
                {
                Application.EnableVisualStyles();
                Application.Run(new Form1());
                }
                简单的说就是让你的控件（包括窗体）显示出来。
             */
            Application.EnableVisualStyles();

            /*
              Application.SetCompatibleTextRenderingDefault(false)大意如下:
                (1).作用:在应用程序范围内设置控件显示文本的默认方式(可以设为使用新的GDI+ ,还是旧的GDI)
                true使用GDI+方式显示文本,
                false使用GDI方式显示文本.
                (2).只能在单独运行窗体的程序中调用该方法;不能在插件式的程序中调用该方法.
                (3).只能在程序创建任何窗体前调用该方法，否则会引发InvalidOperationException异常.
             */
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login_Form());
            Login_Form lf = new Login_Form();
            lf.ShowDialog();
            if (lf.DialogResult.Equals(DialogResult.OK))
            {
                Main_Form mf = new Main_Form();
                mf.lbl_UserName.Text = lf.userName;
                mf.lbl_UserRole.Text = lf.user_Role;
                if (lf.user_Role == "普通用户")
                {
                    mf.sideBar_BtnUsersList.Enabled = false;
                    mf.sideBar_BtnAccessChange.Enabled = false;
                    mf.sideBar_BtnUserDel.Enabled = false;
                    mf.sideBar_BtnUserAdd.Enabled = false;
                    mf.sideBar_BtnImport.Enabled = false;
                    mf.sideBar_BtnModify.Enabled = false;
                    mf.sideBar_BtnAddData.Enabled = false;
                    mf.menuSub_DataIm.Enabled = false;
                    mf.menuSub_DataInput.Enabled = false;
                    mf.menuSub_DataMo.Enabled = false;
                    mf.menuMain_UserMn.Enabled = false;
                    mf.menuSub_Open.Enabled = false;
                    mf.toolStrip_BtnOpen.Enabled = false;
                }
                Application.Run(mf);
            }
            else
            {
                return;
            }
        }
    }
}
