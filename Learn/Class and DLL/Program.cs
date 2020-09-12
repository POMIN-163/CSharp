using System;
using System.Windows.Forms;

// use a DLL which can look its class and function need "using"

namespace Class // class'name (default is same with file)
{
    internal class Program {

        private static void Main(string[] args) {
            bool system_include = true;
            if (system_include) {
                Console.WriteLine("Hello world(include)");
            }
            else {
                System.Console.WriteLine("Hello world(No include)");
            }
            /** use a DLL which can look its class and function **/
            DLL.Class1 DLL_extern_object = new DLL.Class1();
            // create a object in DLL's types to use its method
            Console.WriteLine("E's result：1 + 3 = " + DLL_extern.DLL_internal_fun_e(1, 3).ToString());
            Console.WriteLine("C#'s result：1 + 3 = " + DLL_extern_object.ADD(1, 3).ToString());
            Console.WriteLine("C++'s result：1 + 3 = " + DLL_extern.DLL_internal_fun_Cpp(1, 3).ToString());
            Form form = new Form();
            form.ShowDialog();
            DLL_extern a = new DLL_extern();
        }
    }

    internal class DLL_extern {
        /** use a DLL which can't look its class and function **/

        [System.Runtime.InteropServices.DllImport("DLL_extern_e.dll"/*, CharSet = System.Runtime.InteropServices.CharSet.Ansi*/)]
        public static extern int DLL_internal_fun_e(int a, int b);

        [System.Runtime.InteropServices.DllImport("DLL_extern_Cpp.dll")]
        public static extern int DLL_internal_fun_Cpp(int a, int b);

        ~DLL_extern() {
            Console.WriteLine("DONE");
        }
    }
}