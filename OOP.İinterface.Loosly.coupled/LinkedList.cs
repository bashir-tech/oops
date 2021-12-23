using System;

namespace OOP.İinterface.Loosly.coupled
{
    public class LinkedList : İStack
    {
        public void Pop()
        {
            Console.WriteLine("LinkedList.pop");
        }

        public void Push(int item)
        {
            Console.WriteLine("LinkedList.push");
        }
    }
}
