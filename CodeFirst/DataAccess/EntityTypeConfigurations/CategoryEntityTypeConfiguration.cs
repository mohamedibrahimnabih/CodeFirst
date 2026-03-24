using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.DataAccess.EntityTypeConfigurations
{
    internal class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(e => e.Products)
                .WithOne(e => e.Category)
                .HasPrincipalKey(e => e.Id)
                .HasForeignKey(e => e.Category_Id)
                .IsRequired(false);
        }
    }
}
