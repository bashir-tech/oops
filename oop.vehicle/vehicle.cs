using System;
using System.Collections.Generic;
using System.Text;

namespace oop.vehicle
{
   public  class vehicle
    {

        public string Engine { get; set; }
        public string Model { get; set; }
        public int transimision { get; set; }
        public int Price { get; set; }
        public int Numberofwheels { get; set; }

        public vehicle(string engine, string model, int transimision, int price, int Numberofwheels
            )
        {
            Engine = engine;
            Model = model;
            this.transimision = transimision;
            Price = price;
            Numberofwheels = Numberofwheels;
        }

        public vehicle()
        {
        }

        public override string ToString()
        {
          
            return $"{Engine,-20} " + $"{Model,5} " + $"{Numberofwheels,5} " + $"{transimision,5}" + $"{Price,5} ";
        }


        void Start()
        {

        }
        void Stop()
        {

        }



    }






}
