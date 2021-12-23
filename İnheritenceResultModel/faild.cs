using System;
using System.Collections.Generic;
using System.Text;

namespace İnheritenceResultModel
{
    public class failed : Result
    {
        public failed() : base(false, "failed")
        {

        }

        public failed( string msg) : base(false, msg)
        {
        }
    }
}
