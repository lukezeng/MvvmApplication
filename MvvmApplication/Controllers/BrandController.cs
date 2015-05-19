using System.Web.Mvc;
using MvvmApplication.Services;

namespace MvvmApplication.Controllers
{
    public class BrandController : Controller
    {
        private readonly ICompanyService _companyService;
        public BrandController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        // GET /brand
        public JsonResult Get()
        {
            return Json(_companyService.GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}