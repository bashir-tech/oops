using _11.hafta.Dal.Mapping;
using _11.hafta.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.hafta.Dal
{
     public class pubsDbContext:DbContext
    {
        public DbSet<Title> Titles { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=pubs;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TitleMap());
            modelBuilder.ApplyConfiguration(new PublisherMap());
        }

    }
}
