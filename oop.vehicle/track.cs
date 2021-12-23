using System;
using System.Collections.Generic;
using System.Text;

namespace oop.vehicle
{
    public class track : vehicle
    {


        public track(string engine, string model, int transimision, int price, int Numberofwheels) : base(engine, model, transimision, price, Numberofwheels)
        {

        }
        private int _Numberofwheels;
        public int Numberofwheels
        {
            get
            {
                return Numberofwheels;
            }
            set
            {
                if (Numberofwheels<=12)
                {
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }

    }
}
