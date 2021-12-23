using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP.İnterface.GetEnumerate.APP
{

    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<Product>()
            {
                new Product(){ProducyİD=123,ProductName="Buzldolab",Price=1290},
       new Product(){ProducyİD=134,ProductName="ocak",Price=8000},
       new Product(){ProducyİD=346,ProductName="firin",Price=10000}


            };
            foreach (var product in collection)
            {
                Console.WriteLine($" {product.ProducyİD}" +
                    $" {product.ProductName} " +
                    $" {product.Price} ");
            }
            Console.WriteLine(new string('_',25));

            IEnumerator<Product> enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"{enumerator.Current.ProducyİD} " +
                    $"{enumerator.Current.ProductName} " +
                    $"{enumerator.Current.Price}");

            }
            Console.ReadKey();

        }
    
    }
}
