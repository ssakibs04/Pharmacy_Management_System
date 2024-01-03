using DAL.Models.Entities;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AppDBContext : DbContext
    {
        public DbSet<Staff> Pharmacists { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<Stock> Stocks{ get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Discount> Discounts { get; set; }
    }
}
