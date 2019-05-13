using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
   public class NorthwindContext:DbContext
    {
        // veritabanına karşılık gelen context'i hazırladık
        public DbSet<Product> Products { get; set; }
    }
}
