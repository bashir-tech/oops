using System;
using System.Collections.Generic;
using System.Text;

namespace oops.inheritence
{
    public class rectangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("rectangle drawing task..");
           // base.draw();
        }
        public void calculate()
        {
            Console.WriteLine("calculated by rectangle:");
        }
    }
}
