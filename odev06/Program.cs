using System;
using System.Data.SqlClient;

namespace odev06
{
    class Program
    {
        static void Main(string[] args)
        {
           string Connectionstring = "Server=LAPTOP-3O4Q1PR4\\SQLEXPRESS;Database=SQLQuery2";
            SqlConnection conn = new SqlConnection(Connectionstring);
            

                conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees",conn);
                
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string EmployeeID = dr["EmployeeID"].ToString();
                        string FirstName = dr["FirstName"].ToString();
                        string LastName = dr["LastName"].ToString();
                        Console.WriteLine(EmployeeID + " " + FirstName + " " + LastName );
                    }
                    dr.Close();
                    conn.Close();
           

                  
                
            

        }
    }
}
