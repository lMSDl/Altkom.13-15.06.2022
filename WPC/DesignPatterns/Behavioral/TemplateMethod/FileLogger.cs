using System;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public class FileLogger : Logger<string, FileService>
    {
        private void CloseFile()
        {
            Console.WriteLine("Close File.");
        }

        protected override void Save(string message, FileService service)
        {
            Console.WriteLine("Appending Log message to file : " + message);
        }

        protected override FileService GetService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }

        protected override string CreateItem(string message)
        {
            return message;
        }
    }
}
