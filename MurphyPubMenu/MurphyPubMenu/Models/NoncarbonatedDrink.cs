using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MurphyPubMenu.Models
{
    public class NoncarbonatedDrink : Product
    {
        public NoncarbonatedDrink(string Name, string ID, float Price, int Quantity)
           : base(Name, ID, Price, Quantity)
        {

        }
    }
}