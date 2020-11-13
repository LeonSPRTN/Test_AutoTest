using Microsoft.AspNetCore.Mvc;
using Test_AutoTest.Controllers;
using Xunit;
using Moq;
using Test_AutoTest.Common;
using Castle.Core.Logging;
using Test_AutoTest.Models;
using System.Collections.Generic;

namespace Test_AutoTest.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            var mockUser = new Mock<IRepository>();

            mockUser.Setup(repo => repo.GetAll()).Returns(GetTestUsers());

            var homeController = new HomeController(mockUser.Object);

            ViewResult viewResult = homeController.Index() as ViewResult;

            Assert.Equal("Test_AutoTest", viewResult?.ViewData["Message"]);

            Assert.NotNull(viewResult);
        }

        [Fact]
        public void PrivacyTest()
        {
            var mockUser = new Mock<IRepository>();

            mockUser.Setup(repo => repo.GetAll()).Returns(GetTestUsers());

            var homeController = new HomeController(mockUser.Object);

            ViewResult viewResult = homeController.Privacy() as ViewResult;

            Assert.Equal("Приложение для тестирования", viewResult?.ViewData["Test"]);

            Assert.NotNull(viewResult);
        }

        private List<User> GetTestUsers()
        {
            var users = new List<User>
            {
                new User { Id=1, FirstName="Трус", LastName = "Трусович", Age=35},
                new User { Id=2, FirstName="Болбес", LastName = "Болбесович", Age=29},
                new User { Id=3, FirstName="Бывалый", LastName = "Бывалов", Age=32},
            };
            return users;
        }
    }
}
