using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
  public  class empolyee

    {
        public empolyee()
        {

        }
        public empolyee(int iD)
        {
            ID = iD;
        }

        public empolyee(int iD, string fırstname, string lastname, int age)
        {
            this.ID = iD;
           this. Fırstname = fırstname;
            this.lastname = lastname;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{ID,-20}" + $"{Fırstname,15}" + $"{lastname,15}" + $"{age,15}";
        }

        public int ID { get; set; }
        public string Fırstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        

        
    }

}
