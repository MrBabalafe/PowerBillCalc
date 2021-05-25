using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerData;

namespace CustomerDataTests {
    [TestClass()]
    public class IndustrialCustomerTests {

        [TestMethod()]
        public void CalculateCharge0P0O() {
            //Arrange
            IndustrialCustomer customer;
            decimal expectedCharge = 116m;
            decimal actualCharge;

            //Act
            customer = new IndustrialCustomer(1, "Bob");
            actualCharge = customer.CalculateCharge(0, 0);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateCharge1000P0O() {
            //Arrange
            IndustrialCustomer customer;
            decimal expectedCharge = 116m;
            decimal actualCharge;

            //Act
            customer = new IndustrialCustomer(1, "Bob");
            actualCharge = customer.CalculateCharge(0, 1000);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateCharge1100P1100O() {
            //Arrange
            IndustrialCustomer customer;
            decimal expectedCharge = 125.30m;
            decimal actualCharge;

            //Act
            customer = new IndustrialCustomer(1, "Bob");
            actualCharge = customer.CalculateCharge(1100, 1100);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

    }
}
