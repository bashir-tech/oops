using System;

namespace oop.AbstractClassMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[] {'e','g','r','y'};
            var minheap = new Minheap();
            var maxheap = new Maxheap();
            foreach (var item in arr)
            {
                minheap.insert(item);
                maxheap.insert(item);
                


            }
            Console.WriteLine(minheap.Extract());
            Console.WriteLine(maxheap.Extract());


        }
    }
}
