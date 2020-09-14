using System;
using System.Windows.Forms;

namespace Object_test {
    internal class Program {
        private static void Main(string[] args) {
            //(new Form()).ShowDialog();// 一次性操作
            Form a = new Form();// 创建实例 a
            a.Text = "POMIN";// 属性赋值
            a.ShowDialog();//调用方法

            Form b = new Form {// 创建实例 b
                Text = "POMIN-2",// 创建实例时多个属性赋值需要用","(类似实例的属性"数组")
                Width = 400,
                WindowState = FormWindowState.Maximized,
                Visible = false,// ShowDialog方法需要 Form 可视为false(否则报错)
            };
            b.ShowDialog();
            Form c = b;// 实例调用(另起名字), 并非克隆！！,b、c 指向的是一个实例操作实例的属性会导致覆盖！！
            c.Text = "POMIN-3";// 属性覆盖！！
            b.ShowDialog();
            Console.WriteLine("OK");

            Pomin pomin = new Pomin();// 调用类的非静态方法要先 new 一个实例
            Console.Write("19 + 15 = ");
            pomin.AddWrite(19, 15);
            Console.Write("\n19 - 15 = ");
            pomin.SubWrite(19, 15);
        }
    }
    internal class Pomin {
        public void AddWrite(int a, int b) => Console.Write(a + b);
        public void SubWrite(int a, int b) => Console.Write(a - b);
    }
}