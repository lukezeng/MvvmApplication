using System.Collections.Generic;
using MvvmApplication.Models;
using MvvmApplication.SqlPersistance;

namespace MvvmApplication.Repositories
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAll();
    }

    public class CompanyRepository : ICompanyRepository
    {
        private readonly ICompanySqlPersistence _companySqlPersistence;

        public CompanyRepository(ICompanySqlPersistence companySqlPersistence)
        {
            _companySqlPersistence = companySqlPersistence;
        }

        public IEnumerable<Company> GetAll()
        {
            return _companySqlPersistence.GetAll();
        }
    }
}