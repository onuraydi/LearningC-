using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bu Kısımda LinQ 'da işlendi. Arama kısmını yaparken linq kullandık.

namespace Entity_Framework_Demo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            // burada using olmadan da kullanabilirdik ancak Context bellekte fazla yer kapladığı için böyle kullandık
            // using ile garbage collectorü beklemeden işi biten nesneleri bellekten zorla silmeye yarar.
            // veritabanı bağlantısı app.config içinden işaretli kısımda yapıldı
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }
        // bu kısımlar LİNQ bazıları tanımlandı ancak kullanılmadı
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }

        public Product GetByID(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == id);
                //SingleOrDefault'ta aynı işi yapar ancak o iki sonuç çıkarsa hata verir.
            }
        }


        public void Add(Product product) 
        {
            using (ETradeContext context = new ETradeContext())
            {
                /* bu şekildede yapılırıd
                  var entity = context.Entry(product); 
                  entity.State = EntityState.Added;
                */
                context.Products.Add(product);
                context.SaveChanges(); // veritabanına yaz demek
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); 
                entity.State = EntityState.Modified;
                context.SaveChanges(); // veritabanına yaz demek
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges(); // veritabanına yaz demek
            }
        }
    }
}
