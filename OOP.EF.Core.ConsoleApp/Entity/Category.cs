using System.Collections;
using System.Collections.Generic;

namespace OOP.EF.Core.ConsoleApp.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        //collection navigation property
        public ICollection<Book> Books { get; set; }
    }
}
