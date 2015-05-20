using System.Collections.Generic;
using MvvmApplication.Models;

namespace MvvmApplication.SqlPersistances
{
    public interface IBrandSqlPersistence
    {
        IEnumerable<Brand> GetAll();
    }

    public class BrandSqlPersistence : IBrandSqlPersistence
    {
        public IEnumerable<Brand> GetAll()
        {
            return new List<Brand>
            {
                new Brand()
                {
                    Id = 1,
                    Name = "Brand A"
                },                
                new Brand()
                {
                    Id = 2,
                    Name = "Brand B"
                },                
                new Brand()
                {
                    Id = 3,
                    Name = "Brand C"
                },                
                new Brand()
                {
                    Id = 4,
                    Name = "Brand D"
                },                
                new Brand()
                {
                    Id = 5,
                    Name = "Brand E"
                },                
                new Brand()
                {
                    Id = 6,
                    Name = "Brand F"
                }
            };
        }
    }
}