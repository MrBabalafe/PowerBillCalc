using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerData;

namespace CustomerDataTests {
    [TestClass()]
    public class ResidentialCustomerTests {

        [TestMethod()]
        public void CalculateCharge0Hours() {
            //Arrange
            ResidentialCustomer customer;
            decimal expectedCharge = 6m;

            decimal actualCharge;

            //Act
            customer = new ResidentialCustomer(1, "Bob Smith");
            actualCharge = customer.CalculateCharge(0);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateCharge10Hours() {
            //Arrange
            ResidentialCustomer customer;
            decimal expectedCharge = 6.52m;

            decimal actualCharge;

            //Act
            customer = new ResidentialCustomer(1, "Bob Smith");
            actualCharge = customer.CalculateCharge(10);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateCharge1000Hours() {
            //Arrange
            ResidentialCustomer customer;
            decimal expectedCharge = 58m;

            decimal actualCharge;

            //Act
            customer = new ResidentialCustomer(1, "Bob Smith");
            actualCharge = customer.CalculateCharge(1000);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

    }
}
