using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// kendi hata sınıfımızı farklı dosya olarak oluşturduk bu klasörün içindeki diğer .cs uzantılı dosyaya bak

namespace Exception_Hata_Yonetimi_
{
    internal class Program
    {
        private static void Find()
        {
            List<string> students = new List<string> { "Ali", "Ahmet", "Yavuz" };

            if (!students.Contains("Onur"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        //func metodu için
        static int topla(int x, int y) 
        {
            return x + y;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(topla(3,5));

            Func<int,int,int> add = topla;   // 3. int func dönüş tipinide  döndüreceği iöçin konur
            Console.WriteLine(add(1, 2));   // mesela funcun tek veri tipi varsa o dönüş tipidir (return'ün tipi)

            Func<int> getRandomNumber = delegate
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine("Random number: {0}",getRandomNumber());


            Thread.Sleep(1000);  // bekleterek aynı sayıyı vermemelerini sağlar.
            Func<int> getRandomNumber2 =()=>new Random().Next(1,100);

            Console.WriteLine("2. Random number: {0}",getRandomNumber2());  
            //aynı sayıyı üretmesinin nedeni random ile alakalı bir durumdur

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            //try ve catch'in yerine bunu da kullanabiliriz(Action)
            HandleException(() =>
            {
                Find();
            });

            /*
            try
            {
                string[] students = new string[3] { "Ali", "Ahmet", "Burak" };

                students[3] = "Berat";
            }
            catch (Exception)
            {

                Console.WriteLine("Hataa!!");
            }
            */

            /*
            try
            {
                string[] students = new string[3] { "Ali", "Ahmet", "Burak" };

                students[3] = "Berat";
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            */
            /*
            try
            {
                string[] students = new string[3] { "Ali", "Ahmet", "Burak" };

                students[3] = "Berat";
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.InnerException); // varsa Exception hakkında daha detaylı bilgi verir.
            }
            */

            /*
            try
            {
                string[] students = new string[3] { "Ali", "Ahmet", "Burak" };

                students[3] = "Berat";
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception)
            {

                Console.WriteLine("Hataa!!");
            }
            */

            Console.ReadLine();
        }
        // handle excepiton metodu
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
