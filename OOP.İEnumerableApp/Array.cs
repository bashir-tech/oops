using System.Collections;
using System.Linq;

namespace OOP.İEnumerableApp
{
    public class Array:IEnumerable
    {
        private int[] İnnerList { get; set; }
        private int index = 0;
        public Array(int Size=16)
        {
            İnnerList = new int[Size];
        }
        public Array( params int[] initial)
        {
            İnnerList = new int[initial.Length];
            foreach (var item in initial)
            {
                İnnerList[index] = item;
                index++;
            }
                
        }

        public IEnumerator GetEnumerator()
        {
            // return İnnerList.Take(index).GetEnumerator();
            return new ArrayEnumerator(İnnerList);
        }
    }
}