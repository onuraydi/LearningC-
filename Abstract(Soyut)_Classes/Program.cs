using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Soyut__Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            Oracle oracle = new Oracle();

            Database db = new Oracle();
            db.Add();
            db.Delete();


            sqlServer.Delete();
            oracle.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Farklı bir şekilde Silme yapacağız");
        } 
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Daha da farklı şekilde silme yapacağız");
        }
    }
}
