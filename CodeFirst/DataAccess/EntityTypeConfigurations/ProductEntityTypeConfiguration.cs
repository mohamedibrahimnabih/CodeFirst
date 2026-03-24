using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.DataAccess.EntityTypeConfigurations
{
    internal class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Price)
                .HasPrecision(10, 2);

            builder.Property(e => e.Description)
                .IsRequired(false);

            builder.Property(e => e.Name)
                .HasColumnName("name")
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.CreateAt)
               .HasColumnOrder(1);

            builder.Property(e => e._Id)
                .HasColumnOrder(0);

            builder.ToTable("products");
            builder.HasKey(e => e._Id);
        }
    }
}
