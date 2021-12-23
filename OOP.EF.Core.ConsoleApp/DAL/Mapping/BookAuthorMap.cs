using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EF.Core.ConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EF.Core.ConsoleApp.DAL.Mapping
{
    public class BookAuthorMap : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(ba => ba.BookauthorId);

            builder.HasOne(ba => ba.Book)
                .WithMany(b => b.bookAuthors)
                .HasForeignKey(ba => ba.BookId);

            builder.HasOne(ba => ba.Author)
                .WithMany(a => a.bookAuthors)
                .HasForeignKey(ba => ba.AuthorId);
            

        }
    }
}
