using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvvmApplication.Controllers
{
    public class AdController : Controller
    {
        // GET: App
        public ActionResult Index(int id)
        {
            ViewBag.Title = id + "此处应有公司名字";
            return View();
        }
    }
}