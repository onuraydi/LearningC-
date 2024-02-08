using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_DEMO_ETrade_
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server = ONUR_PC\SQLDENEME;initial catalog = ETrade;integrated security = true");
        // Bağlantı nesnesi oluşturuldu. @ işareti tüm ifadeyi string olarak görmesini sağladı. security ise windows izni diyebiliriz.
        // server= bağlanılacak serverin adı, inital catalog ise bağlanılacak veri tabanı.Bunu başka classlarda da kullanacağımızdan burada tanımladık

        public List<Product> GetAll()
        {
            // Bunu böyle yazmamızın nedeni bağlantı açıksa tekrar açmaya çalıştığımızda sıkıntı çıkaracak olmasıdır.
            ConnectionControl();


            // select from product kısmını veritabanına sağ tıklayarak new querry'nin içine yazarak ürünlere erişebiliriz.
            // connection yazarak bu verileri(komutu) connectiona gönderdik
            SqlCommand command = new SqlCommand("select * from Products", _connection);


            // bu şekilde tablodaki değerleri döndürdük
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            //reader.read gelen verileri okuyabildiğin kadar oku demek
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }


            reader.Close();
            _connection.Close();
            return products;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@UnitPrice,@StockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);

            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name = @name, UnitPrice = @unitPrice, StockAmount = @stockAmount where Id = @id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
           
            command.ExecuteNonQuery();
           
            _connection.Close();
        }


        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from products where Id = @id", _connection);
            command.Parameters.AddWithValue("@id", id);
            
            command.ExecuteNonQuery();
            _connection.Close();
        }

        private void ConnectionControl()
        {
            // Bunu böyle yazmamızın nedeni bağlantı açıksa tekrar açmaya çalıştığımızda sıkıntı çıkaracak olmasıdır.bunu daha sonrada kullanacağımız için metot
            // olarak tanımkladık
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }



        // bu yöntem (DataTable) bellekte fazla yer tğketmesi ,serileştirme olmaması gibi nedenlerele artık kullanılmamaktadr.
        /*
        public DataTable GetAll()  
        {
            // Bunu böyle yazmamızın nedeni bağlantı açıksa tekrar açmaya çalıştığımızda sıkıntı çıkaracak olmasıdır.
            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }


            // select from product kısmını veritabanına sağ tıklayarak new querry'nin içine yazarak ürünlere erişebiliriz.
            //connection yazarak bu verileri(komutu) connectiona gönderdik
            SqlCommand command = new SqlCommand("select * from Products",connection);


            // bu şekilde tablodaki değerleri döndürdük
            SqlDataReader reader = command.ExecuteReader();
            
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;

         }
        */

    }
}
