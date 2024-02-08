using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Students = new string[3];

            Students[0] = "Ali";
            Students[1] = "Veli";
            Students[2] = "Ayse";

            string[] Studens2 = { "Ali", "Veli", "Ayse", "Fatma" };

            String[,] Bolge = new string[3, 3]
            {
                {"Istanbul","Kocaeli","Bursa" },
                {"Ankara","Cankırı","Yozgat" },
                {"Rize","Trabzon","Artvin" }
            };



            foreach (string s in Students)
            {
                Console.WriteLine(s);
            }

            foreach (string s in Studens2)
            {
                Console.WriteLine(s);
            }
            
            for(int i = 0;i <= Bolge.GetUpperBound(0);i++)
            {
                for(int j = 0; j <= Bolge.GetUpperBound(1); j++)
                {
                    Console.WriteLine(Bolge[i,j]);
                }
                Console.WriteLine("--------");
            }

            Console.ReadLine();

        }
    }
}
