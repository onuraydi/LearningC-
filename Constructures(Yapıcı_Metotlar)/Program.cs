using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructures_Yapıcı_Metotlar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManeger customer = new CustomerManeger(10);
            customer.Add();
            customer.List();

            Product product = new Product(2,"Laptop");
            //hata yok ekrana yazdırılmadı

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("entity eklendi");
            personManager.Add();

            Teacher.Number = 10;  //newlenmedi

            Utulities.Validate();

            Manager manager = new Manager();
            manager.DoSomething2();  // nesneden

            Manager.DoSometing();  // direkt classtan

            Console.Read();
        }
    }
    class CustomerManeger
    {
        private int _count;
        public CustomerManeger(int count)
        {
            _count = count; 
        }
        public void List()
        {
            Console.WriteLine("Listed {0} item!",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added!!!");
        }
    }

    class Product
    {
        public Product()
        {
            
        }

        int _id;
        string _name;
        public Product(int id, string name)    // oop dersinde c++ ile çokça yaptık
        {
            _id = id;
            _name = name;
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger: ILogger
    {
        public void Log() 
        {
            Console.WriteLine("Logged to database!!");
        }
    }

    class FileLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!!");
        }

    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!!");
        }
    }

    class BaseClass
    {
        private string _entity;
 
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message!",_entity);
        }
    }

    class PersonManager: BaseClass
    {
        public PersonManager(string entity): base(entity) 
        {

        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher   // nesne oluşturmamıza gerek kalmadan(newlemeden) kullanılır
    {
        public static int Number { get; set; }  // static olmak zorunda
    }

    static class Utulities
    {
        public static void Validate()
        {
            Console.WriteLine("Validetion is done!");
        }
    }

    class Manager
    {
        public static void DoSometing()
        {
            Console.WriteLine("Done 1");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
}
