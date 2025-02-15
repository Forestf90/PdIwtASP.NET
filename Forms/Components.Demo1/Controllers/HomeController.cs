﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Components.Demo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult GetTechnologies()
        {
            var technologies= new List<string> { "asp core", "django","Flatter", "react.js", "vus.js" };
            ViewBag.Message = "Your contact page.";

            return PartialView(technologies);
        }
    }
}