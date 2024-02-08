using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf_Else_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 19;
            if((number >= 0) && (number <= 100))
            {
                Console.WriteLine("The number is between 0 and 100");
            }
            else if((number > 100) && (number <= 200))
            {
                Console.WriteLine("The number is between 101 and 200");
            }
            else if((number > 200) || (number < 0))
            {
                Console.WriteLine("The number is not between 0 and 200");
            }

            Console.ReadLine();
        }
    }
}
