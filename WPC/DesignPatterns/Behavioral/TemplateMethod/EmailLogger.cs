using System;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public class EmailLogger : Logger<Email, IDisposable>
    {
        protected override IDisposable GetService()
        {
            return null;
        }

        protected override Email CreateItem(string message)
        {
            return new Email { Subject = "Logger", Content = message };
        }

        protected override void Save(Email message, IDisposable service)
        {
            Console.WriteLine("Sending Email with Log Message : " + message.Content);
        }
    }
}
