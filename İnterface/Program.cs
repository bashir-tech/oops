using System;
using System.Collections.Generic;

namespace İnterface
{



   public  interface İEmpolyee
    {

        public int İD { get; set; }
        public string fullname { get; set; }
        public decimal salary { get; set; }
        public decimal Getsalary()
        {
            Console.WriteLine("get salary has been ....");
            return 0;
        }
        public void Whoyouare(int Id)
        {


        }


    }
    public class Empolyee : İEmpolyee,IComparable, ICloneable
    {
        public int İD { get; set; }
        public string fullname { get; set; }
        public decimal salary { get; set; }

        // deep copy
        //shallow copy

        public object Clone()
        {
            ////deep copy
            //return new Empolyee()
            //{
            //    İD = this.İD,
            //    fullname = this.fullname,
            //    salary = this.salary
            //};

            //shallow

            return this.MemberwiseClone();
           
        }

        
        public override string ToString()
        {  
            return $"{İD,-20} " + $"{fullname,15}" + $"{salary,10} ";
        }

        public int CompareTo(object obj)
        {
            var others = (Empolyee)obj;
            if (this.İD < others.İD)

                return -1;
            else if (this.İD == others.İD)

                return 0;
            else
                return 1;

        }

        private string locatoın;
        private string name;
        public string Location
        {
            get
            {
                return locatoın;
            }
            set
            {
                locatoın = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


    }

   
    class Program
    {
        static void Main(string[] args)
        {

            
         
           var em1 = new Empolyee() {İD=10,fullname="mohamed ahmed",salary=3000};
            var em2 = em1.Clone()as Empolyee;
            em2.İD = 20;
            Console.WriteLine( em1);
            Console.WriteLine(  em2);


        }

        private static void icomparable()
        {
            var empolyee = new List<Empolyee>
            {
                new Empolyee{İD=100,fullname="bashir ali isse",salary=8000},
                 new Empolyee{İD=2,fullname="abdirsak isse egal",salary=10000},
                  new Empolyee{İD=3,fullname="ali isse egal",salary=7000},
                   new Empolyee{İD=4,fullname="khalif isse egal",salary=9000},
                    new Empolyee{İD=5,fullname="mohamed iss eegal",salary=6000}

            };
            empolyee.Sort();
            foreach (var item in empolyee)
            {
                Console.WriteLine(item);
            }
        }
    }

}