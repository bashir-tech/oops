using OOP.Generic.Repository.Design.Pattern.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generic.Repository.Design.Pattern.DAL.Abstract
{
    public interface İEntityRepostory<T> 
        where T: class,İEntity,new()

    {


        //CRUD
        void Create(T entity);  // create
        List<T> GetAll(); //Read

      
        void apdate(T entity); // update
        void Delate(int entity);// delate

    }
}
