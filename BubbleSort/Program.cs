using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {






        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
            {
                temp = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
        }
    }
    Console.WriteLine("Sorted:");
            foreach (var item in arr)
            {
                Console.WriteLine( item + " ");

            }
        }
    }
}
