using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir = "Ankara";
            Console.WriteLine(sehir);
            foreach (var i in sehir)
            {
                Console.WriteLine(i);
            }
            string sehir2 = "Istanbul";
            string result = sehir + " "+ sehir2;
            Console.WriteLine(result);

            string cumle = "Merhaba yazılım dünyası!";
            Console.WriteLine(cumle.Length);
            Console.WriteLine(cumle.Clone());
            Console.WriteLine(cumle.EndsWith("!"));
            Console.WriteLine(cumle.StartsWith("a"));
            Console.WriteLine(cumle.IndexOf("h"));
            Console.WriteLine(cumle.IndexOf("yazılım"));
            Console.WriteLine(cumle.LastIndexOf("a"));
            Console.WriteLine(cumle.Insert(0, "asd "));
            Console.WriteLine(cumle.Substring(8));
            Console.WriteLine(cumle.ToLower());
            Console.WriteLine(cumle.ToUpper());
            Console.WriteLine(cumle.Replace(" ","-"));
            Console.WriteLine(cumle.Remove(8));
            Console.ReadLine();
        }
    }
}
