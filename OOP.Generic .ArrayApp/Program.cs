using System;
using System.Collections.Generic;

namespace OOP.Generic_.ArrayApp
{

    class Program
    {

        static void Main(string[] args)
        {
            var list = new Stack<book>();

            list.Push(new book(1, "Goal", "Eat Frog"));
            list.Push(new book(2, "hadef", "Eat first frog"));
            list.Push(new book(3, "amaj", "Eat second frog"));
            list.Push(new book(4, "future", "Eat ugliest frog"));
            list.Push(new book(5, "mustaqbal", "Eat easiest frog"));


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        private static void array1()
        {
            var array1 = new Array<Book>(
                new Book(1, "sefeller", 90),
                 new Book(2, "suç veceza", 50),
                  new Book(3, "devlet", 45)

                );
            var array2 = new Array<Company>(

                new Company() { İD = 1, name = "aselan", Country = "turkey" },
                   new Company() { İD = 2, name = "saski", Country = "turkey" },
                      new Company() { İD = 3, name = "calibiyoli", Country = "galkio" }
                );
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------");
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
        }

        private static void generic_struct()
        {
            var stack = new Stack<Company>();
            stack.Push(new Company() { İD = 1, name = "yepas", Country = "turkey" });
            stack.Push(new Company() { İD = 2, name = "samgaz", Country = "turkey" });
            stack.Push(new Company() { İD = 3, name = "saski", Country = "turkey" });
            stack.Push(new Company() { İD = 5, name = "bim", Country = "turkey" });
            stack.Push(new Company() { İD = 7, name = "somexpress", Country = "somalia" });

            Console.WriteLine(stack.Peek().name);
        }

        private static void generic_and_class()
        {
            var list = new LinkedList<Book>();
            list.AddFirst(new Book(1, "seffiler", 30));
            list.AddFirst(new Book(2, "qaab iyo qurux", 25));
            list.AddFirst(new Book(3, "somai history", 40));
            list.AddFirst(new Book(4, "suç ve ceza", 50));


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void genericDefinition()
        {
            var arr = new Array<char>('a', 'e');
            foreach (var item in arr)
            {
                Console.WriteLine(item);

            }
        }
    }
}
