using System.Collections.Generic;
using System.Linq;
using MvvmApplication.Models;

namespace MvvmApplication.SqlPersistances
{
    public interface ICountSqlPersistence
    {
        void Add(string token);
    }

    public class CountSqlPersistence : ICountSqlPersistence
    {
        public void Add(string token)
        {
            
        }
    }
}