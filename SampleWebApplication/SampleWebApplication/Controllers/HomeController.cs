﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Help()
        {
            ViewBag.Message = "Your Help page.";

            return View();
        }
        public ActionResult Home()
        {
            ViewBag.Message = "Your Home page.";

            return View();
        }
        public ActionResult History()
        {
            ViewBag.Message = "Your History page.";

            return View();
        }

        public ActionResult Test1()
        {
            ViewBag.Message = "Your test page.";

            return View();
        }

    }
}
