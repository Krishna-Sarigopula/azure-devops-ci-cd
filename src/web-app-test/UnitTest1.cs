using Microsoft.AspNetCore.Mvc;
using web_app.Controllers;

namespace web_app_test
{
    public class UnitTest1
    {
        [Fact]
        public void HomeController_Index_Test()
        {
            HomeController homeController = new HomeController();
            ViewResult viewResult = homeController.Index() as ViewResult;
            Assert.NotNull(viewResult);
        }

        [Fact]
        public void HomeController_Contact_Test()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Privacy() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }
    }
}