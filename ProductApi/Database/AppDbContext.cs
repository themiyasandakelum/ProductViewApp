using Microsoft.EntityFrameworkCore;
using ProductApi.Models;
using static Azure.Core.HttpHeader;

namespace ProductApi.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                ProductName = "apple",
                SKU = "abcd123",
                RetailPrice = 20,
                SalePrice = 30,
                LowestPrice = 50,
                Status=1,
                CreatedDate = DateTime.Now,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {

                ProductId = 2,
                ProductName = "samsung",
                SKU = "abcd124",
                RetailPrice = 20,
                SalePrice = 30,
                LowestPrice = 50,
                Status = 1,
                CreatedDate = DateTime.Now,
            });
        }
    }
}
