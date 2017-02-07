using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegrationProject;
using IntegrationProject.Controllers;

namespace IntegrationProject.Tests.Controllers
{
    [TestClass]
    class DashboardControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            DashBoardController controller = new DashBoardController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

