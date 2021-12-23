using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace oop.AbstractClassMethodApp
{
    public abstract class Heap
    {
        // field
        protected SortedSet<char> _list;
        public Heap()
        {
            _list = new SortedSet<char>();

        }
        public void insert(char item)
        {
            _list.Add(item);
        }
        //abstract method
        public abstract char  Extract();

      
        
    }
}
