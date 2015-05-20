using System.Collections.Generic;
using System.Web.Http;
using MvvmApplication.Models;
using MvvmApplication.Services;

namespace MvvmApplication.Controllers.Apis
{
    public class CompanyController : ApiController
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        // GET api/company
        public IEnumerable<Company> Get()
        {
            return _companyService.GetAll();
        }
    }
}