using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EF.Core.ConsoleApp.Entity;

namespace OOP.EF.Core.ConsoleApp.DAL.Mapping
{
    public class Categorymap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.categoryName)
                .HasMaxLength(250)
                .IsRequired();
            builder.HasData(

                new Category() { CategoryId = 1, categoryName = "lenovo",description="laptop" },
                new Category() { CategoryId = 2, categoryName = "HP",description="Monitor" },
                new Category() { CategoryId = 3, categoryName = "Dell",description="desktop" });

        }
    }
}
