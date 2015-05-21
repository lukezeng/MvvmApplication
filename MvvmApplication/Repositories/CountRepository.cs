using System.Collections.Generic;
using System.Security.Principal;
using MvvmApplication.Models;
using MvvmApplication.SqlPersistances;

namespace MvvmApplication.Repositories
{
    public interface ICountRepository
    {
        void Add(string token);
    }

    public class CountRepository : ICountRepository
    {
        private readonly ICountSqlPersistence _countSqlPersistence;

        public CountRepository(ICountSqlPersistence countSqlPersistence)
        {
            _countSqlPersistence = countSqlPersistence;
        }

        public void Add(string token)
        {
            _countSqlPersistence.Add(token);
        }
    }
}