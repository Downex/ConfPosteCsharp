using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConfPosteCsharp.Models
{
    public class DataBaseHelper
    {
        public static string HelloWorld()
        {
            try
            {
                MySqlConnectionStringBuilder connectionBuilder = new MySqlConnectionStringBuilder
                {
                    Server = "localhost",
                    Port = 3307,
                    UserID = "root",
                    Password = "",
                    Database = "confposte"
                };
                string hello = null;

                using (MySqlConnection connection = new MySqlConnection(connectionBuilder.ToString()))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT libelle FROM hello;", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                hello = reader.GetString("libelle");
                        }
                    }
                }

                return hello;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw e;
            }
        }

    }
}
