using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmApplication.Controllers;
using MvvmApplication.Services;

namespace MvvmApplication.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            var companyService = new Mock<ICompanyService>();
            var controller = new HomeController(companyService.Object);
            var homeIndex = controller.Index();
            companyService.Verify(x => x.GetAll(), Times.Once);
        }
    }
}
