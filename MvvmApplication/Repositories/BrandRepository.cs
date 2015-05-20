﻿using System.Collections.Generic;
using MvvmApplication.Models;
using MvvmApplication.SqlPersistances;

namespace MvvmApplication.Repositories
{
    public interface IBrandRepository
    {
        IEnumerable<Brand> GetAll();
    }

    public class BrandRepository : IBrandRepository
    {
        private readonly IBrandSqlPersistence _brandSqlPersistence;

        public BrandRepository(IBrandSqlPersistence brandSqlPersistence)
        {
            _brandSqlPersistence = brandSqlPersistence;
        }

        public IEnumerable<Brand> GetAll()
        {
            return _brandSqlPersistence.GetAll();
        }
    }
}