using System;

namespace OOP.Generic.methods
{
    class Program
    {
       public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            //int a = 2, b = 3;
            //Console.WriteLine($"a={a} b={b}");
            //Swap<int>(ref a, ref b);
            //Console.WriteLine($"a={a} b={b}");
            //Console.WriteLine(new string('=',100));

            //char c1 = 'A', c2 = 'B';
            //Console.WriteLine($"c1={c1} c2={c2}");
            //Swap<char>(ref c1,ref c2);
            //Console.WriteLine($"c1={c1} c2={c2}");
            //Console.WriteLine(new string('=', 100));

            //string n1 = "ahmed", n2 = "mohamed";
            //Console.WriteLine($"n1={n1} n2={n2}");
            //Swap<string>(ref n1, ref n2);

            int a = 10, b = 20;
            Console.WriteLine($"a={a},b={b}");
            Spap<int >(ref a, ref b );
            Console.WriteLine($"a={a},b={b}");
        }
        public static void Spap<T>(ref T c, ref T d)
        {
            T temp = c;
            c = d;
            d = temp;
        }

    }
}
