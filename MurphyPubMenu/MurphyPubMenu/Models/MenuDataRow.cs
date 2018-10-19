using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MurphyPubMenu.Models
{
    public class MenuDataRow
    {
        public List<MenuDataCell> MenuDataCells { get; set; }
        public MenuDataRow()
        {
            MenuDataCells = new List<MenuDataCell>();
        }
    }
}