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
        //[TestMethod()]
        //public void BilTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void PrisTest()
        //{
        //    // Arrange
        //    var bilpris = new Bil("2345", true, new DateTime(2017,08,28),false,true);
        //    //Act
        //    int pris = bilpris.PrisStorebælt();
        //    //Assert
        //    Assert.AreEqual(240, pris);
        //}

        [TestMethod()]
        public void KøretøjTest()
        {
            // Arrange
            var køretøj = new Bil("234", true,new DateTime(2017,08,29),true,true);

            // Act
            string køretøjslags = køretøj.KøretøjType();

            // Assert
            Assert.AreEqual("Bil", køretøjslags);
        }

        //[TestMethod()]
        //public void BrobizzTestBil()
        //{
        //    // Arrange
        //    var bilmedbrobizz = new Bil("832huio", false, new DateTime(2017,09,01),true,false);

        //    // Act
        //    bool brobizztestresult = bilmedbrobizz.Brobizz;

        //    // Assert
        //    Assert.AreEqual(true, brobizztestresult);
        //}

        //[TestMethod()]
        //public void WeekendRabatterTest()
        //{
        //    // Arrange
        //    var weekendRabat01 = new Bil("2345",true,new DateTime(2017,09,03),false,false);
        //    // Act
        //    int hvilkenrabat = weekendRabat01.WeekendRabatter();
        //    // Assert
        //    // Bilen har brobizz og køre over en søndag
        //    Assert.AreEqual(310,hvilkenrabat);
        //}
    }
}