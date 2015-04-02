using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using MvvmApplication.Models;

namespace Future.Controllers.api
{
    public class CompanyController : ApiController
    {
        // GET api/company
        public IEnumerable<Company> Get()
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