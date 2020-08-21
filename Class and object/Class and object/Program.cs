using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_and_object
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
