using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EF.Core.ConsoleApp.Entity
{
    public  class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
       
        public decimal Price { get; set; }
        // foriegn key
        public int? CategoryId { get; set; }
        //simple navigation property
        public Category Category { get; set; }
        //simple navigation property
        public BookDetail BookDetail { get; set; }

        public ICollection<BookAuthor> bookAuthors { get; set; }
      


    }
}
