using OOP.ADONET.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace OOP.ADONET.DAL.Concrete
{
    public class EmployeeDal : IEmployeedal
    {
        public void Add(Empolyee Entity)
        {
            var cmd = new SqlCommand("INSERT INTO Employees(FirstName,LastName)VALUES(@FirstName,@LastName)");

            cmd.Parameters.AddWithValue("FirstName", Entity.FirstName);
            cmd.Parameters.AddWithValue("LastName", Entity.LastName);
            var s = RDMS.SqlNonQuery(cmd);
            Console.WriteLine(s);
        }

        public void Delete(Empolyee Entity)
        {



            //comand
            var cmd = new SqlCommand(" DELETE FROM Employees  WHERE  EmployeeID=@EmployeeID");


            cmd.Parameters.AddWithValue("EmployeeID", Entity.EmployeeId);
            var s = RDMS.SqlNonQuery(cmd);



            Console.ReadKey();
        }

        public List<Empolyee> GetAll()
        {
            var _list = new List<Empolyee>();


            // SQL COmmand
            var cmd = new SqlCommand("select  EmployeeID, FirstName, LastName from employees");
            //sql data reader

            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(new Empolyee()
                {
                    EmployeeId = int.Parse(item[0].ToString()),
                    FirstName = item[1].ToString(),
                    LastName = item[2].ToString()



                });
            }
            return _list;
        }

        public void Update(Empolyee Entity)
        {

            var cmd = new SqlCommand(" UPDATE Employees SET FirstName=@FirstName, LastName=@LastName WHERE  EmployeeID=@EmployeeID");


            cmd.Parameters.AddWithValue("EmployeeID", Entity.EmployeeId);
            cmd.Parameters.AddWithValue("FirstName", Entity.FirstName);
            cmd.Parameters.AddWithValue("LastName", Entity.LastName);

            RDMS.SqlNonQuery(cmd);

        }
    }

}
