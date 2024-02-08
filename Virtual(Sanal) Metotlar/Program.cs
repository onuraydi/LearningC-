using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Sanal_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            MySql mySql = new MySql();

            sqlServer.Add();
            mySql.Delete();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Virtaul metot ve override ile kalıtımı farklılaştırdık");
            //base.Add();
        }
    }

    class MySql:Database
    {

    }
}
