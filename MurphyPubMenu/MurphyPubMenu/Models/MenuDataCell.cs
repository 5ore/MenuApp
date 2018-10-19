using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MurphyPubMenu.Models
{
    public class MenuDataCell
    {
        public string Title;
        public float Price;
        public string ImageSource;
        public MenuDataCell(string title, float price, string imageSource)
        {
            Title = title;
            Price = price;
            ImageSource = imageSource;
        }
    }
}