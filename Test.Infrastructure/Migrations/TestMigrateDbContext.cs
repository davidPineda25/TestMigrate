namespace Test.Infrastructure.Migrations;

using Microsoft.EntityFrameworkCore;
using Test.Domain.Entities;

    public class TestMigrateDbContext: DbContext
    {
        public TestMigrateDbContext(DbContextOptions<TestMigrateDbContext> options)
            :base (options)
        {

        }
    
        public DbSet<Category> Category {get; set;}
        public DbSet<Comment> Comment {get; set;}
        public DbSet<Customer> Customer {get; set;}
        public DbSet<DetailOrder> DetailOrder {get; set;}
        public DbSet<Order> Order {get; set;}
        public DbSet<Product> Product {get; set;}
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailOrder>()
            .Property(d => d.UnitPrice)
            .HasColumnType("decimal(18,2)");

             modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");
        }

    
}
    


