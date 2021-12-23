using Microsoft.EntityFrameworkCore;
using OOP.EF.Core.ConsoleApp.DAL.Mapping;
using OOP.EF.Core.ConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EF.Core.ConsoleApp.DAL.Abstract
{
    public class BookAppDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category>Categories{ get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=BookAppDb;");
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new bookMap());
            modelBuilder.ApplyConfiguration(new Categorymap());
            modelBuilder.ApplyConfiguration(new BookDetailMap());
            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new BookAuthorMap());
          
        }
       
    }
}
