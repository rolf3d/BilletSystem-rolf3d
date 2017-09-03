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
            var bilpris = new Bil("2345", true, new DateTime(2017,08,28));
            //Act
            int pris = bilpris.Pris();
            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            // Arrange
            var køretøj = new Bil("234", true,new DateTime(2017,08,29));

            // Act
            string køretøjslags = køretøj.KøretøjType();

            // Assert
            Assert.AreEqual("Bil", køretøjslags);
        }

        [TestMethod()]
        public void BrobizzTestBil()
        {
            // Arrange
            var bilmedbrobizz = new Bil("832huio", false, new DateTime(2017,09,01));

            // Act
            bool brobizztestresult = bilmedbrobizz.Brobizz;

            // Assert
            Assert.AreEqual(true, brobizztestresult);
        }

        [TestMethod()]
        public void WeekendRabatterTest()
        {
            // Arrange
            var weekendRabat01 = new Bil("2345",true,new DateTime(2017,09,03));
            // Act
            int hvilkenrabat = weekendRabat01.WeekendRabatter();
            // Assert
            // Bilen har brobizz og køre over en søndag
            Assert.AreEqual(190,hvilkenrabat);
        }
    }
}