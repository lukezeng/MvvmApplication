using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvvmApplication.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            ViewBag.Title = "Passed In App Title";
            return View();
        }
    }
}