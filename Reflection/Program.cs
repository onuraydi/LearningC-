using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DortIslem dortIslem = new DortIslem(3,5);
            
            Console.WriteLine(dortIslem.Topla(5, 4));  // bizden tekrar sayı istedi

            Console.WriteLine(dortIslem.Topla2()); // sayı istemedi
            */

            var type = typeof(DortIslem);

            //DortIslem dortislem = (DortIslem)Activator.CreateInstance(type,6,7);  // newlemek ile aynı işi yapar diyebiliriz
            // Bu parametreli bir constructers olduğu için type'den sonra parametreleri gönderdik

            //Console.WriteLine(dortislem.Carp2());
            
            var instance = Activator.CreateInstance(type,5,7);

            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null));  // bu şekilde kullanılabilir.

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");  // bu şeklidede kullanılabilir
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("------------------------------------");

            var metotlar = type.GetMethods();
            
            foreach (var m in metotlar) 
            {
                Console.WriteLine("Metot Adi: {0}",m.Name);
                foreach (var m2 in m.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}", m2.Name);
                }
                
                foreach (var m3 in m.GetCustomAttributes())
                {
                    Console.WriteLine("Attributes: {0}", m3.GetType().Name);
                }
            }

            Console.Read();
        }

    }

    public class DortIslem
    {
        private int _sayi1, _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MethodName("Carpma")]  // bu şekilde attribute adı dışarıya farklı şekilde gözükecek
        public int Carp2() 
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
    }
}
