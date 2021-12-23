using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {

            shoppingcart shop = new shoppingcart();
            shop.Add(new CartItem(1, 1, new Product(001, "computers", 1)));
            shop.Add(new CartItem(2, 1, new Product(002, "mobile", 1)));
            shop.Add(new CartItem(3, 1, new Product(003, "tv", 1)));
            Console.WriteLine("-------------------------------------");
            shop.Getlist();
           

            Console.WriteLine(  "-----------------------------------------------");
            List<CartItem> Apdate = new List<CartItem>();
            Apdate.Add(new CartItem(1, 1, new Product(01, "lenovo", 10)));
            Apdate.Add(new CartItem(2, 1, new Product(01, "iphone13", 10)));

            Apdate.Add(new CartItem(3, 1, new Product(01, "LG", 10)));
            shop.GetBalance(Apdate);






        }
    }
}
