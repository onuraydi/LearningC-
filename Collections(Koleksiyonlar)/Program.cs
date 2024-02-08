using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Koleksiyonlar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();

            cities.Add("Ankara");
            cities.Add("Istanbul");
            cities.Add("Corum");
            cities.Add(19);
            cities.Add('A');



            foreach (var i in cities) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // tip güvenli koleksiyonlar

            List<string> cars = new List<string>();

            cars.Add("Mercedes");
            cars.Add("Audi");
            cars.Add("Toyota");

            foreach (var i in cars)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine() ;

            List<Customer> customer = new List<Customer>()
            {
                new Customer {Id = 11, Name = "veli"},
                new Customer {Id = 22, Name = "Ayse"}
            };

            customer.Add(new Customer() { Id = 10, Name = "Ali" });
            
            var count = customer.Count();
            Console.WriteLine(count);

            //customer.Clear();

            Console.WriteLine(customer.IndexOf(customer[1]));



            Console.WriteLine();
            foreach (var i in customer)
            {
                Console.WriteLine(i.Id);
                Console.WriteLine(i.Name);
            }


            Console.WriteLine();
            //Dictionray

            Dictionary<string,string> dictionary = new Dictionary<string,string>();

            dictionary.Add("book", "kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");
            dictionary.Add("Pencil", "Kalem");

            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["Computer"]);

            foreach (var i in dictionary)
            {
                Console.WriteLine(i);
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);
            }

            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
