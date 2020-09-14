using System;

namespace Calc_questions {

    internal class Program {

        private static void Main(string[] args) {
            Console.WriteLine("\n10的阶乘(循环)：" + Calc.FacWrite_1(10));
            Console.WriteLine("10的阶乘(递归)：" + Calc.FacWrite_2(10));
            Console.WriteLine("1到100的和(循环)：" + Calc.Sum_1(1, 100));
            Console.WriteLine("1到100的和(递归)：" + Calc.Sum_2(1, 100));
            Console.WriteLine("3个环共计需搬运(汉诺塔问题 - 递归)：" + Calc.Hanoi(3) + "次");
        }
    }

    internal class Calc {

        // 循环阶乘
        public static int FacWrite_1(int x) {
            int result = 1;
            for (int i = 1; i < x + 1; i++) {
                result *= i;
            }
            return result;
        }

        // 递归阶乘
        public static int FacWrite_2(int x) {
            if (x == 1) {
                return 1;
            }
            else {
                x *= FacWrite_2(x - 1);
                return x;
            }
        }

        // 循环求和
        public static int Sum_1(int min, int max) {
            int result = 0;
            for (int i = min; i <= max; i++) {
                result += i;
            }
            return result;
        }

        // 递归求和
        public static int Sum_2(int min, int max) {
            if (max == min) {
                return 1;
            }
            else {
                max += Sum_2(min, max - 1);
                return max;
            }
        }

        // 汉诺塔问题 from -> to
        public static int Hanoi(int num) {
            if (num == 1) {
                return 1;
            }
            else {
                int result = 0;
                result += 2 * Hanoi(num - 1) + 1;
                return result;
            }
        }
    }
}