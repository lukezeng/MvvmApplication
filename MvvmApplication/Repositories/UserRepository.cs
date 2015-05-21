﻿using System.Collections.Generic;
using MvvmApplication.Models;
using MvvmApplication.SqlPersistances;

namespace MvvmApplication.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetUser(int id);
    }

    public class UserRepository : IUserRepository
    {
        private readonly IUserSqlPersistence _userSqlPersistence;

        public UserRepository(IUserSqlPersistence userSqlPersistence)
        {
            _userSqlPersistence = userSqlPersistence;
        }

        public IEnumerable<User> GetAll()
        {
            return _userSqlPersistence.GetAll();
        }

        public User GetUser(int id)
        {
            return _userSqlPersistence.GetUser(id);
        }
    }
}