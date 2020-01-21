using AnimalBears.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalBears
{
    public class AnimalDB
    {
        public static void AddAnimal(Animal a)
        {
            SqlConnection con = SSMSDBHelper.GetConnection();

            SqlCommand addAnimal = new SqlCommand();
            addAnimal.Connection = con;
            addAnimal.CommandText = "Insert Into Animal" +
                "(AnimalID, Name, AnimalNAme, Color)" +
                "values(@Name, @AnimalName, @Color)";
            addAnimal.Parameters.AddWithValue("@Name", a.AnimalName);
            addAnimal.Parameters.AddWithValue("@AnimalName", a.AnimalName);
            addAnimal.Parameters.AddWithValue("@Color", a.Color);

            try
            {
                con.Open();
                int rows = addAnimal.ExecuteNonQuery();
                if (rows == 0)
                {
                    throw new Exception("Nothing Happened");

                }
            }

            finally
            {
                con.Dispose();
            }
        }    
    }
}
