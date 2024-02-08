using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Logger = new SmsLogger();
            customer.Add();
            
            Console.Read();
        }
    }
    class Customer
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }

    class Database : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }
    class FileLogger: ILogger 
    {
        public void Log() 
        {
            Console.WriteLine("Logged to File!");
        }
    }
    class SmsLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
