using System.Collections.Generic;
using System.Linq;
using MvvmApplication.Models;

namespace MvvmApplication.SqlPersistances
{
    public interface IUserSqlPersistence
    {
        IEnumerable<User> GetAll();
        User GetUser(long id);
    }

    public class UserSqlPersistence : IUserSqlPersistence
    {
        private readonly List<User> _tmpUser = new List<User>
        {
            new User
            {
                Id = 0,
                Name = "曾古"
            },
            new User
            {
                Id = 1,
                Name = "User A"
            },
            new User
            {
                Id = 2,
                Name = "User B"
            },
            new User
            {
                Id = 3,
                Name = "User C"
            },
            new User
            {
                Id = 4,
                Name = "User D"
            },
            new User
            {
                Id = 5,
                Name = "User E"
            },
            new User
            {
                Id = 6,
                Name = "User F"
            }
        };

        public IEnumerable<User> GetAll()
        {
            return _tmpUser;
        }

        public User GetUser(long id)
        {
            var user = _tmpUser.FirstOrDefault(x => x.Id == id);
            return user ?? _tmpUser.FirstOrDefault(x => x.Id == 0);
        }
    }
}