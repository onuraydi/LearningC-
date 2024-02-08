using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Rurleri_Ve_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 19;
            int number2 = 34;   // int veri tipi belirli bir değer aralığındaki değerleri alabilir.
            Console.WriteLine("Number1 is {0} and number2 is {1}",number1, number2);
            //Burada index gibi düşünebiliriz 0 ilk değişkeni 1 ise ikinci değişkeni yazdırır
            
            long number3 = 193402578964555;  // int bu değeri alamaz ancak long bellekte intin iki katı değer saklar.
            Console.WriteLine($"The long number is {number3}");

            short number4 = 3245; // short veri tipi bellekte intin yarısı kadar yer kaplar ancak daha küçük 
            // değerleri tutar.
            Console.WriteLine($"The short number is {number4}");

            byte number5 = 196;  // Byte veri tipi ise shortun yarısı kadar yer kaplar ancak daha küçük değerler tutar. 
            Console.WriteLine($"The byte number is {number5}");
            
            //Buraya kadar olan veri türleri tam sayı tuta veri türleridir.

            bool trueOrFalse = false;  // bu ise iki değer alır true yada false. bu mantıksal bir veri tipidir.
            Console.WriteLine(trueOrFalse);

            char character = 'C'; // bu ise karakter tutan veri tipidir.
            Console.WriteLine(character);

            string word = "Istanbul"; // bu ise bir nevi karakter dizisidir kelime vb tutmak için kullanılır.
            Console.WriteLine(word);

            double number6 = 19.34;  // double ondalıklı değerleri tutmaya yarayan veri tipidir.
            Console.WriteLine(number6);

            decimal number7 = 10.487956646556485396m;  // bu int ile long arasındali farkın double 
            //ile decimal arasnaki farkı gibidir.
            Console.WriteLine(number7);

            float number8 = 19.34f;  // bu ise doubleden daha az yer kaplar ancak virgülden sonra daha az 
            //basamak alır.
            Console.WriteLine(number8);

            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Monday);

            var number9 = 15; // var otomatik olarak veri türünü tutar.
            Console.WriteLine(number9);

            number9 = 'A';   // ascıı tablosundaki değerini verir.
            Console.WriteLine(number9);

            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday = 0, Tuesday = 1, Wednesday = 2, Thursday = 3, Friday = 4, Saturday = 5, Sunday = 6
    }; // enumlar bu şekilde tanımlanır ancak sayıları koymaya gerek yoktur indexten de erişilebilir 
    // ya da farklı sayılar koyabiliriz.
}
