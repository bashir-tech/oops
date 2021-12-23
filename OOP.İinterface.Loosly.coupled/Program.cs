using System;

namespace OOP.İinterface.Loosly.coupled
{

    class Program
    {
        


        static void Main(string[] args)
        {
            var stack = new Stack(new ArrayStack());
            stack.Push(5);
            stack.Pop();

        }
    }
}
