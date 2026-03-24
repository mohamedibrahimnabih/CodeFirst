using CodeFirst.DataAccess.EntityTypeConfigurations;
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CodeFirst.DataAccess
{
    internal class ApplicationDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CodeFirst528;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.HasDefaultSchema("production");
            //new ProductEntityTypeConfiguration().Configure(modelBuilder.Entity<Product>());
            //new CategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<Category>());
            //new OrderEntityTypeConfiguration().Configure(modelBuilder.Entity<Order>());

            //modelBuilder.HasDefaultSchema("authentication");
            //new UserEntityTypeConfiguration().Configure(modelBuilder.Entity<User>());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryEntityTypeConfiguration).Assembly);
        }
    }
}
