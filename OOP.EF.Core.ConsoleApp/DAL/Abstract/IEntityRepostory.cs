using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EF.Core.ConsoleApp.DAL.Abstract
{
  public  interface IEntityRepostory<T> where T:class, new()
    {
        public void Add(T Entity);
        public void Update(T Entity);
        public void Delete(T Entity);
        public List<T> GetAll();
    }
}
