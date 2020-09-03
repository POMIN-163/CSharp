using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<对象> 我的对象 = new List<对象>();
            for (int a = 0; a < 100; a++)
            {
                对象 一个对象 = new 对象("我的第" + a.ToString() + "个对象", 19);
                我的对象.Add(一个对象);
            }
            foreach (var aa in 我的对象)
            {
                Console.WriteLine(aa.名字 + "\t" + aa.年龄.ToString() + "岁\n");
            }

            Console.WriteLine("Alt + a : [D://]".ToUpper());
            Console.WriteLine("Alt + a : [D://]".ToUpper().IndexOf("1ALT"));
            string[] tmp = { "-1", "-1", "-1", "-1", };
            tmp = "Ctrl+Alt+64".ToUpper().Split('+');
            //创建一个进程
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;//是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序

            string strCMD = "explorer";            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(strCMD + "&exit");

            p.StandardInput.AutoFlush = true;

            //获取cmd窗口的输出信息
            string output = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();
      
            System.Windows.Forms.MessageBox.Show(output);
            Console.WriteLine(output);
        }
    }
    class 对象
    {
        public string 名字;
        public int 年龄;
        public 对象(string name, int age)
        {
            名字 = name;
            年龄 = age;
        }
    }
}
