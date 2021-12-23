using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.ADONET.Entities
{

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{CategoryID,-25}" +
                $"{CategoryName,-20}" +
                $"{Description,-10}";
        }
    }
}
