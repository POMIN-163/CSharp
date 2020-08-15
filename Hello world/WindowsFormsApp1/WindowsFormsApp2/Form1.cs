using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using mshtml;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }
        class Win32API
        {
            [DllImport("user32", EntryPoint = "SendMessage")]
            public static extern int SendMessage(int hwnd, int wMsg, int wParam, ref int lParam);

            [DllImport("user32", EntryPoint = "RegisterWindowMessage")]
            public static extern int RegisterWindowMessage(string lpString);

            [DllImport("OLEACC.DLL", EntryPoint = "ObjectFromLresult")]
            public static extern int ObjectFromLresult(
                int lResult,
                ref System.Guid riid,
                int wParam,
                [MarshalAs(UnmanagedType.Interface), System.Runtime.InteropServices.In, System.Runtime.InteropServices.Out]ref System.Object ppvObject
            //注意这个函数ObjectFromLresult的声明
            );
        }
        string compare = "";
        string full_path = "";
        string name = "";
        string tar = "";

        IHTMLDocument2 doc;
        public static string Between(string str, string strLeft, string strRight) //取文本中间
        {
            if (str == null || str.Length == 0) return "";
            if (strLeft != "")
            {
                int indexLeft = str.IndexOf(strLeft);//左边字符串位置
                if (indexLeft < 0) return "";
                indexLeft = indexLeft + strLeft.Length;//左边字符串长度
                if (strRight != "")
                {
                    int indexRight = str.IndexOf(strRight, indexLeft);//右边字符串位置
                    if (indexRight < 0) return "";
                    return str.Substring(indexLeft, indexRight - indexLeft);//indexRight - indexLeft是取中间字符串长度
                }
                else return str.Substring(indexLeft, str.Length - indexLeft);//取字符串右边
            }
            else//取字符串左边
            {
                int indexRight = str.IndexOf(strRight);
                if (indexRight <= 0) return "";
                else return str.Substring(0, indexRight);
            }
        }
        public void init()
        {
            
            full_path = GetType().Assembly.Location;
            name = Path.GetFileNameWithoutExtension(@full_path);
         //name = "PO2426996MIN";
            tar = Between(name, "PO", "MIN");
            object domObject = new object();
            int tempInt = 0;
            Guid guidIEDocument2 = new Guid();
            int WM_Html_GETOBJECT = Win32API.RegisterWindowMessage("WM_Html_GETOBJECT");//定义一个新的窗口消息
            int W = Win32API.SendMessage(int.Parse(tar), WM_Html_GETOBJECT, 0, ref tempInt);//注:第二个参数是RegisterWindowMessage函数的返回值
            int lreturn = Win32API.ObjectFromLresult(W, ref guidIEDocument2, 0, ref domObject);
            doc = (IHTMLDocument2)domObject;
        }
        public void GetHtmlDocument()
        {       
            //name = "PO2426996MIN";
            
            // MessageBox.Show(ss);

            IHTMLSelectionObject currentSelection = doc.selection;
            if (currentSelection != null)
            {
                if (currentSelection.createRange() is IHTMLTxtRange range)
                {
                    //MessageBox.Show(range.text);
                    if (compare != range.text)
                    {
                        compare = range.text;
                        File.WriteAllText(Path.GetDirectoryName(full_path) + "\\" + name + ".txt",range.text);
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetHtmlDocument();
        }
    }
}
