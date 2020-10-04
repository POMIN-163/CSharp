using System;

namespace Fun_test {

    internal class Program {

        private static void Main(string[] args) {
            Class_Fun a = new Class_Fun();
            Console.WriteLine("Obj: " + a.Add(20, 30) + " Static: " + Class_Fun.Add_static(20, 30));
            // C# 中对于实例只能使用非静态方法,其余与C++类似
            Student one = new Student(19, "pomin");
            Console.WriteLine("name:" + one.name + " age:" + Student.GetAge(one));

            int ref_test = 50;
            Ref_out.Ref_(ref ref_test, 10); Ref_out.Out_(out int out_test, 50);
            Console.WriteLine(" Ref: " + ref_test + " Out: " + out_test);
        }
    }

    internal class Student {
        /***构造函数(初始化函数)***/

        static Student()// 创建时调用一次，且仅一次
        {
            Console.WriteLine("One student have been maked!");
        }

        public Student()// 构造函数, 相当于 init (初始化实例)
        {
            age = 0;
            name = "";
        }

        public Student(int _age, string _name)// 函数重载 (用于函数形参可空)
        {
            age = _age;
            name = _name;
        }

        /***成员操作***/
        private int age;
        public string name;
        public int Aaa { get; set; }

        public static int GetAge(Student a)// 访问私有成员
        {
            return a.age;
        }
    }

    internal class Class_Fun {
        /***静态与非静态***/

        public int Add(int a, int b)// 非静态方法, 隶属于实例(C#中)
        {
            return a + b;
        }

        public static int Add_static(int a, int b)// 静态方法, 隶属于类
        {
            return a + b;
        }
    }

    internal class Ref_out {

        public static void Ref_(ref int a, int b)// 有进有出
        {
            Console.Write("a:" + a);
            a = b;
        }

        public static void Out_(out int a, int b)// 有出无进
        {
            a = b;
        }
    }
}