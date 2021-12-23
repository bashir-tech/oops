using System;
using System.Data;
using System.Data.SqlClient;

namespace OOP.ADONET
{
    public static class RDMS
    {
        //RELATİONAL DATABASE MANAGEMENT SYSTEM

        // connection string
        private static string connectionstring = @"Data Source=LAPTOP-3O4Q1PR4\SQLEXPRESS;
         Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;
        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
         MultiSubnetFailover=False";

   public static int SqlNonQuery(SqlCommand cmd)
        {
            try
            {
                using (var conn=new SqlConnection(connectionstring))
                {
                    conn.Open();

                    cmd.Connection = conn;
                    return cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



        public static DataSet SqlReader(SqlCommand cmd)
        {
            try
            {

                using (var conn = new SqlConnection(connectionstring))
                {
                    conn.Open();
                    cmd.Connection = conn;

                    var Sda = new SqlDataAdapter(cmd);
                    var ds = new DataSet();
                    Sda.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }

    }
