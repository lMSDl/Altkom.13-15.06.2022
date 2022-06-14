using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Flyweight
{
    public class Client
    {
        public static void Execute()
        {
            var factory = new FlyweightFactory(
                                    new CarFlyweight { Manufacturer = "Chevrolet", Model = "Camaro2018", Color = "Pink" },
                                    new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C300", Color = "Black" },
                                    new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C500", Color = "Red" },
                                    new CarFlyweight { Manufacturer = "BMW", Model = "M5", Color = "Red" },
                                    new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "White" });
            Console.WriteLine(factory);

            var car = new Car("Ewa", "ASSA232", "Mercedes Benz", "C300", "Black");
            car.CarFlyweight = factory.GetCarFlyweight(car.CarFlyweight);
            Console.WriteLine(factory);

            var car2 = new Car("Adam", "EEA2221", "Mercedes Benz", "C300", "White");
            Console.WriteLine(factory);
            car2.CarFlyweight = factory.GetCarFlyweight(car2.CarFlyweight);
            Console.WriteLine(factory);


            var car3 = new Car("Adam", "EEA2221", "Mercedes Benz", "C300", "White");
            Console.WriteLine(factory);
            car3.CarFlyweight = factory.GetCarFlyweight(car3.CarFlyweight);
            Console.WriteLine(factory);

            Console.WriteLine(car3);
            Console.WriteLine(car2);
            //car2.Color = "Red";
            car2.CarFlyweight = factory.GetCarFlyweight(new CarFlyweight { Manufacturer = car2.Manufacturer, Model = car2.Model, Color = "Red" });
            Console.WriteLine(car3);
            Console.WriteLine(car2);
        }
    }
}
