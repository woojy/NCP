using metoo.Models;
using System;
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
            //ViewBag.theUsers = CInstance.theUserMananger.GetUsers();
            return View();
        }

        public ActionResult Admin()
        {

            return (View());
        }
        public ActionResult Login()
        {
            return (View());
        }

        public ActionResult Vote()
        {
            return (View()); 
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

        public ActionResult Registration()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Registration(CUser aUser)
        {
            if (aUser != null)
            {
                return RedirectToAction("JoinOK", aUser);
            }
            return View(aUser);
        }
        public ActionResult JoinOK(CUser aUser)
        {
            ViewBag.name = aUser.name;

            return View(aUser);
        }
    }
}