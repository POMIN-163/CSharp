using System;

namespace Interface_test {
    internal class Program {
        private static void Main(string[] args) {
            Interface.Car a = new Interface.Car();
            a.Run();
            a.Fill();
            a.Stop();
        }
    }
    internal abstract class Vehicle {
        public void Stop() {
            Console.WriteLine("Stopped!");
        }
        public abstract void Run();// 抽象函数
    }
    internal class Car : Vehicle {
        public override void Run() {
            Console.WriteLine("Car is running...");
        }
    }
    internal class RaceCar : Vehicle {
        public override void Run() {
            Console.WriteLine("Race car is running...");
        }
    }
}
namespace Interface {// 接口
    internal interface IVehicleBase {
        void Stop();
        void Fill();
        void Run();
    }
    internal abstract class Vehicle : IVehicleBase {
        public void Stop() {
            Console.WriteLine("Stopped!");
        }
        public void Fill() {
            Console.WriteLine("Pay and fill...");
        }
        public abstract void Run();// Run 暂未实现，所以依然是 abstract 的
    }
    internal class Car : Vehicle {
        public override void Run() {
            Console.WriteLine("Car is running...");
        }
    }
}