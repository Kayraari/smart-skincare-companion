using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccess;

namespace SengWeb.Data
{
   
 class SengWebContext : DbContext
    {
        public SengWebContext(DbContextOptions<SengWebContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // OWNERSHIP has ID as primary key (identity), not composite key
            modelBuilder.Entity<OWNERSHIP>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                // Add unique constraint for UserID and ProductID if business logic requires it
                // entity.HasIndex(e => new { e.UserID, e.ProductID }).IsUnique();
            });

            // PROGRESSRECORD has LogID as primary key (identity), not composite key
            modelBuilder.Entity<PROGRESSRECORD>(entity =>
            {
                entity.HasKey(e => e.LogID);
                entity.Property(e => e.LogID).ValueGeneratedOnAdd();
            });

            // ROUTINESTEP has ID as primary key (identity), not composite key
            modelBuilder.Entity<ROUTINESTEP>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });
        }

        public DbSet<DataAccess.PRODUCT> PRODUCT { get; set; } = default!;

        public DbSet<DataAccess.OWNERSHIP> OWNERSHIP { get; set; } = default!;

        public DbSet<DataAccess.User> User { get; set; } = default!;
   
public DbSet<DataAccess.ROUTINE> ROUTINE { get; set; } = default!;

        public DbSet<DataAccess.ROUTINESTEP> ROUTINESTEP { get; set; } = default!;

    }
}
