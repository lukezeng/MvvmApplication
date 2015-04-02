using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmApplication.Controllers.Apis;
using MvvmApplication.Services;

namespace MvvmApplication.Tests.Controllers.Apis
{
    [TestClass]
    public class CompanyControllerTests
    {
        [TestMethod]
        public void Get()
        {
            var companyService = new Mock<ICompanyService>();
            var controller = new CompanyController(companyService.Object);
            var allCompanies = controller.Get();
            companyService.Verify(x=>x.GetAll(), Times.Once);
        }
    }
}
