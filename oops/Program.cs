using System;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new empolyee[] { 
                new empolyee { ID = 1, Fırstname = "bashır", lastname = "isse", age = 25 },
                new empolyee { ID = 2, Fırstname = "ahmed", lastname = "isse", age = 15 },
                new empolyee { ID = 3, Fırstname = "alı", lastname = "farah", age = 18 },
                new empolyee { ID = 4, Fırstname = "xalımo", lastname = "mohamed", age = 29 },
                new empolyee { ID = 5, Fırstname = "hassan", lastname = "gedi", age = 30 },
                new empolyee { ID = 6, Fırstname = "abshır", lastname = "isse", age = 17 },
                new empolyee { ID = 7, Fırstname = "xamdı", lastname = "kalıf", age = 25 }


        };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
