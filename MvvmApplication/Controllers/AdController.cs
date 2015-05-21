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
        private readonly IUserService _userService;
        private readonly IBrandService _brandService;
        private readonly IRelationService _relationService;

        public AdController(IUserService userService, IBrandService brandService, IRelationService relationService)
        {
            _userService = userService;
            _brandService = brandService;
            _relationService = relationService;
        }

        // GET: App
        public ActionResult Index(int id)
        {
            var token = Request.QueryString["token"];
            //model给index页面使用
            var adModel = new AdModel(_userService, _brandService, _relationService, id);
            ViewBag.Title = token + adModel.Brand.Name + "此处应有公司名字";
            return View(adModel);
        }
    }

    public class AdModel
    {
        public User User;
        public Brand Brand;
        public AdModel(IUserService userService, IBrandService brandService,IRelationService relationService, int id)
        {
            var relation = relationService.GetRelation(id);
            User = userService.GetUser(relation.UserId);
            Brand = brandService.GetBrand(relation.BrandId);
        }
    }
}