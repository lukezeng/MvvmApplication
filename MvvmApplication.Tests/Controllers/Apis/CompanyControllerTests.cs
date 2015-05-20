using System.Collections.Generic;
using Moq;
using MvvmApplication.Controllers.Apis;
using MvvmApplication.Models;
using MvvmApplication.Services;
using NUnit.Framework;

namespace MvvmApplication.Tests.Controllers.Apis
{
    public class CompanyControllerTests
    {
        private readonly List<Company> _companies = new List<Company>();

        [SetUp]
        public void Setup()
        {
            _companies.Add(new Company());
            _companies.Add(new Company());
        }

        [Test]
        public void Get()
        {
            var companyService = new Mock<ICompanyService>();
            companyService.Setup(x => x.GetAll()).Returns(_companies);
            var controller = new CompanyController(companyService.Object);
            var allCompanies = controller.Get();
            Assert.AreEqual(_companies, allCompanies);
            companyService.Verify(x => x.GetAll(), Times.Once);
        }
    }
}