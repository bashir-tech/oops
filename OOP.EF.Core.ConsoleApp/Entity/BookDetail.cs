using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EF.Core.ConsoleApp.Entity
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
        //foriegn key
        public int BookId { get; set; }   
        //navigation property
        public Book Book { get; set; }
        public string ISSN { get; set; }
        public string City { get; set; }
        public string country { get; set; }
        public int Year { get; set; }

    }
}
