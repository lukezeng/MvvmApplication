using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvvmApplication.Models;

namespace MvvmApplication.Services
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAll();
    }
    public class CompanyService : ICompanyService
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