using System.Collections.Generic;
using System.Linq;
using Moq;
using MvvmApplication.Models;
using MvvmApplication.Repositories;
using MvvmApplication.Services;
using NUnit.Framework;

namespace MvvmApplication.Tests.Services
{
    internal class BrandServiceTests
    {
        private readonly List<Brand> _brands = new List<Brand>();
        private List<Relation> _relations = new List<Relation>();
        private BrandService _brandService;

        private Mock<IBrandRepository> _brandRepository;
        private Mock<IRelationRepository> _relationRepository;

        [SetUp]
        public void Setup()
        {
            for (var i = 0; i < 10; i++)
            {
                _brands.Add(new Brand
                {
                    Id = i,
                    Name = "Test Brand "+ i
                });
            }
            _relations = new List<Relation>
            {
                new Relation
                {

                    Id = 1,
                    UserId = 1,
                    BrandId = 1
                },
                new Relation
                {
                    Id = 2,
                    UserId = 1,
                    BrandId = 2
                },
                new Relation
                {
                    Id = 3,
                    UserId = 1,
                    BrandId = 3
                },
                new Relation
                {

                    Id = 4,
                    UserId = 2,
                    BrandId = 4
                },

            };

            _brandRepository = new Mock<IBrandRepository>();
            _relationRepository = new Mock<IRelationRepository>();

            _brandRepository.Setup(x => x.GetAll()).Returns(_brands);

            _brandService = new BrandService(_brandRepository.Object, _relationRepository.Object);
        }

        [Test]
        public void GetAll()
        {
            var allBrands = _brandService.GetAll();
            _brandRepository.Verify(x => x.GetAll(), Times.Once);
            Assert.AreEqual(allBrands, _brands);
        }

        [Test]
        public void GetBrand_GivenBrandId_ReturnCorrectBrand()
        {
            var result = _brands.FirstOrDefault(x => x.Id == 1);
            _brandRepository.Setup(x => x.GetBrand(1)).Returns(result);
            var brand = _brandService.GetBrand(1);
            _brandRepository.Verify(x => x.GetBrand(1), Times.Once);
            Assert.AreEqual(brand, result);
        }

        [Test]
        public void GetBrandsByUserId_GivenUserId_ReturnAllUsersBrands()
        {
            _relationRepository.Setup(x => x.GetRelationsByUserId(1)).Returns(_relations);
            var brands = _brandService.GetBrandsByUserId(1);
            _relationRepository.Verify(x => x.GetRelationsByUserId(1), Times.Once);
            Assert.AreEqual(_relations.Count, brands.Count());
        }
    }
}