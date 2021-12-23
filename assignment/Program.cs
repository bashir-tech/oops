using System;
using System.Collections.Generic;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            int t = 0;
            int[] seri = new int[] { 1,3,4 };
            for (int i = 0; i < seri.Length; i++)
            {
                if (seri[i]%2==0)
                {
                    t += seri[i];
                    Console.WriteLine(t);
                }
                
            }


        }
    }
}
