using System;

namespace Fun_test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Class_test a = new Class_test();
            Console.WriteLine(
                a.Add(20, 30) == Class_test.Add_static(20, 30));
            // C# 中对于实例只能使用非静态方法,其余与C++类似
            Student one = new Student(19, "pomin");
            Console.WriteLine(" name:" + one.name + "\n age:" + Student.GetAge(one));

            int ref_test = 50;
            Ref_out.Ref_(ref ref_test, 10);
            Console.WriteLine(ref_test);
            Ref_out.Out_(out ref_test, 50);
            Console.WriteLine(ref_test);
        }
    }
    class Student
    {
        /***构造函数(初始化函数)***/
        public Student()// 构造函数, 相当于 init (初始化实例)
        {
            age = 0;
            name = "";
        }
        public Student(int _age)
        {
            age = _age;
            name = "";
        }
        public Student(string _name)
        {
            age = 0;
            name = _name;
        }
        public Student(int _age, string _name)// 函数重载 (用于函数形参可空)
        {
            age = _age;
            name = _name;
        }
        /***成员操作***/
        private int age;
        public string name;
        public static int GetAge(Student a)// 访问私有成员
        {
            return a.age;
        }
    }
    class Class_test
    {
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
    class Ref_out
    {
        public static void Ref_(ref int a, int b)// 有进有出
        {  
            Console.WriteLine("a:" + a);
            a = b;
        }
        public static void Out_(out int a, int b)// 有出无进
        {
            a = b;
        }
    }
}