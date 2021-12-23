using System;
using System.Collections.Generic;

namespace OOP.İnterfaceİcomparable_T_App
{
    class Program
    {


        static void Main(string[] args)
        {
            var empolyees = new List<Empolyee>()
           {
               new Empolyee(){İD=9,Fullname="bashir ali isse", Salary=1200},
               new Empolyee(){İD=5,Fullname="ahmed ali farah",Salary=10000},
               new Empolyee(){İD=3,Fullname="halima ali mohemed",Salary=15000}
           };
            empolyees.Sort();
            foreach (var item in empolyees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
