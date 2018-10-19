using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MurphyPubMenu.Models
{
    public class Wine : Product
    {
        public Wine(string Name, string ID, float Price, int Quantity)
          : base(Name, ID, Price, Quantity)
        {

        }
    }
}