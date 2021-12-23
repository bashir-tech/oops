using LinqAppSample.Dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace LinqAppSample
{



    public class Program
    {
        static void Main(string[] args)
        {
            var l1 = new List<int> { 1,3, 3, 5, 7,6, 9, 10 };
            var l2 = new List<int> { 2, 4, 4, 6, 7, 9, 10 };
            var l3 = l1.Intersect(l2);
           
            foreach (var item in l3)
            {
                Console.WriteLine(item);

            }
        }

        private static void selectclause()
        {
            var context = new NorthwindContext();
            var query = from p in context.Products
                        where (p.UnitPrice > 50 && p.UnitsInStock > 20 && p.UnitsInStock < 50)
                        orderby p.ProductName
                        select new Product()
                        {
                            ProductId = p.ProductId,
                            ProductName = p.ProductName,
                            UnitPrice = p.UnitPrice,
                            UnitsInStock = p.UnitsInStock
                        };
            var method = context.Products

                .Where(p => p.ProductName.Contains("rt"))
                .OrderBy(p => p.ProductName)
                .Take(5)
                .Select(p => new Product()
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock

                });
            foreach (var item in method)
            {
                Console.WriteLine($"{item.ProductId,-5}" +
                    $"{item.ProductName,-40}" +
                    $"{item.UnitPrice,-15}" +
                    $"{item.UnitsInStock,-15}");

            }
        }

        private static void offtype()
        {
            var list = new ArrayList()
            {
                1,2,3,4,5,6,7,8,9,
                "bashir","isse", "mohamed",
                "farah",
                "ahmed",
                true,false,
                DateTime.Now,
                DateTime.Now.AddDays(3),
                DateTime.Now.AddMonths(5)

            };
            //var filtered = list.OfType<int>();
            var filteredData = GenerateList<int>(list);
            foreach (var item in filteredData)
            {
                Console.WriteLine(item);

            }
        }

        private static List<T> GenerateList<T>(IEnumerable arr)
        {
            var list = new List<T>();
            foreach (var item in arr)
            {
                if (item is T)
                
                    list.Add((T)item);

               

            }
            return list;
        }

        private static void predicate()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Func<int, bool> predicate = i => i > 6;

            var filtered = list.Where(predicate);
            foreach (var item in filtered)
            {
                Console.WriteLine(item);

            }
        }

        private static bool checknumber(int number)
        {
            if (number > 6)
            
                return true;
            


                return false;
        }

        private static void selectclauses()
        {
            var context = new NorthwindContext();
            //query syntax
            var query = from em in context.Employees

                        select new Employee
                        {
                            EmployeeId = em.EmployeeId,
                            FirstName = em.FirstName,
                            LastName = em.LastName
                        };
            // method syntax
            var method = context.Employees
               .Select(em => new
               {
                   id = em.EmployeeId,
                   fullname = em.FirstName
                    + " " + em.LastName
               });
            foreach (var item in method)
            {
                Console.WriteLine(item);

            }


            //foreach (var item in method)
            //{
            //    Console.WriteLine($"{item.EmployeeId,-30}" +
            //        $"{item.FirstName,-25}" +
            //        $"{item.LastName,-15}");

            //}
        }

        private static void syntaxes()
        {
            var list = new List<string>()
            {
                "ahmed","bashir",
                "farah","halımo","hamdi","hadio",
                "sadio"
            };
            //query syntax
            var quey = from name in list
                       where name.Contains("ha")
                       select name;
            // method syntax
            var method = list.Select(name => name);
            // mix syntax
            var mix = (from name in list
                       select name)
                    .Where(name => name.Contains("ha"))
                    .OrderBy(name => name);

            foreach (var item in method)
            {
                Console.WriteLine(item);

            }
        }

        private static void overview()
        {
            //(1) datasource
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            // query creation 
            var query = from n in numbers
                        where (n % 2 == 1)
                        orderby n descending

                        select n;
            foreach (var item in query)
            {
                Console.WriteLine(item);

            }
        }
       
    }

}
