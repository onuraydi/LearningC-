using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sart_Bloklari_İf_Else_vb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 19;
            if (number == 19)
            {
                Console.WriteLine("The number is equal to 19");
            }
            else if(number == 20)
            {
                Console.WriteLine("The number is equal to 20");
            }
            else if(number == 18)
            {
                Console.WriteLine("The number is equal to 18");
            }
            else
            {
                Console.WriteLine("The number is not equal to 18, 19 or 20");
            }

            Console.WriteLine(number == 19 ? "The number is equal to 19" : "The number is not equal to 19");
            // bu ise if else'nin kısaltılmış şekilde kullanılışı buna 'Single Line' denir.
            Console.ReadLine();
        }
    }
}
