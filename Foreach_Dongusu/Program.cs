using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = new string[3] { "Ali", "Veli", "Onur" };
            foreach (string i in adlar)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
