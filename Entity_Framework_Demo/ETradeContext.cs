using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Demo
{
    //// Bunun entity framework contexti olabilmesi için dbcontext'ten inherite edilmesi gerekir

    public class ETradeContext:DbContext       
    {
        public DbSet<Product> Products { get; set; }

    }
}
