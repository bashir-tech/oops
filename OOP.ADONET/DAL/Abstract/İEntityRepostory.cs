using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.ADONET.DAL.Abstract
{
    public interface İEntityRepostory<T>
        where T : class, new()
    {
        void Add(T Entity);
        void Update(T Entity);
        List<T> GetAll();
        void Delete(T Entity);

    }

}
