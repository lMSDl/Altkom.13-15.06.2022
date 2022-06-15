using System;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger<DbLog, LogService>
    {
        private void CloseDbConnection()
        {
            Console.WriteLine("Closing DB connection.");
        }

        protected override string PrepareMessage(string message)
        {
            return message;
        }

        protected override DbLog CreateItem(string message)
        {
            return new DbLog { DateTime = DateTime.Now, Message = message };
        }

        protected override void Save(DbLog message, LogService service)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + message.Message);
        }

        protected override LogService GetService()
        {
            Console.WriteLine("Connecting to Database.");
            return new LogService();
        }
    }
}
