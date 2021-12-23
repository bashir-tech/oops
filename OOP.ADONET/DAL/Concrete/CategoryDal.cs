using OOP.ADONET.DAL.Abstract;
using OOP.ADONET.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace OOP.ADONET.DAL.Concrete
{
    public class CategoryDal : ICategorydal
    {
        public void Add(Category Entity)
        {
            var cmd = new SqlCommand("INSERT INTO Categories(CategoryName,Description)VALUES(@CategoryName,@Description)");

            cmd.Parameters.AddWithValue("CategoryName", Entity.CategoryName);
            cmd.Parameters.AddWithValue("Description", Entity.Description);
        
            var s = RDMS.SqlNonQuery(cmd);
            Console.WriteLine(s);
        }

        public void Delete(Category Entity)
        {

            //comand
            var cmd = new SqlCommand(" DELETE FROM Categories  WHERE  CategoryID=@CategoryID");
            

            cmd.Parameters.AddWithValue("categoryID", Entity.CategoryID);
            var s = RDMS.SqlNonQuery(cmd);
            Console.WriteLine(s) ;


        }

        public List<Category> GetAll()
        {

            var _list = new List<Category>();


            // SQL COmmand
            var cmd = new SqlCommand("select  CategoryID, CategoryName, Description from Categories");
            //sql data reader

            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(new Category()
                {
                    CategoryID = int.Parse(item[0].ToString()),
                    CategoryName = item[1].ToString(),
                    Description = item[2].ToString()



                });
            }
            return _list;
        }

        public void Update(Category Entity)
        {
            var cmd = new SqlCommand(" UPDATE Categories SET CategoryName=@CategoryName, Description=@Description WHERE  CategoryID=@CategoryID");


            cmd.Parameters.AddWithValue("CategoryID", Entity.CategoryID);
            cmd.Parameters.AddWithValue("CategoryName", Entity.CategoryName);
            cmd.Parameters.AddWithValue("Description", Entity.Description);

            RDMS.SqlNonQuery(cmd);
        }
    }
}