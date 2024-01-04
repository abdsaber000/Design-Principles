using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pizza
    {
        public virtual string Name => $"{nameof(Pizza)}";
        public virtual decimal Price => 10;
        public static Pizza Order(string type)
        {
            Pizza pizza = new Pizza();
            if(type == "cheese")
            {
                pizza = new Cheese();
            }else if(type == "chicken")
            {
                pizza = new Chicken();
            }
            Prepare();
            Cook();
            Cut();
            return pizza;
        }

        public static Pizza Order2(string type)
        {
            Pizza pizza = new Pizza();
            if (type == "cheese")
            {
                pizza = new Cheese();
            }
            else if (type == "chicken")
            {
                pizza = new Chicken();
            }
            Prepare();
            Cook();
            Cut();
            return pizza;
        }

        private static void Prepare()
        {
            Console.WriteLine("Preparing...");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }

        private static void Cook()
        {
            Console.WriteLine("Cooking...");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }

        private static void Cut()
        {
            Console.WriteLine("Cutting...");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }
        public override string ToString()
        {
            return $"Name : {Name} \nPrice : {Price}";
        }
    }
}
