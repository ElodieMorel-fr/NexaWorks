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

            //Initialisation des statuts
            modelBuilder.Entity<Status>().HasData(new Status { StatusId = 1, Name = "Résolu" });
            modelBuilder.Entity<Status>().HasData(new Status { StatusId = 2, Name = "En cours" });

            //Initialisation des produits
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, Name = "Trader en Herbe" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 2, Name = "Maître des Investissements" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 3, Name = "Planificateur d’Entraînement" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 4, Name = "Planificateur d’Anxiété Sociale" });

            //Initialisation des versions des produits
            //Versions de Trader en Herbe
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 1, ProductId = 1, VersionNumber = "1.0" });
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 2, ProductId = 1, VersionNumber = "1.1" });
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 3, ProductId = 1, VersionNumber = "1.2" });
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 4, ProductId = 1, VersionNumber = "1.3" });
            //Versions de Maitre des Investissement
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 5, ProductId = 2, VersionNumber = "1.0" });
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 6, ProductId = 2, VersionNumber = "2.0" });
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 7, ProductId = 2, VersionNumber = "2.1" });
            //Versions de Planificateur d'Entraînement
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 8, ProductId = 3, VersionNumber = "1.0" });
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 9, ProductId = 3, VersionNumber = "1.1" });
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 10, ProductId = 3, VersionNumber = "2.0" });
            //Versions de Planificateur d'Entraînement
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 11, ProductId = 4, VersionNumber = "1.0" });
            modelBuilder.Entity<ProductVersion>().HasData(new ProductVersion { ProductVersionId = 12, ProductId = 4, VersionNumber = "1.1" });

            //Initialisation des systèmes d'exploitation
            modelBuilder.Entity<OperatingSystem>().HasData(new OperatingSystem { OSId = 1, Name = "Linux" });
            modelBuilder.Entity<OperatingSystem>().HasData(new OperatingSystem { OSId = 2, Name = "MacOS" });
            modelBuilder.Entity<OperatingSystem>().HasData(new OperatingSystem { OSId = 3, Name = "Windows" });
            modelBuilder.Entity<OperatingSystem>().HasData(new OperatingSystem { OSId = 4, Name = "Android" });
            modelBuilder.Entity<OperatingSystem>().HasData(new OperatingSystem { OSId = 5, Name = "iOS" });
            modelBuilder.Entity<OperatingSystem>().HasData(new OperatingSystem { OSId = 6, Name = "Windows Mobile" });
        }

    }
}
