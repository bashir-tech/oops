using System;
using System.Collections.Generic;
using System.Text;

namespace oop.AbstractClassMethodApp
{
   public  class Minheap:Heap

    {

        public override char Extract()
        {
            var item = _list.Min;
            _list.Remove(item);
            return item;

        }
    }
}
