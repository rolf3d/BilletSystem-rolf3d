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
        public void PrisTestMC()
        {
            // Arrange
            var mc = new MC("344",false);
            // Act
            int pris = mc.Pris();

            // Assert
            Assert.AreEqual(125,pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            // Arrange
            var mc01 = new MC("378",false);

            // Act
            string køretøjsslags = mc01.KøretøjType();

            // Assert
            Assert.AreEqual("MC", køretøjsslags);
        }

        [TestMethod()]
        public void NummerpladeTest()
        {
            // Arrange
            MC mortercykel01 = new MC("7465787yu", false);
            // Act
            string nummerpladelængde = mortercykel01.Nummerplade;
            // Assert
            Assert.AreEqual(9,nummerpladelængde);
        }

        [TestMethod()]
        public void BrobizzTestMC()
        {
            // Arrange
            var mcmedbrobizz = new MC("mc123", true);

            // Act
            bool brobizztestresult = mcmedbrobizz.Brobizz;

            // Assert
            Assert.AreEqual(true, brobizztestresult);
        }
    }
}