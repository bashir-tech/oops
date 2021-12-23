
using Microsoft.EntityFrameworkCore;
using OOP.EFCore.DAL;
using OOP.EFCore.Entities;
using System;

namespace OOP.EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book()
            {
                BookID=3,
                Title="marriage ways",
                Price=25
            };
            using (var _context=new BookAppDbContext())
            {
               var s= _context.Entry(book).State = EntityState.Added;
                Console.WriteLine(s);
                _context.SaveChanges();
                
            }
        }
    }
}
