using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Te.ActivityFinder.Core;
using Te.ActivityFinder.Core.Controllers;
using Te.ActivityFinder.Core.Models;

namespace Te.ActivityFinder.Core.Tests.Controllers
{
    [TestClass]
    public class ActivityControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ActivityController controller = new ActivityController();

            // Act
            List<Activity> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ActivityController controller = new ActivityController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ActivityController controller = new ActivityController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            ActivityController controller = new ActivityController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ActivityController controller = new ActivityController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
