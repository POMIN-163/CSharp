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
            c.Text = "POMIN-3";// 属性覆盖！！
            b.ShowDialog();
            Console.WriteLine("OK");


            Pomin pomin = new Pomin();// 调用类的方法前最好要先 new 一个实例
            Console.Write("19 + 15 = "); 
            pomin.AddWrite(19, 15);
            Console.Write("\n19 - 15 = ");
            pomin.SubWrite(19, 15);
            Console.WriteLine("\n10的阶乘(循环)：" + pomin.FacWrite_1(10));
            Console.WriteLine("10的阶乘(递归)：" + pomin.FacWrite_2(10));
            Console.WriteLine("1到100的和(循环)：" + pomin.Sum_1(1, 100));
            Console.WriteLine("1到100的和(递归)：" + pomin.Sum_2(1, 100));
            Console.WriteLine("3个环共计需搬运(汉诺塔问题 - 递归)：" + pomin.Hanoi(3) + "次");
        }
    }
    class Pomin
    {
        public void AddWrite(int a, int b) => Console.Write(a + b);
        public void SubWrite(int a, int b) => Console.Write(a - b);
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
        public int Hanoi(int num)// 汉诺塔问题
        {// from -> to           
            if (num == 1)
            {
                return 1;
            }
            else
            {
                int result = 0;
                result += 2 * Hanoi(num - 1) + 1;
                return result;
            }      
        }
    }
}