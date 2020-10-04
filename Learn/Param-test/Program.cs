using System;

namespace Param_test {
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine(Test(1, 3, 5));
        }
        private static string Test(params int[] arr) {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            return sum.ToString();
        }
    }
}