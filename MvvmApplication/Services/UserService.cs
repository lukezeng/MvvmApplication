using System.Collections.Generic;
using System.Linq;
using MvvmApplication.Models;
using MvvmApplication.Repositories;

namespace MvvmApplication.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetUser(long id);
        IEnumerable<User> GetUsersByBrandId(long brandId);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRelationRepository _relationRepository;

        public UserService(IUserRepository userRepository, IRelationRepository relationRepository)
        {
            _userRepository = userRepository;
            _relationRepository = relationRepository;
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetUser(long id)
        {
            return _userRepository.GetUser(id);
        }

        public IEnumerable<User> GetUsersByBrandId(long brandId)
        {
            var users = GetAll();
            var relations = _relationRepository.GetRelationsByBrandId(brandId);
            return relations.Select(relation => users.FirstOrDefault(x => x.Id == relation.UserId));
        } 
    }
}