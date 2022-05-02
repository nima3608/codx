using CodeCoverage.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCoverageTests.Controllers
{
    [TestClass]
    public class ValuesControllerTests
    {
        [TestMethod]
        public void Throws_ANE_OrderService()
        {
            // Arrange
            // Act 
            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => new ValuesController(orderService: null));
        }
    }
}
