using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Decorator
{
    public abstract class NotificationDecorator : INotification
    {
        private INotification _notification;

        protected NotificationDecorator(INotification notification)
        {
            _notification = notification;
        }

        public void Send(string message)
        {
            _notification.Send(message);
            SuperSend(message);
        }

        protected abstract void SuperSend(string message);
    }
}
