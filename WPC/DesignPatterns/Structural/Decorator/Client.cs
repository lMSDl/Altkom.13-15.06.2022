using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Decorator
{
    public class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();
                var notification = (INotification)new Notification();
                if (text.Length <= 10)
                    notification = new SmsNotification(notification);
                if (HasValidEmail())
                    notification = new EmailNotification(notification);


                notification.Send(text);
            }
        }

        private static bool HasValidEmail()
        {
            return DateTime.Now.Second % 2 == 0;
        }
    }
}
