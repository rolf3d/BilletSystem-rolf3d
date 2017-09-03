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
    public class MCTests
    {
        [TestMethod()]
        public void MCTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PrisTest()
        {
            // Arrange
            var mc = new MC();
            // Act
            int pris = mc.Pris();

            // Assert
            Assert.AreEqual(125,pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            // Arrange
            var mc01 = new MC();

            // Act
            string køretøjsslags = mc01.KøretøjType();

            // Assert
            Assert.AreEqual("MC", køretøjsslags);
        }
    }
}