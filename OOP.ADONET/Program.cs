using OOP.ADONET.DAL.Concrete;
using OOP.ADONET.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OOP.ADONET
{

    class Program
    {



        static void Main(string[] args)
        {
            getlistof();
        }

        private static void ADD()
        {
            var category= new Category()
            {
    
                CategoryName = "flour",
                Description= "sprinkle"


            };



            new CategoryDal().Add(category);


        }
        


        private static void getlistof()
        {
            var _categ = new CategoryDal();
            var _list = _categ.GetAll();
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }

        private static void create()
        {
            var category = new Category()
            {
                CategoryName = "past",
                Description = "it made up flour"

            };



            new CategoryDal().Add(category);


        }
        private static void Delete()
        {
            var category = new Category()
            {
                CategoryID = 11,


            };

            new CategoryDal().Delete(category);
   


            Console.ReadKey();
        }

   
        private static void Read()
        {
            new CategoryDal().GetAll().ForEach(e => Console.WriteLine(e));

        }
        private static void Update()
        {
            var category = new Category()
            {
                CategoryID = 14,
                CategoryName = "date",
                Description = "sweet flavor of the dessert"

            };
            new CategoryDal().Update(category);

         

        }
    }



}

    

