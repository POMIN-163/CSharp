using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;

namespace ListAPP
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();    
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!Extern.initHotkey()){
                Process.GetCurrentProcess().Kill();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hotkey tmp = new Hotkey(Mytext.Text);
            MyList.ItemsSource = null;
            //MyList.ItemsSource = ALL_CMD.all_name;

           // MyList.Items.CurrentItem;
           
            MyList.Items.Add(ALL_CMD.all_name[ALL_CMD.all_name.Count - 1]);
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Extern.endHotkey();
        }

        private void MyList_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (ALL_CMD.ALL.Count == 0 || MyList.SelectedIndex == -1)
            {
                return;
            }
            Process.Start("cmd.exe", "/c " + ALL_CMD.ALL[MyList.SelectedIndex].H_cmd);
        }
    }
    class ALL_CMD
    {
        public static List<Hotkey> ALL = new List<Hotkey>();
        public static List<string> all_name = new List<string>{};
    }
    class Extern
    {
        [System.Runtime.InteropServices.DllImport("_api_hotkey_.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int regAnHotkey(int con, int key, string cmd);
        [System.Runtime.InteropServices.DllImport("_api_hotkey_.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern bool initHotkey();
        [System.Runtime.InteropServices.DllImport("_api_hotkey_.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern bool unregAnHotkey(int tab);
        [System.Runtime.InteropServices.DllImport("_api_hotkey_.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern bool unregAllHotkey();
        [System.Runtime.InteropServices.DllImport("_api_hotkey_.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern void endHotkey();
    }
    class Hotkey : Extern
    {
        public int H_tab;
        public string H_cmd;
        public string H_ini;

        public Hotkey(string ini)
        {
            int Key = 0, control = 0;
            string cmd = "";
            Explain.Ex(ini, ref Key, ref control, ref cmd);

            H_cmd = cmd;
            H_ini = ini;

            H_tab = regAnHotkey(control, Key, H_cmd);

            ALL_CMD.ALL.Add(this);
            ALL_CMD.all_name.Add(this.H_ini);
        }
    }

    public static class Explain
    {
        // 将文本转为要注册的键值
        public static void Ex(string a, ref int key, ref int control, ref string out_)
        {
            int con = 0;
            string[] tmp = { };
            if (a != null)
            {
                if (a.ToUpper().IndexOf("ALT") != -1) con += 4;
                if (a.ToUpper().IndexOf("CTRL") != -1) con += 1;
                if (a.ToUpper().IndexOf("SHIFT") != -1) con += 2;
                control = con;
            }
            out_ = GetRight(a ,"————");
            a = GetLeft(a ,"————");
           
            tmp = a.Split('+');
            try
            {
                key = int.Parse(tmp[tmp.Length - 1]);         
            }
            catch (System.Exception ex)
            {
                
            }
        }
        /// 取左边文本
        public static string GetLeft(this string str, string left, bool ignoreCase = true)
        {
            StringComparison comparison = StringComparison.CurrentCulture;

            if (ignoreCase)
            {
                comparison = StringComparison.OrdinalIgnoreCase;
            }

            int index = str.IndexOf(left, comparison);
            if (index == -1) return "";

            return str.Substring(0, index);
        }

        /// 取文本右边
        public static string GetRight(this string str, string right, bool ignoreCase = true)
        {
            StringComparison comparison = StringComparison.CurrentCulture;

            if (ignoreCase)
            {
                comparison = StringComparison.OrdinalIgnoreCase;
            }

            int index = str.LastIndexOf(right, comparison);
            if (index == -1) return "";

            int index_start = index + right.Length;

            int end_len = str.Length - index_start;
            string temp = str.Substring(index_start, end_len);
            return temp;


        }
    }
}
