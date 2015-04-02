using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvvmApplication.Models;
using MvvmApplication.Repository;

namespace MvvmApplication.Services
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAll();
    }
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public IEnumerable<Company> GetAll()
        {
            return _companyRepository.GetAll();
        }
    }
}