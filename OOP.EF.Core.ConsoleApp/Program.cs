using OOP.EF.Core.ConsoleApp.DAL.Abstract;
using OOP.EF.Core.ConsoleApp.DAL.Concret.EF;
using OOP.EF.Core.ConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace OOP.EF.Core.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Addbook();

            GetAllBooks();

        }

        private static void deleteCategories()
        {
            var _context = new BookAppDbContext();
            var category = _context.Categories
                .Where(c => c.CategoryId == 3)
            .SingleOrDefault();
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        private static void Update()
        {
            var book = new Book()
            {
                BookId = 1,
                Title = "hadef",
                Price = 40

            };
            new BookDal().Update(book);
            GetAllBooks();
        }

        private static void Addbook()
        {
            var book = new Book()
            {
                Price = 45,
                Title = "amaç",
            };
            new BookDal().Add(book);
            
            
        }

        private static void GetAllBooks()
        {
            new BookDal().GetAll().ForEach(e => Console.WriteLine(e.BookId + " " + e.Title + " " + e.Price));
        }
    }
}
