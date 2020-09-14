using System;
using System.Collections;
using System.Collections.Generic;

namespace Important {
    internal class Program {
        private static void Main(string[] args) {
            int x = 103;
            {// 内部的 { } 不能在类、接口、结构中使用
                int y = 1001; // y 的作用域只在 { } 里面
                Console.WriteLine(y);
            }
            Console.WriteLine(x);
            // Console.WriteLine(y); 错误写法

            TestClass.AAA();
            Test.Test_IEnumerator();
            Test.Test_Foreach();
        }
    }
    internal class Test {
        public static void Test_IEnumerator()// 迭代器
        {
            List<int> list = new List<int>() { 1, 2, 5, 8, 44 };
            IEnumerator enum1 = list.GetEnumerator();
            while (enum1.MoveNext()) {
                Console.WriteLine(enum1.Current);
            }
            enum1.Reset();
            while (enum1.MoveNext()) {
                Console.WriteLine(enum1.Current);
            }
        }
        public static void Test_Foreach() {
            List<int> list = new List<int>() { 1, 2, 5, 8, 44 };
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }
    }
    internal class TestClass {
        public int a = 0, b = 0;

        public static void AAA() {
            try {
                int aa = int.Parse("99999999999999999");
                Console.WriteLine("OK");
            }
            catch (OverflowException)// 捕捉指定错误
            {
                Console.WriteLine("Overflow");
            }
            catch (System.Exception ex)// 捕捉全部错误，要放在最后
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine("ERROR");
            }
            finally {
                Console.WriteLine("END");// 必定执行语句
            }
        }
    }
}