using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Proxy
{
    public class Database : IDatabase
    {
        private int _connectionCounter = 5;

        public async Task<int?> RequestAsync(int parameter)
        {
            if(_connectionCounter <= 0)
            {
                Console.WriteLine($"Request {parameter} dropped!");
                return null;
            }

            Interlocked.Decrement(ref _connectionCounter);
            Console.WriteLine($"Available connections {_connectionCounter}");
            await Task.Delay(new Random(_connectionCounter).Next(1000, 3000));

            Console.WriteLine($"Request {parameter} completed ({_connectionCounter})");
            Interlocked.Increment(ref _connectionCounter);
            return parameter;
        }
    }
}
