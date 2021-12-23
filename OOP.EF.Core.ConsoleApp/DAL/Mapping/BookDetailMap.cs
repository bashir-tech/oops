using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EF.Core.ConsoleApp.Entity;
using System;

namespace OOP.EF.Core.ConsoleApp.DAL.Mapping
{
    public class BookDetailMap : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(bd => bd.BookDetailId);
            builder.Property(bd => bd.ISSN)
                .IsRequired()
                .HasDefaultValue("0000-0000-0000");
            builder.Property(bd => bd.Year)
                .HasDefaultValue(DateTime.Now.Year);
            builder.Property(bd => bd.City);
            builder.HasOne(bd => bd.Book)
                .WithOne(b => b.BookDetail)
                .HasForeignKey<BookDetail>(bd => bd.BookId);
         
                
        }
    }
}
