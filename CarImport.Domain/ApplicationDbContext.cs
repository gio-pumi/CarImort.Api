using CarImport.Domain.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Domain
{
    public class ApplicationDbContext : DbContext
    {

      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
       {

       }

        public virtual DbSet<Customer>  Customers { get; set; }
        public virtual DbSet<Order>  Orders { get; set; }

    }
}
