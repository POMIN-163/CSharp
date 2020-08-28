using System;
using System.Collections.Generic;
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
