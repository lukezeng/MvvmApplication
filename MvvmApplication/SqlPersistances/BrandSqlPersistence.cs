using System.Collections.Generic;
using System.Linq;
using MvvmApplication.Models;

namespace MvvmApplication.SqlPersistances
{
    public interface IBrandSqlPersistence
    {
        IEnumerable<Brand> GetAll();
        Brand GetBrand(long id);
    }

    public class BrandSqlPersistence : IBrandSqlPersistence
    {
        private readonly List<Brand> _tmpBrand = new List<Brand>
        {
            new Brand
            {
                Id = 0,
                Name = "全民代言"
            },
            new Brand
            {
                Id = 1,
                Name = "Brand A"
            },
            new Brand
            {
                Id = 2,
                Name = "Brand B"
            },
            new Brand
            {
                Id = 3,
                Name = "Brand C"
            },
            new Brand
            {
                Id = 4,
                Name = "Brand D"
            },
            new Brand
            {
                Id = 5,
                Name = "Brand E"
            },
            new Brand
            {
                Id = 6,
                Name = "Brand F"
            }
        };

        public IEnumerable<Brand> GetAll()
        {
            return _tmpBrand;
        }

        public Brand GetBrand(long id)
        {
            var brand = _tmpBrand.FirstOrDefault(x => x.Id == id);
            return brand ?? _tmpBrand.FirstOrDefault(x => x.Id == 0);
        }
    }
}