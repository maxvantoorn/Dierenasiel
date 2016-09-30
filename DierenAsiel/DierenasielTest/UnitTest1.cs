using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DierenAsiel;

namespace DierenasielTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCat()
        {
            

            Reservation reservation = new Reservation();
            reservation.newCat("jantje", Gender.male, "haha");
            Assert.IsNotNull(reservation.cat);
            
        }

        [TestMethod]
        public void TestDog()
        {


            Reservation reservation = new Reservation();
            reservation.newDog("Gerard", Gender.female, DateTime.Today);
            Assert.IsNotNull(reservation.dog);

        }
    }
}
