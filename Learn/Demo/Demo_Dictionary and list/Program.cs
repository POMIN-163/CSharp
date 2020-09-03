using System;
using System.Collections.Generic;

namespace Demo_Dictionary_and_list
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\n字典测试开始：：：：");
            Dir_test.DirTest();
            Console.WriteLine("\n列表测试开始：：：：");
            List_test.ListTest();
        }
    }

    #region  示例对象
    internal class Obj
    {
        public string name;
        public int age;

        public Obj(string name_, int age_)
        {
            name = name_;
            age = age_;
        }
    }
    #endregion

    #region  字典demo
    internal class Dir_test
    {
        /*
         * 类名：Dir_test
         * 主方法：DirTest()
         * 功能：测试字典(键值对)的demo
         * 日期：2020-8-28
         */
        public static void DirTest()
        {
            // 配置 “键值对成员”
            Dictionary<string, Obj> Dir_obj = new Dictionary<string, Obj>();
            // 批量加入成员
            for (int i = 0; i < 10; i++)
            {
                Obj temp = new Obj("Dir_POMIN - ", i);
                Dir_obj.Add("第" + i.ToString() + "位成员：", temp);
            }
            // 类似数组方式的成员访问（可以索引，如果没有指定成员会报错）
            Console.WriteLine("[]方式访问：：");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(
                    "第" + i + "位成员：" +
                    Dir_obj["第" + i + "位成员："].name +
                    Dir_obj["第" + i + "位成员："].age);
            }
            // "."操作符方式的成员访问
            Console.WriteLine(" . 方式访问：：");
            foreach (var a in Dir_obj)
            {
                Console.WriteLine(
                    a.Key +
                    a.Value.name +
                    a.Value.age);
            }
        }
    }
    #endregion

    #region  列表demo
    internal class List_test
    {
        /*
        * 类名：List_test
        * 主方法：ListTest()
        * 功能：测试列表的demo
        * 日期：2020-8-28
        */
        public static void ListTest()
        {
            List<Obj> List_obj = new List<Obj>();
            for (int i = 0; i < 10; i++)
            {
                Obj temp = new Obj("List_POMIN - ", i);
                List_obj.Add(temp);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("第" + i + "个成员：" + List_obj[i].name + List_obj[i].age);
            }
        }
    }
    #endregion
}