using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class MyContext:DbContext
    {
       public MyContext(DbContextOptions<MyContext>options):base(options)
        {

        }

       public DbSet<Product> products { get; set; }
       public  DbSet<ProductBrand> brands { get; set; }
       public DbSet<BroductType> types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
