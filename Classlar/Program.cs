using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();
            manager.Add();
            manager.Update();

            student student1 = new student();        // bu şekildede kullanılır
            student1.studentName = "Ali";
            student1.studentId = 338;
            student1.studentGrade = 85;

            student student2 = new student      // bu şekildede kullanılır
            {
                studentName = "Veli",
                studentId = 710,
                studentGrade = 88
            };
            Console.WriteLine(student1.studentName); 
            Console.WriteLine(student2.studentName);
            Console.WriteLine(student1.studentId);
            Console.WriteLine(student2.studentId);
            Console.WriteLine(student2.studentGrade);
            Console.WriteLine(student1.studentGrade);
            



            
            Console.Read();
        }
    }

    class CustomerManager
    {
        public void Add() 
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update() 
        {
            Console.WriteLine("Customer Updated");
        }

    }
    class student 
    {
        public int studentId { get; set; }                // bunlar proportieslerdir bir şeyin özelliklerini tutmak için kullanılır.
        public string studentName { get; set; }             // prop yazıp 2 kere tab yazdığımızda ana formunu alır
        public int studentGrade { get; set; }
    }

}
