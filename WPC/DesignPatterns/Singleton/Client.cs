using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Singleton
{
    public class Client
    {
        public static void Execute()
        {

            for (int i = 0; i < 3; i++)
            {
                _ = Task.Run(() => Context.GetInstance().GetSettings("1"));
            }


            var value1 = Context.GetInstance().GetSettings("1");
            Console.WriteLine($"1: {value1}");

            var value2 = Context.GetInstance().GetSettings("2");
            Console.WriteLine($"2: {value2}");

            Context.GetInstance().SetSettings("3", "x");

            var value3 = Context.GetInstance().GetSettings("3");
            Console.WriteLine($"3: {value3}");

        }
    }
}
