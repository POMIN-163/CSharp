using System;
using DLL;

namespace Class // class'name (default is same with file)
{
    class Program
    {
        static void Main(string[] args)
        {
            bool system_include = true;
            if (system_include)
            {
                Console.WriteLine("Hello world(include)");
            }
            else
            {
                System.Console.WriteLine("Hello world(No include)");
            }
        /** use a DLL which can look its class and function **/
            DLL.Class1 a = new DLL.Class1();
            // create a object in DLL's types to use its method
            Console.WriteLine(a.ADD(11, 11).ToString());
        }
        /** use a DLL which can't look its class and function **/
        [System.Runtime.InteropServices.DllImport("DLL_extern.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string DLL_internal_fun();
        private void DLL_extern()
        {
            DLL_internal_fun();
        }
    }
}
