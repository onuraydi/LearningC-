using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iç_Ice_If_Else_Bloklari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 20;

            if (number < 100)
            {
                if(number >= 75)
                {
                    Console.WriteLine("The number is between 75-100");
                }
                else
                {
                    Console.WriteLine("error!!");
                }
            }
            Console.ReadLine();
        }
    }   
}
