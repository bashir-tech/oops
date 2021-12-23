using OOP.Generic.Repository.Design.Pattern.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generic.Repository.Design.Pattern.Entities.Concrte

{
    public class Empolyee:İEntity
    {
        public Empolyee()
        {

        }
        public Empolyee(int empolyeeId, string firstName, string LastName)
        {
            EmpolyeeId = empolyeeId;
            FirstName = firstName;
            LastName = LastName;
        }

        public int EmpolyeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}

