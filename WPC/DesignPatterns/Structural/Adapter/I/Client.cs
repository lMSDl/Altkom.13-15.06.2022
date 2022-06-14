using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.I
{
    public class Client
    {
        public static void Execute()
        {
            ICircle item = new Circle() { R = 5 };
            item = new SquareToCircleAdapter(new Square() { A = 8 });

            CheckR(item);
        }


        public static void CheckR(ICircle circle)
        {
            Console.WriteLine(circle.R <= 5);
        }
    }
}
