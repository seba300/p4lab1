using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace p4lab
{
    class CRUD
    {
        public void Create(int id,string regionDescription, SqlConnection conn)
        {
            string sql = "INSERT INTO Northwind.dbo.Region(RegionID,RegionDescription) VALUES (@id,@regionName)";
            var command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@regionName", regionDescription);
            command.Parameters.AddWithValue("@id", id);

            //returns numbers of lines
            int x = command.ExecuteNonQuery();

            if(x>0)
            {
                Console.WriteLine("Wpisane");
            }
        }
        public void Update(int id, string newName, SqlConnection conn)
        {
            string sql = "UPDATE Northwind.dbo.Region SET RegionDescription = @regionName WHERE RegionID=@id";
            var command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@regionName", newName);
            command.Parameters.AddWithValue("@id", id);

            int x = command.ExecuteNonQuery();

            if (x > 0)
            {
                Console.WriteLine("Zmieniono");
            }
        }

        public void Delete(int id, SqlConnection conn)
        {
            string sql = "DELETE FROM Northwind.dbo.Region WHERE RegionID=@id";
            var command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@id", id);

            int x = command.ExecuteNonQuery();

            if (x > 0)
            {
                Console.WriteLine("Usunieto");
            }
        }

    }
}
