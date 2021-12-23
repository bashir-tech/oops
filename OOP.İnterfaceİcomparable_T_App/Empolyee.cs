using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OOP.İnterfaceİcomparable_T_App
{
  public  class Empolyee:IComparable<Empolyee>
    {
        public int İD { get; set; }
        public string Fullname { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo( Empolyee other)
        {
            // return this.İD.CompareTo(other.İD);
            if (this.İD < other.İD)

                return 1;
            else if (this.İD == other.İD)

                return 0;

            else
              return  -1;

            
            
        }

        public override string ToString()
        {
            return $"{İD,-20} " + $"{Fullname,15}" + $"{Salary,10} ";
        }
    }
}
