using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TechShop.exceptions
{


    public class DatabaseService
    {
        public void ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("your_connection_string"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Database error: " + sqlEx.Message);

            }
        }
    }

}