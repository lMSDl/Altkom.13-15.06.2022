using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Logger<T, TService> where TService : IDisposable
    {
        public void Log(string message)
        {
            message = PrepareMessage(message);
            using (var service = GetService())
            //var service = GetService();
            {
                T item = CreateItem(message);
                Save(item, service);
                //    service.Dispose();
            }
        }

        protected abstract T CreateItem(string message);
        protected abstract void Save(T message, TService service);
        protected abstract TService GetService();
        protected virtual string PrepareMessage(string message)
        {
            return $"{DateTime.Now}: {message}";
        }
    }
}
