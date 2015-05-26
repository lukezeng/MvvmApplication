using System.Collections.Generic;
using System.Linq;
using MvvmApplication.Models;
using MvvmApplication.Repositories;

namespace MvvmApplication.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetUser(int id);
    }

    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        private readonly IRelationRepository _relationRepository;

        public UserService(UserRepository userRepository, IRelationRepository relationRepository)
        {
            _userRepository = userRepository;
            _relationRepository = relationRepository;
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetUser(int id)
        {
            return _userRepository.GetUser(id);
        }

        public IEnumerable<User> GetUsersByBrandId(int brandId)
        {
            var users = GetAll();
            var relations = _relationRepository.GetRelationsByBrandId(brandId);
            return relations.Select(relation => users.FirstOrDefault(x => x.Id == relation.UserId));
        } 
    }
}