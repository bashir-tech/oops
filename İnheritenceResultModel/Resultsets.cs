using System;
using System.Collections.Generic;
using System.Text;

namespace İnheritenceResultModel
{
   public class Resultsets : Result
    {
        public Result action01()
        {
            return new successed();
        }
        public Result action02()
        {

            return new successed("işlem basşarli bir şekilde tamaamlandi");
            

        }
        public Result action03()
        {
            return new failed();
        }
        public Result action04()
        {

            return new failed("işlem basşarsiz");


        }


    }
}
