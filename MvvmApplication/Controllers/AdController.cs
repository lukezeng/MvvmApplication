using System.Web.Mvc;
using MvvmApplication.Models;
using MvvmApplication.Services;

namespace MvvmApplication.Controllers
{
    public class AdController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IRelationService _relationService;
        private readonly IUserService _userService;

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
        public Brand Brand;
        public User User;
        public int VisitCount;

        public AdModel(IUserService userService, IBrandService brandService, IRelationService relationService, int id)
        {
            var relation = relationService.GetRelation(id);
            VisitCount = relation.VisitCount;
            User = userService.GetUser(relation.UserId);
            Brand = brandService.GetBrand(relation.BrandId);
        }
    }
}