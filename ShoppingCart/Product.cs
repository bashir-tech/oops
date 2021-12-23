using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
   public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Product()
        {

        }

        public Product(int productId, string productName, decimal price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ProductId} " + $"{ProductName} " + $"{Price} ";

        }

        }
        }
