using System;

namespace Override_test {

    internal class Program {

        private static void Main(string[] args) {
            Car a = new Car();
            a.Run();
        }
    }

    internal class Vehicle {

        public virtual void Run() {
            Console.WriteLine("I'm running!");// 被重写的基类方法
        }
    }

    internal class Car : Vehicle {

        public override void Run() {
            Console.WriteLine("Car is running!");// 继承类重写基类的方法
        }
    }
}