using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Bridge.I
{
    public class Client
    {
        public static void Execute()
        {
            Shape shape = new Square();
            Console.WriteLine(shape);
            shape.Color = new Red();
            Console.WriteLine(shape);

            shape = new Circle();
            Console.WriteLine(shape);
            shape.Color = new Blue();
            Console.WriteLine(shape);
        }
    }
}
