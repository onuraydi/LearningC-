using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnharitance_Kalıtım_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person{Id = 19, Name = "Onur", Surname = "Aydi"},
                new Customer{Id = 20, Name = "Ali", Surname = "Yılmaz", City = "Ankara"},
                new Student{Id = 21, Name = "Veli", Surname = "Yılmaz", Department = "asd"}
            };
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Surname);
                Console.WriteLine(person.Id);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get;set; }
        public string Surname { get;set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
