﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace metoo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return (View());
        }

        public ActionResult Vote()
        {
            return (View()); 
        }

        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Key()
        {
            return View();
        }
        public ActionResult Result()
        {
            return View();
        }

        public ActionResult Reset()
        {
            return View();
        }

        public ActionResult Check() 
        {
            return View();
        }
    }
}