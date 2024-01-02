using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class AppDBContext : DbContext
    {
        public DbSet<Pharmacist> Pharmacists { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<Sale> Sales { get; set; }
    }
}
