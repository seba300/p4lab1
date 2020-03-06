using System;
using System.Data.SqlClient;

namespace p4lab
{
    //ADO.NET
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string CommandText = "SELECT * FROM Customers";
            SqlCommand command = new SqlCommand(CommandText, conn);

            //execute commandText
            SqlDataReader reader = command.ExecuteReader();

            //read all
            while (reader.Read())
            {
                Console.WriteLine(reader["CompanyName"]);
            }
            reader.Close();

            CRUD crud = new CRUD();
            //crud.Create(7,"Slask", conn);

            //crud.Update(6, "NieSlask", conn);

            crud.Delete(6, conn);
            conn.Close();
        }
    }
}
