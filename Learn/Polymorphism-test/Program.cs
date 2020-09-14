using System;

namespace Polymorphism_test {// 多态
    internal class Program {
        private static void Main(string[] args) {
            Vehicle v = new RaceCar();
            v.Run();
            // Race car is running!

            Car c = new RaceCar();
            c.Run();
            // Race car is running!
        }
    }
    internal class Vehicle {
        public virtual void Run() {
            Console.WriteLine("I'm running!");
        }
    }
    internal class Car : Vehicle {
        public override void Run() {
            Console.WriteLine("Car is running!");
        }
    }
    internal class RaceCar : Car {
        public override void Run() {
            Console.WriteLine("Race car is running!");
        }
    }
}