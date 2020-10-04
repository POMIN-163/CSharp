using System;
using InterfacePhone;

namespace SOLID {// SOLID（单一功能、开闭原则、里氏替换、接口隔离以及依赖反转）
    internal class Program {
        private static void Main(string[] args) {
            Interface.Car a = new Interface.Car();
            a.Run();
            a.Fill();
            a.Stop();
            var user1 = new PhoneUser(new NokiaPhone());
            var user2 = new PhoneUser(new EricssonPhone());
            user1.UsePhone();
            user2.UsePhone();
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
namespace Interface {// 接口版抽象
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
namespace InterfacePhone {
    class PhoneUser {
        private IPhone _phone;

        public PhoneUser(IPhone phone) {
            _phone = phone;
        }
        public void UsePhone() {
            _phone.Receive();
            _phone.Send();
        }
    }
    interface IPhone {
        void Send();
        void Receive();
    }
    class NokiaPhone : IPhone {
        public void Send() {
            Console.WriteLine("Nokia ring ...");
        }
        public void Receive() {
            Console.WriteLine("Good morning!");
        }
    }
    class EricssonPhone : IPhone {
        public void Send() {
            Console.WriteLine("Ericsson ring ...");
        }
        public void Receive() {
            Console.WriteLine("Good evening!");
        }
    }
}