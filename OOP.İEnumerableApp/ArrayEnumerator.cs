using System.Collections;

namespace OOP.İEnumerableApp
{
    internal class ArrayEnumerator : IEnumerator

    {
        private int[] İnnerList;
        private int index;

        public object Current => İnnerList[index];
        public ArrayEnumerator(int[] arr)
        {

            İnnerList = arr;
            // index = -1;
            index = İnnerList.Length;

        }
        public bool MoveNext()
        {
            if (index==İnnerList.Length)
            {
          
                
                // index==-1
                //index++;
                index--;
                return true;
            }
            if (index>=0)
            {
                // index< innerlist.length-1
                //index++;
                index--;
                return true;
            }
            else
            {
                // index = -1;
                index = İnnerList.Length;
                return false;
            }
        }

        public void Reset()
        {
            //index=-1;
            index = İnnerList.Length;        }
    }
}