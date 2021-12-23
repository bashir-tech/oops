using System;
using System.Collections.Generic;

namespace oop
{

    class Program
    {
        static void Main(string[] args)
        {
            var empolyee = new empolyee();
        
            empolyee.add(new empolyee("bashir", "ali", 20));
            empolyee.Remove(empolyee);
            empolyee.AddRange(
                new empolyee( "ali","isse",40),
                 new empolyee("khalif", "isse", 55),
                  new empolyee("mahdi", "isse", 30),
                 new empolyee("mohamed", "isse", 70)

                );
            var list = empolyee.GetEmpolyees();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
