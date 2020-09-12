using System;

namespace ConsoleApp2 {

    internal class Program {

        private static void Main(string[] args) {
            Func<int, int, int> Calc_ADD = new Func<int, int, int>(Func_Fun.ADD);
            Func<int, int, int> Calc_SUB = new Func<int, int, int>(Func_Fun.SUB);
            Func<int, int, int> Calc_MUL = new Func<int, int, int>(Func_Fun.MUL);
            Func<int, int, int> Calc_DIV = new Func<int, int, int>(Func_Fun.DIV);

            Console.WriteLine("ADD:" + Calc_ADD(1, 5));

            Action action = new Action(Action_Fun.Action_1);
            action += Action_Fun.Action_2;
            action += Action_Fun.Action_3; // 事件叠加
            action += Action_Fun.Action_4;
            action.Invoke();
        }
    }

    internal class Func_Fun {
        /*
                public static void CW()
                {
                    Console.WriteLine("CW");
                }*/

        public static int ADD(int a, int b) => a + b;

        public static int SUB(int a, int b) => a - b;

        public static int MUL(int a, int b) => a * b;

        public static int DIV(int a, int b) => a / b;
    }

    internal class Action_Fun {

        public static void Action_1() => Console.WriteLine("事件1");

        public static void Action_2() => Console.WriteLine("事件2");

        public static void Action_3() => Console.WriteLine("事件3");

        public static void Action_4() => Console.WriteLine("事件4");
    }
}