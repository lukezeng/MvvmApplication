using System.Web.Mvc;
using MvvmApplication.Services;

namespace MvvmApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICompanyService _companyService;

        public HomeController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public ActionResult Index()
        {
            _companyService.GetAll();
            return View();
        }
    }
}
