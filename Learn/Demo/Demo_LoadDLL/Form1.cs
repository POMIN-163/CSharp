using System;
using System.Windows.Forms;

namespace Demo_LoadDLL {

    public partial class testForm : Form {

        public testForm() {
            InitializeComponent();
        }

        // Skin皮肤的DLL
        private void Load_Click(object sender, EventArgs e) {
            DLL_extern.SkinH_AttachEx(
            System.IO.Directory.GetCurrentDirectory() + "/皮肤_腾讯TGP.she");
        }

        // C++的DLL
        private void Load_Cpp_Click(object sender, EventArgs e) {
            MessageBox.Show(
                "DLL_Cpp's result : " +
                DLL_extern.DLL_internal_fun_Cpp(10, 30).ToString());
        }

        // E的DLL
        private void Load_E_Click(object sender, EventArgs e) {
            MessageBox.Show(
                "DLL_E's result : " +
                DLL_extern.DLL_internal_fun_e(10, 30).ToString());
        }

        // C#的DLL（黑盒）
        private void Load_Cs_Click(object sender, EventArgs e) {
            MessageBox.Show(
                "DLL_Cs's result : " +
                DLL_extern.DLL_internal_fun_Cs(10, 30).ToString());
        }
    }

    #region 外部DLL

    internal class DLL_extern {
        /*
        * 类名：DLL_extern
        * 主方法：各个语言的DLL函数
        * 功能：测试调用外部DLL的demo
        * 日期：2020-8-29
        */

        [System.Runtime.InteropServices.DllImport("DLL_extern_e.dll"/*, CharSet = System.Runtime.InteropServices.CharSet.Ansi*/)]
        public static extern int DLL_internal_fun_e(int a, int b);

        [System.Runtime.InteropServices.DllImport("DLL_extern_Cpp.dll")]
        public static extern int DLL_internal_fun_Cpp(int a, int b);

        [System.Runtime.InteropServices.DllImport("SkinH_EL.dll")]
        public static extern int SkinH_AttachEx(string a);

        public static int DLL_internal_fun_Cs(int a, int b) {
            DLL.Class1 aa = new DLL.Class1();
            return aa.ADD(a, b);
        }
    }

    #endregion 外部DLL
}