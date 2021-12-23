using _11.hafta.Dal;
using _11.hafta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.hafta
{
    class Program
    {
        static void Main(string[] args)
        { 

          
      
            using (var _context=new pubsDbContext())
            {
                _context.Set<Publisher>().ToList();

                var _list = new List<Publisher>();
                _list.ForEach(e => Console.WriteLine(e.pub_id+ e.pub_name));
            }
        }
    }
}
