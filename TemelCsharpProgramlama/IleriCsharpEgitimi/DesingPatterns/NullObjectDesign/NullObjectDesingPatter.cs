using System;
using FactoryMethodDesignAbstractNameSpace;

namespace NullObjectDesingPatterNamespace
{
    class NullObjectDesingPatterClass
    {
        public static void NullObjectDesingPatterRunMethod()
        {
            CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger());
            customerManager.Save();
            
        }
    }
    class CustomerManager
    {
        private ILogger _logger;

        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            System.Console.WriteLine("Saved");
            _logger.Log();
        }
    }

    interface ILogger
    {
        void Log();
    }

    class Log4NetLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged with Log4Net");
        }
    }

    class NlogLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged with NLogLogger");

        }
    }

   sealed class StubLogger : ILogger
    {
        private static StubLogger? _stubLogger;
        private static object _lock = new object();

        private StubLogger() { }

        public static StubLogger GetLogger()
        {
            lock (_lock)
            {
                if (_stubLogger == null)
                {
                    _stubLogger = new StubLogger();
                }
            }
            return _stubLogger;
        }
        public void Log()
        {
           
        }
    }

    class CustomerManagerTest
    {
        public void SaveTest()
        {
            CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger());
            customerManager.Save();
        }
    }
}