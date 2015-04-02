using System.Collections.Generic;
using System.Web.Http;
using MvvmApplication.Models;
using MvvmApplication.Services;
using Ninject;

namespace MvvmApplication.Controllers.Apis
{
    public class CompanyController : ApiController
    {
        private readonly ICompanyService _companyService;
        public CompanyController()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<ICompanyService>()
                .To<CompanyService>();
            _companyService = ninjectKernel.Get<ICompanyService>();
        }

        // GET api/company
        public IEnumerable<Company> Get()
        {
            return _companyService.GetAll();
        }
    }
}