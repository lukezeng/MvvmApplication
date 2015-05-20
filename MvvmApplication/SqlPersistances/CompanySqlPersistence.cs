using System.Collections.Generic;
using MvvmApplication.Models;

namespace MvvmApplication.SqlPersistances
{
    public interface ICompanySqlPersistence
    {
        IEnumerable<Company> GetAll();
    }

    public class CompanySqlPersistence : ICompanySqlPersistence
    {
        public IEnumerable<Company> GetAll()
        {
            return new List<Company>
            {
                new Company
                {
                    Name = "Amazon",
                    Gdp = 25000,
                    Id = 1,
                    ImageUrl = "abcd",
                    Rating = 5
                }
            };
        }
    }
}