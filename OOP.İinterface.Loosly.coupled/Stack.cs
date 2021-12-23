using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.İinterface.Loosly.coupled
{
    public class Stack : İStack
    {
        private readonly İStack _stack;

        public Stack(İStack stack)
        {
            _stack = stack;
        }

        public void Pop()
        {
            _stack.Pop();
        }

        public void Push(int item)
        {
            _stack.Push(5);
        }
    }
}
