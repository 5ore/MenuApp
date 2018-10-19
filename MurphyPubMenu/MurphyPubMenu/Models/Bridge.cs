using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MurphyPubMenu.Models
{
    public class Bridge
    {
        public List<Product> Products { get; }
        public void SendData()
        {
            // Ovde se salje broj stola admin racunaru.
            
        }
        public void GetData()
        {
            DatabaseConnector connector = new DatabaseConnector(ConfigurationManager.ConnectionStrings["MarfiConnString"].ConnectionString);
            connector.GetProducts()
        }
    }
}