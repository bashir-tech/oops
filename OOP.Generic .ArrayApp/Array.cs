using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOP.Generic_.ArrayApp
{
  public class array<T>:IEnumerable
    {
        private T[] innerlist;
        private int index;
        public array(int size=16)
        {
            innerlist = new T[16];
            index = 0;
        }
        public array(params T[] collections)
        {
            innerlist = new T[collections.Length];
            index = 0;
            foreach (var item in collections)
            {
                innerlist[index] = item;
                index++;
            }

        }

        public IEnumerator GetEnumerator()
        {
            return innerlist.Take(index).GetEnumerator();
        }
    }
    public class book
    {
        public book(int iD, string name, string title)
        {
            ID = iD;
            Name = name;
            Title = title;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"{ID,-25}" +
                $"{Name,-20}" +
                $"{Title,-15}";
        }
    }

    public class Array<T>:IEnumerable where T:new()


    {
        private T[] innerlist;
        private int index;
        public Array( int size =16)
        {
            innerlist = new T[16];
            index = 0;


        }
        public Array(params T[] collection)
        {
            innerlist = new T[collection.Length];
            index = 0;

            foreach (var item in collection)
            {
                innerlist[index] = item;
                index++;


            }

        }

        public IEnumerator GetEnumerator()
        {
            return innerlist.Take(index).GetEnumerator();
        }
    }


}
