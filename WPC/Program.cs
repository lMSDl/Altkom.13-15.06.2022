using System;
using WPC.SOLID.L;

namespace WPC
{
    class Program
    {
        static void Main(string[] args)
        {
            WPC.DesignPatterns.Behavioral.Visitor.II.Client.Execute();
        }

        private static void LSP()
        {
            var rectangle = GetRectangle();

            var a = 5;
            var b = 3;

            rectangle.A = a;
            rectangle.B = b;
            Console.WriteLine($"{a}*{b} = {rectangle.Area}");
        }

        static Rectangle GetRectangle()
        {
            return new Square();
        } 

    }
}
