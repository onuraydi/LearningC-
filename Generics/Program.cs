using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            Utilitiles utulities = new Utilitiles();
            List<string> result = utulities.BuildList<string>("Ankara", "Istanbul", "Edirne");

            foreach (string item in result) 
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utulities.BuildList<Customer>(new Customer { name = "Onur"},new Customer { name = "Ali"});

            foreach (Customer item in result2) 
            {
                Console.WriteLine(item.name);
            }
            Console.ReadLine();
        }
    }
    class Utilitiles 
    {
        // generic metot
        public List<T> BuildList<T>(params T[] items) 
        {
            return new List<T>(items);  
        }
    }
    
    /*
    interface IProductDal
    {
        List<Product> GetAll();
        Product get(int id);

        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
    */
    
    /*
    interface ICustomerDal
    {
        List<Customer> GetAll();
        Customer get(int id);

        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
    */
    class Customer
    {
        public string name { get; set; }
    }

    interface ICustomerDal:IRepository<Customer>
    {
        
    }

    class Product
    {

    }

    interface IProductDal:IRepository<Product> 
    {

    }

    class CustomerDal : ICustomerDal   // direkt impelemente ettik
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    // IProductDal ve ICustomerDal'da iki işlem birbirine çok benziyor onun için generic sınıfları kullanabiliriz. Bunun 
    // isimlendirmesi genel bir şekilde yapılır.

    interface IRepository <T>  // buraya istediğimizi yazarız ancak isimlendirme tekniğinden dolayı T uygun görülür (Type)
    {
        List<T> GetAll();
        T get(int id);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);          //entity = varlık
    }

    interface IRepository2<T> where T:class,new()  // bu kodu yazarak aldığımız paramterenin newlenebilir yani class olarak girilmesini sağlar. 
    {
        List<T> GetAll();
        T get(int id);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);          //entity = varlık
    }
}
