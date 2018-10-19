using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MurphyPubMenu.Models;
using System.Configuration;

namespace MurphyPubMenu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string tableCodeValue)
        {
            if (tableCodeValue == string.Empty) {
                TempData["Alert"] = "Morate uneti kod Vaseg stola.";
                return View();
            }
            if(!new DatabaseConnector(ConfigurationManager.ConnectionStrings["MurphyConnString"].ConnectionString).CheckTableCodeAndSend(tableCodeValue))
            {
                TempData["Alert"] = "Uneti kod ne postoji.";
                return View();
            }
            return RedirectToAction("Menu");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }
    }
}