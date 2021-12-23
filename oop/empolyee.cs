using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class empolyee
    {
        private string _firstname;
        private string _lastname;

        private List<empolyee> _list = new List<empolyee>();

        public string Firstname
        {
            set
            {
                _firstname = value;


            }
            get
            {
                {
                    return _firstname;


                }
            }

        }

        public string Lastname {
            //expression-bodied property accessors
            get => _lastname;
            set => _lastname = value;
        }

        // auto implemented property
        public int age { get; set; }

        public empolyee()
        {

        }
        // overloading
        public empolyee(string firstname, string lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            this.age = age;
        }


        public override string ToString()
        {
            return $"{Firstname,-20} {Lastname,15}  {age,15}";
        }

        public void add(empolyee empolyee)
        {
            _list.Add(empolyee);

        }
        public void AddRange(params empolyee[] empolyees)
        {
            _list.AddRange(empolyees);
        }
        
        public List<empolyee> GetEmpolyees()
        {
            return _list;

        }

        public void Remove(empolyee empolyee)
        {
            _list.Remove(empolyee);
        }


    }
}
