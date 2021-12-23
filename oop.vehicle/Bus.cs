using System;
using System.Collections.Generic;
using System.Text;

namespace oop.vehicle
{
    class Bus : vehicle
    {
        public Bus()
        {
        }

        public Bus(string engine, string model, int transimision, int price, int numberofwheels) : base(engine, model, transimision, price, numberofwheels)
        {


        }

    }
}