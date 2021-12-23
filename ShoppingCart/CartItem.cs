using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class CartItem
    {
        public int CartId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem()
        {

        }

        public CartItem(int cartId, int quantity,Product product )
        {
            CartId = cartId;
            Product = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{CartId} " + $"{Product} " + $"{Quantity} ";
        }
    }
}
