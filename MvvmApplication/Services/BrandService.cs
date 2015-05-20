using System.Collections.Generic;
using MvvmApplication.Models;
using MvvmApplication.Repositories;

namespace MvvmApplication.Services
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetAll();
        Brand GetBrand(int id);
    }

    public class BrandService : IBrandService
    {
        private readonly BrandRepository _brandRepository;

        public BrandService(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public IEnumerable<Brand> GetAll()
        {
            return _brandRepository.GetAll();
        }

        public Brand GetBrand(int id)
        {
            return _brandRepository.GetBrand(id);
        }
    }
}