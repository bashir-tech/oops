using System;
using System.Collections.Generic;
using System.Text;

namespace oop.vehicle
{
    public  class Car : vehicle
    {
        public Car()
        {
        }

        public Car(string engine, string model, int transimision, int price, int Numberofwheels) : base(engine, model, transimision, price, Numberofwheels)
        {

        }
        public int Numberofwheels { get; set; }





    }
}
