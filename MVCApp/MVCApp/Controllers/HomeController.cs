using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            if (id > 5)
            {
                return RedirectToAction("Base");
            }
            ViewBag.ID = id;
            return View("Index");
        }
        public ActionResult Base()
        {
         
            return View();
        }

      
    }
}