using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product()
            {
                 Id = 1,
                 CategoryId = 1,
                 Name = "Kalem1",
                 Price = 1,
                 Stock = 1,
                 CreatedDate = DateTime.Now
            }, new Product()
            {
                Id=2,
                CategoryId = 2,
                Name = "Silgi1",
                Price= 2,
                Stock = 2,
                CreatedDate= DateTime.Now
            }, new Product()
            {
                Id=3,
                CategoryId = 3,
                Name = "Defter1",
                Price = 3,
                Stock = 3,
                CreatedDate = DateTime.Now
            });
        }
    }
}
