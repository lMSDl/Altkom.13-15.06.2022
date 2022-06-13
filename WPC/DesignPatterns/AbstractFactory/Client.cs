using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WPC.DesignPatterns.AbstractFactory.Factories;

namespace WPC.DesignPatterns.AbstractFactory
{
    public static class Client
    {
        public static void Execute()
        {
            var order = new Order();

            order.SelectCar(new HondaFactory(), "Compact", "Sedan");

            Console.WriteLine(order.Car.Name());
        }
    }
}
