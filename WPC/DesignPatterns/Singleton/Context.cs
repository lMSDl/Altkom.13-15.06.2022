using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Singleton
{
    public class Context
    {

        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        private Context()
        {
            Console.WriteLine("Inicjalizacja ustawień");
            _settings["1"] = "a";
            _settings["2"] = "b";
            _settings["3"] = "c";
        }

        public string GetSettings(string key)
        {
            return _settings[key];
        }

        public void SetSettings(string key, string value)
        {
            _settings[key] = value;
        }

        private static Context _instance;

        //public static Context GetInstance()
        //{
        //    if (_instance == null)
        //        _instance = new Context();
        //    return _instance;
        //}

        private static object _locker = new object();
        //public static Context GetInstance()
        //{
        //    lock (_locker)
        //    {
        //        if (_instance == null)
        //            _instance = new Context();
        //    }
        //    return _instance;
        //}
        public static Context GetInstance()
        {
            if (_instance == null)
            {
                lock (_locker)
                {
                    if (_instance == null)
                        _instance = new Context();
                }
            }
            return _instance;
        }
    }
}
