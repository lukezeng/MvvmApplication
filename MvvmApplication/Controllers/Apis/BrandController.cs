using System.Collections.Generic;
using System.Web.Http;
using MvvmApplication.Models;
using MvvmApplication.Services;

namespace MvvmApplication.Controllers.Apis
{
    public class BrandController : ApiController
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        // GET api/company
        public IEnumerable<Brand> Get()
        {
            return _brandService.GetAll();
        }

        // GET api/company
        public Brand GetBrand(int id)
        {
            return _brandService.GetBrand(id);
        }
    }
}