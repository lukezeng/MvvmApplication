using System.Collections.Generic;
using System.Linq;
using Moq;
using MvvmApplication.Models;
using MvvmApplication.Repositories;
using MvvmApplication.Services;
using NUnit.Framework;

namespace MvvmApplication.Tests.Services
{
    internal class UserServiceTests
    {
        private readonly List<Relation> _relations = TestConstant.Relations;
        private readonly List<User> _users = TestConstant.Users;
        private Mock<IRelationRepository> _relationRepository;
        private Mock<IUserRepository> _userRepository;
        private UserService _userService;

        [SetUp]
        public void Setup()
        {
            _userRepository = new Mock<IUserRepository>();
            _relationRepository = new Mock<IRelationRepository>();

            _userRepository.Setup(x => x.GetAll()).Returns(_users);

            _userService = new UserService(_userRepository.Object, _relationRepository.Object);
        }

        [Test]
        public void GetAll()
        {
            var users = _userService.GetAll();

            _userRepository.Verify(x => x.GetAll(), Times.Once);

            Assert.AreEqual(_users, users);
        }

        [Test]
        public void GetUser_GivenUserId_ReturnCorrectUser()
        {
            var result = _users.FirstOrDefault(x => x.Id == 1);
            _userRepository.Setup(x => x.GetUser(1)).Returns(result);

            var user = _userService.GetUser(1);

            _userRepository.Verify(x => x.GetUser(1), Times.Once);
            Assert.AreEqual(result, user);
        }

        [Test]
        public void GetUsersByBrandId_GivenBrandId_ReturnAllBrandsUsers()
        {
            _relationRepository.Setup(x => x.GetRelationsByBrandId(1)).Returns(_relations);

            var users = _userService.GetUsersByBrandId(1);

            _relationRepository.Verify(x => x.GetRelationsByBrandId(1), Times.Once);
            Assert.AreEqual(_relations.Count, users.Count());
        }
    }
}