using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Prototype
{
    public class Client
    {
        public static void Execute()
        {
            var p0 = new Person { Name = "Ewa Tomaszewska", Age = 55, Address = new Address { City = "Kraków", Street = "Warszawska" } };


            var p1 = new Person();

            p1.Parent = p0;
            p1.Name = "Tomasz Tomaszewski";
            p1.Age = 25;
            p1.Address = new Address { City = "Warszawa", Street = "Krakowska" };

            p0.Children = new List<Person>();
            p0.Children.Add(p1);

            var p2 = (Person)p1.Clone();
            p2.Name = "Katarzyna Tomaszewska";
            p0.Children.Add(p2);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            p2.Name = "Katarzyna Katarzyńska";
            p2.Address.Street = "Morska";

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
