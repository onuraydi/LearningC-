using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_yapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class student
    {
        public int id { get; set; }
        private string _Firstname;
        public string Firstname
        {
            get { return _Firstname; }
            set { _Firstname = value; }
        }
        private string LastName { get; set; }
        private string city { get; set; }
    }
}
