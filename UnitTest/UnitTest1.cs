using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Movies_Rental;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Database db = new Database(); // DATABASE CONNECTION 
        [TestMethod]
        public void TestMethod1() // Test method
        {
           
          
            {
                string nameDB = db.Checkdb(); /// expected value for database connection
                Assert.AreEqual(nameDB,"VBMOVIESFULLDATA.MDF"); // actual value for database connection 
            }


        }
        [TestMethod]
        public void testOldrentalcost()
        {
           // var oldDate = DateTime.Today.AddYears(-6).Year.ToString();
         //   Assert.AreEqual(2, _db.GetrentalCost(oldDate));
        }

    }
}

