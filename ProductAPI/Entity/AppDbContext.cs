using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;

namespace ProductAPI.Entity
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<ProductDetailPropertyDetails> ProductDetailPropertyDetails { get; set; }
        public virtual DbSet<Properties> Properties { get; set; }   
        public virtual DbSet<PropertyDetails> PropertyDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server = DESKTOP-QP94QQG; Database = ProductManager; Trusted_Connection = True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDetailPropertyDetails>()
                .HasMany(x => x.ProductDetailId);
                
        }


    }
}
