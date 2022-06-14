using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Decorator
{
    public class SmsNotification : NotificationDecorator
    {
        public SmsNotification(INotification notification) : base(notification)
        {
        }

        protected override void SuperSend(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }
}
