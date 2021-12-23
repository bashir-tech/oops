using OOP.ADONET.DAL.Abstract;
using OOP.ADONET.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OOP.ADONET.DAL.Concrete
{
    public class ProductDal : IProductDal
    {
        public void Add(Product Entity)
        {
            var cmd = new SqlCommand("INSERT INTO Products(ProductName,UnitPrice,UnitsInStock)VALUES(@ProductName,@UnitPrice,@UnitsInStock)");

            cmd.Parameters.AddWithValue("ProductName", Entity.ProductName);
            cmd.Parameters.AddWithValue("UnitPrice", Entity.UnitPrice);
            cmd.Parameters.AddWithValue("UnitsInStock", Entity.UnitsInStock);
            var s = RDMS.SqlNonQuery(cmd);
            Console.WriteLine(s);
        }

        public void Delete(Product Entity)
        {
            //comand
            var cmd = new SqlCommand(" DELETE FROM Product  WHERE  ProductId=@ProductId");


            cmd.Parameters.AddWithValue("EmployeeID", Entity.ProductId);
            var s = RDMS.SqlNonQuery(cmd); throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            var _list = new List<Product>();


            // SQL COmmand
            var cmd = new SqlCommand("select ProductId, ProductName, UnitPrice, UnitsInStock from Products");
            //sql data reader

            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(new Product()
                {
                    ProductId = int.Parse(item[0].ToString()),
                    ProductName = item[1].ToString(),
                    UnitPrice = decimal.Parse(item[2].ToString()),


                    UnitsInStock = int.Parse(item[3].ToString())



                });
            }
            return _list;
        }

        public void Update(Product Entity)
        { 
            var cmd = new SqlCommand(" UPDATE Products SET ProductName=@ProductName, UnitPrice=@UnitPrice, UnitsInStock=@UnitsInStock WHERE  ProductId=@ProductId");


            cmd.Parameters.AddWithValue("ProductId", Entity.ProductId);
            cmd.Parameters.AddWithValue("ProductName", Entity.ProductName);
            cmd.Parameters.AddWithValue("UnitPrice", Entity.UnitPrice);
            cmd.Parameters.AddWithValue("UnitsInStock", Entity.UnitsInStock);

            RDMS.SqlNonQuery(cmd);
        }
    }

}
