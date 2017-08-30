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
            var mc = new MC("876");
            // Act
            int pris = mc.Pris();

            // Assert
            Assert.AreEqual(125,pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            // Arrange
            var mc01 = new MC("987");

            // Act
            string køretøjsslags = mc01.Køretøj();

            // Assert
            Assert.AreEqual("MC", køretøjsslags);
        }
    }
}