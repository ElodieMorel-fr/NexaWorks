using Microsoft.EntityFrameworkCore;
using NexaWorks.Models.Entities;
using OperatingSystem = NexaWorks.Models.Entities.OperatingSystem;

namespace NexaWorks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductVersion> ProductVersions { get; set; }

        public DbSet<Compatibility> Compatibilities { get; set; }

        public DbSet<OperatingSystem> OperatingSystems { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Status> Statuses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Compatibility>().HasKey(c => new { c.ProductVersionId, c.OSId });

            modelBuilder.Entity<OperatingSystem>().HasKey(o => o.OSId);
        }

    }
}
