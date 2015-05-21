using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using MvvmApplication.Models;
using MvvmApplication.Services;

namespace MvvmApplication.Controllers
{
    public class AdController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly ICountService _countService;

        public AdController(IBrandService brandService, ICountService countService)
        {
            _brandService = brandService;
            _countService = countService;
        }

        // GET: App
        public ActionResult Index(int id)
        {
            var token = Request.QueryString["token"];
            if (token != null)
            {
                _countService.Add(token);
            }
            //生成viewmodel给index页面使用
            var adModel = new AdModel(_brandService, id);
            ViewBag.Title = token + adModel.Brand.Name + "此处应有公司名字";
            return View(adModel);
        }
    }

    public class AdModel
    {
        public Brand Brand;
        public AdModel(IBrandService brandService, int id)
        {
            Brand = brandService.GetBrand(id);
        }
    }
}