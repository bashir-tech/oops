using System;
using System.Collections.Generic;
using System.Text;

namespace İnheritenceResultModel
{
   public class successed : Result
    {
        public successed() : base(true,"successed")
        {
        }

        public successed(string massage) : base(true,massage)
        {
        }
    }
}
