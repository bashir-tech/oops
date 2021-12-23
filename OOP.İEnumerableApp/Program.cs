using System;

namespace OOP.İEnumerableApp
{

    class Program
    {
        static void Main(string[] args)
        {
            //define  a custom array
            var arr = new Array(1,4,7);

            var customarr = new int[] { 1, 2, 3 };
            foreach (var item in customarr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("________");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
