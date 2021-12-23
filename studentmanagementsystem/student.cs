using System;
using System.Collections.Generic;
using System.Text;

namespace studentmanagementsystem
{
    class student
    {

        List<student> _list = new List<student>();



        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        private string fullname;

        public string Getfullname()
        {
            return $"{FirstName,-15} " + $" {LastName,-15} ";
        }


        public student()
        {

        }

        public student(int id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Id,-15} " + $"{Getfullname(),-15}" + $"{Email,-15}"; 
        }




        public List<student> studentmanager()
        {
            return _list;

        }

        public void add(student students)
        {
            _list.Add(students);

        }
        public void AddRange(params student[] students)
        {
            _list.AddRange(students);


        }


        public void Remove(student students)
        {
            _list.Remove(students);
        }

        // _list.Add(students);


        //public void AddRange(params student[] students)
        // {


        //_list.AddRange(students);
        // }



    }


    }
