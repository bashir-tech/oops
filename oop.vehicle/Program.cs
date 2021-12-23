using System;
using System.Collections.Generic;

namespace oop.vehicle
{
   class Program
    {
        static void Main(string[] args)
        {
            var c1 = new List<vehicle>() 
            {
                new Car("bashır","isse",5,10000,4),
                new Bus("ahmed","isse",5,10000,4),
                new track("ali","isse",5,10000,13)
            
            
            };
            foreach (var cars in c1)
            {
                Console.WriteLine(cars);
                
            }
           
          

            





        }
    }
}
