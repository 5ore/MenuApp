using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MurphyPubMenu.Models
{
    public class MenuDataTable
    {
        public List<MenuDataRow> MenuDataRows { get; set; }
        public MenuDataTable()
        {
            MenuDataRows = new List<MenuDataRow>();
        }
    }
}