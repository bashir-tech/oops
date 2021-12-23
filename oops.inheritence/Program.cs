using System;
using System.Collections.Generic;

namespace oops.inheritence
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<shape>()
            {
              new  rectangle(),
              new circle(),
              new triangle(),
              new square()


        };
            foreach (var shape in shapes)
            {
                shape.draw();

            }
           
        }

        private static void virtualkeyword()
        {
            var _s1 = new rectangle();
            var _s2 = new circle();
            _s1.x = 10;
            _s1.y = 100;


            Console.WriteLine("{0},{1}", _s1.x, _s1.y);
            _s1.draw();


            _s2.x = 5;
            _s2.y = 55;
            Console.WriteLine("{0},{1}", _s2.x, _s2.y);
            _s2.draw();

            new triangle().draw();
        }
    }
}
