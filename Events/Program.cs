using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";
            harddisk.StockControlEvent += Harddisk_StockControlEvent;

            Product gsm = new Product(50);
            gsm.ProductName = "Iphone";
            gsm.StockControlEvent += Gsm_StockControlEvent;  // event bu şeklide newlenir += ve tab


            for (int i = 0; i < 10; i++) 
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Harddisk_StockControlEvent()
        {
            Console.WriteLine("Hard disk about to finish!");
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("GSM about to finish!");
        }
    }

}
