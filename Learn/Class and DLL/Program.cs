using DLL;// 引入外部的C#
using System;

namespace DLL_Test // 类名
{
    internal class Program {

        [System.Runtime.InteropServices.DllImport("DLL_extern_e.dll"/*, CharSet = System.Runtime.InteropServices.CharSet.Ansi*/)]
        public static extern int DLL_internal_fun_e(int a, int b);

        [System.Runtime.InteropServices.DllImport("DLL_extern_Cpp.dll")]// 引入非托管代码程序集
        public static extern int DLL_internal_fun_Cpp(int a, int b);

        private static void Main(string[] args) {
            Console.WriteLine("E's result：1 + 3 = " + DLL_internal_fun_e(1, 3).ToString());
            // E 的DLL调用
            Console.WriteLine("C#'s result：1 + 3 = " + Class1.ADD(1, 3).ToString());
            // C# 的DLL白盒调用
            Console.WriteLine("C++'s result：1 + 3 = " + DLL_internal_fun_Cpp(1, 3).ToString());
            // C++ 的DLL调用
        }
    }
}