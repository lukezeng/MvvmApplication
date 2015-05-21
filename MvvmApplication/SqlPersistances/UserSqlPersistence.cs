using System.Collections.Generic;
using System.Linq;
using MvvmApplication.Models;

namespace MvvmApplication.SqlPersistances
{
    public interface IUserSqlPersistence
    {
        IEnumerable<User> GetAll();
        User GetUser(int id);
    }

    public class UserSqlPersistence : IUserSqlPersistence
    {
        private readonly List<User> _tmpUser = new List<User>
        {
            new User()
            {
                Id = 0,
                Name = "全民代言"
            },
            new User()
            {
                Id = 1,
                Name = "Brand A"
            },
            new User()
            {
                Id = 2,
                Name = "Brand B"
            },
            new User()
            {
                Id = 3,
                Name = "Brand C"
            },
            new User()
            {
                Id = 4,
                Name = "Brand D"
            },
            new User()
            {
                Id = 5,
                Name = "Brand E"
            },
            new User()
            {
                Id = 6,
                Name = "Brand F"
            }
        };

        public IEnumerable<User> GetAll()
        {
            return _tmpUser;
        }

        public User GetUser(int id)
        {
            var user = _tmpUser.FirstOrDefault(x => x.Id == id);
            return user ?? _tmpUser.FirstOrDefault(x => x.Id == 0);
        }
    }
}