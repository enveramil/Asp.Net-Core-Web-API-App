using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        // Veritabanı yolunu startup dosyasından vereceğimiz için DbContextOptions kullandık.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Her bir entity'e karşılık DbSet tanımlaması yapacağız.

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ProductFeature>().HasData(
                new ProductFeature()
                {
                    Id = 1,
                    Color = "Kırmızı",
                    Height = 100,
                    Width = 100,
                    ProductId = 1,
                },
                new ProductFeature()
                {
                    Id = 2,
                    Color = "Black",
                    Height = 200,
                    Width = 200,
                    ProductId = 2
                }
                
                );
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
