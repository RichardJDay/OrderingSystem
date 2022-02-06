using Microsoft.EntityFrameworkCore;
using OrderingSystem.Controllers;
using OrderingSystem.Models;

namespace Database
{
    public class OrderingSystemDbContext : DbContext
    {
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<OrderItem>? OrderItem { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=OrderingSystem;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>()
            .HasOne(p => p.ProductId);      
            
            

        }
    }
}