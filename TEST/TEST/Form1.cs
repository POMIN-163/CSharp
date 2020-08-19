using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DLL.SkinH_AttachEx("D:/My/热键工具/4-我的源码/she/皮肤包/皮肤_腾讯TGP.she", "");
        }
        class DLL
        {
            [System.Runtime.InteropServices.DllImport("SkinH_EL.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
            public static extern int SkinH_AttachEx(string a, string b);
        }
    }
}
