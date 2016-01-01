﻿using System.Web.Mvc;

namespace Komsky.Web.Controllers
{
    public partial class HomeController : Controller
    {
       public virtual ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}