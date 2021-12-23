using System;
using System.Collections.Generic;
using System.Text;

namespace İnheritenceResultModel
{
    public class Result
    {
        public bool States { get; set; }
        public string Massage { get; set; }
        public Result()
        {

        }   
        public Result(bool states, string massage)
        {
            States = states;
            Massage = massage;
        }


       



    }
}
