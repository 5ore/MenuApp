using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MurphyPubMenu.Models
{
    public class Attachment
    {
        public string Name;
        public float Price;
        public Attachment(string Name, float Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}