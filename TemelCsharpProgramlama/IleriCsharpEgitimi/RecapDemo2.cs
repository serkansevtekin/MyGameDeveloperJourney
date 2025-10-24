using System;

namespace CSharpProgramlama.IleriCSharpEgitimi.RecapDemo2
{
    public class RecapDemo2
    {
        public static void RecapDemo2Run()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();
        }
    }

    class CustomerManager
    {
        public  ILogger? Logger { get; set; }
        public void Add()
        {
            Logger!.Log();
            System.Console.WriteLine("Customer Added!");
        }
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged to database!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged to file!");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
           System.Console.WriteLine("Logged to sms");
        }
    }

    interface ILogger
    {
        void Log();
    }
}