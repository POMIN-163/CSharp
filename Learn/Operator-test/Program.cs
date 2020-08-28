using System;
using System.Collections.Generic;

namespace Operator_test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            People one = new People("pomin-1", 19);
            People two = new People("pomin-2", 20);

            List<People> list = People.AddMember(one, two);
            Console.WriteLine("test 1::");
            foreach (var p in list)
            {
                Console.WriteLine("\n name:" + p.name + "\n age:" + p.age);
            }
            list = one ^ two;
            Console.WriteLine("test 2::");
            foreach (var p in list)
            {
                Console.WriteLine("\n name:" + p.name + "\n age:" + p.age);
            }
        }
    }

    internal class People
    {
        public string name;
        public int age;

        public People(string name_, int age_)
        {
            name = name_;
            age = age_;
        }

        public static List<People> AddMember(People p1, People p2)
        {
            List<People> people = new List<People>
            {
                p1,
                p2
            };

            return people;
        }

        public static List<People> operator ^(People p1, People p2)
        {
            List<People> people = new List<People>
            {
                p1,
                p2
            };

            return people;
        }
    }
}