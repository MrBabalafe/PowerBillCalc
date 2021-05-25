using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerData;

namespace CustomerDataTests {
    [TestClass()]
    public class CommercialCustomerTests {

        [TestMethod()]
        public void CalculateCharge0Hours() {
            //Arrange
            CommercialCustomer customer;
            decimal expectedCharge = 60m;
            decimal actualCharge;

            //Act
            customer = new CommercialCustomer(1, "Bob");
            actualCharge = customer.CalculateCharge(0);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateCharge1000Hours() {
            //Arrange
            CommercialCustomer customer;
            decimal expectedCharge = 60m;
            decimal actualCharge;

            //Act
            customer = new CommercialCustomer(1, "Bob");
            actualCharge = customer.CalculateCharge(1000);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateCharge1100Hours() {
            //Arrange
            CommercialCustomer customer;
            decimal expectedCharge = 64.50m;
            decimal actualCharge;

            //Act
            customer = new CommercialCustomer(1, "Bob");
            actualCharge = customer.CalculateCharge(1100);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

    }
}
