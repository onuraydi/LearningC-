using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attiributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Age = 19,
                FirstName = "Onur",
                LastName = "Aydi",
                Id = 1
            };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.Read();
        }
    }
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperyt]
        public string FirstName { get; set; }
        [RequiredProperyt]
        public string LastName { get; set; }
        [RequiredProperyt]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Buraya yazdığımız yazı 22. satırdaki koddun üstüne mouse getirdiğimizde gözükecek")]  // hazır attribute
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added!",customer.FirstName,customer.LastName,customer.Age,customer.Id);
        }
    }
    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]  şeklindede kullanımı vardır.
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)]  // nesneler (proportieslar) için kullanacağımız için kullanıldık
    //allow multiple bir proporties için birden fazla kez kullanılabilir mi demek.
    class RequiaredPropertyAttribute:Attribute
    {
         
    }

    class ToTableAttribute:Attribute
    {
        private string _tableName;

        public ToTableAttribute(string v)
        {
            this._tableName = _tableName;
        }
    }
}
