using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.Entities
{
    public class Book
    {
        [key]
        public int BookID { get; set; }
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public decimal Price { get; set; }
     
       
    }
}
