using System;
using System.Windows.Forms;
namespace Class_and_object
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //(new Form()).ShowDialog();// 错误操作
            Form a = new Form();
            // 创建实例 a
            a.Text = "POMIN";// 属性赋值
            a.ShowDialog();//调用方法
            // 创建实例 b
            Form b = new Form
            {
                Text = "POMIN-2",// 创建实例时多个属性赋值需要用","(类似实例的属性"数组")
                Width = 400,
                WindowState = FormWindowState.Maximized,
                Visible = false,// ShowDialog方法需要 Form 可视为false(否则报错)
            };
            b.ShowDialog();
            Form c = b;
            // 实例调用(另起名字), 并非克隆！！,b、c 指向的是一个实例操作实例的属性会导致覆盖！！
            c.Text = "POMIN-3";
            b.ShowDialog();
            Console.WriteLine("OK");


            Pomin pomin = new Pomin();// 调用类的方法前最好要先 new 一个实例
            pomin.AddWrite(19, 15);
            pomin.SubWrite(19, 15);
            Console.WriteLine(pomin.FacWrite_1(10));
            Console.WriteLine(pomin.FacWrite_2(10));
            Console.WriteLine(pomin.Sum_1(1, 100));
            Console.WriteLine(pomin.Sum_2(1, 100));
            Console.WriteLine(pomin.汉诺塔(3, "柱1", "柱2", "柱3"));
        }
    }
    class Pomin
    {
        public void AddWrite(int a, int b) => Console.WriteLine(a + b);
        public void SubWrite(int a, int b) => Console.WriteLine(a - b);
        public int FacWrite_1(int x)// 循环阶乘
        {
            int result = 1;
            for (int i = 1; i < x + 1; i++)
            {
                result *= i;
            }
            return result;
        }
        public int FacWrite_2(int x)// 递归阶乘
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                x *= FacWrite_2(x - 1);
                return x;
            }   
        }
        public int Sum_1(int min,int max)// 循环求和
        {
            int result = 0;
            for (int i = min; i <= max; i++)
            {
                result += i;
            }
            return result;
        }
        public int Sum_2(int min,int max)// 递归求和
        {
            if (max == min)
            {
                return 1;
            }
            else
            {
                max += Sum_2(min, max - 1);
                return max;
            }
        }
        public int 汉诺塔(int 数量, string 柱子1, string 柱子2, string 柱子3)
        {// 柱子1 -> 柱子3           
            if (数量 == 1)
            {
                return 1;
            }
            else
            {
                int 结果 = 0;
                结果 += 2 * 汉诺塔(数量 - 1,柱子1, 柱子2, 柱子3) + 1;
                return 结果;
            }      
        }
    }
}