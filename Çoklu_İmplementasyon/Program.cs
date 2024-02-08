using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çoklu_İmplementasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                    worker.work();
            }
            IGetSalary[] salary = new IGetSalary[2]
            {
                new Worker(),
                new Manager()
            };
            foreach(var sal in salary)
            {
                sal.GetSalary();
            }
            IEat[] eat = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach(var eats in eat)
            {
                eats.Eat();
            }
            Console.ReadLine();
        }
    }
    interface IWorker 
    {
        void work();
    }
    interface IEat
    {
        void Eat();
    }
    interface IGetSalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, IGetSalary 
    {
        public void Eat()
        {
            Console.WriteLine("true");
        }

        public void GetSalary()
        {
            Console.WriteLine("true");
        }

        public void work()
        {
            Console.WriteLine("true");
        }
    } 
    class Worker : IWorker, IGetSalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("true");
        }

        public void GetSalary()
        {
            Console.WriteLine("true");
        }

        public void work()
        {
            Console.WriteLine("true");
        }
    }
    class Robot : IWorker
    {
        public void work()
        {
            Console.WriteLine("true");
        }
    }
}
