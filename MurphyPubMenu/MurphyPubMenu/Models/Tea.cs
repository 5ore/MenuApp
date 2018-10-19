using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MurphyPubMenu.Models
{
    public class Tea : Product
    {
        public List<Attachment> Attachments { get; }
        public Tea(string Name, string ID, float Price, List<Attachment> attachments, int Quantity)
            :base(Name, ID, Price, Quantity)
        {

        }
    }
}