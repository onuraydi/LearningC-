using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                name = "Onur",
                lastName = "Aydi"
            };
            

            Student student = new Student
            {
                Id = 1,
                name = "Ali",
                lastName = "Yılmaz"
            };
            manager.Add(customer);
            manager.Add(student);
            Console.Read();  
        }
    }
    interface IPerson 
    {
        int Id { get; set; }
        string name { get; set; }
        string lastName { get; set; }

    }
    class Customer : IPerson // bir sonraki ile aynı şey
    {
        public int  Id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
    }
    class Student : IPerson// bu kısım implement interdace secilerek yazıldı
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)      // buraya customer gibi bir parametre göndereseydik bu metot sadece customeri yazmak
                                             // için çalışırdı buraya Iperson gönderdik student için de çalıştı
        {
            Console.WriteLine(person.name);
        }
    }
}
