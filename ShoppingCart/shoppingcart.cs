using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class shoppingcart
    {
        List<CartItem> _list = new List<CartItem>();
        public void Getlist()
        {
            var list = _list;
            foreach (var item in list)
            {
                Console.WriteLine(item.Product.ProductId + "     " +  item.Product.ProductName  + "    " + item.Product.Price );
            }

        }
        public void GetBalance(List<CartItem> list)
        {
            decimal toplam = 0;
            foreach (var item in list)
            {
                toplam += (item.Product.Price * item.Quantity);



            }
            Console.WriteLine("toplam tutar" + toplam);


        }

        public void Add(CartItem item)
        {
            _list.Add(item);

            Console.WriteLine($"{item.Product.ProductId} { item.Product.ProductName,-20} eklendi");

        }

        public void Remove(int index)
        {
            _list.RemoveAt(index);



        }

      
    }
}
