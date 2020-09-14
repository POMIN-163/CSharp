using System;
using System.Threading;

namespace Demo_My_events {
    internal class Program {
        private static void Main(string[] args) {
            Event_Test.Main.Main_Start();

            var customer = new Customer(); // 1.事件拥有者
            var waiter = new Waiter(); // 2.事件响应者
            customer.Order += waiter.Action;// // 3.Order 事件成员 5. +=事件订阅

            customer.Action();
            customer.PayTheBill();
        }
    }
    // 该类用于传递点的是什么菜，作为事件参数，需要以 EventArgs 结尾，且继承自 EventArgs
    public class OrderEventArgs : EventArgs {
        public string DishName { get; set; }
        public string Size { get; set; }
    }
    // 声明一个委托类型，因为该委托用于事件处理，所以以 EventHandler 结尾 注意委托类型的声明和类声明是平级的
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);
    public class Customer {
        // 委托类型字段
        private OrderEventHandler orderEventHandler;
        // 事件声明
        public event OrderEventHandler Order
        {
            add { this.orderEventHandler += value; }
            remove { this.orderEventHandler -= value; }
        }

        public double Bill { get; set; }

        public void PayTheBill() => Console.WriteLine("I will pay ${0}.", this.Bill);
        public void SitDown() => Console.WriteLine("Sit down.");

        public void Think() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Let me think ...");
                Thread.Sleep(1000);
            }
            if (this.orderEventHandler != null) {
                var e = new OrderEventArgs();
                e.DishName = "Kongpao Chicken";
                e.Size = "large";
                this.orderEventHandler.Invoke(this, e);
            }
        }
        public void Action() {
            Console.ReadLine();
            SitDown();
            Think();
        }
    }

    public class Waiter {
        // 4.事件处理器
        public void Action(Customer customer, OrderEventArgs e) {
            Console.WriteLine("I will serve you the dish - {0}.", e.DishName);
            double price = 0;
            switch (e.Size) {
                case "small": price = 5; break;
                case "large": price = 15; break;
                default: break;
            }
            customer.Bill += price;
        }
    }
}
namespace Event_Test {
    public class Main {
        public static void Main_Start() {
            MyEvent_student OneStu = new MyEvent_student();// 事件主体实例
            ActionEventArgs Act = new ActionEventArgs// 事件参数实例
            {
                Name = "Pomin",
                Age = 19,
                Num = 1,
            };
            OneStu.Order += Event.Answer;// 事件订阅
            OneStu.Begin(Act);
            // Process.GetCurrentProcess().Kill();
        }
    }
    public delegate void OrderEventHandler(MyEvent_student stu, ActionEventArgs e);// 事件委托
    public class ActionEventArgs : EventArgs// 事件参数
    {
        public int Num { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public ActionEventArgs() {
            Console.WriteLine("事件参数实例创建：OK");
        }
    }
    public class MyEvent_student// 事件主体
    {
        private OrderEventHandler myEvent_action;// 委托字段

        public MyEvent_student() {
            Console.WriteLine("事件主体实例创建：OK");
        }
        public event OrderEventHandler Order// 事件声明
        {
            add { this.myEvent_action += value; }
            remove { this.myEvent_action -= value; }
        }
        public void Begin(ActionEventArgs tmp)// 事件发生
        {
            myEvent_action.Invoke(this, tmp);// 事件触发
        }
    }
    public class Event// 事件内容
    {
        public static void Answer(MyEvent_student stu, ActionEventArgs e) {
            Console.WriteLine("Num:" + e.Num + "Name:" + e.Name + "Age:" + e.Age + " DONE");
        }
    }
}