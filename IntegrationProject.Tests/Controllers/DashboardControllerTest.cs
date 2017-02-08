using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegrationProject;
using IntegrationProject.Controllers;
using IntegrationProject.Models;
using IntegrationProject.ViewModels;

namespace IntegrationProject.Tests.Controllers
{
    [TestClass]
    public class DashBoardControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new DashBoardController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    }
}

