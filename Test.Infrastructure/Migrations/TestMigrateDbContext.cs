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
        public DbSet<DetailOrderCustomer> DetailOrderCustomer {get; set;}
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailOrder>()
            .Property(d => d.UnitPrice)
            .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<DetailOrderCustomer>()
            .HasOne(d => d.Order)
            .WithMany(o => o.DetailOrderClient)
            .HasForeignKey(d => d.IdOrder)
            .OnDelete(DeleteBehavior.NoAction);

            // # Forma de intento en que se intento crear la tabla o entidad de relaciones
            // de muchos a muchos haciendolo dentro del DbContext y no en las entidades

        // modelBuilder.Entity("Test.Domain.DetailOrderCustomer", entity =>
        //         {
        //             entity.ToTable("DetailOrderCustomer");

        //             entity.Property<Guid>("IdDetailOrderClient")
        //             .ValueGeneratedOnAdd();

        //     entity.HasKey("IdDetailOrderClient");

        //     entity.Property<Guid>("IdOrder");
        //     entity.Property<Guid>("IdCustomer");
    
        // entity.HasOne("Test.Domain.Entities","Order")
        // .WithMany("DetailOrderClient")
        // .HasForeignKey("IdOrder")
        // .OnDelete(DeleteBehavior.Cascade);

        //     entity.HasOne("Test.Domain.Entities","Customer")
        //     .WithMany("DetailOrderClient")
        //     .HasForeignKey("IdCustomer")
        //     .OnDelete(DeleteBehavior.Cascade);
        //         });

    }

    
}
    


