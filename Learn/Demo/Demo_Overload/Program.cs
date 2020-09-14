using System;

namespace Demo_Overload {
    internal class Program {
        private static void Main(string[] args) {
            Overload_Fun Test1 = new Overload_Fun(19, "POMIN");
            Overload_Fun Test2 = new Overload_Fun("POMIN");
            Overload_Fun Test3 = new Overload_Fun(19);

            Overload_Operator Test4 = new Overload_Operator();
            Overload_Operator Test5 = new Overload_Operator();

            Test4.var1 = Test5.var2 = 20;
            Console.WriteLine(Test4 ^ Test5);
        }
    }

    #region 方法重载

    internal class Overload_Fun {
        /*
        * 类名：Overload_Fun
        * 主方法：Overload_Fun()
        * 功能：测试方法重载的demo
        * 日期：2020-8-30
        */
        public int var1;
        public string var2;

        public Overload_Fun(int var1_, string var2_) {
            var1 = var1_;
            var2 = var2_;
        }

        public Overload_Fun(string var2_) {
            var2 = var2_;
        }

        public Overload_Fun(int var1_) {
            var1 = var1_;
        }
    }

    #endregion 方法重载

    #region 操作符重载

    internal class Overload_Operator {
        /*
        * 类名：Overload_Operator
        * 主方法： ^
        * 功能：测试操作符重载的demo
        * 日期：2020-8-30
        */
        public int var1 = 0;
        public int var2 = 0;

        public static int operator ^(Overload_Operator a, Overload_Operator b)
        // 参数中至少有一个是本类的对象
        {
            return a.var1 + b.var2;
        }
    }

    #endregion 操作符重载
}