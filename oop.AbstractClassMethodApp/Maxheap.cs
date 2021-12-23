using System;
using System.Collections.Generic;
using System.Text;

namespace oop.AbstractClassMethodApp
{
    public class Maxheap:Heap
    {

        
       
            public override char Extract()
            {
                var item = _list.Max;
                return item;


            }
       
    }
}
