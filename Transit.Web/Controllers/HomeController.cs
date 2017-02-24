﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transit.Commons;
using Transit.Web.Models;

namespace Transit.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();

            model.Title = "Home";
            model.BreadCrumbs = new List<Link>{
                new Link() { Text="Transit", URL="/" },
                new Link() { Text="Home", URL="/" },
            };

            return View(model);
        }

        public ActionResult About()
        {
            AboutViewModel model = new AboutViewModel();

            model.Title = "About";
            model.BreadCrumbs = new List<Link>{
                new Link() { Text="Transit", URL="/" },
                new Link() { Text="About", URL="/about" },
            };

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}