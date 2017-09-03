using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void BilTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PrisTest()
        {
            // Arrange
            var bilpris = new Bil("2345");
            //Act
            int pris = bilpris.Pris();
            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            // Arrange
            var køretøj = new Bil("234");

            // Act
            string køretøjslags = køretøj.KøretøjType();

            // Assert
            Assert.AreEqual("Bil",køretøjslags);
        }
    }
}