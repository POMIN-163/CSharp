using System;
using System.Windows.Forms;

namespace type_test {

    internal class Program {

        private static void Main(string[] args) {
            Console.WriteLine("Size:::" +
                              "\n byte:" + sizeof(byte) +
                              "\n char:" + sizeof(char) +
                              "\n int: " + sizeof(int) +
                              "\n long: " + sizeof(long) +
                              "\n float: " + sizeof(float) +
                              "\n double: " + sizeof(double)
                              );
            Console.WriteLine("Type:::" +
                              "\n Class::" +
                              "\n Form: " + typeof(Form).FullName +
                              "\n Form: " + typeof(Form).BaseType.FullName +
                              "\n Form: " + typeof(Form).BaseType.BaseType.FullName
                              );
            Console.WriteLine("Type:::" +
                              "\n Struct::" +
                              "\n byte: " + typeof(byte) +
                              "\n Byte: " + typeof(Byte) +
                              "\n char: " + typeof(char) +
                              "\n Int16: " + typeof(Int16) +// char == Int16 以此类推
                              "\n int: " + typeof(int) +
                              "\n Int32: " + typeof(Int32) +
                              "\n long: " + typeof(long) +
                              "\n Int64: " + typeof(Int64)
                              );
            Console.WriteLine("Type:::" +
                              "\n Enum::" +
                              "\n FormWindowState: " + typeof(FormWindowState) +
                              "\n FWS-Max: " + FormWindowState.Maximized.GetTypeCode()
                              );
            Student Stu1 = new Student {
                Age = 19,
                Name = "someone",
            };
            Stu1.parents[0] = "none";

            while (true) {
            }
        }

        private class Student {
            public static int Amount;// 静态成员, 隶属于类, 不隶属于类的实例
            public int Age;
            public string Name;
            public string[] parents = new string[100];
        }
    }
}