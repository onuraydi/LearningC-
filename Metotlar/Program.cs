using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(19, 25);
            Console.WriteLine(Add2(34, 44));
            Console.WriteLine(Add3(15));   // 15 verdik bunu default değerle toplar.
          

            int number1 = 19;                 // bunu tanımladan ref ile aynı işlemi yapmak istersek 'out' kullanırız.
            int number2 = 93;
            Console.WriteLine(Add4( ref number1,number2)); // buraya ref koymasaydık number1 toplama için 44 kullanılırdı ancak
            Console.WriteLine(number1);                     // daha sonra 19 değerine geri dönerdi.

            
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(3,5,8));

            Console.WriteLine(Add5(19, 25, 11, 45, 95));
            Console.ReadLine();
        }
        static void Add(int a, int b)
        {
            int toplam = a + b;
            Console.WriteLine(a + " + " + b + " = " + toplam);
        }
        static int Add2 (int a, int b)
        {
            return a + b;
        }

        static int Add3 (int a, int b = 20)  // burada b değeri verilmezse onu default olarak 20 kullanır. 
        {                                    // ancak defalt değer metodun son parametresinde olmalı.
            return (a + b);
        }
        static int Add4 (ref int number1, int number2)  //Burada ref kullanarak dışarıdan gönderdiğimiz değerinde metodun içindeki değere
                                            // eşit olmasını sağlarız diğer türlü number 1 değişmezdi sadece metodun içindeki 
                                            // değeri metot bitene kadar alırdı sonra tekrardan tanımladığımız değere dönerdi.
        {
            number1 = 44;
            return number1 + number2;

        }

        static int Multiply(int a, int b)
        {
            return (a * b);
        }

        static int Multiply(int a, int b, int c)
        {
            return (a * b * c);
        }

        static int Add5(params int[] numbers)   //Buradaki params saesinde istenildiği kadar sayı toplama işlemine sokulabilir.
        {
            return numbers.Sum();
        }
    }

}
