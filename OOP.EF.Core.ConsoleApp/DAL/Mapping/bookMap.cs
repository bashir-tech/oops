using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EF.Core.ConsoleApp.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EF.Core.ConsoleApp.DAL.Mapping
{
    public class bookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);
            
            builder.Property(b => b.Title)
                .HasMaxLength(250)
                .IsRequired();
            builder.Property(b => b.Price);




            builder.HasData(


                new Book() { BookId = 1, Title = "marriage", Price = 25, CategoryId = 3 },
                new Book() { BookId = 2, Title = "History Of Islam", Price = 100, CategoryId = 3 },
                new Book() { BookId = 3, Title = "Goal", Price = 35, CategoryId = 3 });
            builder.HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId);
        }


        }
}
