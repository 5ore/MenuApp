using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MurphyPubMenu.Models
{
    public class Coffee : Product
    {
        public List<Attachment> Attachments { get; }
        public Coffee(string Name, string ID, float Price, int Quantity, List<Attachment> attachments)
            :base(Name, ID, Price, Quantity)
        {
            Attachments = attachments;
            Bridge.Products.Add(this);
        }
    }
}