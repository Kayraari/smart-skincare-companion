using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccess;

namespace SengWeb.Data
{
   
    public class SengWebContext : DbContext
    {
        public SengWebContext (DbContextOptions<SengWebContext> options)
            : base(options)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PRODUCT>().HasOne(p => p.SUNSCREEN).WithOne(m => m.PRODUCT).HasForeignKey<SUNSCREEN>(m => m.ID).IsRequired();
            modelBuilder.Entity<PRODUCT>().HasOne(p => p.CLEANSER).WithOne(m => m.PRODUCT).HasForeignKey<CLEANSER>(m => m.ID).IsRequired();
            modelBuilder.Entity<PRODUCT>().HasOne(p => p.MOISTURIZER).WithOne(m => m.PRODUCT).HasForeignKey<MOISTURIZER>(m=>m.ID).IsRequired();

            modelBuilder.Entity<OWNERSHIP>().HasKey(p => new { p.UserID, p.ProductID });

            modelBuilder.Entity<PROGRESSRECORD>().HasKey(p=> new { p.UserID, p.LogID });

            modelBuilder.Entity<ROUTINESTEP>().HasKey(p => new { p.RoutineID, p.ProductID });
        }

        public DbSet<DataAccess.PRODUCT> PRODUCT { get; set; } = default!;
        public DbSet<DataAccess.MOISTURIZER> MOISTURIZER { get; set; } = default!;
        
    }
}
