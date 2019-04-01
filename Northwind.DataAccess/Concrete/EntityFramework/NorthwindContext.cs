using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("NorthwindContext")
        {

        }

        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Categorie { get; set; }
        
    }
}
