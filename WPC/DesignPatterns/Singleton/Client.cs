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

            for (int i = 0; i < 10; i++)
            {
                _ = Task.Run(() => Console.WriteLine(Context.Instance.GetSettings("1")));
                //_ = Task.Run(() => Context.GetInstance().GetSettings("1"));
            }


            var value1 = Context.Instance.GetSettings("1");
            //var value1 = Context.GetInstance().GetSettings("1");
            Console.WriteLine($"1: {value1}");

            var value2 = Context.Instance.GetSettings("2");
            //var value2 = Context.GetInstance().GetSettings("2");
            Console.WriteLine($"2: {value2}");

            Context.Instance.SetSettings("3", "x");
            //Context.GetInstance().SetSettings("3", "x");

            var value3 = Context.Instance.GetSettings("3");
            //var value3 = Context.GetInstance().GetSettings("3");
            Console.WriteLine($"3: {value3}");

        }
    }
}
