using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MurphyPubMenu.Models
{
    public abstract class Product
    {
        protected string Name;
        protected string ID;
        protected float Price;
        protected int Quantity;
        public Product(string name, string id, float price, int quantity)
        {
            Name = name;
            ID = id;
            Price = price;
            Quantity = quantity;
        }
    }
}