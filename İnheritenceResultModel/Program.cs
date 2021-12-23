using System;

namespace İnheritenceResultModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var RS = new Resultsets();
            var r1 = RS.action01();
            Console.WriteLine(r1.Massage);
            Console.WriteLine(r1.States);

            var r2 = RS.action02();
            Console.WriteLine(r2.Massage);
            Console.WriteLine(r2.States);

            var r3 = RS.action03();
            Console.WriteLine(r3.Massage);
            Console.WriteLine(r3.States);
            var r4 = RS.action04();
            Console.WriteLine(r4.Massage);
            Console.WriteLine(r4.States);




            Console.WriteLine("Hello World!");
        }
    }
}
