using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referance_And_Value_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Adana" };
            string[] cities2 = new string[] { "Bursa", "Bolu" };

            cities2 = cities1;
            cities1[0] = "Corum";

            foreach (string city in cities2) 
            {
                Console.WriteLine(city);
            }
            Console.Read();
        }
    }
}
