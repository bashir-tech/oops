using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.ADONET.Entities
{
  public  class Product

    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return $"{ProductId,-5}" +
                $"{ProductName,-25}" +
                $"{UnitPrice,-15}" +
                $"{UnitsInStock,-10}";
        }
    }
}
