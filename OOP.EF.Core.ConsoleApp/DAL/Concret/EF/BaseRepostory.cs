using Microsoft.EntityFrameworkCore;
using OOP.EF.Core.ConsoleApp.DAL.Abstract;
using OOP.EF.Core.ConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EF.Core.ConsoleApp.DAL.Concret.EF
{
    public class BaseRepostory<T> : IEntityRepostory<T> where T : class, new()
       
    {
        public void Add(T Entity)
        {
            using (var _context=new BookAppDbContext())
            {
                _context.Entry(Entity).State = EntityState.Added;
               
                _context.SaveChanges();
              


            }
        }

        public void Delete(T Entity)
        {
            using (var _context = new BookAppDbContext())
            {
                _context.Entry(Entity).State = EntityState.Deleted;
                _context.SaveChanges();

            }
        }

        public List<T> GetAll()
        {
            using (var _context = new BookAppDbContext())
            {
                return _context.Set<T>().ToList();

            }
         
        }

        public void Update(T Entity)
        {
            using (var _context = new BookAppDbContext())
            {
                _context.Entry(Entity).State = EntityState.Modified;
                _context.SaveChanges();

            }
        }
    }
}
