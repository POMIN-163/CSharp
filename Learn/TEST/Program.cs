using System;

namespace TEST {
    internal class Program {
        private static void Main(string[] args) {
            string a = string.Empty;
            a = "Pomin";
            Console.WriteLine(string.IsNullOrEmpty(a));
            Console.WriteLine($"{a}");
        }
    }
}