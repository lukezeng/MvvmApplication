using System.Collections.Generic;
using System.Linq;
using MvvmApplication.Models;
using MvvmApplication.Repositories;

namespace MvvmApplication.Services
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetAll();
        Brand GetBrand(long id);
        IEnumerable<Brand> GetBrandsByUserId(int userId);
    }

    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IRelationRepository _relationRepository;

        public BrandService(IBrandRepository brandRepository, IRelationRepository relationRepository)
        {
            _brandRepository = brandRepository;
            _relationRepository = relationRepository;
        }

        public IEnumerable<Brand> GetAll()
        {
            return _brandRepository.GetAll();
        }

        public Brand GetBrand(long id)
        {
            return _brandRepository.GetBrand(id);
        }

        public IEnumerable<Brand> GetBrandsByUserId(int userId)
        {
            var brands = GetAll();
            var relations = _relationRepository.GetRelationsByUserId(userId);
            return relations.Select(relation => brands.FirstOrDefault(x => x.Id == relation.BrandId));
        }
    }
}