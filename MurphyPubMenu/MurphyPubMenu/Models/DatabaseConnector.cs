using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MurphyPubMenu.Models
{
    public class DatabaseConnector
    {
        public string ConnectionString { get; }
        public DatabaseConnector(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public MenuDataTable GetProducts(string productType)
        {
            MenuDataTable table = new MenuDataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM Products WHERE ProductType = '{productType}'");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<MenuDataCell> cells = new List<MenuDataCell>();
                        while (reader.Read())
                        {
                            cells.Add(new MenuDataCell(reader["Title"].ToString(), (float)reader["Price"], reader["ImageSource"].ToString()));
                        }
                    }   
                }
            }
            catch(MySqlException ex)
            {
                
            }
            catch(Exception ex)
            {

            }
        }
    }
}