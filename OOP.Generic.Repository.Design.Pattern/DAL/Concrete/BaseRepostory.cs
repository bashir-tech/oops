using OOP.Generic.Repository.Design.Pattern.DAL.Abstract;
using OOP.Generic.Repository.Design.Pattern.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generic.Repository.Design.Pattern.DAL.Concrete
{
    public class BaseRepostory<T> : İEntityRepostory<T> 
        where T: class,İEntity,new()
    {
        public void apdate(T entity)
        {
            throw new NotImplementedException();
        }

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delate(int entity)
        {
            throw new NotImplementedException();
        }

        public T Get()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
