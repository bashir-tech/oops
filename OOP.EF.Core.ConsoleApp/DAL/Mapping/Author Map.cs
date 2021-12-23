using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EF.Core.ConsoleApp.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EF.Core.ConsoleApp.DAL.Mapping
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorId);
            builder.Property(a => a.FirstName)
                .HasMaxLength(250)
                .IsRequired();
            builder.Property(a => a.LastName)
                .HasMaxLength(250)
                .IsRequired();
            builder.HasData(new Author() { AuthorId = 1, FirstName = "ahmed", LastName = "ali" });


        }


    }
}
