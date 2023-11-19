using Microsoft.EntityFrameworkCore;
using Warehouse.Helpers;
using Warehouse.Models;

namespace Warehouse.Database
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext() : base()
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=SLAVIK;Initial Catalog=WarehouseDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId);

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryID);

            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryID);

            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Seed Category
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Laptops", Description = "Portable computers" },
                new Category { CategoryID = 2, Name = "Desktops", Description = "Desktop computers" },
                new Category { CategoryID = 3, Name = "Tablets", Description = "Handheld computers" },
                new Category { CategoryID = 4, Name = "Monitors", Description = "Display screens" },
                new Category { CategoryID = 5, Name = "Printers", Description = "Document printers" },
                new Category { CategoryID = 6, Name = "Storage", Description = "Storage devices" },
                new Category { CategoryID = 7, Name = "Networking", Description = "Networking equipment" },
                new Category { CategoryID = 8, Name = "Accessories", Description = "Computer accessories" },
                new Category { CategoryID = 9, Name = "Software", Description = "Computer software" },
                new Category { CategoryID = 10, Name = "Games", Description = "Computer games" }
            );

            // Seed Product
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Laptop 1", Description = "Description 1", Price = 1000.00m, CategoryID = 1, QuantityInStock = 10 },
                new Product { ProductId = 2, Name = "Laptop 2", Description = "Description 2", Price = 1500.00m, CategoryID = 1, QuantityInStock = 5 },
                new Product { ProductId = 3, Name = "Desktop 1", Description = "Description 3", Price = 1200.00m, CategoryID = 2, QuantityInStock = 7 },
                new Product { ProductId = 4, Name = "Desktop 2", Description = "Description 4", Price = 2000.00m, CategoryID = 2, QuantityInStock = 6 },
                new Product { ProductId = 5, Name = "Tablet 1", Description = "Description 5", Price = 500.00m, CategoryID = 3, QuantityInStock = 15 },
                new Product { ProductId = 6, Name = "Tablet 2", Description = "Description 6", Price = 750.00m, CategoryID = 3, QuantityInStock = 8 },
                new Product { ProductId = 7, Name = "Monitor 1", Description = "Description 7", Price = 300.00m, CategoryID = 4, QuantityInStock = 12 },
                new Product { ProductId = 8, Name = "Printer 1", Description = "Description 8", Price = 200.00m, CategoryID = 5, QuantityInStock = 10 },
                new Product { ProductId = 9, Name = "External Hard Drive", Description = "Description 9", Price = 100.00m, CategoryID = 6, QuantityInStock = 20 },
                new Product { ProductId = 10, Name = "Wireless Router", Description = "Description 10", Price = 150.00m, CategoryID = 7, QuantityInStock = 10 }
            );
        }
    }
}
