using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Iterator
{
    public class Client
    {
        public static void Execute()
        {
            List<string> list = new List<string> { "1", "2", "3", "4" };

            var buffer = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine(buffer+list[i]);
                buffer = list[i];
            }

            IEnumerator<Tuple<string, string>> bufferIterator = new BufferIterator<string>(list.GetEnumerator());

            var bufferCollection = new Buffer<string>(list);
            bufferIterator = bufferCollection.GetEnumerator();
            while(bufferIterator.MoveNext())
            {
                Console.WriteLine(bufferIterator.Current.Item1+ bufferIterator.Current.Item2);
            }

            foreach(var item in bufferCollection)
            {
                Console.WriteLine(item.Item1+item.Item2);
            }
        }
    }
}
