using Moq;
using MvvmApplication.Controllers;
using MvvmApplication.Services;
using NUnit.Framework;

namespace MvvmApplication.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Test]        
        public void Index()
        {
            var companyService = new Mock<ICompanyService>();
            var controller = new HomeController(companyService.Object);
            var homeIndex = controller.Index();
            companyService.Verify(x => x.GetAll(), Times.Once);
        }
    }
}
