using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int  MyDelegate3(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManeger customerManeger = new CustomerManeger();
            //customerManeger.SendMessage();
            //customerManeger.ShowAllert();

            MyDelegate myDelegate = customerManeger.SendMessage;
            myDelegate += customerManeger.ShowAlert;
                
            myDelegate -= customerManeger.SendMessage;

            myDelegate();

            MyDelegate2 myDelegate2 = customerManeger.SendMessage2;
            myDelegate2 += customerManeger.ShowAlert2;

            myDelegate2("Hello!!!");  // ikisine de aynı değeri gönderdik bu da delegateslerin kısıtıdır.

            Matematik matematik = new Matematik();

            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;

            var result = myDelegate3(15, 10);  // burada dönüş tipinden dolayı en son verdiğimiz metotdu yazdıracak yani toplama 
            Console.WriteLine(result);         // değil çarpma yapacak ve onu yazdıracak.

            Console.ReadLine();
        }
    }

    public class CustomerManeger
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1 , int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
