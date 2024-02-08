using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_Sayı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayi giriniz: ");
            var sayi = Convert.ToInt32(Console.ReadLine());
            if (asalmi(sayi))
            {
                Console.WriteLine("Girdiğiniz sayı asal bir sayıdır.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı asal sayı değildir.");
            }
            Console.ReadLine();
        }
        private static bool asalmi(int number ) 
        {
            bool result = true;
            for(int i = 2; i <= number - 1; i++) 
            {
                if(number % i == 0) 
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
